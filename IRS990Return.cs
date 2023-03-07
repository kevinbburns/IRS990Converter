using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using JsonConverter = Newtonsoft.Json.JsonConverter;
using JsonConverterAttribute = Newtonsoft.Json.JsonConverterAttribute;
using System.Text;
using JsonFlatten;

public class SingleOrArrayConverter<T> : JsonConverter
{
    public override bool CanConvert(Type dynamicType)
    {
        return (dynamicType == typeof(List<T>));
    }

    public override dynamic ReadJson(JsonReader reader, Type dynamicType,
        dynamic existingValue, JsonSerializer serializer)
    {
        try
        {
            serializer.Formatting = Formatting.Indented;
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Array)
            {
                return token.ToObject<List<T>>();
            }

            return new List<T> {token.ToObject<T>()};
        }
        catch (Exception ex)
        {
            try
            {
                var s = !string.IsNullOrEmpty(reader.Value.ToString()) ? reader.Value.ToString().Trim() : "";
                return new List<string> {s};
            }
            catch
            {
                return new List<string>();
            }
        }
    }

    public override bool CanWrite
    {
        get { return true; }
    }

    public override void WriteJson(JsonWriter writer, dynamic value,
        JsonSerializer serializer)
    {
        var vList = (List<T>) value;
        if (!vList.Any())
            return;

        var vName = vList.FirstOrDefault().GetType().Name;

        //JToken token = JToken.Fromdynamic(value);
        var jobArrayString = JsonConvert.SerializeObject(value, Formatting.None);
        var jObjArray = JsonConvert.DeserializeObject<JObject[]>(jobArrayString);

        var sb = new StringBuilder();
        sb.Append(@"{" + $"\"{vName}\":\"");

        var nL = System.Environment.NewLine;

        foreach (JObject n in jObjArray)
        {
            var flat = n.Flatten();
            var s = JsonConvert.SerializeObject(flat);
            s = s.Replace(@""",""", nL)
                .Replace(@"""}", nL)
                .Replace("{", "")
                .Replace("}", "")
                .Replace(@"""", "")
                .Replace(",", nL);

            sb.Append(s.Trim());
        }

        sb.Append(@"""}");
        var retStr = sb.ToString();

        var jObj = JObject.Parse(retStr);
        jObj.WriteTo(writer);
    }
}


public class FixScrewedUpString : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return (objectType == typeof(string));
    }

    public override object ReadJson(JsonReader reader, Type dynamicType,
        object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null)
            return null;

        try
        {
            JToken jt = JToken.Load(reader);
            string s = jt.Value<string>();

            if (s.Contains("#text"))
            {
                try
                {
                    var jsonError = JsonConvert
                        .DeserializeObject<JsonErrorStringValue>(s);
                    if (jsonError != null)
                    {
                        return jsonError.Text;
                    }
                    else
                    {
                        return s;
                    }
                }
                catch
                {
                    try
                    {
                        return s;
                    }
                    catch
                    {
                        return null;
                    }
                }
            }
            else
            {
                return s;
            }
        }
        catch
        {
            try
            {
                var s = reader.Value as string;
                if (string.IsNullOrEmpty(s))
                    return "";

                JObject jObj = JObject.Parse(s);
                var jsonError = jObj.ToObject<JsonErrorStringValue>();
                try
                {
                    if (jsonError != null)
                    {
                        return jsonError.Text;
                    }
                    else
                    {
                        return jObj.ToString();
                    }
                }
                catch (Exception middleInnerExp)
                {
                    return s;
                }
            }
            catch (Exception ex)
            {
                var m = ex.Message;
                return "";
            }
        }
    }

    public override bool CanWrite
    {
        get { return false; }
    }

    public override void WriteJson(JsonWriter writer, dynamic value, JsonSerializer serializer)
    {
        JObject j = JObject.FromObject(value);
        j.WriteTo(writer);
    }
}


public class JsonErrorStringValue
{
    [JsonPropertyName("@referenceDocumentId")]
    public string ReferenceDocumentId { get; set; }

    [JsonPropertyName("#text")] public string Text { get; set; }
}


public class AccountActivitiesOutsideUSGrp
{
    [JsonPropertyName("RegionTxt")] public string RegionTxt { get; set; }

    [JsonPropertyName("OfficesCnt")] public string OfficesCnt { get; set; }

    [JsonPropertyName("EmployeeCnt")] public string EmployeeCnt { get; set; }

    [JsonPropertyName("TypeOfActivitiesConductedTxt")]
    public string TypeOfActivitiesConductedTxt { get; set; }

    [JsonPropertyName("SpecificServicesProvidedTxt")]
    public string SpecificServicesProvidedTxt { get; set; }

    [JsonPropertyName("RegionTotalExpendituresAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RegionTotalExpendituresAmt { get; set; }
}

public class AccountingFeesDetail
{
    [JsonPropertyName("CategoryTxt")] public string CategoryTxt { get; set; }

    [JsonPropertyName("Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Amt { get; set; }

    [JsonPropertyName("NetInvestmentIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetInvestmentIncomeAmt { get; set; }

    [JsonPropertyName("DisbursementsCharitablePrpsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DisbursementsCharitablePrpsAmt { get; set; }

    [JsonPropertyName("AdjustedNetIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdjustedNetIncomeAmt { get; set; }
}


public class AccountingFeesSchedule
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("AccountingFeesDetail")]
    public AccountingFeesDetail AccountingFeesDetail { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class AccountsPayableAccrExpnssGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }
}

public class AccountsReceivableGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class AcctCompileOrReviewBasisGrp
{
    [JsonPropertyName("SeparateBasisFinclStmtInd")
     , JsonConverter(typeof(FixScrewedUpString))]
    public string SeparateBasisFinclStmtInd { get; set; }

    [JsonPropertyName("ConsolidatedBasisFinclStmtInd")
     , JsonConverter(typeof(FixScrewedUpString))]
    public string ConsolidatedBasisFinclStmtInd { get; set; }

    [JsonPropertyName("ConsolAndSepBasisFinclStmtInd")]
    [JsonConverter(typeof(FixScrewedUpString))]
    public string ConsolAndSepBasisFinclStmtInd { get; set; }
}

public class AcquisitionIndebtednessGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class ActyNotPreviouslyRptExpln
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("ExplanationTxt")] public string ExplanationTxt { get; set; }
}

public class AdjustedFMVLessIndebtednessGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class AdjustedGroRssIncomeGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class AdjustedNetIncomeGrp
{
    [JsonPropertyName("NetSTCapitalGainAdjNetIncmGrp"),JsonConverter(typeof(SingleOrArrayConverter<NetSTCapitalGainAdjNetIncmGrp>))]
    public List<NetSTCapitalGainAdjNetIncmGrp> NetSTCapitalGainAdjNetIncmGrp { get; set; }

    [JsonPropertyName("RecoveriesPYDistributionsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<RecoveriesPYDistributionsGrp>))]
    public List<RecoveriesPYDistributionsGrp> RecoveriesPYDistributionsGrp { get; set; }

    [JsonPropertyName("OtherGrossIncomeGrp"),  JsonConverter(typeof(SingleOrArrayConverter<OtherGrossIncomeGrp>))]
    public List<OtherGrossIncomeGrp> OtherGrossIncomeGrp { get; set; }

    [JsonPropertyName("AdjustedGrossIncomeGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<AdjustedGrossIncomeGrp>))]
    public List<AdjustedGrossIncomeGrp> AdjustedGrossIncomeGrp { get; set; }

    [JsonPropertyName("DepreciationDepletionGrp"),  JsonConverter(typeof(SingleOrArrayConverter<DepreciationDepletionGrp>))]
    public List<DepreciationDepletionGrp> DepreciationDepletionGrp { get; set; }

    [JsonPropertyName("ProductionIncomeGrp"),  JsonConverter(typeof(SingleOrArrayConverter<ProductionIncomeGrp>))]
    public List<ProductionIncomeGrp> ProductionIncomeGrp { get; set; }

    [JsonPropertyName("OtherExpensesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<OtherExpensesGrp>))] 
    public List<OtherExpensesGrp> OtherExpensesGrp { get; set; }

    [JsonPropertyName("TotalAdjustedNetIncomeGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalAdjustedNetIncomeGrp>))]
    public List<TotalAdjustedNetIncomeGrp> TotalAdjustedNetIncomeGrp { get; set; }
}

public class AdjustedGrossIncomeGrp
{
    [JsonPropertyName("PriorYearAmt")] public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt")] public string CurrentYearAmt { get; set; }
}


public class AdvertisingGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class AffiliatedGroupAttachment
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("MeduimExplanationTxt")]
    public string MeduimExplanationTxt { get; set; }
}

public class AffiliatedGroupSchedule
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("AffiliatedScheduleGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<AffiliatedScheduleGrp>))]
    public List<AffiliatedScheduleGrp> AffiliatedScheduleGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class AffiliatedScheduleGrp
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("EIN")] public string EIN { get; set; }

    [JsonPropertyName("ElectingOrganizationInd")]
    [JsonConverter(typeof(FixScrewedUpString))]
    public string ElectingOrganizationInd { get; set; }

    [JsonPropertyName("TotalGrassrootsLobbyAmt"),
     JsonConverter(typeof(FixScrewedUpString))]
    public string TotalGrassrootsLobbyAmt { get; set; }

    [JsonPropertyName("TotalDirectLobbyAmt"),
     JsonConverter(typeof(FixScrewedUpString))]
    public string TotalDirectLobbyAmt { get; set; }

    [JsonPropertyName("TotalLobbyExpenditureAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalLobbyExpenditureAmt { get; set; }

    [JsonPropertyName("OtherExemptPurposeExpendAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherExemptPurposeExpendAmt { get; set; }

    [JsonPropertyName("TotalExemptPurposeExpendAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalExemptPurposeExpendAmt { get; set; }

    [JsonPropertyName("LobbyNontxAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LobbyNontxAmt { get; set; }

    [JsonPropertyName("GrassrootsNontxAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrassrootsNontxAmt { get; set; }

    [JsonPropertyName("TotalLobbyGrssrootMnsNontxAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalLobbyGrssrootMnsNontxAmt { get; set; }

    [JsonPropertyName("TotLbbyExpendMnsLobbyNontxAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotLbbyExpendMnsLobbyNontxAmt { get; set; }

    [JsonPropertyName("ShareExcessLobbyExpendAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ShareExcessLobbyExpendAmt { get; set; }
}

public class AffiliateListing
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("AffiliateListingGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<AffiliatedScheduleGrp>))]
    public List<AffiliateListingGrp> AffiliateListingGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class AffiliateListingGrp
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("EIN")] public string EIN { get; set; }

    [JsonPropertyName("BusinessNameControlTxt")]
    public string BusinessNameControlTxt { get; set; }
}

public class AgriculturalNameAndAddressGrp
{
    [JsonPropertyName("CollegeUniversityName")]
    public CollegeUniversityName CollegeUniversityName { get; set; }

    [JsonPropertyName("CityNm")] public string CityNm { get; set; }

    [JsonPropertyName("StateAbbreviationCd")]
    public string StateAbbreviationCd { get; set; }
}

public class AllOtherExpensesGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class AllOtherProgramRelatedInvstGrp
{
    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Amt { get; set; }
}

public class AllOthProgRltdInvestmentsSch
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("AllOtherProgramRelatedInvstGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<AllOtherProgramRelatedInvstGrp>))]
    public List<AllOtherProgramRelatedInvstGrp> AllOtherProgramRelatedInvstGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class AmortizationSchedule
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("AmortizationScheduleDetail")]
    public AmortizationScheduleDetail AmortizationScheduleDetail { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class AmortizationScheduleDetail
{
    [JsonPropertyName("AmortizedExpensesDesc")]
    public string AmortizedExpensesDesc { get; set; }

    [JsonPropertyName("AcquiredCompletedOrExpendedDt")]
    public string AcquiredCompletedOrExpendedDt { get; set; }

    [JsonPropertyName("AmortizedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AmortizedAmt { get; set; }

    [JsonPropertyName("DeductionForPriorYearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DeductionForPriorYearsAmt { get; set; }

    [JsonPropertyName("AmortizationPeriodRt")]
    public string AmortizationPeriodRt { get; set; }

    [JsonPropertyName("CurrentYearAmortizationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmortizationAmt { get; set; }

    [JsonPropertyName("NetInvestmentIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetInvestmentIncomeAmt { get; set; }

    [JsonPropertyName("AdjustedNetIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdjustedNetIncomeAmt { get; set; }

    [JsonPropertyName("TotalAmortizationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmortizationAmt { get; set; }
}

public class AmountsRcvdDsqlfyPersonGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }
}

public class AnalysisIncomeProducingActyGrp
{
    [JsonPropertyName("DivAndIntFromSecPartVIIGrp"),  JsonConverter(typeof(SingleOrArrayConverter<DivAndIntFromSecPartVIIGrp>))]
    public List<DivAndIntFromSecPartVIIGrp> DivAndIntFromSecPartVIIGrp { get; set; }

    [JsonPropertyName("SubtotalsIncmProducingActyGrp"),  JsonConverter(typeof(SingleOrArrayConverter<SubtotalsIncmProducingActyGrp>))]
    public List<SubtotalsIncmProducingActyGrp> SubtotalsIncmProducingActyGrp { get; set; }

    [JsonPropertyName("TotalIncomeProducingActyAmt"), 
     JsonConverter(typeof(FixScrewedUpString))]
    public string TotalIncomeProducingActyAmt { get; set; }

    [JsonPropertyName("IntOnSavAndTempCashInvstGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> IntOnSavAndTempCashInvstGrp { get; set; }

    [JsonPropertyName("GainSalesAstOthThanInvntryGrp"),  JsonConverter(typeof(SingleOrArrayConverter<GainSalesAstOthThanInvntryGrp>))]
    public List<GainSalesAstOthThanInvntryGrp> GainSalesAstOthThanInvntryGrp { get; set; }

    [JsonPropertyName("OtherInvestmentIncmPartVIIGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> OtherInvestmentIncmPartVIIGrp { get; set; }

    [JsonPropertyName("FeesContractsFromGovtAgGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> FeesContractsFromGovtAgGrp { get; set; }

    [JsonPropertyName("MembershipDuesAndAssmntGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> MembershipDuesAndAssmntGrp { get; set; }

    [JsonPropertyName("NetRntlIncmReDebtFincdPropGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> NetRntlIncmReDebtFincdPropGrp { get; set; }

    [JsonPropertyName("NetRntlIncmReNotDebtFincdProp")]
    public List<dynamic> NetRntlIncmReNotDebtFincdProp { get; set; }

    [JsonPropertyName("NetRentalIncomePersonalPropGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> NetRentalIncomePersonalPropGrp { get; set; }

    [JsonPropertyName("NetIncomeLossFromSpecialEvtGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> NetIncomeLossFromSpecialEvtGrp { get; set; }

    [JsonPropertyName("GrossProfitLossSlsOfInvntryGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> GrossProfitLossSlsOfInvntryGrp { get; set; }

    [JsonPropertyName("ProgramServiceRevPartVIIGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<ProgramServiceRevPartVIIGrp>))]
    public List<ProgramServiceRevPartVIIGrp> ProgramServiceRevPartVIIGrp { get; set; }

    [JsonPropertyName("OtherRevenueDescribedGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<OtherRevenueDescribedGrp>))]
    public List<OtherRevenueDescribedGrp> OtherRevenueDescribedGrp { get; set; }
}

public class AnalysisOfRevenueAndExpenses
{
    [JsonPropertyName("ContriRcvdRevAndExpnssAmt")
     , JsonConverter(typeof(FixScrewedUpString))]
    public string ContriRcvdRevAndExpnssAmt { get; set; }

    [JsonPropertyName("ScheduleBNotRequiredInd")
     , JsonConverter(typeof(FixScrewedUpString))]
    public string ScheduleBNotRequiredInd { get; set; }

    [JsonPropertyName("DividendsRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DividendsRevAndExpnssAmt { get; set; }

    [JsonPropertyName("DividendsNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DividendsNetInvstIncmAmt { get; set; }

    [JsonPropertyName("GrossRentsRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossRentsRevAndExpnssAmt { get; set; }

    [JsonPropertyName("GrossRentsNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossRentsNetInvstIncmAmt { get; set; }

    [JsonPropertyName("NetRentalIncomeOrLossAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetRentalIncomeOrLossAmt { get; set; }

    [JsonPropertyName("NetGainSaleAstRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetGainSaleAstRevAndExpnssAmt { get; set; }

    [JsonPropertyName("GrossSalesPriceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossSalesPriceAmt { get; set; }

    [JsonPropertyName("CapGainNetIncmNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CapGainNetIncmNetInvstIncmAmt { get; set; }

    [JsonPropertyName("OtherIncomeRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherIncomeRevAndExpnssAmt { get; set; }

    [JsonPropertyName("OtherIncomeNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherIncomeNetInvstIncmAmt { get; set; }

    [JsonPropertyName("TotalRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRevAndExpnssAmt { get; set; }

    [JsonPropertyName("TotalNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalNetInvstIncmAmt { get; set; }

    [JsonPropertyName("CompOfcrDirTrstRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompOfcrDirTrstRevAndExpnssAmt { get; set; }

    [JsonPropertyName("CompOfcrDirTrstNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompOfcrDirTrstNetInvstIncmAmt { get; set; }

    [JsonPropertyName("CompOfcrDirTrstDsbrsChrtblAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompOfcrDirTrstDsbrsChrtblAmt { get; set; }

    [JsonPropertyName("OthEmplSlrsWgsRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OthEmplSlrsWgsRevAndExpnssAmt { get; set; }

    [JsonPropertyName("OthEmplSlrsWgsNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OthEmplSlrsWgsNetInvstIncmAmt { get; set; }

    [JsonPropertyName("OthEmplSlrsWgsDsbrsChrtblAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OthEmplSlrsWgsDsbrsChrtblAmt { get; set; }

    [JsonPropertyName("PensionEmplBnftRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PensionEmplBnftRevAndExpnssAmt { get; set; }

    [JsonPropertyName("PensionEmplBnftNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PensionEmplBnftNetInvstIncmAmt { get; set; }

    [JsonPropertyName("PensionEmplBnftDsbrsChrtblAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PensionEmplBnftDsbrsChrtblAmt { get; set; }

    [JsonPropertyName("LegalFeesRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LegalFeesRevAndExpnssAmt { get; set; }

    [JsonPropertyName("LegalFeesNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LegalFeesNetInvstIncmAmt { get; set; }

    [JsonPropertyName("LegalFeesDsbrsChrtblAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LegalFeesDsbrsChrtblAmt { get; set; }

    [JsonPropertyName("AccountingFeesRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AccountingFeesRevAndExpnssAmt { get; set; }

    [JsonPropertyName("AccountingFeesNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AccountingFeesNetInvstIncmAmt { get; set; }

    [JsonPropertyName("AccountingFeesChrtblPrpsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AccountingFeesChrtblPrpsAmt { get; set; }

    [JsonPropertyName("OtherProfFeesRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherProfFeesRevAndExpnssAmt { get; set; }

    [JsonPropertyName("OtherProfFeesNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherProfFeesNetInvstIncmAmt { get; set; }

    [JsonPropertyName("OtherProfFeesDsbrsChrtblAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherProfFeesDsbrsChrtblAmt { get; set; }

    [JsonPropertyName("TaxesRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxesRevAndExpnssAmt { get; set; }

    [JsonPropertyName("TaxesNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxesNetInvstIncmAmt { get; set; }

    [JsonPropertyName("TaxesDsbrsChrtblAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxesDsbrsChrtblAmt { get; set; }

    [JsonPropertyName("DeprecAndDpltnRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DeprecAndDpltnRevAndExpnssAmt { get; set; }

    [JsonPropertyName("DeprecAndDpltnNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DeprecAndDpltnNetInvstIncmAmt { get; set; }

    [JsonPropertyName("OccupancyRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OccupancyRevAndExpnssAmt { get; set; }

    [JsonPropertyName("OccupancyNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OccupancyNetInvstIncmAmt { get; set; }

    [JsonPropertyName("OccupancyDsbrsChrtblAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OccupancyDsbrsChrtblAmt { get; set; }

    [JsonPropertyName("TravConfMeetingRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TravConfMeetingRevAndExpnssAmt { get; set; }

    [JsonPropertyName("TravConfMeetingNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TravConfMeetingNetInvstIncmAmt { get; set; }

    [JsonPropertyName("TravConfMeetingDsbrsChrtblAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TravConfMeetingDsbrsChrtblAmt { get; set; }

    [JsonPropertyName("PrintingAndPubRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PrintingAndPubRevAndExpnssAmt { get; set; }

    [JsonPropertyName("PrintingAndPubNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PrintingAndPubNetInvstIncmAmt { get; set; }

    [JsonPropertyName("PrintingAndPubDsbrsChrtblAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PrintingAndPubDsbrsChrtblAmt { get; set; }

    [JsonPropertyName("OtherExpensesRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherExpensesRevAndExpnssAmt { get; set; }

    [JsonPropertyName("OtherExpensesNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherExpensesNetInvstIncmAmt { get; set; }

    [JsonPropertyName("OtherExpensesDsbrsChrtblAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherExpensesDsbrsChrtblAmt { get; set; }

    [JsonPropertyName("TotOprExpensesRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotOprExpensesRevAndExpnssAmt { get; set; }

    [JsonPropertyName("TotOprExpensesNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotOprExpensesNetInvstIncmAmt { get; set; }

    [JsonPropertyName("TotOprExpensesDsbrsChrtblAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotOprExpensesDsbrsChrtblAmt { get; set; }

    [JsonPropertyName("ContriPaidRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ContriPaidRevAndExpnssAmt { get; set; }

    [JsonPropertyName("ContriPaidDsbrsChrtblAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ContriPaidDsbrsChrtblAmt { get; set; }

    [JsonPropertyName("TotalExpensesRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalExpensesRevAndExpnssAmt { get; set; }

    [JsonPropertyName("TotalExpensesNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalExpensesNetInvstIncmAmt { get; set; }

    [JsonPropertyName("TotalExpensesDsbrsChrtblAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalExpensesDsbrsChrtblAmt { get; set; }

    [JsonPropertyName("ExcessRevenueOverExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessRevenueOverExpensesAmt { get; set; }

    [JsonPropertyName("NetInvestmentIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetInvestmentIncomeAmt { get; set; }

    [JsonPropertyName("TotalAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAdjNetIncmAmt { get; set; }

    [JsonPropertyName("CompOfcrDirTrstAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompOfcrDirTrstAdjNetIncmAmt { get; set; }

    [JsonPropertyName("TotOprExpensesAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotOprExpensesAdjNetIncmAmt { get; set; }

    [JsonPropertyName("TotalExpensesAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalExpensesAdjNetIncmAmt { get; set; }

    [JsonPropertyName("AdjustedNetIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdjustedNetIncomeAmt { get; set; }

    [JsonPropertyName("InterestOnSavRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InterestOnSavRevAndExpnssAmt { get; set; }

    [JsonPropertyName("InterestOnSavNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InterestOnSavNetInvstIncmAmt { get; set; }

    [JsonPropertyName("InterestOnSavingsAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InterestOnSavingsAdjNetIncmAmt { get; set; }

    [JsonPropertyName("DividendsAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DividendsAdjNetIncmAmt { get; set; }

    [JsonPropertyName("InterestRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InterestRevAndExpnssAmt { get; set; }

    [JsonPropertyName("NetSTCapitalGainAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetSTCapitalGainAdjNetIncmAmt { get; set; }

    [JsonPropertyName("OthEmplSlrsWgsAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OthEmplSlrsWgsAdjNetIncmAmt { get; set; }

    [JsonPropertyName("PensionEmplBnftAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PensionEmplBnftAdjNetIncmAmt { get; set; }

    [JsonPropertyName("InterestDsbrsChrtblAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InterestDsbrsChrtblAmt { get; set; }

    [JsonPropertyName("TravConfMeetingAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TravConfMeetingAdjNetIncmAmt { get; set; }

    [JsonPropertyName("PrintingAndPubAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PrintingAndPubAdjNetIncmAmt { get; set; }

    [JsonPropertyName("OtherIncomeAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherIncomeAdjNetIncmAmt { get; set; }

    [JsonPropertyName("AccountingFeesAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AccountingFeesAdjNetIncmAmt { get; set; }

    [JsonPropertyName("InterestNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InterestNetInvstIncmAmt { get; set; }

    [JsonPropertyName("InterestAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InterestAdjNetIncmAmt { get; set; }

    [JsonPropertyName("TaxesAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxesAdjNetIncmAmt { get; set; }

    [JsonPropertyName("DeprecAndDpltnAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DeprecAndDpltnAdjNetIncmAmt { get; set; }

    [JsonPropertyName("OccupancyAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OccupancyAdjNetIncmAmt { get; set; }

    [JsonPropertyName("OtherExpensesAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherExpensesAdjNetIncmAmt { get; set; }

    [JsonPropertyName("GrossSalesLessRetAndAllwncAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossSalesLessRetAndAllwncAmt { get; set; }

    [JsonPropertyName("CostOfGoodsSoldAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CostOfGoodsSoldAmt { get; set; }

    [JsonPropertyName("GrossProfitRevAndExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossProfitRevAndExpnssAmt { get; set; }

    [JsonPropertyName("GrossProfitAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossProfitAdjNetIncmAmt { get; set; }

    [JsonPropertyName("OtherProfFeesAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherProfFeesAdjNetIncmAmt { get; set; }

    [JsonPropertyName("LegalFeesAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LegalFeesAdjNetIncmAmt { get; set; }

    [JsonPropertyName("GrossRentsAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossRentsAdjNetIncmAmt { get; set; }

    [JsonPropertyName("IncmModificationsAdjNetIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string IncmModificationsAdjNetIncmAmt { get; set; }
}

public class ApplicationSubmissionInfoGrp
{
    [JsonPropertyName("RecipientPersonNm")]
    public string RecipientPersonNm { get; set; }

    [JsonPropertyName("RecipientUSAddress")]
    public RecipientUSAddress RecipientUSAddress { get; set; }

    [JsonPropertyName("RecipientPhoneNum")]
    public string RecipientPhoneNum { get; set; }

    [JsonPropertyName("FormAndInfoAndMaterialsTxt")]
    public string FormAndInfoAndMaterialsTxt { get; set; }

    [JsonPropertyName("SubmissionDeadlinesTxt")]
    public string SubmissionDeadlinesTxt { get; set; }

    [JsonPropertyName("RestrictionsOnAwardsTxt")]
    public string RestrictionsOnAwardsTxt { get; set; }

    [JsonPropertyName("RecipientEmailAddressTxt")]
    public string RecipientEmailAddressTxt { get; set; }
}

public class AppliedToPriorYearElection
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("ElectionDesc")] public string ElectionDesc { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}


public class AverageMonthlyCashBalancesGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class AverageMonthlyFMVOfSecGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class AveragingAttachment
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("ExplanationTxt")] public string ExplanationTxt { get; set; }
}

public class AvgGrassrootsLobbyingExpendGrp
{
    [JsonPropertyName("CurrentYearMinus3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearMinus3Amt { get; set; }

    [JsonPropertyName("CurrentYearMinus2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearMinus2Amt { get; set; }

    [JsonPropertyName("CurrentYearMinus1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearMinus1Amt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class AvgGrassrootsNontaxableGrp
{
    [JsonPropertyName("CurrentYearMinus3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearMinus3Amt { get; set; }

    [JsonPropertyName("CurrentYearMinus2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearMinus2Amt { get; set; }

    [JsonPropertyName("CurrentYearMinus1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearMinus1Amt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class AvgLobbyingNontaxableAmountGrp
{
    [JsonPropertyName("CurrentYearMinus3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearMinus3Amt { get; set; }

    [JsonPropertyName("CurrentYearMinus2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearMinus2Amt { get; set; }

    [JsonPropertyName("CurrentYearMinus1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearMinus1Amt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class AvgTotalLobbyingExpendGrp
{
    [JsonPropertyName("CurrentYearMinus3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearMinus3Amt { get; set; }

    [JsonPropertyName("CurrentYearMinus2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearMinus2Amt { get; set; }

    [JsonPropertyName("CurrentYearMinus1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearMinus1Amt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class BenefitsToMembersGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }
}

public class BooksInCareOfDetail
{
    [JsonPropertyName("PersonNm")] public string PersonNm { get; set; }

    [JsonPropertyName("PhoneNum")] public string PhoneNum { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("ForeignAddress")] public ForeignAddress ForeignAddress { get; set; }
}

public class BorrowedFundsElection
{
    [JsonPropertyName("@documentId")] 
    public string DocumentId { get; set; }

    [JsonPropertyName("BorrowedFundsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<BorrowedFundsGrp>))] 
    public List<BorrowedFundsGrp> BorrowedFundsGrp { get; set; }
}

public class BorrowedFundsGrp
{
    [JsonPropertyName("PersonNm")] public string PersonNm { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("BorrowedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BorrowedAmt { get; set; }
}

public class BorrowerNameGrp
{
    [JsonPropertyName("PersonNm")] public string PersonNm { get; set; }

    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }
}

public class BuildingsGrp
{
    [JsonPropertyName("OtherCostOrOtherBasisAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherCostOrOtherBasisAmt { get; set; }

    [JsonPropertyName("BookValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BookValueAmt { get; set; }

    [JsonPropertyName("InvestmentCostOrOtherBasisAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvestmentCostOrOtherBasisAmt { get; set; }

    [JsonPropertyName("DepreciationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DepreciationAmt { get; set; }
}

public class BusinessName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }

    [JsonPropertyName("BusinessNameLine2Txt")]
    public string BusinessNameLine2Txt { get; set; }
}

public class BusinessOfficerGrp
{
    [JsonPropertyName("PersonNm")] public string PersonNm { get; set; }

    [JsonPropertyName("PersonTitleTxt")] public string PersonTitleTxt { get; set; }

    [JsonPropertyName("PhoneNum")] public string PhoneNum { get; set; }

    [JsonPropertyName("SignatureDt")] public string SignatureDt { get; set; }

    [JsonPropertyName("DiscussWithPaidPreparerInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DiscussWithPaidPreparerInd { get; set; }
}

public class BusTrInvolveInterestedPrsnGrp
{
    [JsonPropertyName("NameOfInterested")] public NameOfInterested NameOfInterested { get; set; }

    [JsonPropertyName("RelationshipDescriptionTxt")]
    public string RelationshipDescriptionTxt { get; set; }

    [JsonPropertyName("TransactionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TransactionAmt { get; set; }

    [JsonPropertyName("TransactionDesc")] public string TransactionDesc { get; set; }

    [JsonPropertyName("SharingOfRevenuesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SharingOfRevenuesInd { get; set; }
}

public class CapGainsLossTxInvstIncmDetail
{
    [JsonPropertyName("CapGainsLossTxInvstIncmGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<CapGainsLossTxInvstIncmGrp>))]
    public List<CapGainsLossTxInvstIncmGrp> CapGainsLossTxInvstIncmGrp { get; set; }

    [JsonPropertyName("CapitalGainNetIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CapitalGainNetIncomeAmt { get; set; }

    [JsonPropertyName("NetShortTermCapitalGainLossAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetShortTermCapitalGainLossAmt { get; set; }
}

public class CapGainsLossTxInvstIncmGrp
{
    [JsonPropertyName("PropertyDesc")] public string PropertyDesc { get; set; }

    [JsonPropertyName("AcquiredDt")] public string AcquiredDt { get; set; }

    [JsonPropertyName("SoldDt")] public string SoldDt { get; set; }

    [JsonPropertyName("GrossSalesPriceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossSalesPriceAmt { get; set; }

    [JsonPropertyName("GainOrLossAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GainOrLossAmt { get; set; }

    [JsonPropertyName("GainsMinusExcessOrLossesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GainsMinusExcessOrLossesAmt { get; set; }

    [JsonPropertyName("CostOrOtherBasisAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CostOrOtherBasisAmt { get; set; }
}

public class CapStkTrPrinCurrentFundsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class CashAndInKindContributionsGrp
{
    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }
}

public class CashDeemedCharitableExplnStmt
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("ShortExplanationTxt")]
    public string ShortExplanationTxt { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }
}

public class CashDeemedCharitableGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class CashDistributionExplnStmt
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }

    [JsonPropertyName("ExplanationTxt")] public string ExplanationTxt { get; set; }
}

public class CashNonInterestBearingGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class CashSavingsAndInvestmentsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class CharitableContributionsDetail
{
    [JsonPropertyName("ContributorNum")] public string ContributorNum { get; set; }

    [JsonPropertyName("GiftPurposeTxt")] public string GiftPurposeTxt { get; set; }

    [JsonPropertyName("GiftUseTxt")] public string GiftUseTxt { get; set; }

    [JsonPropertyName("HowGiftIsHeldDesc")]
    public string HowGiftIsHeldDesc { get; set; }

    [JsonPropertyName("RlnOfTransferorToTransfereeTxt")]
    public string RlnOfTransferorToTransfereeTxt { get; set; }
}

public class ChgInNetAssetsFundBalancesGrp
{
    [JsonPropertyName("TotNetAstOrFundBalancesBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotNetAstOrFundBalancesBOYAmt { get; set; }

    [JsonPropertyName("ExcessRevenueOverExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessRevenueOverExpensesAmt { get; set; }

    [JsonPropertyName("OtherIncreasesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherIncreasesAmt { get; set; }

    [JsonPropertyName("SubtotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SubtotalAmt { get; set; }

    [JsonPropertyName("OtherDecreasesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherDecreasesAmt { get; set; }

    [JsonPropertyName("TotNetAstOrFundBalancesEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotNetAstOrFundBalancesEOYAmt { get; set; }
}

public class CloselyHeldEquityInterestsGrp
{
    [JsonPropertyName("BookValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BookValueAmt { get; set; }

    [JsonPropertyName("MethodValuationCd")]
    public string MethodValuationCd { get; set; }
}

public class CoalitionBuildingGrp
{
    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }
}

public class CollectionUsedOtherPurposesGrp
{
    [JsonPropertyName("CollectionUsedOtherPurposesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CollectionUsedOtherPurposesInd { get; set; }

    [JsonPropertyName("OtherPurposesDesc")]
    public string OtherPurposesDesc { get; set; }
}

public class CollegeUniversityName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }
}

public class CommunityHealthServicesGrp
{
    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }
}

public class CommunitySupportGrp
{
    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }
}

public class CompCurrentOfcrDirectorsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class CompDisqualPersonsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class CompensationExplanation
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("CompensationExplanationGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<CompensationExplanationGrp>))]
    public List<CompensationExplanationGrp> CompensationExplanationGrp { get; set; }
}

public class CompensationExplanationGrp
{
    [JsonPropertyName("PersonNm")] public string PersonNm { get; set; }

    [JsonPropertyName("ShortExplanationTxt")]
    public string ShortExplanationTxt { get; set; }
}

public class CompensationHighestPaidEmplGrp
{
    [JsonPropertyName("PersonNm")] public string PersonNm { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("TitleTxt")] public string TitleTxt { get; set; }

    [JsonPropertyName("AverageHrsPerWkDevotedToPosRt")]
    public string AverageHrsPerWkDevotedToPosRt { get; set; }

    [JsonPropertyName("CompensationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompensationAmt { get; set; }

    [JsonPropertyName("EmployeeBenefitsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EmployeeBenefitsAmt { get; set; }

    [JsonPropertyName("ExpenseAccountAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExpenseAccountAmt { get; set; }

    [JsonPropertyName("AverageHoursPerWeekRt")]
    public string AverageHoursPerWeekRt { get; set; }
}

public class CompensationOfHghstPdCntrctGrp
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("ServiceTypeTxt")] public string ServiceTypeTxt { get; set; }

    [JsonPropertyName("CompensationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompensationAmt { get; set; }

    [JsonPropertyName("ForeignAddress")] public ForeignAddress ForeignAddress { get; set; }

    [JsonPropertyName("PersonNm")] public string PersonNm { get; set; }
}

public class ConferencesMeetingsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}


public class ContractorAddress
{
    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }
}

public class ContractorBusinessName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }
}

public class ContractorCompensationExpln
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("ContractorCompExplnGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<ContractorCompExplnGrp>))]
    public List<ContractorCompExplnGrp> ContractorCompExplnGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class ContractorCompensationGrp
{
    [JsonPropertyName("ContractorName")] public ContractorName ContractorName { get; set; }

    [JsonPropertyName("ContractorAddress")]
    public ContractorAddress ContractorAddress { get; set; }

    [JsonPropertyName("ServicesDesc")] public string ServicesDesc { get; set; }

    [JsonPropertyName("CompensationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompensationAmt { get; set; }
}

public class ContractorCompExplnGrp
{
    [JsonPropertyName("ContractorBusinessName")]
    public ContractorBusinessName ContractorBusinessName { get; set; }

    [JsonPropertyName("ExplanationTxt")] public string ExplanationTxt { get; set; }
}

public class ContractorName
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("PersonNm")] public string PersonNm { get; set; }
}

public class ContributorBusinessName
{
    [JsonPropertyName("BusinessNameLine1")]
    public string BusinessNameLine1 { get; set; }
}

public class ContributorInformationGrp
{
    [JsonPropertyName("ContributorNum")] public string ContributorNum { get; set; }

    [JsonPropertyName("ContributorBusinessName")]
    public ContributorBusinessName ContributorBusinessName { get; set; }

    [JsonPropertyName("ContributorUSAddress")]
    public ContributorUSAddress ContributorUSAddress { get; set; }

    [JsonPropertyName("TotalContributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalContributionsAmt { get; set; }
}

public class ContributorUSAddress
{
    [JsonPropertyName("AddressLine1")] public string AddressLine1 { get; set; }

    [JsonPropertyName("AddressLine2")] public string AddressLine2 { get; set; }

    [JsonPropertyName("City")] public string City { get; set; }

    [JsonPropertyName("State")] public string State { get; set; }

    [JsonPropertyName("ZIPCode")] public string ZIPCode { get; set; }
}


public class CostingMethodologyUsedGrp
{
    [JsonPropertyName("CostToChargeRatioInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CostToChargeRatioInd { get; set; }

    [JsonPropertyName("OtherInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherInd { get; set; }

    [JsonPropertyName("CostAccountingSystemInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CostAccountingSystemInd { get; set; }
}


public class CYEndwmtFundGrp
{
    [JsonPropertyName("BeginningYearBalanceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BeginningYearBalanceAmt { get; set; }

    [JsonPropertyName("ContributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ContributionsAmt { get; set; }

    [JsonPropertyName("InvestmentEarningsOrLossesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvestmentEarningsOrLossesAmt { get; set; }

    [JsonPropertyName("OtherExpendituresAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherExpendituresAmt { get; set; }

    [JsonPropertyName("EndYearBalanceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EndYearBalanceAmt { get; set; }

    [JsonPropertyName("GrantsOrScholarshipsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantsOrScholarshipsAmt { get; set; }

    [JsonPropertyName("AdministrativeExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdministrativeExpensesAmt { get; set; }
}

public class CYMinus1YrEndwmtFundGrp
{
    [JsonPropertyName("BeginningYearBalanceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BeginningYearBalanceAmt { get; set; }

    [JsonPropertyName("InvestmentEarningsOrLossesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvestmentEarningsOrLossesAmt { get; set; }

    [JsonPropertyName("OtherExpendituresAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherExpendituresAmt { get; set; }

    [JsonPropertyName("EndYearBalanceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EndYearBalanceAmt { get; set; }

    [JsonPropertyName("ContributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ContributionsAmt { get; set; }

    [JsonPropertyName("GrantsOrScholarshipsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantsOrScholarshipsAmt { get; set; }

    [JsonPropertyName("AdministrativeExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdministrativeExpensesAmt { get; set; }
}

public class CYMinus2YrEndwmtFundGrp
{
    [JsonPropertyName("BeginningYearBalanceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BeginningYearBalanceAmt { get; set; }

    [JsonPropertyName("InvestmentEarningsOrLossesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvestmentEarningsOrLossesAmt { get; set; }

    [JsonPropertyName("OtherExpendituresAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherExpendituresAmt { get; set; }

    [JsonPropertyName("AdministrativeExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdministrativeExpensesAmt { get; set; }

    [JsonPropertyName("EndYearBalanceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EndYearBalanceAmt { get; set; }

    [JsonPropertyName("ContributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ContributionsAmt { get; set; }

    [JsonPropertyName("GrantsOrScholarshipsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantsOrScholarshipsAmt { get; set; }
}

public class CYMinus3YrEndwmtFundGrp
{
    [JsonPropertyName("BeginningYearBalanceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BeginningYearBalanceAmt { get; set; }

    [JsonPropertyName("EndYearBalanceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EndYearBalanceAmt { get; set; }

    [JsonPropertyName("ContributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ContributionsAmt { get; set; }

    [JsonPropertyName("OtherExpendituresAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherExpendituresAmt { get; set; }
}

public class CYMinus4YrEndwmtFundGrp
{
    [JsonPropertyName("BeginningYearBalanceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BeginningYearBalanceAmt { get; set; }

    [JsonPropertyName("EndYearBalanceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EndYearBalanceAmt { get; set; }

    [JsonPropertyName("ContributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ContributionsAmt { get; set; }

    [JsonPropertyName("OtherExpendituresAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherExpendituresAmt { get; set; }
}

public class DeferredRevenueGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class DepreciationDepletionGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }

    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class DepreciationPropertyGrp
{
    [JsonPropertyName("PropertyDesc")] public string PropertyDesc { get; set; }

    [JsonPropertyName("AcquiredDt")] public string AcquiredDt { get; set; }

    [JsonPropertyName("CostOrOtherBasisAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CostOrOtherBasisAmt { get; set; }

    [JsonPropertyName("PriorYearDepreciationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearDepreciationAmt { get; set; }

    [JsonPropertyName("ComputationMethodTxt")]
    public string ComputationMethodTxt { get; set; }

    [JsonPropertyName("LifeRt")] public string LifeRt { get; set; }

    [JsonPropertyName("CurrentYearExpenseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearExpenseAmt { get; set; }

    [JsonPropertyName("NetInvestmentIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetInvestmentIncomeAmt { get; set; }

    [JsonPropertyName("AdjustedNetIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdjustedNetIncomeAmt { get; set; }
}

public class DepreciationSchedule
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("DepreciationPropertyGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<DepreciationPropertyGrp>))]
    public List<DepreciationPropertyGrp> DepreciationPropertyGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class DirectControllingEntityName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }
}

public class DiscountedCareOthPercentageGrp
{
    [JsonPropertyName("OtherInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherInd { get; set; }

    [JsonPropertyName("DiscountedCareOtherPct")]
    public string DiscountedCareOtherPct { get; set; }
}

public class DispositionOfAssetsDetail
{
    [JsonPropertyName("AssetsDistriOrExpnssPaidDesc")]
    public string AssetsDistriOrExpnssPaidDesc { get; set; }

    [JsonPropertyName("DistributionDt")] public string DistributionDt { get; set; }

    [JsonPropertyName("FairMarketValueOfAssetAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FairMarketValueOfAssetAmt { get; set; }

    [JsonPropertyName("MethodOfFMVDeterminationTxt")]
    public string MethodOfFMVDeterminationTxt { get; set; }

    [JsonPropertyName("EIN")] public string EIN { get; set; }

    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("IRCSectionTxt")] public string IRCSectionTxt { get; set; }
}

public class DisqualifiedPersonExBnftTrGrp
{
    [JsonPropertyName("PersonNm")] public string PersonNm { get; set; }

    [JsonPropertyName("RlnDisqualifiedPersonOrgTxt")]
    public string RlnDisqualifiedPersonOrgTxt { get; set; }

    [JsonPropertyName("TransactionDesc")] public string TransactionDesc { get; set; }

    [JsonPropertyName("TransactionCorrectedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TransactionCorrectedInd { get; set; }
}

public class DisregardedEntityName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }
}

public class DissolutionInformationGrp
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("ShortExplanationTxt")]
    public string ShortExplanationTxt { get; set; }

    [JsonPropertyName("DissolutionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DissolutionAmt { get; set; }
}

public class DissolutionStmt
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("DissolutionInformationGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<DissolutionInformationGrp>))]
    public List<DissolutionInformationGrp> DissolutionInformationGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class DistributableAmountGrp
{
    [JsonPropertyName("MinimumInvestmentReturnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string MinimumInvestmentReturnAmt { get; set; }

    [JsonPropertyName("TaxBasedOnInvestmentIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxBasedOnInvestmentIncomeAmt { get; set; }

    [JsonPropertyName("TotalTaxAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalTaxAmt { get; set; }

    [JsonPropertyName("DistributableBeforeAdjAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DistributableBeforeAdjAmt { get; set; }

    [JsonPropertyName("DistributableBeforeDedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DistributableBeforeDedAmt { get; set; }

    [JsonPropertyName("DistributableAsAdjustedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DistributableAsAdjustedAmt { get; set; }

    [JsonPropertyName("RecoveriesQualfiedDistriAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RecoveriesQualfiedDistriAmt { get; set; }

    [JsonPropertyName("DeductionFromDistributableAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DeductionFromDistributableAmt { get; set; }

    [JsonPropertyName("Sect4942j3j5FndtnAndFrgnOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Sect4942j3j5FndtnAndFrgnOrgInd { get; set; }

    [JsonPropertyName("IncomeTaxAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string IncomeTaxAmt { get; set; }

    [JsonPropertyName("CYAdjNetIncomeDistributableAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYAdjNetIncomeDistributableAmt { get; set; }

    [JsonPropertyName("CYPct85AdjustedNetIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYPct85AdjustedNetIncomeAmt { get; set; }

    [JsonPropertyName("CYTotalMinAstDistributableAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYTotalMinAstDistributableAmt { get; set; }

    [JsonPropertyName("CYGreaterAdjustedMinimumAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYGreaterAdjustedMinimumAmt { get; set; }

    [JsonPropertyName("CYIncomeTaxImposedPYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYIncomeTaxImposedPYAmt { get; set; }

    [JsonPropertyName("CYDistributableAsAdjustedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYDistributableAsAdjustedAmt { get; set; }

    [JsonPropertyName("FirstYearType3NonFuncInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FirstYearType3NonFuncInd { get; set; }
}

public class DistributionAllocationsGrp
{
    [JsonPropertyName("CYDistributableAsAdjustedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYDistributableAsAdjustedAmt { get; set; }

    [JsonPropertyName("UnderdistributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnderdistributionsAmt { get; set; }

    [JsonPropertyName("ExcessDistributionCyovYr4Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessDistributionCyovYr4Amt { get; set; }

    [JsonPropertyName("ExcessDistributionCyovYr3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessDistributionCyovYr3Amt { get; set; }

    [JsonPropertyName("ExcessDistributionCyovYr2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessDistributionCyovYr2Amt { get; set; }

    [JsonPropertyName("ExcessDistributionCyovYr1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessDistributionCyovYr1Amt { get; set; }

    [JsonPropertyName("TotalExcessDistributionCyovAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalExcessDistributionCyovAmt { get; set; }

    [JsonPropertyName("CyovAppliedUnderdistriPYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CyovAppliedUnderdistriPYAmt { get; set; }

    [JsonPropertyName("CyovAppliedUnderdistrCPYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CyovAppliedUnderdistrCPYAmt { get; set; }

    [JsonPropertyName("ExcessDistributionCyovAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessDistributionCyovAmt { get; set; }

    [JsonPropertyName("CYTotalAnnualDistributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYTotalAnnualDistributionsAmt { get; set; }

    [JsonPropertyName("CYDistribAppUnderdistriPYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYDistribAppUnderdistriPYAmt { get; set; }

    [JsonPropertyName("ExcessDistributionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessDistributionAmt { get; set; }

    [JsonPropertyName("RemainingUnderdistriPYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RemainingUnderdistriPYAmt { get; set; }

    [JsonPropertyName("RemainingUnderdistriCYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RemainingUnderdistriCYAmt { get; set; }

    [JsonPropertyName("ExcessDistriCyovToNextYrAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessDistriCyovToNextYrAmt { get; set; }

    [JsonPropertyName("ExcessFromYear5Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessFromYear5Amt { get; set; }

    [JsonPropertyName("ExcessFromYear4Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessFromYear4Amt { get; set; }

    [JsonPropertyName("ExcessFromYear3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessFromYear3Amt { get; set; }

    [JsonPropertyName("ExcessFromYear2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessFromYear2Amt { get; set; }

    [JsonPropertyName("ExcessFromYear1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessFromYear1Amt { get; set; }

    [JsonPropertyName("CYDistriAppDistributableAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYDistriAppDistributableAmt { get; set; }
}

public class DistributionFromCorpusElection
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("ElectionDesc")] public string ElectionDesc { get; set; }
}

public class DistributionsGrp
{
    [JsonPropertyName("CYPaidAccomplishExemptPrpsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYPaidAccomplishExemptPrpsAmt { get; set; }

    [JsonPropertyName("CYPdInExcessIncomeActivityAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYPdInExcessIncomeActivityAmt { get; set; }

    [JsonPropertyName("CYAdministrativeExpensePaidAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYAdministrativeExpensePaidAmt { get; set; }

    [JsonPropertyName("ExemptUseAssetsAcquisPaidAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExemptUseAssetsAcquisPaidAmt { get; set; }

    [JsonPropertyName("QualifiedSetAsideAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string QualifiedSetAsideAmt { get; set; }

    [JsonPropertyName("CYOtherDistributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYOtherDistributionsAmt { get; set; }

    [JsonPropertyName("CYTotalAnnualDistributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYTotalAnnualDistributionsAmt { get; set; }

    [JsonPropertyName("CYDistriAttentiveSuprtOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYDistriAttentiveSuprtOrgAmt { get; set; }

    [JsonPropertyName("CYDistributableAsAdjustedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYDistributableAsAdjustedAmt { get; set; }

    [JsonPropertyName("CYDistributionYrRt")]
    public string CYDistributionYrRt { get; set; }
}

public class DivAndIntFromSecPartVIIGrp
{
    [JsonPropertyName("ExclusionCd")] public string ExclusionCd { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExclusionAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFunctionIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrExemptFunctionIncmAmt { get; set; }

    [JsonPropertyName("BusinessCd")] public string BusinessCd { get; set; }

    [JsonPropertyName("UnrelatedBusinessTaxblIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrelatedBusinessTaxblIncmAmt { get; set; }
}

public class DoingBusinessAsName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }

    [JsonPropertyName("BusinessNameLine2Txt")]
    public string BusinessNameLine2Txt { get; set; }
}


public class DonorRestrictionNetAssetsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}


public class DrugsAndMedicalSuppliesGrp
{
    [JsonPropertyName("NonCashCheckboxInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string NonCashCheckboxInd { get; set; }

    [JsonPropertyName("ContributionCnt")] public string ContributionCnt { get; set; }

    [JsonPropertyName("NoncashContributionsRptF990Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NoncashContributionsRptF990Amt { get; set; }

    [JsonPropertyName("MethodOfDeterminingRevenuesTxt")]
    public string MethodOfDeterminingRevenuesTxt { get; set; }
}

public class EconomicDevelopmentGrp
{
    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }
}

public class EmployeeCompensationExpln
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("EmployeeCompExplanationGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<EmployeeCompExplanationGrp>))]
    public List<EmployeeCompExplanationGrp> EmployeeCompExplanationGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class EmployeeCompExplanationGrp
{
    [JsonPropertyName("EmployeeNm")] public string EmployeeNm { get; set; }

    [JsonPropertyName("ExplanationTxt")] public string ExplanationTxt { get; set; }
}

public class EntityName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }
}

public class EnvironmentalImprovementsGrp
{
    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }

    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }
}

public class EquipmentGrp
{
    [JsonPropertyName("OtherCostOrOtherBasisAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherCostOrOtherBasisAmt { get; set; }

    [JsonPropertyName("DepreciationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DepreciationAmt { get; set; }

    [JsonPropertyName("BookValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BookValueAmt { get; set; }

    [JsonPropertyName("InvestmentCostOrOtherBasisAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvestmentCostOrOtherBasisAmt { get; set; }
}

public class EscrowAccountLiabilityGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class ExciseTaxBasedOnInvstIncmGrp
{
    [JsonPropertyName("DomesticOrgMeetingSect4940eInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DomesticOrgMeetingSect4940eInd { get; set; }

    [JsonPropertyName("InvestmentIncomeExciseTaxAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvestmentIncomeExciseTaxAmt { get; set; }

    [JsonPropertyName("SubtotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SubtotalAmt { get; set; }

    [JsonPropertyName("TaxBasedOnInvestmentIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxBasedOnInvestmentIncomeAmt { get; set; }

    [JsonPropertyName("EstimatedPlusOvpmtIncmTxAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EstimatedPlusOvpmtIncmTxAmt { get; set; }

    [JsonPropertyName("TotalPaymentsAndCreditsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalPaymentsAndCreditsAmt { get; set; }

    [JsonPropertyName("OverpaymentAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OverpaymentAmt { get; set; }

    [JsonPropertyName("AppliedToESTaxAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AppliedToESTaxAmt { get; set; }

    [JsonPropertyName("TaxDueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxDueAmt { get; set; }

    [JsonPropertyName("TaxUnderSection511Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxUnderSection511Amt { get; set; }

    [JsonPropertyName("SubtitleATaxAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SubtitleATaxAmt { get; set; }

    [JsonPropertyName("ExtsnRequestIncomeTaxPaidAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExtsnRequestIncomeTaxPaidAmt { get; set; }

    [JsonPropertyName("BackupWithholdingWithheldAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BackupWithholdingWithheldAmt { get; set; }

    [JsonPropertyName("EsPenaltyAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EsPenaltyAmt { get; set; }

    [JsonPropertyName("RefundAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RefundAmt { get; set; }

    [JsonPropertyName("Form2220AttachedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form2220AttachedInd { get; set; }

    [JsonPropertyName("OriginalReturnTaxPaidAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OriginalReturnTaxPaidAmt { get; set; }

    [JsonPropertyName("AppliedToEsTaxAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AppliedToEsTaxAmt { get; set; }

    [JsonPropertyName("OriginalReturnOverpaymentAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OriginalReturnOverpaymentAmt { get; set; }

    [JsonPropertyName("RulingLetterDt")] public string RulingLetterDt { get; set; }

    [JsonPropertyName("ExemptOperatingFoundationsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExemptOperatingFoundationsInd { get; set; }

    [JsonPropertyName("NotApplicableCd")] public string NotApplicableCd { get; set; }
}

public class ExpenditureResponsibilityGrp
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("GrantDt")] public string GrantDt { get; set; }

    [JsonPropertyName("GrantAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantAmt { get; set; }

    [JsonPropertyName("PurposeOfGrantTxt")]
    public string PurposeOfGrantTxt { get; set; }

    [JsonPropertyName("ExpendedByGranteeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExpendedByGranteeAmt { get; set; }

    [JsonPropertyName("AnyDiversionByGranteeTxt")]
    public string AnyDiversionByGranteeTxt { get; set; }

    [JsonPropertyName("DatesOfReportsByGranteeTxt")]
    public string DatesOfReportsByGranteeTxt { get; set; }

    [JsonPropertyName("ResultsOfVerificationTxt")]
    public string ResultsOfVerificationTxt { get; set; }

    [JsonPropertyName("ForeignAddress")] public ForeignAddress ForeignAddress { get; set; }
}

public class ExpenditureResponsibilityStmt
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("ExpenditureResponsibilityGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<ExpenditureResponsibilityGrp>))]
    public List<ExpenditureResponsibilityGrp> ExpenditureResponsibilityGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class ExplanOfLegisPoliticalActvts
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("MediumExplanationTxt")]
    public string MediumExplanationTxt { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class ExplnOfNonFilingWithAGStmt
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("ExplanationTxt")] public string ExplanationTxt { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class FeesForServicesAccountingGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class FeesForServicesLegalGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class FeesForServicesLobbyingGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class FeesForServicesManagementGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class FeesForServicesOtherGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class FeesForServicesProfFundraising
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class FeesForSrvcInvstMgmntFeesGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class Filer
{
    [JsonPropertyName("EIN")] public string EIN { get; set; }

    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("BusinessNameControlTxt")]
    public string BusinessNameControlTxt { get; set; }

    [JsonPropertyName("PhoneNum")] public string PhoneNum { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("InCareOfNm")] public string InCareOfNm { get; set; }

    [JsonPropertyName("ForeignAddress")] public ForeignAddress ForeignAddress { get; set; }
}

public class FilingSecurityInformation
{
    [JsonPropertyName("AtSubmissionCreationDeviceId")]
    public string AtSubmissionCreationDeviceId { get; set; }

    [JsonPropertyName("AtSubmissionFilingDeviceId")]
    public string AtSubmissionFilingDeviceId { get; set; }

    [JsonPropertyName("IPAddress")] public IPAddress IPAddress { get; set; }

    [JsonPropertyName("IPDt")] public string IPDt { get; set; }

    [JsonPropertyName("IPTm")] public string IPTm { get; set; }

    [JsonPropertyName("FederalOriginalSubmissionId")]
    public string FederalOriginalSubmissionId { get; set; }

    [JsonPropertyName("FederalOriginalSubmissionIdDt")]
    public string FederalOriginalSubmissionIdDt { get; set; }

    [JsonPropertyName("FilingLicenseTypeCd")]
    public string FilingLicenseTypeCd { get; set; }

    [JsonPropertyName("IPTimezoneCd")] public string IPTimezoneCd { get; set; }
}

public class FinancialAssistanceAtCostTyp
{
    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }
}

public class FMVOtherNonExemptUseAssetGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class ForeignAddress
{
    [JsonPropertyName("AddressLine1Txt")] public string AddressLine1Txt { get; set; }

    [JsonPropertyName("CityNm")] public string CityNm { get; set; }

    [JsonPropertyName("ProvinceOrStateNm")]
    public string ProvinceOrStateNm { get; set; }

    [JsonPropertyName("CountryCd")] public string CountryCd { get; set; }

    [JsonPropertyName("ForeignPostalCd")] public string ForeignPostalCd { get; set; }

    [JsonPropertyName("AddressLine2Txt")] public string AddressLine2Txt { get; set; }
}

public class ForeignGrantsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }
}

public class ForeignIndividualsGrantsGrp
{
    [JsonPropertyName("TypeOfAssistanceTxt")]
    public string TypeOfAssistanceTxt { get; set; }

    [JsonPropertyName("RegionTxt")] public string RegionTxt { get; set; }

    [JsonPropertyName("RecipientCnt")] public string RecipientCnt { get; set; }

    [JsonPropertyName("NonCashAssistanceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NonCashAssistanceAmt { get; set; }

    [JsonPropertyName("DescriptionOfNonCashAsstTxt")]
    public string DescriptionOfNonCashAsstTxt { get; set; }

    [JsonPropertyName("CashGrantAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CashGrantAmt { get; set; }

    [JsonPropertyName("MannerOfCashDisbursementTxt")]
    public string MannerOfCashDisbursementTxt { get; set; }
}

public class Form990PartVIISectionAGrp
{
    [JsonPropertyName("PersonNm")] public string PersonNm { get; set; }

    [JsonPropertyName("TitleTxt")] public string TitleTxt { get; set; }

    [JsonPropertyName("AverageHoursPerWeekRt")]
    public string AverageHoursPerWeekRt { get; set; }

    [JsonPropertyName("AverageHoursPerWeekRltdOrgRt")]
    public string AverageHoursPerWeekRltdOrgRt { get; set; }

    [JsonPropertyName("IndividualTrusteeOrDirectorInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string IndividualTrusteeOrDirectorInd { get; set; }

    [JsonPropertyName("ReportableCompFromOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReportableCompFromOrgAmt { get; set; }

    [JsonPropertyName("ReportableCompFromRltdOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReportableCompFromRltdOrgAmt { get; set; }

    [JsonPropertyName("OtherCompensationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherCompensationAmt { get; set; }

    [JsonPropertyName("OfficerInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OfficerInd { get; set; }

    [JsonPropertyName("FormerOfcrDirectorTrusteeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FormerOfcrDirectorTrusteeInd { get; set; }

    [JsonPropertyName("KeyEmployeeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string KeyEmployeeInd { get; set; }
}

public class Form990PFBalanceSheetsGrp
{
    [JsonPropertyName("CashBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CashBOYAmt { get; set; }

    [JsonPropertyName("CashEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CashEOYAmt { get; set; }

    [JsonPropertyName("CashEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CashEOYFMVAmt { get; set; }

    [JsonPropertyName("SavAndTempCashInvstBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SavAndTempCashInvstBOYAmt { get; set; }

    [JsonPropertyName("SavAndTempCashInvstEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SavAndTempCashInvstEOYAmt { get; set; }

    [JsonPropertyName("SavAndTempCashInvstEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SavAndTempCashInvstEOYFMVAmt { get; set; }

    [JsonPropertyName("AcctRcvblAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AcctRcvblAmt { get; set; }

    [JsonPropertyName("AcctRcvblBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AcctRcvblBOYAmt { get; set; }

    [JsonPropertyName("AcctRcvblEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AcctRcvblEOYAmt { get; set; }

    [JsonPropertyName("AcctRcvblEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AcctRcvblEOYFMVAmt { get; set; }

    [JsonPropertyName("PrepaidExpensesBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PrepaidExpensesBOYAmt { get; set; }

    [JsonPropertyName("PrepaidExpensesEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PrepaidExpensesEOYAmt { get; set; }

    [JsonPropertyName("PrepaidExpensesEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PrepaidExpensesEOYFMVAmt { get; set; }

    [JsonPropertyName("USGovernmentObligationsBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string USGovernmentObligationsBOYAmt { get; set; }

    [JsonPropertyName("USGovernmentObligationsEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string USGovernmentObligationsEOYAmt { get; set; }

    [JsonPropertyName("USGovtObligationsEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string USGovtObligationsEOYFMVAmt { get; set; }

    [JsonPropertyName("CorporateStockBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CorporateStockBOYAmt { get; set; }

    [JsonPropertyName("CorporateStockEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CorporateStockEOYAmt { get; set; }

    [JsonPropertyName("CorporateStockEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CorporateStockEOYFMVAmt { get; set; }

    [JsonPropertyName("CorporateBondsBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CorporateBondsBOYAmt { get; set; }

    [JsonPropertyName("CorporateBondsEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CorporateBondsEOYAmt { get; set; }

    [JsonPropertyName("CorporateBondsEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CorporateBondsEOYFMVAmt { get; set; }

    [JsonPropertyName("InvstLandCostOrOtherBasisAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvstLandCostOrOtherBasisAmt { get; set; }

    [JsonPropertyName("InvstLandAccumDepreciationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvstLandAccumDepreciationAmt { get; set; }

    [JsonPropertyName("LandBldgInvestmentsBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LandBldgInvestmentsBOYAmt { get; set; }

    [JsonPropertyName("LandBldgInvestmentsEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LandBldgInvestmentsEOYAmt { get; set; }

    [JsonPropertyName("LandBldgInvestmentsEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LandBldgInvestmentsEOYFMVAmt { get; set; }

    [JsonPropertyName("OtherInvestmentsBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherInvestmentsBOYAmt { get; set; }

    [JsonPropertyName("OtherInvestmentsEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherInvestmentsEOYAmt { get; set; }

    [JsonPropertyName("OtherInvestmentsEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherInvestmentsEOYFMVAmt { get; set; }

    [JsonPropertyName("LandBldgEquipCostOrOtherBssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LandBldgEquipCostOrOtherBssAmt { get; set; }

    [JsonPropertyName("LandBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LandBOYAmt { get; set; }

    [JsonPropertyName("LandEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LandEOYAmt { get; set; }

    [JsonPropertyName("LandEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LandEOYFMVAmt { get; set; }

    [JsonPropertyName("OtherAssetsBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherAssetsBOYAmt { get; set; }

    [JsonPropertyName("OtherAssetsEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherAssetsEOYAmt { get; set; }

    [JsonPropertyName("OtherAssetsEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherAssetsEOYFMVAmt { get; set; }

    [JsonPropertyName("TotalAssetsBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAssetsBOYAmt { get; set; }

    [JsonPropertyName("TotalAssetsEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAssetsEOYAmt { get; set; }

    [JsonPropertyName("TotalAssetsEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAssetsEOYFMVAmt { get; set; }

    [JsonPropertyName("AccountsPayableBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AccountsPayableBOYAmt { get; set; }

    [JsonPropertyName("AccountsPayableEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AccountsPayableEOYAmt { get; set; }

    [JsonPropertyName("TotalLiabilitiesBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalLiabilitiesBOYAmt { get; set; }

    [JsonPropertyName("TotalLiabilitiesEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalLiabilitiesEOYAmt { get; set; }

    [JsonPropertyName("OrganizationFollowsSFAS117Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string OrganizationFollowsSFAS117Ind { get; set; }

    [JsonPropertyName("UnrestrictedBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrestrictedBOYAmt { get; set; }

    [JsonPropertyName("UnrestrictedEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrestrictedEOYAmt { get; set; }

    [JsonPropertyName("TotNetAstOrFundBalancesBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotNetAstOrFundBalancesBOYAmt { get; set; }

    [JsonPropertyName("TotNetAstOrFundBalancesEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotNetAstOrFundBalancesEOYAmt { get; set; }

    [JsonPropertyName("TotalLiabilitiesNetAstBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalLiabilitiesNetAstBOYAmt { get; set; }

    [JsonPropertyName("TotalLiabilitiesNetAstEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalLiabilitiesNetAstEOYAmt { get; set; }

    [JsonPropertyName("OrgDoesNotFollowSFAS117Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string OrgDoesNotFollowSFAS117Ind { get; set; }

    [JsonPropertyName("RetainedEarningBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RetainedEarningBOYAmt { get; set; }

    [JsonPropertyName("RetainedEarningEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RetainedEarningEOYAmt { get; set; }

    [JsonPropertyName("OtherRcvblAllwncDbtflAcctAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherRcvblAllwncDbtflAcctAmt { get; set; }

    [JsonPropertyName("CapitalStockBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CapitalStockBOYAmt { get; set; }

    [JsonPropertyName("CapitalStockEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CapitalStockEOYAmt { get; set; }

    [JsonPropertyName("LandBldgEquipAccumDeprecAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LandBldgEquipAccumDeprecAmt { get; set; }

    [JsonPropertyName("MortgagesAndNotesPayableBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string MortgagesAndNotesPayableBOYAmt { get; set; }

    [JsonPropertyName("MortgagesAndNotesPayableEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string MortgagesAndNotesPayableEOYAmt { get; set; }

    [JsonPropertyName("OtherLiabilitiesBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherLiabilitiesBOYAmt { get; set; }

    [JsonPropertyName("OtherLiabilitiesEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherLiabilitiesEOYAmt { get; set; }

    [JsonPropertyName("AdditionalPaidInCapitalBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdditionalPaidInCapitalBOYAmt { get; set; }

    [JsonPropertyName("AdditionalPaidInCapitalEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdditionalPaidInCapitalEOYAmt { get; set; }

    [JsonPropertyName("MortgageLoansBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string MortgageLoansBOYAmt { get; set; }

    [JsonPropertyName("MortgageLoansEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string MortgageLoansEOYAmt { get; set; }

    [JsonPropertyName("MortgageLoansEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string MortgageLoansEOYFMVAmt { get; set; }

    [JsonPropertyName("TemporarilyRestrictedBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TemporarilyRestrictedBOYAmt { get; set; }

    [JsonPropertyName("TemporarilyRestrictedEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TemporarilyRestrictedEOYAmt { get; set; }

    [JsonPropertyName("OtherNtsAndLoansRcvblAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherNtsAndLoansRcvblAmt { get; set; }

    [JsonPropertyName("OtherNtsAndLoansRcvblBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherNtsAndLoansRcvblBOYAmt { get; set; }

    [JsonPropertyName("OtherNtsAndLoansRcvblEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherNtsAndLoansRcvblEOYAmt { get; set; }

    [JsonPropertyName("OtherNtsAndLoansRcvblEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherNtsAndLoansRcvblEOYFMVAmt { get; set; }

    [JsonPropertyName("RcvblFromOfficersEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RcvblFromOfficersEOYAmt { get; set; }

    [JsonPropertyName("GrantsPayableBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantsPayableBOYAmt { get; set; }

    [JsonPropertyName("GrantsPayableEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantsPayableEOYAmt { get; set; }

    [JsonPropertyName("InventoriesBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InventoriesBOYAmt { get; set; }

    [JsonPropertyName("InventoriesEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InventoriesEOYAmt { get; set; }

    [JsonPropertyName("InventoriesEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InventoriesEOYFMVAmt { get; set; }

    [JsonPropertyName("DeferredRevenueBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DeferredRevenueBOYAmt { get; set; }

    [JsonPropertyName("DeferredRevenueEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DeferredRevenueEOYAmt { get; set; }

    [JsonPropertyName("LoansFromOfficersBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LoansFromOfficersBOYAmt { get; set; }

    [JsonPropertyName("LoansFromOfficersEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LoansFromOfficersEOYAmt { get; set; }

    [JsonPropertyName("PledgesRcvblBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PledgesRcvblBOYAmt { get; set; }

    [JsonPropertyName("PermanentlyRestrictedBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PermanentlyRestrictedBOYAmt { get; set; }

    [JsonPropertyName("PermanentlyRestrictedEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PermanentlyRestrictedEOYAmt { get; set; }

    [JsonPropertyName("GrantsReceivableBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantsReceivableBOYAmt { get; set; }

    [JsonPropertyName("GrantsReceivableEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantsReceivableEOYAmt { get; set; }

    [JsonPropertyName("GrantsReceivableEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantsReceivableEOYFMVAmt { get; set; }

    [JsonPropertyName("RcvblFromOfficersBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RcvblFromOfficersBOYAmt { get; set; }

    [JsonPropertyName("RcvblFromOfficersEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RcvblFromOfficersEOYFMVAmt { get; set; }

    [JsonPropertyName("OrganizationFollowsFASB117Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string OrganizationFollowsFASB117Ind { get; set; }

    [JsonPropertyName("NoDonorRstrNetAssestsBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NoDonorRstrNetAssestsBOYAmt { get; set; }

    [JsonPropertyName("NoDonorRstrNetAssestsEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NoDonorRstrNetAssestsEOYAmt { get; set; }

    [JsonPropertyName("PledgesRcvblEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PledgesRcvblEOYAmt { get; set; }

    [JsonPropertyName("PledgesRcvblEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PledgesRcvblEOYFMVAmt { get; set; }

    [JsonPropertyName("PledgesRcvblAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PledgesRcvblAmt { get; set; }

    [JsonPropertyName("OrgDoesNotFollowFASB117Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string OrgDoesNotFollowFASB117Ind { get; set; }

    [JsonPropertyName("AcctRcvblAllwncDbtflAcctAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AcctRcvblAllwncDbtflAcctAmt { get; set; }

    [JsonPropertyName("PledgesRcvblAllwncDbtflAcctAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PledgesRcvblAllwncDbtflAcctAmt { get; set; }
}

public class Form990SchASupportingOrgGrp
{
    [JsonPropertyName("ListedByNameGoverningDocInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ListedByNameGoverningDocInd { get; set; }

    [JsonPropertyName("SuprtOrgNoIRSDeterminationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SuprtOrgNoIRSDeterminationInd { get; set; }

    [JsonPropertyName("SupportedOrgSectionC456Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string SupportedOrgSectionC456Ind { get; set; }

    [JsonPropertyName("SupportedOrgNotOrganizedUSInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SupportedOrgNotOrganizedUSInd { get; set; }

    [JsonPropertyName("OrganizationChangeSuprtOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OrganizationChangeSuprtOrgInd { get; set; }

    [JsonPropertyName("SupportedOrgClassDesignatedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SupportedOrgClassDesignatedInd { get; set; }

    [JsonPropertyName("SupportNonSupportedOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SupportNonSupportedOrgInd { get; set; }

    [JsonPropertyName("PaymentSubstantialContribtrInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PaymentSubstantialContribtrInd { get; set; }

    [JsonPropertyName("LoanDisqualifiedPersonInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LoanDisqualifiedPersonInd { get; set; }

    [JsonPropertyName("ControlledDisqualifiedPrsnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ControlledDisqualifiedPrsnInd { get; set; }

    [JsonPropertyName("DisqualifiedPrsnControllIntInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DisqualifiedPrsnControllIntInd { get; set; }

    [JsonPropertyName("DisqualifiedPrsnOwnrIntInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DisqualifiedPrsnOwnrIntInd { get; set; }

    [JsonPropertyName("ExcessBusinessHoldingsRulesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessBusinessHoldingsRulesInd { get; set; }

    [JsonPropertyName("ContributionControllerInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ContributionControllerInd { get; set; }

    [JsonPropertyName("ContributionFamilyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ContributionFamilyInd { get; set; }

    [JsonPropertyName("Contribution35ControlledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Contribution35ControlledInd { get; set; }

    [JsonPropertyName("SupportedOrgQualifiedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SupportedOrgQualifiedInd { get; set; }

    [JsonPropertyName("SuprtExclusivelySec170c2BInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SuprtExclusivelySec170c2BInd { get; set; }

    [JsonPropertyName("ControlDecidingGrntFrgnOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ControlDecidingGrntFrgnOrgInd { get; set; }

    [JsonPropertyName("SupportForeignOrgNoDetermInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SupportForeignOrgNoDetermInd { get; set; }

    [JsonPropertyName("ExcessBusinessHoldingsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessBusinessHoldingsInd { get; set; }

    [JsonPropertyName("SubstitutionBeyondOrgCntlInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SubstitutionBeyondOrgCntlInd { get; set; }
}

public class Form990SchAType1SuprtOrgGrp
{
    [JsonPropertyName("PowerAppointMajorityDirTrstInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PowerAppointMajorityDirTrstInd { get; set; }

    [JsonPropertyName("OperateBenefitNonSuprtOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OperateBenefitNonSuprtOrgInd { get; set; }
}

public class Form990SchAType3FuncIntGrp
{
    [JsonPropertyName("GovernmentalEntityInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GovernmentalEntityInd { get; set; }

    [JsonPropertyName("ActivitiesTestInd")]
    [JsonConverter(typeof(FixScrewedUpString))]
    public string ActivitiesTestInd { get; set; }

    [JsonPropertyName("ActivitiesFurtherExemptPrpsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ActivitiesFurtherExemptPrpsInd { get; set; }

    [JsonPropertyName("ActivitiesEngagedOrgInvlmntInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ActivitiesEngagedOrgInvlmntInd { get; set; }

    [JsonPropertyName("AppointElectMajorityOfficerInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AppointElectMajorityOfficerInd { get; set; }

    [JsonPropertyName("ExerciseDirectionPoliciesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExerciseDirectionPoliciesInd { get; set; }

    [JsonPropertyName("ParentSupportedOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ParentSupportedOrgInd { get; set; }
}

public class Form990SchAType3SprtOrgAllGrp
{
    [JsonPropertyName("TimelyProvidedDocumentsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TimelyProvidedDocumentsInd { get; set; }

    [JsonPropertyName("OfficersCloseRelationshipInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OfficersCloseRelationshipInd { get; set; }

    [JsonPropertyName("SupportedOrgVoiceInvestmentInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SupportedOrgVoiceInvestmentInd { get; set; }
}

public class Form990ScheduleAPartVIGrp
{
    [JsonPropertyName("FormAndLineReferenceDesc")]
    public string FormAndLineReferenceDesc { get; set; }

    [JsonPropertyName("ExplanationTxt")] public string ExplanationTxt { get; set; }
}

public class Form990TotalAssetsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class FreeCareOthPercentageGrp
{
    [JsonPropertyName("OtherInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherInd { get; set; }

    [JsonPropertyName("FreeCareOtherPct")] public string FreeCareOtherPct { get; set; }
}

public class FSAuditedBasisGrp
{
    [JsonPropertyName("SeparateBasisFinclStmtInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SeparateBasisFinclStmtInd { get; set; }

    [JsonPropertyName("ConsolidatedBasisFinclStmtInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ConsolidatedBasisFinclStmtInd { get; set; }

    [JsonPropertyName("ConsolAndSepBasisFinclStmtInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ConsolAndSepBasisFinclStmtInd { get; set; }
}

public class FundraiserActivityInfoGrp
{
    [JsonPropertyName("OrganizationBusinessName")]
    public OrganizationBusinessName OrganizationBusinessName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("ActivityTxt")] public string ActivityTxt { get; set; }

    [JsonPropertyName("FundraiserControlOfFundsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraiserControlOfFundsInd { get; set; }

    [JsonPropertyName("GrossReceiptsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossReceiptsAmt { get; set; }

    [JsonPropertyName("RetainedByContractorAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RetainedByContractorAmt { get; set; }

    [JsonPropertyName("NetToOrganizationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetToOrganizationAmt { get; set; }
}

public class FundraisingEventInformationGrp
{
    [JsonPropertyName("Event1Nm")] public string Event1Nm { get; set; }

    [JsonPropertyName("GrossReceiptsEvent1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossReceiptsEvent1Amt { get; set; }

    [JsonPropertyName("GrossRevenueEvent1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossRevenueEvent1Amt { get; set; }

    [JsonPropertyName("OtherDirectExpensesEvent1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherDirectExpensesEvent1Amt { get; set; }

    [JsonPropertyName("Event2Nm")] public string Event2Nm { get; set; }

    [JsonPropertyName("GrossReceiptsEvent2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossReceiptsEvent2Amt { get; set; }

    [JsonPropertyName("GrossRevenueEvent2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossRevenueEvent2Amt { get; set; }

    [JsonPropertyName("OtherDirectExpensesEvent2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherDirectExpensesEvent2Amt { get; set; }

    [JsonPropertyName("OtherEventsTotalCnt")]
    public string OtherEventsTotalCnt { get; set; }

    [JsonPropertyName("GrossReceiptsOtherEventsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossReceiptsOtherEventsAmt { get; set; }

    [JsonPropertyName("GrossRevenueOtherEventsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossRevenueOtherEventsAmt { get; set; }

    [JsonPropertyName("OthDirectExpnssOtherEventsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OthDirectExpnssOtherEventsAmt { get; set; }

    [JsonPropertyName("GrossReceiptsTotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossReceiptsTotalAmt { get; set; }

    [JsonPropertyName("GrossRevenueTotalEventsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossRevenueTotalEventsAmt { get; set; }

    [JsonPropertyName("OthDirectExpnssTotalEventsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OthDirectExpnssTotalEventsAmt { get; set; }

    [JsonPropertyName("DirectExpenseSummaryEventsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectExpenseSummaryEventsAmt { get; set; }

    [JsonPropertyName("NetIncomeSummaryAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetIncomeSummaryAmt { get; set; }

    [JsonPropertyName("NonCashPrizesEvent1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NonCashPrizesEvent1Amt { get; set; }

    [JsonPropertyName("FoodAndBeverageEvent1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FoodAndBeverageEvent1Amt { get; set; }

    [JsonPropertyName("EntertainmentEvent1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EntertainmentEvent1Amt { get; set; }

    [JsonPropertyName("RentFacilityCostsEvent2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RentFacilityCostsEvent2Amt { get; set; }

    [JsonPropertyName("FoodAndBeverageEvent2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FoodAndBeverageEvent2Amt { get; set; }

    [JsonPropertyName("NonCashPrizesTotalEventsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NonCashPrizesTotalEventsAmt { get; set; }

    [JsonPropertyName("RentFcltyCostsTotalEventsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RentFcltyCostsTotalEventsAmt { get; set; }

    [JsonPropertyName("FoodAndBeverageTotalEventsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FoodAndBeverageTotalEventsAmt { get; set; }

    [JsonPropertyName("EntertainmentTotalEventsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EntertainmentTotalEventsAmt { get; set; }

    [JsonPropertyName("CharitableContriEvent1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CharitableContriEvent1Amt { get; set; }

    [JsonPropertyName("RentFacilityCostsEvent1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RentFacilityCostsEvent1Amt { get; set; }

    [JsonPropertyName("CharitableContributionsTotAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CharitableContributionsTotAmt { get; set; }

    [JsonPropertyName("CharitableContriEvent2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CharitableContriEvent2Amt { get; set; }

    [JsonPropertyName("NonCashPrizesEvent2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NonCashPrizesEvent2Amt { get; set; }

    [JsonPropertyName("CharitableContriOtherEventsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CharitableContriOtherEventsAmt { get; set; }

    [JsonPropertyName("CashPrizesEvent1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CashPrizesEvent1Amt { get; set; }

    [JsonPropertyName("CashPrizesOtherEventsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CashPrizesOtherEventsAmt { get; set; }

    [JsonPropertyName("CashPrizesTotalEventsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CashPrizesTotalEventsAmt { get; set; }

    [JsonPropertyName("EntertainmentEvent2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EntertainmentEvent2Amt { get; set; }

    [JsonPropertyName("NonCashPrizesOtherEventsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NonCashPrizesOtherEventsAmt { get; set; }

    [JsonPropertyName("RentFcltyCostsOtherEventsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RentFcltyCostsOtherEventsAmt { get; set; }

    [JsonPropertyName("FoodAndBeverageOtherEventsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FoodAndBeverageOtherEventsAmt { get; set; }

    [JsonPropertyName("EntertainmentOtherEventsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EntertainmentOtherEventsAmt { get; set; }

    [JsonPropertyName("CashPrizesEvent2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CashPrizesEvent2Amt { get; set; }
}

public class GainLossSaleOtherAssetGrp
{
    [JsonPropertyName("AssetDesc")] public string AssetDesc { get; set; }

    [JsonPropertyName("AcquiredDt")] public string AcquiredDt { get; set; }

    [JsonPropertyName("SoldDt")] public string SoldDt { get; set; }

    [JsonPropertyName("PurchaserNameGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<PurchaserNameGrp>))]
    public List<PurchaserNameGrp> PurchaserNameGrp { get; set; }

    [JsonPropertyName("GrossSalesPriceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossSalesPriceAmt { get; set; }

    [JsonPropertyName("BasisAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BasisAmt { get; set; }

    [JsonPropertyName("TotalNetAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalNetAmt { get; set; }
}

public class GainLossSaleOtherAssetsSch
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("GainLossSaleOtherAssetGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<GainLossSaleOtherAssetGrp>))]
    public List<GainLossSaleOtherAssetGrp> GainLossSaleOtherAssetGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class GainOrLossGrp
{
    [JsonPropertyName("SecuritiesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SecuritiesAmt { get; set; }

    [JsonPropertyName("OtherAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherAmt { get; set; }
}

public class GainSalesAstOthThanInvntryGrp
{
    [JsonPropertyName("UnrelatedBusinessTaxblIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrelatedBusinessTaxblIncmAmt { get; set; }

    [JsonPropertyName("ExclusionCd")] public string ExclusionCd { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExclusionAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFunctionIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrExemptFunctionIncmAmt { get; set; }

    [JsonPropertyName("BusinessCd")] public string BusinessCd { get; set; }
}

public class GamingInformationGrp
{
    [JsonPropertyName("GrossRevenueBingoAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossRevenueBingoAmt { get; set; }

    [JsonPropertyName("OtherDirectExpensesBingoAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherDirectExpensesBingoAmt { get; set; }

    [JsonPropertyName("VolunteerLaborBingoInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string VolunteerLaborBingoInd { get; set; }

    [JsonPropertyName("VolunteerLaborBingoPct")]
    public string VolunteerLaborBingoPct { get; set; }

    [JsonPropertyName("GrossRevenuePullTabsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossRevenuePullTabsAmt { get; set; }

    [JsonPropertyName("OtherDirectExpensesPullTabsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherDirectExpensesPullTabsAmt { get; set; }

    [JsonPropertyName("VolunteerLaborPullTabsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string VolunteerLaborPullTabsInd { get; set; }

    [JsonPropertyName("VolunteerLaborPullTabsPct")]
    public string VolunteerLaborPullTabsPct { get; set; }

    [JsonPropertyName("VolunteerLaborOtherGamingInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string VolunteerLaborOtherGamingInd { get; set; }

    [JsonPropertyName("GrossRevenueTotalGamingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossRevenueTotalGamingAmt { get; set; }

    [JsonPropertyName("OthDirectExpnssTotalGamingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OthDirectExpnssTotalGamingAmt { get; set; }

    [JsonPropertyName("DirectExpenseSummaryGamingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectExpenseSummaryGamingAmt { get; set; }

    [JsonPropertyName("NetGamingIncomeSummaryAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetGamingIncomeSummaryAmt { get; set; }

    [JsonPropertyName("CashPrizesPullTabsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CashPrizesPullTabsAmt { get; set; }

    [JsonPropertyName("GrossRevenueOtherGamingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossRevenueOtherGamingAmt { get; set; }

    [JsonPropertyName("CashPrizesOtherGamingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CashPrizesOtherGamingAmt { get; set; }

    [JsonPropertyName("OthDirectExpnssOtherGamingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OthDirectExpnssOtherGamingAmt { get; set; }

    [JsonPropertyName("CashPrizesTotalGamingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CashPrizesTotalGamingAmt { get; set; }

    [JsonPropertyName("RentFacilityCostsPullTabsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RentFacilityCostsPullTabsAmt { get; set; }

    [JsonPropertyName("RentFcltyCostsTotalGamingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RentFcltyCostsTotalGamingAmt { get; set; }

    [JsonPropertyName("CashPrizesBingoAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CashPrizesBingoAmt { get; set; }

    [JsonPropertyName("RentFacilityCostsBingoAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RentFacilityCostsBingoAmt { get; set; }

    [JsonPropertyName("VolunteerLaborOtherGamingPct")]
    public string VolunteerLaborOtherGamingPct { get; set; }
}

public class GamingManagerBusinessName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }

    [JsonPropertyName("BusinessNameLine2Txt")]
    public string BusinessNameLine2Txt { get; set; }
}

public class GeneralExplanationAttachment
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("GeneralExplanationGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<GeneralExplanationGrp>))]
    public List<GeneralExplanationGrp> GeneralExplanationGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class GeneralExplanationGrp
{
    [JsonPropertyName("FormAndLineReferenceDesc")]
    public string FormAndLineReferenceDesc { get; set; }

    [JsonPropertyName("MediumExplanationTxt")]
    public string MediumExplanationTxt { get; set; }

    [JsonPropertyName("IdentifierTxt")] public string IdentifierTxt { get; set; }
}

public class GiftsGrantsContriRcvd170Grp
{
    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class GiftsGrantsContrisRcvd509Grp
{
    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }
}

public class GovtFurnSrvcFcltsVl170Grp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }
}

public class GovtFurnSrvcFcltsVl509Grp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }
}

public class GrantOrContriApprvForFutGrp
{
    [JsonPropertyName("RecipientPersonNm")]
    public string RecipientPersonNm { get; set; }

    [JsonPropertyName("RecipientUSAddress")]
    public RecipientUSAddress RecipientUSAddress { get; set; }

    [JsonPropertyName("RecipientRelationshipTxt")]
    public string RecipientRelationshipTxt { get; set; }

    [JsonPropertyName("GrantOrContributionPurposeTxt")]
    public string GrantOrContributionPurposeTxt { get; set; }

    [JsonPropertyName("Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Amt { get; set; }
}

public class GrantOrContributionPdDurYrGrp
{
    [JsonPropertyName("RecipientBusinessName")]
    public RecipientBusinessName RecipientBusinessName { get; set; }

    [JsonPropertyName("RecipientUSAddress")]
    public RecipientUSAddress RecipientUSAddress { get; set; }

    [JsonPropertyName("RecipientRelationshipTxt")]
    public string RecipientRelationshipTxt { get; set; }

    [JsonPropertyName("RecipientFoundationStatusTxt")]
    public string RecipientFoundationStatusTxt { get; set; }

    [JsonPropertyName("GrantOrContributionPurposeTxt")]
    public string GrantOrContributionPurposeTxt { get; set; }

    [JsonPropertyName("Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Amt { get; set; }
}

public class GrantsOtherAsstToIndivInUSGrp
{
    [JsonPropertyName("GrantTypeTxt")] public string GrantTypeTxt { get; set; }

    [JsonPropertyName("RecipientCnt")] public string RecipientCnt { get; set; }

    [JsonPropertyName("CashGrantAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CashGrantAmt { get; set; }
}

public class GrantsPayableGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class GrantsToDomesticIndividualsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }
}

public class GrantsToDomesticOrgsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }
}

public class GrantsToOrgOutsideUSGrp
{
    [JsonPropertyName("RegionTxt")] public string RegionTxt { get; set; }

    [JsonPropertyName("PurposeOfGrantTxt")]
    public string PurposeOfGrantTxt { get; set; }

    [JsonPropertyName("CashGrantAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CashGrantAmt { get; set; }

    [JsonPropertyName("MannerOfCashDisbursementTxt")]
    public string MannerOfCashDisbursementTxt { get; set; }
}

public class GrassrootsNontaxableGrp
{
    [JsonPropertyName("FilingOrganizationsTotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FilingOrganizationsTotalAmt { get; set; }
}

public class GrntAsstBnftInterestedPrsnGrp
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("RelationshipWithOrgTxt")]
    public string RelationshipWithOrgTxt { get; set; }

    [JsonPropertyName("CashGrantAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CashGrantAmt { get; set; }

    [JsonPropertyName("TypeOfAssistanceTxt")]
    public string TypeOfAssistanceTxt { get; set; }

    [JsonPropertyName("AssistancePurposeTxt")]
    public string AssistancePurposeTxt { get; set; }
}

public class GrossAmountSalesAssetsGrp
{
    [JsonPropertyName("SecuritiesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SecuritiesAmt { get; set; }

    [JsonPropertyName("OtherAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherAmt { get; set; }
}

public class GrossInvestmentIncome170Grp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }
}

public class GrossInvestmentIncome509Grp
{
    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class GrossInvestmentIncomeGrp
{
    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year3Amt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}


public class GrossReceiptsAdmissionsGrp
{
    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class GrossReceiptsNonUnrltBusGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }
}

public class GrossRentsGrp
{
    [JsonPropertyName("RealAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RealAmt { get; set; }

    [JsonPropertyName("PersonalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PersonalAmt { get; set; }
}

public class HealthImprovementAdvocacyGrp
{
    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }

    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }
}

public class HealthProfessionsEducationGrp
{
    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }
}

public class HospitalFacilitiesGrp
{
    [JsonPropertyName("FacilityNum")] public string FacilityNum { get; set; }

    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("WebsiteAddressTxt")]
    public string WebsiteAddressTxt { get; set; }

    [JsonPropertyName("StateLicenseNum")] public string StateLicenseNum { get; set; }

    [JsonPropertyName("LicensedHospitalInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LicensedHospitalInd { get; set; }

    [JsonPropertyName("GeneralMedicalAndSurgicalInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GeneralMedicalAndSurgicalInd { get; set; }

    [JsonPropertyName("CriticalAccessHospitalInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CriticalAccessHospitalInd { get; set; }

    [JsonPropertyName("EmergencyRoom24HrsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string EmergencyRoom24HrsInd { get; set; }
}

public class HospitalFacilityName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }
}

public class HospitalFcltyPoliciesPrctcGrp
{
    [JsonPropertyName("HospitalFacilityName")]
    public HospitalFacilityName HospitalFacilityName { get; set; }

    [JsonPropertyName("FacilityNum")] public string FacilityNum { get; set; }

    [JsonPropertyName("FirstLicensedCYOrPYInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FirstLicensedCYOrPYInd { get; set; }

    [JsonPropertyName("TaxExemptHospitalCYOrPYInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxExemptHospitalCYOrPYInd { get; set; }

    [JsonPropertyName("CHNAConductedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CHNAConductedInd { get; set; }

    [JsonPropertyName("CommunityDefinitionInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CommunityDefinitionInd { get; set; }

    [JsonPropertyName("CommunityDemographicsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CommunityDemographicsInd { get; set; }

    [JsonPropertyName("ExistingResourcesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExistingResourcesInd { get; set; }

    [JsonPropertyName("HowDataObtainedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string HowDataObtainedInd { get; set; }

    [JsonPropertyName("CommunityHealthNeedsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CommunityHealthNeedsInd { get; set; }

    [JsonPropertyName("OtherHealthIssuesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherHealthIssuesInd { get; set; }

    [JsonPropertyName("CommunityHlthNeedsIdProcessInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CommunityHlthNeedsIdProcessInd { get; set; }

    [JsonPropertyName("ConsultingProcessInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ConsultingProcessInd { get; set; }

    [JsonPropertyName("PriorCHNAImpactInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorCHNAImpactInd { get; set; }

    [JsonPropertyName("CHNAConductedYr")] public string CHNAConductedYr { get; set; }

    [JsonPropertyName("TakeIntoAccountOthersInputInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TakeIntoAccountOthersInputInd { get; set; }

    [JsonPropertyName("CHNAConductedWithOtherFcltsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CHNAConductedWithOtherFcltsInd { get; set; }

    [JsonPropertyName("CHNAConductedWithNonFcltsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CHNAConductedWithNonFcltsInd { get; set; }

    [JsonPropertyName("CHNAReportWidelyAvailableInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CHNAReportWidelyAvailableInd { get; set; }

    [JsonPropertyName("RptAvailableOnOwnWebsiteInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string RptAvailableOnOwnWebsiteInd { get; set; }

    [JsonPropertyName("OwnWebsiteURLTxt")] public string OwnWebsiteURLTxt { get; set; }

    [JsonPropertyName("OtherWebsiteInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherWebsiteInd { get; set; }

    [JsonPropertyName("OtherWebsiteURLTxt")]
    public string OtherWebsiteURLTxt { get; set; }

    [JsonPropertyName("PaperCopyPublicInspectionInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PaperCopyPublicInspectionInd { get; set; }

    [JsonPropertyName("ImplementationStrategyAdoptInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ImplementationStrategyAdoptInd { get; set; }

    [JsonPropertyName("ImplementationStrategyAdptYr")]
    public string ImplementationStrategyAdptYr { get; set; }

    [JsonPropertyName("StrategyPostedWebsiteInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string StrategyPostedWebsiteInd { get; set; }

    [JsonPropertyName("StrategyWebsiteURLTxt")]
    public string StrategyWebsiteURLTxt { get; set; }

    [JsonPropertyName("StrategyAttachedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string StrategyAttachedInd { get; set; }

    [JsonPropertyName("OrganizationIncurExciseTaxInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OrganizationIncurExciseTaxInd { get; set; }

    [JsonPropertyName("EligCriteriaExplainedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string EligCriteriaExplainedInd { get; set; }

    [JsonPropertyName("FPGFamilyIncmLmtFreeDscntInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FPGFamilyIncmLmtFreeDscntInd { get; set; }

    [JsonPropertyName("FPGFamilyIncmLmtFreeCarePct")]
    public string FPGFamilyIncmLmtFreeCarePct { get; set; }

    [JsonPropertyName("FPGFamilyIncmLmtDscntCarePct")]
    public string FPGFamilyIncmLmtDscntCarePct { get; set; }

    [JsonPropertyName("AssetLevelCriteriaInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AssetLevelCriteriaInd { get; set; }

    [JsonPropertyName("MedicalIndigencyCriteriaInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MedicalIndigencyCriteriaInd { get; set; }

    [JsonPropertyName("InsuranceStatusCriteriaInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InsuranceStatusCriteriaInd { get; set; }

    [JsonPropertyName("UnderinsuranceStatCriteriaInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnderinsuranceStatCriteriaInd { get; set; }

    [JsonPropertyName("ExplainedBasisInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExplainedBasisInd { get; set; }

    [JsonPropertyName("AppFinancialAsstExplnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AppFinancialAsstExplnInd { get; set; }

    [JsonPropertyName("DescribedInfoInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DescribedInfoInd { get; set; }

    [JsonPropertyName("DescribedSuprtDocInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DescribedSuprtDocInd { get; set; }

    [JsonPropertyName("ProvidedHospitalContactInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProvidedHospitalContactInd { get; set; }

    [JsonPropertyName("IncludesPublicityMeasuresInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string IncludesPublicityMeasuresInd { get; set; }

    [JsonPropertyName("FAPAvailableOnWebsiteInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FAPAvailableOnWebsiteInd { get; set; }

    [JsonPropertyName("FAPAvailableOnWebsiteURLTxt")]
    public string FAPAvailableOnWebsiteURLTxt { get; set; }

    [JsonPropertyName("FAPAppAvailableOnWebsiteInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FAPAppAvailableOnWebsiteInd { get; set; }

    [JsonPropertyName("FAPAppAvailableOnWebsiteURLTxt")]
    public string FAPAppAvailableOnWebsiteURLTxt { get; set; }

    [JsonPropertyName("FAPSummaryOnWebsiteInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FAPSummaryOnWebsiteInd { get; set; }

    [JsonPropertyName("FAPSummaryOnWebsiteURLTxt")]
    public string FAPSummaryOnWebsiteURLTxt { get; set; }

    [JsonPropertyName("FAPAvlblOnRequestNoChargeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FAPAvlblOnRequestNoChargeInd { get; set; }

    [JsonPropertyName("FAPAppAvlblOnRequestNoChrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FAPAppAvlblOnRequestNoChrgInd { get; set; }

    [JsonPropertyName("FAPSumAvlblOnRequestNoChrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FAPSumAvlblOnRequestNoChrgInd { get; set; }

    [JsonPropertyName("NotifiedFAPCopyBillDisplayInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string NotifiedFAPCopyBillDisplayInd { get; set; }

    [JsonPropertyName("CommuntityNotifiedFAPInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CommuntityNotifiedFAPInd { get; set; }

    [JsonPropertyName("FAPTranslatedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FAPTranslatedInd { get; set; }

    [JsonPropertyName("FAPActionsOnNonpaymentInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FAPActionsOnNonpaymentInd { get; set; }

    [JsonPropertyName("PermitNoActionsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PermitNoActionsInd { get; set; }

    [JsonPropertyName("CollectionActivitiesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CollectionActivitiesInd { get; set; }

    [JsonPropertyName("ProvidedWrittenNoticeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProvidedWrittenNoticeInd { get; set; }

    [JsonPropertyName("MadeEffortOrallyNotifyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MadeEffortOrallyNotifyInd { get; set; }

    [JsonPropertyName("ProcessedFAPApplicationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProcessedFAPApplicationInd { get; set; }

    [JsonPropertyName("MadePresumptiveEligDetermInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MadePresumptiveEligDetermInd { get; set; }

    [JsonPropertyName("NondisEmergencyCarePolicyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string NondisEmergencyCarePolicyInd { get; set; }

    [JsonPropertyName("LookBackMedicareInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LookBackMedicareInd { get; set; }

    [JsonPropertyName("AmountsGenerallyBilledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AmountsGenerallyBilledInd { get; set; }

    [JsonPropertyName("GrossChargesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossChargesInd { get; set; }
}

public class HospitalNameAndAddressGrp
{
    [JsonPropertyName("SupportedOrganizationName")]
    public SupportedOrganizationName SupportedOrganizationName { get; set; }

    [JsonPropertyName("CityNm")] public string CityNm { get; set; }

    [JsonPropertyName("StateAbbreviationCd")]
    public string StateAbbreviationCd { get; set; }
}

public class IdDisregardedEntitiesGrp
{
    [JsonPropertyName("DisregardedEntityName")]
    public DisregardedEntityName DisregardedEntityName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("EIN")] public string EIN { get; set; }

    [JsonPropertyName("PrimaryActivitiesTxt")]
    public string PrimaryActivitiesTxt { get; set; }

    [JsonPropertyName("LegalDomicileStateCd")]
    public string LegalDomicileStateCd { get; set; }

    [JsonPropertyName("TotalIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalIncomeAmt { get; set; }

    [JsonPropertyName("EndOfYearAssetsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EndOfYearAssetsAmt { get; set; }

    [JsonPropertyName("DirectControllingEntityName")]
    public DirectControllingEntityName DirectControllingEntityName { get; set; }
}

public class IdRelatedOrgTxblCorpTrGrp
{
    [JsonPropertyName("RelatedOrganizationName")]
    public RelatedOrganizationName RelatedOrganizationName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("EIN")] public string EIN { get; set; }

    [JsonPropertyName("PrimaryActivitiesTxt")]
    public string PrimaryActivitiesTxt { get; set; }

    [JsonPropertyName("LegalDomicileStateCd")]
    public string LegalDomicileStateCd { get; set; }

    [JsonPropertyName("DirectControllingNACd")]
    public string DirectControllingNACd { get; set; }

    [JsonPropertyName("EntityTypeTxt")] public string EntityTypeTxt { get; set; }

    [JsonPropertyName("ControlledOrganizationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ControlledOrganizationInd { get; set; }
}

public class IdRelatedOrgTxblPartnershipGrp
{
    [JsonPropertyName("RelatedOrganizationName")]
    public RelatedOrganizationName RelatedOrganizationName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("EIN")] public string EIN { get; set; }

    [JsonPropertyName("PrimaryActivitiesTxt")]
    public string PrimaryActivitiesTxt { get; set; }

    [JsonPropertyName("LegalDomicileStateCd")]
    public string LegalDomicileStateCd { get; set; }

    [JsonPropertyName("PredominantIncomeTypeTxt")]
    public string PredominantIncomeTypeTxt { get; set; }

    [JsonPropertyName("ShareOfTotalIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ShareOfTotalIncomeAmt { get; set; }

    [JsonPropertyName("DisproportionateAllocationsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DisproportionateAllocationsInd { get; set; }

    [JsonPropertyName("GeneralOrManagingPartnerInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GeneralOrManagingPartnerInd { get; set; }

    [JsonPropertyName("DirectControllingNACd")]
    public string DirectControllingNACd { get; set; }

    [JsonPropertyName("ShareOfEOYAssetsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ShareOfEOYAssetsAmt { get; set; }
}

public class IdRelatedTaxExemptOrgGrp
{
    [JsonPropertyName("DisregardedEntityName")]
    public DisregardedEntityName DisregardedEntityName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("EIN")] public string EIN { get; set; }

    [JsonPropertyName("PrimaryActivitiesTxt")]
    public string PrimaryActivitiesTxt { get; set; }

    [JsonPropertyName("LegalDomicileStateCd")]
    public string LegalDomicileStateCd { get; set; }

    [JsonPropertyName("ExemptCodeSectionTxt")]
    public string ExemptCodeSectionTxt { get; set; }

    [JsonPropertyName("PublicCharityStatusTxt")]
    public string PublicCharityStatusTxt { get; set; }

    [JsonPropertyName("ControlledOrganizationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ControlledOrganizationInd { get; set; }

    [JsonPropertyName("DirectControllingNACd")]
    public string DirectControllingNACd { get; set; }
}

public class IncmFromInvestBondProceedsGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExclusionAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrelatedBusinessRevenueAmt { get; set; }
}

public class InformationTechnologyGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class InsuranceGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class IntangibleAssetsGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }
}

public class InterestGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class InventoriesForSaleOrUseGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }
}

public class InventorySaleGrp
{
    [JsonPropertyName("CategoryTxt")] public string CategoryTxt { get; set; }

    [JsonPropertyName("GrossSalesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossSalesAmt { get; set; }

    [JsonPropertyName("CostOfGoodsSoldAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CostOfGoodsSoldAmt { get; set; }

    [JsonPropertyName("NetAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetAmt { get; set; }
}

public class InvestmentIncomeAndUBTIGrp
{
    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class InvestmentIncomeGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExclusionAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrelatedBusinessRevenueAmt { get; set; }
}

public class InvestmentLandGrp
{
    [JsonPropertyName("CategoryOrItemTxt")]
    public string CategoryOrItemTxt { get; set; }

    [JsonPropertyName("CostOrOtherBasisAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CostOrOtherBasisAmt { get; set; }

    [JsonPropertyName("AccumulatedDepreciationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AccumulatedDepreciationAmt { get; set; }

    [JsonPropertyName("BookValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BookValueAmt { get; set; }
}

public class InvestmentsCorpBondsSchedule
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("InvestmentsCorporateBondsGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<InvestmentsCorporateBondsGrp>))]
    public List<InvestmentsCorporateBondsGrp> InvestmentsCorporateBondsGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class InvestmentsCorporateBondsGrp
{
    [JsonPropertyName("BondNm")] public string BondNm { get; set; }

    [JsonPropertyName("EOYBookValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYBookValueAmt { get; set; }

    [JsonPropertyName("EOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYFMVAmt { get; set; }
}

public class InvestmentsCorporateStockGrp
{
    [JsonPropertyName("StockNm")] public string StockNm { get; set; }

    [JsonPropertyName("EOYBookValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYBookValueAmt { get; set; }

    [JsonPropertyName("EOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYFMVAmt { get; set; }
}

public class InvestmentsCorpStockSchedule
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("InvestmentsCorporateStockGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<InvestmentsCorporateStockGrp>))]
    public List<InvestmentsCorporateStockGrp> InvestmentsCorporateStockGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }
}

public class InvestmentsGovtObligationsSch
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("USGovtObligationsBookVlEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string USGovtObligationsBookVlEOYAmt { get; set; }

    [JsonPropertyName("USGovtObligationsEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string USGovtObligationsEOYFMVAmt { get; set; }

    [JsonPropertyName("StateLocalSecBookVlEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string StateLocalSecBookVlEOYAmt { get; set; }

    [JsonPropertyName("StateLocalSecEOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string StateLocalSecEOYFMVAmt { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class InvestmentsLandSchedule2
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("InvestmentLandGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<InvestmentLandGrp>))]
    public List<InvestmentLandGrp> InvestmentLandGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }
}

public class InvestmentsOtherGrp
{
    [JsonPropertyName("CategoryOrItemTxt")]
    public string CategoryOrItemTxt { get; set; }

    [JsonPropertyName("ListedAtCostOrFMVCd")]
    public string ListedAtCostOrFMVCd { get; set; }

    [JsonPropertyName("BookValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BookValueAmt { get; set; }

    [JsonPropertyName("EOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYFMVAmt { get; set; }
}

public class InvestmentsOtherSchedule2
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("InvestmentsOtherGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<InvestmentsOtherGrp>))]
    public List<InvestmentsOtherGrp> InvestmentsOtherGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }
}

public class InvestmentsOtherSecuritiesGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }
}

public class InvestmentsProgramRelatedGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }
}

public class InvestmentsPubTradedSecGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }
}

public class InvstProgramRelatedOrgGrp
{
    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("BookValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BookValueAmt { get; set; }

    [JsonPropertyName("MethodValuationCd")]
    public string MethodValuationCd { get; set; }
}

public class IPAddress
{
    [JsonPropertyName("IPv4AddressTxt")] public string IPv4AddressTxt { get; set; }
}

public class IRS990
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("@referenceDocumentId")]
    public string ReferenceDocumentId { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("GrossReceiptsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossReceiptsAmt { get; set; }

    [JsonPropertyName("GroupReturnForAffiliatesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GroupReturnForAffiliatesInd { get; set; }

    [JsonPropertyName("AllAffiliatesIncludedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AllAffiliatesIncludedInd { get; set; }

    [JsonPropertyName("Organization501cInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Organization501cInd { get; set; }

    [JsonPropertyName("WebsiteAddressTxt")]
    public string WebsiteAddressTxt { get; set; }

    [JsonPropertyName("TypeOfOrganizationTrustInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TypeOfOrganizationTrustInd { get; set; }

    [JsonPropertyName("FormationYr")] public string FormationYr { get; set; }

    [JsonPropertyName("LegalDomicileStateCd")]
    public string LegalDomicileStateCd { get; set; }

    [JsonPropertyName("ActivityOrMissionDesc")]
    public string ActivityOrMissionDesc { get; set; }

    [JsonPropertyName("VotingMembersGoverningBodyCnt")]
    public string VotingMembersGoverningBodyCnt { get; set; }

    [JsonPropertyName("VotingMembersIndependentCnt")]
    public string VotingMembersIndependentCnt { get; set; }

    [JsonPropertyName("TotalEmployeeCnt")] public string TotalEmployeeCnt { get; set; }

    [JsonPropertyName("TotalGrossUBIAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalGrossUBIAmt { get; set; }

    [JsonPropertyName("CYContributionsGrantsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYContributionsGrantsAmt { get; set; }

    [JsonPropertyName("PYProgramServiceRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PYProgramServiceRevenueAmt { get; set; }

    [JsonPropertyName("CYProgramServiceRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYProgramServiceRevenueAmt { get; set; }

    [JsonPropertyName("PYInvestmentIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PYInvestmentIncomeAmt { get; set; }

    [JsonPropertyName("CYInvestmentIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYInvestmentIncomeAmt { get; set; }

    [JsonPropertyName("CYOtherRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYOtherRevenueAmt { get; set; }

    [JsonPropertyName("PYTotalRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PYTotalRevenueAmt { get; set; }

    [JsonPropertyName("CYTotalRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYTotalRevenueAmt { get; set; }

    [JsonPropertyName("CYGrantsAndSimilarPaidAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYGrantsAndSimilarPaidAmt { get; set; }

    [JsonPropertyName("PYBenefitsPaidToMembersAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PYBenefitsPaidToMembersAmt { get; set; }

    [JsonPropertyName("CYBenefitsPaidToMembersAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYBenefitsPaidToMembersAmt { get; set; }

    [JsonPropertyName("PYSalariesCompEmpBnftPaidAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PYSalariesCompEmpBnftPaidAmt { get; set; }

    [JsonPropertyName("CYSalariesCompEmpBnftPaidAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYSalariesCompEmpBnftPaidAmt { get; set; }

    [JsonPropertyName("CYTotalProfFndrsngExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYTotalProfFndrsngExpnsAmt { get; set; }

    [JsonPropertyName("CYTotalFundraisingExpenseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYTotalFundraisingExpenseAmt { get; set; }

    [JsonPropertyName("PYOtherExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PYOtherExpensesAmt { get; set; }

    [JsonPropertyName("CYOtherExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYOtherExpensesAmt { get; set; }

    [JsonPropertyName("PYTotalExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PYTotalExpensesAmt { get; set; }

    [JsonPropertyName("CYTotalExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYTotalExpensesAmt { get; set; }

    [JsonPropertyName("PYRevenuesLessExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PYRevenuesLessExpensesAmt { get; set; }

    [JsonPropertyName("CYRevenuesLessExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CYRevenuesLessExpensesAmt { get; set; }

    [JsonPropertyName("TotalAssetsBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAssetsBOYAmt { get; set; }

    [JsonPropertyName("TotalAssetsEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAssetsEOYAmt { get; set; }

    [JsonPropertyName("TotalLiabilitiesBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalLiabilitiesBOYAmt { get; set; }

    [JsonPropertyName("TotalLiabilitiesEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalLiabilitiesEOYAmt { get; set; }

    [JsonPropertyName("NetAssetsOrFundBalancesBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetAssetsOrFundBalancesBOYAmt { get; set; }

    [JsonPropertyName("NetAssetsOrFundBalancesEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetAssetsOrFundBalancesEOYAmt { get; set; }

    [JsonPropertyName("MissionDesc")] public string MissionDesc { get; set; }

    [JsonPropertyName("SignificantNewProgramSrvcInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SignificantNewProgramSrvcInd { get; set; }

    [JsonPropertyName("SignificantChangeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SignificantChangeInd { get; set; }

    [JsonPropertyName("ExpenseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExpenseAmt { get; set; }

    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("TotalProgramServiceExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalProgramServiceExpensesAmt { get; set; }

    [JsonPropertyName("DescribedInSection501c3Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string DescribedInSection501c3Ind { get; set; }

    [JsonPropertyName("ScheduleBRequiredInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ScheduleBRequiredInd { get; set; }

    [JsonPropertyName("PoliticalCampaignActyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PoliticalCampaignActyInd { get; set; }

    [JsonPropertyName("SubjectToProxyTaxInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SubjectToProxyTaxInd { get; set; }

    [JsonPropertyName("DonorAdvisedFundInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DonorAdvisedFundInd { get; set; }

    [JsonPropertyName("ConservationEasementsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ConservationEasementsInd { get; set; }

    [JsonPropertyName("CollectionsOfArtInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CollectionsOfArtInd { get; set; }

    [JsonPropertyName("CreditCounselingInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CreditCounselingInd { get; set; }

    [JsonPropertyName("TempOrPermanentEndowmentsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TempOrPermanentEndowmentsInd { get; set; }

    [JsonPropertyName("ReportLandBuildingEquipmentInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReportLandBuildingEquipmentInd { get; set; }

    [JsonPropertyName("ReportInvestmentsOtherSecInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReportInvestmentsOtherSecInd { get; set; }

    [JsonPropertyName("ReportProgramRelatedInvstInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReportProgramRelatedInvstInd { get; set; }

    [JsonPropertyName("ReportOtherAssetsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReportOtherAssetsInd { get; set; }

    [JsonPropertyName("ReportOtherLiabilitiesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReportOtherLiabilitiesInd { get; set; }

    [JsonPropertyName("IncludeFIN48FootnoteInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string IncludeFIN48FootnoteInd { get; set; }

    [JsonPropertyName("IndependentAuditFinclStmtInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string IndependentAuditFinclStmtInd { get; set; }

    [JsonPropertyName("ConsolidatedAuditFinclStmtInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ConsolidatedAuditFinclStmtInd { get; set; }

    [JsonPropertyName("SchoolOperatingInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SchoolOperatingInd { get; set; }

    [JsonPropertyName("ForeignOfficeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ForeignOfficeInd { get; set; }

    [JsonPropertyName("ForeignActivitiesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ForeignActivitiesInd { get; set; }

    [JsonPropertyName("MoreThan5000KToOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MoreThan5000KToOrgInd { get; set; }

    [JsonPropertyName("MoreThan5000KToIndividualsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MoreThan5000KToIndividualsInd { get; set; }

    [JsonPropertyName("ProfessionalFundraisingInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProfessionalFundraisingInd { get; set; }

    [JsonPropertyName("FundraisingActivitiesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingActivitiesInd { get; set; }

    [JsonPropertyName("GamingActivitiesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GamingActivitiesInd { get; set; }

    [JsonPropertyName("OperateHospitalInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OperateHospitalInd { get; set; }

    [JsonPropertyName("GrantsToOrganizationsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantsToOrganizationsInd { get; set; }

    [JsonPropertyName("GrantsToIndividualsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantsToIndividualsInd { get; set; }

    [JsonPropertyName("ScheduleJRequiredInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ScheduleJRequiredInd { get; set; }

    [JsonPropertyName("TaxExemptBondsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxExemptBondsInd { get; set; }

    [JsonPropertyName("InvestTaxExemptBondsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvestTaxExemptBondsInd { get; set; }

    [JsonPropertyName("EscrowAccountInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string EscrowAccountInd { get; set; }

    [JsonPropertyName("OnBehalfOfIssuerInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OnBehalfOfIssuerInd { get; set; }

    [JsonPropertyName("LoanOutstandingInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LoanOutstandingInd { get; set; }

    [JsonPropertyName("GrantToRelatedPersonInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantToRelatedPersonInd { get; set; }

    [JsonPropertyName("BusinessRlnWithOrgMemInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string BusinessRlnWithOrgMemInd { get; set; }

    [JsonPropertyName("BusinessRlnWithFamMemInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string BusinessRlnWithFamMemInd { get; set; }

    [JsonPropertyName("BusinessRlnWithOfficerEntInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string BusinessRlnWithOfficerEntInd { get; set; }

    [JsonPropertyName("DeductibleNonCashContriInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DeductibleNonCashContriInd { get; set; }

    [JsonPropertyName("DeductibleArtContributionInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DeductibleArtContributionInd { get; set; }

    [JsonPropertyName("TerminateOperationsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TerminateOperationsInd { get; set; }

    [JsonPropertyName("PartialLiquidationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PartialLiquidationInd { get; set; }

    [JsonPropertyName("DisregardedEntityInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DisregardedEntityInd { get; set; }

    [JsonPropertyName("RelatedEntityInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedEntityInd { get; set; }

    [JsonPropertyName("RelatedOrganizationCtrlEntInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrganizationCtrlEntInd { get; set; }

    [JsonPropertyName("ActivitiesConductedPrtshpInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ActivitiesConductedPrtshpInd { get; set; }

    [JsonPropertyName("ScheduleORequiredInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ScheduleORequiredInd { get; set; }

    [JsonPropertyName("IRPDocumentCnt")] public string IRPDocumentCnt { get; set; }

    [JsonPropertyName("IRPDocumentW2GCnt")]
    public string IRPDocumentW2GCnt { get; set; }

    [JsonPropertyName("BackupWthldComplianceInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string BackupWthldComplianceInd { get; set; }

    [JsonPropertyName("EmployeeCnt")] public string EmployeeCnt { get; set; }

    [JsonPropertyName("EmploymentTaxReturnsFiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string EmploymentTaxReturnsFiledInd { get; set; }

    [JsonPropertyName("UnrelatedBusIncmOverLimitInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrelatedBusIncmOverLimitInd { get; set; }

    [JsonPropertyName("Form990TFiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form990TFiledInd { get; set; }

    [JsonPropertyName("ForeignFinancialAccountInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ForeignFinancialAccountInd { get; set; }

    [JsonPropertyName("ProhibitedTaxShelterTransInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProhibitedTaxShelterTransInd { get; set; }

    [JsonPropertyName("TaxablePartyNotificationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxablePartyNotificationInd { get; set; }

    [JsonPropertyName("NondeductibleContributionsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string NondeductibleContributionsInd { get; set; }

    [JsonPropertyName("DAFExcessBusinessHoldingsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DAFExcessBusinessHoldingsInd { get; set; }

    [JsonPropertyName("TaxableDistributionsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxableDistributionsInd { get; set; }

    [JsonPropertyName("DistributionToDonorInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DistributionToDonorInd { get; set; }

    [JsonPropertyName("OrgFiledInLieuOfForm1041Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string OrgFiledInLieuOfForm1041Ind { get; set; }

    [JsonPropertyName("LicensedMoreThanOneStateInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LicensedMoreThanOneStateInd { get; set; }

    [JsonPropertyName("IndoorTanningServicesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string IndoorTanningServicesInd { get; set; }

    [JsonPropertyName("InfoInScheduleOPartVIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InfoInScheduleOPartVIInd { get; set; }

    [JsonPropertyName("GoverningBodyVotingMembersCnt")]
    public string GoverningBodyVotingMembersCnt { get; set; }

    [JsonPropertyName("IndependentVotingMemberCnt")]
    public string IndependentVotingMemberCnt { get; set; }

    [JsonPropertyName("FamilyOrBusinessRlnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FamilyOrBusinessRlnInd { get; set; }

    [JsonPropertyName("DelegationOfMgmtDutiesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DelegationOfMgmtDutiesInd { get; set; }

    [JsonPropertyName("ChangeToOrgDocumentsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ChangeToOrgDocumentsInd { get; set; }

    [JsonPropertyName("MaterialDiversionOrMisuseInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MaterialDiversionOrMisuseInd { get; set; }

    [JsonPropertyName("MembersOrStockholdersInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MembersOrStockholdersInd { get; set; }

    [JsonPropertyName("ElectionOfBoardMembersInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ElectionOfBoardMembersInd { get; set; }

    [JsonPropertyName("DecisionsSubjectToApprovaInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DecisionsSubjectToApprovaInd { get; set; }

    [JsonPropertyName("MinutesOfGoverningBodyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MinutesOfGoverningBodyInd { get; set; }

    [JsonPropertyName("MinutesOfCommitteesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MinutesOfCommitteesInd { get; set; }

    [JsonPropertyName("OfficerMailingAddressInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OfficerMailingAddressInd { get; set; }

    [JsonPropertyName("LocalChaptersInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LocalChaptersInd { get; set; }

    [JsonPropertyName("Form990ProvidedToGvrnBodyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form990ProvidedToGvrnBodyInd { get; set; }

    [JsonPropertyName("ConflictOfInterestPolicyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ConflictOfInterestPolicyInd { get; set; }

    [JsonPropertyName("AnnualDisclosureCoveredPrsnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AnnualDisclosureCoveredPrsnInd { get; set; }

    [JsonPropertyName("RegularMonitoringEnfrcInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string RegularMonitoringEnfrcInd { get; set; }

    [JsonPropertyName("WhistleblowerPolicyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string WhistleblowerPolicyInd { get; set; }

    [JsonPropertyName("DocumentRetentionPolicyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DocumentRetentionPolicyInd { get; set; }

    [JsonPropertyName("CompensationProcessCEOInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompensationProcessCEOInd { get; set; }

    [JsonPropertyName("CompensationProcessOtherInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompensationProcessOtherInd { get; set; }

    [JsonPropertyName("InvestmentInJointVentureInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvestmentInJointVentureInd { get; set; }

    [JsonPropertyName("OwnWebsiteInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OwnWebsiteInd { get; set; }

    [JsonPropertyName("UponRequestInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string UponRequestInd { get; set; }

    [JsonPropertyName("BooksInCareOfDetail")]
    public BooksInCareOfDetail BooksInCareOfDetail { get; set; }

    [JsonPropertyName("Form990PartVIISectionAGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<Form990PartVIISectionAGrp>))]
    public List<Form990PartVIISectionAGrp> Form990PartVIISectionAGrp { get; set; }

    [JsonPropertyName("TotalReportableCompFromOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalReportableCompFromOrgAmt { get; set; }

    [JsonPropertyName("IndivRcvdGreaterThan100KCnt")]
    public string IndivRcvdGreaterThan100KCnt { get; set; }

    [JsonPropertyName("FormerOfcrEmployeesListedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FormerOfcrEmployeesListedInd { get; set; }

    [JsonPropertyName("TotalCompGreaterThan150KInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCompGreaterThan150KInd { get; set; }

    [JsonPropertyName("CompensationFromOtherSrcsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompensationFromOtherSrcsInd { get; set; }

    [JsonPropertyName("CntrctRcvdGreaterThan100KCnt")]
    public string CntrctRcvdGreaterThan100KCnt { get; set; }

    [JsonPropertyName("TotalContributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalContributionsAmt { get; set; }

    [JsonPropertyName("ProgramServiceRevenueGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<ProgramServiceRevenueGrp>))]
    public List<ProgramServiceRevenueGrp> ProgramServiceRevenueGrp { get; set; }

    [JsonPropertyName("TotalProgramServiceRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalProgramServiceRevenueAmt { get; set; }

    [JsonPropertyName("InvestmentIncomeGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<InvestmentIncomeGrp>))]
    public List<InvestmentIncomeGrp> InvestmentIncomeGrp { get; set; }

    [JsonPropertyName("IncmFromInvestBondProceedsGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<IncmFromInvestBondProceedsGrp>))]
    public List<IncmFromInvestBondProceedsGrp> IncmFromInvestBondProceedsGrp { get; set; }

    [JsonPropertyName("RoyaltiesRevenueGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<RoyaltiesRevenueGrp>))]
    public List<RoyaltiesRevenueGrp> RoyaltiesRevenueGrp { get; set; }

    [JsonPropertyName("NetRentalIncomeOrLossGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<NetRentalIncomeOrLossGrp>))]
    public List<NetRentalIncomeOrLossGrp> NetRentalIncomeOrLossGrp { get; set; }

    [JsonPropertyName("NetGainOrLossInvestmentsGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<NetGainOrLossInvestmentsGrp>))]
    public List<NetGainOrLossInvestmentsGrp> NetGainOrLossInvestmentsGrp { get; set; }

    [JsonPropertyName("NetIncmFromFundraisingEvtGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<NetIncmFromFundraisingEvtGrp>))]
    public List<NetIncmFromFundraisingEvtGrp> NetIncmFromFundraisingEvtGrp { get; set; }

    [JsonPropertyName("NetIncomeFromGamingGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<NetIncomeFromGamingGrp>))]
    public List<NetIncomeFromGamingGrp> NetIncomeFromGamingGrp { get; set; }

    [JsonPropertyName("NetIncomeOrLossGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<NetIncomeOrLossGrp>))]
    public List<NetIncomeOrLossGrp> NetIncomeOrLossGrp { get; set; }

    [JsonPropertyName("OtherRevenueTotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherRevenueTotalAmt { get; set; }

    [JsonPropertyName("TotalRevenueGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<TotalRevenueGrp>))]
    public List<TotalRevenueGrp> TotalRevenueGrp { get; set; }

    [JsonPropertyName("GrantsToDomesticOrgsGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<GrantsToDomesticOrgsGrp>))]
    public List<GrantsToDomesticOrgsGrp> GrantsToDomesticOrgsGrp { get; set; }

    [JsonPropertyName("GrantsToDomesticIndividualsGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<GrantsToDomesticIndividualsGrp>))]
    public List<GrantsToDomesticIndividualsGrp> GrantsToDomesticIndividualsGrp { get; set; }

    [JsonPropertyName("ForeignGrantsGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<ForeignGrantsGrp>))]
    public List<ForeignGrantsGrp> ForeignGrantsGrp { get; set; }

    [JsonPropertyName("BenefitsToMembersGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<BenefitsToMembersGrp>))]
    public List<BenefitsToMembersGrp> BenefitsToMembersGrp { get; set; }

    [JsonPropertyName("CompCurrentOfcrDirectorsGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<CompCurrentOfcrDirectorsGrp>))]
    public List<CompCurrentOfcrDirectorsGrp> CompCurrentOfcrDirectorsGrp { get; set; }

    [JsonPropertyName("CompDisqualPersonsGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<CompDisqualPersonsGrp>))]
    public List<CompDisqualPersonsGrp> CompDisqualPersonsGrp { get; set; }

    [JsonPropertyName("OtherSalariesAndWagesGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<OtherSalariesAndWagesGrp>))]
    public List<OtherSalariesAndWagesGrp> OtherSalariesAndWagesGrp { get; set; }

    [JsonPropertyName("PensionPlanContributionsGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<PensionPlanContributionsGrp>))]
    public List<PensionPlanContributionsGrp> PensionPlanContributionsGrp { get; set; }

    [JsonPropertyName("OtherEmployeeBenefitsGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<OtherEmployeeBenefitsGrp>))]
    public List<OtherEmployeeBenefitsGrp> OtherEmployeeBenefitsGrp { get; set; }

    [JsonPropertyName("PayrollTaxesGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<PayrollTaxesGrp>))]
    public List<PayrollTaxesGrp> PayrollTaxesGrp { get; set; }

    [JsonPropertyName("FeesForServicesManagementGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<FeesForServicesManagementGrp>))]
    public List<FeesForServicesManagementGrp> FeesForServicesManagementGrp { get; set; }

    [JsonPropertyName("FeesForServicesLegalGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<FeesForServicesLegalGrp>))]
    public List<FeesForServicesLegalGrp> FeesForServicesLegalGrp { get; set; }

    [JsonPropertyName("FeesForServicesAccountingGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<FeesForServicesAccountingGrp>))]
    public List<FeesForServicesAccountingGrp> FeesForServicesAccountingGrp { get; set; }

    [JsonPropertyName("FeesForServicesLobbyingGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<FeesForServicesLobbyingGrp>))]
    public List<FeesForServicesLobbyingGrp> FeesForServicesLobbyingGrp { get; set; }

    [JsonPropertyName("FeesForServicesProfFundraising")]
    [JsonConverter(typeof(SingleOrArrayConverter<FeesForServicesProfFundraising>))]
    public List<FeesForServicesProfFundraising> FeesForServicesProfFundraising { get; set; }

    [JsonPropertyName("FeesForSrvcInvstMgmntFeesGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<FeesForSrvcInvstMgmntFeesGrp>))]
    public List<FeesForSrvcInvstMgmntFeesGrp> FeesForSrvcInvstMgmntFeesGrp { get; set; }

    [JsonPropertyName("FeesForServicesOtherGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<FeesForServicesOtherGrp>))]
    public List<FeesForServicesOtherGrp> FeesForServicesOtherGrp { get; set; }

    [JsonPropertyName("AdvertisingGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<AdvertisingGrp>))]
    public List<AdvertisingGrp> AdvertisingGrp { get; set; }

    [JsonPropertyName("OfficeExpensesGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<OfficeExpensesGrp>))]
    public List<OfficeExpensesGrp> OfficeExpensesGrp { get; set; }

    [JsonPropertyName("InformationTechnologyGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<InformationTechnologyGrp>))]
    public List<InformationTechnologyGrp> InformationTechnologyGrp { get; set; }

    [JsonPropertyName("RoyaltiesGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<RoyaltiesGrp>))]
    public List<RoyaltiesGrp> RoyaltiesGrp { get; set; }

    [JsonPropertyName("OccupancyGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<OccupancyGrp>))]
    public List<OccupancyGrp> OccupancyGrp { get; set; }

    [JsonPropertyName("TravelGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<TravelGrp>))]
    public List<TravelGrp> TravelGrp { get; set; }

    [JsonPropertyName("PymtTravelEntrtnmntPubOfclGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<PymtTravelEntrtnmntPubOfclGrp>))]
    public List<PymtTravelEntrtnmntPubOfclGrp> PymtTravelEntrtnmntPubOfclGrp { get; set; }

    [JsonPropertyName("ConferencesMeetingsGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<ConferencesMeetingsGrp>))]
    public List<ConferencesMeetingsGrp> ConferencesMeetingsGrp { get; set; }

    [JsonPropertyName("InterestGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<InterestGrp>))]
    public List<InterestGrp> InterestGrp { get; set; }

    [JsonPropertyName("PaymentsToAffiliatesGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<PaymentsToAffiliatesGrp>))]
    public List<PaymentsToAffiliatesGrp> PaymentsToAffiliatesGrp { get; set; }

    [JsonPropertyName("DepreciationDepletionGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<DepreciationDepletionGrp>))]
    public List<DepreciationDepletionGrp> DepreciationDepletionGrp { get; set; }

    [JsonPropertyName("InsuranceGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<InsuranceGrp>))]
    public List<InsuranceGrp> InsuranceGrp { get; set; }

    [JsonPropertyName("OtherExpensesGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<OtherExpensesGrp>))]
    public List<OtherExpensesGrp> OtherExpensesGrp { get; set; }

    [JsonPropertyName("AllOtherExpensesGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<AllOtherExpensesGrp>))]
    public List<AllOtherExpensesGrp> AllOtherExpensesGrp { get; set; }

    [JsonPropertyName("TotalFunctionalExpensesGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<TotalFunctionalExpensesGrp>))]
    public List<TotalFunctionalExpensesGrp> TotalFunctionalExpensesGrp { get; set; }

    [JsonPropertyName("CashNonInterestBearingGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<CashNonInterestBearingGrp>))]
    public List<CashNonInterestBearingGrp> CashNonInterestBearingGrp { get; set; }

    [JsonPropertyName("SavingsAndTempCashInvstGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<SavingsAndTempCashInvstGrp>))]
    public List<SavingsAndTempCashInvstGrp> SavingsAndTempCashInvstGrp { get; set; }

    [JsonPropertyName("PledgesAndGrantsReceivableGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<PledgesAndGrantsReceivableGrp>))]
    public List<PledgesAndGrantsReceivableGrp> PledgesAndGrantsReceivableGrp { get; set; }

    [JsonPropertyName("AccountsReceivableGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<AccountsReceivableGrp>))]
    public List<AccountsReceivableGrp> AccountsReceivableGrp { get; set; }

    [JsonPropertyName("ReceivablesFromOfficersEtcGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<ReceivablesFromOfficersEtcGrp>))]
    public List<ReceivablesFromOfficersEtcGrp> ReceivablesFromOfficersEtcGrp { get; set; }

    [JsonPropertyName("RcvblFromDisqualifiedPrsnGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<RcvblFromDisqualifiedPrsnGrp>))]
    public List<RcvblFromDisqualifiedPrsnGrp> RcvblFromDisqualifiedPrsnGrp { get; set; }

    [JsonPropertyName("OthNotesLoansReceivableNetGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<OthNotesLoansReceivableNetGrp>))]
    public List<OthNotesLoansReceivableNetGrp> OthNotesLoansReceivableNetGrp { get; set; }

    [JsonPropertyName("InventoriesForSaleOrUseGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<InventoriesForSaleOrUseGrp>))]
    public List<InventoriesForSaleOrUseGrp> InventoriesForSaleOrUseGrp { get; set; }

    [JsonPropertyName("PrepaidExpensesDefrdChargesGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<PrepaidExpensesDefrdChargesGrp>))]
    public List<PrepaidExpensesDefrdChargesGrp> PrepaidExpensesDefrdChargesGrp { get; set; }

    [JsonPropertyName("LandBldgEquipCostOrOtherBssAmt"), 
     JsonConverter(typeof(FixScrewedUpString))]
    public string LandBldgEquipCostOrOtherBssAmt { get; set; }

    [JsonPropertyName("LandBldgEquipAccumDeprecAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LandBldgEquipAccumDeprecAmt { get; set; }

    [JsonPropertyName("LandBldgEquipBasisNetGrp"),  
     JsonConverter(typeof(SingleOrArrayConverter<LandBldgEquipBasisNetGrp>))]

    public List<LandBldgEquipBasisNetGrp> LandBldgEquipBasisNetGrp { get; set; }

    [JsonPropertyName("InvestmentsPubTradedSecGrp"),  JsonConverter(typeof(SingleOrArrayConverter<InvestmentsPubTradedSecGrp>))]
    public List<InvestmentsPubTradedSecGrp> InvestmentsPubTradedSecGrp { get; set; }

    [JsonPropertyName("InvestmentsOtherSecuritiesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<InvestmentsOtherSecuritiesGrp>))]
    public List<InvestmentsOtherSecuritiesGrp> InvestmentsOtherSecuritiesGrp { get; set; }

    [JsonPropertyName("InvestmentsProgramRelatedGrp"),  JsonConverter(typeof(SingleOrArrayConverter<InvestmentsProgramRelatedGrp>))]
    public List<InvestmentsProgramRelatedGrp> InvestmentsProgramRelatedGrp { get; set; }

    [JsonPropertyName("IntangibleAssetsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<IntangibleAssetsGrp>))]
    public List<IntangibleAssetsGrp> IntangibleAssetsGrp { get; set; }

    [JsonPropertyName("OtherAssetsTotalGrp"),  JsonConverter(typeof(SingleOrArrayConverter<OtherAssetsTotalGrp>))]
    public List<OtherAssetsTotalGrp> OtherAssetsTotalGrp { get; set; }

    [JsonPropertyName("TotalAssetsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalAssetsGrp>))] 
    public List<TotalAssetsGrp> TotalAssetsGrp { get; set; }

    [JsonPropertyName("OtherLiabilitiesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<OtherLiabilitiesGrp>))]
    public List<OtherLiabilitiesGrp> OtherLiabilitiesGrp { get; set; }

    [JsonPropertyName("TotalLiabilitiesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalLiabilitiesGrp>))]
    public List<TotalLiabilitiesGrp> TotalLiabilitiesGrp { get; set; }

    [JsonPropertyName("OrganizationFollowsSFAS117Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string OrganizationFollowsSFAS117Ind { get; set; }

    [JsonPropertyName("UnrestrictedNetAssetsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<UnrestrictedNetAssetsGrp>))]
    public List<UnrestrictedNetAssetsGrp> UnrestrictedNetAssetsGrp { get; set; }

    [JsonPropertyName("TotalNetAssetsFundBalanceGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalNetAssetsFundBalanceGrp>))]
    public List<TotalNetAssetsFundBalanceGrp> TotalNetAssetsFundBalanceGrp { get; set; }

    [JsonPropertyName("TotLiabNetAssetsFundBalanceGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotLiabNetAssetsFundBalanceGrp>))]
    public List<TotLiabNetAssetsFundBalanceGrp> TotLiabNetAssetsFundBalanceGrp { get; set; }

    [JsonPropertyName("ReconcilationRevenueExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReconcilationRevenueExpnssAmt { get; set; }

    [JsonPropertyName("MethodOfAccountingAccrualInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MethodOfAccountingAccrualInd { get; set; }

    [JsonPropertyName("AccountantCompileOrReviewInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AccountantCompileOrReviewInd { get; set; }

    [JsonPropertyName("FSAuditedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FSAuditedInd { get; set; }

    [JsonPropertyName("FSAuditedBasisGrp"),  JsonConverter(typeof(SingleOrArrayConverter<FSAuditedBasisGrp>))]
    public List<FSAuditedBasisGrp> FSAuditedBasisGrp { get; set; }

    [JsonPropertyName("AuditCommitteeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AuditCommitteeInd { get; set; }

    [JsonPropertyName("FederalGrantAuditRequiredInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FederalGrantAuditRequiredInd { get; set; }

    [JsonPropertyName("PrincipalOfficerNm")]
    public string PrincipalOfficerNm { get; set; }

    [JsonPropertyName("TypeOfOrganizationAssocInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TypeOfOrganizationAssocInd { get; set; }

    [JsonPropertyName("TotalVolunteersCnt")]
    public string TotalVolunteersCnt { get; set; }

    [JsonPropertyName("NetUnrelatedBusTxblIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetUnrelatedBusTxblIncmAmt { get; set; }

    [JsonPropertyName("PYContributionsGrantsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PYContributionsGrantsAmt { get; set; }

    [JsonPropertyName("PYOtherRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PYOtherRevenueAmt { get; set; }

    [JsonPropertyName("PYGrantsAndSimilarPaidAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PYGrantsAndSimilarPaidAmt { get; set; }

    [JsonPropertyName("GrantAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantAmt { get; set; }

    [JsonPropertyName("RevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RevenueAmt { get; set; }

    [JsonPropertyName("TransactionWithControlEntInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TransactionWithControlEntInd { get; set; }

    [JsonPropertyName("QuidProQuoContributionsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string QuidProQuoContributionsInd { get; set; }

    [JsonPropertyName("Form8282PropertyDisposedOfInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form8282PropertyDisposedOfInd { get; set; }

    [JsonPropertyName("RcvFndsToPayPrsnlBnftCntrctInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string RcvFndsToPayPrsnlBnftCntrctInd { get; set; }

    [JsonPropertyName("PayPremiumsPrsnlBnftCntrctInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PayPremiumsPrsnlBnftCntrctInd { get; set; }

    [JsonPropertyName("Form8899FiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form8899Filedind { get; set; }

    [JsonPropertyName("Form1098CFiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form1098CFiledInd { get; set; }

    [JsonPropertyName("InitiationFeesAndCapContriAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InitiationFeesAndCapContriAmt { get; set; }

    [JsonPropertyName("GrossReceiptsForPublicUseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossReceiptsForPublicUseAmt { get; set; }

    [JsonPropertyName("StatesWhereCopyOfReturnIsFldCd"), JsonConverter(typeof(FixScrewedUpString))]
    public string StatesWhereCopyOfReturnIsFldCd { get; set; }

    [JsonPropertyName("OtherInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherInd { get; set; }

    [JsonPropertyName("NoListedPersonsCompensatedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string NoListedPersonsCompensatedInd { get; set; }

    [JsonPropertyName("TotReportableCompRltdOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotReportableCompRltdOrgAmt { get; set; }

    [JsonPropertyName("TotalOtherCompensationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalOtherCompensationAmt { get; set; }

    [JsonPropertyName("MembershipDuesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string MembershipDuesAmt { get; set; }

    [JsonPropertyName("GrossRentsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<GrossRentsGrp>))] 
    public List<GrossRentsGrp> GrossRentsGrp { get; set; }

    [JsonPropertyName("LessRentalExpensesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<LessRentalExpensesGrp>))]
    public List<LessRentalExpensesGrp> LessRentalExpensesGrp { get; set; }

    [JsonPropertyName("GamingGrossIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GamingGrossIncomeAmt { get; set; }

    [JsonPropertyName("GamingDirectExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GamingDirectExpensesAmt { get; set; }

    [JsonPropertyName("GrossSalesOfInventoryAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossSalesOfInventoryAmt { get; set; }

    [JsonPropertyName("CostOfGoodsSoldAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CostOfGoodsSoldAmt { get; set; }

    [JsonPropertyName("AccountsPayableAccrExpnssGrp"),  JsonConverter(typeof(SingleOrArrayConverter<AccountsPayableAccrExpnssGrp>))]
    public List<AccountsPayableAccrExpnssGrp> AccountsPayableAccrExpnssGrp { get; set; }

    [JsonPropertyName("OrgDoesNotFollowSFAS117Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string OrgDoesNotFollowSFAS117Ind { get; set; }

    [JsonPropertyName("PdInCapSrplsLandBldgEqpFundGrp"),  JsonConverter(typeof(SingleOrArrayConverter<PdInCapSrplsLandBldgEqpFundGrp>))]
    public List<PdInCapSrplsLandBldgEqpFundGrp> PdInCapSrplsLandBldgEqpFundGrp { get; set; }

    [JsonPropertyName("OtherChangesInNetAssetsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherChangesInNetAssetsAmt { get; set; }

    [JsonPropertyName("MethodOfAccountingCashInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MethodOfAccountingCashInd { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("Organization501c3Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string Organization501c3Ind { get; set; }

    [JsonPropertyName("TypeOfOrganizationCorpInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TypeOfOrganizationCorpInd { get; set; }

    [JsonPropertyName("PYTotalProfFndrsngExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PYTotalProfFndrsngExpnsAmt { get; set; }

    [JsonPropertyName("InfoInScheduleOPartIIIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InfoInScheduleOPartIIIInd { get; set; }

    [JsonPropertyName("ProgSrvcAccomActy2Grp"),  JsonConverter(typeof(SingleOrArrayConverter<ProgSrvcAccomActy2Grp>))]
    public List<ProgSrvcAccomActy2Grp> ProgSrvcAccomActy2Grp { get; set; }

    [JsonPropertyName("ProgSrvcAccomActy3Grp"),  JsonConverter(typeof(SingleOrArrayConverter<ProgSrvcAccomActy3Grp>))]
    public List<ProgSrvcAccomActy3Grp> ProgSrvcAccomActy3Grp { get; set; }

    [JsonPropertyName("LobbyingActivitiesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LobbyingActivitiesInd { get; set; }

    [JsonPropertyName("EngagedInExcessBenefitTransInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string EngagedInExcessBenefitTransInd { get; set; }

    [JsonPropertyName("PYExcessBenefitTransInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PYExcessBenefitTransInd { get; set; }

    [JsonPropertyName("TrnsfrExmptNonChrtblRltdOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TrnsfrExmptNonChrtblRltdOrgInd { get; set; }

    [JsonPropertyName("InfoInScheduleOPartVIIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InfoInScheduleOPartVIIInd { get; set; }

    [JsonPropertyName("GovernmentGrantsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GovernmentGrantsAmt { get; set; }

    [JsonPropertyName("AllOtherContributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AllOtherContributionsAmt { get; set; }

    [JsonPropertyName("RentalIncomeOrLossGrp"),  JsonConverter(typeof(SingleOrArrayConverter<RentalIncomeOrLossGrp>))]
    public List<RentalIncomeOrLossGrp> RentalIncomeOrLossGrp { get; set; }

    [JsonPropertyName("OtherRevenueMiscGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<OtherRevenueMiscGrp>))]
    public List<OtherRevenueMiscGrp> OtherRevenueMiscGrp { get; set; }

    [JsonPropertyName("TemporarilyRstrNetAssetsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TemporarilyRstrNetAssetsGrp>))]
    public List<TemporarilyRstrNetAssetsGrp> TemporarilyRstrNetAssetsGrp { get; set; }

    [JsonPropertyName("Form8282FiledCnt")] 
    public string Form8282FiledCnt { get; set; }

    [JsonPropertyName("LoansFromOfficersDirectorsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<LoansFromOfficersDirectorsGrp>))]
    public List<LoansFromOfficersDirectorsGrp> LoansFromOfficersDirectorsGrp { get; set; }

    [JsonPropertyName("FederalGrantAuditPerformedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FederalGrantAuditPerformedInd { get; set; }

    [JsonPropertyName("FundraisingGrossIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingGrossIncomeAmt { get; set; }

    [JsonPropertyName("FundraisingDirectExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingDirectExpensesAmt { get; set; }

    [JsonPropertyName("GrantsPayableGrp"),  JsonConverter(typeof(SingleOrArrayConverter<GrantsPayableGrp>))] 
    public List<GrantsPayableGrp> GrantsPayableGrp { get; set; }

    [JsonPropertyName("DeferredRevenueGrp"),  JsonConverter(typeof(SingleOrArrayConverter<DeferredRevenueGrp>))]
    public List<DeferredRevenueGrp> DeferredRevenueGrp { get; set; }

    [JsonPropertyName("TaxExemptBondLiabilitiesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TaxExemptBondLiabilitiesGrp>))]
    public List<TaxExemptBondLiabilitiesGrp> TaxExemptBondLiabilitiesGrp { get; set; }

    [JsonPropertyName("EscrowAccountLiabilityGrp"),  JsonConverter(typeof(SingleOrArrayConverter<EscrowAccountLiabilityGrp>))]
    public List<EscrowAccountLiabilityGrp> EscrowAccountLiabilityGrp { get; set; }

    [JsonPropertyName("MortgNotesPyblScrdInvstPropGrp"),  JsonConverter(typeof(SingleOrArrayConverter<MortgNotesPyblScrdInvstPropGrp>))]
    public List<MortgNotesPyblScrdInvstPropGrp> MortgNotesPyblScrdInvstPropGrp { get; set; }

    [JsonPropertyName("UnsecuredNotesLoansPayableGrp"),  JsonConverter(typeof(SingleOrArrayConverter<UnsecuredNotesLoansPayableGrp>))]
    public List<UnsecuredNotesLoansPayableGrp> UnsecuredNotesLoansPayableGrp { get; set; }

    [JsonPropertyName("CapStkTrPrinCurrentFundsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<CapStkTrPrinCurrentFundsGrp>))]
    public List<CapStkTrPrinCurrentFundsGrp> CapStkTrPrinCurrentFundsGrp { get; set; }

    [JsonPropertyName("RtnEarnEndowmentIncmOthFndsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<RtnEarnEndowmentIncmOthFndsGrp>))]
    public List<RtnEarnEndowmentIncmOthFndsGrp> RtnEarnEndowmentIncmOthFndsGrp { get; set; }

    [JsonPropertyName("PriorPeriodAdjustmentsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorPeriodAdjustmentsAmt { get; set; }

    [JsonPropertyName("AddressChangeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AddressChangeInd { get; set; }

    [JsonPropertyName("Form8886TFiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form8886TFiledInd { get; set; }

    [JsonPropertyName("NondeductibleContriDisclInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string NondeductibleContriDisclInd { get; set; }

    [JsonPropertyName("QuidProQuoContriDisclInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string QuidProQuoContriDisclInd { get; set; }

    [JsonPropertyName("PoliciesReferenceChaptersInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PoliciesReferenceChaptersInd { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }

    [JsonPropertyName("NoncashContributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NoncashContributionsAmt { get; set; }

    [JsonPropertyName("GrossAmountSalesAssetsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<GrossAmountSalesAssetsGrp>))]
    public List<GrossAmountSalesAssetsGrp> GrossAmountSalesAssetsGrp { get; set; }

    [JsonPropertyName("LessCostOthBasisSalesExpnssGrp"),  JsonConverter(typeof(SingleOrArrayConverter<LessCostOthBasisSalesExpnssGrp>))]
    public List<LessCostOthBasisSalesExpnssGrp> LessCostOthBasisSalesExpnssGrp { get; set; }

    [JsonPropertyName("GainOrLossGrp"),  JsonConverter(typeof(SingleOrArrayConverter<GainOrLossGrp>))] 
    public List<GainOrLossGrp> GainOrLossGrp { get; set; }

    [JsonPropertyName("ContriRptFundraisingEventAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ContriRptFundraisingEventAmt { get; set; }

    [JsonPropertyName("NetUnrlzdGainsLossesInvstAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetUnrlzdGainsLossesInvstAmt { get; set; }

    [JsonPropertyName("InfoInScheduleOPartXIIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InfoInScheduleOPartXIIInd { get; set; }

    [JsonPropertyName("InfoInScheduleOPartIXInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InfoInScheduleOPartIXInd { get; set; }

    [JsonPropertyName("AcctCompileOrReviewBasisGrp"),  JsonConverter(typeof(SingleOrArrayConverter<AcctCompileOrReviewBasisGrp>))]
    public List<AcctCompileOrReviewBasisGrp> AcctCompileOrReviewBasisGrp { get; set; }

    [JsonPropertyName("ContractorCompensationGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<ContractorCompensationGrp>))]
    public List<ContractorCompensationGrp> ContractorCompensationGrp { get; set; }

    [JsonPropertyName("RelatedOrganizationsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrganizationsAmt { get; set; }

    [JsonPropertyName("PermanentlyRstrNetAssetsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<PermanentlyRstrNetAssetsGrp>))]
    public List<PermanentlyRstrNetAssetsGrp> PermanentlyRstrNetAssetsGrp { get; set; }

    [JsonPropertyName("ProgSrvcAccomActyOtherGrp"),  JsonConverter(typeof(SingleOrArrayConverter<ProgSrvcAccomActyOtherGrp>))]
    public List<ProgSrvcAccomActyOtherGrp> ProgSrvcAccomActyOtherGrp { get; set; }

    [JsonPropertyName("InfoInScheduleOPartVInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InfoInScheduleOPartVInd { get; set; }

    [JsonPropertyName("TotalOthProgramServiceRevGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalOthProgramServiceRevGrp>))]
    public List<TotalOthProgramServiceRevGrp> TotalOthProgramServiceRevGrp { get; set; }

    [JsonPropertyName("GroupExemptionNum")]
    public string GroupExemptionNum { get; set; }

    [JsonPropertyName("TotalOtherProgSrvcExpenseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalOtherProgSrvcExpenseAmt { get; set; }

    [JsonPropertyName("TotalOtherProgSrvcRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalOtherProgSrvcRevenueAmt { get; set; }

    [JsonPropertyName("InfoInScheduleOPartXIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InfoInScheduleOPartXIInd { get; set; }

    [JsonPropertyName("TotalOtherProgSrvcGrantAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalOtherProgSrvcGrantAmt { get; set; }

    [JsonPropertyName("FederatedCampaignsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FederatedCampaignsAmt { get; set; }

    [JsonPropertyName("DonatedServicesAndUseFcltsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DonatedServicesAndUseFcltsAmt { get; set; }

    [JsonPropertyName("InvestmentExpenseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvestmentExpenseAmt { get; set; }

    [JsonPropertyName("OtherWebsiteInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherWebsiteInd { get; set; }

    [JsonPropertyName("DoingBusinessAsName")]
    public DoingBusinessAsName DoingBusinessAsName { get; set; }

    [JsonPropertyName("ForeignCountryCd")]
    [JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> ForeignCountryCd { get; set; }


    [JsonPropertyName("TypeOfOrganizationOtherInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TypeOfOrganizationOtherInd { get; set; }

    [JsonPropertyName("OtherOrganizationDsc")]
    public string OtherOrganizationDsc { get; set; }

    [JsonPropertyName("MiscellaneousRevenueGrp"),  JsonConverter(typeof(SingleOrArrayConverter<MiscellaneousRevenueGrp>))]
    public List<MiscellaneousRevenueGrp> MiscellaneousRevenueGrp { get; set; }

    [JsonPropertyName("MethodOfAccountingOtherInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MethodOfAccountingOtherInd { get; set; }

    [JsonPropertyName("WrittenPolicyOrProcedureInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string WrittenPolicyOrProcedureInd { get; set; }

    [JsonPropertyName("InfoInScheduleOPartXInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InfoInScheduleOPartXInd { get; set; }

    [JsonPropertyName("JointCostsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string JointCostsInd { get; set; }

    [JsonPropertyName("TotalJointCostsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalJointCostsGrp>))]
    public List<TotalJointCostsGrp> TotalJointCostsGrp { get; set; }

    [JsonPropertyName("SubjToTaxRmnrtnExPrchtPymtInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SubjToTaxRmnrtnExPrchtPymtInd { get; set; }

    [JsonPropertyName("SubjectToExcsTaxNetInvstIncInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SubjectToExcsTaxNetInvstIncInd { get; set; }

    [JsonPropertyName("MembersAndShrGrossIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string MembersAndShrGrossIncomeAmt { get; set; }

    [JsonPropertyName("OtherSourcesGrossIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherSourcesGrossIncomeAmt { get; set; }

    [JsonPropertyName("PrincipalOfcrBusinessName")]
    public PrincipalOfcrBusinessName PrincipalOfcrBusinessName { get; set; }

    [JsonPropertyName("AmendedReturnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AmendedReturnInd { get; set; }

    [JsonPropertyName("InitialReturnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InitialReturnInd { get; set; }

    [JsonPropertyName("InfoInScheduleOPartVIIIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InfoInScheduleOPartVIIIInd { get; set; }

    [JsonPropertyName("Form720FiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form720FiledInd { get; set; }

    [JsonPropertyName("FinalReturnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FinalReturnInd { get; set; }

    [JsonPropertyName("ContractTerminationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ContractTerminationInd { get; set; }

    [JsonPropertyName("AuditedFinancialStmtAttInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AuditedFinancialStmtAttInd { get; set; }

    [JsonPropertyName("ForeignAddress")] public ForeignAddress ForeignAddress { get; set; }

    [JsonPropertyName("TaxExemptInterestAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxExemptInterestAmt { get; set; }

    [JsonPropertyName("ActivityCd")] public string ActivityCd { get; set; }

    [JsonPropertyName("DonorRstrOrQuasiEndowmentsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DonorRstrOrQuasiEndowmentsInd { get; set; }

    [JsonPropertyName("BusinessRlnWith35CtrlEntInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string BusinessRlnWith35CtrlEntInd { get; set; }

    [JsonPropertyName("OrganizationFollowsFASB117Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string OrganizationFollowsFASB117Ind { get; set; }

    [JsonPropertyName("NoDonorRestrictionNetAssetsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<NoDonorRestrictionNetAssetsGrp>))]
    public List<NoDonorRestrictionNetAssetsGrp> NoDonorRestrictionNetAssetsGrp { get; set; }

    [JsonPropertyName("Organization4947a1NotPFInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Organization4947a1NotPFInd { get; set; }

    [JsonPropertyName("LegalDomicileCountryCd")]
    public string LegalDomicileCountryCd { get; set; }

    [JsonPropertyName("SpecialConditionDesc")]
    public string SpecialConditionDesc { get; set; }

    [JsonPropertyName("DonorRestrictionNetAssetsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<DonorRestrictionNetAssetsGrp>))]
    public List<DonorRestrictionNetAssetsGrp> DonorRestrictionNetAssetsGrp { get; set; }

    [JsonPropertyName("OrgDoesNotFollowFASB117Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string OrgDoesNotFollowFASB117Ind { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }

    [JsonPropertyName("StateRequiredReservesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string StateRequiredReservesAmt { get; set; }

    [JsonPropertyName("ReservesMaintainedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReservesMaintainedAmt { get; set; }
}

public class IRS990EZ
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("@referenceDocumentId")]
    public string ReferenceDocumentId { get; set; }

    [JsonPropertyName("MethodOfAccountingCashInd")
     , JsonConverter(typeof(FixScrewedUpString))]
    public string MethodOfAccountingCashInd { get; set; }

    [JsonPropertyName("WebsiteAddressTxt")]
    public string WebsiteAddressTxt { get; set; }

    [JsonPropertyName("Organization501c3Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string Organization501c3Ind { get; set; }

    [JsonPropertyName("TypeOfOrganizationCorpInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TypeOfOrganizationCorpInd { get; set; }

    [JsonPropertyName("GrossReceiptsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossReceiptsAmt { get; set; }

    [JsonPropertyName("InfoInScheduleOPartIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InfoInScheduleOPartIInd { get; set; }

    [JsonPropertyName("ContributionsGiftsGrantsEtcAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ContributionsGiftsGrantsEtcAmt { get; set; }

    [JsonPropertyName("ProgramServiceRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServiceRevenueAmt { get; set; }

    [JsonPropertyName("MembershipDuesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string MembershipDuesAmt { get; set; }

    [JsonPropertyName("FundraisingGrossIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingGrossIncomeAmt { get; set; }

    [JsonPropertyName("SpecialEventsDirectExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SpecialEventsDirectExpensesAmt { get; set; }

    [JsonPropertyName("SpecialEventsNetIncomeLossAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SpecialEventsNetIncomeLossAmt { get; set; }

    [JsonPropertyName("TotalRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRevenueAmt { get; set; }

    [JsonPropertyName("FeesAndOtherPymtToIndCntrctAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FeesAndOtherPymtToIndCntrctAmt { get; set; }

    [JsonPropertyName("PrintingPublicationsPostageAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PrintingPublicationsPostageAmt { get; set; }

    [JsonPropertyName("OtherExpensesTotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherExpensesTotalAmt { get; set; }

    [JsonPropertyName("TotalExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalExpensesAmt { get; set; }

    [JsonPropertyName("ExcessOrDeficitForYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessOrDeficitForYearAmt { get; set; }

    [JsonPropertyName("NetAssetsOrFundBalancesBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetAssetsOrFundBalancesBOYAmt { get; set; }

    [JsonPropertyName("OtherChangesInNetAssetsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherChangesInNetAssetsAmt { get; set; }

    [JsonPropertyName("NetAssetsOrFundBalancesEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetAssetsOrFundBalancesEOYAmt { get; set; }

    [JsonPropertyName("InfoInScheduleOPartIIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InfoInScheduleOPartIIInd { get; set; }

    [JsonPropertyName("CashSavingsAndInvestmentsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<CashSavingsAndInvestmentsGrp>))]
    public List<CashSavingsAndInvestmentsGrp> CashSavingsAndInvestmentsGrp { get; set; }

    [JsonPropertyName("Form990TotalAssetsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<Form990TotalAssetsGrp>))]
    public List<Form990TotalAssetsGrp> Form990TotalAssetsGrp { get; set; }

    [JsonPropertyName("SumOfTotalLiabilitiesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<SumOfTotalLiabilitiesGrp>))]
    public List<SumOfTotalLiabilitiesGrp> SumOfTotalLiabilitiesGrp { get; set; }

    [JsonPropertyName("NetAssetsOrFundBalancesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<NetAssetsOrFundBalancesGrp>))]
    public List<NetAssetsOrFundBalancesGrp> NetAssetsOrFundBalancesGrp { get; set; }

    [JsonPropertyName("InfoInScheduleOPartIIIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InfoInScheduleOPartIIIInd { get; set; }

    [JsonPropertyName("PrimaryExemptPurposeTxt")]
    public string PrimaryExemptPurposeTxt { get; set; }

    [JsonPropertyName("ProgramSrvcAccomplishmentGrp"),  JsonConverter(typeof(SingleOrArrayConverter<ProgramSrvcAccomplishmentGrp>))]
    public List<ProgramSrvcAccomplishmentGrp> ProgramSrvcAccomplishmentGrp { get; set; }

    [JsonPropertyName("TotalProgramServiceExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalProgramServiceExpensesAmt { get; set; }

    [JsonPropertyName("OfficerDirectorTrusteeEmplGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<OfficerDirectorTrusteeEmplGrp>))]
    public List<OfficerDirectorTrusteeEmplGrp> OfficerDirectorTrusteeEmplGrp { get; set; }

    [JsonPropertyName("InfoInScheduleOPartVInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InfoInScheduleOPartVInd { get; set; }

    [JsonPropertyName("ActivitiesNotPreviouslyRptInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ActivitiesNotPreviouslyRptInd { get; set; }

    [JsonPropertyName("ChgMadeToOrgnzngDocNotRptInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ChgMadeToOrgnzngDocNotRptInd { get; set; }

    [JsonPropertyName("OrganizationHadUBIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OrganizationHadUBIInd { get; set; }

    [JsonPropertyName("SubjectToProxyTaxInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SubjectToProxyTaxInd { get; set; }

    [JsonPropertyName("OrganizationDissolvedEtcInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OrganizationDissolvedEtcInd { get; set; }

    [JsonPropertyName("DirectIndirectPltclExpendAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectIndirectPltclExpendAmt { get; set; }

    [JsonPropertyName("MadeLoansToFromOfficersInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MadeLoansToFromOfficersInd { get; set; }

    [JsonPropertyName("TaxImposedUnderIRC4911Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxImposedUnderIRC4911Amt { get; set; }

    [JsonPropertyName("TaxImposedUnderIRC4912Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxImposedUnderIRC4912Amt { get; set; }

    [JsonPropertyName("TaxImposedUnderIRC4955Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxImposedUnderIRC4955Amt { get; set; }

    [JsonPropertyName("EngagedInExcessBenefitTransInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string EngagedInExcessBenefitTransInd { get; set; }

    [JsonPropertyName("TaxImposedOnOrganizationMgrAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxImposedOnOrganizationMgrAmt { get; set; }

    [JsonPropertyName("TaxReimbursedByOrganizationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxReimbursedByOrganizationAmt { get; set; }

    [JsonPropertyName("ProhibitedTaxShelterTransInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProhibitedTaxShelterTransInd { get; set; }

    [JsonPropertyName("StatesWhereCopyOfReturnIsFldCd")]
    public string StatesWhereCopyOfReturnIsFldCd { get; set; }

    [JsonPropertyName("BooksInCareOfDetail")]
    public BooksInCareOfDetail BooksInCareOfDetail { get; set; }

    [JsonPropertyName("ForeignFinancialAccountInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ForeignFinancialAccountInd { get; set; }

    [JsonPropertyName("ForeignOfficeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ForeignOfficeInd { get; set; }

    [JsonPropertyName("DonorAdvisedFndsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DonorAdvisedFndsInd { get; set; }

    [JsonPropertyName("OperateHospitalInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OperateHospitalInd { get; set; }

    [JsonPropertyName("TanningServicesProvidedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TanningServicesProvidedInd { get; set; }

    [JsonPropertyName("RelatedOrganizationCtrlEntInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrganizationCtrlEntInd { get; set; }

    [JsonPropertyName("PoliticalCampaignActyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PoliticalCampaignActyInd { get; set; }

    [JsonPropertyName("LobbyingActivitiesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LobbyingActivitiesInd { get; set; }

    [JsonPropertyName("SchoolOperatingInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SchoolOperatingInd { get; set; }

    [JsonPropertyName("TrnsfrExmptNonChrtblRltdOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TrnsfrExmptNonChrtblRltdOrgInd { get; set; }

    [JsonPropertyName("PartVIOfCompOfHghstPdEmplTxt")]
    public string PartVIOfCompOfHghstPdEmplTxt { get; set; }

    [JsonPropertyName("PartVIHghstPdCntrctProfSrvcTxt")]
    public string PartVIHghstPdCntrctProfSrvcTxt { get; set; }

    [JsonPropertyName("FiledScheduleAInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FiledScheduleAInd { get; set; }


    //public string ReferenceDocumentName { get; set; }

    [JsonPropertyName("GroupExemptionNum")]
    public string GroupExemptionNum { get; set; }

    [JsonPropertyName("ScheduleBNotRequiredInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ScheduleBNotRequiredInd { get; set; }

    [JsonPropertyName("Organization501cInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Organization501cInd { get; set; }

    [JsonPropertyName("InvestmentIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvestmentIncomeAmt { get; set; }

    [JsonPropertyName("CostOrOtherBasisExpenseSaleAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CostOrOtherBasisExpenseSaleAmt { get; set; }

    [JsonPropertyName("GainOrLossFromSaleOfAssetsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GainOrLossFromSaleOfAssetsAmt { get; set; }

    [JsonPropertyName("GamingGrossIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GamingGrossIncomeAmt { get; set; }

    [JsonPropertyName("CostOfGoodsSoldAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CostOfGoodsSoldAmt { get; set; }

    [JsonPropertyName("GrossProfitLossSlsOfInvntryAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossProfitLossSlsOfInvntryAmt { get; set; }

    [JsonPropertyName("Form1120PolFiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form1120PolFiledInd { get; set; }

    [JsonPropertyName("TransactionWithControlEntInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TransactionWithControlEntInd { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("InitialReturnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InitialReturnInd { get; set; }

    [JsonPropertyName("SaleOfAssetsGrossAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SaleOfAssetsGrossAmt { get; set; }

    [JsonPropertyName("GrossSalesOfInventoryAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossSalesOfInventoryAmt { get; set; }

    [JsonPropertyName("OtherRevenueTotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherRevenueTotalAmt { get; set; }

    [JsonPropertyName("GrantsAndSimilarAmountsPaidAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantsAndSimilarAmountsPaidAmt { get; set; }

    [JsonPropertyName("BenefitsPaidToOrForMembersAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BenefitsPaidToOrForMembersAmt { get; set; }

    [JsonPropertyName("SalariesOtherCompEmplBnftAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SalariesOtherCompEmplBnftAmt { get; set; }

    [JsonPropertyName("OccupancyRentUtltsAndMaintAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OccupancyRentUtltsAndMaintAmt { get; set; }

    [JsonPropertyName("LandAndBuildingsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<LandAndBuildingsGrp>))]
    public List<LandAndBuildingsGrp> LandAndBuildingsGrp { get; set; }

    [JsonPropertyName("OtherAssetsTotalDetail")]
    public OtherAssetsTotalDetail OtherAssetsTotalDetail { get; set; }

    [JsonPropertyName("LoansToFromOfficersAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LoansToFromOfficersAmt { get; set; }

    [JsonPropertyName("MethodOfAccountingAccrualInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MethodOfAccountingAccrualInd { get; set; }

    [JsonPropertyName("InfoInScheduleOPartIVInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InfoInScheduleOPartIVInd { get; set; }

    [JsonPropertyName("OrganizationFiled990TInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OrganizationFiled990TInd { get; set; }

    [JsonPropertyName("InitiationFeesAndCapContriAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InitiationFeesAndCapContriAmt { get; set; }

    [JsonPropertyName("GrossReceiptsForPublicUseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossReceiptsForPublicUseAmt { get; set; }

    [JsonPropertyName("Form720FiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form720FiledInd { get; set; }

    [JsonPropertyName("MethodOfAccountingOtherDesc")]
    public string MethodOfAccountingOtherDesc { get; set; }

    [JsonPropertyName("TypeOfOrganizationAssocInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TypeOfOrganizationAssocInd { get; set; }

    [JsonPropertyName("RelatedOrgSect527OrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrgSect527OrgInd { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }

    [JsonPropertyName("AddressChangeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AddressChangeInd { get; set; }

    [JsonPropertyName("FinalReturnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FinalReturnInd { get; set; }

    [JsonPropertyName("CompensationOfHghstPdCntrctGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<CompensationOfHghstPdCntrctGrp>))]
    public List<CompensationOfHghstPdCntrctGrp> CompensationOfHghstPdCntrctGrp { get; set; }

    [JsonPropertyName("TypeOfOrganizationTrustInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TypeOfOrganizationTrustInd { get; set; }

    [JsonPropertyName("TypeOfOrganizationOtherInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TypeOfOrganizationOtherInd { get; set; }

    [JsonPropertyName("TypeOfOrganizationOtherDesc")]
    public string TypeOfOrganizationOtherDesc { get; set; }

    [JsonPropertyName("AmendedReturnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AmendedReturnInd { get; set; }

    [JsonPropertyName("ForeignFinancialAccountCntryCd")]
    public string ForeignFinancialAccountCntryCd { get; set; }

    [JsonPropertyName("OtherEmployeePaidOver100kCnt")]
    public string OtherEmployeePaidOver100kCnt { get; set; }

    [JsonPropertyName("CntrctRcvdGreaterThan100KCnt")]
    public string CntrctRcvdGreaterThan100KCnt { get; set; }

    [JsonPropertyName("ForeignOfficeCountryCd")]
    public string ForeignOfficeCountryCd { get; set; }

    [JsonPropertyName("InfoInScheduleOPartVIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InfoInScheduleOPartVIInd { get; set; }

    [JsonPropertyName("CompensationHighestPaidEmplGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<CompensationHighestPaidEmplGrp>))]
    public List<CompensationHighestPaidEmplGrp> CompensationHighestPaidEmplGrp { get; set; }

    [JsonPropertyName("SpecialConditionDesc")]
    public string SpecialConditionDesc { get; set; }

    [JsonPropertyName("Organization4947a1NotPFInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Organization4947a1NotPFInd { get; set; }
}

public class IRS990PF
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("Organization501c3ExemptPFInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Organization501c3ExemptPFInd { get; set; }

    [JsonPropertyName("FMVAssetsEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FMVAssetsEOYAmt { get; set; }

    [JsonPropertyName("MethodOfAccountingAccrualInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MethodOfAccountingAccrualInd { get; set; }

    [JsonPropertyName("AnalysisOfRevenueAndExpenses")]
    public AnalysisOfRevenueAndExpenses AnalysisOfRevenueAndExpenses { get; set; }

    [JsonPropertyName("Form990PFBalanceSheetsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<Form990PFBalanceSheetsGrp>))]
    public List<Form990PFBalanceSheetsGrp> Form990PFBalanceSheetsGrp { get; set; }

    [JsonPropertyName("ChgInNetAssetsFundBalancesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<ChgInNetAssetsFundBalancesGrp>))]
    public List<ChgInNetAssetsFundBalancesGrp> ChgInNetAssetsFundBalancesGrp { get; set; }

    [JsonPropertyName("CapGainsLossTxInvstIncmDetail")]
    public CapGainsLossTxInvstIncmDetail CapGainsLossTxInvstIncmDetail { get; set; }

    [JsonPropertyName("QlfyUndSect4940eReducedTaxGrp"),  JsonConverter(typeof(SingleOrArrayConverter<QlfyUndSect4940eReducedTaxGrp>))]
    public List<QlfyUndSect4940eReducedTaxGrp> QlfyUndSect4940eReducedTaxGrp { get; set; }

    [JsonPropertyName("ExciseTaxBasedOnInvstIncmGrp"),  JsonConverter(typeof(SingleOrArrayConverter<ExciseTaxBasedOnInvstIncmGrp>))]
    public List<ExciseTaxBasedOnInvstIncmGrp> ExciseTaxBasedOnInvstIncmGrp { get; set; }

    [JsonPropertyName("StatementsRegardingActyGrp"),  JsonConverter(typeof(SingleOrArrayConverter<StatementsRegardingActyGrp>))]
    public List<StatementsRegardingActyGrp> StatementsRegardingActyGrp { get; set; }

    [JsonPropertyName("StatementsRegardingActy4720Grp"),  JsonConverter(typeof(SingleOrArrayConverter<StatementsRegardingActy4720Grp>))]
    public List<StatementsRegardingActy4720Grp> StatementsRegardingActy4720Grp { get; set; }

    [JsonPropertyName("OfficerDirTrstKeyEmplInfoGrp"),  JsonConverter(typeof(SingleOrArrayConverter<OfficerDirTrstKeyEmplInfoGrp>))]
    public List<OfficerDirTrstKeyEmplInfoGrp> OfficerDirTrstKeyEmplInfoGrp { get; set; }

    [JsonPropertyName("SummaryOfDirectChrtblActyGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> SummaryOfDirectChrtblActyGrp { get; set; }

    [JsonPropertyName("SumOfProgramRelatedInvstGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> SumOfProgramRelatedInvstGrp { get; set; }

    [JsonPropertyName("MinimumInvestmentReturnGrp"),  JsonConverter(typeof(SingleOrArrayConverter<MinimumInvestmentReturnGrp>))]
    public List<MinimumInvestmentReturnGrp> MinimumInvestmentReturnGrp { get; set; }

    [JsonPropertyName("DistributableAmountGrp"),  JsonConverter(typeof(SingleOrArrayConverter<DistributableAmountGrp>))]
    public List<DistributableAmountGrp> DistributableAmountGrp { get; set; }

    [JsonPropertyName("QualifyingDistriPartXIIGrp"),  JsonConverter(typeof(SingleOrArrayConverter<QualifyingDistriPartXIIGrp>))]
    public List<QualifyingDistriPartXIIGrp> QualifyingDistriPartXIIGrp { get; set; }

    [JsonPropertyName("UndistributedIncomeGrp"),  JsonConverter(typeof(SingleOrArrayConverter<UndistributedIncomeGrp>))]
    public List<UndistributedIncomeGrp> UndistributedIncomeGrp { get; set; }

    [JsonPropertyName("SupplementaryInformationGrp"),  JsonConverter(typeof(SingleOrArrayConverter<SupplementaryInformationGrp>))]
    public List<SupplementaryInformationGrp> SupplementaryInformationGrp { get; set; }

    [JsonPropertyName("AnalysisIncomeProducingActyGrp"),  
     JsonConverter(typeof(SingleOrArrayConverter<AnalysisIncomeProducingActyGrp>))]
    public List<AnalysisIncomeProducingActyGrp> AnalysisIncomeProducingActyGrp { get; set; }

    [JsonPropertyName("TrnsfrTransRlnNonchrtblEOGrp"), 
     JsonConverter(typeof(SingleOrArrayConverter<TrnsfrTransRlnNonchrtblEOGrp>))]
    public List<TrnsfrTransRlnNonchrtblEOGrp> TrnsfrTransRlnNonchrtblEOGrp { get; set; }

    [JsonPropertyName("MethodOfAccountingCashInd"), 
     JsonConverter(typeof(FixScrewedUpString))]
    public string MethodOfAccountingCashInd { get; set; }

    [JsonPropertyName("PrivateOperatingFoundationsGrp"),  
     JsonConverter(typeof(SingleOrArrayConverter<PrivateOperatingFoundationsGrp>))]
    public List<PrivateOperatingFoundationsGrp> PrivateOperatingFoundationsGrp { get; set; }

    [JsonPropertyName("@referenceDocumentId")]
    public string ReferenceDocumentId { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("AmendedReturnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AmendedReturnInd { get; set; }

    [JsonPropertyName("Organization4947a1TrtdPFInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Organization4947a1TrtdPFInd { get; set; }

    [JsonPropertyName("RlnOfActyToAccomOfExmptPrpsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> RlnOfActyToAccomOfExmptPrpsGrp { get; set; }

    [JsonPropertyName("AddressChangeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AddressChangeInd { get; set; }

    [JsonPropertyName("MethodOfAccountingOtherInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MethodOfAccountingOtherInd { get; set; }

    [JsonPropertyName("InitialReturnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InitialReturnInd { get; set; }

    [JsonPropertyName("FinalReturnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FinalReturnInd { get; set; }

    [JsonPropertyName("PFStatusTermSect507b1AInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PFStatusTermSect507b1AInd { get; set; }

    [JsonPropertyName("InitialReturnFormerPubChrtyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InitialReturnFormerPubChrtyInd { get; set; }

    [JsonPropertyName("SpecialConditionDesc")]
    public string SpecialConditionDesc { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }

    [JsonPropertyName("Organization501c3TaxablePFInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Organization501c3TaxablePFInd { get; set; }
}

public class IRS990ScheduleA
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("PublicOrganization170Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string PublicOrganization170Ind { get; set; }

    [JsonPropertyName("GiftsGrantsContriRcvd170Grp"),  JsonConverter(typeof(SingleOrArrayConverter<GiftsGrantsContriRcvd170Grp>))]
    public List<GiftsGrantsContriRcvd170Grp> GiftsGrantsContriRcvd170Grp { get; set; }

    [JsonPropertyName("TotalCalendarYear170Grp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalCalendarYear170Grp>))]
    public List<TotalCalendarYear170Grp> TotalCalendarYear170Grp { get; set; }

    [JsonPropertyName("PublicSupportTotal170Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PublicSupportTotal170Amt { get; set; }

    [JsonPropertyName("GrossInvestmentIncome170Grp"),  JsonConverter(typeof(SingleOrArrayConverter<GrossInvestmentIncome170Grp>))]
    public List<GrossInvestmentIncome170Grp> GrossInvestmentIncome170Grp { get; set; }

    [JsonPropertyName("OtherIncome170Grp"),  JsonConverter(typeof(SingleOrArrayConverter<OtherIncome170Grp>))]
    public List<OtherIncome170Grp> OtherIncome170Grp { get; set; }

    [JsonPropertyName("TotalSupportAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalSupportAmt { get; set; }

    [JsonPropertyName("GrossReceiptsRltdActivitiesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossReceiptsRltdActivitiesAmt { get; set; }

    [JsonPropertyName("PublicSupportCY170Pct")]
    public string PublicSupportCY170Pct { get; set; }

    [JsonPropertyName("PublicSupportPY170Pct")]
    public string PublicSupportPY170Pct { get; set; }

    [JsonPropertyName("ThirtyThrPctSuprtTestsCY170Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string ThirtyThrPctSuprtTestsCY170Ind { get; set; }

    [JsonPropertyName("Form990ScheduleAPartVIGrp"),  JsonConverter(typeof(SingleOrArrayConverter<Form990ScheduleAPartVIGrp>))]
    public List<Form990ScheduleAPartVIGrp> Form990ScheduleAPartVIGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("TaxRevLeviedOrgnztnlBnft170Grp"),  
     JsonConverter(typeof(SingleOrArrayConverter<TaxRevLeviedOrgnztnlBnft170Grp>))]
    public List<TaxRevLeviedOrgnztnlBnft170Grp> TaxRevLeviedOrgnztnlBnft170Grp { get; set; }

    [JsonPropertyName("GovtFurnSrvcFcltsVl170Grp"),
     JsonConverter(typeof(SingleOrArrayConverter<GovtFurnSrvcFcltsVl170Grp>))]
    public List<GovtFurnSrvcFcltsVl170Grp> GovtFurnSrvcFcltsVl170Grp { get; set; }

    [JsonPropertyName("SubstantialContributorsTotAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SubstantialContributorsTotAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessNetIncm170Grp"), 
     JsonConverter(typeof(SingleOrArrayConverter<UnrelatedBusinessNetIncm170Grp>))]
    public List<UnrelatedBusinessNetIncm170Grp> UnrelatedBusinessNetIncm170Grp { get; set; }

    [JsonPropertyName("PubliclySupportedOrg509a2Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string PubliclySupportedOrg509a2Ind { get; set; }

    [JsonPropertyName("GiftsGrantsContrisRcvd509Grp"),  JsonConverter(typeof(SingleOrArrayConverter<GiftsGrantsContrisRcvd509Grp>))]
    public List<GiftsGrantsContrisRcvd509Grp> GiftsGrantsContrisRcvd509Grp { get; set; }

    [JsonPropertyName("Total509Grp"),  JsonConverter(typeof(SingleOrArrayConverter<Total509Grp>))] 
    public List<Total509Grp> Total509Grp { get; set; }

    [JsonPropertyName("AmountsRcvdDsqlfyPersonGrp"),  JsonConverter(typeof(SingleOrArrayConverter<AmountsRcvdDsqlfyPersonGrp>))]
    public List<AmountsRcvdDsqlfyPersonGrp> AmountsRcvdDsqlfyPersonGrp { get; set; }

    [JsonPropertyName("SubstantialContributorsAmtGrp"),  JsonConverter(typeof(SingleOrArrayConverter<SubstantialContributorsAmtGrp>))]
    public List<SubstantialContributorsAmtGrp> SubstantialContributorsAmtGrp { get; set; }

    [JsonPropertyName("SubstAndDsqlfyPrsnsTotGrp"),  JsonConverter(typeof(SingleOrArrayConverter<SubstAndDsqlfyPrsnsTotGrp>))]
    public List<SubstAndDsqlfyPrsnsTotGrp> SubstAndDsqlfyPrsnsTotGrp { get; set; }

    [JsonPropertyName("PublicSupportTotal509Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PublicSupportTotal509Amt { get; set; }

    [JsonPropertyName("TotalSupportCalendarYearGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalSupportCalendarYearGrp>))]
    public List<TotalSupportCalendarYearGrp> TotalSupportCalendarYearGrp { get; set; }

    [JsonPropertyName("PublicSupportCY509Pct")]
    public string PublicSupportCY509Pct { get; set; }

    [JsonPropertyName("PublicSupportPY509Pct")]
    public string PublicSupportPY509Pct { get; set; }

    [JsonPropertyName("InvestmentIncomeCYPct")]
    public string InvestmentIncomeCYPct { get; set; }

    [JsonPropertyName("ThirtyThrPctSuprtTestsCY509Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string ThirtyThrPctSuprtTestsCY509Ind { get; set; }

    [JsonPropertyName("First5Years170Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string First5Years170Ind { get; set; }

    [JsonPropertyName("GrossReceiptsAdmissionsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<GrossReceiptsAdmissionsGrp>))]
    public List<GrossReceiptsAdmissionsGrp> GrossReceiptsAdmissionsGrp { get; set; }

    [JsonPropertyName("GrossReceiptsNonUnrltBusGrp"),  JsonConverter(typeof(SingleOrArrayConverter<GrossReceiptsNonUnrltBusGrp>))]
    public List<GrossReceiptsNonUnrltBusGrp> GrossReceiptsNonUnrltBusGrp { get; set; }

    [JsonPropertyName("TaxRevLeviedOrgnztnlBnft509Grp"),  JsonConverter(typeof(SingleOrArrayConverter<TaxRevLeviedOrgnztnlBnft509Grp>))]
    public List<TaxRevLeviedOrgnztnlBnft509Grp> TaxRevLeviedOrgnztnlBnft509Grp { get; set; }

    [JsonPropertyName("GovtFurnSrvcFcltsVl509Grp"),  JsonConverter(typeof(SingleOrArrayConverter<GovtFurnSrvcFcltsVl509Grp>))]
    public List<GovtFurnSrvcFcltsVl509Grp> GovtFurnSrvcFcltsVl509Grp { get; set; }

    [JsonPropertyName("GrossInvestmentIncome509Grp"),  JsonConverter(typeof(SingleOrArrayConverter<GrossInvestmentIncome509Grp>))]
    public List<GrossInvestmentIncome509Grp> GrossInvestmentIncome509Grp { get; set; }

    [JsonPropertyName("Post1975UBTIGrp"),  JsonConverter(typeof(SingleOrArrayConverter<Post1975UBTIGrp>))] 
    public List<Post1975UBTIGrp> Post1975UBTIGrp { get; set; }

    [JsonPropertyName("InvestmentIncomeAndUBTIGrp"),  JsonConverter(typeof(SingleOrArrayConverter<InvestmentIncomeAndUBTIGrp>))]
    public List<InvestmentIncomeAndUBTIGrp> InvestmentIncomeAndUBTIGrp { get; set; }

    [JsonPropertyName("NetIncomeFromOtherUBIGrp"),  JsonConverter(typeof(SingleOrArrayConverter<NetIncomeFromOtherUBIGrp>))]
    public List<NetIncomeFromOtherUBIGrp> NetIncomeFromOtherUBIGrp { get; set; }

    [JsonPropertyName("OtherIncome509Grp"),  JsonConverter(typeof(SingleOrArrayConverter<OtherIncome509Grp>))]
    public List<OtherIncome509Grp> OtherIncome509Grp { get; set; }

    [JsonPropertyName("First5Years509Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string First5Years509Ind { get; set; }

    [JsonPropertyName("InvestmentIncomePYPct")]
    public string InvestmentIncomePYPct { get; set; }

    [JsonPropertyName("TenPctFactsCrcmstncsTestCYInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TenPctFactsCrcmstncsTestCYInd { get; set; }

    [JsonPropertyName("FactsAndCircumstancesTestTxt")]
    public string FactsAndCircumstancesTestTxt { get; set; }

    [JsonPropertyName("SupportingOrganization509a3Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string SupportingOrganization509a3Ind { get; set; }

    [JsonPropertyName("SupportingOrgType1Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string SupportingOrgType1Ind { get; set; }

    [JsonPropertyName("SupportedOrganizationsCnt")]
    public string SupportedOrganizationsCnt { get; set; }

    [JsonPropertyName("SupportedOrgInformationGrp"),  JsonConverter(typeof(SingleOrArrayConverter<SupportedOrgInformationGrp>))]
    public List<SupportedOrgInformationGrp> SupportedOrgInformationGrp { get; set; }

    [JsonPropertyName("SupportedOrganizationsTotalCnt")]
    public string SupportedOrganizationsTotalCnt { get; set; }

    [JsonPropertyName("SupportSumAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SupportSumAmt { get; set; }

    [JsonPropertyName("OtherSupportSumAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherSupportSumAmt { get; set; }

    [JsonPropertyName("Form990SchASupportingOrgGrp"),  JsonConverter(typeof(SingleOrArrayConverter<Form990SchASupportingOrgGrp>))]
    public List<Form990SchASupportingOrgGrp> Form990SchASupportingOrgGrp { get; set; }

    [JsonPropertyName("Form990SchAType1SuprtOrgGrp"),  JsonConverter(typeof(SingleOrArrayConverter<Form990SchAType1SuprtOrgGrp>))]
    public List<Form990SchAType1SuprtOrgGrp> Form990SchAType1SuprtOrgGrp { get; set; }

    [JsonPropertyName("SchoolInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SchoolInd { get; set; }

    [JsonPropertyName("PrivateFoundation509Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string PrivateFoundation509Ind { get; set; }

    [JsonPropertyName("ChurchInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ChurchInd { get; set; }

    [JsonPropertyName("HospitalInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string HospitalInd { get; set; }

    [JsonPropertyName("SupportingOrgType3NonFuncInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SupportingOrgType3NonFuncInd { get; set; }

    [JsonPropertyName("Form990SchAType3SprtOrgAllGrp"),  JsonConverter(typeof(SingleOrArrayConverter<Form990SchAType3SprtOrgAllGrp>))]
    public List<Form990SchAType3SprtOrgAllGrp> Form990SchAType3SprtOrgAllGrp { get; set; }

    [JsonPropertyName("AdjustedNetIncomeGrp"),  JsonConverter(typeof(SingleOrArrayConverter<AdjustedNetIncomeGrp>))]
    public List<AdjustedNetIncomeGrp> AdjustedNetIncomeGrp { get; set; }

    [JsonPropertyName("MinimumAssetAmountGrp"),  JsonConverter(typeof(SingleOrArrayConverter<MinimumAssetAmountGrp>))]
    public List<MinimumAssetAmountGrp> MinimumAssetAmountGrp { get; set; }

    [JsonPropertyName("DistributableAmountGrp"),  JsonConverter(typeof(SingleOrArrayConverter<DistributableAmountGrp>))]
    public List<DistributableAmountGrp> DistributableAmountGrp { get; set; }

    [JsonPropertyName("DistributionsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<DistributionsGrp>))]
    public List<DistributionsGrp> DistributionsGrp { get; set; }

    [JsonPropertyName("DistributionAllocationsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<DistributionAllocationsGrp>))]
    public List<DistributionAllocationsGrp> DistributionAllocationsGrp { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }

    [JsonPropertyName("CollegeOrganizationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CollegeOrganizationInd { get; set; }

    [JsonPropertyName("IRSWrittenDeterminationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string IRSWrittenDeterminationInd { get; set; }

    [JsonPropertyName("SupportingOrgType3FuncIntInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SupportingOrgType3FuncIntInd { get; set; }

    [JsonPropertyName("Form990SchAType3FuncIntGrp"),  JsonConverter(typeof(SingleOrArrayConverter<Form990SchAType3FuncIntGrp>))]
    public List<Form990SchAType3FuncIntGrp> Form990SchAType3FuncIntGrp { get; set; }

    [JsonPropertyName("SupportingOrgType2Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string SupportingOrgType2Ind { get; set; }

    [JsonPropertyName("MajorityDirTrstSupportedOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MajorityDirTrstSupportedOrgInd { get; set; }

    [JsonPropertyName("ThirtyThrPctSuprtTestsPY509Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string ThirtyThrPctSuprtTestsPY509Ind { get; set; }

    [JsonPropertyName("CommunityTrustInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CommunityTrustInd { get; set; }

    [JsonPropertyName("GovernmentalUnitInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GovernmentalUnitInd { get; set; }

    [JsonPropertyName("PrivateFoundation170Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string PrivateFoundation170Ind { get; set; }

    [JsonPropertyName("MedicalResearchOrganizationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MedicalResearchOrganizationInd { get; set; }

    [JsonPropertyName("HospitalNameAndAddressGrp"),  JsonConverter(typeof(SingleOrArrayConverter<HospitalNameAndAddressGrp>))]
    public List<HospitalNameAndAddressGrp> HospitalNameAndAddressGrp { get; set; }

    [JsonPropertyName("ThirtyThrPctSuprtTestsPY170Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string ThirtyThrPctSuprtTestsPY170Ind { get; set; }

    [JsonPropertyName("TenPctFactsCrcmstncsTestPYInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TenPctFactsCrcmstncsTestPYInd { get; set; }

    [JsonPropertyName("TestPublicSafetyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TestPublicSafetyInd { get; set; }

    [JsonPropertyName("TrustIntegralPartTestInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TrustIntegralPartTestInd { get; set; }

    [JsonPropertyName("AgriculturalResearchOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AgriculturalResearchOrgInd { get; set; }

    [JsonPropertyName("AgriculturalNameAndAddressGrp"),  JsonConverter(typeof(SingleOrArrayConverter<AgriculturalNameAndAddressGrp>))]
    public List<AgriculturalNameAndAddressGrp> AgriculturalNameAndAddressGrp { get; set; }
}

public class IRS990ScheduleB
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("Organization501c3ExemptPFInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Organization501c3ExemptPFInd { get; set; }

    [JsonPropertyName("GeneralRuleInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GeneralRuleInd { get; set; }

    [JsonPropertyName("ContributorInformationGrp"),  JsonConverter(typeof(SingleOrArrayConverter<ContributorInformationGrp>))]
    public List<ContributorInformationGrp> ContributorInformationGrp { get; set; }

    [JsonPropertyName("@softwareId")]
    public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("NonCashPropertyContributionGrp"),  JsonConverter(typeof(SingleOrArrayConverter<NonCashPropertyContributionGrp>))]
    public List<NonCashPropertyContributionGrp> NonCashPropertyContributionGrp { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }

    [JsonPropertyName("Organization501c3TaxablePFInd"),
     JsonConverter(typeof(FixScrewedUpString))]
    public string Organization501c3TaxablePFInd { get; set; }

    [JsonPropertyName("Organization501cInd"),
     JsonConverter(typeof(FixScrewedUpString))]
    public string Organization501cInd { get; set; }

    [JsonPropertyName("CharitableContributionsDetail")]
    public CharitableContributionsDetail CharitableContributionsDetail { get; set; }

    [JsonPropertyName("Organization4947a1TrtdPFInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Organization4947a1TrtdPFInd { get; set; }

    [JsonPropertyName("TotalUnder1000ContributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalUnder1000ContributionsAmt { get; set; }
}

public class IRS990ScheduleC
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("SubstantiallyAllDuesNondedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SubstantiallyAllDuesNondedInd { get; set; }

    [JsonPropertyName("OnlyInHouseLobbyingInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OnlyInHouseLobbyingInd { get; set; }

    [JsonPropertyName("AgreeCarryoverPriorYearInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AgreeCarryoverPriorYearInd { get; set; }

    [JsonPropertyName("Form1120POLFiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form1120POLFiledInd { get; set; }

    [JsonPropertyName("VolunteersInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string VolunteersInd { get; set; }

    [JsonPropertyName("PaidStaffOrManagementInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PaidStaffOrManagementInd { get; set; }

    [JsonPropertyName("MediaAdvertisementsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MediaAdvertisementsInd { get; set; }

    [JsonPropertyName("MailingsMembersInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MailingsMembersInd { get; set; }

    [JsonPropertyName("PublicationsOrBroadcastInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PublicationsOrBroadcastInd { get; set; }

    [JsonPropertyName("GrantsOtherOrganizationsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantsOtherOrganizationsInd { get; set; }

    [JsonPropertyName("DirectContactLegislatorsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectContactLegislatorsInd { get; set; }

    [JsonPropertyName("RalliesDemonstrationsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string RalliesDemonstrationsInd { get; set; }

    [JsonPropertyName("OtherActivitiesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherActivitiesInd { get; set; }

    [JsonPropertyName("NotDescribedSection501c3Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string NotDescribedSection501c3Ind { get; set; }

    [JsonPropertyName("OtherActivitiesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherActivitiesAmt { get; set; }

    [JsonPropertyName("TotalLobbyingExpendituresAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalLobbyingExpendituresAmt { get; set; }

    [JsonPropertyName("SupplementalInformationDetail"),
     JsonConverter(typeof(SingleOrArrayConverter<SupplementalInformationDetail>))]
    public List<SupplementalInformationDetail> SupplementalInformationDetail { get; set; }


    [JsonPropertyName("PoliticalExpendituresAmt"), JsonConverter(typeof(FixScrewedUpString))]

    public string PoliticalExpendituresAmt { get; set; }

    [JsonPropertyName("TotalGrassrootsLobbyingGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalGrassrootsLobbyingGrp>))]
    public List<TotalGrassrootsLobbyingGrp> TotalGrassrootsLobbyingGrp { get; set; }

    [JsonPropertyName("TotalDirectLobbyingGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalDirectLobbyingGrp>))]
    public List<TotalDirectLobbyingGrp> TotalDirectLobbyingGrp { get; set; }

    [JsonPropertyName("TotalLobbyingExpendGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalLobbyingExpendGrp>))]
    public List<TotalLobbyingExpendGrp> TotalLobbyingExpendGrp { get; set; }

    [JsonPropertyName("OtherExemptPurposeExpendGrp"),  JsonConverter(typeof(SingleOrArrayConverter<OtherExemptPurposeExpendGrp>))]
    public List<OtherExemptPurposeExpendGrp> OtherExemptPurposeExpendGrp { get; set; }

    [JsonPropertyName("TotalExemptPurposeExpendGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalExemptPurposeExpendGrp>))]
    public List<TotalExemptPurposeExpendGrp> TotalExemptPurposeExpendGrp { get; set; }

    [JsonPropertyName("LobbyingNontaxableAmountGrp"),  JsonConverter(typeof(SingleOrArrayConverter<LobbyingNontaxableAmountGrp>))]
    public List<LobbyingNontaxableAmountGrp> LobbyingNontaxableAmountGrp { get; set; }

    [JsonPropertyName("GrassrootsNontaxableGrp"),  JsonConverter(typeof(SingleOrArrayConverter<GrassrootsNontaxableGrp>))]
    public List<GrassrootsNontaxableGrp> GrassrootsNontaxableGrp { get; set; }

    [JsonPropertyName("TotLbbyngGrassrootMnsNonTxGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotLbbyngGrassrootMnsNonTxGrp>))]
    public List<TotLbbyngGrassrootMnsNonTxGrp> TotLbbyngGrassrootMnsNonTxGrp { get; set; }

    [JsonPropertyName("TotLbbyExpendMnsLbbyngNonTxGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotLbbyExpendMnsLbbyngNonTxGrp>))]
    public List<TotLbbyExpendMnsLbbyngNonTxGrp> TotLbbyExpendMnsLbbyngNonTxGrp { get; set; }

    [JsonPropertyName("DirectContactLegislatorsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectContactLegislatorsAmt { get; set; }

    [JsonPropertyName("AvgLobbyingNontaxableAmountGrp"),  JsonConverter(typeof(SingleOrArrayConverter<AvgLobbyingNontaxableAmountGrp>))]
    public List<AvgLobbyingNontaxableAmountGrp> AvgLobbyingNontaxableAmountGrp { get; set; }

    [JsonPropertyName("LobbyingCeilingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LobbyingCeilingAmt { get; set; }

    [JsonPropertyName("AvgTotalLobbyingExpendGrp"),  JsonConverter(typeof(SingleOrArrayConverter<AvgTotalLobbyingExpendGrp>))]
    public List<AvgTotalLobbyingExpendGrp> AvgTotalLobbyingExpendGrp { get; set; }

    [JsonPropertyName("AvgGrassrootsNontaxableGrp"),  JsonConverter(typeof(SingleOrArrayConverter<AvgGrassrootsNontaxableGrp>))]
    public List<AvgGrassrootsNontaxableGrp> AvgGrassrootsNontaxableGrp { get; set; }

    [JsonPropertyName("GrassrootsCeilingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrassrootsCeilingAmt { get; set; }

    [JsonPropertyName("AvgGrassrootsLobbyingExpendGrp"),  JsonConverter(typeof(SingleOrArrayConverter<AvgGrassrootsLobbyingExpendGrp>))]
    public List<AvgGrassrootsLobbyingExpendGrp> AvgGrassrootsLobbyingExpendGrp { get; set; }

    [JsonPropertyName("DuesAssessmentsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DuesAssessmentsAmt { get; set; }

    [JsonPropertyName("NonDeductibleLbbyngPltclCYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NonDeductibleLbbyngPltclCYAmt { get; set; }

    [JsonPropertyName("NonDedLbbyngPltclCyovAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NonDedLbbyngPltclCyovAmt { get; set; }

    [JsonPropertyName("NonDeductibleLbbyngPltclTotAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NonDeductibleLbbyngPltclTotAmt { get; set; }

    [JsonPropertyName("AggregateReportedDuesNtcAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AggregateReportedDuesNtcAmt { get; set; }

    [JsonPropertyName("TaxableAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxableAmt { get; set; }

    [JsonPropertyName("VolunteerHoursCnt")]
    public string VolunteerHoursCnt { get; set; }

    [JsonPropertyName("InternalFundsContributedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InternalFundsContributedAmt { get; set; }

    [JsonPropertyName("TotalExemptFunctionExpendAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalExemptFunctionExpendAmt { get; set; }

    [JsonPropertyName("Section527PoliticalOrgGrp"),  JsonConverter(typeof(SingleOrArrayConverter<Section527PoliticalOrgGrp>))]
    public List<Section527PoliticalOrgGrp> Section527PoliticalOrgGrp { get; set; }

    [JsonPropertyName("CarriedOverAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CarriedOverAmt { get; set; }

    [JsonPropertyName("Form4720FiledSection4955TaxInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form4720FiledSection4955TaxInd { get; set; }

    [JsonPropertyName("CorrectionMadeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CorrectionMadeInd { get; set; }

    [JsonPropertyName("Form4720FiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form4720FiledInd { get; set; }

    [JsonPropertyName("Section4955OrganizationTaxAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Section4955OrganizationTaxAmt { get; set; }

    [JsonPropertyName("Section4955ManagersTaxAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Section4955ManagersTaxAmt { get; set; }

    [JsonPropertyName("Expended527ActivitiesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Expended527ActivitiesAmt { get; set; }

    [JsonPropertyName("Form4720Filed4912TaxInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form4720Filed4912TaxInd { get; set; }

    [JsonPropertyName("MailingsMembersAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string MailingsMembersAmt { get; set; }

    [JsonPropertyName("MediaAdvertisementsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string MediaAdvertisementsAmt { get; set; }

    [JsonPropertyName("PublicationsOrBroadcastAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PublicationsOrBroadcastAmt { get; set; }

    [JsonPropertyName("GrantsOtherOrganizationsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantsOtherOrganizationsAmt { get; set; }

    [JsonPropertyName("RalliesDemonstrationsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RalliesDemonstrationsAmt { get; set; }

    [JsonPropertyName("LimitedControlProvisionsAppInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LimitedControlProvisionsAppInd { get; set; }

    [JsonPropertyName("OrganizationBelongsAffltGrpInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OrganizationBelongsAffltGrpInd { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }

    [JsonPropertyName("Tax4912Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Tax4912Amt { get; set; }

    [JsonPropertyName("Managers4912TaxAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Managers4912TaxAmt { get; set; }
}

public class IRS990ScheduleD
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("OtherLandBuildingsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<OtherLandBuildingsGrp>))]
    public List<OtherLandBuildingsGrp> OtherLandBuildingsGrp { get; set; }

    [JsonPropertyName("TotalBookValueLandBuildingsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalBookValueLandBuildingsAmt { get; set; }

    [JsonPropertyName("OtherLiabilitiesOrgGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<OtherLiabilitiesOrgGrp>))]
    public List<OtherLiabilitiesOrgGrp> OtherLiabilitiesOrgGrp { get; set; }


    [JsonPropertyName("TotalLiabilityAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalLiabilityAmt { get; set; }

    [JsonPropertyName("BuildingsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<BuildingsGrp>))] 
    public List<BuildingsGrp> BuildingsGrp { get; set; }

    [JsonPropertyName("EquipmentGrp"),  JsonConverter(typeof(SingleOrArrayConverter<EquipmentGrp>))]
    public List<EquipmentGrp> EquipmentGrp { get; set; }

    [JsonPropertyName("OtherAssetsOrgGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<OtherAssetsOrgGrp>))]
    public List<OtherAssetsOrgGrp> OtherAssetsOrgGrp { get; set; }

    [JsonPropertyName("TotalBookValueOtherAssetsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalBookValueOtherAssetsAmt { get; set; }

    [JsonPropertyName("TotalRevEtcAuditedFinclStmtAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRevEtcAuditedFinclStmtAmt { get; set; }

    [JsonPropertyName("DonatedServicesAndUseFcltsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DonatedServicesAndUseFcltsAmt { get; set; }

    [JsonPropertyName("RevenueNotReportedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RevenueNotReportedAmt { get; set; }

    [JsonPropertyName("RevenueSubtotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RevenueSubtotalAmt { get; set; }

    [JsonPropertyName("RevenueNotReportedFinclStmtAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RevenueNotReportedFinclStmtAmt { get; set; }

    [JsonPropertyName("TotalRevenuePerForm990Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRevenuePerForm990Amt { get; set; }

    [JsonPropertyName("TotExpnsEtcAuditedFinclStmtAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotExpnsEtcAuditedFinclStmtAmt { get; set; }

    [JsonPropertyName("DonatedServicesUseFcltsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DonatedServicesUseFcltsAmt { get; set; }

    [JsonPropertyName("ExpensesNotReportedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExpensesNotReportedAmt { get; set; }

    [JsonPropertyName("ExpensesSubtotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExpensesSubtotalAmt { get; set; }

    [JsonPropertyName("ExpensesNotRptFinclStmtAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExpensesNotRptFinclStmtAmt { get; set; }

    [JsonPropertyName("TotalExpensesPerForm990Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalExpensesPerForm990Amt { get; set; }

    [JsonPropertyName("LandGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))] 
    public List<dynamic> LandGrp { get; set; }

    [JsonPropertyName("LeaseholdImprovementsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<LeaseholdImprovementsGrp>))]
    public List<LeaseholdImprovementsGrp> LeaseholdImprovementsGrp { get; set; }

    [JsonPropertyName("ArtPublicExhibitionAmountsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> ArtPublicExhibitionAmountsGrp { get; set; }

    [JsonPropertyName("HeldWorksArtGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))] 
    public List<dynamic> HeldWorksArtGrp { get; set; }

    [JsonPropertyName("CYMinus3YrEndwmtFundGrp"),  JsonConverter(typeof(SingleOrArrayConverter<CYMinus3YrEndwmtFundGrp>))]
    public List<CYMinus3YrEndwmtFundGrp> CYMinus3YrEndwmtFundGrp { get; set; }

    [JsonPropertyName("CYMinus4YrEndwmtFundGrp"),  JsonConverter(typeof(SingleOrArrayConverter<CYMinus4YrEndwmtFundGrp>))]
    public List<CYMinus4YrEndwmtFundGrp> CYMinus4YrEndwmtFundGrp { get; set; }

    [JsonPropertyName("FederalIncomeTaxLiabilityAmt"),
     JsonConverter(typeof(FixScrewedUpString))]
    public string FederalIncomeTaxLiabilityAmt { get; set; }

    [JsonPropertyName("InclEscrowCustodialAcctLiabInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InclEscrowCustodialAcctLiabInd { get; set; }

    [JsonPropertyName("OtherSecuritiesGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<OtherSecuritiesGrp>))]
    public List<OtherSecuritiesGrp> OtherSecuritiesGrp { get; set; }

    [JsonPropertyName("OtherRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherRevenueAmt { get; set; }

    [JsonPropertyName("OtherExpensesIncludedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherExpensesIncludedAmt { get; set; }

    [JsonPropertyName("SupplementalInformationDetail"),
     JsonConverter(typeof(SingleOrArrayConverter<SupplementalInformationDetail>))]
    public List<SupplementalInformationDetail> SupplementalInformationDetail { get; set; }

    [JsonPropertyName("AgentTrusteeEtcInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AgentTrusteeEtcInd { get; set; }

    [JsonPropertyName("CYEndwmtFundGrp"),  JsonConverter(typeof(SingleOrArrayConverter<CYEndwmtFundGrp>))]
    public List<CYEndwmtFundGrp> CYEndwmtFundGrp { get; set; }

    [JsonPropertyName("CYMinus1YrEndwmtFundGrp"),  JsonConverter(typeof(SingleOrArrayConverter<CYMinus1YrEndwmtFundGrp>))]
    public List<CYMinus1YrEndwmtFundGrp> CYMinus1YrEndwmtFundGrp { get; set; }

    [JsonPropertyName("CYMinus2YrEndwmtFundGrp"),  JsonConverter(typeof(SingleOrArrayConverter<CYMinus2YrEndwmtFundGrp>))]
    public List<CYMinus2YrEndwmtFundGrp> CYMinus2YrEndwmtFundGrp { get; set; }

    [JsonPropertyName("BoardDesignatedBalanceEOYPct")]
    public string BoardDesignatedBalanceEOYPct { get; set; }

    [JsonPropertyName("PrmnntEndowmentBalanceEOYPct")]
    public string PrmnntEndowmentBalanceEOYPct { get; set; }

    [JsonPropertyName("TermEndowmentBalanceEOYPct")]
    public string TermEndowmentBalanceEOYPct { get; set; }

    [JsonPropertyName("EndowmentsHeldUnrelatedOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string EndowmentsHeldUnrelatedOrgInd { get; set; }

    [JsonPropertyName("EndowmentsHeldRelatedOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string EndowmentsHeldRelatedOrgInd { get; set; }

    [JsonPropertyName("TotalBookValueSecuritiesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalBookValueSecuritiesAmt { get; set; }

    [JsonPropertyName("FootnoteTextInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FootnoteTextInd { get; set; }

    [JsonPropertyName("NetUnrealizedGainsInvstAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetUnrealizedGainsInvstAmt { get; set; }

    [JsonPropertyName("InvestmentExpensesNotIncldAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvestmentExpensesNotIncldAmt { get; set; }

    [JsonPropertyName("InvestmentExpensesNotIncld2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvestmentExpensesNotIncld2Amt { get; set; }

    [JsonPropertyName("OtherRevenuesNotIncludedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherRevenuesNotIncludedAmt { get; set; }

    [JsonPropertyName("OtherExpensesNotIncludedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherExpensesNotIncludedAmt { get; set; }

    [JsonPropertyName("InvstProgramRelatedOrgGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<InvstProgramRelatedOrgGrp>))]
    public List<InvstProgramRelatedOrgGrp> InvstProgramRelatedOrgGrp { get; set; }

    [JsonPropertyName("TotalBookValueProgramRltdAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalBookValueProgramRltdAmt { get; set; }

    [JsonPropertyName("DisclosedOrgLegCtrlInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DisclosedOrgLegCtrlInd { get; set; }

    [JsonPropertyName("DisclosedForCharitablePrpsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DisclosedForCharitablePrpsInd { get; set; }

    [JsonPropertyName("RecoveriesPriorYearGrantsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RecoveriesPriorYearGrantsAmt { get; set; }

    [JsonPropertyName("PriorYearAdjustmentsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAdjustmentsAmt { get; set; }

    [JsonPropertyName("LossesReportedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LossesReportedAmt { get; set; }

    [JsonPropertyName("RelatedOrgListSchRInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrgListSchRInd { get; set; }

    [JsonPropertyName("FinancialDerivativesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> FinancialDerivativesGrp { get; set; }

    [JsonPropertyName("CloselyHeldEquityInterestsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<CloselyHeldEquityInterestsGrp>))]
    public List<CloselyHeldEquityInterestsGrp> CloselyHeldEquityInterestsGrp { get; set; }

    [JsonPropertyName("CollectionUsedPreservationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CollectionUsedPreservationInd { get; set; }

    [JsonPropertyName("SolicitedAssetsSaleInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SolicitedAssetsSaleInd { get; set; }

    [JsonPropertyName("ExplanationProvidedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExplanationProvidedInd { get; set; }

    [JsonPropertyName("PreservationPublicUseInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PreservationPublicUseInd { get; set; }

    [JsonPropertyName("ProtectionNaturalHabitatInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProtectionNaturalHabitatInd { get; set; }

    [JsonPropertyName("PreservationOpenSpaceInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PreservationOpenSpaceInd { get; set; }

    [JsonPropertyName("HistoricLandAreaInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string HistoricLandAreaInd { get; set; }

    [JsonPropertyName("TotalEasementsCnt")]
    public string TotalEasementsCnt { get; set; }

    [JsonPropertyName("TotalAcreageCnt")] public string TotalAcreageCnt { get; set; }

    [JsonPropertyName("StatesEasementsHeldCnt")]
    public string StatesEasementsHeldCnt { get; set; }

    [JsonPropertyName("WrittenPolicyMonitoringInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string WrittenPolicyMonitoringInd { get; set; }

    [JsonPropertyName("StaffHoursSpentEnforcementCnt")]
    public string StaffHoursSpentEnforcementCnt { get; set; }

    [JsonPropertyName("ExpensesIncurredEnforcementAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExpensesIncurredEnforcementAmt { get; set; }

    [JsonPropertyName("Section170hRqrStsfdInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Section170hRqrStsfdInd { get; set; }

    [JsonPropertyName("CollectionUsedPubExhibitionInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CollectionUsedPubExhibitionInd { get; set; }

    [JsonPropertyName("CollUsedScholarlyRsrchInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CollUsedScholarlyRsrchInd { get; set; }

    [JsonPropertyName("DonorAdvisedFundsHeldCnt")]
    public string DonorAdvisedFundsHeldCnt { get; set; }

    [JsonPropertyName("DonorAdvisedFundsGrantsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DonorAdvisedFundsGrantsAmt { get; set; }

    [JsonPropertyName("DonorAdvisedFundsVlEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DonorAdvisedFundsVlEOYAmt { get; set; }

    [JsonPropertyName("CollUsedLoanOrExchProgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CollUsedLoanOrExchProgInd { get; set; }

    [JsonPropertyName("CollectionUsedOtherPurposesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<CollectionUsedOtherPurposesGrp>))]
    public List<CollectionUsedOtherPurposesGrp> CollectionUsedOtherPurposesGrp { get; set; }

    [JsonPropertyName("DonorAdvisedFundsContriAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DonorAdvisedFundsContriAmt { get; set; }

    [JsonPropertyName("BeginningBalanceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BeginningBalanceAmt { get; set; }

    [JsonPropertyName("AdditionsDuringYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdditionsDuringYearAmt { get; set; }

    [JsonPropertyName("DistributionsDuringYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DistributionsDuringYearAmt { get; set; }

    [JsonPropertyName("EndingBalanceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EndingBalanceAmt { get; set; }

    [JsonPropertyName("FundsAndOtherAccountsHeldCnt")]
    public string FundsAndOtherAccountsHeldCnt { get; set; }

    [JsonPropertyName("FundsAndOtherAccountsContriAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundsAndOtherAccountsContriAmt { get; set; }

    [JsonPropertyName("FundsAndOtherAccountsGrantsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundsAndOtherAccountsGrantsAmt { get; set; }

    [JsonPropertyName("FundsAndOtherAccountsVlEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundsAndOtherAccountsVlEOYAmt { get; set; }

    [JsonPropertyName("HistoricStructureInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string HistoricStructureInd { get; set; }

    [JsonPropertyName("HistoricStructureEasementsCnt")]
    public string HistoricStructureEasementsCnt { get; set; }

    [JsonPropertyName("HistoricStrctrEasementsAftrCnt")]
    public string HistoricStrctrEasementsAftrCnt { get; set; }

    [JsonPropertyName("ModifiedEasementsCnt")]
    public string ModifiedEasementsCnt { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }
}

public class IRS990ScheduleE
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("NondiscriminatoryPolicyStmtInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string NondiscriminatoryPolicyStmtInd { get; set; }

    [JsonPropertyName("PolicyStmtInBrochuresEtcInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PolicyStmtInBrochuresEtcInd { get; set; }

    [JsonPropertyName("PlcyPblczdViaBroadcastMediaInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PlcyPblczdViaBroadcastMediaInd { get; set; }

    [JsonPropertyName("MaintainRacialCompRecsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MaintainRacialCompRecsInd { get; set; }

    [JsonPropertyName("MaintainScholarshipsRecsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MaintainScholarshipsRecsInd { get; set; }

    [JsonPropertyName("MaintainCpyOfBrochuresEtcInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MaintainCpyOfBrochuresEtcInd { get; set; }

    [JsonPropertyName("MaintainCpyOfAllSolInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MaintainCpyOfAllSolInd { get; set; }

    [JsonPropertyName("DiscriminateRaceStdntsRghtsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DiscriminateRaceStdntsRghtsInd { get; set; }

    [JsonPropertyName("DiscriminateRaceAdmissPlcyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DiscriminateRaceAdmissPlcyInd { get; set; }

    [JsonPropertyName("DiscriminateRaceEmplmFcultyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DiscriminateRaceEmplmFcultyInd { get; set; }

    [JsonPropertyName("DiscriminateRaceSchsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DiscriminateRaceSchsInd { get; set; }

    [JsonPropertyName("DiscriminateRaceEducPlcyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DiscriminateRaceEducPlcyInd { get; set; }

    [JsonPropertyName("DiscriminateRaceUseOfFcltsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DiscriminateRaceUseOfFcltsInd { get; set; }

    [JsonPropertyName("DiscriminateRaceAthltProgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DiscriminateRaceAthltProgInd { get; set; }

    [JsonPropertyName("DiscriminateRaceOtherActyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DiscriminateRaceOtherActyInd { get; set; }

    [JsonPropertyName("GovernmentFinancialAidRcvdInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GovernmentFinancialAidRcvdInd { get; set; }

    [JsonPropertyName("GovernmentFinancialAidRvkdInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GovernmentFinancialAidRvkdInd { get; set; }

    [JsonPropertyName("ComplianceWithRevProc7550Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string ComplianceWithRevProc7550Ind { get; set; }

    [JsonPropertyName("SupplementalInformationDetail")
     , JsonConverter(typeof(SingleOrArrayConverter<SupplementalInformationDetail>))]
    public List<SupplementalInformationDetail> SupplementalInformationDetail { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }
}

public class IRS990ScheduleF
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("GrantRecordsMaintainedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantRecordsMaintainedInd { get; set; }

    [JsonPropertyName("AccountActivitiesOutsideUSGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<AccountActivitiesOutsideUSGrp>))]
    public List<AccountActivitiesOutsideUSGrp> AccountActivitiesOutsideUSGrp { get; set; }

    [JsonPropertyName("SubtotalOfficesCnt")]
    public string SubtotalOfficesCnt { get; set; }

    [JsonPropertyName("SubtotalEmployeesCnt")]
    public string SubtotalEmployeesCnt { get; set; }

    [JsonPropertyName("ContinuationTotalOfficeCnt")]
    public string ContinuationTotalOfficeCnt { get; set; }

    [JsonPropertyName("ContinuationTotalEmployeeCnt")]
    public string ContinuationTotalEmployeeCnt { get; set; }

    [JsonPropertyName("TotalOfficeCnt")] public string TotalOfficeCnt { get; set; }

    [JsonPropertyName("TotalEmployeeCnt")] public string TotalEmployeeCnt { get; set; }

    [JsonPropertyName("SubtotalSpentAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SubtotalSpentAmt { get; set; }

    [JsonPropertyName("ContinuationSpentAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ContinuationSpentAmt { get; set; }

    [JsonPropertyName("TotalSpentAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalSpentAmt { get; set; }

    [JsonPropertyName("GrantsToOrgOutsideUSGrp"),  JsonConverter(typeof(SingleOrArrayConverter<GrantsToOrgOutsideUSGrp>))]
    public List<GrantsToOrgOutsideUSGrp> GrantsToOrgOutsideUSGrp { get; set; }

    [JsonPropertyName("TransferToForeignCorpInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TransferToForeignCorpInd { get; set; }

    [JsonPropertyName("InterestInForeignTrustInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InterestInForeignTrustInd { get; set; }

    [JsonPropertyName("ForeignCorpOwnershipInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ForeignCorpOwnershipInd { get; set; }

    [JsonPropertyName("PassiveForeignInvestmestCoInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PassiveForeignInvestmestCoInd { get; set; }

    [JsonPropertyName("ForeignPartnershipInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ForeignPartnershipInd { get; set; }

    [JsonPropertyName("BoycottCountriesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string BoycottCountriesInd { get; set; }

    [JsonPropertyName("SupplementalInformationDetail"),
     JsonConverter(typeof(SingleOrArrayConverter<SupplementalInformationDetail>))]
    public List<SupplementalInformationDetail> SupplementalInformationDetail { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("Total501c3OrgCnt")] public string Total501c3OrgCnt { get; set; }

    [JsonPropertyName("TotalOtherOrgCnt")] public string TotalOtherOrgCnt { get; set; }

    [JsonPropertyName("ForeignIndividualsGrantsGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<ForeignIndividualsGrantsGrp>))]
    public List<ForeignIndividualsGrantsGrp> ForeignIndividualsGrantsGrp { get; set; }

    [JsonPropertyName("ContinutationTotalOfficeCnt")]
    public string ContinutationTotalOfficeCnt { get; set; }

    [JsonPropertyName("ContinutationTotalEmployeeCnt")]
    public string ContinutationTotalEmployeeCnt { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }
}

public class IRS990ScheduleG
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("GamingInformationGrp"),  JsonConverter(typeof(SingleOrArrayConverter<GamingInformationGrp>))]
    public List<GamingInformationGrp> GamingInformationGrp { get; set; }

    [JsonPropertyName("StatesWhereGamingConductedCd")]
    public string StatesWhereGamingConductedCd { get; set; }

    [JsonPropertyName("GamingWithNonmembersInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GamingWithNonmembersInd { get; set; }

    [JsonPropertyName("MemberOfOtherEntityInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MemberOfOtherEntityInd { get; set; }

    [JsonPropertyName("GamingOwnFacilityPct")]
    public string GamingOwnFacilityPct { get; set; }

    [JsonPropertyName("IndividualWithBooksNm")]
    public string IndividualWithBooksNm { get; set; }

    [JsonPropertyName("PersonsWithBooksUSAddress")]
    public PersonsWithBooksUSAddress PersonsWithBooksUSAddress { get; set; }

    [JsonPropertyName("CntrctWith3rdPrtyForGameRevInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CntrctWith3rdPrtyForGameRevInd { get; set; }

    [JsonPropertyName("GamingManagerPersonNm")]
    public string GamingManagerPersonNm { get; set; }

    [JsonPropertyName("GamingManagerServicesProvTxt")]
    public string GamingManagerServicesProvTxt { get; set; }

    [JsonPropertyName("GamingManagerIsDirectorOfcrInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GamingManagerIsDirectorOfcrInd { get; set; }

    [JsonPropertyName("CharitableDistributionRqrInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CharitableDistributionRqrInd { get; set; }

    [JsonPropertyName("FundraisingEventInformationGrp"),  JsonConverter(typeof(SingleOrArrayConverter<FundraisingEventInformationGrp>))]
    public List<FundraisingEventInformationGrp> FundraisingEventInformationGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("AgrmtProfFundraisingActyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AgrmtProfFundraisingActyInd { get; set; }

    [JsonPropertyName("FundraiserActivityInfoGrp"),  JsonConverter(typeof(SingleOrArrayConverter<FundraiserActivityInfoGrp>))]
    public List<FundraiserActivityInfoGrp> FundraiserActivityInfoGrp { get; set; }

    [JsonPropertyName("TotalGrossReceiptsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalGrossReceiptsAmt { get; set; }

    [JsonPropertyName("TotalRetainedByContractorsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRetainedByContractorsAmt { get; set; }

    [JsonPropertyName("TotalNetToOrganizationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalNetToOrganizationAmt { get; set; }

    [JsonPropertyName("LicensedStatesCd")] public string LicensedStatesCd { get; set; }

    [JsonPropertyName("MailSolicitationsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MailSolicitationsInd { get; set; }

    [JsonPropertyName("EmailSolicitationsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string EmailSolicitationsInd { get; set; }

    [JsonPropertyName("PhoneSolicitationsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PhoneSolicitationsInd { get; set; }

    [JsonPropertyName("InPersonSolicitationsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InPersonSolicitationsInd { get; set; }

    [JsonPropertyName("SolicitationOfNonGovtGrantsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SolicitationOfNonGovtGrantsInd { get; set; }

    [JsonPropertyName("SolicitationOfGovtGrantsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SolicitationOfGovtGrantsInd { get; set; }

    [JsonPropertyName("SupplementalInformationDetail")]
    [JsonConverter(typeof(SingleOrArrayConverter<SupplementalInformationDetail>))]
    public List<SupplementalInformationDetail> SupplementalInformationDetail { get; set; }

    [JsonPropertyName("LicensedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LicensedInd { get; set; }

    [JsonPropertyName("LicenseSuspendedEtcInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LicenseSuspendedEtcInd { get; set; }

    [JsonPropertyName("SpecialFundraisingEventsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SpecialFundraisingEventsInd { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }

    [JsonPropertyName("PersonsWithBooksName")]
    public PersonsWithBooksName PersonsWithBooksName { get; set; }

    [JsonPropertyName("GamingOtherFacilityPct")]
    public string GamingOtherFacilityPct { get; set; }

    [JsonPropertyName("GamingManagerCompensationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GamingManagerCompensationAmt { get; set; }

    [JsonPropertyName("GamingManagerIsEmployeeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GamingManagerIsEmployeeInd { get; set; }

    [JsonPropertyName("GamingRevenueReceivedByOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GamingRevenueReceivedByOrgAmt { get; set; }

    [JsonPropertyName("GamingRevenueRtnBy3PrtyAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GamingRevenueRtnBy3PrtyAmt { get; set; }

    [JsonPropertyName("ThirdPartyBusinessName")]
    public ThirdPartyBusinessName ThirdPartyBusinessName { get; set; }

    [JsonPropertyName("ThirdPartyUSAddress")]
    public ThirdPartyUSAddress ThirdPartyUSAddress { get; set; }

    [JsonPropertyName("DistributedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DistributedAmt { get; set; }

    [JsonPropertyName("GamingManagerBusinessName")]
    public GamingManagerBusinessName GamingManagerBusinessName { get; set; }

    [JsonPropertyName("AllStatesCd")] public string AllStatesCd { get; set; }

    [JsonPropertyName("ThirdPartyPersonNm")]
    public string ThirdPartyPersonNm { get; set; }

    [JsonPropertyName("GamingManagerIsIndCntrctInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GamingManagerIsIndCntrctInd { get; set; }

    [JsonPropertyName("ExplanationIfNoTxt")]
    public string ExplanationIfNoTxt { get; set; }

    [JsonPropertyName("ExplanationIfYesTxt")]
    public string ExplanationIfYesTxt { get; set; }

    [JsonPropertyName("ThirdPartyForeignAddress")]
    public ThirdPartyForeignAddress ThirdPartyForeignAddress { get; set; }
}

public class IRS990ScheduleH
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("FinancialAssistancePolicyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FinancialAssistancePolicyInd { get; set; }

    [JsonPropertyName("WrittenPolicyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string WrittenPolicyInd { get; set; }

    [JsonPropertyName("AllHospitalsPolicyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AllHospitalsPolicyInd { get; set; }

    [JsonPropertyName("FPGReferenceFreeCareInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FPGReferenceFreeCareInd { get; set; }

    [JsonPropertyName("Percent200Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string Percent200Ind { get; set; }

    [JsonPropertyName("FPGReferenceDiscountedCareInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FPGReferenceDiscountedCareInd { get; set; }

    [JsonPropertyName("Percent400Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string Percent400Ind { get; set; }

    [JsonPropertyName("FreeCareMedicallyIndigentInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FreeCareMedicallyIndigentInd { get; set; }

    [JsonPropertyName("FinancialAssistanceBudgetInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FinancialAssistanceBudgetInd { get; set; }

    [JsonPropertyName("ExpensesExceedBudgetInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExpensesExceedBudgetInd { get; set; }

    [JsonPropertyName("UnableToProvideCareInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnableToProvideCareInd { get; set; }

    [JsonPropertyName("AnnualCommunityBnftReportInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AnnualCommunityBnftReportInd { get; set; }

    [JsonPropertyName("ReportPublicallyAvailableInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReportPublicallyAvailableInd { get; set; }

    [JsonPropertyName("FinancialAssistanceAtCostTyp")]
    public FinancialAssistanceAtCostTyp FinancialAssistanceAtCostTyp { get; set; }

    [JsonPropertyName("UnreimbursedMedicaidGrp"),  JsonConverter(typeof(SingleOrArrayConverter<UnreimbursedMedicaidGrp>))]
    public List<UnreimbursedMedicaidGrp> UnreimbursedMedicaidGrp { get; set; }

    [JsonPropertyName("UnreimbursedCostsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<UnreimbursedCostsGrp>))]
    public List<UnreimbursedCostsGrp> UnreimbursedCostsGrp { get; set; }

    [JsonPropertyName("TotalFinancialAssistanceTyp")]
    public TotalFinancialAssistanceTyp TotalFinancialAssistanceTyp { get; set; }

    [JsonPropertyName("CommunityHealthServicesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<CommunityHealthServicesGrp>))]
    public List<CommunityHealthServicesGrp> CommunityHealthServicesGrp { get; set; }

    [JsonPropertyName("HealthProfessionsEducationGrp"),  JsonConverter(typeof(SingleOrArrayConverter<HealthProfessionsEducationGrp>))]
    public List<HealthProfessionsEducationGrp> HealthProfessionsEducationGrp { get; set; }

    [JsonPropertyName("SubsidizedHealthServicesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<SubsidizedHealthServicesGrp>))]
    public List<SubsidizedHealthServicesGrp> SubsidizedHealthServicesGrp { get; set; }

    [JsonPropertyName("CashAndInKindContributionsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<CashAndInKindContributionsGrp>))]
    public List<CashAndInKindContributionsGrp> CashAndInKindContributionsGrp { get; set; }

    [JsonPropertyName("TotalOtherBenefitsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalOtherBenefitsGrp>))]
    public List<TotalOtherBenefitsGrp> TotalOtherBenefitsGrp { get; set; }

    [JsonPropertyName("TotalCommunityBenefitsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalCommunityBenefitsGrp>))]
    public List<TotalCommunityBenefitsGrp> TotalCommunityBenefitsGrp { get; set; }

    [JsonPropertyName("CoalitionBuildingGrp"),  JsonConverter(typeof(SingleOrArrayConverter<CoalitionBuildingGrp>))]
    public List<CoalitionBuildingGrp> CoalitionBuildingGrp { get; set; }

    [JsonPropertyName("TotalCommuntityBuildingActyGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalCommuntityBuildingActyGrp>))]
    public List<TotalCommuntityBuildingActyGrp> TotalCommuntityBuildingActyGrp { get; set; }

    [JsonPropertyName("BadDebtExpenseReportedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string BadDebtExpenseReportedInd { get; set; }

    [JsonPropertyName("BadDebtExpenseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BadDebtExpenseAmt { get; set; }

    [JsonPropertyName("BadDebtExpenseAttributableAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BadDebtExpenseAttributableAmt { get; set; }

    [JsonPropertyName("ReimbursedByMedicareAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReimbursedByMedicareAmt { get; set; }

    [JsonPropertyName("CostOfCareReimbursedByMedcrAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CostOfCareReimbursedByMedcrAmt { get; set; }

    [JsonPropertyName("MedicareSurplusOrShortfallAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string MedicareSurplusOrShortfallAmt { get; set; }

    [JsonPropertyName("CostingMethodologyUsedGrp"),  JsonConverter(typeof(SingleOrArrayConverter<CostingMethodologyUsedGrp>))]
    public List<CostingMethodologyUsedGrp> CostingMethodologyUsedGrp { get; set; }

    [JsonPropertyName("WrittenDebtCollectionPolicyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string WrittenDebtCollectionPolicyInd { get; set; }

    [JsonPropertyName("FinancialAssistancePrvsnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FinancialAssistancePrvsnInd { get; set; }

    [JsonPropertyName("HospitalFacilitiesCnt")]
    public string HospitalFacilitiesCnt { get; set; }

    [JsonPropertyName("HospitalFacilitiesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<HospitalFacilitiesGrp>))]
    public List<HospitalFacilitiesGrp> HospitalFacilitiesGrp { get; set; }

    [JsonPropertyName("HospitalFcltyPoliciesPrctcGrp"),  JsonConverter(typeof(SingleOrArrayConverter<HospitalFcltyPoliciesPrctcGrp>))]
    public List<HospitalFcltyPoliciesPrctcGrp> HospitalFcltyPoliciesPrctcGrp { get; set; }

    [JsonPropertyName("SupplementalInformationGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<SupplementalInformationGrp>))]
    public List<SupplementalInformationGrp> SupplementalInformationGrp { get; set; }

    [JsonPropertyName("FacilityNum")]
    public string FacilityNum { get; set; }

    [JsonPropertyName("OthHlthCareFcltsNotHospitalGrp"),  JsonConverter(typeof(SingleOrArrayConverter<OthHlthCareFcltsNotHospitalGrp>))]
    public List<OthHlthCareFcltsNotHospitalGrp> OthHlthCareFcltsNotHospitalGrp { get; set; }

    [JsonPropertyName("SupplementalInformationDetail")]
    [JsonConverter(typeof(SingleOrArrayConverter<SupplementalInformationDetail>))]
    public List<SupplementalInformationDetail> SupplementalInformationDetail { get; set; }

    [JsonPropertyName("Percent100Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string Percent100Ind { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("Percent200DInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Percent200DInd { get; set; }

    [JsonPropertyName("CommunitySupportGrp"),  JsonConverter(typeof(SingleOrArrayConverter<CommunitySupportGrp>))]
    public List<CommunitySupportGrp> CommunitySupportGrp { get; set; }

    [JsonPropertyName("Percent300Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string Percent300Ind { get; set; }

    [JsonPropertyName("FreeCareOthPercentageGrp"),  JsonConverter(typeof(SingleOrArrayConverter<FreeCareOthPercentageGrp>))]
    public List<FreeCareOthPercentageGrp> FreeCareOthPercentageGrp { get; set; }

    [JsonPropertyName("ResearchGrp"),  JsonConverter(typeof(SingleOrArrayConverter<ResearchGrp>))] 
    public List<ResearchGrp> ResearchGrp { get; set; }

    [JsonPropertyName("ManagementCoAndJntVenturesGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<ManagementCoAndJntVenturesGrp>))]
    public List<ManagementCoAndJntVenturesGrp> ManagementCoAndJntVenturesGrp { get; set; }

    [JsonPropertyName("DiscountedCareOthPercentageGrp"),  JsonConverter(typeof(SingleOrArrayConverter<DiscountedCareOthPercentageGrp>))]
    public List<DiscountedCareOthPercentageGrp> DiscountedCareOthPercentageGrp { get; set; }

    [JsonPropertyName("HealthImprovementAdvocacyGrp"),  JsonConverter(typeof(SingleOrArrayConverter<HealthImprovementAdvocacyGrp>))]
    public List<HealthImprovementAdvocacyGrp> HealthImprovementAdvocacyGrp { get; set; }

    [JsonPropertyName("WorkforceDevelopmentGrp"),  JsonConverter(typeof(SingleOrArrayConverter<WorkforceDevelopmentGrp>))]
    public List<WorkforceDevelopmentGrp> WorkforceDevelopmentGrp { get; set; }

    [JsonPropertyName("EconomicDevelopmentGrp"),  JsonConverter(typeof(SingleOrArrayConverter<EconomicDevelopmentGrp>))]
    public List<EconomicDevelopmentGrp> EconomicDevelopmentGrp { get; set; }

    [JsonPropertyName("Percent350Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string Percent350Ind { get; set; }

    [JsonPropertyName("OtherCommuntityBuildingActyGrp"),  JsonConverter(typeof(SingleOrArrayConverter<OtherCommuntityBuildingActyGrp>))]
    public List<OtherCommuntityBuildingActyGrp> OtherCommuntityBuildingActyGrp { get; set; }

    [JsonPropertyName("Percent150Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string Percent150Ind { get; set; }

    [JsonPropertyName("Percent250Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string Percent250Ind { get; set; }

    [JsonPropertyName("LeadershipDevelopmentGrp"),  JsonConverter(typeof(SingleOrArrayConverter<LeadershipDevelopmentGrp>))]
    public List<LeadershipDevelopmentGrp> LeadershipDevelopmentGrp { get; set; }

    [JsonPropertyName("PhysicalImprvAndHousingGrp"),  JsonConverter(typeof(SingleOrArrayConverter<PhysicalImprvAndHousingGrp>))]
    public List<PhysicalImprvAndHousingGrp> PhysicalImprvAndHousingGrp { get; set; }

    [JsonPropertyName("EnvironmentalImprovementsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<EnvironmentalImprovementsGrp>))]
    public List<EnvironmentalImprovementsGrp> EnvironmentalImprovementsGrp { get; set; }

    [JsonPropertyName("IndivHospitalTailoredPolicyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string IndivHospitalTailoredPolicyInd { get; set; }

    [JsonPropertyName("MostHospitalsPolicyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MostHospitalsPolicyInd { get; set; }
}

public class IRS990ScheduleI
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("GrantRecordsMaintainedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantRecordsMaintainedInd { get; set; }

    [JsonPropertyName("RecipientTable")]
    [JsonConverter(typeof(SingleOrArrayConverter<RecipientTable>))]
    public List<RecipientTable> RecipientTable { get; set; }

    [JsonPropertyName("Total501c3OrgCnt")] public string Total501c3OrgCnt { get; set; }

    [JsonPropertyName("TotalOtherOrgCnt")] public string TotalOtherOrgCnt { get; set; }

    [JsonPropertyName("GrantsOtherAsstToIndivInUSGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<GrantsOtherAsstToIndivInUSGrp>))]
    public List<GrantsOtherAsstToIndivInUSGrp> GrantsOtherAsstToIndivInUSGrp { get; set; }

    [JsonPropertyName("SupplementalInformationDetail")]
    [JsonConverter(typeof(SingleOrArrayConverter<SupplementalInformationDetail>))]
    public List<SupplementalInformationDetail> SupplementalInformationDetail { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }
}

public class IRS990ScheduleJ
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("WrittenEmploymentContractInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string WrittenEmploymentContractInd { get; set; }

    [JsonPropertyName("BoardOrCommitteeApprovalInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string BoardOrCommitteeApprovalInd { get; set; }

    [JsonPropertyName("SeverancePaymentInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SeverancePaymentInd { get; set; }

    [JsonPropertyName("SupplementalNonqualRtrPlanInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SupplementalNonqualRtrPlanInd { get; set; }

    [JsonPropertyName("EquityBasedCompArrngmInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string EquityBasedCompArrngmInd { get; set; }

    [JsonPropertyName("CompBasedOnRevenueOfFlngOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompBasedOnRevenueOfFlngOrgInd { get; set; }

    [JsonPropertyName("CompBsdOnRevRelatedOrgsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompBsdOnRevRelatedOrgsInd { get; set; }

    [JsonPropertyName("CompBsdNetEarnsFlngOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompBsdNetEarnsFlngOrgInd { get; set; }

    [JsonPropertyName("CompBsdNetEarnsRltdOrgsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompBsdNetEarnsRltdOrgsInd { get; set; }

    [JsonPropertyName("AnyNonFixedPaymentsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AnyNonFixedPaymentsInd { get; set; }

    [JsonPropertyName("InitialContractExceptionInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InitialContractExceptionInd { get; set; }

    [JsonPropertyName("RebuttablePresumptionProcInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string RebuttablePresumptionProcInd { get; set; }

    [JsonPropertyName("RltdOrgOfficerTrstKeyEmplGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<RltdOrgOfficerTrstKeyEmplGrp>))]
    public List<RltdOrgOfficerTrstKeyEmplGrp> RltdOrgOfficerTrstKeyEmplGrp { get; set; }

    [JsonPropertyName("SubstantiationRequiredInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SubstantiationRequiredInd { get; set; }

    [JsonPropertyName("SupplementalInformationDetail")]
    [JsonConverter(typeof(SingleOrArrayConverter<SupplementalInformationDetail>))]
    public List<SupplementalInformationDetail> SupplementalInformationDetail { get; set; }

    [JsonPropertyName("CompensationCommitteeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompensationCommitteeInd { get; set; }

    [JsonPropertyName("CompensationSurveyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompensationSurveyInd { get; set; }

    [JsonPropertyName("IndependentConsultantInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string IndependentConsultantInd { get; set; }

    [JsonPropertyName("Form990OfOtherOrganizationsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form990OfOtherOrganizationsInd { get; set; }

    [JsonPropertyName("ClubDuesOrFeesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ClubDuesOrFeesInd { get; set; }

    [JsonPropertyName("WrittenPolicyRefTAndEExpnssInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string WrittenPolicyRefTAndEExpnssInd { get; set; }

    [JsonPropertyName("TravelForCompanionsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TravelForCompanionsInd { get; set; }

    [JsonPropertyName("FirstClassOrCharterTravelInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FirstClassOrCharterTravelInd { get; set; }

    [JsonPropertyName("IdemnificationGrossUpPmtsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string IdemnificationGrossUpPmtsInd { get; set; }

    [JsonPropertyName("DiscretionarySpendingAcctInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DiscretionarySpendingAcctInd { get; set; }

    [JsonPropertyName("HousingAllowanceOrResidenceInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string HousingAllowanceOrResidenceInd { get; set; }

    [JsonPropertyName("PersonalServicesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PersonalServicesInd { get; set; }

    [JsonPropertyName("PaymentsForUseOfResidenceInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PaymentsForUseOfResidenceInd { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }
}

public class IRS990ScheduleK
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("TaxExemptBondsIssuesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TaxExemptBondsIssuesGrp>))]
    public List<TaxExemptBondsIssuesGrp> TaxExemptBondsIssuesGrp { get; set; }

    [JsonPropertyName("TaxExemptBondsProceedsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TaxExemptBondsProceedsGrp>))]
    public List<TaxExemptBondsProceedsGrp> TaxExemptBondsProceedsGrp { get; set; }

    [JsonPropertyName("TaxExemptBondsPrivateBusUseGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TaxExemptBondsPrivateBusUseGrp>))]
    public List<TaxExemptBondsPrivateBusUseGrp> TaxExemptBondsPrivateBusUseGrp { get; set; }

    [JsonPropertyName("TaxExemptBondsArbitrageGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TaxExemptBondsArbitrageGrp>))]
    public List<TaxExemptBondsArbitrageGrp> TaxExemptBondsArbitrageGrp { get; set; }
}

public class IRS990ScheduleL
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("LoansBtwnOrgInterestedPrsnGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<LoansBtwnOrgInterestedPrsnGrp>))]
    public List<LoansBtwnOrgInterestedPrsnGrp> LoansBtwnOrgInterestedPrsnGrp { get; set; }

    [JsonPropertyName("TotalBalanceDueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalBalanceDueAmt { get; set; }

    [JsonPropertyName("BusTrInvolveInterestedPrsnGrp"),  JsonConverter(typeof(SingleOrArrayConverter<BusTrInvolveInterestedPrsnGrp>))]
    public List<BusTrInvolveInterestedPrsnGrp> BusTrInvolveInterestedPrsnGrp { get; set; }

    [JsonPropertyName("SupplementalInformationDetail")]
    [JsonConverter(typeof(SingleOrArrayConverter<SupplementalInformationDetail>))]
    public List<SupplementalInformationDetail> SupplementalInformationDetail { get; set; }

    [JsonPropertyName("DisqualifiedPersonExBnftTrGrp"),  JsonConverter(typeof(SingleOrArrayConverter<DisqualifiedPersonExBnftTrGrp>))]
    public List<DisqualifiedPersonExBnftTrGrp> DisqualifiedPersonExBnftTrGrp { get; set; }

    [JsonPropertyName("TaxImposedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxImposedAmt { get; set; }

    [JsonPropertyName("TaxReimbursedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxReimbursedAmt { get; set; }

    [JsonPropertyName("GrntAsstBnftInterestedPrsnGrp"),  JsonConverter(typeof(SingleOrArrayConverter<GrntAsstBnftInterestedPrsnGrp>))]
    public List<GrntAsstBnftInterestedPrsnGrp> GrntAsstBnftInterestedPrsnGrp { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }
}

public class IRS990ScheduleM
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("SecuritiesPubliclyTradedGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> SecuritiesPubliclyTradedGrp { get; set; }

    [JsonPropertyName("AnyPropertyThatMustBeHeldInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AnyPropertyThatMustBeHeldInd { get; set; }

    [JsonPropertyName("ReviewProcessUnusualNCGiftsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReviewProcessUnusualNCGiftsInd { get; set; }

    [JsonPropertyName("ThirdPartiesUsedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ThirdPartiesUsedInd { get; set; }

    [JsonPropertyName("OtherNonCashContriTableGrp"),  JsonConverter(typeof(SingleOrArrayConverter<OtherNonCashContriTableGrp>))]
    public List<OtherNonCashContriTableGrp> OtherNonCashContriTableGrp { get; set; }

    [JsonPropertyName("ClothingAndHouseholdGoodsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> ClothingAndHouseholdGoodsGrp { get; set; }

    [JsonPropertyName("WorksOfArtGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> WorksOfArtGrp { get; set; }

    [JsonPropertyName("BooksAndPublicationsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> BooksAndPublicationsGrp { get; set; }

    [JsonPropertyName("CollectiblesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))] 
    public List<dynamic> CollectiblesGrp { get; set; }

    [JsonPropertyName("FoodInventoryGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))] 
    public List<dynamic>  FoodInventoryGrp { get; set; }

    [JsonPropertyName("Form8283ReceivedCnt")]
    public string Form8283ReceivedCnt { get; set; }

    [JsonPropertyName("SupplementalInformationDetail"),
     JsonConverter(typeof(SingleOrArrayConverter<SupplementalInformationDetail>))]
    public List<SupplementalInformationDetail> SupplementalInformationDetail { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("QualifiedContribOtherGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> QualifiedContribOtherGrp { get; set; }

    [JsonPropertyName("ArtHistoricalTreasuresGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> ArtHistoricalTreasuresGrp { get; set; }

    [JsonPropertyName("ArtFractionalInterestGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> ArtFractionalInterestGrp { get; set; }

    [JsonPropertyName("CarsAndOtherVehiclesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> CarsAndOtherVehiclesGrp { get; set; }

    [JsonPropertyName("BoatsAndPlanesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> BoatsAndPlanesGrp { get; set; }

    [JsonPropertyName("IntellectualPropertyGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> IntellectualPropertyGrp { get; set; }

    [JsonPropertyName("SecuritiesCloselyHeldStockGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> SecuritiesCloselyHeldStockGrp { get; set; }

    [JsonPropertyName("SecurPrtnrshpTrustIntrstsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> SecurPrtnrshpTrustIntrstsGrp { get; set; }

    [JsonPropertyName("SecuritiesMiscellaneousGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> SecuritiesMiscellaneousGrp { get; set; }

    [JsonPropertyName("QualifiedContribHistStructGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> QualifiedContribHistStructGrp { get; set; }

    [JsonPropertyName("RealEstateResidentialGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> RealEstateResidentialGrp { get; set; }

    [JsonPropertyName("RealEstateCommercialGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> RealEstateCommercialGrp { get; set; }

    [JsonPropertyName("RealEstateOtherGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> RealEstateOtherGrp { get; set; }

    [JsonPropertyName("DrugsAndMedicalSuppliesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<DrugsAndMedicalSuppliesGrp>))]
    public List<DrugsAndMedicalSuppliesGrp> DrugsAndMedicalSuppliesGrp { get; set; }

    [JsonPropertyName("TaxidermyGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))] 
    public List<dynamic> TaxidermyGrp { get; set; }

    [JsonPropertyName("HistoricalArtifactsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> HistoricalArtifactsGrp { get; set; }

    [JsonPropertyName("ScientificSpecimensGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> ScientificSpecimensGrp { get; set; }

    [JsonPropertyName("ArchaeologicalArtifactsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
    public List<dynamic> ArchaeologicalArtifactsGrp { get; set; }

    [JsonPropertyName("@documentName")] 
    public string DocumentName { get; set; }
}

public class IRS990ScheduleN
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("DispositionOfAssetsDetail")]
    [JsonConverter(typeof(SingleOrArrayConverter<DispositionOfAssetsDetail>))]
    public List<DispositionOfAssetsDetail> DispositionOfAssetsDetail { get; set; }

    [JsonPropertyName("DirectorOfSuccessor2Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectorOfSuccessor2Ind { get; set; }

    [JsonPropertyName("EmployeeOfSuccessor2Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string EmployeeOfSuccessor2Ind { get; set; }

    [JsonPropertyName("OwnerOfSuccessor2Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string OwnerOfSuccessor2Ind { get; set; }

    [JsonPropertyName("ReceiveCompensation2Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReceiveCompensation2Ind { get; set; }

    [JsonPropertyName("LiquidationOfAssetsTableGrp"),  JsonConverter(typeof(SingleOrArrayConverter<LiquidationOfAssetsTableGrp>))]
    public List<LiquidationOfAssetsTableGrp> LiquidationOfAssetsTableGrp { get; set; }

    [JsonPropertyName("DirectorOfSuccessorInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectorOfSuccessorInd { get; set; }

    [JsonPropertyName("EmployeeOfSuccessorInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string EmployeeOfSuccessorInd { get; set; }

    [JsonPropertyName("OwnerOfSuccessorInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OwnerOfSuccessorInd { get; set; }

    [JsonPropertyName("ReceiveCompensationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReceiveCompensationInd { get; set; }

    [JsonPropertyName("AssetsDistributedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AssetsDistributedInd { get; set; }

    [JsonPropertyName("RequiredToNotifyAGInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string RequiredToNotifyAGInd { get; set; }

    [JsonPropertyName("AttorneyGeneralNotifiedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AttorneyGeneralNotifiedInd { get; set; }

    [JsonPropertyName("LiabilitiesPaidInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LiabilitiesPaidInd { get; set; }

    [JsonPropertyName("BondsOutstandingInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string BondsOutstandingInd { get; set; }

    [JsonPropertyName("BondLiabilitiesDischargedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string BondLiabilitiesDischargedInd { get; set; }

    [JsonPropertyName("SupplementalInformationDetail"),
     JsonConverter(typeof(SingleOrArrayConverter<SupplementalInformationDetail>))]
    public List<SupplementalInformationDetail> SupplementalInformationDetail { get; set; }
}

public class IRS990ScheduleO
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("SupplementalInformationDetail"),
     JsonConverter(typeof(SingleOrArrayConverter<SupplementalInformationDetail>))]
    public List<SupplementalInformationDetail> SupplementalInformationDetail { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }
}

public class IRS990ScheduleR
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("IdRelatedTaxExemptOrgGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<IdRelatedTaxExemptOrgGrp>))]
    public List<IdRelatedTaxExemptOrgGrp> IdRelatedTaxExemptOrgGrp { get; set; }

    [JsonPropertyName("ReceiptOfIntAnntsRntsRyltsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReceiptOfIntAnntsRntsRyltsInd { get; set; }

    [JsonPropertyName("GiftGrntOrCapContriToOthOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GiftGrntOrCapContriToOthOrgInd { get; set; }

    [JsonPropertyName("GiftGrntCapContriFromOthOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GiftGrntCapContriFromOthOrgInd { get; set; }

    [JsonPropertyName("LoansOrGuaranteesToOtherOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LoansOrGuaranteesToOtherOrgInd { get; set; }

    [JsonPropertyName("LoansOrGuaranteesFromOthOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LoansOrGuaranteesFromOthOrgInd { get; set; }

    [JsonPropertyName("DivRelatedOrganizationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DivRelatedOrganizationInd { get; set; }

    [JsonPropertyName("AssetSaleToOtherOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AssetSaleToOtherOrgInd { get; set; }

    [JsonPropertyName("AssetPurchaseFromOtherOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AssetPurchaseFromOtherOrgInd { get; set; }

    [JsonPropertyName("AssetExchangeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AssetExchangeInd { get; set; }

    [JsonPropertyName("RentalOfFacilitiesToOthOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string RentalOfFacilitiesToOthOrgInd { get; set; }

    [JsonPropertyName("RentalOfFcltsFromOthOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string RentalOfFcltsFromOthOrgInd { get; set; }

    [JsonPropertyName("PerformOfServicesForOthOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PerformOfServicesForOthOrgInd { get; set; }

    [JsonPropertyName("PerformOfServicesByOtherOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PerformOfServicesByOtherOrgInd { get; set; }

    [JsonPropertyName("SharingOfFacilitiesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SharingOfFacilitiesInd { get; set; }

    [JsonPropertyName("PaidEmployeesSharingInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PaidEmployeesSharingInd { get; set; }

    [JsonPropertyName("ReimbursementPaidToOtherOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReimbursementPaidToOtherOrgInd { get; set; }

    [JsonPropertyName("ReimbursementPaidByOtherOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReimbursementPaidByOtherOrgInd { get; set; }

    [JsonPropertyName("TransferToOtherOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TransferToOtherOrgInd { get; set; }

    [JsonPropertyName("TransferFromOtherOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TransferFromOtherOrgInd { get; set; }

    [JsonPropertyName("TransactionsRelatedOrgGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<TransactionsRelatedOrgGrp>))]
    public List<TransactionsRelatedOrgGrp> TransactionsRelatedOrgGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("IdRelatedOrgTxblCorpTrGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<IdRelatedOrgTxblCorpTrGrp>))]
    public List<IdRelatedOrgTxblCorpTrGrp> IdRelatedOrgTxblCorpTrGrp { get; set; }

    [JsonPropertyName("IdDisregardedEntitiesGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<IdDisregardedEntitiesGrp>))]
    public List<IdDisregardedEntitiesGrp> IdDisregardedEntitiesGrp { get; set; }

    [JsonPropertyName("IdRelatedOrgTxblPartnershipGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<IdRelatedOrgTxblPartnershipGrp>))]
    public List<IdRelatedOrgTxblPartnershipGrp> IdRelatedOrgTxblPartnershipGrp { get; set; }

    [JsonPropertyName("SupplementalInformationDetail"),
     JsonConverter(typeof(SingleOrArrayConverter<SupplementalInformationDetail>))]
    public List<SupplementalInformationDetail> SupplementalInformationDetail { get; set; }

    [JsonPropertyName("UnrelatedOrgTxblPartnershipGrp"), 
     JsonConverter(typeof(SingleOrArrayConverter<UnrelatedOrgTxblPartnershipGrp>))]
    public List<UnrelatedOrgTxblPartnershipGrp> UnrelatedOrgTxblPartnershipGrp { get; set; }

    [JsonPropertyName("@documentName")]
    public string DocumentName { get; set; }
}

public class IssuerName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }
}

public class LandAndBuildingsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class LandBldgEquipBasisNetGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class LandEtcGrp
{
    [JsonPropertyName("CategoryOrItemTxt")]
    public string CategoryOrItemTxt { get; set; }

    [JsonPropertyName("CostOrOtherBasisAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CostOrOtherBasisAmt { get; set; }

    [JsonPropertyName("AccumulatedDepreciationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AccumulatedDepreciationAmt { get; set; }

    [JsonPropertyName("BookValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BookValueAmt { get; set; }

    [JsonPropertyName("EOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYFMVAmt { get; set; }
}

public class LandEtcSchedule2
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("LandEtcGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<LandEtcGrp>))]
    public List<LandEtcGrp> LandEtcGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }
}

public class LargestSupportFromEOGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class LeadershipDevelopmentGrp
{
    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }
}

public class LeaseholdImprovementsGrp
{
    [JsonPropertyName("OtherCostOrOtherBasisAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherCostOrOtherBasisAmt { get; set; }

    [JsonPropertyName("DepreciationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DepreciationAmt { get; set; }

    [JsonPropertyName("BookValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BookValueAmt { get; set; }

    [JsonPropertyName("InvestmentCostOrOtherBasisAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvestmentCostOrOtherBasisAmt { get; set; }
}

public class LegalFeesGrp
{
    [JsonPropertyName("LegalFeesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LegalFeesAmt { get; set; }

    [JsonPropertyName("NetInvestmentIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetInvestmentIncomeAmt { get; set; }

    [JsonPropertyName("AdjustedNetIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdjustedNetIncomeAmt { get; set; }

    [JsonPropertyName("DisbursementsCharitablePrpsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DisbursementsCharitablePrpsAmt { get; set; }

    [JsonPropertyName("CategoryTxt")] public string CategoryTxt { get; set; }
}

public class LegalFeesSchedule
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("LegalFeesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<LegalFeesGrp>))] 
    public List<LegalFeesGrp> LegalFeesGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }
}

public class LenderNameGrp
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("PersonNm")] public string PersonNm { get; set; }
}

public class LessCostOthBasisSalesExpnssGrp
{
    [JsonPropertyName("SecuritiesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SecuritiesAmt { get; set; }

    [JsonPropertyName("OtherAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherAmt { get; set; }
}

public class LessorAdjNetIncmMinInvstRetGrp
{
    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year3Amt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class LessRentalExpensesGrp
{
    [JsonPropertyName("RealAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RealAmt { get; set; }

    [JsonPropertyName("PersonalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PersonalAmt { get; set; }
}

public class LiquidationExplanationStmt
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("ExplanationTxt")] public string ExplanationTxt { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class LiquidationOfAssetsDetail
{
    [JsonPropertyName("AssetsDistriOrExpnssPaidDesc")]
    public string AssetsDistriOrExpnssPaidDesc { get; set; }

    [JsonPropertyName("DistributionDt")] public string DistributionDt { get; set; }
}

public class LiquidationOfAssetsTableGrp
{
    [JsonPropertyName("LiquidationOfAssetsDetail")]
    [JsonConverter(typeof(SingleOrArrayConverter<LiquidationOfAssetsDetail>))]
    public List<LiquidationOfAssetsDetail> LiquidationOfAssetsDetail { get; set; }
}

public class LoansBtwnOrgInterestedPrsnGrp
{
    [JsonPropertyName("PersonNm")] public string PersonNm { get; set; }

    [JsonPropertyName("RelationshipWithOrgTxt")]
    public string RelationshipWithOrgTxt { get; set; }

    [JsonPropertyName("LoanPurposeTxt")] public string LoanPurposeTxt { get; set; }

    [JsonPropertyName("LoanToOrganizationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LoanToOrganizationInd { get; set; }

    [JsonPropertyName("OriginalPrincipalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OriginalPrincipalAmt { get; set; }

    [JsonPropertyName("BalanceDueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BalanceDueAmt { get; set; }

    [JsonPropertyName("DefaultInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DefaultInd { get; set; }

    [JsonPropertyName("BoardOrCommitteeApprovalInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string BoardOrCommitteeApprovalInd { get; set; }

    [JsonPropertyName("WrittenAgreementInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string WrittenAgreementInd { get; set; }
}

public class LoansFromOfficerGrp
{
    [JsonPropertyName("LenderPersonNm")] public string LenderPersonNm { get; set; }

    [JsonPropertyName("LoanOriginalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LoanOriginalAmt { get; set; }

    [JsonPropertyName("BalanceDueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BalanceDueAmt { get; set; }

    [JsonPropertyName("InterestRt")] public string InterestRt { get; set; }

    [JsonPropertyName("LoanPurposeTxt")] public string LoanPurposeTxt { get; set; }

    [JsonPropertyName("ConsiderationFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ConsiderationFMVAmt { get; set; }
}

public class LoansFromOfficersDirectorsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class LoansFromOfficersSchedule
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("LoansFromOfficerGrp"),  JsonConverter(typeof(SingleOrArrayConverter<LoansFromOfficerGrp>))]
    public List<LoansFromOfficerGrp> LoansFromOfficerGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("@documentName")] public string DocumentName { get; set; }
}

public class LobbyingNontaxableAmountGrp
{
    [JsonPropertyName("FilingOrganizationsTotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FilingOrganizationsTotalAmt { get; set; }
}

public class LocationOfBooksForeignAddress
{
    [JsonPropertyName("AddressLine1Txt")] public string AddressLine1Txt { get; set; }

    [JsonPropertyName("CityNm")] public string CityNm { get; set; }

    [JsonPropertyName("ProvinceOrStateNm")]
    public string ProvinceOrStateNm { get; set; }

    [JsonPropertyName("CountryCd")] public string CountryCd { get; set; }

    [JsonPropertyName("ForeignPostalCd")] public string ForeignPostalCd { get; set; }
}

public class LocationOfBooksUSAddress
{
    [JsonPropertyName("AddressLine1Txt")] public string AddressLine1Txt { get; set; }

    [JsonPropertyName("CityNm")] public string CityNm { get; set; }

    [JsonPropertyName("StateAbbreviationCd")]
    public string StateAbbreviationCd { get; set; }

    [JsonPropertyName("ZIPCd")] public string ZIPCd { get; set; }

    [JsonPropertyName("AddressLine2Txt")] public string AddressLine2Txt { get; set; }
}

public class ManagementCoAndJntVenturesGrp
{
    [JsonPropertyName("EntityName")] public EntityName EntityName { get; set; }

    [JsonPropertyName("PrimaryActivitiesTxt")]
    public string PrimaryActivitiesTxt { get; set; }

    [JsonPropertyName("OrgProfitOrOwnershipPct")]
    public string OrgProfitOrOwnershipPct { get; set; }

    [JsonPropertyName("OfcrEtcProfitOrOwnershipPct")]
    public string OfcrEtcProfitOrOwnershipPct { get; set; }

    [JsonPropertyName("PhysiciansProfitOrOwnershipPct")]
    public string PhysiciansProfitOrOwnershipPct { get; set; }
}


public class MinimumAssetAmountGrp
{
    [JsonPropertyName("AverageMonthlyFMVOfSecGrp"),  JsonConverter(typeof(SingleOrArrayConverter<AverageMonthlyFMVOfSecGrp>))]
    public List<AverageMonthlyFMVOfSecGrp> AverageMonthlyFMVOfSecGrp { get; set; }

    [JsonPropertyName("AverageMonthlyCashBalancesGrp"),  JsonConverter(typeof(SingleOrArrayConverter<AverageMonthlyCashBalancesGrp>))]
    public List<AverageMonthlyCashBalancesGrp> AverageMonthlyCashBalancesGrp { get; set; }

    [JsonPropertyName("FMVOtherNonExemptUseAssetGrp"),  JsonConverter(typeof(SingleOrArrayConverter<FMVOtherNonExemptUseAssetGrp>))]
    public List<FMVOtherNonExemptUseAssetGrp> FMVOtherNonExemptUseAssetGrp { get; set; }

    [JsonPropertyName("TotalFMVOfNonExemptUseAssetGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalFMVOfNonExemptUseAssetGrp>))]
    public List<TotalFMVOfNonExemptUseAssetGrp> TotalFMVOfNonExemptUseAssetGrp { get; set; }

    [JsonPropertyName("DiscountClaimedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DiscountClaimedAmt { get; set; }

    [JsonPropertyName("AcquisitionIndebtednessGrp"),  JsonConverter(typeof(SingleOrArrayConverter<AcquisitionIndebtednessGrp>))]
    public List<AcquisitionIndebtednessGrp> AcquisitionIndebtednessGrp { get; set; }

    [JsonPropertyName("AdjustedFMVLessIndebtednessGrp"),  JsonConverter(typeof(SingleOrArrayConverter<AdjustedFMVLessIndebtednessGrp>))]
    public List<AdjustedFMVLessIndebtednessGrp> AdjustedFMVLessIndebtednessGrp { get; set; }

    [JsonPropertyName("CashDeemedCharitableGrp"),  JsonConverter(typeof(SingleOrArrayConverter<CashDeemedCharitableGrp>))]
    public List<CashDeemedCharitableGrp> CashDeemedCharitableGrp { get; set; }

    [JsonPropertyName("NetVlNonExemptUseAssetsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<NetVlNonExemptUseAssetsGrp>))]
    public List<NetVlNonExemptUseAssetsGrp> NetVlNonExemptUseAssetsGrp { get; set; }

    [JsonPropertyName("PctOfNetVlNonExemptUseAstGrp"),  JsonConverter(typeof(SingleOrArrayConverter<PctOfNetVlNonExemptUseAstGrp>))]
    public List<PctOfNetVlNonExemptUseAstGrp> PctOfNetVlNonExemptUseAstGrp { get; set; }

    [JsonPropertyName("RecoveriesPYDistriMinAssetGrp"),  JsonConverter(typeof(SingleOrArrayConverter<RecoveriesPYDistriMinAssetGrp>))]
    public List<RecoveriesPYDistriMinAssetGrp> RecoveriesPYDistriMinAssetGrp { get; set; }

    [JsonPropertyName("TotalMinimumAssetGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalMinimumAssetGrp>))]
    public List<TotalMinimumAssetGrp> TotalMinimumAssetGrp { get; set; }
}

public class MinimumInvestmentReturnGrp
{
    [JsonPropertyName("AverageMonthlyFMVOfSecAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AverageMonthlyFMVOfSecAmt { get; set; }

    [JsonPropertyName("AverageMonthlyCashBalancesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AverageMonthlyCashBalancesAmt { get; set; }

    [JsonPropertyName("FMVAllOtherNoncharitableAstAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FMVAllOtherNoncharitableAstAmt { get; set; }

    [JsonPropertyName("TotalFMVOfUnusedAssetsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalFMVOfUnusedAssetsAmt { get; set; }

    [JsonPropertyName("AdjustedTotalFMVOfUnusedAstAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdjustedTotalFMVOfUnusedAstAmt { get; set; }

    [JsonPropertyName("CashDeemedCharitableAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CashDeemedCharitableAmt { get; set; }

    [JsonPropertyName("NetVlNoncharitableAssetsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetVlNoncharitableAssetsAmt { get; set; }

    [JsonPropertyName("MinimumInvestmentReturnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string MinimumInvestmentReturnAmt { get; set; }

    [JsonPropertyName("AcquisitionIndebtednessAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AcquisitionIndebtednessAmt { get; set; }

    [JsonPropertyName("ReductionClaimedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReductionClaimedAmt { get; set; }
}

public class MiscellaneousRevenueGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrelatedBusinessRevenueAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExclusionAmt { get; set; }
}

public class MortgagesAndNotesPayableSch
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("MortgageAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string MortgageAmt { get; set; }

    [JsonPropertyName("NotePayableGrp"),  JsonConverter(typeof(SingleOrArrayConverter<NotePayableGrp>))] 
    public List<NotePayableGrp> NotePayableGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class MortgNotesPyblScrdInvstPropGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class NameOfInterested
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }
}

public class NetAssetsOrFundBalancesGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class NetGainOrLossInvestmentsGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExclusionAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrelatedBusinessRevenueAmt { get; set; }
}


public class NetIncmFromFundraisingEvtGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExclusionAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrelatedBusinessRevenueAmt { get; set; }
}

public class NetIncomeFromGamingGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExclusionAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrelatedBusinessRevenueAmt { get; set; }
}

public class NetIncomeFromOtherUBIGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }
}

public class NetIncomeOrLossGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrelatedBusinessRevenueAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExclusionAmt { get; set; }
}

public class NetRentalIncomeOrLossGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExclusionAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrelatedBusinessRevenueAmt { get; set; }
}

public class NetSTCapitalGainAdjNetIncmGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class NetVlNonExemptUseAssetsGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class NoDonorRestrictionNetAssetsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class NonCashPropertyContributionGrp
{
    [JsonPropertyName("ContributorNum")] public string ContributorNum { get; set; }

    [JsonPropertyName("NoncashPropertyDesc")]
    public string NoncashPropertyDesc { get; set; }

    [JsonPropertyName("FairMarketValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FairMarketValueAmt { get; set; }

    [JsonPropertyName("ReceivedDt")] public string ReceivedDt { get; set; }
}

public class NoncharitableExemptOrgName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }
}

public class NotePayableGrp
{
    [JsonPropertyName("LenderNameGrp"),  JsonConverter(typeof(SingleOrArrayConverter<LenderNameGrp>))]
    public List<LenderNameGrp> LenderNameGrp { get; set; }

    [JsonPropertyName("InsiderRelationshipTxt")]
    public string InsiderRelationshipTxt { get; set; }

    [JsonPropertyName("BalanceDueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BalanceDueAmt { get; set; }

    [JsonPropertyName("LoanPurposeTxt")] public string LoanPurposeTxt { get; set; }

    [JsonPropertyName("LenderConsiderationDesc")]
    public string LenderConsiderationDesc { get; set; }

    [JsonPropertyName("ConsiderationFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ConsiderationFMVAmt { get; set; }

    [JsonPropertyName("LoanOriginalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LoanOriginalAmt { get; set; }

    [JsonPropertyName("NoteDt")] public string NoteDt { get; set; }

    [JsonPropertyName("LoanMaturityDt")] public string LoanMaturityDt { get; set; }

    [JsonPropertyName("RepaymentTermsTxt")]
    public string RepaymentTermsTxt { get; set; }

    [JsonPropertyName("InterestRt")] public string InterestRt { get; set; }

    [JsonPropertyName("SecurityProvidedBorrowerTxt")]
    public string SecurityProvidedBorrowerTxt { get; set; }
}

public class OccupancyGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class OfficeExpensesGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class OfficerDirectorTrusteeEmplGrp
{
    [JsonPropertyName("PersonNm")] public string PersonNm { get; set; }

    [JsonPropertyName("TitleTxt")] public string TitleTxt { get; set; }

    [JsonPropertyName("AverageHrsPerWkDevotedToPosRt")]
    public string AverageHrsPerWkDevotedToPosRt { get; set; }

    [JsonPropertyName("CompensationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompensationAmt { get; set; }

    [JsonPropertyName("EmployeeBenefitProgramAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EmployeeBenefitProgramAmt { get; set; }

    [JsonPropertyName("ExpenseAccountOtherAllwncAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExpenseAccountOtherAllwncAmt { get; set; }
}

public class OfficerDirTrstKeyEmplGrp
{
    [JsonPropertyName("PersonNm")] public string PersonNm { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("TitleTxt")] public string TitleTxt { get; set; }

    [JsonPropertyName("AverageHrsPerWkDevotedToPosRt")]
    public string AverageHrsPerWkDevotedToPosRt { get; set; }

    [JsonPropertyName("CompensationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompensationAmt { get; set; }

    [JsonPropertyName("EmployeeBenefitProgramAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EmployeeBenefitProgramAmt { get; set; }

    [JsonPropertyName("ExpenseAccountOtherAllwncAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExpenseAccountOtherAllwncAmt { get; set; }
}

public class OfficerDirTrstKeyEmplInfoGrp
{
    [JsonPropertyName("OfficerDirTrstKeyEmplGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<OfficerDirTrstKeyEmplGrp>))]

    public List<OfficerDirTrstKeyEmplGrp> OfficerDirTrstKeyEmplGrp { get; set; }

    [JsonPropertyName("CompensationHighestPaidEmplGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<CompensationHighestPaidEmplGrp>))]
    public List<CompensationHighestPaidEmplGrp> CompensationHighestPaidEmplGrp { get; set; }

    [JsonPropertyName("OtherEmployeePaidOver50kCnt")]
    public string OtherEmployeePaidOver50kCnt { get; set; }

    [JsonPropertyName("ContractorPaidOver50kCnt")]
    public string ContractorPaidOver50kCnt { get; set; }

    [JsonPropertyName("CompOfHghstPdEmplOrNONETxt")]
    public string CompOfHghstPdEmplOrNONETxt { get; set; }

    [JsonPropertyName("CompOfHghstPdCntrctOrNONETxt")]
    public string CompOfHghstPdCntrctOrNONETxt { get; set; }

    [JsonPropertyName("CompensationOfHghstPdCntrctGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<CompensationOfHghstPdCntrctGrp>))]
    public List<CompensationOfHghstPdCntrctGrp> CompensationOfHghstPdCntrctGrp { get; set; }
}

public class OfficerOtherRcvblGrp
{
    [JsonPropertyName("BorrowerPersonNm")] public string BorrowerPersonNm { get; set; }

    [JsonPropertyName("LoanOriginalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LoanOriginalAmt { get; set; }

    [JsonPropertyName("BalanceDueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BalanceDueAmt { get; set; }

    [JsonPropertyName("BorrowerTitleTxt")] public string BorrowerTitleTxt { get; set; }

    [JsonPropertyName("NoteDt")] public string NoteDt { get; set; }

    [JsonPropertyName("ConsiderationFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ConsiderationFMVAmt { get; set; }

    [JsonPropertyName("LoanMaturityDt")] public string LoanMaturityDt { get; set; }

    [JsonPropertyName("RepaymentTermsTxt")]
    public string RepaymentTermsTxt { get; set; }

    [JsonPropertyName("InterestRt")] public string InterestRt { get; set; }

    [JsonPropertyName("LoanPurposeTxt")] public string LoanPurposeTxt { get; set; }
}

public class Organization501c3Name
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }
}

public class OrganizationBusinessName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }
}


public class OtherAssetsOrgGrp
{
    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("BookValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BookValueAmt { get; set; }
}

public class OtherAssetsSchedule
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("OtherAssetsScheduleGrp"),  JsonConverter(typeof(SingleOrArrayConverter<OtherAssetsScheduleGrp>))]
    public List<OtherAssetsScheduleGrp> OtherAssetsScheduleGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class OtherAssetsScheduleGrp
{
    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("BOYBookValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYBookValueAmt { get; set; }

    [JsonPropertyName("EOYBookValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYBookValueAmt { get; set; }

    [JsonPropertyName("EOYFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYFMVAmt { get; set; }
}

public class OtherAssetsTotalDetail
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class OtherAssetsTotalGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }
}

public class OtherCommuntityBuildingActyGrp
{
    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }
}

public class OtherDecreasesDetail
{
    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Amt { get; set; }
}

public class OtherDecreasesSchedule
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("OtherDecreasesDetail")]
    [JsonConverter(typeof(SingleOrArrayConverter<OtherDecreasesDetail>))]
    public List<OtherDecreasesDetail> OtherDecreasesDetail { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class OtherEmployeeBenefitsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class OtherExemptPurposeExpendGrp
{
    [JsonPropertyName("FilingOrganizationsTotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FilingOrganizationsTotalAmt { get; set; }
}

public class OtherExpensesGrp
{
    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }

    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class OtherExpensesSchedule
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("OtherExpensesScheduleGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<OtherExpensesScheduleGrp>))]
    public List<OtherExpensesScheduleGrp> OtherExpensesScheduleGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class OtherExpensesScheduleGrp
{
    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("RevenueAndExpensesPerBooksAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RevenueAndExpensesPerBooksAmt { get; set; }

    [JsonPropertyName("NetInvestmentIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetInvestmentIncomeAmt { get; set; }

    [JsonPropertyName("DisbursementsCharitablePrpsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DisbursementsCharitablePrpsAmt { get; set; }
}

public class OtherGrossIncomeGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class OtherIncome170Grp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }
}

public class OtherIncome509Grp
{
    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class OtherIncomeDetail
{
    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("RevenueAndExpensesPerBooksAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RevenueAndExpensesPerBooksAmt { get; set; }

    [JsonPropertyName("NetInvestmentIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetInvestmentIncomeAmt { get; set; }

    [JsonPropertyName("AdjustedNetIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdjustedNetIncomeAmt { get; set; }
}


public class OtherIncomeSchedule2
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("OtherIncomeDetail")]
    [JsonConverter(typeof(SingleOrArrayConverter<OtherIncomeDetail>))]
    public List<OtherIncomeDetail> OtherIncomeDetail { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}


public class OtherIncreasesDetail
{
    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Amt { get; set; }
}

public class OtherIncreasesSchedule
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("OtherIncreasesDetail")]
    [JsonConverter(typeof(SingleOrArrayConverter<OtherIncreasesDetail>))]
    public List<OtherIncreasesDetail> OtherIncreasesDetail { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class OtherLandBuildingsGrp
{
    [JsonPropertyName("OtherCostOrOtherBasisAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherCostOrOtherBasisAmt { get; set; }

    [JsonPropertyName("DepreciationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DepreciationAmt { get; set; }

    [JsonPropertyName("BookValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BookValueAmt { get; set; }

    [JsonPropertyName("InvestmentCostOrOtherBasisAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvestmentCostOrOtherBasisAmt { get; set; }
}

public class OtherLiabilitiesDetail
{
    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("BOYBookValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYBookValueAmt { get; set; }

    [JsonPropertyName("EOYBookValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYBookValueAmt { get; set; }
}

public class OtherLiabilitiesGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class OtherLiabilitiesOrgGrp
{
    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Amt { get; set; }
}

public class OtherLiabilitiesSchedule
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("OtherLiabilitiesDetail")]
    [JsonConverter(typeof(SingleOrArrayConverter<OtherLiabilitiesDetail>))]
    public List<OtherLiabilitiesDetail> OtherLiabilitiesDetail { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class OtherNonCashContriTableGrp
{
    [JsonPropertyName("NonCashCheckboxInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string NonCashCheckboxInd { get; set; }

    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("ContributionCnt")] public string ContributionCnt { get; set; }

    [JsonPropertyName("NoncashContributionsRptF990Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NoncashContributionsRptF990Amt { get; set; }

    [JsonPropertyName("MethodOfDeterminingRevenuesTxt")]
    public string MethodOfDeterminingRevenuesTxt { get; set; }
}

public class OtherNotesLoansRcvblLongGrp
{
    [JsonPropertyName("BorrowerNameGrp"),  JsonConverter(typeof(SingleOrArrayConverter<BorrowerNameGrp>))] 
    public List<BorrowerNameGrp> BorrowerNameGrp { get; set; }

    [JsonPropertyName("LoanOriginalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string LoanOriginalAmt { get; set; }

    [JsonPropertyName("BalanceDueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BalanceDueAmt { get; set; }

    [JsonPropertyName("InterestRt")] public string InterestRt { get; set; }

    [JsonPropertyName("LoanPurposeTxt")] public string LoanPurposeTxt { get; set; }

    [JsonPropertyName("ConsiderationFMVAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ConsiderationFMVAmt { get; set; }

    [JsonPropertyName("NoteDt")] public string NoteDt { get; set; }

    [JsonPropertyName("LoanMaturityDt")] public string LoanMaturityDt { get; set; }

    [JsonPropertyName("RepaymentTermsTxt")]
    public string RepaymentTermsTxt { get; set; }

    [JsonPropertyName("SecurityProvidedBorrowerTxt")]
    public string SecurityProvidedBorrowerTxt { get; set; }

    [JsonPropertyName("InsiderRelationshipTxt")]
    public string InsiderRelationshipTxt { get; set; }
}

public class OtherNotesLoansRcvblLongSch
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("OtherNotesLoansRcvblLongGrp")]
    public List<OtherNotesLoansRcvblLongGrp> OtherNotesLoansRcvblLongGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class OtherNotesLoansRcvblShortGrp
{
    [JsonPropertyName("Organization501c3Name")]
    public Organization501c3Name Organization501c3Name { get; set; }

    [JsonPropertyName("BalanceDueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BalanceDueAmt { get; set; }
}

public class OtherNotesLoansRcvblShortSch2
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("OtherNotesLoansRcvblShortGrp"), 
     JsonConverter(typeof(SingleOrArrayConverter<OtherNotesLoansRcvblShortGrp>))]
    public List<OtherNotesLoansRcvblShortGrp> OtherNotesLoansRcvblShortGrp { get; set; }

    [JsonPropertyName("@softwareId")] 
    public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class OtherOrganizationName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }
}

public class OtherProfessionalFeesDetail
{
    [JsonPropertyName("CategoryTxt")] public string CategoryTxt { get; set; }

    [JsonPropertyName("Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Amt { get; set; }

    [JsonPropertyName("NetInvestmentIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetInvestmentIncomeAmt { get; set; }

    [JsonPropertyName("AdjustedNetIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdjustedNetIncomeAmt { get; set; }

    [JsonPropertyName("DisbursementsCharitablePrpsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DisbursementsCharitablePrpsAmt { get; set; }
}

public class OtherProfessionalFeesSchedule
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("OtherProfessionalFeesDetail")]
    [JsonConverter(typeof(SingleOrArrayConverter<OtherProfessionalFeesDetail>))]
    public List<OtherProfessionalFeesDetail> OtherProfessionalFeesDetail { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class OtherReceivablesOfficersSch
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("OfficerOtherRcvblGrp"),  JsonConverter(typeof(SingleOrArrayConverter<OfficerOtherRcvblGrp>))]
    public List<OfficerOtherRcvblGrp> OfficerOtherRcvblGrp { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("OfficerTravelAdvanceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OfficerTravelAdvanceAmt { get; set; }
}

public class OtherRevenueDescribedGrp
{
    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("RelatedOrExemptFunctionIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrExemptFunctionIncmAmt { get; set; }
}

public class OtherRevenueMiscGrp
{
    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExclusionAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("BusinessCd")] public string BusinessCd { get; set; }
}

public class OtherSalariesAndWagesGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class OtherSecuritiesGrp
{
    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("BookValueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BookValueAmt { get; set; }

    [JsonPropertyName("MethodValuationCd")]
    public string MethodValuationCd { get; set; }
}

public class OthHlthCareFcltsGrp
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("FacilityTxt")] public string FacilityTxt { get; set; }
}

public class OthHlthCareFcltsNotHospitalGrp
{
    [JsonPropertyName("OthHlthCareFcltsGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<OthHlthCareFcltsGrp>))]
    public List<OthHlthCareFcltsGrp> OthHlthCareFcltsGrp { get; set; }
}

public class OthNotesLoansReceivableNetGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class PaymentsToAffiliatesGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class PayrollTaxesGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class Pct85LessorAdjIncmOrMinRetGrp
{
    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year3Amt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class PctOfNetVlNonExemptUseAstGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class PdInCapSrplsLandBldgEqpFundGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class PensionPlanContributionsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class PermanentlyRstrNetAssetsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class PersonsWithBooksName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }

    [JsonPropertyName("BusinessNameLine2Txt")]
    public string BusinessNameLine2Txt { get; set; }
}

public class PersonsWithBooksUSAddress
{
    [JsonPropertyName("AddressLine1Txt")] public string AddressLine1Txt { get; set; }

    [JsonPropertyName("CityNm")] public string CityNm { get; set; }

    [JsonPropertyName("StateAbbreviationCd")]
    public string StateAbbreviationCd { get; set; }

    [JsonPropertyName("ZIPCd")] public string ZIPCd { get; set; }

    [JsonPropertyName("AddressLine2Txt")] public string AddressLine2Txt { get; set; }
}

public class PhysicalImprvAndHousingGrp
{
    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }

    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }
}

public class PledgesAndGrantsReceivableGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }
}

public class Post1975UBTIGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }
}

public class PrepaidExpensesDefrdChargesGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class PreparerFirmGrp
{
    [JsonPropertyName("PreparerFirmEIN")] public string PreparerFirmEIN { get; set; }

    [JsonPropertyName("PreparerFirmName")] public PreparerFirmName PreparerFirmName { get; set; }

    [JsonPropertyName("PreparerUSAddress")]
    public PreparerUSAddress PreparerUSAddress { get; set; }

    [JsonPropertyName("PreparerForeignAddress")]
    public PreparerForeignAddress PreparerForeignAddress { get; set; }
}

public class PreparerFirmName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }

    [JsonPropertyName("BusinessNameLine2Txt")]
    public string BusinessNameLine2Txt { get; set; }
}

public class PreparerForeignAddress
{
    [JsonPropertyName("AddressLine1Txt")] public string AddressLine1Txt { get; set; }

    [JsonPropertyName("CityNm")] public string CityNm { get; set; }

    [JsonPropertyName("ProvinceOrStateNm")]
    public string ProvinceOrStateNm { get; set; }

    [JsonPropertyName("CountryCd")] public string CountryCd { get; set; }

    [JsonPropertyName("ForeignPostalCd")] public string ForeignPostalCd { get; set; }

    [JsonPropertyName("AddressLine2Txt")] public string AddressLine2Txt { get; set; }
}

public class PreparerPersonGrp
{
    [JsonPropertyName("PreparerPersonNm")] public string PreparerPersonNm { get; set; }

    [JsonPropertyName("PTIN")] public string PTIN { get; set; }

    [JsonPropertyName("PhoneNum")] public string PhoneNum { get; set; }

    [JsonPropertyName("PreparationDt")] public string PreparationDt { get; set; }

    [JsonPropertyName("SelfEmployedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SelfEmployedInd { get; set; }

    [JsonPropertyName("SSN")] public string SSN { get; set; }
}

public class PreparerUSAddress
{
    [JsonPropertyName("AddressLine1Txt")] public string AddressLine1Txt { get; set; }

    [JsonPropertyName("CityNm")] public string CityNm { get; set; }

    [JsonPropertyName("StateAbbreviationCd")]
    public string StateAbbreviationCd { get; set; }

    [JsonPropertyName("ZIPCd")] public string ZIPCd { get; set; }

    [JsonPropertyName("AddressLine2Txt")] public string AddressLine2Txt { get; set; }
}

public class PrincipalOfcrBusinessName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }

    [JsonPropertyName("BusinessNameLine2Txt")]
    public string BusinessNameLine2Txt { get; set; }
}

public class PrivateOperatingFoundationsGrp
{
    [JsonPropertyName("Section4942j3Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string Section4942j3Ind { get; set; }

    [JsonPropertyName("LessorAdjNetIncmMinInvstRetGrp"),  JsonConverter(typeof(SingleOrArrayConverter<LessorAdjNetIncmMinInvstRetGrp>))]
    public List<LessorAdjNetIncmMinInvstRetGrp> LessorAdjNetIncmMinInvstRetGrp { get; set; }

    [JsonPropertyName("Pct85LessorAdjIncmOrMinRetGrp"),  JsonConverter(typeof(SingleOrArrayConverter<Pct85LessorAdjIncmOrMinRetGrp>))]
    public List<Pct85LessorAdjIncmOrMinRetGrp> Pct85LessorAdjIncmOrMinRetGrp { get; set; }

    [JsonPropertyName("QualifyingDistributionsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<QualifyingDistributionsGrp>))]
    public List<QualifyingDistributionsGrp> QualifyingDistributionsGrp { get; set; }

    [JsonPropertyName("QualifyingDistriNotUsedDrtGrp"),  JsonConverter(typeof(SingleOrArrayConverter<QualifyingDistriNotUsedDrtGrp>))]
    public List<QualifyingDistriNotUsedDrtGrp> QualifyingDistriNotUsedDrtGrp { get; set; }

    [JsonPropertyName("QualifyingDistriMadeDrtGrp"),  JsonConverter(typeof(SingleOrArrayConverter<QualifyingDistriMadeDrtGrp>))]
    public List<QualifyingDistriMadeDrtGrp> QualifyingDistriMadeDrtGrp { get; set; }

    [JsonPropertyName("TotalAssetsGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalAssetsGrp>))] 
    public List<TotalAssetsGrp> TotalAssetsGrp { get; set; }

    [JsonPropertyName("TotalAssetsSect4942j3BiGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalAssetsSect4942j3BiGrp>))]
    public List<TotalAssetsSect4942j3BiGrp> TotalAssetsSect4942j3BiGrp { get; set; }

    [JsonPropertyName("TwoThirdsMinimumInvstRetGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TwoThirdsMinimumInvstRetGrp>))]
    public List<TwoThirdsMinimumInvstRetGrp> TwoThirdsMinimumInvstRetGrp { get; set; }

    [JsonPropertyName("TotalSupportGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TotalSupportGrp>))] 
    public List<TotalSupportGrp> TotalSupportGrp { get; set; }

    [JsonPropertyName("PublicSupportType")]
    public PublicSupportType PublicSupportType { get; set; }

    [JsonPropertyName("LargestSupportFromEOGrp"),  JsonConverter(typeof(SingleOrArrayConverter<LargestSupportFromEOGrp>))]
    public List<LargestSupportFromEOGrp> LargestSupportFromEOGrp { get; set; }

    [JsonPropertyName("GrossInvestmentIncomeGrp"),  JsonConverter(typeof(SingleOrArrayConverter<GrossInvestmentIncomeGrp>))]
    public List<GrossInvestmentIncomeGrp> GrossInvestmentIncomeGrp { get; set; }
}

public class ProductionIncomeGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class ProgramServiceRevenueGrp
{
    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("BusinessCd")] public string BusinessCd { get; set; }

    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrelatedBusinessRevenueAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExclusionAmt { get; set; }
}

public class ProgramServiceRevPartVIIGrp
{
    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("RelatedOrExemptFunctionIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrExemptFunctionIncmAmt { get; set; }
}

public class ProgramSrvcAccomplishmentGrp
{
    [JsonPropertyName("DescriptionProgramSrvcAccomTxt")]
    public string DescriptionProgramSrvcAccomTxt { get; set; }

    [JsonPropertyName("GrantsAndAllocationsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantsAndAllocationsAmt { get; set; }

    [JsonPropertyName("ProgramServiceExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServiceExpensesAmt { get; set; }
}

public class ProgSrvcAccomActy2Grp
{
    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("ExpenseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExpenseAmt { get; set; }

    [JsonPropertyName("RevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RevenueAmt { get; set; }

    [JsonPropertyName("GrantAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantAmt { get; set; }

    [JsonPropertyName("ActivityCd")] public string ActivityCd { get; set; }
}

public class ProgSrvcAccomActy3Grp
{
    [JsonPropertyName("ExpenseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExpenseAmt { get; set; }

    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("GrantAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantAmt { get; set; }

    [JsonPropertyName("RevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RevenueAmt { get; set; }

    [JsonPropertyName("ActivityCd")] public string ActivityCd { get; set; }
}

public class ProgSrvcAccomActyOtherGrp
{
    [JsonPropertyName("ExpenseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExpenseAmt { get; set; }

    [JsonPropertyName("RevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RevenueAmt { get; set; }

    [JsonPropertyName("Desc")] public string Desc { get; set; }
}

public class PublicSupportType
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class PurchaserNameGrp
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }
}

public class PymtTravelEntrtnmntPubOfclGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class QlfyUndSect4940eReducedTaxGrp
{
    [JsonPropertyName("LiableSection4942TaxInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LiableSection4942TaxInd { get; set; }

    [JsonPropertyName("AdjustedQlfyDistriYr1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdjustedQlfyDistriYr1Amt { get; set; }

    [JsonPropertyName("NetVlNoncharitableAssetsYr1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetVlNoncharitableAssetsYr1Amt { get; set; }

    [JsonPropertyName("DistributionYr1Rt")]
    public string DistributionYr1Rt { get; set; }

    [JsonPropertyName("AdjustedQlfyDistriYr2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdjustedQlfyDistriYr2Amt { get; set; }

    [JsonPropertyName("NetVlNoncharitableAssetsYr2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetVlNoncharitableAssetsYr2Amt { get; set; }

    [JsonPropertyName("DistributionYr2Rt")]
    public string DistributionYr2Rt { get; set; }

    [JsonPropertyName("TotalDistributionRt")]
    public string TotalDistributionRt { get; set; }

    [JsonPropertyName("AverageDistributionRt")]
    public string AverageDistributionRt { get; set; }

    [JsonPropertyName("NetVlNoncharitableAssetsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetVlNoncharitableAssetsAmt { get; set; }

    [JsonPropertyName("AdjNetVlNoncharitableAssetsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdjNetVlNoncharitableAssetsAmt { get; set; }

    [JsonPropertyName("NetInvestmentIncomePctAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetInvestmentIncomePctAmt { get; set; }

    [JsonPropertyName("AdjNonchrtblNetInvstIncmPctAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdjNonchrtblNetInvstIncmPctAmt { get; set; }

    [JsonPropertyName("QualifyingDistributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string QualifyingDistributionsAmt { get; set; }

    [JsonPropertyName("AdjustedQlfyDistriYr3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdjustedQlfyDistriYr3Amt { get; set; }

    [JsonPropertyName("NetVlNoncharitableAssetsYr3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetVlNoncharitableAssetsYr3Amt { get; set; }

    [JsonPropertyName("DistributionYr3Rt")]
    public string DistributionYr3Rt { get; set; }

    [JsonPropertyName("AdjustedQlfyDistriYr4Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdjustedQlfyDistriYr4Amt { get; set; }

    [JsonPropertyName("NetVlNoncharitableAssetsYr4Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetVlNoncharitableAssetsYr4Amt { get; set; }

    [JsonPropertyName("DistributionYr4Rt")]
    public string DistributionYr4Rt { get; set; }

    [JsonPropertyName("AdjustedQlfyDistriYr5Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdjustedQlfyDistriYr5Amt { get; set; }

    [JsonPropertyName("NetVlNoncharitableAssetsYr5Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetVlNoncharitableAssetsYr5Amt { get; set; }

    [JsonPropertyName("DistributionYr5Rt")]
    public string DistributionYr5Rt { get; set; }
}

public class QualifyingDistributionsGrp
{
    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year3Amt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class QualifyingDistriMadeDrtGrp
{
    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year3Amt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class QualifyingDistriNotUsedDrtGrp
{
    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year3Amt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class QualifyingDistriPartXIIGrp
{
    [JsonPropertyName("ExpensesAndContributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExpensesAndContributionsAmt { get; set; }

    [JsonPropertyName("CharitableAssetsAcquisPaidAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CharitableAssetsAcquisPaidAmt { get; set; }

    [JsonPropertyName("QualifyingDistributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string QualifyingDistributionsAmt { get; set; }

    [JsonPropertyName("PctSect4940eOrgNetInvstIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PctSect4940eOrgNetInvstIncmAmt { get; set; }

    [JsonPropertyName("AdjustedQualifyingDistriAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdjustedQualifyingDistriAmt { get; set; }

    [JsonPropertyName("ProgramRelatedInvstTotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramRelatedInvstTotalAmt { get; set; }

    [JsonPropertyName("SetAsideSuitabilityTestAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SetAsideSuitabilityTestAmt { get; set; }

    [JsonPropertyName("SetAsideCashDistriTestAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SetAsideCashDistriTestAmt { get; set; }
}

public class RcvblFromDisqualifiedPrsnGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }
}

public class ReasonableCauseExplanation
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }

    [JsonPropertyName("ExplanationTxt")] public string ExplanationTxt { get; set; }
}

public class ReceivablesFromOfficersEtcGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }
}

public class RecipientBusinessName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }
}

public class RecipientTable
{
    [JsonPropertyName("RecipientBusinessName")]
    public RecipientBusinessName RecipientBusinessName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("RecipientEIN")] public string RecipientEIN { get; set; }

    [JsonPropertyName("IRCSectionDesc")] public string IRCSectionDesc { get; set; }

    [JsonPropertyName("CashGrantAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CashGrantAmt { get; set; }

    [JsonPropertyName("PurposeOfGrantTxt")]
    public string PurposeOfGrantTxt { get; set; }
}

public class RecipientUSAddress
{
    [JsonPropertyName("AddressLine1Txt")] public string AddressLine1Txt { get; set; }

    [JsonPropertyName("CityNm")] public string CityNm { get; set; }

    [JsonPropertyName("StateAbbreviationCd")]
    public string StateAbbreviationCd { get; set; }

    [JsonPropertyName("ZIPCd")] public string ZIPCd { get; set; }

    [JsonPropertyName("AddressLine2Txt")] public string AddressLine2Txt { get; set; }
}

public class RecoveriesPYDistributionsGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class RecoveriesPYDistriMinAssetGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class ReductionExplanationStatement
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("ShortExplanationTxt")]
    public string ShortExplanationTxt { get; set; }
}

public class RelatedOrganizationName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }
}

public class RelationshipScheduleDetail
{
    [JsonPropertyName("OrganizationBusinessName")]
    public OrganizationBusinessName OrganizationBusinessName { get; set; }

    [JsonPropertyName("OrganizationTypeDesc")]
    public string OrganizationTypeDesc { get; set; }

    [JsonPropertyName("RelationshipDescriptionTxt")]
    public string RelationshipDescriptionTxt { get; set; }
}

public class RentalIncomeOrLossGrp
{
    [JsonPropertyName("RealAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RealAmt { get; set; }

    [JsonPropertyName("PersonalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PersonalAmt { get; set; }
}


public class ResearchGrp
{
    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }
}

public class RltdOrgOfficerTrstKeyEmplGrp
{
    [JsonPropertyName("PersonNm")] public string PersonNm { get; set; }

    [JsonPropertyName("TitleTxt")] public string TitleTxt { get; set; }

    [JsonPropertyName("BaseCompensationFilingOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BaseCompensationFilingOrgAmt { get; set; }

    [JsonPropertyName("CompensationBasedOnRltdOrgsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompensationBasedOnRltdOrgsAmt { get; set; }

    [JsonPropertyName("BonusFilingOrganizationAmount")]
    public string BonusFilingOrganizationAmount { get; set; }

    [JsonPropertyName("BonusRelatedOrganizationsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BonusRelatedOrganizationsAmt { get; set; }

    [JsonPropertyName("OtherCompensationFilingOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherCompensationFilingOrgAmt { get; set; }

    [JsonPropertyName("OtherCompensationRltdOrgsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherCompensationRltdOrgsAmt { get; set; }

    [JsonPropertyName("DeferredCompensationFlngOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DeferredCompensationFlngOrgAmt { get; set; }

    [JsonPropertyName("DeferredCompRltdOrgsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DeferredCompRltdOrgsAmt { get; set; }

    [JsonPropertyName("NontaxableBenefitsFilingOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NontaxableBenefitsFilingOrgAmt { get; set; }

    [JsonPropertyName("NontaxableBenefitsRltdOrgsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NontaxableBenefitsRltdOrgsAmt { get; set; }

    [JsonPropertyName("TotalCompensationFilingOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCompensationFilingOrgAmt { get; set; }

    [JsonPropertyName("TotalCompensationRltdOrgsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCompensationRltdOrgsAmt { get; set; }

    [JsonPropertyName("CompReportPrior990FilingOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompReportPrior990FilingOrgAmt { get; set; }

    [JsonPropertyName("CompReportPrior990RltdOrgsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CompReportPrior990RltdOrgsAmt { get; set; }
}

public class Return
{
    public string Json { get; set; }

    [JsonPropertyName("id")] public string Id { get; set; }

    [JsonPropertyName("file_name")] public string FileName { get; set; }

    [JsonPropertyName("@binaryAttachmentCnt")]
    public string BinaryAttachmentCnt { get; set; }

    [JsonPropertyName("ReturnTs")] public string ReturnTs { get; set; }

    [JsonPropertyName("TaxPeriodEndDt")] public string TaxPeriodEndDt { get; set; }

    [JsonPropertyName("PreparerFirmGrp"),  JsonConverter(typeof(SingleOrArrayConverter<PreparerFirmGrp>))]
    public List<PreparerFirmGrp> PreparerFirmGrp { get; set; }

    [JsonPropertyName("ReturnTypeCd")] public string ReturnTypeCd { get; set; }

    [JsonPropertyName("TaxPeriodBeginDt")] public string TaxPeriodBeginDt { get; set; }

    [JsonPropertyName("Filer")] public Filer Filer { get; set; }

    [JsonPropertyName("BusinessOfficerGrp"),  JsonConverter(typeof(SingleOrArrayConverter<BusinessOfficerGrp>))]
    public List<BusinessOfficerGrp> BusinessOfficerGrp { get; set; }

    [JsonPropertyName("PreparerPersonGrp"),  JsonConverter(typeof(SingleOrArrayConverter<PreparerPersonGrp>))]
    public List<PreparerPersonGrp> PreparerPersonGrp { get; set; }

    [JsonPropertyName("FilingSecurityInformation")]
    public FilingSecurityInformation FilingSecurityInformation { get; set; }

    [JsonPropertyName("TaxYr")] public string TaxYr { get; set; }

    [JsonPropertyName("BuildTS")] public string BuildTS { get; set; }

    [JsonPropertyName("@documentCnt")] public string DocumentCnt { get; set; }

    [JsonPropertyName("IRS990PF")] public IRS990PF IRS990PF { get; set; }

    [JsonPropertyName("AccountingFeesSchedule")]
    public AccountingFeesSchedule AccountingFeesSchedule { get; set; }

    [JsonPropertyName("DepreciationSchedule")]
    public DepreciationSchedule DepreciationSchedule { get; set; }

    [JsonPropertyName("InvestmentsCorpBondsSchedule")]
    public InvestmentsCorpBondsSchedule InvestmentsCorpBondsSchedule { get; set; }

    [JsonPropertyName("InvestmentsCorpStockSchedule")]
    public InvestmentsCorpStockSchedule InvestmentsCorpStockSchedule { get; set; }

    [JsonPropertyName("InvestmentsGovtObligationsSch")]
    public InvestmentsGovtObligationsSch InvestmentsGovtObligationsSch { get; set; }

    [JsonPropertyName("InvestmentsLandSchedule2")]
    public InvestmentsLandSchedule2 InvestmentsLandSchedule2 { get; set; }

    [JsonPropertyName("InvestmentsOtherSchedule2")]
    public InvestmentsOtherSchedule2 InvestmentsOtherSchedule2 { get; set; }

    [JsonPropertyName("LandEtcSchedule2")] public LandEtcSchedule2 LandEtcSchedule2 { get; set; }

    [JsonPropertyName("LegalFeesSchedule")]
    public LegalFeesSchedule LegalFeesSchedule { get; set; }

    [JsonPropertyName("OtherAssetsSchedule")]
    public OtherAssetsSchedule OtherAssetsSchedule { get; set; }

    [JsonPropertyName("OtherDecreasesSchedule")]
    public OtherDecreasesSchedule OtherDecreasesSchedule { get; set; }

    [JsonPropertyName("OtherExpensesSchedule")]
    public OtherExpensesSchedule OtherExpensesSchedule { get; set; }

    [JsonPropertyName("OtherIncomeSchedule2")]
    public OtherIncomeSchedule2 OtherIncomeSchedule2 { get; set; }

    [JsonPropertyName("OtherIncreasesSchedule")]
    public OtherIncreasesSchedule OtherIncreasesSchedule { get; set; }

    [JsonPropertyName("OtherProfessionalFeesSchedule")]
    public OtherProfessionalFeesSchedule OtherProfessionalFeesSchedule { get; set; }

    [JsonPropertyName("TaxesSchedule")] public TaxesSchedule TaxesSchedule { get; set; }

    [JsonPropertyName("IRS990")] public IRS990 IRS990 { get; set; }

    [JsonPropertyName("IRS990ScheduleD")] public IRS990ScheduleD IRS990ScheduleD { get; set; }

    [JsonPropertyName("IRS990ScheduleO")] public IRS990ScheduleO IRS990ScheduleO { get; set; }

    [JsonPropertyName("IRS990ScheduleG")] public IRS990ScheduleG IRS990ScheduleG { get; set; }

    [JsonPropertyName("IRS990ScheduleA")] public IRS990ScheduleA IRS990ScheduleA { get; set; }

    [JsonPropertyName("IRS990ScheduleB")] public IRS990ScheduleB IRS990ScheduleB { get; set; }

    [JsonPropertyName("IRS990ScheduleR")] public IRS990ScheduleR IRS990ScheduleR { get; set; }

    [JsonPropertyName("IRS990ScheduleJ")] public IRS990ScheduleJ IRS990ScheduleJ { get; set; }

    [JsonPropertyName("IRS990ScheduleL")] public IRS990ScheduleL IRS990ScheduleL { get; set; }

    [JsonPropertyName("IRS990EZ")] public IRS990EZ IRS990EZ { get; set; }

    [JsonPropertyName("TransferPrsnlBnftContractsDecl")]
    public TransferPrsnlBnftContractsDecl TransferPrsnlBnftContractsDecl { get; set; }

    [JsonPropertyName("IRS990ScheduleF")] public IRS990ScheduleF IRS990ScheduleF { get; set; }

    [JsonPropertyName("IRS990ScheduleM")] public IRS990ScheduleM IRS990ScheduleM { get; set; }

    [JsonPropertyName("IRS990ScheduleC")] public IRS990ScheduleC IRS990ScheduleC { get; set; }

    [JsonPropertyName("IRS990ScheduleI")] public IRS990ScheduleI IRS990ScheduleI { get; set; }

    [JsonPropertyName("CompensationExplanation")]
    public CompensationExplanation CompensationExplanation { get; set; }

    [JsonPropertyName("IRS990ScheduleE")] public IRS990ScheduleE IRS990ScheduleE { get; set; }

    [JsonPropertyName("AmortizationSchedule")]
    public AmortizationSchedule AmortizationSchedule { get; set; }

    [JsonPropertyName("MortgagesAndNotesPayableSch")]
    public MortgagesAndNotesPayableSch MortgagesAndNotesPayableSch { get; set; }

    [JsonPropertyName("SalesOfInventoryList")]
    public SalesOfInventoryList SalesOfInventoryList { get; set; }

    [JsonPropertyName("GeneralExplanationAttachment")]
    public GeneralExplanationAttachment GeneralExplanationAttachment { get; set; }

    [JsonPropertyName("OtherLiabilitiesSchedule")]
    public OtherLiabilitiesSchedule OtherLiabilitiesSchedule { get; set; }

    [JsonPropertyName("SubstantialContributorsSch")]
    public SubstantialContributorsSch SubstantialContributorsSch { get; set; }

    [JsonPropertyName("GainLossSaleOtherAssetsSch")]
    public GainLossSaleOtherAssetsSch GainLossSaleOtherAssetsSch { get; set; }

    [JsonPropertyName("IRS990ScheduleK")] public IRS990ScheduleK IRS990ScheduleK { get; set; }

    [JsonPropertyName("ReasonableCauseExplanation")]
    public ReasonableCauseExplanation ReasonableCauseExplanation { get; set; }

    [JsonPropertyName("IRS990ScheduleN")] public IRS990ScheduleN IRS990ScheduleN { get; set; }

    [JsonPropertyName("AppliedToPriorYearElection")]
    public AppliedToPriorYearElection AppliedToPriorYearElection { get; set; }

    [JsonPropertyName("DissolutionStmt")] public DissolutionStmt DissolutionStmt { get; set; }

    [JsonPropertyName("IRS990ScheduleH")] public IRS990ScheduleH IRS990ScheduleH { get; set; }

    [JsonPropertyName("OtherNotesLoansRcvblLongSch")]
    public OtherNotesLoansRcvblLongSch OtherNotesLoansRcvblLongSch { get; set; }

    [JsonPropertyName("DistributionFromCorpusElection")]
    public DistributionFromCorpusElection DistributionFromCorpusElection { get; set; }

    [JsonPropertyName("LiquidationExplanationStmt")]
    public LiquidationExplanationStmt LiquidationExplanationStmt { get; set; }

    [JsonPropertyName("LoansFromOfficersSchedule")]
    public LoansFromOfficersSchedule LoansFromOfficersSchedule { get; set; }

    [JsonPropertyName("OtherNotesLoansRcvblShortSch2")]
    public OtherNotesLoansRcvblShortSch2 OtherNotesLoansRcvblShortSch2 { get; set; }

    [JsonPropertyName("CashDeemedCharitableExplnStmt")]
    public CashDeemedCharitableExplnStmt CashDeemedCharitableExplnStmt { get; set; }

    [JsonPropertyName("ExplnOfNonFilingWithAGStmt")]
    public ExplnOfNonFilingWithAGStmt ExplnOfNonFilingWithAGStmt { get; set; }

    [JsonPropertyName("DisasterReliefTxt")]
    public string DisasterReliefTxt { get; set; }

    [JsonPropertyName("AllOthProgRltdInvestmentsSch")]
    public AllOthProgRltdInvestmentsSch AllOthProgRltdInvestmentsSch { get; set; }

    [JsonPropertyName("ExpenditureResponsibilityStmt")]
    public ExpenditureResponsibilityStmt ExpenditureResponsibilityStmt { get; set; }

    [JsonPropertyName("TransfersFrmControlledEntities")]
    public TransfersFrmControlledEntities TransfersFrmControlledEntities { get; set; }

    [JsonPropertyName("TransfersToControlledEntities")]
    public TransfersToControlledEntities TransfersToControlledEntities { get; set; }

    [JsonPropertyName("OtherReceivablesOfficersSch")]
    public OtherReceivablesOfficersSch OtherReceivablesOfficersSch { get; set; }

    [JsonPropertyName("AffiliateListing")] public AffiliateListing AffiliateListing { get; set; }

    [JsonPropertyName("ExplanOfLegisPoliticalActvts")]
    public ExplanOfLegisPoliticalActvts ExplanOfLegisPoliticalActvts { get; set; }

    [JsonPropertyName("AveragingAttachment")]
    public AveragingAttachment AveragingAttachment { get; set; }

    [JsonPropertyName("EmployeeCompensationExpln")]
    public EmployeeCompensationExpln EmployeeCompensationExpln { get; set; }

    [JsonPropertyName("ReductionExplanationStatement")]
    public ReductionExplanationStatement ReductionExplanationStatement { get; set; }

    [JsonPropertyName("ContractorCompensationExpln")]
    public ContractorCompensationExpln ContractorCompensationExpln { get; set; }

    [JsonPropertyName("AffiliatedGroupSchedule")]
    public AffiliatedGroupSchedule AffiliatedGroupSchedule { get; set; }

    [JsonPropertyName("BorrowedFundsElection")]
    public BorrowedFundsElection BorrowedFundsElection { get; set; }

    [JsonPropertyName("CashDistributionExplnStmt")]
    public CashDistributionExplnStmt CashDistributionExplnStmt { get; set; }

    [JsonPropertyName("ActyNotPreviouslyRptExpln")]
    public ActyNotPreviouslyRptExpln ActyNotPreviouslyRptExpln { get; set; }

    [JsonPropertyName("AffiliatedGroupAttachment")]
    public AffiliatedGroupAttachment AffiliatedGroupAttachment { get; set; }
}

public class RoyaltiesGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class RoyaltiesRevenueGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrelatedBusinessRevenueAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExclusionAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrExemptFuncIncomeAmt { get; set; }
}

public class RtnEarnEndowmentIncmOthFndsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class SalesOfInventoryList
{
    [JsonPropertyName("@documentId")]
    public string DocumentId { get; set; }

    [JsonPropertyName("InventorySaleGrp"),  JsonConverter(typeof(SingleOrArrayConverter<InventorySaleGrp>))] 
    public List<InventorySaleGrp> InventorySaleGrp { get; set; }

    [JsonPropertyName("@softwareId")] 
    public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class SavingsAndTempCashInvstGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class Section527PoliticalOrgGrp
{
    [JsonPropertyName("OrganizationBusinessName")]
    public OrganizationBusinessName OrganizationBusinessName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("EIN")] public string EIN { get; set; }

    [JsonPropertyName("ContributionsRcvdDlvrAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ContributionsRcvdDlvrAmt { get; set; }
}

public class StatementsRegardingActy4720Grp
{
    [JsonPropertyName("SaleOrExchDisqualifiedPrsnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SaleOrExchDisqualifiedPrsnInd { get; set; }

    [JsonPropertyName("BrrwOrLendDisqualifiedPrsnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string BrrwOrLendDisqualifiedPrsnInd { get; set; }

    [JsonPropertyName("FurnGoodsDisqualifiedPrsnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FurnGoodsDisqualifiedPrsnInd { get; set; }

    [JsonPropertyName("PayCompDisqualifiedPrsnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PayCompDisqualifiedPrsnInd { get; set; }

    [JsonPropertyName("TransferAstDisqualifiedPrsnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TransferAstDisqualifiedPrsnInd { get; set; }

    [JsonPropertyName("PaymentToGovernmentOfficialInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PaymentToGovernmentOfficialInd { get; set; }

    [JsonPropertyName("ActsFailToQlfyAsExceptionsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ActsFailToQlfyAsExceptionsInd { get; set; }

    [JsonPropertyName("UndistributedIncomePYInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string UndistributedIncomePYInd { get; set; }

    [JsonPropertyName("BusinessHoldingsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string BusinessHoldingsInd { get; set; }

    [JsonPropertyName("ExcessBusinessHoldingsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessBusinessHoldingsInd { get; set; }

    [JsonPropertyName("JeopardyInvestmentsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string JeopardyInvestmentsInd { get; set; }

    [JsonPropertyName("UncorrectedPYJeopardyInvstInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string UncorrectedPYJeopardyInvstInd { get; set; }

    [JsonPropertyName("InfluenceLegislationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InfluenceLegislationInd { get; set; }

    [JsonPropertyName("InfluenceElectionInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string InfluenceElectionInd { get; set; }

    [JsonPropertyName("GrantsToIndividualsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantsToIndividualsInd { get; set; }

    [JsonPropertyName("GrantsToOrganizationsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrantsToOrganizationsInd { get; set; }

    [JsonPropertyName("NoncharitablePurposeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string NoncharitablePurposeInd { get; set; }

    [JsonPropertyName("RcvFndsToPayPrsnlBnftCntrctInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string RcvFndsToPayPrsnlBnftCntrctInd { get; set; }

    [JsonPropertyName("PayPremiumsPrsnlBnftCntrctInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PayPremiumsPrsnlBnftCntrctInd { get; set; }

    [JsonPropertyName("ProhibitedTaxShelterTransInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProhibitedTaxShelterTransInd { get; set; }

    [JsonPropertyName("UncorrectedPriorActsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string UncorrectedPriorActsInd { get; set; }

    [JsonPropertyName("UndistrIncmSect4942a2NotAppInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string UndistrIncmSect4942a2NotAppInd { get; set; }

    [JsonPropertyName("TransactionsFailToQlfyAsExcInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TransactionsFailToQlfyAsExcInd { get; set; }

    [JsonPropertyName("MaintainedExpenditureRspnsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MaintainedExpenditureRspnsInd { get; set; }

    [JsonPropertyName("ProceedsOrNetIncomeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProceedsOrNetIncomeInd { get; set; }

    [JsonPropertyName("UndistributedIncomePY1Yr")]
    public string UndistributedIncomePY1Yr { get; set; }

    [JsonPropertyName("UndistributedIncomePY2Yr")]
    public string UndistributedIncomePY2Yr { get; set; }

    [JsonPropertyName("UndistributedIncomePY3Yr")]
    public string UndistributedIncomePY3Yr { get; set; }

    [JsonPropertyName("UndistributedIncomePY4Yr")]
    public string UndistributedIncomePY4Yr { get; set; }

    [JsonPropertyName("UndistrIncmSect4942a2AppYr4Yr")]
    public string UndistrIncmSect4942a2AppYr4Yr { get; set; }

    [JsonPropertyName("SubjToTaxRmnrtnExPrchtPymtInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SubjToTaxRmnrtnExPrchtPymtInd { get; set; }

    [JsonPropertyName("RelyingCurrentNtcDsstrAsst1Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelyingCurrentNtcDsstrAsst1Ind { get; set; }

    [JsonPropertyName("RelyingCurrentNtcDsstrAsstInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelyingCurrentNtcDsstrAsstInd { get; set; }

    [JsonPropertyName("UndistrIncmSect4942a2AppYr1Yr")]
    public string UndistrIncmSect4942a2AppYr1Yr { get; set; }

    [JsonPropertyName("UndistrIncmSect4942a2AppYr2Yr")]
    public string UndistrIncmSect4942a2AppYr2Yr { get; set; }

    [JsonPropertyName("UndistrIncmSect4942a2AppYr3Yr")]
    public string UndistrIncmSect4942a2AppYr3Yr { get; set; }
}

public class StatementsRegardingActyGrp
{
    [JsonPropertyName("LegislativePoliticalActyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LegislativePoliticalActyInd { get; set; }

    [JsonPropertyName("MoreThan100SpentInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MoreThan100SpentInd { get; set; }

    [JsonPropertyName("Form1120POLFiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form1120POLFiledInd { get; set; }

    [JsonPropertyName("ActivitiesNotPreviouslyRptInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ActivitiesNotPreviouslyRptInd { get; set; }

    [JsonPropertyName("ChangesToArticlesOrBylawsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ChangesToArticlesOrBylawsInd { get; set; }

    [JsonPropertyName("UnrelatedBusIncmOverLimitInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrelatedBusIncmOverLimitInd { get; set; }

    [JsonPropertyName("OrganizationDissolvedEtcInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OrganizationDissolvedEtcInd { get; set; }

    [JsonPropertyName("Section508eRqrSatisfiedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Section508eRqrSatisfiedInd { get; set; }

    [JsonPropertyName("AtLeast5000InAssetsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AtLeast5000InAssetsInd { get; set; }

    [JsonPropertyName("OrgReportOrRegisterStateCd")]
    public string OrgReportOrRegisterStateCd { get; set; }

    [JsonPropertyName("Form990PFFiledWithAttyGenInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form990PFFiledWithAttyGenInd { get; set; }

    [JsonPropertyName("PrivateOperatingFoundationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PrivateOperatingFoundationInd { get; set; }

    [JsonPropertyName("NewSubstantialContributorsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string NewSubstantialContributorsInd { get; set; }

    [JsonPropertyName("OwnControlledEntityInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OwnControlledEntityInd { get; set; }

    [JsonPropertyName("DonorAdvisedFundInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DonorAdvisedFundInd { get; set; }

    [JsonPropertyName("ComplyWithPublicInspRqrInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ComplyWithPublicInspRqrInd { get; set; }

    [JsonPropertyName("WebsiteAddressTxt")]
    public string WebsiteAddressTxt { get; set; }

    [JsonPropertyName("IndividualWithBooksNm")]
    public string IndividualWithBooksNm { get; set; }

    [JsonPropertyName("PhoneNum")] public string PhoneNum { get; set; }

    [JsonPropertyName("LocationOfBooksUSAddress")]
    public LocationOfBooksUSAddress LocationOfBooksUSAddress { get; set; }

    [JsonPropertyName("ForeignAccountsQuestionInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ForeignAccountsQuestionInd { get; set; }

    [JsonPropertyName("PersonsWithBooksName")]
    public PersonsWithBooksName PersonsWithBooksName { get; set; }

    [JsonPropertyName("Section4955OrganizationTaxAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Section4955OrganizationTaxAmt { get; set; }

    [JsonPropertyName("Section4955ManagersTaxAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Section4955ManagersTaxAmt { get; set; }

    [JsonPropertyName("TaxReimbursedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxReimbursedAmt { get; set; }

    [JsonPropertyName("Form990TFiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form990TFiledInd { get; set; }

    [JsonPropertyName("NECTFilingInLieuOFForm1041Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string NECTFilingInLieuOFForm1041Ind { get; set; }

    [JsonPropertyName("TaxExemptInterestAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TaxExemptInterestAmt { get; set; }

    [JsonPropertyName("ForeignCountryCd")] public string ForeignCountryCd { get; set; }

    [JsonPropertyName("LocationOfBooksForeignAddress")]
    public LocationOfBooksForeignAddress LocationOfBooksForeignAddress { get; set; }
}

public class SubsidizedHealthServicesGrp
{
    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }
}

public class SubstAndDsqlfyPrsnsTotGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }
}

public class SubstantialContributorDetail
{
    [JsonPropertyName("PersonNm")] public string PersonNm { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }
}

public class SubstantialContributorsAmtGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }
}

public class SubstantialContributorsSch
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("SubstantialContributorDetail")]
    [JsonConverter(typeof(SingleOrArrayConverter<SubstantialContributorDetail>))]
    public List<SubstantialContributorDetail> SubstantialContributorDetail { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class SubtotalsIncmProducingActyGrp
{
    [JsonPropertyName("RelatedOrExemptFunctionIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrExemptFunctionIncmAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessTaxblIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrelatedBusinessTaxblIncmAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExclusionAmt { get; set; }
}

public class SumOfTotalLiabilitiesGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class SupplementalInformationDetail
{
    [JsonPropertyName("FormAndLineReferenceDesc")]
    public string FormAndLineReferenceDesc { get; set; }

    [JsonPropertyName("ExplanationTxt")] public string ExplanationTxt { get; set; }
}

public class SupplementalInformationGrp
{
    [JsonPropertyName("FormAndLineReferenceDesc")]
    public string FormAndLineReferenceDesc { get; set; }

    [JsonPropertyName("ExplanationTxt")] public string ExplanationTxt { get; set; }
}

public class SupplementaryInformationGrp
{
    [JsonPropertyName("ContributingManagerNm")]
    public string ContributingManagerNm { get; set; }

    [JsonPropertyName("ShareholderManagerNm")]
    public string ShareholderManagerNm { get; set; }

    [JsonPropertyName("OnlyContriToPreselectedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OnlyContriToPreselectedInd { get; set; }

    [JsonPropertyName("GrantOrContributionPdDurYrGrp"),  JsonConverter(typeof(SingleOrArrayConverter<GrantOrContributionPdDurYrGrp>))]
    public List<GrantOrContributionPdDurYrGrp> GrantOrContributionPdDurYrGrp { get; set; }

    [JsonPropertyName("TotalGrantOrContriPdDurYrAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalGrantOrContriPdDurYrAmt { get; set; }

    [JsonPropertyName("TotalGrantOrContriApprvFutAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalGrantOrContriApprvFutAmt { get; set; }

    [JsonPropertyName("ApplicationSubmissionInfoGrp"),  JsonConverter(typeof(SingleOrArrayConverter<ApplicationSubmissionInfoGrp>))]
    public List<ApplicationSubmissionInfoGrp> ApplicationSubmissionInfoGrp { get; set; }

    [JsonPropertyName("GrantOrContriApprvForFutGrp"),  JsonConverter(typeof(SingleOrArrayConverter<GrantOrContriApprvForFutGrp>))]
    public List<GrantOrContriApprvForFutGrp> GrantOrContriApprvForFutGrp { get; set; }
}

public class SupportedOrganizationName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }

    [JsonPropertyName("BusinessNameLine2Txt")]
    public string BusinessNameLine2Txt { get; set; }
}

public class SupportedOrgInformationGrp
{
    [JsonPropertyName("SupportedOrganizationName")]
    public SupportedOrganizationName SupportedOrganizationName { get; set; }

    [JsonPropertyName("EIN")] public string EIN { get; set; }

    [JsonPropertyName("OrganizationTypeCd")]
    public string OrganizationTypeCd { get; set; }

    [JsonPropertyName("GoverningDocumentListedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GoverningDocumentListedInd { get; set; }

    [JsonPropertyName("SupportAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string SupportAmt { get; set; }

    [JsonPropertyName("OtherSupportAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherSupportAmt { get; set; }
}

public class TaxesDetail
{
    [JsonPropertyName("CategoryTxt")] public string CategoryTxt { get; set; }

    [JsonPropertyName("Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Amt { get; set; }

    [JsonPropertyName("NetInvestmentIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetInvestmentIncomeAmt { get; set; }

    [JsonPropertyName("DisbursementsCharitablePrpsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DisbursementsCharitablePrpsAmt { get; set; }
}

public class TaxesSchedule
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("TaxesDetail")]
    [JsonConverter(typeof(SingleOrArrayConverter<TaxesDetail>))]
    public List<TaxesDetail> TaxesDetail { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class TaxExemptBondLiabilitiesGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class TaxExemptBondsArbitrageGrp
{
    [JsonPropertyName("BondReferenceCd")] public string BondReferenceCd { get; set; }

    [JsonPropertyName("Form8038TFiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string Form8038TFiledInd { get; set; }

    [JsonPropertyName("VariableRateIssueInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string VariableRateIssueInd { get; set; }

    [JsonPropertyName("HedgeIdentifiedInBksAndRecInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string HedgeIdentifiedInBksAndRecInd { get; set; }

    [JsonPropertyName("GrossProceedsInvestedInGICInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossProceedsInvestedInGICInd { get; set; }

    [JsonPropertyName("GrossProceedsInvestedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GrossProceedsInvestedInd { get; set; }

    [JsonPropertyName("WrittenProcToMonitorReqsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string WrittenProcToMonitorReqsInd { get; set; }
}

public class TaxExemptBondsIssuesGrp
{
    [JsonPropertyName("BondReferenceCd")] public string BondReferenceCd { get; set; }

    [JsonPropertyName("IssuerName")] public IssuerName IssuerName { get; set; }

    [JsonPropertyName("BondIssuerEIN")] public string BondIssuerEIN { get; set; }

    [JsonPropertyName("CUSIPNum")] public string CUSIPNum { get; set; }

    [JsonPropertyName("BondIssuedDt")] public string BondIssuedDt { get; set; }

    [JsonPropertyName("IssuePriceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string IssuePriceAmt { get; set; }

    [JsonPropertyName("PurposeDesc")] public string PurposeDesc { get; set; }

    [JsonPropertyName("DefeasedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DefeasedInd { get; set; }

    [JsonPropertyName("OnBehalfOfIssuerInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OnBehalfOfIssuerInd { get; set; }

    [JsonPropertyName("PoolFinancingInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PoolFinancingInd { get; set; }
}

public class TaxExemptBondsPrivateBusUseGrp
{
    [JsonPropertyName("BondReferenceCd")] public string BondReferenceCd { get; set; }

    [JsonPropertyName("OwningBondFinancedPropertyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string OwningBondFinancedPropertyInd { get; set; }

    [JsonPropertyName("AnyLeaseArrangementsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AnyLeaseArrangementsInd { get; set; }

    [JsonPropertyName("MgmtContractBondFincdPropInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string MgmtContractBondFincdPropInd { get; set; }

    [JsonPropertyName("AnyResearchAgreementsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AnyResearchAgreementsInd { get; set; }

    [JsonPropertyName("BondIssMeetPrvtSecPymtTestInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string BondIssMeetPrvtSecPymtTestInd { get; set; }

    [JsonPropertyName("ChangeInUseBondFinancedPropInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ChangeInUseBondFinancedPropInd { get; set; }

    [JsonPropertyName("ProcsNonqualifiedBondRemdtdInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProcsNonqualifiedBondRemdtdInd { get; set; }
}

public class TaxExemptBondsProceedsGrp
{
    [JsonPropertyName("BondReferenceCd")] public string BondReferenceCd { get; set; }

    [JsonPropertyName("TotalProceedsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalProceedsAmt { get; set; }

    [JsonPropertyName("InReserveFundAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InReserveFundAmt { get; set; }

    [JsonPropertyName("CapitalizedInterestAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CapitalizedInterestAmt { get; set; }

    [JsonPropertyName("IssuanceCostsFromProceedsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string IssuanceCostsFromProceedsAmt { get; set; }

    [JsonPropertyName("CapitalExpendituresAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CapitalExpendituresAmt { get; set; }

    [JsonPropertyName("OtherSpentProceedsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string OtherSpentProceedsAmt { get; set; }

    [JsonPropertyName("SubstantialCompletionYr")]
    public string SubstantialCompletionYr { get; set; }

    [JsonPropertyName("CurrentRefundingInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentRefundingInd { get; set; }

    [JsonPropertyName("AdvanceRefundingInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdvanceRefundingInd { get; set; }

    [JsonPropertyName("FinalAllocationMadeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string FinalAllocationMadeInd { get; set; }

    [JsonPropertyName("AdequateBooksAndRecMaintInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AdequateBooksAndRecMaintInd { get; set; }
}

public class TaxRevLeviedOrgnztnlBnft170Grp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }
}

public class TaxRevLeviedOrgnztnlBnft509Grp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }
}

public class TemporarilyRstrNetAssetsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class ThirdPartyBusinessName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string BusinessNameLine1Txt { get; set; }
}

public class ThirdPartyForeignAddress
{
    [JsonPropertyName("AddressLine1Txt")] public string AddressLine1Txt { get; set; }

    [JsonPropertyName("CityNm")] public string CityNm { get; set; }

    [JsonPropertyName("CountryCd")] public string CountryCd { get; set; }

    [JsonPropertyName("ForeignPostalCd")] public string ForeignPostalCd { get; set; }
}

public class ThirdPartyUSAddress
{
    [JsonPropertyName("AddressLine1Txt")] public string AddressLine1Txt { get; set; }

    [JsonPropertyName("CityNm")] public string CityNm { get; set; }

    [JsonPropertyName("StateAbbreviationCd")]
    public string StateAbbreviationCd { get; set; }

    [JsonPropertyName("ZIPCd")] public string ZIPCd { get; set; }
}

public class Total509Grp
{
    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }
}

public class TotalAdjustedNetIncomeGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class TotalAssetsGrp
{
    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year3Amt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class TotalAssetsSect4942j3BiGrp
{
    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year3Amt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class TotalCalendarYear170Grp
{
    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class TotalCommunityBenefitsGrp
{
    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }
}

public class TotalCommuntityBuildingActyGrp
{
    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }
}

public class TotalDirectLobbyingGrp
{
    [JsonPropertyName("FilingOrganizationsTotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FilingOrganizationsTotalAmt { get; set; }
}

public class TotalExemptPurposeExpendGrp
{
    [JsonPropertyName("FilingOrganizationsTotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FilingOrganizationsTotalAmt { get; set; }
}

public class TotalFinancialAssistanceTyp
{
    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }
}

public class TotalFMVOfNonExemptUseAssetGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class TotalFunctionalExpensesGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class TotalGrassrootsLobbyingGrp
{
    [JsonPropertyName("FilingOrganizationsTotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FilingOrganizationsTotalAmt { get; set; }
}

public class TotalJointCostsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class TotalLiabilitiesGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class TotalLobbyingExpendGrp
{
    [JsonPropertyName("FilingOrganizationsTotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FilingOrganizationsTotalAmt { get; set; }
}

public class TotalMinimumAssetGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }
}

public class TotalNetAssetsFundBalanceGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class TotalOtherBenefitsGrp
{
    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }
}

public class TotalOthProgramServiceRevGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrelatedBusinessRevenueAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExclusionAmt { get; set; }
}

public class TotalRevenueGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UnrelatedBusinessRevenueAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExclusionAmt { get; set; }
}

public class TotalSupportCalendarYearGrp
{
    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class TotalSupportGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }
}

public class TotLbbyExpendMnsLbbyngNonTxGrp
{
    [JsonPropertyName("FilingOrganizationsTotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FilingOrganizationsTotalAmt { get; set; }
}

public class TotLbbyngGrassrootMnsNonTxGrp
{
    [JsonPropertyName("FilingOrganizationsTotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FilingOrganizationsTotalAmt { get; set; }
}

public class TotLiabNetAssetsFundBalanceGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class TransactionsRelatedOrgGrp
{
    [JsonPropertyName("OtherOrganizationName")]
    public OtherOrganizationName OtherOrganizationName { get; set; }

    [JsonPropertyName("TransactionTypeTxt")]
    public string TransactionTypeTxt { get; set; }

    [JsonPropertyName("MethodOfAmountDeterminationTxt")]
    public string MethodOfAmountDeterminationTxt { get; set; }

    [JsonPropertyName("InvolvedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvolvedAmt { get; set; }
}

public class TransferPrsnlBnftContractsDecl
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("DeclarationDesc")] public string DeclarationDesc { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class TransferScheduleDetail
{
    [JsonPropertyName("LineNumberTxt")] public string LineNumberTxt { get; set; }

    [JsonPropertyName("InvolvedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string InvolvedAmt { get; set; }

    [JsonPropertyName("NoncharitableExemptOrgName")]
    public NoncharitableExemptOrgName NoncharitableExemptOrgName { get; set; }

    [JsonPropertyName("TransfersTransAndShrArrngmDesc")]
    public string TransfersTransAndShrArrngmDesc { get; set; }
}

public class TransfersFrmControlledEntities
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("TransfersFromControlledEntGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<TransfersFromControlledEntGrp>))]
    public List<TransfersFromControlledEntGrp> TransfersFromControlledEntGrp { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class TransfersFromControlledEntGrp
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("EIN")] public string EIN { get; set; }

    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Amt { get; set; }
}

public class TransfersToControlledEntGrp
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("EIN")] public string EIN { get; set; }

    [JsonPropertyName("Desc")] public string Desc { get; set; }

    [JsonPropertyName("Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Amt { get; set; }

    [JsonPropertyName("ForeignAddress")] public ForeignAddress ForeignAddress { get; set; }
}

public class TransfersToControlledEntities
{
    [JsonPropertyName("@documentId")] public string DocumentId { get; set; }

    [JsonPropertyName("TransfersToControlledEntGrp"),  JsonConverter(typeof(SingleOrArrayConverter<TransfersToControlledEntGrp>))]
    public List<TransfersToControlledEntGrp> TransfersToControlledEntGrp { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("@softwareId")] public string SoftwareId { get; set; }

    [JsonPropertyName("@softwareVersionNum")]
    public string SoftwareVersionNum { get; set; }
}

public class TravelGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string FundraisingAmt { get; set; }
}

public class TrnsfrTransRlnNonchrtblEOGrp
{
    [JsonPropertyName("TrnsfrOfCashToNonchrtblEOInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TrnsfrOfCashToNonchrtblEOInd { get; set; }

    [JsonPropertyName("TrnsfrOtherAssetNonchrtblEOInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string TrnsfrOtherAssetNonchrtblEOInd { get; set; }

    [JsonPropertyName("SalesOrExchangesOfAssetsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SalesOrExchangesOfAssetsInd { get; set; }

    [JsonPropertyName("PurchaseOfAssetsNonchrtblEOInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PurchaseOfAssetsNonchrtblEOInd { get; set; }

    [JsonPropertyName("RentalOfFacilitiesOthAssetsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string RentalOfFacilitiesOthAssetsInd { get; set; }

    [JsonPropertyName("ReimbursementArrangementsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string ReimbursementArrangementsInd { get; set; }

    [JsonPropertyName("LoansOrLoanGuaranteesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string LoansOrLoanGuaranteesInd { get; set; }

    [JsonPropertyName("PerformanceOfServicesEtcInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string PerformanceOfServicesEtcInd { get; set; }

    [JsonPropertyName("SharingOfFacilitiesEtcInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string SharingOfFacilitiesEtcInd { get; set; }

    [JsonPropertyName("RelationshipsNonchrtblEOInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string RelationshipsNonchrtblEOInd { get; set; }

    [JsonPropertyName("RelationshipScheduleDetail")]
    public RelationshipScheduleDetail RelationshipScheduleDetail { get; set; }

    [JsonPropertyName("TransferScheduleDetail")]
    [JsonConverter(typeof(SingleOrArrayConverter<TransferScheduleDetail>))]
    public List<TransferScheduleDetail> TransferScheduleDetail { get; set; }
}

public class TwoThirdsMinimumInvstRetGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Year3Amt { get; set; }
}

public class UndistributedIncomeGrp
{
    [JsonPropertyName("DistributableAsAdjustedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DistributableAsAdjustedAmt { get; set; }

    [JsonPropertyName("ExcessDistributionCyovYr4Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessDistributionCyovYr4Amt { get; set; }

    [JsonPropertyName("ExcessDistributionCyovYr3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessDistributionCyovYr3Amt { get; set; }

    [JsonPropertyName("ExcessDistributionCyovYr1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessDistributionCyovYr1Amt { get; set; }

    [JsonPropertyName("TotalExcessDistributionCyovAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalExcessDistributionCyovAmt { get; set; }

    [JsonPropertyName("QualifyingDistributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string QualifyingDistributionsAmt { get; set; }

    [JsonPropertyName("AppliedToCurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AppliedToCurrentYearAmt { get; set; }

    [JsonPropertyName("RemainingDistriFromCorpusAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string RemainingDistriFromCorpusAmt { get; set; }

    [JsonPropertyName("TotalCorpusAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCorpusAmt { get; set; }

    [JsonPropertyName("UndistributedIncomeCYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UndistributedIncomeCYAmt { get; set; }

    [JsonPropertyName("ExcessDistriCyovToNextYrAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessDistriCyovToNextYrAmt { get; set; }

    [JsonPropertyName("ExcessFromYear4Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessFromYear4Amt { get; set; }

    [JsonPropertyName("ExcessFromYear3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessFromYear3Amt { get; set; }

    [JsonPropertyName("ExcessFromYear1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessFromYear1Amt { get; set; }

    [JsonPropertyName("ExcessFromCurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessFromCurrentYearAmt { get; set; }

    [JsonPropertyName("UndistributedIncomePYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string UndistributedIncomePYAmt { get; set; }

    [JsonPropertyName("PriorYear1Yr")] public string PriorYear1Yr { get; set; }

    [JsonPropertyName("PriorYear2Yr")] public string PriorYear2Yr { get; set; }

    [JsonPropertyName("PriorYear3Yr")] public string PriorYear3Yr { get; set; }

    [JsonPropertyName("TotalForPriorYearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalForPriorYearsAmt { get; set; }

    [JsonPropertyName("ExcessDistributionCyovYr2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessDistributionCyovYr2Amt { get; set; }

    [JsonPropertyName("AppliedToYear1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AppliedToYear1Amt { get; set; }

    [JsonPropertyName("PriorYearUndistributedIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearUndistributedIncmAmt { get; set; }

    [JsonPropertyName("Taxable1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Taxable1Amt { get; set; }

    [JsonPropertyName("Taxable2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string Taxable2Amt { get; set; }

    [JsonPropertyName("ExcessFromYear2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessFromYear2Amt { get; set; }

    [JsonPropertyName("AppliedToPriorYearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string AppliedToPriorYearsAmt { get; set; }

    [JsonPropertyName("TreatedAsDistriFromCorpusAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TreatedAsDistriFromCorpusAmt { get; set; }

    [JsonPropertyName("ExcessDistriCyovAppCYCorpusAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessDistriCyovAppCYCorpusAmt { get; set; }

    [JsonPropertyName("ExcessDistributionCyovAppCYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessDistributionCyovAppCYAmt { get; set; }

    [JsonPropertyName("PriorYearDeficiencyOrTaxAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string PriorYearDeficiencyOrTaxAmt { get; set; }

    [JsonPropertyName("CorpusDistri170b1EOr4942g3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CorpusDistri170b1EOr4942g3Amt { get; set; }

    [JsonPropertyName("ExcessDistriCyovFromYr5Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessDistriCyovFromYr5Amt { get; set; }

    [JsonPropertyName("ExcessDistributionCyovYr5Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ExcessDistributionCyovYr5Amt { get; set; }
}

public class UnreimbursedCostsGrp
{
    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }
}

public class UnreimbursedMedicaidGrp
{
    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }
}

public class UnrelatedBusinessNetIncm170Grp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string CurrentTaxYearMinus2YearsAmt { get; set; }
}

public class UnrelatedOrgTxblPartnershipGrp
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("EIN")] public string EIN { get; set; }

    [JsonPropertyName("PrimaryActivitiesTxt")]
    public string PrimaryActivitiesTxt { get; set; }

    [JsonPropertyName("LegalDomicileStateCd")]
    public string LegalDomicileStateCd { get; set; }

    [JsonPropertyName("PredominateIncomeDesc")]
    public string PredominateIncomeDesc { get; set; }

    [JsonPropertyName("AllPartnersC3SInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string AllPartnersC3SInd { get; set; }

    [JsonPropertyName("ShareOfTotalIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ShareOfTotalIncomeAmt { get; set; }

    [JsonPropertyName("ShareOfEOYAssetsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string ShareOfEOYAssetsAmt { get; set; }

    [JsonPropertyName("DisproportionateAllocationsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string DisproportionateAllocationsInd { get; set; }

    [JsonPropertyName("GeneralOrManagingPartnerInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string GeneralOrManagingPartnerInd { get; set; }

    [JsonPropertyName("OwnershipPct")] public string OwnershipPct { get; set; }
}

public class UnrestrictedNetAssetsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class UnsecuredNotesLoansPayableGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string EOYAmt { get; set; }
}

public class USAddress
{
    [JsonPropertyName("AddressLine1Txt")] public string AddressLine1Txt { get; set; }

    [JsonPropertyName("CityNm")] public string CityNm { get; set; }

    [JsonPropertyName("StateAbbreviationCd")]
    public string StateAbbreviationCd { get; set; }

    [JsonPropertyName("ZIPCd")] public string ZIPCd { get; set; }

    [JsonPropertyName("AddressLine2Txt")] public string AddressLine2Txt { get; set; }
}

public class WorkforceDevelopmentGrp
{
    [JsonPropertyName("PersonsServedCnt")] public string PersonsServedCnt { get; set; }

    [JsonPropertyName("TotalCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string TotalCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("NetCommunityBenefitExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string NetCommunityBenefitExpnsAmt { get; set; }

    [JsonPropertyName("TotalExpensePct")] public string TotalExpensePct { get; set; }

    [JsonPropertyName("DirectOffsettingRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string DirectOffsettingRevenueAmt { get; set; }

    [JsonPropertyName("ActivitiesOrProgramsCnt")]
    public string ActivitiesOrProgramsCnt { get; set; }
}
