using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
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

public class IRS990Minified
{
    [JsonProperty("Id")]
    public string? Id { get; set; }

    [JsonProperty("FileName")] 
    public string? FileName { get; set; }

    [JsonProperty("EIN")]
    public string? EIN { get; set; }

    [JsonProperty("TaxYr")]
    public string? TaxYr { get; set; }

    [JsonProperty("ReturnTs")] 
    public string? ReturnTs { get; set; }

    [JsonProperty("TaxPeriodEndDt")] 
    public string? TaxPeriodEndDt { get; set; }

    [JsonProperty("TaxPeriodBeginDt")] 
    public string? TaxPeriodBeginDt { get; set; }

    [JsonProperty("BusinessNameLine1Txt")] 
    public string? BusinessNameLine1Txt { get; set; }

    [JsonProperty("AddressLine1Txt")] 
    public string? AddressLine1Txt { get; set; }

    [JsonProperty("CityNm")] 
    public string? CityNm { get; set; }

    [JsonProperty("StateAbbreviationCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> StateAbbreviationCd { get; set; }

    [JsonProperty("ZIPCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> ZIPCd { get; set; }

    [JsonProperty("TotalEmployeeCnt")] 
    public string? TotalEmployeeCnt { get; set; }

    [JsonProperty("PYTotalRevenueAmt")] 
    public string? PYTotalRevenueAmt { get; set; }

    [JsonProperty("CYTotalRevenueAmt")] 
    public string? CYTotalRevenueAmt { get; set; }

    [JsonProperty("PYRevenuesLessExpensesAmt")]
    public string? PYRevenuesLessExpensesAmt { get; set; }

    [JsonProperty("CYRevenuesLessExpensesAmt")]
    public string? CYRevenuesLessExpensesAmt { get; set; }

    [JsonProperty("TotalAssetsBOYAmt")] 
    public string? TotalAssetsBOYAmt { get; set; }

    [JsonProperty("TotalAssetsEOYAmt")]
    public string? TotalAssetsEOYAmt { get; set; }

    [JsonProperty("SupplementalNonqualRtrPlanInd")]
    public string? SupplementalNonqualRtrPlanInd { get; set; }

    [JsonProperty("RltdOrgOfficerTrstKeyEmplGrp")]
    public List<RltdOrgOfficerTrstKeyEmplGrp> RltdOrgOfficerTrstKeyEmplGrp { get; set; }
}

public class JsonErrorStringValue
{
    [JsonPropertyName("@referenceDocumentId")]
    public string? ReferenceDocumentId { get; set; }

    [JsonPropertyName("#text")] public string? Text { get; set; }
}

public class AccountsPayableAccrExpnssGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }
}

public class AccountsReceivableGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class AcctCompileOrReviewBasisGrp
{
    [JsonPropertyName("SeparateBasisFinclStmtInd")
     , JsonConverter(typeof(FixScrewedUpString))]
    public string? SeparateBasisFinclStmtInd { get; set; }

    [JsonPropertyName("ConsolidatedBasisFinclStmtInd")
     , JsonConverter(typeof(FixScrewedUpString))]
    public string? ConsolidatedBasisFinclStmtInd { get; set; }

    [JsonPropertyName("ConsolAndSepBasisFinclStmtInd")]
    [JsonConverter(typeof(FixScrewedUpString))]
    public string? ConsolAndSepBasisFinclStmtInd { get; set; }
}

public class AcquisitionIndebtednessGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}

public class AdjustedFMVLessIndebtednessGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}

public class AdjustedGrossIncomeGrp
{
    [JsonPropertyName("PriorYearAmt")] public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt")] public string? CurrentYearAmt { get; set; }
}
public class AdvertisingGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class AllOtherExpensesGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class ApplicationSubmissionInfoGrp
{
    [JsonPropertyName("RecipientPersonNm")]
    public string? RecipientPersonNm { get; set; }

    [JsonPropertyName("RecipientUSAddress")]
    public RecipientUSAddress RecipientUSAddress { get; set; }

    [JsonPropertyName("RecipientPhoneNum")]
    public string? RecipientPhoneNum { get; set; }

    [JsonPropertyName("FormAndInfoAndMaterialsTxt")]
    public string? FormAndInfoAndMaterialsTxt { get; set; }

    [JsonPropertyName("SubmissionDeadlinesTxt")]
    public string? SubmissionDeadlinesTxt { get; set; }

    [JsonPropertyName("RestrictionsOnAwardsTxt")]
    public string? RestrictionsOnAwardsTxt { get; set; }

    [JsonPropertyName("RecipientEmailAddressTxt")]
    public string? RecipientEmailAddressTxt { get; set; }
}

public class AverageMonthlyCashBalancesGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}

public class AverageMonthlyFMVOfSecGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}

public class BenefitsToMembersGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }
}

public class BooksInCareOfDetail
{
    [JsonPropertyName("PersonNm")] public string? PersonNm { get; set; }

    [JsonPropertyName("PhoneNum")] public string? PhoneNum { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("ForeignAddress")] public ForeignAddress ForeignAddress { get; set; }
}

public class BorrowerNameGrp
{
    [JsonPropertyName("PersonNm")] public string? PersonNm { get; set; }

    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }
}


public class BusinessName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }

    [JsonPropertyName("BusinessNameLine2Txt")]
    public string? BusinessNameLine2Txt { get; set; }
}

public class CapGainsLossTxInvstIncmGrp
{
    [JsonPropertyName("PropertyDesc")] public string? PropertyDesc { get; set; }

    [JsonPropertyName("AcquiredDt")] public string? AcquiredDt { get; set; }

    [JsonPropertyName("SoldDt")] public string? SoldDt { get; set; }

    [JsonPropertyName("GrossSalesPriceAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GrossSalesPriceAmt { get; set; }

    [JsonPropertyName("GainOrLossAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GainOrLossAmt { get; set; }

    [JsonPropertyName("GainsMinusExcessOrLossesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GainsMinusExcessOrLossesAmt { get; set; }

    [JsonPropertyName("CostOrOtherBasisAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CostOrOtherBasisAmt { get; set; }
}

public class CapStkTrPrinCurrentFundsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}


public class CashDeemedCharitableGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}

public class CashNonInterestBearingGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class CashSavingsAndInvestmentsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class CollegeUniversityName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }
}

public class CompCurrentOfcrDirectorsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class CompDisqualPersonsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class CompensationHighestPaidEmplGrp
{
    [JsonPropertyName("PersonNm")]
    public string? PersonNm { get; set; }

    [JsonPropertyName("USAddress")] 
    public USAddress USAddress { get; set; }

    [JsonPropertyName("TitleTxt")] 
    public string? TitleTxt { get; set; }

    [JsonPropertyName("AverageHrsPerWkDevotedToPosRt")]
    public string? AverageHrsPerWkDevotedToPosRt { get; set; }

    [JsonPropertyName("CompensationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CompensationAmt { get; set; }

    [JsonPropertyName("EmployeeBenefitsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EmployeeBenefitsAmt { get; set; }

    [JsonPropertyName("ExpenseAccountAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExpenseAccountAmt { get; set; }

    [JsonPropertyName("AverageHoursPerWeekRt")]
    public string? AverageHoursPerWeekRt { get; set; }
}

public class CompensationOfHghstPdCntrctGrp
{
    [JsonPropertyName("BusinessName")]
    public BusinessName BusinessName { get; set; }

    [JsonPropertyName("USAddress")] 
    public USAddress USAddress { get; set; }

    [JsonPropertyName("ServiceTypeTxt")] 
    public string? ServiceTypeTxt { get; set; }

    [JsonPropertyName("CompensationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CompensationAmt { get; set; }

    [JsonPropertyName("ForeignAddress")] 
    public ForeignAddress ForeignAddress { get; set; }

    [JsonPropertyName("PersonNm")] 
    public string? PersonNm { get; set; }
}

public class ConferencesMeetingsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}


public class ContractorAddress
{
    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }
}

public class ContractorBusinessName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }
}

public class ContractorCompensationGrp
{
    [JsonPropertyName("ContractorName")] public ContractorName ContractorName { get; set; }

    [JsonPropertyName("ContractorAddress")]
    public ContractorAddress ContractorAddress { get; set; }

    [JsonPropertyName("ServicesDesc")] public string? ServicesDesc { get; set; }

    [JsonPropertyName("CompensationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CompensationAmt { get; set; }
}

public class ContractorName
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("PersonNm")] public string? PersonNm { get; set; }
}

public class ContributorBusinessName
{
    [JsonPropertyName("BusinessNameLine1")]
    public string? BusinessNameLine1 { get; set; }
}

public class ContributorUSAddress
{
    [JsonPropertyName("AddressLine1")] public string? AddressLine1 { get; set; }

    [JsonPropertyName("AddressLine2")] public string? AddressLine2 { get; set; }

    [JsonPropertyName("City")] public string? City { get; set; }

    [JsonPropertyName("State")] public string? State { get; set; }

    [JsonPropertyName("ZIPCode")] public string? ZIPCode { get; set; }
}

public class DeferredRevenueGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class DepreciationDepletionGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }

    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}
public class DirectControllingEntityName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }
}


public class DisregardedEntityName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }
}

public class DivAndIntFromSecPartVIIGrp
{
    [JsonPropertyName("ExclusionCd")] public string? ExclusionCd { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExclusionAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFunctionIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrExemptFunctionIncmAmt { get; set; }

    [JsonPropertyName("BusinessCd")] public string? BusinessCd { get; set; }

    [JsonPropertyName("UnrelatedBusinessTaxblIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? UnrelatedBusinessTaxblIncmAmt { get; set; }
}

public class DoingBusinessAsName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }

    [JsonPropertyName("BusinessNameLine2Txt")]
    public string? BusinessNameLine2Txt { get; set; }
}

public class DonorRestrictionNetAssetsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class DrugsAndMedicalSuppliesGrp
{
    [JsonPropertyName("NonCashCheckboxInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? NonCashCheckboxInd { get; set; }

    [JsonPropertyName("ContributionCnt")] public string? ContributionCnt { get; set; }

    [JsonPropertyName("NoncashContributionsRptF990Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? NoncashContributionsRptF990Amt { get; set; }

    [JsonPropertyName("MethodOfDeterminingRevenuesTxt")]
    public string? MethodOfDeterminingRevenuesTxt { get; set; }
}

public class EntityName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }
}

public class EscrowAccountLiabilityGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class FeesForServicesAccountingGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class FeesForServicesLegalGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class FeesForServicesLobbyingGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class FeesForServicesManagementGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class FeesForServicesOtherGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class FeesForServicesProfFundraising
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class FeesForSrvcInvstMgmntFeesGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class Filer
{
    [JsonPropertyName("EIN")] 
    public string? EIN { get; set; }

    [JsonPropertyName("BusinessName")] 
    public BusinessName BusinessName { get; set; }

    [JsonPropertyName("BusinessNameControlTxt")]
    public string? BusinessNameControlTxt { get; set; }

    [JsonPropertyName("PhoneNum")] 
    public string? PhoneNum { get; set; }

    [JsonPropertyName("USAddress")] 
    public USAddress USAddress { get; set; }

    [JsonPropertyName("InCareOfNm")] 
    public string? InCareOfNm { get; set; }

    [JsonPropertyName("ForeignAddress")] 
    public ForeignAddress ForeignAddress { get; set; }
}

public class FMVOtherNonExemptUseAssetGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}

public class ForeignAddress
{
    [JsonPropertyName("AddressLine1Txt")] public string? AddressLine1Txt { get; set; }

    [JsonPropertyName("CityNm")] public string? CityNm { get; set; }

    [JsonPropertyName("ProvinceOrStateNm")]
    public string? ProvinceOrStateNm { get; set; }

    [JsonPropertyName("CountryCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))] 
    public List<string> CountryCd { get; set; }

    [JsonPropertyName("ForeignPostalCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))] 
    public List<string> ForeignPostalCd { get; set; }

    [JsonPropertyName("AddressLine2Txt")] public string? AddressLine2Txt { get; set; }
}

public class ForeignGrantsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }
}

public class Form990PartVIISectionAGrp
{
    [JsonPropertyName("PersonNm")] public string? PersonNm { get; set; }

    [JsonPropertyName("TitleTxt")] public string? TitleTxt { get; set; }

    [JsonPropertyName("AverageHoursPerWeekRt")]
    public string? AverageHoursPerWeekRt { get; set; }

    [JsonPropertyName("AverageHoursPerWeekRltdOrgRt")]
    public string? AverageHoursPerWeekRltdOrgRt { get; set; }

    [JsonPropertyName("IndividualTrusteeOrDirectorInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? IndividualTrusteeOrDirectorInd { get; set; }

    [JsonPropertyName("ReportableCompFromOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ReportableCompFromOrgAmt { get; set; }

    [JsonPropertyName("ReportableCompFromRltdOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ReportableCompFromRltdOrgAmt { get; set; }

    [JsonPropertyName("OtherCompensationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OtherCompensationAmt { get; set; }

    [JsonPropertyName("OfficerInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OfficerInd { get; set; }

    [JsonPropertyName("FormerOfcrDirectorTrusteeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FormerOfcrDirectorTrusteeInd { get; set; }

    [JsonPropertyName("KeyEmployeeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? KeyEmployeeInd { get; set; }
}

public class Form990TotalAssetsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class FSAuditedBasisGrp
{
    [JsonPropertyName("SeparateBasisFinclStmtInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SeparateBasisFinclStmtInd { get; set; }

    [JsonPropertyName("ConsolidatedBasisFinclStmtInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ConsolidatedBasisFinclStmtInd { get; set; }

    [JsonPropertyName("ConsolAndSepBasisFinclStmtInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ConsolAndSepBasisFinclStmtInd { get; set; }
}

public class GainOrLossGrp
{
    [JsonPropertyName("SecuritiesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SecuritiesAmt { get; set; }

    [JsonPropertyName("OtherAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OtherAmt { get; set; }
}

public class GainSalesAstOthThanInvntryGrp
{
    [JsonPropertyName("UnrelatedBusinessTaxblIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? UnrelatedBusinessTaxblIncmAmt { get; set; }

    [JsonPropertyName("ExclusionCd")] public string? ExclusionCd { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExclusionAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFunctionIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrExemptFunctionIncmAmt { get; set; }

    [JsonPropertyName("BusinessCd")] public string? BusinessCd { get; set; }
}

public class GrantOrContriApprvForFutGrp
{
    [JsonPropertyName("RecipientPersonNm")]
    public string? RecipientPersonNm { get; set; }

    [JsonPropertyName("RecipientUSAddress")]
    public RecipientUSAddress RecipientUSAddress { get; set; }

    [JsonPropertyName("RecipientRelationshipTxt")]
    public string? RecipientRelationshipTxt { get; set; }

    [JsonPropertyName("GrantOrContributionPurposeTxt")]
    public string? GrantOrContributionPurposeTxt { get; set; }

    [JsonPropertyName("Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Amt { get; set; }
}

public class GrantOrContributionPdDurYrGrp
{
    [JsonPropertyName("RecipientBusinessName")]
    public RecipientBusinessName RecipientBusinessName { get; set; }

    [JsonPropertyName("RecipientUSAddress")]
    public RecipientUSAddress RecipientUSAddress { get; set; }

    [JsonPropertyName("RecipientRelationshipTxt")]
    public string? RecipientRelationshipTxt { get; set; }

    [JsonPropertyName("RecipientFoundationStatusTxt")]
    public string? RecipientFoundationStatusTxt { get; set; }

    [JsonPropertyName("GrantOrContributionPurposeTxt")]
    public string? GrantOrContributionPurposeTxt { get; set; }

    [JsonPropertyName("Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Amt { get; set; }
}

public class GrantsOtherAsstToIndivInUSGrp
{
    [JsonPropertyName("GrantTypeTxt")] public string? GrantTypeTxt { get; set; }

    [JsonPropertyName("RecipientCnt")] public string? RecipientCnt { get; set; }

    [JsonPropertyName("CashGrantAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CashGrantAmt { get; set; }
}

public class GrantsPayableGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class GrantsToDomesticIndividualsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }
}

public class GrantsToDomesticOrgsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }
}

public class GrossAmountSalesAssetsGrp
{
    [JsonPropertyName("SecuritiesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SecuritiesAmt { get; set; }

    [JsonPropertyName("OtherAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OtherAmt { get; set; }
}

public class GrossInvestmentIncomeGrp
{
    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year3Amt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }
}

public class GrossRentsGrp
{
    [JsonPropertyName("RealAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RealAmt { get; set; }

    [JsonPropertyName("PersonalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PersonalAmt { get; set; }
}

public class HospitalFacilityName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }
}

public class IncmFromInvestBondProceedsGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExclusionAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? UnrelatedBusinessRevenueAmt { get; set; }
}

public class InformationTechnologyGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class InsuranceGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class IntangibleAssetsGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }
}

public class InterestGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class InventoriesForSaleOrUseGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }
}

public class InvestmentIncomeGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExclusionAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? UnrelatedBusinessRevenueAmt { get; set; }
}

public class InvestmentsOtherSecuritiesGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }
}

public class InvestmentsProgramRelatedGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }
}

public class InvestmentsPubTradedSecGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }
}

public class IRS990
{
    [JsonPropertyName("GrossReceiptsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GrossReceiptsAmt { get; set; }

    [JsonPropertyName("GroupReturnForAffiliatesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GroupReturnForAffiliatesInd { get; set; }

    [JsonPropertyName("AllAffiliatesIncludedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? AllAffiliatesIncludedInd { get; set; }

    [JsonPropertyName("Organization501cInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Organization501cInd { get; set; }

    [JsonPropertyName("WebsiteAddressTxt")]
    public string? WebsiteAddressTxt { get; set; }

    [JsonPropertyName("TypeOfOrganizationTrustInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TypeOfOrganizationTrustInd { get; set; }

    [JsonPropertyName("FormationYr")] public string? FormationYr { get; set; }

    [JsonPropertyName("LegalDomicileStateCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> LegalDomicileStateCd { get; set; }

    [JsonPropertyName("ActivityOrMissionDesc")]
    public string? ActivityOrMissionDesc { get; set; }

    [JsonPropertyName("VotingMembersGoverningBodyCnt")]
    public string? VotingMembersGoverningBodyCnt { get; set; }

    [JsonPropertyName("VotingMembersIndependentCnt")]
    public string? VotingMembersIndependentCnt { get; set; }

    [JsonPropertyName("TotalEmployeeCnt")] public string? TotalEmployeeCnt { get; set; }

    [JsonPropertyName("TotalGrossUBIAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalGrossUBIAmt { get; set; }

    [JsonPropertyName("CYContributionsGrantsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CYContributionsGrantsAmt { get; set; }

    [JsonPropertyName("PYProgramServiceRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PYProgramServiceRevenueAmt { get; set; }

    [JsonPropertyName("CYProgramServiceRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CYProgramServiceRevenueAmt { get; set; }

    [JsonPropertyName("PYInvestmentIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PYInvestmentIncomeAmt { get; set; }

    [JsonPropertyName("CYInvestmentIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CYInvestmentIncomeAmt { get; set; }

    [JsonPropertyName("CYOtherRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CYOtherRevenueAmt { get; set; }

    [JsonPropertyName("PYTotalRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PYTotalRevenueAmt { get; set; }

    [JsonPropertyName("CYTotalRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CYTotalRevenueAmt { get; set; }

    [JsonPropertyName("CYGrantsAndSimilarPaidAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CYGrantsAndSimilarPaidAmt { get; set; }

    [JsonPropertyName("PYBenefitsPaidToMembersAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PYBenefitsPaidToMembersAmt { get; set; }

    [JsonPropertyName("CYBenefitsPaidToMembersAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CYBenefitsPaidToMembersAmt { get; set; }

    [JsonPropertyName("PYSalariesCompEmpBnftPaidAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PYSalariesCompEmpBnftPaidAmt { get; set; }

    [JsonPropertyName("CYSalariesCompEmpBnftPaidAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CYSalariesCompEmpBnftPaidAmt { get; set; }

    [JsonPropertyName("CYTotalProfFndrsngExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CYTotalProfFndrsngExpnsAmt { get; set; }

    [JsonPropertyName("CYTotalFundraisingExpenseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CYTotalFundraisingExpenseAmt { get; set; }

    [JsonPropertyName("PYOtherExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PYOtherExpensesAmt { get; set; }

    [JsonPropertyName("CYOtherExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CYOtherExpensesAmt { get; set; }

    [JsonPropertyName("PYTotalExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PYTotalExpensesAmt { get; set; }

    [JsonPropertyName("CYTotalExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CYTotalExpensesAmt { get; set; }

    [JsonPropertyName("PYRevenuesLessExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PYRevenuesLessExpensesAmt { get; set; }

    [JsonPropertyName("CYRevenuesLessExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CYRevenuesLessExpensesAmt { get; set; }

    [JsonPropertyName("TotalAssetsBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAssetsBOYAmt { get; set; }

    [JsonPropertyName("TotalAssetsEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAssetsEOYAmt { get; set; }

    [JsonPropertyName("TotalLiabilitiesBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalLiabilitiesBOYAmt { get; set; }

    [JsonPropertyName("TotalLiabilitiesEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalLiabilitiesEOYAmt { get; set; }

    [JsonPropertyName("NetAssetsOrFundBalancesBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? NetAssetsOrFundBalancesBOYAmt { get; set; }

    [JsonPropertyName("NetAssetsOrFundBalancesEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? NetAssetsOrFundBalancesEOYAmt { get; set; }

    [JsonPropertyName("MissionDesc")] public string? MissionDesc { get; set; }

    [JsonPropertyName("SignificantNewProgramSrvcInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SignificantNewProgramSrvcInd { get; set; }

    [JsonPropertyName("SignificantChangeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SignificantChangeInd { get; set; }

    [JsonPropertyName("ExpenseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExpenseAmt { get; set; }

    [JsonPropertyName("Desc")] public string? Desc { get; set; }

    [JsonPropertyName("TotalProgramServiceExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalProgramServiceExpensesAmt { get; set; }

    [JsonPropertyName("DescribedInSection501c3Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string? DescribedInSection501c3Ind { get; set; }

    [JsonPropertyName("ScheduleBRequiredInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ScheduleBRequiredInd { get; set; }

    [JsonPropertyName("PoliticalCampaignActyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PoliticalCampaignActyInd { get; set; }

    [JsonPropertyName("SubjectToProxyTaxInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SubjectToProxyTaxInd { get; set; }

    [JsonPropertyName("DonorAdvisedFundInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? DonorAdvisedFundInd { get; set; }

    [JsonPropertyName("ConservationEasementsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ConservationEasementsInd { get; set; }

    [JsonPropertyName("CollectionsOfArtInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CollectionsOfArtInd { get; set; }

    [JsonPropertyName("CreditCounselingInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CreditCounselingInd { get; set; }

    [JsonPropertyName("TempOrPermanentEndowmentsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TempOrPermanentEndowmentsInd { get; set; }

    [JsonPropertyName("ReportLandBuildingEquipmentInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ReportLandBuildingEquipmentInd { get; set; }

    [JsonPropertyName("ReportInvestmentsOtherSecInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ReportInvestmentsOtherSecInd { get; set; }

    [JsonPropertyName("ReportProgramRelatedInvstInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ReportProgramRelatedInvstInd { get; set; }

    [JsonPropertyName("ReportOtherAssetsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ReportOtherAssetsInd { get; set; }

    [JsonPropertyName("ReportOtherLiabilitiesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ReportOtherLiabilitiesInd { get; set; }

    [JsonPropertyName("IncludeFIN48FootnoteInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? IncludeFIN48FootnoteInd { get; set; }

    [JsonPropertyName("IndependentAuditFinclStmtInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? IndependentAuditFinclStmtInd { get; set; }

    [JsonPropertyName("ConsolidatedAuditFinclStmtInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ConsolidatedAuditFinclStmtInd { get; set; }

    [JsonPropertyName("SchoolOperatingInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SchoolOperatingInd { get; set; }

    [JsonPropertyName("ForeignOfficeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ForeignOfficeInd { get; set; }

    [JsonPropertyName("ForeignActivitiesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ForeignActivitiesInd { get; set; }

    [JsonPropertyName("MoreThan5000KToOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? MoreThan5000KToOrgInd { get; set; }

    [JsonPropertyName("MoreThan5000KToIndividualsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? MoreThan5000KToIndividualsInd { get; set; }

    [JsonPropertyName("ProfessionalFundraisingInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProfessionalFundraisingInd { get; set; }

    [JsonPropertyName("FundraisingActivitiesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingActivitiesInd { get; set; }

    [JsonPropertyName("GamingActivitiesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GamingActivitiesInd { get; set; }

    [JsonPropertyName("OperateHospitalInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OperateHospitalInd { get; set; }

    [JsonPropertyName("GrantsToOrganizationsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GrantsToOrganizationsInd { get; set; }

    [JsonPropertyName("GrantsToIndividualsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GrantsToIndividualsInd { get; set; }

    [JsonPropertyName("ScheduleJRequiredInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ScheduleJRequiredInd { get; set; }

    [JsonPropertyName("TaxExemptBondsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TaxExemptBondsInd { get; set; }

    [JsonPropertyName("InvestTaxExemptBondsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InvestTaxExemptBondsInd { get; set; }

    [JsonPropertyName("EscrowAccountInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EscrowAccountInd { get; set; }

    [JsonPropertyName("OnBehalfOfIssuerInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OnBehalfOfIssuerInd { get; set; }

    [JsonPropertyName("LoanOutstandingInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? LoanOutstandingInd { get; set; }

    [JsonPropertyName("GrantToRelatedPersonInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GrantToRelatedPersonInd { get; set; }

    [JsonPropertyName("BusinessRlnWithOrgMemInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BusinessRlnWithOrgMemInd { get; set; }

    [JsonPropertyName("BusinessRlnWithFamMemInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BusinessRlnWithFamMemInd { get; set; }

    [JsonPropertyName("BusinessRlnWithOfficerEntInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BusinessRlnWithOfficerEntInd { get; set; }

    [JsonPropertyName("DeductibleNonCashContriInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? DeductibleNonCashContriInd { get; set; }

    [JsonPropertyName("DeductibleArtContributionInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? DeductibleArtContributionInd { get; set; }

    [JsonPropertyName("TerminateOperationsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TerminateOperationsInd { get; set; }

    [JsonPropertyName("PartialLiquidationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PartialLiquidationInd { get; set; }

    [JsonPropertyName("DisregardedEntityInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? DisregardedEntityInd { get; set; }

    [JsonPropertyName("RelatedEntityInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedEntityInd { get; set; }

    [JsonPropertyName("RelatedOrganizationCtrlEntInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrganizationCtrlEntInd { get; set; }

    [JsonPropertyName("ActivitiesConductedPrtshpInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ActivitiesConductedPrtshpInd { get; set; }

    [JsonPropertyName("ScheduleORequiredInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ScheduleORequiredInd { get; set; }

    [JsonPropertyName("IRPDocumentCnt")] public string? IRPDocumentCnt { get; set; }

    [JsonPropertyName("IRPDocumentW2GCnt")]
    public string? IRPDocumentW2GCnt { get; set; }

    [JsonPropertyName("BackupWthldComplianceInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BackupWthldComplianceInd { get; set; }

    [JsonPropertyName("EmployeeCnt")] public string? EmployeeCnt { get; set; }

    [JsonPropertyName("EmploymentTaxReturnsFiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EmploymentTaxReturnsFiledInd { get; set; }

    [JsonPropertyName("UnrelatedBusIncmOverLimitInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? UnrelatedBusIncmOverLimitInd { get; set; }

    [JsonPropertyName("Form990TFiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Form990TFiledInd { get; set; }

    [JsonPropertyName("ForeignFinancialAccountInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ForeignFinancialAccountInd { get; set; }

    [JsonPropertyName("ProhibitedTaxShelterTransInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProhibitedTaxShelterTransInd { get; set; }

    [JsonPropertyName("TaxablePartyNotificationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TaxablePartyNotificationInd { get; set; }

    [JsonPropertyName("NondeductibleContributionsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? NondeductibleContributionsInd { get; set; }

    [JsonPropertyName("DAFExcessBusinessHoldingsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? DAFExcessBusinessHoldingsInd { get; set; }

    [JsonPropertyName("TaxableDistributionsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TaxableDistributionsInd { get; set; }

    [JsonPropertyName("DistributionToDonorInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? DistributionToDonorInd { get; set; }

    [JsonPropertyName("OrgFiledInLieuOfForm1041Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OrgFiledInLieuOfForm1041Ind { get; set; }

    [JsonPropertyName("LicensedMoreThanOneStateInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? LicensedMoreThanOneStateInd { get; set; }

    [JsonPropertyName("IndoorTanningServicesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? IndoorTanningServicesInd { get; set; }

    [JsonPropertyName("InfoInScheduleOPartVIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InfoInScheduleOPartVIInd { get; set; }

    [JsonPropertyName("GoverningBodyVotingMembersCnt")]
    public string? GoverningBodyVotingMembersCnt { get; set; }

    [JsonPropertyName("IndependentVotingMemberCnt")]
    public string? IndependentVotingMemberCnt { get; set; }

    [JsonPropertyName("FamilyOrBusinessRlnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FamilyOrBusinessRlnInd { get; set; }

    [JsonPropertyName("DelegationOfMgmtDutiesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? DelegationOfMgmtDutiesInd { get; set; }

    [JsonPropertyName("ChangeToOrgDocumentsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ChangeToOrgDocumentsInd { get; set; }

    [JsonPropertyName("MaterialDiversionOrMisuseInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? MaterialDiversionOrMisuseInd { get; set; }

    [JsonPropertyName("MembersOrStockholdersInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? MembersOrStockholdersInd { get; set; }

    [JsonPropertyName("ElectionOfBoardMembersInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ElectionOfBoardMembersInd { get; set; }

    [JsonPropertyName("DecisionsSubjectToApprovaInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? DecisionsSubjectToApprovaInd { get; set; }

    [JsonPropertyName("MinutesOfGoverningBodyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? MinutesOfGoverningBodyInd { get; set; }

    [JsonPropertyName("MinutesOfCommitteesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? MinutesOfCommitteesInd { get; set; }

    [JsonPropertyName("OfficerMailingAddressInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OfficerMailingAddressInd { get; set; }

    [JsonPropertyName("LocalChaptersInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? LocalChaptersInd { get; set; }

    [JsonPropertyName("Form990ProvidedToGvrnBodyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Form990ProvidedToGvrnBodyInd { get; set; }

    [JsonPropertyName("ConflictOfInterestPolicyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ConflictOfInterestPolicyInd { get; set; }

    [JsonPropertyName("AnnualDisclosureCoveredPrsnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? AnnualDisclosureCoveredPrsnInd { get; set; }

    [JsonPropertyName("RegularMonitoringEnfrcInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RegularMonitoringEnfrcInd { get; set; }

    [JsonPropertyName("WhistleblowerPolicyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? WhistleblowerPolicyInd { get; set; }

    [JsonPropertyName("DocumentRetentionPolicyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? DocumentRetentionPolicyInd { get; set; }

    [JsonPropertyName("CompensationProcessCEOInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CompensationProcessCEOInd { get; set; }

    [JsonPropertyName("CompensationProcessOtherInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CompensationProcessOtherInd { get; set; }

    [JsonPropertyName("InvestmentInJointVentureInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InvestmentInJointVentureInd { get; set; }

    [JsonPropertyName("OwnWebsiteInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OwnWebsiteInd { get; set; }

    [JsonPropertyName("UponRequestInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? UponRequestInd { get; set; }

    [JsonPropertyName("BooksInCareOfDetail")]
    public BooksInCareOfDetail BooksInCareOfDetail { get; set; }

    [JsonPropertyName("Form990PartVIISectionAGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<Form990PartVIISectionAGrp>))]
    public List<Form990PartVIISectionAGrp> Form990PartVIISectionAGrp { get; set; }

    [JsonPropertyName("TotalReportableCompFromOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalReportableCompFromOrgAmt { get; set; }

    [JsonPropertyName("IndivRcvdGreaterThan100KCnt")]
    public string? IndivRcvdGreaterThan100KCnt { get; set; }

    [JsonPropertyName("FormerOfcrEmployeesListedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FormerOfcrEmployeesListedInd { get; set; }

    [JsonPropertyName("TotalCompGreaterThan150KInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalCompGreaterThan150KInd { get; set; }

    [JsonPropertyName("CompensationFromOtherSrcsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CompensationFromOtherSrcsInd { get; set; }

    [JsonPropertyName("CntrctRcvdGreaterThan100KCnt")]
    public string? CntrctRcvdGreaterThan100KCnt { get; set; }

    [JsonPropertyName("TotalContributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalContributionsAmt { get; set; }

    [JsonPropertyName("ProgramServiceRevenueGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<ProgramServiceRevenueGrp>))]
    public List<ProgramServiceRevenueGrp> ProgramServiceRevenueGrp { get; set; }

    [JsonPropertyName("TotalProgramServiceRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalProgramServiceRevenueAmt { get; set; }

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
    public string? OtherRevenueTotalAmt { get; set; }

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
    public string? LandBldgEquipCostOrOtherBssAmt { get; set; }

    [JsonPropertyName("LandBldgEquipAccumDeprecAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? LandBldgEquipAccumDeprecAmt { get; set; }

    [JsonPropertyName("LandBldgEquipBasisNetGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<LandBldgEquipBasisNetGrp>))]

    public List<LandBldgEquipBasisNetGrp> LandBldgEquipBasisNetGrp { get; set; }

    [JsonPropertyName("InvestmentsPubTradedSecGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<InvestmentsPubTradedSecGrp>))]
    public List<InvestmentsPubTradedSecGrp> InvestmentsPubTradedSecGrp { get; set; }

    [JsonPropertyName("InvestmentsOtherSecuritiesGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<InvestmentsOtherSecuritiesGrp>))]
    public List<InvestmentsOtherSecuritiesGrp> InvestmentsOtherSecuritiesGrp { get; set; }

    [JsonPropertyName("InvestmentsProgramRelatedGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<InvestmentsProgramRelatedGrp>))]
    public List<InvestmentsProgramRelatedGrp> InvestmentsProgramRelatedGrp { get; set; }

    [JsonPropertyName("IntangibleAssetsGrp"), JsonConverter(typeof(SingleOrArrayConverter<IntangibleAssetsGrp>))]
    public List<IntangibleAssetsGrp> IntangibleAssetsGrp { get; set; }

    [JsonPropertyName("OtherAssetsTotalGrp"), JsonConverter(typeof(SingleOrArrayConverter<OtherAssetsTotalGrp>))]
    public List<OtherAssetsTotalGrp> OtherAssetsTotalGrp { get; set; }

    [JsonPropertyName("TotalAssetsGrp"), JsonConverter(typeof(SingleOrArrayConverter<TotalAssetsGrp>))]
    public List<TotalAssetsGrp> TotalAssetsGrp { get; set; }

    [JsonPropertyName("OtherLiabilitiesGrp"), JsonConverter(typeof(SingleOrArrayConverter<OtherLiabilitiesGrp>))]
    public List<OtherLiabilitiesGrp> OtherLiabilitiesGrp { get; set; }

    [JsonPropertyName("TotalLiabilitiesGrp"), JsonConverter(typeof(SingleOrArrayConverter<TotalLiabilitiesGrp>))]
    public List<TotalLiabilitiesGrp> TotalLiabilitiesGrp { get; set; }

    [JsonPropertyName("OrganizationFollowsSFAS117Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OrganizationFollowsSFAS117Ind { get; set; }

    [JsonPropertyName("UnrestrictedNetAssetsGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<UnrestrictedNetAssetsGrp>))]
    public List<UnrestrictedNetAssetsGrp> UnrestrictedNetAssetsGrp { get; set; }

    [JsonPropertyName("TotalNetAssetsFundBalanceGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<TotalNetAssetsFundBalanceGrp>))]
    public List<TotalNetAssetsFundBalanceGrp> TotalNetAssetsFundBalanceGrp { get; set; }

    [JsonPropertyName("TotLiabNetAssetsFundBalanceGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<TotLiabNetAssetsFundBalanceGrp>))]
    public List<TotLiabNetAssetsFundBalanceGrp> TotLiabNetAssetsFundBalanceGrp { get; set; }

    [JsonPropertyName("ReconcilationRevenueExpnssAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ReconcilationRevenueExpnssAmt { get; set; }

    [JsonPropertyName("MethodOfAccountingAccrualInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? MethodOfAccountingAccrualInd { get; set; }

    [JsonPropertyName("AccountantCompileOrReviewInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? AccountantCompileOrReviewInd { get; set; }

    [JsonPropertyName("FSAuditedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FSAuditedInd { get; set; }

    [JsonPropertyName("FSAuditedBasisGrp"), JsonConverter(typeof(SingleOrArrayConverter<FSAuditedBasisGrp>))]
    public List<FSAuditedBasisGrp> FSAuditedBasisGrp { get; set; }

    [JsonPropertyName("AuditCommitteeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? AuditCommitteeInd { get; set; }

    [JsonPropertyName("FederalGrantAuditRequiredInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FederalGrantAuditRequiredInd { get; set; }

    [JsonPropertyName("PrincipalOfficerNm")]
    public string? PrincipalOfficerNm { get; set; }

    [JsonPropertyName("TypeOfOrganizationAssocInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TypeOfOrganizationAssocInd { get; set; }

    [JsonPropertyName("TotalVolunteersCnt")]
    public string? TotalVolunteersCnt { get; set; }

    [JsonPropertyName("NetUnrelatedBusTxblIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? NetUnrelatedBusTxblIncmAmt { get; set; }

    [JsonPropertyName("PYContributionsGrantsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PYContributionsGrantsAmt { get; set; }

    [JsonPropertyName("PYOtherRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PYOtherRevenueAmt { get; set; }

    [JsonPropertyName("PYGrantsAndSimilarPaidAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PYGrantsAndSimilarPaidAmt { get; set; }

    [JsonPropertyName("GrantAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GrantAmt { get; set; }

    [JsonPropertyName("RevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RevenueAmt { get; set; }

    [JsonPropertyName("TransactionWithControlEntInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TransactionWithControlEntInd { get; set; }

    [JsonPropertyName("QuidProQuoContributionsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? QuidProQuoContributionsInd { get; set; }

    [JsonPropertyName("Form8282PropertyDisposedOfInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Form8282PropertyDisposedOfInd { get; set; }

    [JsonPropertyName("RcvFndsToPayPrsnlBnftCntrctInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RcvFndsToPayPrsnlBnftCntrctInd { get; set; }

    [JsonPropertyName("PayPremiumsPrsnlBnftCntrctInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PayPremiumsPrsnlBnftCntrctInd { get; set; }

    [JsonPropertyName("Form8899FiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Form8899Filedind { get; set; }

    [JsonPropertyName("Form1098CFiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Form1098CFiledInd { get; set; }

    [JsonPropertyName("InitiationFeesAndCapContriAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InitiationFeesAndCapContriAmt { get; set; }

    [JsonPropertyName("GrossReceiptsForPublicUseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GrossReceiptsForPublicUseAmt { get; set; }

    
    [JsonPropertyName("StatesWhereCopyOfReturnIsFldCd"), JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> StatesWhereCopyOfReturnIsFldCd { get; set; }

    [JsonPropertyName("OtherInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OtherInd { get; set; }

    [JsonPropertyName("NoListedPersonsCompensatedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? NoListedPersonsCompensatedInd { get; set; }

    [JsonPropertyName("TotReportableCompRltdOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotReportableCompRltdOrgAmt { get; set; }

    [JsonPropertyName("TotalOtherCompensationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalOtherCompensationAmt { get; set; }

    [JsonPropertyName("MembershipDuesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? MembershipDuesAmt { get; set; }

    [JsonPropertyName("GrossRentsGrp"), JsonConverter(typeof(SingleOrArrayConverter<GrossRentsGrp>))]
    public List<GrossRentsGrp> GrossRentsGrp { get; set; }

    [JsonPropertyName("LessRentalExpensesGrp"), JsonConverter(typeof(SingleOrArrayConverter<LessRentalExpensesGrp>))]
    public List<LessRentalExpensesGrp> LessRentalExpensesGrp { get; set; }

    [JsonPropertyName("GamingGrossIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GamingGrossIncomeAmt { get; set; }

    [JsonPropertyName("GamingDirectExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GamingDirectExpensesAmt { get; set; }

    [JsonPropertyName("GrossSalesOfInventoryAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GrossSalesOfInventoryAmt { get; set; }

    [JsonPropertyName("CostOfGoodsSoldAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CostOfGoodsSoldAmt { get; set; }

    [JsonPropertyName("AccountsPayableAccrExpnssGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<AccountsPayableAccrExpnssGrp>))]
    public List<AccountsPayableAccrExpnssGrp> AccountsPayableAccrExpnssGrp { get; set; }

    [JsonPropertyName("OrgDoesNotFollowSFAS117Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OrgDoesNotFollowSFAS117Ind { get; set; }

    [JsonPropertyName("PdInCapSrplsLandBldgEqpFundGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<PdInCapSrplsLandBldgEqpFundGrp>))]
    public List<PdInCapSrplsLandBldgEqpFundGrp> PdInCapSrplsLandBldgEqpFundGrp { get; set; }

    [JsonPropertyName("OtherChangesInNetAssetsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OtherChangesInNetAssetsAmt { get; set; }

    [JsonPropertyName("MethodOfAccountingCashInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? MethodOfAccountingCashInd { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("Organization501c3Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Organization501c3Ind { get; set; }

    [JsonPropertyName("TypeOfOrganizationCorpInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TypeOfOrganizationCorpInd { get; set; }

    [JsonPropertyName("PYTotalProfFndrsngExpnsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PYTotalProfFndrsngExpnsAmt { get; set; }

    [JsonPropertyName("InfoInScheduleOPartIIIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InfoInScheduleOPartIIIInd { get; set; }

    [JsonPropertyName("ProgSrvcAccomActy2Grp"), JsonConverter(typeof(SingleOrArrayConverter<ProgSrvcAccomActy2Grp>))]
    public List<ProgSrvcAccomActy2Grp> ProgSrvcAccomActy2Grp { get; set; }

    [JsonPropertyName("ProgSrvcAccomActy3Grp"), JsonConverter(typeof(SingleOrArrayConverter<ProgSrvcAccomActy3Grp>))]
    public List<ProgSrvcAccomActy3Grp> ProgSrvcAccomActy3Grp { get; set; }

    [JsonPropertyName("LobbyingActivitiesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? LobbyingActivitiesInd { get; set; }

    [JsonPropertyName("EngagedInExcessBenefitTransInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EngagedInExcessBenefitTransInd { get; set; }

    [JsonPropertyName("PYExcessBenefitTransInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PYExcessBenefitTransInd { get; set; }

    [JsonPropertyName("TrnsfrExmptNonChrtblRltdOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TrnsfrExmptNonChrtblRltdOrgInd { get; set; }

    [JsonPropertyName("InfoInScheduleOPartVIIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InfoInScheduleOPartVIIInd { get; set; }

    [JsonPropertyName("GovernmentGrantsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GovernmentGrantsAmt { get; set; }

    [JsonPropertyName("AllOtherContributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? AllOtherContributionsAmt { get; set; }

    [JsonPropertyName("RentalIncomeOrLossGrp"), JsonConverter(typeof(SingleOrArrayConverter<RentalIncomeOrLossGrp>))]
    public List<RentalIncomeOrLossGrp> RentalIncomeOrLossGrp { get; set; }

    [JsonPropertyName("OtherRevenueMiscGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<OtherRevenueMiscGrp>))]
    public List<OtherRevenueMiscGrp> OtherRevenueMiscGrp { get; set; }

    [JsonPropertyName("TemporarilyRstrNetAssetsGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<TemporarilyRstrNetAssetsGrp>))]
    public List<TemporarilyRstrNetAssetsGrp> TemporarilyRstrNetAssetsGrp { get; set; }

    [JsonPropertyName("Form8282FiledCnt")] public string? Form8282FiledCnt { get; set; }

    [JsonPropertyName("LoansFromOfficersDirectorsGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<LoansFromOfficersDirectorsGrp>))]
    public List<LoansFromOfficersDirectorsGrp> LoansFromOfficersDirectorsGrp { get; set; }

    [JsonPropertyName("FederalGrantAuditPerformedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FederalGrantAuditPerformedInd { get; set; }

    [JsonPropertyName("FundraisingGrossIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingGrossIncomeAmt { get; set; }

    [JsonPropertyName("FundraisingDirectExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingDirectExpensesAmt { get; set; }

    [JsonPropertyName("GrantsPayableGrp"), JsonConverter(typeof(SingleOrArrayConverter<GrantsPayableGrp>))]
    public List<GrantsPayableGrp> GrantsPayableGrp { get; set; }

    [JsonPropertyName("DeferredRevenueGrp"), JsonConverter(typeof(SingleOrArrayConverter<DeferredRevenueGrp>))]
    public List<DeferredRevenueGrp> DeferredRevenueGrp { get; set; }

    [JsonPropertyName("TaxExemptBondLiabilitiesGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<TaxExemptBondLiabilitiesGrp>))]
    public List<TaxExemptBondLiabilitiesGrp> TaxExemptBondLiabilitiesGrp { get; set; }

    [JsonPropertyName("EscrowAccountLiabilityGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<EscrowAccountLiabilityGrp>))]
    public List<EscrowAccountLiabilityGrp> EscrowAccountLiabilityGrp { get; set; }

    [JsonPropertyName("MortgNotesPyblScrdInvstPropGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<MortgNotesPyblScrdInvstPropGrp>))]
    public List<MortgNotesPyblScrdInvstPropGrp> MortgNotesPyblScrdInvstPropGrp { get; set; }

    [JsonPropertyName("UnsecuredNotesLoansPayableGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<UnsecuredNotesLoansPayableGrp>))]
    public List<UnsecuredNotesLoansPayableGrp> UnsecuredNotesLoansPayableGrp { get; set; }

    [JsonPropertyName("CapStkTrPrinCurrentFundsGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<CapStkTrPrinCurrentFundsGrp>))]
    public List<CapStkTrPrinCurrentFundsGrp> CapStkTrPrinCurrentFundsGrp { get; set; }

    [JsonPropertyName("RtnEarnEndowmentIncmOthFndsGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<RtnEarnEndowmentIncmOthFndsGrp>))]
    public List<RtnEarnEndowmentIncmOthFndsGrp> RtnEarnEndowmentIncmOthFndsGrp { get; set; }

    [JsonPropertyName("PriorPeriodAdjustmentsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorPeriodAdjustmentsAmt { get; set; }

    [JsonPropertyName("AddressChangeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? AddressChangeInd { get; set; }

    [JsonPropertyName("Form8886TFiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Form8886TFiledInd { get; set; }

    [JsonPropertyName("NondeductibleContriDisclInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? NondeductibleContriDisclInd { get; set; }

    [JsonPropertyName("QuidProQuoContriDisclInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? QuidProQuoContriDisclInd { get; set; }

    [JsonPropertyName("PoliciesReferenceChaptersInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PoliciesReferenceChaptersInd { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }

    [JsonPropertyName("NoncashContributionsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? NoncashContributionsAmt { get; set; }

    [JsonPropertyName("GrossAmountSalesAssetsGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<GrossAmountSalesAssetsGrp>))]
    public List<GrossAmountSalesAssetsGrp> GrossAmountSalesAssetsGrp { get; set; }

    [JsonPropertyName("LessCostOthBasisSalesExpnssGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<LessCostOthBasisSalesExpnssGrp>))]
    public List<LessCostOthBasisSalesExpnssGrp> LessCostOthBasisSalesExpnssGrp { get; set; }

    [JsonPropertyName("GainOrLossGrp"), JsonConverter(typeof(SingleOrArrayConverter<GainOrLossGrp>))]
    public List<GainOrLossGrp> GainOrLossGrp { get; set; }

    [JsonPropertyName("ContriRptFundraisingEventAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ContriRptFundraisingEventAmt { get; set; }

    [JsonPropertyName("NetUnrlzdGainsLossesInvstAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? NetUnrlzdGainsLossesInvstAmt { get; set; }

    [JsonPropertyName("InfoInScheduleOPartXIIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InfoInScheduleOPartXIIInd { get; set; }

    [JsonPropertyName("InfoInScheduleOPartIXInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InfoInScheduleOPartIXInd { get; set; }

    [JsonPropertyName("AcctCompileOrReviewBasisGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<AcctCompileOrReviewBasisGrp>))]
    public List<AcctCompileOrReviewBasisGrp> AcctCompileOrReviewBasisGrp { get; set; }

    [JsonPropertyName("ContractorCompensationGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<ContractorCompensationGrp>))]
    public List<ContractorCompensationGrp> ContractorCompensationGrp { get; set; }

    [JsonPropertyName("RelatedOrganizationsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrganizationsAmt { get; set; }

    [JsonPropertyName("PermanentlyRstrNetAssetsGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<PermanentlyRstrNetAssetsGrp>))]
    public List<PermanentlyRstrNetAssetsGrp> PermanentlyRstrNetAssetsGrp { get; set; }

    [JsonPropertyName("ProgSrvcAccomActyOtherGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<ProgSrvcAccomActyOtherGrp>))]
    public List<ProgSrvcAccomActyOtherGrp> ProgSrvcAccomActyOtherGrp { get; set; }

    [JsonPropertyName("InfoInScheduleOPartVInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InfoInScheduleOPartVInd { get; set; }

    [JsonPropertyName("TotalOthProgramServiceRevGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<TotalOthProgramServiceRevGrp>))]
    public List<TotalOthProgramServiceRevGrp> TotalOthProgramServiceRevGrp { get; set; }

    [JsonPropertyName("GroupExemptionNum")]
    public string? GroupExemptionNum { get; set; }

    [JsonPropertyName("TotalOtherProgSrvcExpenseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalOtherProgSrvcExpenseAmt { get; set; }

    [JsonPropertyName("TotalOtherProgSrvcRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalOtherProgSrvcRevenueAmt { get; set; }

    [JsonPropertyName("InfoInScheduleOPartXIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InfoInScheduleOPartXIInd { get; set; }

    [JsonPropertyName("TotalOtherProgSrvcGrantAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalOtherProgSrvcGrantAmt { get; set; }

    [JsonPropertyName("FederatedCampaignsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FederatedCampaignsAmt { get; set; }

    [JsonPropertyName("DonatedServicesAndUseFcltsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? DonatedServicesAndUseFcltsAmt { get; set; }

    [JsonPropertyName("InvestmentExpenseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InvestmentExpenseAmt { get; set; }

    [JsonPropertyName("OtherWebsiteInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OtherWebsiteInd { get; set; }

    [JsonPropertyName("DoingBusinessAsName")]
    public DoingBusinessAsName DoingBusinessAsName { get; set; }

    [JsonPropertyName("ForeignCountryCd")]
    [JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> ForeignCountryCd { get; set; }


    [JsonPropertyName("TypeOfOrganizationOtherInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TypeOfOrganizationOtherInd { get; set; }

    [JsonPropertyName("OtherOrganizationDsc")]
    public string? OtherOrganizationDsc { get; set; }

    [JsonPropertyName("MiscellaneousRevenueGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<MiscellaneousRevenueGrp>))]
    public List<MiscellaneousRevenueGrp> MiscellaneousRevenueGrp { get; set; }

    [JsonPropertyName("MethodOfAccountingOtherInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? MethodOfAccountingOtherInd { get; set; }

    [JsonPropertyName("WrittenPolicyOrProcedureInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? WrittenPolicyOrProcedureInd { get; set; }

    [JsonPropertyName("InfoInScheduleOPartXInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InfoInScheduleOPartXInd { get; set; }

    [JsonPropertyName("JointCostsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? JointCostsInd { get; set; }

    [JsonPropertyName("TotalJointCostsGrp"), JsonConverter(typeof(SingleOrArrayConverter<TotalJointCostsGrp>))]
    public List<TotalJointCostsGrp> TotalJointCostsGrp { get; set; }

    [JsonPropertyName("SubjToTaxRmnrtnExPrchtPymtInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SubjToTaxRmnrtnExPrchtPymtInd { get; set; }

    [JsonPropertyName("SubjectToExcsTaxNetInvstIncInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SubjectToExcsTaxNetInvstIncInd { get; set; }

    [JsonPropertyName("MembersAndShrGrossIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? MembersAndShrGrossIncomeAmt { get; set; }

    [JsonPropertyName("OtherSourcesGrossIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OtherSourcesGrossIncomeAmt { get; set; }

    [JsonPropertyName("PrincipalOfcrBusinessName")]
    public PrincipalOfcrBusinessName PrincipalOfcrBusinessName { get; set; }

    [JsonPropertyName("AmendedReturnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? AmendedReturnInd { get; set; }

    [JsonPropertyName("InitialReturnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InitialReturnInd { get; set; }

    [JsonPropertyName("InfoInScheduleOPartVIIIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InfoInScheduleOPartVIIIInd { get; set; }

    [JsonPropertyName("Form720FiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Form720FiledInd { get; set; }

    [JsonPropertyName("FinalReturnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FinalReturnInd { get; set; }

    [JsonPropertyName("ContractTerminationInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ContractTerminationInd { get; set; }

    [JsonPropertyName("AuditedFinancialStmtAttInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? AuditedFinancialStmtAttInd { get; set; }

    [JsonPropertyName("ForeignAddress")] public ForeignAddress ForeignAddress { get; set; }

    [JsonPropertyName("TaxExemptInterestAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TaxExemptInterestAmt { get; set; }

    [JsonPropertyName("ActivityCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))] 
    public List<string> ActivityCd { get; set; }

    [JsonPropertyName("DonorRstrOrQuasiEndowmentsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? DonorRstrOrQuasiEndowmentsInd { get; set; }

    [JsonPropertyName("BusinessRlnWith35CtrlEntInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BusinessRlnWith35CtrlEntInd { get; set; }

    [JsonPropertyName("OrganizationFollowsFASB117Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OrganizationFollowsFASB117Ind { get; set; }

    [JsonPropertyName("NoDonorRestrictionNetAssetsGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<NoDonorRestrictionNetAssetsGrp>))]
    public List<NoDonorRestrictionNetAssetsGrp> NoDonorRestrictionNetAssetsGrp { get; set; }

    [JsonPropertyName("Organization4947a1NotPFInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Organization4947a1NotPFInd { get; set; }

    [JsonPropertyName("LegalDomicileCountryCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> LegalDomicileCountryCd { get; set; }

    [JsonPropertyName("SpecialConditionDesc"),JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> SpecialConditionDesc { get; set; }

    [JsonPropertyName("DonorRestrictionNetAssetsGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<DonorRestrictionNetAssetsGrp>))]
    public List<DonorRestrictionNetAssetsGrp> DonorRestrictionNetAssetsGrp { get; set; }

    [JsonPropertyName("OrgDoesNotFollowFASB117Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OrgDoesNotFollowFASB117Ind { get; set; }

    [JsonPropertyName("StateRequiredReservesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? StateRequiredReservesAmt { get; set; }

    [JsonPropertyName("ReservesMaintainedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ReservesMaintainedAmt { get; set; }
}

public class IRS990EZ
{
    [JsonPropertyName("MethodOfAccountingCashInd")
     , JsonConverter(typeof(FixScrewedUpString))]
    public string? MethodOfAccountingCashInd { get; set; }

    [JsonPropertyName("WebsiteAddressTxt")]
    public string? WebsiteAddressTxt { get; set; }

    [JsonPropertyName("Organization501c3Ind"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Organization501c3Ind { get; set; }

    [JsonPropertyName("TypeOfOrganizationCorpInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TypeOfOrganizationCorpInd { get; set; }

    [JsonPropertyName("GrossReceiptsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GrossReceiptsAmt { get; set; }

    [JsonPropertyName("InfoInScheduleOPartIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InfoInScheduleOPartIInd { get; set; }

    [JsonPropertyName("ContributionsGiftsGrantsEtcAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ContributionsGiftsGrantsEtcAmt { get; set; }

    [JsonPropertyName("ProgramServiceRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServiceRevenueAmt { get; set; }

    [JsonPropertyName("MembershipDuesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? MembershipDuesAmt { get; set; }

    [JsonPropertyName("FundraisingGrossIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingGrossIncomeAmt { get; set; }

    [JsonPropertyName("SpecialEventsDirectExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SpecialEventsDirectExpensesAmt { get; set; }

    [JsonPropertyName("SpecialEventsNetIncomeLossAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SpecialEventsNetIncomeLossAmt { get; set; }

    [JsonPropertyName("TotalRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalRevenueAmt { get; set; }

    [JsonPropertyName("FeesAndOtherPymtToIndCntrctAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FeesAndOtherPymtToIndCntrctAmt { get; set; }

    [JsonPropertyName("PrintingPublicationsPostageAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PrintingPublicationsPostageAmt { get; set; }

    [JsonPropertyName("OtherExpensesTotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OtherExpensesTotalAmt { get; set; }

    [JsonPropertyName("TotalExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalExpensesAmt { get; set; }

    [JsonPropertyName("ExcessOrDeficitForYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExcessOrDeficitForYearAmt { get; set; }

    [JsonPropertyName("NetAssetsOrFundBalancesBOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? NetAssetsOrFundBalancesBOYAmt { get; set; }

    [JsonPropertyName("OtherChangesInNetAssetsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OtherChangesInNetAssetsAmt { get; set; }

    [JsonPropertyName("NetAssetsOrFundBalancesEOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? NetAssetsOrFundBalancesEOYAmt { get; set; }

    [JsonPropertyName("InfoInScheduleOPartIIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InfoInScheduleOPartIIInd { get; set; }

    [JsonPropertyName("CashSavingsAndInvestmentsGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<CashSavingsAndInvestmentsGrp>))]
    public List<CashSavingsAndInvestmentsGrp> CashSavingsAndInvestmentsGrp { get; set; }

    [JsonPropertyName("Form990TotalAssetsGrp"), JsonConverter(typeof(SingleOrArrayConverter<Form990TotalAssetsGrp>))]
    public List<Form990TotalAssetsGrp> Form990TotalAssetsGrp { get; set; }

    [JsonPropertyName("SumOfTotalLiabilitiesGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<SumOfTotalLiabilitiesGrp>))]
    public List<SumOfTotalLiabilitiesGrp> SumOfTotalLiabilitiesGrp { get; set; }

    [JsonPropertyName("NetAssetsOrFundBalancesGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<NetAssetsOrFundBalancesGrp>))]
    public List<NetAssetsOrFundBalancesGrp> NetAssetsOrFundBalancesGrp { get; set; }

    [JsonPropertyName("InfoInScheduleOPartIIIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InfoInScheduleOPartIIIInd { get; set; }

    [JsonPropertyName("PrimaryExemptPurposeTxt")]
    public string? PrimaryExemptPurposeTxt { get; set; }

    [JsonPropertyName("ProgramSrvcAccomplishmentGrp"),
     JsonConverter(typeof(SingleOrArrayConverter<ProgramSrvcAccomplishmentGrp>))]
    public List<ProgramSrvcAccomplishmentGrp> ProgramSrvcAccomplishmentGrp { get; set; }

    [JsonPropertyName("TotalProgramServiceExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalProgramServiceExpensesAmt { get; set; }

    // [JsonPropertyName("OfficerDirectorTrusteeEmplGrp")]
    // [JsonConverter(typeof(SingleOrArrayConverter<OfficerDirectorTrusteeEmplGrp>))]
    // public List<OfficerDirectorTrusteeEmplGrp> OfficerDirectorTrusteeEmplGrp { get; set; }

    [JsonPropertyName("OfficerDirectorTrusteeEmplGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> OfficerDirectorTrusteeEmplGrp { get; set; }
    
    [JsonPropertyName("InfoInScheduleOPartVInd")
     , JsonConverter(typeof(FixScrewedUpString))]
    public string? InfoInScheduleOPartVInd { get; set; }

    [JsonPropertyName("ActivitiesNotPreviouslyRptInd")
     , JsonConverter(typeof(FixScrewedUpString))]
    public string? ActivitiesNotPreviouslyRptInd { get; set; }

    [JsonPropertyName("ChgMadeToOrgnzngDocNotRptInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ChgMadeToOrgnzngDocNotRptInd { get; set; }

    [JsonPropertyName("OrganizationHadUBIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OrganizationHadUBIInd { get; set; }

    [JsonPropertyName("SubjectToProxyTaxInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SubjectToProxyTaxInd { get; set; }

    [JsonPropertyName("OrganizationDissolvedEtcInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OrganizationDissolvedEtcInd { get; set; }

    [JsonPropertyName("DirectIndirectPltclExpendAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? DirectIndirectPltclExpendAmt { get; set; }

    [JsonPropertyName("MadeLoansToFromOfficersInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? MadeLoansToFromOfficersInd { get; set; }

    [JsonPropertyName("TaxImposedUnderIRC4911Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TaxImposedUnderIRC4911Amt { get; set; }

    [JsonPropertyName("TaxImposedUnderIRC4912Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TaxImposedUnderIRC4912Amt { get; set; }

    [JsonPropertyName("TaxImposedUnderIRC4955Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TaxImposedUnderIRC4955Amt { get; set; }

    [JsonPropertyName("EngagedInExcessBenefitTransInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EngagedInExcessBenefitTransInd { get; set; }

    [JsonPropertyName("TaxImposedOnOrganizationMgrAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TaxImposedOnOrganizationMgrAmt { get; set; }

    [JsonPropertyName("TaxReimbursedByOrganizationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TaxReimbursedByOrganizationAmt { get; set; }

    [JsonPropertyName("ProhibitedTaxShelterTransInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProhibitedTaxShelterTransInd { get; set; }

    [JsonPropertyName("StatesWhereCopyOfReturnIsFldCd"), JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> StatesWhereCopyOfReturnIsFldCd { get; set; }

    [JsonPropertyName("BooksInCareOfDetail")]
    public BooksInCareOfDetail BooksInCareOfDetail { get; set; }

    [JsonPropertyName("ForeignFinancialAccountInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ForeignFinancialAccountInd { get; set; }

    [JsonPropertyName("ForeignOfficeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ForeignOfficeInd { get; set; }

    [JsonPropertyName("DonorAdvisedFndsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? DonorAdvisedFndsInd { get; set; }

    [JsonPropertyName("OperateHospitalInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OperateHospitalInd { get; set; }

    [JsonPropertyName("TanningServicesProvidedInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TanningServicesProvidedInd { get; set; }

    [JsonPropertyName("RelatedOrganizationCtrlEntInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrganizationCtrlEntInd { get; set; }

    [JsonPropertyName("PoliticalCampaignActyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PoliticalCampaignActyInd { get; set; }

    [JsonPropertyName("LobbyingActivitiesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? LobbyingActivitiesInd { get; set; }

    [JsonPropertyName("SchoolOperatingInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SchoolOperatingInd { get; set; }

    [JsonPropertyName("TrnsfrExmptNonChrtblRltdOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TrnsfrExmptNonChrtblRltdOrgInd { get; set; }

    [JsonPropertyName("PartVIOfCompOfHghstPdEmplTxt")]
    public string? PartVIOfCompOfHghstPdEmplTxt { get; set; }

    [JsonPropertyName("PartVIHghstPdCntrctProfSrvcTxt")]
    public string? PartVIHghstPdCntrctProfSrvcTxt { get; set; }

    [JsonPropertyName("FiledScheduleAInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FiledScheduleAInd { get; set; }


    //public string? ReferenceDocumentName { get; set; }

    [JsonPropertyName("GroupExemptionNum")]
    public string? GroupExemptionNum { get; set; }

    [JsonPropertyName("ScheduleBNotRequiredInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ScheduleBNotRequiredInd { get; set; }

    [JsonPropertyName("Organization501cInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Organization501cInd { get; set; }

    [JsonPropertyName("InvestmentIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InvestmentIncomeAmt { get; set; }

    [JsonPropertyName("CostOrOtherBasisExpenseSaleAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CostOrOtherBasisExpenseSaleAmt { get; set; }

    [JsonPropertyName("GainOrLossFromSaleOfAssetsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GainOrLossFromSaleOfAssetsAmt { get; set; }

    [JsonPropertyName("GamingGrossIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GamingGrossIncomeAmt { get; set; }

    [JsonPropertyName("CostOfGoodsSoldAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CostOfGoodsSoldAmt { get; set; }

    [JsonPropertyName("GrossProfitLossSlsOfInvntryAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GrossProfitLossSlsOfInvntryAmt { get; set; }

    [JsonPropertyName("Form1120PolFiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Form1120PolFiledInd { get; set; }

    [JsonPropertyName("TransactionWithControlEntInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TransactionWithControlEntInd { get; set; }

    [JsonPropertyName("InitialReturnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InitialReturnInd { get; set; }

    [JsonPropertyName("SaleOfAssetsGrossAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SaleOfAssetsGrossAmt { get; set; }

    [JsonPropertyName("GrossSalesOfInventoryAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GrossSalesOfInventoryAmt { get; set; }

    [JsonPropertyName("OtherRevenueTotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OtherRevenueTotalAmt { get; set; }

    [JsonPropertyName("GrantsAndSimilarAmountsPaidAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GrantsAndSimilarAmountsPaidAmt { get; set; }

    [JsonPropertyName("BenefitsPaidToOrForMembersAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BenefitsPaidToOrForMembersAmt { get; set; }

    [JsonPropertyName("SalariesOtherCompEmplBnftAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SalariesOtherCompEmplBnftAmt { get; set; }

    [JsonPropertyName("OccupancyRentUtltsAndMaintAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OccupancyRentUtltsAndMaintAmt { get; set; }

    [JsonPropertyName("LandAndBuildingsGrp"), JsonConverter(typeof(SingleOrArrayConverter<LandAndBuildingsGrp>))]
    public List<LandAndBuildingsGrp> LandAndBuildingsGrp { get; set; }

    [JsonPropertyName("OtherAssetsTotalDetail")]
    public OtherAssetsTotalDetail OtherAssetsTotalDetail { get; set; }

    [JsonPropertyName("LoansToFromOfficersAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? LoansToFromOfficersAmt { get; set; }

    [JsonPropertyName("MethodOfAccountingAccrualInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? MethodOfAccountingAccrualInd { get; set; }

    [JsonPropertyName("InfoInScheduleOPartIVInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InfoInScheduleOPartIVInd { get; set; }

    [JsonPropertyName("OrganizationFiled990TInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OrganizationFiled990TInd { get; set; }

    [JsonPropertyName("InitiationFeesAndCapContriAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InitiationFeesAndCapContriAmt { get; set; }

    [JsonPropertyName("GrossReceiptsForPublicUseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GrossReceiptsForPublicUseAmt { get; set; }

    [JsonPropertyName("Form720FiledInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Form720FiledInd { get; set; }

    [JsonPropertyName("MethodOfAccountingOtherDesc")]
    public string? MethodOfAccountingOtherDesc { get; set; }

    [JsonPropertyName("TypeOfOrganizationAssocInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TypeOfOrganizationAssocInd { get; set; }

    [JsonPropertyName("RelatedOrgSect527OrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrgSect527OrgInd { get; set; }

    [JsonPropertyName("AddressChangeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? AddressChangeInd { get; set; }

    [JsonPropertyName("FinalReturnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FinalReturnInd { get; set; }

    [JsonPropertyName("CompensationOfHghstPdCntrctGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> CompensationOfHghstPdCntrctGrp { get; set; }

    [JsonPropertyName("TypeOfOrganizationTrustInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TypeOfOrganizationTrustInd { get; set; }

    [JsonPropertyName("TypeOfOrganizationOtherInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TypeOfOrganizationOtherInd { get; set; }

    [JsonPropertyName("TypeOfOrganizationOtherDesc")]
    public string? TypeOfOrganizationOtherDesc { get; set; }

    [JsonPropertyName("AmendedReturnInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? AmendedReturnInd { get; set; }

    [JsonPropertyName("ForeignFinancialAccountCntryCd"), JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> ForeignFinancialAccountCntryCd { get; set; }

    [JsonPropertyName("OtherEmployeePaidOver100kCnt")]
    public string? OtherEmployeePaidOver100kCnt { get; set; }

    [JsonPropertyName("CntrctRcvdGreaterThan100KCnt")]
    public string? CntrctRcvdGreaterThan100KCnt { get; set; }

    [JsonPropertyName("ForeignOfficeCountryCd"), JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> ForeignOfficeCountryCd { get; set; }

    [JsonPropertyName("InfoInScheduleOPartVIInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InfoInScheduleOPartVIInd { get; set; }

    [JsonPropertyName("CompensationHighestPaidEmplGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> CompensationHighestPaidEmplGrp { get; set; }

    [JsonPropertyName("SpecialConditionDesc")]
    public string? SpecialConditionDesc { get; set; }

    [JsonPropertyName("Organization4947a1NotPFInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Organization4947a1NotPFInd { get; set; }
}

public class IRS990ScheduleJ
{
    [JsonPropertyName("WrittenEmploymentContractInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? WrittenEmploymentContractInd { get; set; }

    [JsonPropertyName("BoardOrCommitteeApprovalInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BoardOrCommitteeApprovalInd { get; set; }

    [JsonPropertyName("SeverancePaymentInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SeverancePaymentInd { get; set; }

    [JsonPropertyName("SupplementalNonqualRtrPlanInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SupplementalNonqualRtrPlanInd { get; set; }

    [JsonPropertyName("EquityBasedCompArrngmInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EquityBasedCompArrngmInd { get; set; }

    [JsonPropertyName("CompBasedOnRevenueOfFlngOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CompBasedOnRevenueOfFlngOrgInd { get; set; }

    [JsonPropertyName("CompBsdOnRevRelatedOrgsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CompBsdOnRevRelatedOrgsInd { get; set; }

    [JsonPropertyName("CompBsdNetEarnsFlngOrgInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CompBsdNetEarnsFlngOrgInd { get; set; }

    [JsonPropertyName("CompBsdNetEarnsRltdOrgsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CompBsdNetEarnsRltdOrgsInd { get; set; }

    [JsonPropertyName("AnyNonFixedPaymentsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? AnyNonFixedPaymentsInd { get; set; }

    [JsonPropertyName("InitialContractExceptionInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InitialContractExceptionInd { get; set; }

    [JsonPropertyName("RebuttablePresumptionProcInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RebuttablePresumptionProcInd { get; set; }

    [JsonPropertyName("RltdOrgOfficerTrstKeyEmplGrp")]
    [JsonConverter(typeof(SingleOrArrayConverter<RltdOrgOfficerTrstKeyEmplGrp>))]
    public List<RltdOrgOfficerTrstKeyEmplGrp> RltdOrgOfficerTrstKeyEmplGrp { get; set; }

    [JsonPropertyName("SubstantiationRequiredInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SubstantiationRequiredInd { get; set; }

    [JsonPropertyName("SupplementalInformationDetail")]
    [JsonConverter(typeof(SingleOrArrayConverter<SupplementalInformationDetail>))]
    public List<SupplementalInformationDetail> SupplementalInformationDetail { get; set; }

    [JsonPropertyName("CompensationCommitteeInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CompensationCommitteeInd { get; set; }

    [JsonPropertyName("CompensationSurveyInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CompensationSurveyInd { get; set; }

    [JsonPropertyName("IndependentConsultantInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? IndependentConsultantInd { get; set; }

    [JsonPropertyName("Form990OfOtherOrganizationsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Form990OfOtherOrganizationsInd { get; set; }

    [JsonPropertyName("ClubDuesOrFeesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ClubDuesOrFeesInd { get; set; }

    [JsonPropertyName("WrittenPolicyRefTAndEExpnssInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? WrittenPolicyRefTAndEExpnssInd { get; set; }

    [JsonPropertyName("TravelForCompanionsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TravelForCompanionsInd { get; set; }

    [JsonPropertyName("FirstClassOrCharterTravelInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FirstClassOrCharterTravelInd { get; set; }

    [JsonPropertyName("IdemnificationGrossUpPmtsInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? IdemnificationGrossUpPmtsInd { get; set; }

    [JsonPropertyName("DiscretionarySpendingAcctInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? DiscretionarySpendingAcctInd { get; set; }

    [JsonPropertyName("HousingAllowanceOrResidenceInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? HousingAllowanceOrResidenceInd { get; set; }

    [JsonPropertyName("PersonalServicesInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PersonalServicesInd { get; set; }

    [JsonPropertyName("PaymentsForUseOfResidenceInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PaymentsForUseOfResidenceInd { get; set; }

}

// public class IRS990ScheduleM
// {
//     [JsonPropertyName("SecuritiesPubliclyTradedGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     public List<dynamic> SecuritiesPubliclyTradedGrp { get; set; }
//
//     [JsonPropertyName("AnyPropertyThatMustBeHeldInd"), JsonConverter(typeof(FixScrewedUpString))]
//     public string? AnyPropertyThatMustBeHeldInd { get; set; }
//
//     [JsonPropertyName("ReviewProcessUnusualNCGiftsInd"), JsonConverter(typeof(FixScrewedUpString))]
//     public string? ReviewProcessUnusualNCGiftsInd { get; set; }
//
//     [JsonPropertyName("ThirdPartiesUsedInd"), JsonConverter(typeof(FixScrewedUpString))]
//     public string? ThirdPartiesUsedInd { get; set; }
//
//     [JsonPropertyName("OtherNonCashContriTableGrp"),
//      JsonConverter(typeof(SingleOrArrayConverter<OtherNonCashContriTableGrp>))]
//     public List<OtherNonCashContriTableGrp> OtherNonCashContriTableGrp { get; set; }
//
//     // [JsonPropertyName("ClothingAndHouseholdGoodsGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> ClothingAndHouseholdGoodsGrp { get; set; }
//
//     // [JsonPropertyName("WorksOfArtGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> WorksOfArtGrp { get; set; }
//     //
//     // [JsonPropertyName("BooksAndPublicationsGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> BooksAndPublicationsGrp { get; set; }
//     //
//     // [JsonPropertyName("CollectiblesGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> CollectiblesGrp { get; set; }
//     //
//     // [JsonPropertyName("FoodInventoryGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> FoodInventoryGrp { get; set; }
//
//     [JsonPropertyName("Form8283ReceivedCnt")]
//     public string? Form8283ReceivedCnt { get; set; }
//
//     [JsonPropertyName("SupplementalInformationDetail"),
//      JsonConverter(typeof(SingleOrArrayConverter<SupplementalInformationDetail>))]
//     public List<SupplementalInformationDetail> SupplementalInformationDetail { get; set; }
//
//     [JsonPropertyName("QualifiedContribOtherGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     public List<dynamic> QualifiedContribOtherGrp { get; set; }
//
//     // [JsonPropertyName("ArtHistoricalTreasuresGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> ArtHistoricalTreasuresGrp { get; set; }
//     //
//     // [JsonPropertyName("ArtFractionalInterestGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> ArtFractionalInterestGrp { get; set; }
//     //
//     // [JsonPropertyName("CarsAndOtherVehiclesGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> CarsAndOtherVehiclesGrp { get; set; }
//     //
//     // [JsonPropertyName("BoatsAndPlanesGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> BoatsAndPlanesGrp { get; set; }
//
//     // [JsonPropertyName("IntellectualPropertyGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> IntellectualPropertyGrp { get; set; }
//     //
//     // [JsonPropertyName("SecuritiesCloselyHeldStockGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> SecuritiesCloselyHeldStockGrp { get; set; }
//     //
//     // [JsonPropertyName("SecurPrtnrshpTrustIntrstsGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> SecurPrtnrshpTrustIntrstsGrp { get; set; }
//     //
//     // [JsonPropertyName("SecuritiesMiscellaneousGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> SecuritiesMiscellaneousGrp { get; set; }
//     //
//     // [JsonPropertyName("QualifiedContribHistStructGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> QualifiedContribHistStructGrp { get; set; }
//     //
//     // [JsonPropertyName("RealEstateResidentialGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> RealEstateResidentialGrp { get; set; }
//     //
//     // [JsonPropertyName("RealEstateCommercialGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> RealEstateCommercialGrp { get; set; }
//     //
//     // [JsonPropertyName("RealEstateOtherGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> RealEstateOtherGrp { get; set; }
//
//     [JsonPropertyName("DrugsAndMedicalSuppliesGrp"),
//      JsonConverter(typeof(SingleOrArrayConverter<DrugsAndMedicalSuppliesGrp>))]
//     public List<DrugsAndMedicalSuppliesGrp> DrugsAndMedicalSuppliesGrp { get; set; }
//
//     // [JsonPropertyName("TaxidermyGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> TaxidermyGrp { get; set; }
//     //
//     // [JsonPropertyName("HistoricalArtifactsGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> HistoricalArtifactsGrp { get; set; }
//     //
//     // [JsonPropertyName("ScientificSpecimensGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> ScientificSpecimensGrp { get; set; }
//     //
//     // [JsonPropertyName("ArchaeologicalArtifactsGrp"), JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
//     // public List<dynamic> ArchaeologicalArtifactsGrp { get; set; }
// }

public class IRS990ScheduleO
{
    [JsonPropertyName("SupplementalInformationDetail"),
     JsonConverter(typeof(SingleOrArrayConverter<SupplementalInformationDetail>))]
    public List<SupplementalInformationDetail> SupplementalInformationDetail { get; set; }

}

public class IssuerName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }
}

public class LandAndBuildingsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class LandBldgEquipBasisNetGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class LargestSupportFromEOGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }
}

public class LenderNameGrp
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("PersonNm")] public string? PersonNm { get; set; }
}

public class LessCostOthBasisSalesExpnssGrp
{
    [JsonPropertyName("SecuritiesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? SecuritiesAmt { get; set; }

    [JsonPropertyName("OtherAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OtherAmt { get; set; }
}

public class LessorAdjNetIncmMinInvstRetGrp
{
    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year3Amt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }
}

public class LessRentalExpensesGrp
{
    [JsonPropertyName("RealAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RealAmt { get; set; }

    [JsonPropertyName("PersonalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PersonalAmt { get; set; }
}

public class LiquidationOfAssetsDetail
{
    [JsonPropertyName("AssetsDistriOrExpnssPaidDesc")]
    public string? AssetsDistriOrExpnssPaidDesc { get; set; }

    [JsonPropertyName("DistributionDt")] public string? DistributionDt { get; set; }
}
public class LoansFromOfficersDirectorsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class LocationOfBooksForeignAddress
{
    [JsonPropertyName("AddressLine1Txt")] public string? AddressLine1Txt { get; set; }

    [JsonPropertyName("CityNm")] public string? CityNm { get; set; }

    [JsonPropertyName("ProvinceOrStateNm")]
    public string? ProvinceOrStateNm { get; set; }

    [JsonPropertyName("CountryCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))] 
    public List<string> CountryCd { get; set; }

    [JsonPropertyName("ForeignPostalCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))] 
    public List<string> ForeignPostalCd { get; set; }
}

public class LocationOfBooksUSAddress
{
    [JsonPropertyName("AddressLine1Txt")] public string? AddressLine1Txt { get; set; }

    [JsonPropertyName("CityNm")] public string? CityNm { get; set; }

    [JsonPropertyName("StateAbbreviationCd"), ]
    public List<string> StateAbbreviationCd { get; set; }

    [JsonPropertyName("ZIPCd")] public string? ZIPCd { get; set; }

    [JsonPropertyName("AddressLine2Txt")] public string? AddressLine2Txt { get; set; }
}

public class MiscellaneousRevenueGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? UnrelatedBusinessRevenueAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExclusionAmt { get; set; }
}

public class MortgNotesPyblScrdInvstPropGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class NameOfInterested
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }
}

public class NetAssetsOrFundBalancesGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class NetGainOrLossInvestmentsGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExclusionAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? UnrelatedBusinessRevenueAmt { get; set; }
}


public class NetIncmFromFundraisingEvtGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExclusionAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? UnrelatedBusinessRevenueAmt { get; set; }
}

public class NetIncomeFromGamingGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExclusionAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? UnrelatedBusinessRevenueAmt { get; set; }
}

public class NetIncomeOrLossGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? UnrelatedBusinessRevenueAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExclusionAmt { get; set; }
}

public class NetRentalIncomeOrLossGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExclusionAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? UnrelatedBusinessRevenueAmt { get; set; }
}

public class NetSTCapitalGainAdjNetIncmGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}

public class NetVlNonExemptUseAssetsGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}

public class NoDonorRestrictionNetAssetsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class NoncharitableExemptOrgName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }
}

public class OccupancyGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class OfficeExpensesGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class OfficerDirectorTrusteeEmplGrp
{
    [JsonPropertyName("PersonNm")] 
    public string? PersonNm { get; set; }

    [JsonPropertyName("TitleTxt")]
    public string? TitleTxt { get; set; }

    [JsonPropertyName("AverageHrsPerWkDevotedToPosRt")]
    public string? AverageHrsPerWkDevotedToPosRt { get; set; }

    [JsonPropertyName("CompensationAmt"), 
     JsonConverter(typeof(FixScrewedUpString))]
    public string? CompensationAmt { get; set; }

    [JsonPropertyName("EmployeeBenefitProgramAmt"),
     JsonConverter(typeof(FixScrewedUpString))]
    public string? EmployeeBenefitProgramAmt { get; set; }

    [JsonPropertyName("ExpenseAccountOtherAllwncAmt"), 
     JsonConverter(typeof(FixScrewedUpString))]
    public string? ExpenseAccountOtherAllwncAmt { get; set; }
}

public class OfficerDirTrstKeyEmplGrp
{
    [JsonPropertyName("PersonNm")] public string? PersonNm { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("TitleTxt")] public string? TitleTxt { get; set; }

    [JsonPropertyName("AverageHrsPerWkDevotedToPosRt")]
    public string? AverageHrsPerWkDevotedToPosRt { get; set; }

    [JsonPropertyName("CompensationAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CompensationAmt { get; set; }

    [JsonPropertyName("EmployeeBenefitProgramAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EmployeeBenefitProgramAmt { get; set; }

    [JsonPropertyName("ExpenseAccountOtherAllwncAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExpenseAccountOtherAllwncAmt { get; set; }
}


public class Organization501c3Name
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }
}

public class OrganizationBusinessName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }
}


public class OtherAssetsTotalDetail
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class OtherAssetsTotalGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }
}

public class OtherEmployeeBenefitsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}


public class OtherExpensesGrp
{
    [JsonPropertyName("Desc")] public string? Desc { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }

    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}


public class OtherGrossIncomeGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}


public class OtherLiabilitiesGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}


public class OtherNonCashContriTableGrp
{
    [JsonPropertyName("NonCashCheckboxInd"), JsonConverter(typeof(FixScrewedUpString))]
    public string? NonCashCheckboxInd { get; set; }

    [JsonPropertyName("Desc")] public string? Desc { get; set; }

    [JsonPropertyName("ContributionCnt")] public string? ContributionCnt { get; set; }

    [JsonPropertyName("NoncashContributionsRptF990Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? NoncashContributionsRptF990Amt { get; set; }

    [JsonPropertyName("MethodOfDeterminingRevenuesTxt")]
    public string? MethodOfDeterminingRevenuesTxt { get; set; }
}


public class OtherOrganizationName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }
}


public class OtherRevenueDescribedGrp
{
    [JsonPropertyName("Desc")] public string? Desc { get; set; }

    [JsonPropertyName("RelatedOrExemptFunctionIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrExemptFunctionIncmAmt { get; set; }
}

public class OtherRevenueMiscGrp
{
    [JsonPropertyName("Desc")] public string? Desc { get; set; }

    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExclusionAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("BusinessCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> BusinessCd { get; set; }
}

public class OtherSalariesAndWagesGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}


public class OthHlthCareFcltsGrp
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }

    [JsonPropertyName("USAddress")] public USAddress USAddress { get; set; }

    [JsonPropertyName("FacilityTxt")] public string? FacilityTxt { get; set; }
}


public class OthNotesLoansReceivableNetGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class PaymentsToAffiliatesGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class PayrollTaxesGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class Pct85LessorAdjIncmOrMinRetGrp
{
    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year3Amt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }
}

public class PctOfNetVlNonExemptUseAstGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}

public class PdInCapSrplsLandBldgEqpFundGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class PensionPlanContributionsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class PermanentlyRstrNetAssetsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class PersonsWithBooksName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }

    [JsonPropertyName("BusinessNameLine2Txt")]
    public string? BusinessNameLine2Txt { get; set; }
}

public class PledgesAndGrantsReceivableGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }
}

public class Post1975UBTIGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentTaxYearAmt { get; set; }
}

public class PrepaidExpensesDefrdChargesGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}


public class PreparerFirmName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }

    [JsonPropertyName("BusinessNameLine2Txt")]
    public string? BusinessNameLine2Txt { get; set; }
}

public class PreparerForeignAddress
{
    [JsonPropertyName("AddressLine1Txt")] public string? AddressLine1Txt { get; set; }

    [JsonPropertyName("CityNm")] public string? CityNm { get; set; }

    [JsonPropertyName("ProvinceOrStateNm")]
    public string? ProvinceOrStateNm { get; set; }

    [JsonPropertyName("CountryCd")] public string? CountryCd { get; set; }

    [JsonPropertyName("ForeignPostalCd")] public string? ForeignPostalCd { get; set; }

    [JsonPropertyName("AddressLine2Txt")] public string? AddressLine2Txt { get; set; }
}

public class PreparerUSAddress
{
    [JsonPropertyName("AddressLine1Txt")] public string? AddressLine1Txt { get; set; }

    [JsonPropertyName("CityNm")] public string? CityNm { get; set; }

    [JsonPropertyName("StateAbbreviationCd")]
    public string? StateAbbreviationCd { get; set; }

    [JsonPropertyName("ZIPCd")] public string? ZIPCd { get; set; }

    [JsonPropertyName("AddressLine2Txt")] public string? AddressLine2Txt { get; set; }
}

public class PrincipalOfcrBusinessName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }

    [JsonPropertyName("BusinessNameLine2Txt")]
    public string? BusinessNameLine2Txt { get; set; }
}

public class ProductionIncomeGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}

public class ProgramServiceRevenueGrp
{
    [JsonPropertyName("Desc")] public string? Desc { get; set; }

    [JsonPropertyName("BusinessCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))] 
    public List<string> BusinessCd { get; set; }

    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? UnrelatedBusinessRevenueAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExclusionAmt { get; set; }
}

public class ProgramServiceRevPartVIIGrp
{
    [JsonPropertyName("Desc")] public string? Desc { get; set; }

    [JsonPropertyName("RelatedOrExemptFunctionIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrExemptFunctionIncmAmt { get; set; }
}

public class ProgramSrvcAccomplishmentGrp
{
    [JsonPropertyName("DescriptionProgramSrvcAccomTxt")]
    public string? DescriptionProgramSrvcAccomTxt { get; set; }

    [JsonPropertyName("GrantsAndAllocationsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GrantsAndAllocationsAmt { get; set; }

    [JsonPropertyName("ProgramServiceExpensesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServiceExpensesAmt { get; set; }
}

public class ProgSrvcAccomActy2Grp
{
    [JsonPropertyName("Desc")] public string? Desc { get; set; }

    [JsonPropertyName("ExpenseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExpenseAmt { get; set; }

    [JsonPropertyName("RevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RevenueAmt { get; set; }

    [JsonPropertyName("GrantAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GrantAmt { get; set; }

    [JsonPropertyName("ActivityCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> ActivityCd { get; set; }
}

public class ProgSrvcAccomActy3Grp
{
    [JsonPropertyName("ExpenseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExpenseAmt { get; set; }

    [JsonPropertyName("Desc")] public string? Desc { get; set; }

    [JsonPropertyName("GrantAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? GrantAmt { get; set; }

    [JsonPropertyName("RevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RevenueAmt { get; set; }

    [JsonPropertyName("ActivityCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))] 
    public List<string> ActivityCd { get; set; }
}

public class ProgSrvcAccomActyOtherGrp
{
    [JsonPropertyName("ExpenseAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExpenseAmt { get; set; }

    [JsonPropertyName("RevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RevenueAmt { get; set; }

    [JsonPropertyName("Desc")] public string? Desc { get; set; }
}

public class PublicSupportType
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }
}

public class PurchaserNameGrp
{
    [JsonPropertyName("BusinessName")] public BusinessName BusinessName { get; set; }
}

public class PymtTravelEntrtnmntPubOfclGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}


public class QualifyingDistributionsGrp
{
    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year3Amt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }
}

public class QualifyingDistriMadeDrtGrp
{
    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year3Amt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }
}

public class QualifyingDistriNotUsedDrtGrp
{
    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year3Amt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }
}


public class RcvblFromDisqualifiedPrsnGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }
}

public class ReceivablesFromOfficersEtcGrp
{
    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }
}

public class RecipientBusinessName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }
}

public class RecipientUSAddress
{
    [JsonPropertyName("AddressLine1Txt")] public string? AddressLine1Txt { get; set; }

    [JsonPropertyName("CityNm")] public string? CityNm { get; set; }

    [JsonPropertyName("StateAbbreviationCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> StateAbbreviationCd { get; set; }

    [JsonPropertyName("ZIPCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))] 
    public List<string> ZIPCd { get; set; }

    [JsonPropertyName("AddressLine2Txt")] public string? AddressLine2Txt { get; set; }
}

public class RecoveriesPYDistributionsGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}

public class RecoveriesPYDistriMinAssetGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}

public class RelatedOrganizationName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }
}

public class RelationshipScheduleDetail
{
    [JsonPropertyName("OrganizationBusinessName")]
    public OrganizationBusinessName OrganizationBusinessName { get; set; }

    [JsonPropertyName("OrganizationTypeDesc")]
    public string? OrganizationTypeDesc { get; set; }

    [JsonPropertyName("RelationshipDescriptionTxt")]
    public string? RelationshipDescriptionTxt { get; set; }
}

public class RentalIncomeOrLossGrp
{
    [JsonPropertyName("RealAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RealAmt { get; set; }

    [JsonPropertyName("PersonalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PersonalAmt { get; set; }
}

public class RltdOrgOfficerTrstKeyEmplGrp
{
    [JsonPropertyName("PersonNm")] public string? PersonNm { get; set; }

    [JsonPropertyName("TitleTxt")] public string? TitleTxt { get; set; }

    [JsonPropertyName("BaseCompensationFilingOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BaseCompensationFilingOrgAmt { get; set; }

    [JsonPropertyName("CompensationBasedOnRltdOrgsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CompensationBasedOnRltdOrgsAmt { get; set; }

    [JsonPropertyName("BonusFilingOrganizationAmount")]
    public string? BonusFilingOrganizationAmount { get; set; }

    [JsonPropertyName("BonusRelatedOrganizationsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BonusRelatedOrganizationsAmt { get; set; }

    [JsonPropertyName("OtherCompensationFilingOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OtherCompensationFilingOrgAmt { get; set; }

    [JsonPropertyName("OtherCompensationRltdOrgsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? OtherCompensationRltdOrgsAmt { get; set; }

    [JsonPropertyName("DeferredCompensationFlngOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? DeferredCompensationFlngOrgAmt { get; set; }

    [JsonPropertyName("DeferredCompRltdOrgsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? DeferredCompRltdOrgsAmt { get; set; }

    [JsonPropertyName("NontaxableBenefitsFilingOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? NontaxableBenefitsFilingOrgAmt { get; set; }

    [JsonPropertyName("NontaxableBenefitsRltdOrgsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? NontaxableBenefitsRltdOrgsAmt { get; set; }

    [JsonPropertyName("TotalCompensationFilingOrgAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalCompensationFilingOrgAmt { get; set; }

    [JsonPropertyName("TotalCompensationRltdOrgsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalCompensationRltdOrgsAmt { get; set; }

    [JsonPropertyName("CompReportPrior990FilingOrgAmt"),
     JsonConverter(typeof(FixScrewedUpString))]
    public string? CompReportPrior990FilingOrgAmt { get; set; }

    [JsonPropertyName("CompReportPrior990RltdOrgsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CompReportPrior990RltdOrgsAmt { get; set; }
}

public class Return
{
    [JsonPropertyName("Id")]
    public Guid Id { get; set; }

    [JsonPropertyName("FileName")] 
    public string? FileName { get; set; }

    [JsonPropertyName("ReturnTs")]
    public string? ReturnTs { get; set; }

    [JsonPropertyName("TaxPeriodEndDt")] 
    public string? TaxPeriodEndDt { get; set; }

    [JsonPropertyName("ReturnTypeCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))] 
    public List<string> ReturnTypeCd { get; set; }

    [JsonPropertyName("TaxPeriodBeginDt")]
    public string? TaxPeriodBeginDt { get; set; }

    [JsonPropertyName("Filer")] 
    public Filer Filer { get; set; }

    //[JsonPropertyName("BusinessOfficerGrp"), 
    // JsonConverter(typeof(SingleOrArrayConverter<BusinessOfficerGrp>))]
    //public List<BusinessOfficerGrp> BusinessOfficerGrp { get; set; }

    [JsonPropertyName("TaxYr")] 
    public string? TaxYr { get; set; }

    [JsonPropertyName("BuildTS")]
    public string? BuildTS { get; set; }

    [JsonPropertyName("IRS990")] 
    public IRS990 IRS990 { get; set; }

    [JsonPropertyName("IRS990ScheduleO")] 
    public IRS990ScheduleO IRS990ScheduleO { get; set; }

     [JsonPropertyName("IRS990ScheduleJ")]
     public IRS990ScheduleJ IRS990ScheduleJ { get; set; }

    [JsonPropertyName("IRS990EZ")] 
    public IRS990EZ IRS990EZ { get; set; }

    // [JsonPropertyName("IRS990ScheduleM")]
    // public IRS990ScheduleM IRS990ScheduleM { get; set; }
}

public class RoyaltiesGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class RoyaltiesRevenueGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? UnrelatedBusinessRevenueAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExclusionAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrExemptFuncIncomeAmt { get; set; }
}

public class RtnEarnEndowmentIncmOthFndsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class SavingsAndTempCashInvstGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class SubtotalsIncmProducingActyGrp
{
    [JsonPropertyName("RelatedOrExemptFunctionIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrExemptFunctionIncmAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessTaxblIncmAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? UnrelatedBusinessTaxblIncmAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExclusionAmt { get; set; }
}

public class SumOfTotalLiabilitiesGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class SupplementalInformationDetail
{
    [JsonPropertyName("FormAndLineReferenceDesc")]
    public string? FormAndLineReferenceDesc { get; set; }

    [JsonPropertyName("ExplanationTxt")] public string? ExplanationTxt { get; set; }
}


public class SupportedOrganizationName
{
    [JsonPropertyName("BusinessNameLine1Txt")]
    public string? BusinessNameLine1Txt { get; set; }

    [JsonPropertyName("BusinessNameLine2Txt")]
    public string? BusinessNameLine2Txt { get; set; }
}

public class TaxExemptBondLiabilitiesGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class TemporarilyRstrNetAssetsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}


public class TotalAdjustedNetIncomeGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}

public class TotalAssetsGrp
{
    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year3Amt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class TotalAssetsSect4942j3BiGrp
{
    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year3Amt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }
}


public class TotalFMVOfNonExemptUseAssetGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}

public class TotalFunctionalExpensesGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}


public class TotalJointCostsGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}

public class TotalLiabilitiesGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}


public class TotalMinimumAssetGrp
{
    [JsonPropertyName("PriorYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? PriorYearAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }
}

public class TotalNetAssetsFundBalanceGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class TotalOthProgramServiceRevGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? UnrelatedBusinessRevenueAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExclusionAmt { get; set; }
}

public class TotalRevenueGrp
{
    [JsonPropertyName("TotalRevenueColumnAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalRevenueColumnAmt { get; set; }

    [JsonPropertyName("RelatedOrExemptFuncIncomeAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? RelatedOrExemptFuncIncomeAmt { get; set; }

    [JsonPropertyName("UnrelatedBusinessRevenueAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? UnrelatedBusinessRevenueAmt { get; set; }

    [JsonPropertyName("ExclusionAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ExclusionAmt { get; set; }
}

public class TotalSupportCalendarYearGrp
{
    [JsonPropertyName("CurrentTaxYearMinus4YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentTaxYearMinus4YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus3YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentTaxYearMinus3YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus2YearsAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentTaxYearMinus2YearsAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearMinus1YearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentTaxYearMinus1YearAmt { get; set; }

    [JsonPropertyName("CurrentTaxYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentTaxYearAmt { get; set; }

    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }
}

public class TotalSupportGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }
}

public class TotLiabNetAssetsFundBalanceGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}


public class TransferScheduleDetail
{
    [JsonPropertyName("LineNumberTxt")] public string? LineNumberTxt { get; set; }

    [JsonPropertyName("InvolvedAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? InvolvedAmt { get; set; }

    [JsonPropertyName("NoncharitableExemptOrgName")]
    public NoncharitableExemptOrgName NoncharitableExemptOrgName { get; set; }

    [JsonPropertyName("TransfersTransAndShrArrngmDesc")]
    public string? TransfersTransAndShrArrngmDesc { get; set; }
}

public class TravelGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("ManagementAndGeneralAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ManagementAndGeneralAmt { get; set; }

    [JsonPropertyName("ProgramServicesAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? ProgramServicesAmt { get; set; }

    [JsonPropertyName("FundraisingAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? FundraisingAmt { get; set; }
}


public class TwoThirdsMinimumInvstRetGrp
{
    [JsonPropertyName("TotalAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? TotalAmt { get; set; }

    [JsonPropertyName("CurrentYearAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? CurrentYearAmt { get; set; }

    [JsonPropertyName("Year1Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year1Amt { get; set; }

    [JsonPropertyName("Year2Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year2Amt { get; set; }

    [JsonPropertyName("Year3Amt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? Year3Amt { get; set; }
}


public class UnrestrictedNetAssetsGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class UnsecuredNotesLoansPayableGrp
{
    [JsonPropertyName("BOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? BOYAmt { get; set; }

    [JsonPropertyName("EOYAmt"), JsonConverter(typeof(FixScrewedUpString))]
    public string? EOYAmt { get; set; }
}

public class USAddress
{
    [JsonPropertyName("AddressLine1Txt")] 
    public string? AddressLine1Txt { get; set; }

    [JsonPropertyName("CityNm")] 
    public string? CityNm { get; set; }

    [JsonPropertyName("StateAbbreviationCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> StateAbbreviationCd { get; set; }

    [JsonPropertyName("ZIPCd"),JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> ZIPCd { get; set; }

    [JsonPropertyName("AddressLine2Txt")] 
    public string? AddressLine2Txt { get; set; }
}
