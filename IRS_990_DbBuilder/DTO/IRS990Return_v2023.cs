// public class AccountActivitiesOutsideUSGrp
// {
//     [JsonProperty("RegionTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RegionTxt")]
//     public string RegionTxt { get; set; }
//
//     [JsonProperty("TypeOfActivitiesConductedTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TypeOfActivitiesConductedTxt")]
//     public string TypeOfActivitiesConductedTxt { get; set; }
//
//     [JsonProperty("RegionTotalExpendituresAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RegionTotalExpendituresAmt")]
//     public string RegionTotalExpendituresAmt { get; set; }
//
//     [JsonProperty("OfficesCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OfficesCnt")]
//     public string OfficesCnt { get; set; }
//
//     [JsonProperty("EmployeeCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EmployeeCnt")]
//     public string EmployeeCnt { get; set; }
//
//     [JsonProperty("SpecificServicesProvidedTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SpecificServicesProvidedTxt")]
//     public string SpecificServicesProvidedTxt { get; set; }
// }
//
// public class AccountingFeesDetail
// {
//     [JsonProperty("CategoryTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CategoryTxt")]
//     public string CategoryTxt { get; set; }
//
//     [JsonProperty("Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Amt")]
//     public string Amt { get; set; }
//
//     [JsonProperty("DisbursementsCharitablePrpsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisbursementsCharitablePrpsAmt")]
//     public string DisbursementsCharitablePrpsAmt { get; set; }
//
//     [JsonProperty("NetInvestmentIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetInvestmentIncomeAmt")]
//     public string NetInvestmentIncomeAmt { get; set; }
//
//     [JsonProperty("AdjustedNetIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedNetIncomeAmt")]
//     public string AdjustedNetIncomeAmt { get; set; }
// }
//
// public class AccountingFeesRevAndExpnssAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
// }
//
// public class AccountingFeesSchedule
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("AccountingFeesDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AccountingFeesDetail")]
//     public AccountingFeesDetail AccountingFeesDetail { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class AccountsPayableAccrExpnssGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class AccountsReceivableGrp
// {
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
//
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
// }
//
// public class AcctCompileOrReviewBasisGrp
// {
//     [JsonProperty("SeparateBasisFinclStmtInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SeparateBasisFinclStmtInd")]
//     public string SeparateBasisFinclStmtInd { get; set; }
//
//     [JsonProperty("ConsolidatedBasisFinclStmtInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ConsolidatedBasisFinclStmtInd")]
//     public string ConsolidatedBasisFinclStmtInd { get; set; }
// }
//
// public class AcquisitionIndebtednessGrp
// {
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class AdditionalFilerInformation
// {
//     [JsonProperty("TrustedCustomerGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TrustedCustomerGrp")]
//     public TrustedCustomerGrp TrustedCustomerGrp { get; set; }
// }
//
// public class AdjustedFMVLessIndebtednessGrp
// {
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class AdjustedGrossIncomeGrp
// {
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class AdjustedNetIncomeGrp
// {
//     [JsonProperty("NetSTCapitalGainAdjNetIncmGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetSTCapitalGainAdjNetIncmGrp")]
//     public NetSTCapitalGainAdjNetIncmGrp NetSTCapitalGainAdjNetIncmGrp { get; set; }
//
//     [JsonProperty("RecoveriesPYDistributionsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecoveriesPYDistributionsGrp")]
//     public RecoveriesPYDistributionsGrp RecoveriesPYDistributionsGrp { get; set; }
//
//     [JsonProperty("OtherGrossIncomeGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherGrossIncomeGrp")]
//     public OtherGrossIncomeGrp OtherGrossIncomeGrp { get; set; }
//
//     [JsonProperty("AdjustedGrossIncomeGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedGrossIncomeGrp")]
//     public AdjustedGrossIncomeGrp AdjustedGrossIncomeGrp { get; set; }
//
//     [JsonProperty("DepreciationDepletionGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationDepletionGrp")]
//     public DepreciationDepletionGrp DepreciationDepletionGrp { get; set; }
//
//     [JsonProperty("ProductionIncomeGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProductionIncomeGrp")]
//     public ProductionIncomeGrp ProductionIncomeGrp { get; set; }
//
//     [JsonProperty("OtherExpensesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherExpensesGrp")]
//     public OtherExpensesGrp OtherExpensesGrp { get; set; }
//
//     [JsonProperty("TotalAdjustedNetIncomeGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAdjustedNetIncomeGrp")]
//     public TotalAdjustedNetIncomeGrp TotalAdjustedNetIncomeGrp { get; set; }
// }
//
// public class AdvertisingGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class AffiliatedGroupSchedule
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("AffiliatedScheduleGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AffiliatedScheduleGrp")]
//     public List<AffiliatedScheduleGrp> AffiliatedScheduleGrp { get; } = new List<AffiliatedScheduleGrp>();
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
// }
//
// public class AffiliatedScheduleGrp
// {
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("EIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EIN")]
//     public string EIN { get; set; }
//
//     [JsonProperty("ElectingOrganizationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ElectingOrganizationInd")]
//     public string ElectingOrganizationInd { get; set; }
//
//     [JsonProperty("TotalGrassrootsLobbyAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalGrassrootsLobbyAmt")]
//     public string TotalGrassrootsLobbyAmt { get; set; }
//
//     [JsonProperty("TotalDirectLobbyAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalDirectLobbyAmt")]
//     public string TotalDirectLobbyAmt { get; set; }
//
//     [JsonProperty("TotalLobbyExpenditureAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalLobbyExpenditureAmt")]
//     public string TotalLobbyExpenditureAmt { get; set; }
//
//     [JsonProperty("OtherExemptPurposeExpendAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherExemptPurposeExpendAmt")]
//     public string OtherExemptPurposeExpendAmt { get; set; }
//
//     [JsonProperty("TotalExemptPurposeExpendAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExemptPurposeExpendAmt")]
//     public string TotalExemptPurposeExpendAmt { get; set; }
//
//     [JsonProperty("LobbyNontxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LobbyNontxAmt")]
//     public string LobbyNontxAmt { get; set; }
//
//     [JsonProperty("GrassrootsNontxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrassrootsNontxAmt")]
//     public string GrassrootsNontxAmt { get; set; }
//
//     [JsonProperty("TotalLobbyGrssrootMnsNontxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalLobbyGrssrootMnsNontxAmt")]
//     public string TotalLobbyGrssrootMnsNontxAmt { get; set; }
//
//     [JsonProperty("TotLbbyExpendMnsLobbyNontxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotLbbyExpendMnsLobbyNontxAmt")]
//     public string TotLbbyExpendMnsLobbyNontxAmt { get; set; }
//
//     [JsonProperty("ShareExcessLobbyExpendAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ShareExcessLobbyExpendAmt")]
//     public string ShareExcessLobbyExpendAmt { get; set; }
// }
//
// public class AffiliateListing
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("AffiliateListingGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AffiliateListingGrp")]
//     public List<AffiliateListingGrp> AffiliateListingGrp { get; } = new List<AffiliateListingGrp>();
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
// }
//
// public class AffiliateListingGrp
// {
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("EIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EIN")]
//     public string EIN { get; set; }
//
//     [JsonProperty("BusinessNameControlTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameControlTxt")]
//     public string BusinessNameControlTxt { get; set; }
// }
//
// public class AgriBiodieselMixtureCreditAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class AgriculturalChemicalsCreditGrp
// {
//     [JsonProperty("AgriculturalChemicalsCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AgriculturalChemicalsCreditAmt")]
//     public string AgriculturalChemicalsCreditAmt { get; set; }
// }
//
// public class AgriculturalNameAndAddressGrp
// {
//     [JsonProperty("CollegeUniversityName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CollegeUniversityName")]
//     public CollegeUniversityName CollegeUniversityName { get; set; }
//
//     [JsonProperty("CityNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CityNm")]
//     public string CityNm { get; set; }
//
//     [JsonProperty("StateAbbreviationCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StateAbbreviationCd")]
//     public string StateAbbreviationCd { get; set; }
// }
//
// public class AllOtherExpensesGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class AllOtherProgramRelatedInvstGrp
// {
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Amt")]
//     public string Amt { get; set; }
// }
//
// public class AllOthProgRltdInvestmentsSch
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("AllOtherProgramRelatedInvstGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AllOtherProgramRelatedInvstGrp")]
//     public AllOtherProgramRelatedInvstGrp AllOtherProgramRelatedInvstGrp { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class AllowableQlfyElectricVehGrp
// {
//     [JsonProperty("AllowableQualifiedElecVehAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AllowableQualifiedElecVehAmt")]
//     public string AllowableQualifiedElecVehAmt { get; set; }
// }
//
// public class AmortizationSchedule
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("AmortizationScheduleDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AmortizationScheduleDetail")]
//     public AmortizationScheduleDetail AmortizationScheduleDetail { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class AmortizationScheduleDetail
// {
//     [JsonProperty("AmortizedExpensesDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AmortizedExpensesDesc")]
//     public string AmortizedExpensesDesc { get; set; }
//
//     [JsonProperty("AcquiredCompletedOrExpendedDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AcquiredCompletedOrExpendedDt")]
//     public string AcquiredCompletedOrExpendedDt { get; set; }
//
//     [JsonProperty("AmortizedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AmortizedAmt")]
//     public string AmortizedAmt { get; set; }
//
//     [JsonProperty("DeductionForPriorYearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DeductionForPriorYearsAmt")]
//     public string DeductionForPriorYearsAmt { get; set; }
//
//     [JsonProperty("AmortizationPeriodRt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AmortizationPeriodRt")]
//     public string AmortizationPeriodRt { get; set; }
//
//     [JsonProperty("CurrentYearAmortizationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmortizationAmt")]
//     public string CurrentYearAmortizationAmt { get; set; }
//
//     [JsonProperty("AdjustedNetIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedNetIncomeAmt")]
//     public string AdjustedNetIncomeAmt { get; set; }
//
//     [JsonProperty("TotalAmortizationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmortizationAmt")]
//     public string TotalAmortizationAmt { get; set; }
//
//     [JsonProperty("NetInvestmentIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetInvestmentIncomeAmt")]
//     public string NetInvestmentIncomeAmt { get; set; }
// }
//
// public class AmountsRcvdDsqlfyPersonGrp
// {
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class AnalysisIncomeProducingActyGrp
// {
//     [JsonProperty("NetRentalIncomePersonalPropGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetRentalIncomePersonalPropGrp")]
//     public string NetRentalIncomePersonalPropGrp { get; set; }
//
//     [JsonProperty("OtherInvestmentIncmPartVIIGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherInvestmentIncmPartVIIGrp")]
//     public OtherInvestmentIncmPartVIIGrp OtherInvestmentIncmPartVIIGrp { get; set; }
//
//     [JsonProperty("GainSalesAstOthThanInvntryGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GainSalesAstOthThanInvntryGrp")]
//     public GainSalesAstOthThanInvntryGrp GainSalesAstOthThanInvntryGrp { get; set; }
//
//     [JsonProperty("NetIncomeLossFromSpecialEvtGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetIncomeLossFromSpecialEvtGrp")]
//     public string NetIncomeLossFromSpecialEvtGrp { get; set; }
//
//     [JsonProperty("GrossProfitLossSlsOfInvntryGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossProfitLossSlsOfInvntryGrp")]
//     public string GrossProfitLossSlsOfInvntryGrp { get; set; }
//
//     [JsonProperty("SubtotalsIncmProducingActyGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubtotalsIncmProducingActyGrp")]
//     public SubtotalsIncmProducingActyGrp SubtotalsIncmProducingActyGrp { get; set; }
//
//     [JsonProperty("TotalIncomeProducingActyAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalIncomeProducingActyAmt")]
//     public string TotalIncomeProducingActyAmt { get; set; }
//
//     [JsonProperty("ProgramServiceRevenueDtl", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServiceRevenueDtl")]
//     public List<ProgramServiceRevenueDtl> ProgramServiceRevenueDtl { get; } = new List<ProgramServiceRevenueDtl>();
//
//     [JsonProperty("DivAndIntFromSecPartVIIGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DivAndIntFromSecPartVIIGrp")]
//     public DivAndIntFromSecPartVIIGrp DivAndIntFromSecPartVIIGrp { get; set; }
//
//     [JsonProperty("IntOnSavAndTempCashInvstGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IntOnSavAndTempCashInvstGrp")]
//     public IntOnSavAndTempCashInvstGrp IntOnSavAndTempCashInvstGrp { get; set; }
//
//     [JsonProperty("FeesContractsFromGovtAgGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FeesContractsFromGovtAgGrp")]
//     public string FeesContractsFromGovtAgGrp { get; set; }
//
//     [JsonProperty("MembershipDuesAndAssmntGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MembershipDuesAndAssmntGrp")]
//     public string MembershipDuesAndAssmntGrp { get; set; }
//
//     [JsonProperty("NetRntlIncmReDebtFincdPropGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetRntlIncmReDebtFincdPropGrp")]
//     public string NetRntlIncmReDebtFincdPropGrp { get; set; }
//
//     [JsonProperty("NetRntlIncmReNotDebtFincdProp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetRntlIncmReNotDebtFincdProp")]
//     public string NetRntlIncmReNotDebtFincdProp { get; set; }
//
//     [JsonProperty("DividendsAndInterestFromSecDtl", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DividendsAndInterestFromSecDtl")]
//     public DividendsAndInterestFromSecDtl DividendsAndInterestFromSecDtl { get; set; }
//
//     [JsonProperty("OtherInvestmentIncomeGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherInvestmentIncomeGrp")]
//     public string OtherInvestmentIncomeGrp { get; set; }
//
//     [JsonProperty("OtherRevenueDescribedGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherRevenueDescribedGrp")]
//     public List<OtherRevenueDescribedGrp> OtherRevenueDescribedGrp { get; } = new List<OtherRevenueDescribedGrp>();
//
//     [JsonProperty("ProgramServiceRevPartVIIGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServiceRevPartVIIGrp")]
//     public ProgramServiceRevPartVIIGrp ProgramServiceRevPartVIIGrp { get; set; }
// }
//
// public class AnalysisOfRevenueAndExpenses
// {
//     [JsonProperty("ContriRcvdRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContriRcvdRevAndExpnssAmt")]
//     public string ContriRcvdRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("ScheduleBNotRequiredInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ScheduleBNotRequiredInd")]
//     public string ScheduleBNotRequiredInd { get; set; }
//
//     [JsonProperty("NetGainSaleAstRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetGainSaleAstRevAndExpnssAmt")]
//     public string NetGainSaleAstRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("GrossSalesPriceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossSalesPriceAmt")]
//     public string GrossSalesPriceAmt { get; set; }
//
//     [JsonProperty("TotalRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevAndExpnssAmt")]
//     public string TotalRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("TotalNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalNetInvstIncmAmt")]
//     public string TotalNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("TotalAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAdjNetIncmAmt")]
//     public string TotalAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("LegalFeesRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LegalFeesRevAndExpnssAmt")]
//     public LegalFeesRevAndExpnssAmt LegalFeesRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("LegalFeesNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LegalFeesNetInvstIncmAmt")]
//     public string LegalFeesNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("LegalFeesAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LegalFeesAdjNetIncmAmt")]
//     public string LegalFeesAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("LegalFeesDsbrsChrtblAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LegalFeesDsbrsChrtblAmt")]
//     public string LegalFeesDsbrsChrtblAmt { get; set; }
//
//     [JsonProperty("AccountingFeesRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AccountingFeesRevAndExpnssAmt")]
//     public AccountingFeesRevAndExpnssAmt AccountingFeesRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("AccountingFeesNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AccountingFeesNetInvstIncmAmt")]
//     public string AccountingFeesNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("AccountingFeesAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AccountingFeesAdjNetIncmAmt")]
//     public string AccountingFeesAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("AccountingFeesChrtblPrpsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AccountingFeesChrtblPrpsAmt")]
//     public string AccountingFeesChrtblPrpsAmt { get; set; }
//
//     [JsonProperty("OtherProfFeesRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherProfFeesRevAndExpnssAmt")]
//     public OtherProfFeesRevAndExpnssAmt OtherProfFeesRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("OtherProfFeesNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherProfFeesNetInvstIncmAmt")]
//     public string OtherProfFeesNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("OtherProfFeesAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherProfFeesAdjNetIncmAmt")]
//     public string OtherProfFeesAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("OtherProfFeesDsbrsChrtblAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherProfFeesDsbrsChrtblAmt")]
//     public string OtherProfFeesDsbrsChrtblAmt { get; set; }
//
//     [JsonProperty("TravConfMeetingRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TravConfMeetingRevAndExpnssAmt")]
//     public string TravConfMeetingRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("TravConfMeetingNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TravConfMeetingNetInvstIncmAmt")]
//     public string TravConfMeetingNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("TravConfMeetingAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TravConfMeetingAdjNetIncmAmt")]
//     public string TravConfMeetingAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("TravConfMeetingDsbrsChrtblAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TravConfMeetingDsbrsChrtblAmt")]
//     public string TravConfMeetingDsbrsChrtblAmt { get; set; }
//
//     [JsonProperty("PrintingAndPubRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrintingAndPubRevAndExpnssAmt")]
//     public string PrintingAndPubRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("PrintingAndPubNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrintingAndPubNetInvstIncmAmt")]
//     public string PrintingAndPubNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("PrintingAndPubAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrintingAndPubAdjNetIncmAmt")]
//     public string PrintingAndPubAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("PrintingAndPubDsbrsChrtblAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrintingAndPubDsbrsChrtblAmt")]
//     public string PrintingAndPubDsbrsChrtblAmt { get; set; }
//
//     [JsonProperty("OtherExpensesRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherExpensesRevAndExpnssAmt")]
//     public OtherExpensesRevAndExpnssAmt OtherExpensesRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("OtherExpensesNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherExpensesNetInvstIncmAmt")]
//     public string OtherExpensesNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("OtherExpensesAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherExpensesAdjNetIncmAmt")]
//     public string OtherExpensesAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("OtherExpensesDsbrsChrtblAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherExpensesDsbrsChrtblAmt")]
//     public string OtherExpensesDsbrsChrtblAmt { get; set; }
//
//     [JsonProperty("TotOprExpensesRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotOprExpensesRevAndExpnssAmt")]
//     public string TotOprExpensesRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("TotOprExpensesNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotOprExpensesNetInvstIncmAmt")]
//     public string TotOprExpensesNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("TotOprExpensesAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotOprExpensesAdjNetIncmAmt")]
//     public string TotOprExpensesAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("TotOprExpensesDsbrsChrtblAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotOprExpensesDsbrsChrtblAmt")]
//     public string TotOprExpensesDsbrsChrtblAmt { get; set; }
//
//     [JsonProperty("ContriPaidRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContriPaidRevAndExpnssAmt")]
//     public string ContriPaidRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("ContriPaidDsbrsChrtblAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContriPaidDsbrsChrtblAmt")]
//     public string ContriPaidDsbrsChrtblAmt { get; set; }
//
//     [JsonProperty("TotalExpensesRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensesRevAndExpnssAmt")]
//     public string TotalExpensesRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("TotalExpensesNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensesNetInvstIncmAmt")]
//     public string TotalExpensesNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("TotalExpensesAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensesAdjNetIncmAmt")]
//     public string TotalExpensesAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("TotalExpensesDsbrsChrtblAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensesDsbrsChrtblAmt")]
//     public string TotalExpensesDsbrsChrtblAmt { get; set; }
//
//     [JsonProperty("ExcessRevenueOverExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessRevenueOverExpensesAmt")]
//     public string ExcessRevenueOverExpensesAmt { get; set; }
//
//     [JsonProperty("NetInvestmentIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetInvestmentIncomeAmt")]
//     public string NetInvestmentIncomeAmt { get; set; }
//
//     [JsonProperty("AdjustedNetIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedNetIncomeAmt")]
//     public string AdjustedNetIncomeAmt { get; set; }
//
//     [JsonProperty("OtherIncomeRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherIncomeRevAndExpnssAmt")]
//     public OtherIncomeRevAndExpnssAmt OtherIncomeRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("CompOfcrDirTrstRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompOfcrDirTrstRevAndExpnssAmt")]
//     public string CompOfcrDirTrstRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("CompOfcrDirTrstAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompOfcrDirTrstAdjNetIncmAmt")]
//     public string CompOfcrDirTrstAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("CompOfcrDirTrstDsbrsChrtblAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompOfcrDirTrstDsbrsChrtblAmt")]
//     public string CompOfcrDirTrstDsbrsChrtblAmt { get; set; }
//
//     [JsonProperty("DividendsRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DividendsRevAndExpnssAmt")]
//     public string DividendsRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("DividendsNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DividendsNetInvstIncmAmt")]
//     public string DividendsNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("DividendsAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DividendsAdjNetIncmAmt")]
//     public string DividendsAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("CapGainNetIncmNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CapGainNetIncmNetInvstIncmAmt")]
//     public string CapGainNetIncmNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("GrossProfitRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossProfitRevAndExpnssAmt")]
//     public GrossProfitRevAndExpnssAmt GrossProfitRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("CompOfcrDirTrstNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompOfcrDirTrstNetInvstIncmAmt")]
//     public string CompOfcrDirTrstNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("TaxesRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxesRevAndExpnssAmt")]
//     public TaxesRevAndExpnssAmt TaxesRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("TaxesAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxesAdjNetIncmAmt")]
//     public string TaxesAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("DeprecAndDpltnRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DeprecAndDpltnRevAndExpnssAmt")]
//     public DeprecAndDpltnRevAndExpnssAmt DeprecAndDpltnRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("InterestOnSavRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InterestOnSavRevAndExpnssAmt")]
//     public string InterestOnSavRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("InterestOnSavNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InterestOnSavNetInvstIncmAmt")]
//     public string InterestOnSavNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("InterestOnSavingsAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InterestOnSavingsAdjNetIncmAmt")]
//     public string InterestOnSavingsAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("NetSTCapitalGainAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetSTCapitalGainAdjNetIncmAmt")]
//     public string NetSTCapitalGainAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("TaxesNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxesNetInvstIncmAmt")]
//     public string TaxesNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("OthEmplSlrsWgsNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OthEmplSlrsWgsNetInvstIncmAmt")]
//     public string OthEmplSlrsWgsNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("OthEmplSlrsWgsAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OthEmplSlrsWgsAdjNetIncmAmt")]
//     public string OthEmplSlrsWgsAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("OthEmplSlrsWgsDsbrsChrtblAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OthEmplSlrsWgsDsbrsChrtblAmt")]
//     public string OthEmplSlrsWgsDsbrsChrtblAmt { get; set; }
//
//     [JsonProperty("PensionEmplBnftNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PensionEmplBnftNetInvstIncmAmt")]
//     public string PensionEmplBnftNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("PensionEmplBnftAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PensionEmplBnftAdjNetIncmAmt")]
//     public string PensionEmplBnftAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("InterestDsbrsChrtblAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InterestDsbrsChrtblAmt")]
//     public string InterestDsbrsChrtblAmt { get; set; }
//
//     [JsonProperty("TaxesDsbrsChrtblAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxesDsbrsChrtblAmt")]
//     public string TaxesDsbrsChrtblAmt { get; set; }
//
//     [JsonProperty("DeprecAndDpltnNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DeprecAndDpltnNetInvstIncmAmt")]
//     public string DeprecAndDpltnNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("OtherIncomeNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherIncomeNetInvstIncmAmt")]
//     public string OtherIncomeNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("OthEmplSlrsWgsRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OthEmplSlrsWgsRevAndExpnssAmt")]
//     public string OthEmplSlrsWgsRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("PensionEmplBnftRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PensionEmplBnftRevAndExpnssAmt")]
//     public string PensionEmplBnftRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("PensionEmplBnftDsbrsChrtblAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PensionEmplBnftDsbrsChrtblAmt")]
//     public string PensionEmplBnftDsbrsChrtblAmt { get; set; }
//
//     [JsonProperty("OccupancyRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OccupancyRevAndExpnssAmt")]
//     public string OccupancyRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("OccupancyNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OccupancyNetInvstIncmAmt")]
//     public string OccupancyNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("OccupancyAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OccupancyAdjNetIncmAmt")]
//     public string OccupancyAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("OccupancyDsbrsChrtblAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OccupancyDsbrsChrtblAmt")]
//     public string OccupancyDsbrsChrtblAmt { get; set; }
//
//     [JsonProperty("InterestRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InterestRevAndExpnssAmt")]
//     public string InterestRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("InterestNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InterestNetInvstIncmAmt")]
//     public string InterestNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("GrossRentsRevAndExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossRentsRevAndExpnssAmt")]
//     public string GrossRentsRevAndExpnssAmt { get; set; }
//
//     [JsonProperty("GrossRentsNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossRentsNetInvstIncmAmt")]
//     public string GrossRentsNetInvstIncmAmt { get; set; }
//
//     [JsonProperty("GrossRentsAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossRentsAdjNetIncmAmt")]
//     public string GrossRentsAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("NetRentalIncomeOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetRentalIncomeOrLossAmt")]
//     public string NetRentalIncomeOrLossAmt { get; set; }
//
//     [JsonProperty("IncmModificationsAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IncmModificationsAdjNetIncmAmt")]
//     public string IncmModificationsAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("GrossSalesLessRetAndAllwncAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossSalesLessRetAndAllwncAmt")]
//     public string GrossSalesLessRetAndAllwncAmt { get; set; }
//
//     [JsonProperty("CostOfGoodsSoldAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CostOfGoodsSoldAmt")]
//     public string CostOfGoodsSoldAmt { get; set; }
//
//     [JsonProperty("GrossProfitAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossProfitAdjNetIncmAmt")]
//     public string GrossProfitAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("OtherIncomeAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherIncomeAdjNetIncmAmt")]
//     public string OtherIncomeAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("InterestAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InterestAdjNetIncmAmt")]
//     public string InterestAdjNetIncmAmt { get; set; }
//
//     [JsonProperty("DeprecAndDpltnAdjNetIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DeprecAndDpltnAdjNetIncmAmt")]
//     public string DeprecAndDpltnAdjNetIncmAmt { get; set; }
// }
//
// public class ApplicationSubmissionInfoGrp
// {
//     [JsonProperty("RecipientPersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecipientPersonNm")]
//     public string RecipientPersonNm { get; set; }
//
//     [JsonProperty("RecipientUSAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecipientUSAddress")]
//     public RecipientUSAddress RecipientUSAddress { get; set; }
//
//     [JsonProperty("RecipientPhoneNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecipientPhoneNum")]
//     public string RecipientPhoneNum { get; set; }
//
//     [JsonProperty("FormAndInfoAndMaterialsTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FormAndInfoAndMaterialsTxt")]
//     public string FormAndInfoAndMaterialsTxt { get; set; }
//
//     [JsonProperty("SubmissionDeadlinesTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubmissionDeadlinesTxt")]
//     public string SubmissionDeadlinesTxt { get; set; }
//
//     [JsonProperty("RestrictionsOnAwardsTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RestrictionsOnAwardsTxt")]
//     public string RestrictionsOnAwardsTxt { get; set; }
//
//     [JsonProperty("RecipientEmailAddressTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecipientEmailAddressTxt")]
//     public string RecipientEmailAddressTxt { get; set; }
// }
//
// public class AppliedToPriorYearElection
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("ElectionDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ElectionDesc")]
//     public string ElectionDesc { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class ArtPublicExhibitionAmountsGrp
// {
//     [JsonProperty("RevenuesIncludedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RevenuesIncludedAmt")]
//     public string RevenuesIncludedAmt { get; set; }
//
//     [JsonProperty("AssetsIncludedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AssetsIncludedAmt")]
//     public string AssetsIncludedAmt { get; set; }
// }
//
// public class AuditedFinancialStmtAttInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class AverageMonthlyCashBalancesGrp
// {
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class AverageMonthlyFMVOfSecGrp
// {
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class AveragingAttachment
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("ExplanationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExplanationTxt")]
//     public string ExplanationTxt { get; set; }
// }
//
// public class AvgGrassrootsLobbyingExpendGrp
// {
//     [JsonProperty("CurrentYearMinus3Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearMinus3Amt")]
//     public string CurrentYearMinus3Amt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("CurrentYearMinus2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearMinus2Amt")]
//     public string CurrentYearMinus2Amt { get; set; }
//
//     [JsonProperty("CurrentYearMinus1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearMinus1Amt")]
//     public string CurrentYearMinus1Amt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class AvgGrassrootsNontaxableGrp
// {
//     [JsonProperty("CurrentYearMinus3Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearMinus3Amt")]
//     public string CurrentYearMinus3Amt { get; set; }
//
//     [JsonProperty("CurrentYearMinus2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearMinus2Amt")]
//     public string CurrentYearMinus2Amt { get; set; }
//
//     [JsonProperty("CurrentYearMinus1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearMinus1Amt")]
//     public string CurrentYearMinus1Amt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class AvgLobbyingNontaxableAmountGrp
// {
//     [JsonProperty("CurrentYearMinus3Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearMinus3Amt")]
//     public string CurrentYearMinus3Amt { get; set; }
//
//     [JsonProperty("CurrentYearMinus2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearMinus2Amt")]
//     public string CurrentYearMinus2Amt { get; set; }
//
//     [JsonProperty("CurrentYearMinus1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearMinus1Amt")]
//     public string CurrentYearMinus1Amt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class AvgTotalLobbyingExpendGrp
// {
//     [JsonProperty("CurrentYearMinus3Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearMinus3Amt")]
//     public string CurrentYearMinus3Amt { get; set; }
//
//     [JsonProperty("CurrentYearMinus2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearMinus2Amt")]
//     public string CurrentYearMinus2Amt { get; set; }
//
//     [JsonProperty("CurrentYearMinus1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearMinus1Amt")]
//     public string CurrentYearMinus1Amt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class AviationGasolineCreditAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class AviationNontxGasCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class BackupWithholdingAmt
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
//
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
// }
//
// public class BenefitsToMembersGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
// }
//
// public class BiodieselMixtureCreditAmt
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class BiofuelProducerCreditGrp
// {
//     [JsonProperty("BiofuelProducerCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BiofuelProducerCreditAmt")]
//     public string BiofuelProducerCreditAmt { get; set; }
// }
//
// public class BlndrCrUseDslWtrEmulsionCrAmt
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class BooksInCareOfDetail
// {
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
//
//     [JsonProperty("PhoneNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PhoneNum")]
//     public string PhoneNum { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("PersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonNm")]
//     public string PersonNm { get; set; }
//
//     [JsonProperty("ForeignAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignAddress")]
//     public ForeignAddress ForeignAddress { get; set; }
//
//     [JsonProperty("ForeignPhoneNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignPhoneNum")]
//     public string ForeignPhoneNum { get; set; }
// }
//
// public class BorrowedFundsElection
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("BorrowedFundsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BorrowedFundsGrp")]
//     public BorrowedFundsGrp BorrowedFundsGrp { get; set; }
// }
//
// public class BorrowedFundsGrp
// {
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("BorrowedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BorrowedAmt")]
//     public string BorrowedAmt { get; set; }
//
//     [JsonProperty("UseOfBorrowedFundsTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UseOfBorrowedFundsTxt")]
//     public string UseOfBorrowedFundsTxt { get; set; }
// }
//
// public class BorrowerNameGrp
// {
//     [JsonProperty("PersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonNm")]
//     public string PersonNm { get; set; }
// }
//
// public class BuildingsGrp
// {
//     [JsonProperty("OtherCostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherCostOrOtherBasisAmt")]
//     public string OtherCostOrOtherBasisAmt { get; set; }
//
//     [JsonProperty("DepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationAmt")]
//     public string DepreciationAmt { get; set; }
//
//     [JsonProperty("BookValueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BookValueAmt")]
//     public string BookValueAmt { get; set; }
//
//     [JsonProperty("InvestmentCostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentCostOrOtherBasisAmt")]
//     public string InvestmentCostOrOtherBasisAmt { get; set; }
// }
//
// public class BusinessCreditsGrp
// {
//     [JsonProperty("CYIncreasingResearchCrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYIncreasingResearchCrGrp")]
//     public CYIncreasingResearchCrGrp CYIncreasingResearchCrGrp { get; set; }
//
//     [JsonProperty("CYRenewableElectricityCrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYRenewableElectricityCrGrp")]
//     public CYRenewableElectricityCrGrp CYRenewableElectricityCrGrp { get; set; }
//
//     [JsonProperty("CYEmplrProvChildCareFcltsCrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYEmplrProvChildCareFcltsCrGrp")]
//     public CYEmplrProvChildCareFcltsCrGrp CYEmplrProvChildCareFcltsCrGrp { get; set; }
//
//     [JsonProperty("CurrentYearGeneralBusCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearGeneralBusCrAmt")]
//     public string CurrentYearGeneralBusCrAmt { get; set; }
//
//     [JsonProperty("TotalBusinessCreditsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalBusinessCreditsAmt")]
//     public string TotalBusinessCreditsAmt { get; set; }
//
//     [JsonProperty("WorkOpportunityCrFrom5884Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("WorkOpportunityCrFrom5884Grp")]
//     public WorkOpportunityCrFrom5884Grp WorkOpportunityCrFrom5884Grp { get; set; }
//
//     [JsonProperty("CrForEmployerSSMedicareTaxGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CrForEmployerSSMedicareTaxGrp")]
//     public CrForEmployerSSMedicareTaxGrp CrForEmployerSSMedicareTaxGrp { get; set; }
//
//     [JsonProperty("SumOfAllowableGeneralBusCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SumOfAllowableGeneralBusCrAmt")]
//     public string SumOfAllowableGeneralBusCrAmt { get; set; }
//
//     [JsonProperty("CurrentYearInvestmentCreditGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearInvestmentCreditGrp")]
//     public CurrentYearInvestmentCreditGrp CurrentYearInvestmentCreditGrp { get; set; }
//
//     [JsonProperty("CYAdvncManufacturingProdCrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYAdvncManufacturingProdCrGrp")]
//     public CYAdvncManufacturingProdCrGrp CYAdvncManufacturingProdCrGrp { get; set; }
//
//     [JsonProperty("CYLowIncomeHousingCrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYLowIncomeHousingCrGrp")]
//     public CYLowIncomeHousingCrGrp CYLowIncomeHousingCrGrp { get; set; }
//
//     [JsonProperty("CurrentYearDisabledAccessCrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearDisabledAccessCrGrp")]
//     public CurrentYearDisabledAccessCrGrp CurrentYearDisabledAccessCrGrp { get; set; }
//
//     [JsonProperty("CurrentYearIndianEmplmnCrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearIndianEmplmnCrGrp")]
//     public CurrentYearIndianEmplmnCrGrp CurrentYearIndianEmplmnCrGrp { get; set; }
//
//     [JsonProperty("CurrentYearOrphanDrugCreditGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearOrphanDrugCreditGrp")]
//     public CurrentYearOrphanDrugCreditGrp CurrentYearOrphanDrugCreditGrp { get; set; }
//
//     [JsonProperty("CurrentYearNewMarketsCreditGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearNewMarketsCreditGrp")]
//     public CurrentYearNewMarketsCreditGrp CurrentYearNewMarketsCreditGrp { get; set; }
//
//     [JsonProperty("CYSmallEmployerPensionPlanGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYSmallEmployerPensionPlanGrp")]
//     public CYSmallEmployerPensionPlanGrp CYSmallEmployerPensionPlanGrp { get; set; }
//
//     [JsonProperty("CYBiodieselRnwblAvnFuelCrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYBiodieselRnwblAvnFuelCrGrp")]
//     public CYBiodieselRnwblAvnFuelCrGrp CYBiodieselRnwblAvnFuelCrGrp { get; set; }
//
//     [JsonProperty("CYLowSulfurDieselCreditGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYLowSulfurDieselCreditGrp")]
//     public CYLowSulfurDieselCreditGrp CYLowSulfurDieselCreditGrp { get; set; }
//
//     [JsonProperty("DistilledSpiritsCreditGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistilledSpiritsCreditGrp")]
//     public DistilledSpiritsCreditGrp DistilledSpiritsCreditGrp { get; set; }
//
//     [JsonProperty("CYNonconventionalFuelCreditGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYNonconventionalFuelCreditGrp")]
//     public CYNonconventionalFuelCreditGrp CYNonconventionalFuelCreditGrp { get; set; }
//
//     [JsonProperty("CYEnergyEfficientHomeCreditGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYEnergyEfficientHomeCreditGrp")]
//     public CYEnergyEfficientHomeCreditGrp CYEnergyEfficientHomeCreditGrp { get; set; }
//
//     [JsonProperty("CYEnergyEfficientApplianceGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYEnergyEfficientApplianceGrp")]
//     public CYEnergyEfficientApplianceGrp CYEnergyEfficientApplianceGrp { get; set; }
//
//     [JsonProperty("CYAlternativeMotorVehicleCrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYAlternativeMotorVehicleCrGrp")]
//     public CYAlternativeMotorVehicleCrGrp CYAlternativeMotorVehicleCrGrp { get; set; }
//
//     [JsonProperty("CYAlternativeRefuelingCrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYAlternativeRefuelingCrGrp")]
//     public CYAlternativeRefuelingCrGrp CYAlternativeRefuelingCrGrp { get; set; }
//
//     [JsonProperty("CYEnhancedOilRecoveryCreditGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYEnhancedOilRecoveryCreditGrp")]
//     public CYEnhancedOilRecoveryCreditGrp CYEnhancedOilRecoveryCreditGrp { get; set; }
//
//     [JsonProperty("MineRescueTeamTrainingCrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MineRescueTeamTrainingCrGrp")]
//     public MineRescueTeamTrainingCrGrp MineRescueTeamTrainingCrGrp { get; set; }
//
//     [JsonProperty("AgriculturalChemicalsCreditGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AgriculturalChemicalsCreditGrp")]
//     public AgriculturalChemicalsCreditGrp AgriculturalChemicalsCreditGrp { get; set; }
//
//     [JsonProperty("DifferentialWagePaymentsCrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DifferentialWagePaymentsCrGrp")]
//     public DifferentialWagePaymentsCrGrp DifferentialWagePaymentsCrGrp { get; set; }
//
//     [JsonProperty("CarbonDioxideCreditGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CarbonDioxideCreditGrp")]
//     public CarbonDioxideCreditGrp CarbonDioxideCreditGrp { get; set; }
//
//     [JsonProperty("QlfyPlugInElecDriveMtrVehCrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("QlfyPlugInElecDriveMtrVehCrGrp")]
//     public QlfyPlugInElecDriveMtrVehCrGrp QlfyPlugInElecDriveMtrVehCrGrp { get; set; }
//
//     [JsonProperty("AllowableQlfyElectricVehGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AllowableQlfyElectricVehGrp")]
//     public AllowableQlfyElectricVehGrp AllowableQlfyElectricVehGrp { get; set; }
//
//     [JsonProperty("EmployeeRetentionCreditGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EmployeeRetentionCreditGrp")]
//     public EmployeeRetentionCreditGrp EmployeeRetentionCreditGrp { get; set; }
//
//     [JsonProperty("CYGenBusCrElectingLgePrtshpGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYGenBusCrElectingLgePrtshpGrp")]
//     public CYGenBusCrElectingLgePrtshpGrp CYGenBusCrElectingLgePrtshpGrp { get; set; }
//
//     [JsonProperty("OtherCurrentYearCreditAmtGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherCurrentYearCreditAmtGrp")]
//     public OtherCurrentYearCreditAmtGrp OtherCurrentYearCreditAmtGrp { get; set; }
//
//     [JsonProperty("EnterAmountFromF8844Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EnterAmountFromF8844Grp")]
//     public EnterAmountFromF8844Grp EnterAmountFromF8844Grp { get; set; }
//
//     [JsonProperty("InvestmentCreditGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentCreditGrp")]
//     public InvestmentCreditGrp InvestmentCreditGrp { get; set; }
//
//     [JsonProperty("BiofuelProducerCreditGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BiofuelProducerCreditGrp")]
//     public BiofuelProducerCreditGrp BiofuelProducerCreditGrp { get; set; }
//
//     [JsonProperty("LowIncomeHousingCreditGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LowIncomeHousingCreditGrp")]
//     public LowIncomeHousingCreditGrp LowIncomeHousingCreditGrp { get; set; }
//
//     [JsonProperty("RenewableElectricityProdCrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RenewableElectricityProdCrGrp")]
//     public RenewableElectricityProdCrGrp RenewableElectricityProdCrGrp { get; set; }
//
//     [JsonProperty("QualifiedRailroadTrackMaintGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("QualifiedRailroadTrackMaintGrp")]
//     public QualifiedRailroadTrackMaintGrp QualifiedRailroadTrackMaintGrp { get; set; }
//
//     [JsonProperty("SmallEmployerHIPCreditAmtGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SmallEmployerHIPCreditAmtGrp")]
//     public SmallEmployerHIPCreditAmtGrp SmallEmployerHIPCreditAmtGrp { get; set; }
//
//     [JsonProperty("IncreasingResearchCrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IncreasingResearchCrGrp")]
//     public IncreasingResearchCrGrp IncreasingResearchCrGrp { get; set; }
//
//     [JsonProperty("EmplrCrPdFamilyMedLeaveGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EmplrCrPdFamilyMedLeaveGrp")]
//     public EmplrCrPdFamilyMedLeaveGrp EmplrCrPdFamilyMedLeaveGrp { get; set; }
//
//     [JsonProperty("OtherSpecifiedCreditAmtGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherSpecifiedCreditAmtGrp")]
//     public OtherSpecifiedCreditAmtGrp OtherSpecifiedCreditAmtGrp { get; set; }
//
//     [JsonProperty("CurrentYearBiodieselFuelCrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearBiodieselFuelCrGrp")]
//     public CurrentYearBiodieselFuelCrGrp CurrentYearBiodieselFuelCrGrp { get; set; }
//
//     [JsonProperty("RnwblElecCoalCrFromF8835Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RnwblElecCoalCrFromF8835Grp")]
//     public RnwblElecCoalCrFromF8835Grp RnwblElecCoalCrFromF8835Grp { get; set; }
// }
//
// public class BusinessName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
//
//     [JsonProperty("BusinessNameLine2Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine2Txt")]
//     public string BusinessNameLine2Txt { get; set; }
// }
//
// public class BusinessOfficerGrp
// {
//     [JsonProperty("PersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonNm")]
//     public string PersonNm { get; set; }
//
//     [JsonProperty("PersonTitleTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonTitleTxt")]
//     public string PersonTitleTxt { get; set; }
//
//     [JsonProperty("PhoneNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PhoneNum")]
//     public string PhoneNum { get; set; }
//
//     [JsonProperty("SignatureDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SignatureDt")]
//     public string SignatureDt { get; set; }
//
//     [JsonProperty("DiscussWithPaidPreparerInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DiscussWithPaidPreparerInd")]
//     public string DiscussWithPaidPreparerInd { get; set; }
//
//     [JsonProperty("ForeignPhoneNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignPhoneNum")]
//     public string ForeignPhoneNum { get; set; }
// }
//
// public class BusTrInvolveInterestedPrsnGrp
// {
//     [JsonProperty("NameOfInterested", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NameOfInterested")]
//     public NameOfInterested NameOfInterested { get; set; }
//
//     [JsonProperty("RelationshipDescriptionTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelationshipDescriptionTxt")]
//     public string RelationshipDescriptionTxt { get; set; }
//
//     [JsonProperty("TransactionDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransactionDesc")]
//     public string TransactionDesc { get; set; }
//
//     [JsonProperty("SharingOfRevenuesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SharingOfRevenuesInd")]
//     public string SharingOfRevenuesInd { get; set; }
// }
//
// public class BusUseOfUndyedDieselCreditAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class BusUseOfUndyedKeroseneCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class CapGainsLossTxInvstIncmDetail
// {
//     [JsonProperty("CapGainsLossTxInvstIncmGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CapGainsLossTxInvstIncmGrp")]
//     public List<CapGainsLossTxInvstIncmGrp> CapGainsLossTxInvstIncmGrp { get; } =
//         new List<CapGainsLossTxInvstIncmGrp>();
//
//     [JsonProperty("CapitalGainNetIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CapitalGainNetIncomeAmt")]
//     public string CapitalGainNetIncomeAmt { get; set; }
// }
//
// public class CapGainsLossTxInvstIncmGrp
// {
//     [JsonProperty("PropertyDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PropertyDesc")]
//     public string PropertyDesc { get; set; }
//
//     [JsonProperty("HowAcquiredCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HowAcquiredCd")]
//     public string HowAcquiredCd { get; set; }
//
//     [JsonProperty("AcquiredDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AcquiredDt")]
//     public string AcquiredDt { get; set; }
//
//     [JsonProperty("SoldDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SoldDt")]
//     public string SoldDt { get; set; }
//
//     [JsonProperty("GrossSalesPriceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossSalesPriceAmt")]
//     public string GrossSalesPriceAmt { get; set; }
//
//     [JsonProperty("CostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CostOrOtherBasisAmt")]
//     public string CostOrOtherBasisAmt { get; set; }
//
//     [JsonProperty("GainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GainOrLossAmt")]
//     public string GainOrLossAmt { get; set; }
//
//     [JsonProperty("GainsMinusExcessOrLossesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GainsMinusExcessOrLossesAmt")]
//     public string GainsMinusExcessOrLossesAmt { get; set; }
// }
//
// public class CapitalGainAndLossAssetGrp
// {
//     [JsonProperty("PropertyDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PropertyDesc")]
//     public string PropertyDesc { get; set; }
//
//     [JsonProperty("GainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GainOrLossAmt")]
//     public string GainOrLossAmt { get; set; }
// }
//
// public class CapitalGainNetIncomeAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class CapStkTrPrinCurrentFundsGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class CarbonDioxideCreditGrp
// {
//     [JsonProperty("CarbonDioxideCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CarbonDioxideCreditAmt")]
//     public string CarbonDioxideCreditAmt { get; set; }
// }
//
// public class CarsAndOtherVehiclesGrp
// {
//     [JsonProperty("NonCashCheckboxInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashCheckboxInd")]
//     public string NonCashCheckboxInd { get; set; }
//
//     [JsonProperty("ContributionCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributionCnt")]
//     public string ContributionCnt { get; set; }
//
//     [JsonProperty("NoncashContributionsRptF990Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NoncashContributionsRptF990Amt")]
//     public string NoncashContributionsRptF990Amt { get; set; }
//
//     [JsonProperty("MethodOfDeterminingRevenuesTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfDeterminingRevenuesTxt")]
//     public string MethodOfDeterminingRevenuesTxt { get; set; }
// }
//
// public class CashAndInKindContributionsGrp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
// }
//
// public class CashDeemedCharitableExplnStmt
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("ShortExplanationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ShortExplanationTxt")]
//     public string ShortExplanationTxt { get; set; }
// }
//
// public class CashDeemedCharitableGrp
// {
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class CashDistributionExplnStmt
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("ExplanationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExplanationTxt")]
//     public string ExplanationTxt { get; set; }
// }
//
// public class CashNonInterestBearingGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class CashSavingsAndInvestmentsGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class CharitableContributionsDetail
// {
//     [JsonProperty("ContributorNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributorNum")]
//     public string ContributorNum { get; set; }
//
//     [JsonProperty("GiftPurposeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GiftPurposeTxt")]
//     public string GiftPurposeTxt { get; set; }
//
//     [JsonProperty("GiftUseTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GiftUseTxt")]
//     public string GiftUseTxt { get; set; }
//
//     [JsonProperty("HowGiftIsHeldDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HowGiftIsHeldDesc")]
//     public string HowGiftIsHeldDesc { get; set; }
//
//     [JsonProperty("RlnOfTransferorToTransfereeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RlnOfTransferorToTransfereeTxt")]
//     public string RlnOfTransferorToTransfereeTxt { get; set; }
// }
//
// public class ChgInNetAssetsFundBalancesGrp
// {
//     [JsonProperty("TotNetAstOrFundBalancesBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotNetAstOrFundBalancesBOYAmt")]
//     public string TotNetAstOrFundBalancesBOYAmt { get; set; }
//
//     [JsonProperty("ExcessRevenueOverExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessRevenueOverExpensesAmt")]
//     public string ExcessRevenueOverExpensesAmt { get; set; }
//
//     [JsonProperty("SubtotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubtotalAmt")]
//     public string SubtotalAmt { get; set; }
//
//     [JsonProperty("TotNetAstOrFundBalancesEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotNetAstOrFundBalancesEOYAmt")]
//     public string TotNetAstOrFundBalancesEOYAmt { get; set; }
//
//     [JsonProperty("OtherDecreasesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherDecreasesAmt")]
//     public string OtherDecreasesAmt { get; set; }
//
//     [JsonProperty("OtherIncreasesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherIncreasesAmt")]
//     public string OtherIncreasesAmt { get; set; }
// }
//
// public class ClothingAndHouseholdGoodsGrp
// {
//     [JsonProperty("NonCashCheckboxInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashCheckboxInd")]
//     public string NonCashCheckboxInd { get; set; }
//
//     [JsonProperty("NoncashContributionsRptF990Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NoncashContributionsRptF990Amt")]
//     public string NoncashContributionsRptF990Amt { get; set; }
//
//     [JsonProperty("MethodOfDeterminingRevenuesTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfDeterminingRevenuesTxt")]
//     public string MethodOfDeterminingRevenuesTxt { get; set; }
// }
//
// public class CoalitionBuildingGrp
// {
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
//
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
// }
//
// public class CollectionsOfArtInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class CollectionUsedOtherPurposesGrp
// {
//     [JsonProperty("CollectionUsedOtherPurposesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CollectionUsedOtherPurposesInd")]
//     public string CollectionUsedOtherPurposesInd { get; set; }
//
//     [JsonProperty("OtherPurposesDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherPurposesDesc")]
//     public string OtherPurposesDesc { get; set; }
// }
//
// public class CollegeUniversityName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
// }
//
// public class CommunityHealthServicesGrp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
// }
//
// public class CommunitySupportGrp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
// }
//
// public class CompCurrentOfcrDirectorsGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class CompDisqualPersonsGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class CompensationExplanation
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("CompensationExplanationGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompensationExplanationGrp")]
//     public List<CompensationExplanationGrp> CompensationExplanationGrp { get; } =
//         new List<CompensationExplanationGrp>();
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
// }
//
// public class CompensationExplanationGrp
// {
//     [JsonProperty("PersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonNm")]
//     public string PersonNm { get; set; }
// }
//
// public class CompensationHighestPaidEmplGrp
// {
//     [JsonProperty("PersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonNm")]
//     public string PersonNm { get; set; }
//
//     [JsonProperty("TitleTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TitleTxt")]
//     public string TitleTxt { get; set; }
//
//     [JsonProperty("AverageHoursPerWeekRt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AverageHoursPerWeekRt")]
//     public string AverageHoursPerWeekRt { get; set; }
//
//     [JsonProperty("CompensationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompensationAmt")]
//     public string CompensationAmt { get; set; }
//
//     [JsonProperty("EmployeeBenefitsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EmployeeBenefitsAmt")]
//     public string EmployeeBenefitsAmt { get; set; }
//
//     [JsonProperty("ExpenseAccountAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpenseAccountAmt")]
//     public string ExpenseAccountAmt { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("AverageHrsPerWkDevotedToPosRt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AverageHrsPerWkDevotedToPosRt")]
//     public string AverageHrsPerWkDevotedToPosRt { get; set; }
// }
//
// public class CompensationOfHghstPdCntrctGrp
// {
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("ServiceTypeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ServiceTypeTxt")]
//     public string ServiceTypeTxt { get; set; }
//
//     [JsonProperty("CompensationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompensationAmt")]
//     public string CompensationAmt { get; set; }
//
//     [JsonProperty("PersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonNm")]
//     public string PersonNm { get; set; }
//
//     [JsonProperty("ForeignAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignAddress")]
//     public ForeignAddress ForeignAddress { get; set; }
// }
//
// public class CompressedGasBiomassCreditAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class CompressedNaturalGasCreditAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ConferencesMeetingsGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class ConservationEasementsInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ConsolidatedAuditFinclStmtInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ConsolidatedBusinessCreditsGrp
// {
//     [JsonProperty("ConsolidatedSectionInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ConsolidatedSectionInd")]
//     public string ConsolidatedSectionInd { get; set; }
//
//     [JsonProperty("BusinessCreditsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessCreditsGrp")]
//     public BusinessCreditsGrp BusinessCreditsGrp { get; set; }
// }
//
// public class ContractorAddress
// {
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("ForeignAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignAddress")]
//     public ForeignAddress ForeignAddress { get; set; }
// }
//
// public class ContractorBusinessName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
// }
//
// public class ContractorCompensationExpln
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("ContractorCompExplnGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContractorCompExplnGrp")]
//     public ContractorCompExplnGrp ContractorCompExplnGrp { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
// }
//
// public class ContractorCompensationGrp
// {
//     [JsonProperty("ContractorName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContractorName")]
//     public ContractorName ContractorName { get; set; }
//
//     [JsonProperty("ContractorAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContractorAddress")]
//     public ContractorAddress ContractorAddress { get; set; }
//
//     [JsonProperty("ServicesDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ServicesDesc")]
//     public string ServicesDesc { get; set; }
//
//     [JsonProperty("CompensationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompensationAmt")]
//     public string CompensationAmt { get; set; }
// }
//
// public class ContractorCompExplnGrp
// {
//     [JsonProperty("ContractorPersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContractorPersonNm")]
//     public string ContractorPersonNm { get; set; }
//
//     [JsonProperty("ExplanationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExplanationTxt")]
//     public string ExplanationTxt { get; set; }
//
//     [JsonProperty("ContractorBusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContractorBusinessName")]
//     public ContractorBusinessName ContractorBusinessName { get; set; }
// }
//
// public class ContractorName
// {
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
//
//     [JsonProperty("PersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonNm")]
//     public string PersonNm { get; set; }
// }
//
// public class ContributorBusinessName
// {
//     [JsonProperty("BusinessNameLine1", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1")]
//     public string BusinessNameLine1 { get; set; }
// }
//
// public class ContributorInformationGrp
// {
//     [JsonProperty("ContributorNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributorNum")]
//     public string ContributorNum { get; set; }
//
//     [JsonProperty("ContributorBusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributorBusinessName")]
//     public ContributorBusinessName ContributorBusinessName { get; set; }
//
//     [JsonProperty("ContributorUSAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributorUSAddress")]
//     public ContributorUSAddress ContributorUSAddress { get; set; }
//
//     [JsonProperty("TotalContributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalContributionsAmt")]
//     public string TotalContributionsAmt { get; set; }
// }
//
// public class ContributorUSAddress
// {
//     [JsonProperty("AddressLine1", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine1")]
//     public string AddressLine1 { get; set; }
//
//     [JsonProperty("AddressLine2", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine2")]
//     public string AddressLine2 { get; set; }
//
//     [JsonProperty("City", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("City")]
//     public string City { get; set; }
//
//     [JsonProperty("State", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("State")]
//     public string State { get; set; }
//
//     [JsonProperty("ZIPCode", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ZIPCode")]
//     public string ZIPCode { get; set; }
// }
//
// public class CorporateBondsEOYAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
// }
//
// public class CorporateStockEOYAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class CostingMethodologyUsedGrp
// {
//     [JsonProperty("CostToChargeRatioInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CostToChargeRatioInd")]
//     public string CostToChargeRatioInd { get; set; }
//
//     [JsonProperty("OtherInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherInd")]
//     public string OtherInd { get; set; }
//
//     [JsonProperty("CostAccountingSystemInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CostAccountingSystemInd")]
//     public string CostAccountingSystemInd { get; set; }
// }
//
// public class CreditCounselingInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class CreditsAdjPaymentOtherInd
// {
//     [JsonProperty("@creditsAdjPaymentOtherAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditsAdjPaymentOtherAmt")]
//     public string CreditsAdjPaymentOtherAmt { get; set; }
//
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class CrForEmployerSSMedicareTaxGrp
// {
//     [JsonProperty("CreditForEmployerSSMedcrTxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CreditForEmployerSSMedcrTxAmt")]
//     public string CreditForEmployerSSMedcrTxAmt { get; set; }
//
//     [JsonProperty("PassThroughEntityEIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PassThroughEntityEIN")]
//     public string PassThroughEntityEIN { get; set; }
// }
//
// public class CurrentYearBiodieselFuelCrGrp
// {
//     [JsonProperty("CurrentYearBiodieselFuelCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearBiodieselFuelCrAmt")]
//     public string CurrentYearBiodieselFuelCrAmt { get; set; }
// }
//
// public class CurrentYearDisabledAccessCrGrp
// {
//     [JsonProperty("CurrentYearDisabledAccessCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearDisabledAccessCrAmt")]
//     public string CurrentYearDisabledAccessCrAmt { get; set; }
// }
//
// public class CurrentYearIndianEmplmnCrGrp
// {
//     [JsonProperty("CYIndianEmploymentCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYIndianEmploymentCreditAmt")]
//     public string CYIndianEmploymentCreditAmt { get; set; }
// }
//
// public class CurrentYearInvestmentCreditGrp
// {
//     [JsonProperty("CurrentYearInvestmentCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearInvestmentCreditAmt")]
//     public string CurrentYearInvestmentCreditAmt { get; set; }
// }
//
// public class CurrentYearNewMarketsCreditGrp
// {
//     [JsonProperty("CurrentYearNewMarketsCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearNewMarketsCreditAmt")]
//     public string CurrentYearNewMarketsCreditAmt { get; set; }
// }
//
// public class CurrentYearOrphanDrugCreditGrp
// {
//     [JsonProperty("CurrentYearOrphanDrugCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearOrphanDrugCreditAmt")]
//     public string CurrentYearOrphanDrugCreditAmt { get; set; }
// }
//
// public class CYAdvncManufacturingProdCrGrp
// {
//     [JsonProperty("AdvncManufacturingProdCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdvncManufacturingProdCrAmt")]
//     public string AdvncManufacturingProdCrAmt { get; set; }
// }
//
// public class CYAlternativeMotorVehicleCrGrp
// {
//     [JsonProperty("CurrentYearAltMtrVehCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAltMtrVehCrAmt")]
//     public string CurrentYearAltMtrVehCrAmt { get; set; }
// }
//
// public class CYAlternativeRefuelingCrGrp
// {
//     [JsonProperty("CurrentYearAltRefuelingCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAltRefuelingCrAmt")]
//     public string CurrentYearAltRefuelingCrAmt { get; set; }
// }
//
// public class CYBiodieselRnwblAvnFuelCrGrp
// {
//     [JsonProperty("BiodieselRnwblAvnFuelCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BiodieselRnwblAvnFuelCrAmt")]
//     public string BiodieselRnwblAvnFuelCrAmt { get; set; }
// }
//
// public class CYEmplrProvChildCareFcltsCrGrp
// {
//     [JsonProperty("CYEmplrProvChldCareFcltsCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYEmplrProvChldCareFcltsCrAmt")]
//     public string CYEmplrProvChldCareFcltsCrAmt { get; set; }
// }
//
// public class CYEndwmtFundGrp
// {
//     [JsonProperty("BeginningYearBalanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BeginningYearBalanceAmt")]
//     public string BeginningYearBalanceAmt { get; set; }
//
//     [JsonProperty("InvestmentEarningsOrLossesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentEarningsOrLossesAmt")]
//     public string InvestmentEarningsOrLossesAmt { get; set; }
//
//     [JsonProperty("EndYearBalanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EndYearBalanceAmt")]
//     public string EndYearBalanceAmt { get; set; }
//
//     [JsonProperty("ContributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributionsAmt")]
//     public string ContributionsAmt { get; set; }
//
//     [JsonProperty("GrantsOrScholarshipsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsOrScholarshipsAmt")]
//     public string GrantsOrScholarshipsAmt { get; set; }
//
//     [JsonProperty("OtherExpendituresAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherExpendituresAmt")]
//     public string OtherExpendituresAmt { get; set; }
//
//     [JsonProperty("AdministrativeExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdministrativeExpensesAmt")]
//     public string AdministrativeExpensesAmt { get; set; }
// }
//
// public class CYEnergyEfficientApplianceGrp
// {
//     [JsonProperty("CYEngyEfficientApplianceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYEngyEfficientApplianceAmt")]
//     public string CYEngyEfficientApplianceAmt { get; set; }
// }
//
// public class CYEnergyEfficientHomeCreditGrp
// {
//     [JsonProperty("CurrentYrEngyEfficientHmCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYrEngyEfficientHmCrAmt")]
//     public string CurrentYrEngyEfficientHmCrAmt { get; set; }
// }
//
// public class CYEnhancedOilRecoveryCreditGrp
// {
//     [JsonProperty("EnhancedOilRecoveryCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EnhancedOilRecoveryCreditAmt")]
//     public string EnhancedOilRecoveryCreditAmt { get; set; }
// }
//
// public class CYGenBusCrElectingLgePrtshpGrp
// {
//     [JsonProperty("CYGenBusCrElectingLgePrtshpAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYGenBusCrElectingLgePrtshpAmt")]
//     public string CYGenBusCrElectingLgePrtshpAmt { get; set; }
// }
//
// public class CYIncreasingResearchCrGrp
// {
//     [JsonProperty("CYIncreasingResearchCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYIncreasingResearchCrAmt")]
//     public string CYIncreasingResearchCrAmt { get; set; }
// }
//
// public class CYLowIncomeHousingCrGrp
// {
//     [JsonProperty("CurrentYearLowIncomeHsngCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearLowIncomeHsngCrAmt")]
//     public string CurrentYearLowIncomeHsngCrAmt { get; set; }
// }
//
// public class CYLowSulfurDieselCreditGrp
// {
//     [JsonProperty("CurrentYearLowSulfurDslCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearLowSulfurDslCrAmt")]
//     public string CurrentYearLowSulfurDslCrAmt { get; set; }
// }
//
// public class CYMinus1YrEndwmtFundGrp
// {
//     [JsonProperty("BeginningYearBalanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BeginningYearBalanceAmt")]
//     public string BeginningYearBalanceAmt { get; set; }
//
//     [JsonProperty("InvestmentEarningsOrLossesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentEarningsOrLossesAmt")]
//     public string InvestmentEarningsOrLossesAmt { get; set; }
//
//     [JsonProperty("EndYearBalanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EndYearBalanceAmt")]
//     public string EndYearBalanceAmt { get; set; }
//
//     [JsonProperty("ContributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributionsAmt")]
//     public string ContributionsAmt { get; set; }
//
//     [JsonProperty("GrantsOrScholarshipsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsOrScholarshipsAmt")]
//     public string GrantsOrScholarshipsAmt { get; set; }
//
//     [JsonProperty("OtherExpendituresAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherExpendituresAmt")]
//     public string OtherExpendituresAmt { get; set; }
//
//     [JsonProperty("AdministrativeExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdministrativeExpensesAmt")]
//     public string AdministrativeExpensesAmt { get; set; }
// }
//
// public class CYMinus2YrEndwmtFundGrp
// {
//     [JsonProperty("BeginningYearBalanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BeginningYearBalanceAmt")]
//     public string BeginningYearBalanceAmt { get; set; }
//
//     [JsonProperty("InvestmentEarningsOrLossesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentEarningsOrLossesAmt")]
//     public string InvestmentEarningsOrLossesAmt { get; set; }
//
//     [JsonProperty("EndYearBalanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EndYearBalanceAmt")]
//     public string EndYearBalanceAmt { get; set; }
//
//     [JsonProperty("ContributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributionsAmt")]
//     public string ContributionsAmt { get; set; }
//
//     [JsonProperty("GrantsOrScholarshipsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsOrScholarshipsAmt")]
//     public string GrantsOrScholarshipsAmt { get; set; }
//
//     [JsonProperty("OtherExpendituresAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherExpendituresAmt")]
//     public string OtherExpendituresAmt { get; set; }
//
//     [JsonProperty("AdministrativeExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdministrativeExpensesAmt")]
//     public string AdministrativeExpensesAmt { get; set; }
// }
//
// public class CYMinus3YrEndwmtFundGrp
// {
//     [JsonProperty("BeginningYearBalanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BeginningYearBalanceAmt")]
//     public string BeginningYearBalanceAmt { get; set; }
//
//     [JsonProperty("InvestmentEarningsOrLossesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentEarningsOrLossesAmt")]
//     public string InvestmentEarningsOrLossesAmt { get; set; }
//
//     [JsonProperty("EndYearBalanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EndYearBalanceAmt")]
//     public string EndYearBalanceAmt { get; set; }
// }
//
// public class CYMinus4YrEndwmtFundGrp
// {
//     [JsonProperty("BeginningYearBalanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BeginningYearBalanceAmt")]
//     public string BeginningYearBalanceAmt { get; set; }
//
//     [JsonProperty("EndYearBalanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EndYearBalanceAmt")]
//     public string EndYearBalanceAmt { get; set; }
// }
//
// public class CYNonconventionalFuelCreditGrp
// {
//     [JsonProperty("CurrentYearNnconvFuelCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearNnconvFuelCrAmt")]
//     public string CurrentYearNnconvFuelCrAmt { get; set; }
// }
//
// public class CYRenewableElectricityCrGrp
// {
//     [JsonProperty("CurrentYearRenewableElecCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearRenewableElecCrAmt")]
//     public string CurrentYearRenewableElecCrAmt { get; set; }
// }
//
// public class CYSmallEmployerPensionPlanGrp
// {
//     [JsonProperty("CurrentYrSmllEmplrPnsnPlanAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYrSmllEmplrPnsnPlanAmt")]
//     public string CurrentYrSmllEmplrPnsnPlanAmt { get; set; }
// }
//
// public class DeferredRevenueGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class DeprecAndDpltnRevAndExpnssAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class DepreciationDepletionGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
//
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class DepreciationPropertyGrp
// {
//     [JsonProperty("PropertyDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PropertyDesc")]
//     public string PropertyDesc { get; set; }
//
//     [JsonProperty("AcquiredDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AcquiredDt")]
//     public string AcquiredDt { get; set; }
//
//     [JsonProperty("CostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CostOrOtherBasisAmt")]
//     public string CostOrOtherBasisAmt { get; set; }
//
//     [JsonProperty("PriorYearDepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearDepreciationAmt")]
//     public string PriorYearDepreciationAmt { get; set; }
//
//     [JsonProperty("ComputationMethodTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ComputationMethodTxt")]
//     public string ComputationMethodTxt { get; set; }
//
//     [JsonProperty("LifeRt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LifeRt")]
//     public string LifeRt { get; set; }
//
//     [JsonProperty("CurrentYearExpenseAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearExpenseAmt")]
//     public string CurrentYearExpenseAmt { get; set; }
//
//     [JsonProperty("AdjustedNetIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedNetIncomeAmt")]
//     public string AdjustedNetIncomeAmt { get; set; }
// }
//
// public class DepreciationSchedule
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("DepreciationPropertyGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationPropertyGrp")]
//     public DepreciationPropertyGrp DepreciationPropertyGrp { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class DifferentialWagePaymentsCrGrp
// {
//     [JsonProperty("DifferentialWagePaymentsCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DifferentialWagePaymentsCrAmt")]
//     public string DifferentialWagePaymentsCrAmt { get; set; }
// }
//
// public class DirectControllingEntityName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
// }
//
// public class DiscountedCareOthPercentageGrp
// {
//     [JsonProperty("OtherInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherInd")]
//     public string OtherInd { get; set; }
//
//     [JsonProperty("DiscountedCareOtherPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DiscountedCareOtherPct")]
//     public string DiscountedCareOtherPct { get; set; }
// }
//
// public class DispositionOfAssetsDetail
// {
//     [JsonProperty("AssetsDistriOrExpnssPaidDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AssetsDistriOrExpnssPaidDesc")]
//     public string AssetsDistriOrExpnssPaidDesc { get; set; }
//
//     [JsonProperty("DistributionDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributionDt")]
//     public string DistributionDt { get; set; }
//
//     [JsonProperty("FairMarketValueOfAssetAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FairMarketValueOfAssetAmt")]
//     public string FairMarketValueOfAssetAmt { get; set; }
//
//     [JsonProperty("MethodOfFMVDeterminationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfFMVDeterminationTxt")]
//     public string MethodOfFMVDeterminationTxt { get; set; }
//
//     [JsonProperty("PersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonNm")]
//     public string PersonNm { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("IRCSectionTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRCSectionTxt")]
//     public string IRCSectionTxt { get; set; }
//
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
// }
//
// public class DisqualifiedPersonExBnftTrGrp
// {
//     [JsonProperty("TransactionCorrectedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransactionCorrectedInd")]
//     public string TransactionCorrectedInd { get; set; }
//
//     [JsonProperty("PersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonNm")]
//     public string PersonNm { get; set; }
//
//     [JsonProperty("TransactionDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransactionDesc")]
//     public string TransactionDesc { get; set; }
// }
//
// public class DisregardedEntityName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
// }
//
// public class DissolutionInformationGrp
// {
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("ShortExplanationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ShortExplanationTxt")]
//     public string ShortExplanationTxt { get; set; }
//
//     [JsonProperty("DissolutionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DissolutionAmt")]
//     public string DissolutionAmt { get; set; }
// }
//
// public class DissolutionStmt
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("DissolutionInformationGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DissolutionInformationGrp")]
//     public DissolutionInformationGrp DissolutionInformationGrp { get; set; }
// }
//
// public class DistilledSpiritsCreditGrp
// {
//     [JsonProperty("DistilledSpiritsCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistilledSpiritsCreditAmt")]
//     public string DistilledSpiritsCreditAmt { get; set; }
// }
//
// public class DistributableAmountGrp
// {
//     [JsonProperty("CYAdjNetIncomeDistributableAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYAdjNetIncomeDistributableAmt")]
//     public string CYAdjNetIncomeDistributableAmt { get; set; }
//
//     [JsonProperty("CYPct85AdjustedNetIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYPct85AdjustedNetIncomeAmt")]
//     public string CYPct85AdjustedNetIncomeAmt { get; set; }
//
//     [JsonProperty("CYTotalMinAstDistributableAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYTotalMinAstDistributableAmt")]
//     public string CYTotalMinAstDistributableAmt { get; set; }
//
//     [JsonProperty("CYGreaterAdjustedMinimumAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYGreaterAdjustedMinimumAmt")]
//     public string CYGreaterAdjustedMinimumAmt { get; set; }
//
//     [JsonProperty("CYIncomeTaxImposedPYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYIncomeTaxImposedPYAmt")]
//     public string CYIncomeTaxImposedPYAmt { get; set; }
//
//     [JsonProperty("CYDistributableAsAdjustedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYDistributableAsAdjustedAmt")]
//     public string CYDistributableAsAdjustedAmt { get; set; }
//
//     [JsonProperty("FirstYearType3NonFuncInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FirstYearType3NonFuncInd")]
//     public string FirstYearType3NonFuncInd { get; set; }
//
//     [JsonProperty("Sect4942j3j5FndtnAndFrgnOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Sect4942j3j5FndtnAndFrgnOrgInd")]
//     public string Sect4942j3j5FndtnAndFrgnOrgInd { get; set; }
//
//     [JsonProperty("MinimumInvestmentReturnAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MinimumInvestmentReturnAmt")]
//     public string MinimumInvestmentReturnAmt { get; set; }
//
//     [JsonProperty("TaxBasedOnInvestmentIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxBasedOnInvestmentIncomeAmt")]
//     public string TaxBasedOnInvestmentIncomeAmt { get; set; }
//
//     [JsonProperty("TotalTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalTaxAmt")]
//     public string TotalTaxAmt { get; set; }
//
//     [JsonProperty("DistributableBeforeAdjAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributableBeforeAdjAmt")]
//     public string DistributableBeforeAdjAmt { get; set; }
//
//     [JsonProperty("DistributableBeforeDedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributableBeforeDedAmt")]
//     public string DistributableBeforeDedAmt { get; set; }
//
//     [JsonProperty("DistributableAsAdjustedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributableAsAdjustedAmt")]
//     public string DistributableAsAdjustedAmt { get; set; }
//
//     [JsonProperty("RecoveriesQualfiedDistriAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecoveriesQualfiedDistriAmt")]
//     public string RecoveriesQualfiedDistriAmt { get; set; }
//
//     [JsonProperty("DeductionFromDistributableAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DeductionFromDistributableAmt")]
//     public string DeductionFromDistributableAmt { get; set; }
//
//     [JsonProperty("IncomeTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IncomeTaxAmt")]
//     public string IncomeTaxAmt { get; set; }
// }
//
// public class DistributionAllocationsGrp
// {
//     [JsonProperty("CYDistributableAsAdjustedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYDistributableAsAdjustedAmt")]
//     public string CYDistributableAsAdjustedAmt { get; set; }
//
//     [JsonProperty("UnderdistributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnderdistributionsAmt")]
//     public string UnderdistributionsAmt { get; set; }
//
//     [JsonProperty("ExcessDistributionCyovYr5Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessDistributionCyovYr5Amt")]
//     public string ExcessDistributionCyovYr5Amt { get; set; }
//
//     [JsonProperty("ExcessDistributionCyovYr4Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessDistributionCyovYr4Amt")]
//     public string ExcessDistributionCyovYr4Amt { get; set; }
//
//     [JsonProperty("ExcessDistributionCyovYr3Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessDistributionCyovYr3Amt")]
//     public string ExcessDistributionCyovYr3Amt { get; set; }
//
//     [JsonProperty("ExcessDistributionCyovYr2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessDistributionCyovYr2Amt")]
//     public string ExcessDistributionCyovYr2Amt { get; set; }
//
//     [JsonProperty("ExcessDistributionCyovYr1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessDistributionCyovYr1Amt")]
//     public string ExcessDistributionCyovYr1Amt { get; set; }
//
//     [JsonProperty("TotalExcessDistributionCyovAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExcessDistributionCyovAmt")]
//     public string TotalExcessDistributionCyovAmt { get; set; }
//
//     [JsonProperty("CyovAppliedUnderdistriPYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CyovAppliedUnderdistriPYAmt")]
//     public string CyovAppliedUnderdistriPYAmt { get; set; }
//
//     [JsonProperty("CyovAppliedUnderdistrCPYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CyovAppliedUnderdistrCPYAmt")]
//     public string CyovAppliedUnderdistrCPYAmt { get; set; }
//
//     [JsonProperty("CarryoverPYNotAppliedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CarryoverPYNotAppliedAmt")]
//     public string CarryoverPYNotAppliedAmt { get; set; }
//
//     [JsonProperty("ExcessDistributionCyovAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessDistributionCyovAmt")]
//     public string ExcessDistributionCyovAmt { get; set; }
//
//     [JsonProperty("CYTotalAnnualDistributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYTotalAnnualDistributionsAmt")]
//     public string CYTotalAnnualDistributionsAmt { get; set; }
//
//     [JsonProperty("CYDistribAppUnderdistriPYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYDistribAppUnderdistriPYAmt")]
//     public string CYDistribAppUnderdistriPYAmt { get; set; }
//
//     [JsonProperty("ExcessDistributionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessDistributionAmt")]
//     public string ExcessDistributionAmt { get; set; }
//
//     [JsonProperty("RemainingUnderdistriPYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RemainingUnderdistriPYAmt")]
//     public string RemainingUnderdistriPYAmt { get; set; }
//
//     [JsonProperty("RemainingUnderdistriCYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RemainingUnderdistriCYAmt")]
//     public string RemainingUnderdistriCYAmt { get; set; }
//
//     [JsonProperty("ExcessDistriCyovToNextYrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessDistriCyovToNextYrAmt")]
//     public string ExcessDistriCyovToNextYrAmt { get; set; }
//
//     [JsonProperty("ExcessFromYear5Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessFromYear5Amt")]
//     public string ExcessFromYear5Amt { get; set; }
//
//     [JsonProperty("ExcessFromYear4Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessFromYear4Amt")]
//     public string ExcessFromYear4Amt { get; set; }
//
//     [JsonProperty("ExcessFromYear3Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessFromYear3Amt")]
//     public string ExcessFromYear3Amt { get; set; }
//
//     [JsonProperty("ExcessFromYear2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessFromYear2Amt")]
//     public string ExcessFromYear2Amt { get; set; }
//
//     [JsonProperty("ExcessFromYear1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessFromYear1Amt")]
//     public string ExcessFromYear1Amt { get; set; }
//
//     [JsonProperty("CYDistriAppDistributableAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYDistriAppDistributableAmt")]
//     public string CYDistriAppDistributableAmt { get; set; }
// }
//
// public class DistributionFromCorpusElection
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("ElectionDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ElectionDesc")]
//     public string ElectionDesc { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class DistributionsGrp
// {
//     [JsonProperty("CYPaidAccomplishExemptPrpsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYPaidAccomplishExemptPrpsAmt")]
//     public string CYPaidAccomplishExemptPrpsAmt { get; set; }
//
//     [JsonProperty("CYPdInExcessIncomeActivityAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYPdInExcessIncomeActivityAmt")]
//     public string CYPdInExcessIncomeActivityAmt { get; set; }
//
//     [JsonProperty("CYAdministrativeExpensePaidAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYAdministrativeExpensePaidAmt")]
//     public string CYAdministrativeExpensePaidAmt { get; set; }
//
//     [JsonProperty("ExemptUseAssetsAcquisPaidAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExemptUseAssetsAcquisPaidAmt")]
//     public string ExemptUseAssetsAcquisPaidAmt { get; set; }
//
//     [JsonProperty("QualifiedSetAsideAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("QualifiedSetAsideAmt")]
//     public string QualifiedSetAsideAmt { get; set; }
//
//     [JsonProperty("CYOtherDistributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYOtherDistributionsAmt")]
//     public string CYOtherDistributionsAmt { get; set; }
//
//     [JsonProperty("CYTotalAnnualDistributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYTotalAnnualDistributionsAmt")]
//     public string CYTotalAnnualDistributionsAmt { get; set; }
//
//     [JsonProperty("CYDistriAttentiveSuprtOrgAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYDistriAttentiveSuprtOrgAmt")]
//     public string CYDistriAttentiveSuprtOrgAmt { get; set; }
//
//     [JsonProperty("CYDistributableAsAdjustedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYDistributableAsAdjustedAmt")]
//     public string CYDistributableAsAdjustedAmt { get; set; }
//
//     [JsonProperty("CYDistributionYrRt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYDistributionYrRt")]
//     public string CYDistributionYrRt { get; set; }
// }
//
// public class DivAndIntFromSecPartVIIGrp
// {
//     [JsonProperty("ExclusionCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionCd")]
//     public string ExclusionCd { get; set; }
//
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
//
//     [JsonProperty("UnrelatedBusinessTaxblIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessTaxblIncmAmt")]
//     public string UnrelatedBusinessTaxblIncmAmt { get; set; }
//
//     [JsonProperty("RelatedOrExemptFunctionIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFunctionIncmAmt")]
//     public string RelatedOrExemptFunctionIncmAmt { get; set; }
//
//     [JsonProperty("BusinessCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessCd")]
//     public string BusinessCd { get; set; }
// }
//
// public class DividendsAndInterestFromSecDtl
// {
//     [JsonProperty("ExclusionCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionCd")]
//     public string ExclusionCd { get; set; }
//
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
//
//     [JsonProperty("RelatedOrExemptFunctionIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFunctionIncmAmt")]
//     public string RelatedOrExemptFunctionIncmAmt { get; set; }
//
//     [JsonProperty("UnrelatedBusinessTaxblIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessTaxblIncmAmt")]
//     public string UnrelatedBusinessTaxblIncmAmt { get; set; }
//
//     [JsonProperty("BusinessCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessCd")]
//     public string BusinessCd { get; set; }
// }
//
// public class DoingBusinessAsName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
//
//     [JsonProperty("BusinessNameLine2Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine2Txt")]
//     public string BusinessNameLine2Txt { get; set; }
// }
//
// public class DonorAdvisedFundInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class DonorRestrictionNetAssetsGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class DonorRstrOrQuasiEndowmentsInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class DslFuelSoldStLocalGovtCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class EconomicDevelopmentGrp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
// }
//
// public class EmployeeRetentionCreditGrp
// {
//     [JsonProperty("EmployeeRetentionCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EmployeeRetentionCreditAmt")]
//     public string EmployeeRetentionCreditAmt { get; set; }
// }
//
// public class EmplrCrPdFamilyMedLeaveGrp
// {
//     [JsonProperty("EmplrCrPdFamilyMedLeaveAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EmplrCrPdFamilyMedLeaveAmt")]
//     public string EmplrCrPdFamilyMedLeaveAmt { get; set; }
// }
//
// public class EngagedInExcessBenefitTransInd
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class EnterAmountFromF8844Grp
// {
//     [JsonProperty("EnterAmountFromF8844Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EnterAmountFromF8844Amt")]
//     public string EnterAmountFromF8844Amt { get; set; }
// }
//
// public class EntityName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
// }
//
// public class EnvironmentalImprovementsGrp
// {
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
//
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
// }
//
// public class EquipmentGrp
// {
//     [JsonProperty("OtherCostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherCostOrOtherBasisAmt")]
//     public string OtherCostOrOtherBasisAmt { get; set; }
//
//     [JsonProperty("DepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationAmt")]
//     public string DepreciationAmt { get; set; }
//
//     [JsonProperty("BookValueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BookValueAmt")]
//     public string BookValueAmt { get; set; }
//
//     [JsonProperty("InvestmentCostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentCostOrOtherBasisAmt")]
//     public string InvestmentCostOrOtherBasisAmt { get; set; }
// }
//
// public class EscrowAccountLiabilityGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class EstateOrTrustCapGainOrLossGrp
// {
//     [JsonProperty("NetSTCapitalGainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetSTCapitalGainOrLossAmt")]
//     public string NetSTCapitalGainOrLossAmt { get; set; }
//
//     [JsonProperty("NetLongTermGainOrLossGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetLongTermGainOrLossGrp")]
//     public NetLongTermGainOrLossGrp NetLongTermGainOrLossGrp { get; set; }
//
//     [JsonProperty("TotalNetGainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalNetGainOrLossAmt")]
//     public string TotalNetGainOrLossAmt { get; set; }
// }
//
// public class ExciseTaxBasedOnInvstIncmGrp
// {
//     [JsonProperty("InvestmentIncomeExciseTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentIncomeExciseTaxAmt")]
//     public string InvestmentIncomeExciseTaxAmt { get; set; }
//
//     [JsonProperty("TaxUnderSection511Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxUnderSection511Amt")]
//     public string TaxUnderSection511Amt { get; set; }
//
//     [JsonProperty("SubtotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubtotalAmt")]
//     public string SubtotalAmt { get; set; }
//
//     [JsonProperty("SubtitleATaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubtitleATaxAmt")]
//     public string SubtitleATaxAmt { get; set; }
//
//     [JsonProperty("TaxBasedOnInvestmentIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxBasedOnInvestmentIncomeAmt")]
//     public string TaxBasedOnInvestmentIncomeAmt { get; set; }
//
//     [JsonProperty("EstimatedPlusOvpmtIncmTxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EstimatedPlusOvpmtIncmTxAmt")]
//     public string EstimatedPlusOvpmtIncmTxAmt { get; set; }
//
//     [JsonProperty("ExtsnRequestIncomeTaxPaidAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExtsnRequestIncomeTaxPaidAmt")]
//     public string ExtsnRequestIncomeTaxPaidAmt { get; set; }
//
//     [JsonProperty("BackupWithholdingWithheldAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BackupWithholdingWithheldAmt")]
//     public string BackupWithholdingWithheldAmt { get; set; }
//
//     [JsonProperty("TotalPaymentsAndCreditsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalPaymentsAndCreditsAmt")]
//     public string TotalPaymentsAndCreditsAmt { get; set; }
//
//     [JsonProperty("OriginalReturnTaxPaidAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OriginalReturnTaxPaidAmt")]
//     public string OriginalReturnTaxPaidAmt { get; set; }
//
//     [JsonProperty("EsPenaltyAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EsPenaltyAmt")]
//     public string EsPenaltyAmt { get; set; }
//
//     [JsonProperty("TaxDueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxDueAmt")]
//     public string TaxDueAmt { get; set; }
//
//     [JsonProperty("AppliedToESTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AppliedToESTaxAmt")]
//     public string AppliedToESTaxAmt { get; set; }
//
//     [JsonProperty("RefundAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RefundAmt")]
//     public string RefundAmt { get; set; }
//
//     [JsonProperty("DomesticOrgMeetingSect4940eInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DomesticOrgMeetingSect4940eInd")]
//     public string DomesticOrgMeetingSect4940eInd { get; set; }
//
//     [JsonProperty("Form2220AttachedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form2220AttachedInd")]
//     public Form2220AttachedInd Form2220AttachedInd { get; set; }
//
//     [JsonProperty("OverpaymentAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OverpaymentAmt")]
//     public string OverpaymentAmt { get; set; }
//
//     [JsonProperty("ExemptFrgnOrgTaxWthldAtSrceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExemptFrgnOrgTaxWthldAtSrceAmt")]
//     public string ExemptFrgnOrgTaxWthldAtSrceAmt { get; set; }
//
//     [JsonProperty("OriginalReturnOverpaymentAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OriginalReturnOverpaymentAmt")]
//     public string OriginalReturnOverpaymentAmt { get; set; }
//
//     [JsonProperty("RulingLetterDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RulingLetterDt")]
//     public string RulingLetterDt { get; set; }
//
//     [JsonProperty("NotApplicableCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NotApplicableCd")]
//     public string NotApplicableCd { get; set; }
//
//     [JsonProperty("ExemptOperatingFoundationsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExemptOperatingFoundationsInd")]
//     public string ExemptOperatingFoundationsInd { get; set; }
// }
//
// public class ExpenditureResponsibilityGrp
// {
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
//
//     [JsonProperty("ForeignAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignAddress")]
//     public ForeignAddress ForeignAddress { get; set; }
//
//     [JsonProperty("GrantDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantDt")]
//     public string GrantDt { get; set; }
//
//     [JsonProperty("GrantAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantAmt")]
//     public string GrantAmt { get; set; }
//
//     [JsonProperty("PurposeOfGrantTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PurposeOfGrantTxt")]
//     public string PurposeOfGrantTxt { get; set; }
//
//     [JsonProperty("ExpendedByGranteeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpendedByGranteeAmt")]
//     public string ExpendedByGranteeAmt { get; set; }
//
//     [JsonProperty("AnyDiversionByGranteeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AnyDiversionByGranteeTxt")]
//     public string AnyDiversionByGranteeTxt { get; set; }
//
//     [JsonProperty("DatesOfReportsByGranteeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DatesOfReportsByGranteeTxt")]
//     public string DatesOfReportsByGranteeTxt { get; set; }
//
//     [JsonProperty("VerificationDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("VerificationDt")]
//     public string VerificationDt { get; set; }
//
//     [JsonProperty("ResultsOfVerificationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ResultsOfVerificationTxt")]
//     public string ResultsOfVerificationTxt { get; set; }
// }
//
// public class ExpenditureResponsibilityStmt
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("ExpenditureResponsibilityGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpenditureResponsibilityGrp")]
//     public ExpenditureResponsibilityGrp ExpenditureResponsibilityGrp { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
// }
//
// public class ExpensesAndContributionsAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ExplanOfLegisPoliticalActvts
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("MediumExplanationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MediumExplanationTxt")]
//     public string MediumExplanationTxt { get; set; }
// }
//
// public class ExplnOfNonFilingWithAGStmt
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("ExplanationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExplanationTxt")]
//     public string ExplanationTxt { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class ExpNontxAviationGasCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ExpNontxUseDslWtrEmulsionCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ExportedDyedDieselFuelCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ExportedDyedKeroseneCreditAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ExportedNontxUseOfGasCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ExportedUndyedKeroseneCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ExpUndyedDieselFuelCreditAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class FarmPrpsUndyedDslFuelCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class FarmPrpsUndyedKeroseneCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class FeesForServicesAccountingGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class FeesForServicesLegalGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
// }
//
// public class FeesForServicesLobbyingGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class FeesForServicesManagementGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class FeesForServicesOtherGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class FeesForSrvcInvstMgmntFeesGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class Filer
// {
//     [JsonProperty("EIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EIN")]
//     public string EIN { get; set; }
//
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
//
//     [JsonProperty("BusinessNameControlTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameControlTxt")]
//     public string BusinessNameControlTxt { get; set; }
//
//     [JsonProperty("PhoneNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PhoneNum")]
//     public string PhoneNum { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("InCareOfNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InCareOfNm")]
//     public string InCareOfNm { get; set; }
//
//     [JsonProperty("ForeignPhoneNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignPhoneNum")]
//     public string ForeignPhoneNum { get; set; }
//
//     [JsonProperty("ForeignAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignAddress")]
//     public ForeignAddress ForeignAddress { get; set; }
// }
//
// public class FinancialAssistanceAtCostTyp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
// }
//
// public class FMVOtherNonExemptUseAssetGrp
// {
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class FoodInventoryGrp
// {
//     [JsonProperty("NonCashCheckboxInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashCheckboxInd")]
//     public string NonCashCheckboxInd { get; set; }
//
//     [JsonProperty("NoncashContributionsRptF990Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NoncashContributionsRptF990Amt")]
//     public string NoncashContributionsRptF990Amt { get; set; }
//
//     [JsonProperty("MethodOfDeterminingRevenuesTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfDeterminingRevenuesTxt")]
//     public string MethodOfDeterminingRevenuesTxt { get; set; }
//
//     [JsonProperty("ContributionCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributionCnt")]
//     public string ContributionCnt { get; set; }
// }
//
// public class ForeignAddress
// {
//     [JsonProperty("AddressLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine1Txt")]
//     public string AddressLine1Txt { get; set; }
//
//     [JsonProperty("CityNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CityNm")]
//     public string CityNm { get; set; }
//
//     [JsonProperty("ProvinceOrStateNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProvinceOrStateNm")]
//     public string ProvinceOrStateNm { get; set; }
//
//     [JsonProperty("CountryCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CountryCd")]
//     public string CountryCd { get; set; }
//
//     [JsonProperty("ForeignPostalCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignPostalCd")]
//     public string ForeignPostalCd { get; set; }
//
//     [JsonProperty("AddressLine2Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine2Txt")]
//     public string AddressLine2Txt { get; set; }
// }
//
// public class ForeignGrantsGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
// }
//
// public class ForeignIndividualsGrantsGrp
// {
//     [JsonProperty("TypeOfAssistanceTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TypeOfAssistanceTxt")]
//     public string TypeOfAssistanceTxt { get; set; }
//
//     [JsonProperty("RegionTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RegionTxt")]
//     public string RegionTxt { get; set; }
//
//     [JsonProperty("RecipientCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecipientCnt")]
//     public string RecipientCnt { get; set; }
//
//     [JsonProperty("NonCashAssistanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashAssistanceAmt")]
//     public string NonCashAssistanceAmt { get; set; }
//
//     [JsonProperty("DescriptionOfNonCashAsstTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DescriptionOfNonCashAsstTxt")]
//     public string DescriptionOfNonCashAsstTxt { get; set; }
//
//     [JsonProperty("ValuationMethodUsedDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ValuationMethodUsedDesc")]
//     public string ValuationMethodUsedDesc { get; set; }
//
//     [JsonProperty("CashGrantAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashGrantAmt")]
//     public string CashGrantAmt { get; set; }
//
//     [JsonProperty("MannerOfCashDisbursementTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MannerOfCashDisbursementTxt")]
//     public string MannerOfCashDisbursementTxt { get; set; }
// }
//
// public class ForeignTaxPdWithheldAtSrceAmt
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class Form1041ScheduleDInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class Form2220AttachedInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
// }
//
// public class Form4136Ind
// {
//     [JsonProperty("@totalFuelTaxCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@totalFuelTaxCreditAmt")]
//     public string TotalFuelTaxCreditAmt { get; set; }
//
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class Form990PartVIISectionAGrp
// {
//     [JsonProperty("PersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonNm")]
//     public string PersonNm { get; set; }
//
//     [JsonProperty("TitleTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TitleTxt")]
//     public string TitleTxt { get; set; }
//
//     [JsonProperty("AverageHoursPerWeekRt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AverageHoursPerWeekRt")]
//     public string AverageHoursPerWeekRt { get; set; }
//
//     [JsonProperty("IndividualTrusteeOrDirectorInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IndividualTrusteeOrDirectorInd")]
//     public string IndividualTrusteeOrDirectorInd { get; set; }
//
//     [JsonProperty("ReportableCompFromOrgAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReportableCompFromOrgAmt")]
//     public string ReportableCompFromOrgAmt { get; set; }
//
//     [JsonProperty("ReportableCompFromRltdOrgAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReportableCompFromRltdOrgAmt")]
//     public string ReportableCompFromRltdOrgAmt { get; set; }
//
//     [JsonProperty("OtherCompensationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherCompensationAmt")]
//     public string OtherCompensationAmt { get; set; }
//
//     [JsonProperty("OfficerInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OfficerInd")]
//     public string OfficerInd { get; set; }
//
//     [JsonProperty("AverageHoursPerWeekRltdOrgRt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AverageHoursPerWeekRltdOrgRt")]
//     public string AverageHoursPerWeekRltdOrgRt { get; set; }
// }
//
// public class Form990PFBalanceSheetsGrp
// {
//     [JsonProperty("CashBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashBOYAmt")]
//     public string CashBOYAmt { get; set; }
//
//     [JsonProperty("CashEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashEOYAmt")]
//     public string CashEOYAmt { get; set; }
//
//     [JsonProperty("SavAndTempCashInvstBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SavAndTempCashInvstBOYAmt")]
//     public string SavAndTempCashInvstBOYAmt { get; set; }
//
//     [JsonProperty("SavAndTempCashInvstEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SavAndTempCashInvstEOYAmt")]
//     public string SavAndTempCashInvstEOYAmt { get; set; }
//
//     [JsonProperty("AcctRcvblAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AcctRcvblAmt")]
//     public string AcctRcvblAmt { get; set; }
//
//     [JsonProperty("AcctRcvblAllwncDbtflAcctAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AcctRcvblAllwncDbtflAcctAmt")]
//     public string AcctRcvblAllwncDbtflAcctAmt { get; set; }
//
//     [JsonProperty("AcctRcvblBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AcctRcvblBOYAmt")]
//     public string AcctRcvblBOYAmt { get; set; }
//
//     [JsonProperty("AcctRcvblEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AcctRcvblEOYAmt")]
//     public string AcctRcvblEOYAmt { get; set; }
//
//     [JsonProperty("PledgesRcvblAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PledgesRcvblAmt")]
//     public string PledgesRcvblAmt { get; set; }
//
//     [JsonProperty("PledgesRcvblAllwncDbtflAcctAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PledgesRcvblAllwncDbtflAcctAmt")]
//     public string PledgesRcvblAllwncDbtflAcctAmt { get; set; }
//
//     [JsonProperty("PledgesRcvblBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PledgesRcvblBOYAmt")]
//     public string PledgesRcvblBOYAmt { get; set; }
//
//     [JsonProperty("PledgesRcvblEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PledgesRcvblEOYAmt")]
//     public string PledgesRcvblEOYAmt { get; set; }
//
//     [JsonProperty("GrantsReceivableBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsReceivableBOYAmt")]
//     public string GrantsReceivableBOYAmt { get; set; }
//
//     [JsonProperty("GrantsReceivableEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsReceivableEOYAmt")]
//     public string GrantsReceivableEOYAmt { get; set; }
//
//     [JsonProperty("RcvblFromOfficersBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RcvblFromOfficersBOYAmt")]
//     public string RcvblFromOfficersBOYAmt { get; set; }
//
//     [JsonProperty("RcvblFromOfficersEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RcvblFromOfficersEOYAmt")]
//     public RcvblFromOfficersEOYAmt RcvblFromOfficersEOYAmt { get; set; }
//
//     [JsonProperty("OtherRcvblAllwncDbtflAcctAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherRcvblAllwncDbtflAcctAmt")]
//     public string OtherRcvblAllwncDbtflAcctAmt { get; set; }
//
//     [JsonProperty("OtherNtsAndLoansRcvblBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherNtsAndLoansRcvblBOYAmt")]
//     public string OtherNtsAndLoansRcvblBOYAmt { get; set; }
//
//     [JsonProperty("OtherNtsAndLoansRcvblEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherNtsAndLoansRcvblEOYAmt")]
//     public OtherNtsAndLoansRcvblEOYAmt OtherNtsAndLoansRcvblEOYAmt { get; set; }
//
//     [JsonProperty("InventoriesBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InventoriesBOYAmt")]
//     public string InventoriesBOYAmt { get; set; }
//
//     [JsonProperty("InventoriesEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InventoriesEOYAmt")]
//     public string InventoriesEOYAmt { get; set; }
//
//     [JsonProperty("PrepaidExpensesBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrepaidExpensesBOYAmt")]
//     public string PrepaidExpensesBOYAmt { get; set; }
//
//     [JsonProperty("PrepaidExpensesEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrepaidExpensesEOYAmt")]
//     public string PrepaidExpensesEOYAmt { get; set; }
//
//     [JsonProperty("MortgageLoansBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MortgageLoansBOYAmt")]
//     public string MortgageLoansBOYAmt { get; set; }
//
//     [JsonProperty("MortgageLoansEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MortgageLoansEOYAmt")]
//     public string MortgageLoansEOYAmt { get; set; }
//
//     [JsonProperty("OtherAssetsBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherAssetsBOYAmt")]
//     public OtherAssetsBOYAmt OtherAssetsBOYAmt { get; set; }
//
//     [JsonProperty("OtherAssetsEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherAssetsEOYAmt")]
//     public OtherAssetsEOYAmt OtherAssetsEOYAmt { get; set; }
//
//     [JsonProperty("TotalAssetsBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAssetsBOYAmt")]
//     public string TotalAssetsBOYAmt { get; set; }
//
//     [JsonProperty("TotalAssetsEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAssetsEOYAmt")]
//     public string TotalAssetsEOYAmt { get; set; }
//
//     [JsonProperty("TotalAssetsEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAssetsEOYFMVAmt")]
//     public string TotalAssetsEOYFMVAmt { get; set; }
//
//     [JsonProperty("AccountsPayableBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AccountsPayableBOYAmt")]
//     public string AccountsPayableBOYAmt { get; set; }
//
//     [JsonProperty("AccountsPayableEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AccountsPayableEOYAmt")]
//     public string AccountsPayableEOYAmt { get; set; }
//
//     [JsonProperty("LoansFromOfficersBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoansFromOfficersBOYAmt")]
//     public string LoansFromOfficersBOYAmt { get; set; }
//
//     [JsonProperty("LoansFromOfficersEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoansFromOfficersEOYAmt")]
//     public string LoansFromOfficersEOYAmt { get; set; }
//
//     [JsonProperty("MortgagesAndNotesPayableBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MortgagesAndNotesPayableBOYAmt")]
//     public string MortgagesAndNotesPayableBOYAmt { get; set; }
//
//     [JsonProperty("MortgagesAndNotesPayableEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MortgagesAndNotesPayableEOYAmt")]
//     public MortgagesAndNotesPayableEOYAmt MortgagesAndNotesPayableEOYAmt { get; set; }
//
//     [JsonProperty("OtherLiabilitiesBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherLiabilitiesBOYAmt")]
//     public OtherLiabilitiesBOYAmt OtherLiabilitiesBOYAmt { get; set; }
//
//     [JsonProperty("OtherLiabilitiesEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherLiabilitiesEOYAmt")]
//     public OtherLiabilitiesEOYAmt OtherLiabilitiesEOYAmt { get; set; }
//
//     [JsonProperty("TotalLiabilitiesBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalLiabilitiesBOYAmt")]
//     public string TotalLiabilitiesBOYAmt { get; set; }
//
//     [JsonProperty("TotalLiabilitiesEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalLiabilitiesEOYAmt")]
//     public string TotalLiabilitiesEOYAmt { get; set; }
//
//     [JsonProperty("OrganizationFollowsFASB117Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrganizationFollowsFASB117Ind")]
//     public string OrganizationFollowsFASB117Ind { get; set; }
//
//     [JsonProperty("NoDonorRstrNetAssestsBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NoDonorRstrNetAssestsBOYAmt")]
//     public string NoDonorRstrNetAssestsBOYAmt { get; set; }
//
//     [JsonProperty("NoDonorRstrNetAssestsEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NoDonorRstrNetAssestsEOYAmt")]
//     public string NoDonorRstrNetAssestsEOYAmt { get; set; }
//
//     [JsonProperty("DonorRstrNetAssetsBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DonorRstrNetAssetsBOYAmt")]
//     public string DonorRstrNetAssetsBOYAmt { get; set; }
//
//     [JsonProperty("DonorRstrNetAssetsEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DonorRstrNetAssetsEOYAmt")]
//     public string DonorRstrNetAssetsEOYAmt { get; set; }
//
//     [JsonProperty("TotNetAstOrFundBalancesBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotNetAstOrFundBalancesBOYAmt")]
//     public string TotNetAstOrFundBalancesBOYAmt { get; set; }
//
//     [JsonProperty("TotNetAstOrFundBalancesEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotNetAstOrFundBalancesEOYAmt")]
//     public string TotNetAstOrFundBalancesEOYAmt { get; set; }
//
//     [JsonProperty("TotalLiabilitiesNetAstBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalLiabilitiesNetAstBOYAmt")]
//     public string TotalLiabilitiesNetAstBOYAmt { get; set; }
//
//     [JsonProperty("TotalLiabilitiesNetAstEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalLiabilitiesNetAstEOYAmt")]
//     public string TotalLiabilitiesNetAstEOYAmt { get; set; }
//
//     [JsonProperty("CashEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashEOYFMVAmt")]
//     public string CashEOYFMVAmt { get; set; }
//
//     [JsonProperty("SavAndTempCashInvstEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SavAndTempCashInvstEOYFMVAmt")]
//     public string SavAndTempCashInvstEOYFMVAmt { get; set; }
//
//     [JsonProperty("LandBldgInvestmentsEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LandBldgInvestmentsEOYAmt")]
//     public LandBldgInvestmentsEOYAmt LandBldgInvestmentsEOYAmt { get; set; }
//
//     [JsonProperty("OtherInvestmentsEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherInvestmentsEOYAmt")]
//     public OtherInvestmentsEOYAmt OtherInvestmentsEOYAmt { get; set; }
//
//     [JsonProperty("LandEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LandEOYAmt")]
//     public LandEOYAmt LandEOYAmt { get; set; }
//
//     [JsonProperty("OtherAssetsEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherAssetsEOYFMVAmt")]
//     public OtherAssetsEOYFMVAmt OtherAssetsEOYFMVAmt { get; set; }
//
//     [JsonProperty("CorporateStockEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CorporateStockEOYAmt")]
//     public CorporateStockEOYAmt CorporateStockEOYAmt { get; set; }
//
//     [JsonProperty("CorporateStockEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CorporateStockEOYFMVAmt")]
//     public string CorporateStockEOYFMVAmt { get; set; }
//
//     [JsonProperty("OrgDoesNotFollowFASB117Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrgDoesNotFollowFASB117Ind")]
//     public string OrgDoesNotFollowFASB117Ind { get; set; }
//
//     [JsonProperty("RetainedEarningEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RetainedEarningEOYAmt")]
//     public string RetainedEarningEOYAmt { get; set; }
//
//     [JsonProperty("CorporateStockBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CorporateStockBOYAmt")]
//     public string CorporateStockBOYAmt { get; set; }
//
//     [JsonProperty("AcctRcvblEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AcctRcvblEOYFMVAmt")]
//     public string AcctRcvblEOYFMVAmt { get; set; }
//
//     [JsonProperty("OtherInvestmentsBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherInvestmentsBOYAmt")]
//     public string OtherInvestmentsBOYAmt { get; set; }
//
//     [JsonProperty("OtherInvestmentsEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherInvestmentsEOYFMVAmt")]
//     public string OtherInvestmentsEOYFMVAmt { get; set; }
//
//     [JsonProperty("CapitalStockBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CapitalStockBOYAmt")]
//     public string CapitalStockBOYAmt { get; set; }
//
//     [JsonProperty("CapitalStockEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CapitalStockEOYAmt")]
//     public string CapitalStockEOYAmt { get; set; }
//
//     [JsonProperty("PrepaidExpensesEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrepaidExpensesEOYFMVAmt")]
//     public string PrepaidExpensesEOYFMVAmt { get; set; }
//
//     [JsonProperty("CorporateBondsBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CorporateBondsBOYAmt")]
//     public string CorporateBondsBOYAmt { get; set; }
//
//     [JsonProperty("CorporateBondsEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CorporateBondsEOYAmt")]
//     public CorporateBondsEOYAmt CorporateBondsEOYAmt { get; set; }
//
//     [JsonProperty("CorporateBondsEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CorporateBondsEOYFMVAmt")]
//     public string CorporateBondsEOYFMVAmt { get; set; }
//
//     [JsonProperty("AdditionalPaidInCapitalBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdditionalPaidInCapitalBOYAmt")]
//     public string AdditionalPaidInCapitalBOYAmt { get; set; }
//
//     [JsonProperty("AdditionalPaidInCapitalEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdditionalPaidInCapitalEOYAmt")]
//     public string AdditionalPaidInCapitalEOYAmt { get; set; }
//
//     [JsonProperty("RetainedEarningBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RetainedEarningBOYAmt")]
//     public string RetainedEarningBOYAmt { get; set; }
//
//     [JsonProperty("USGovernmentObligationsEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USGovernmentObligationsEOYAmt")]
//     public USGovernmentObligationsEOYAmt USGovernmentObligationsEOYAmt { get; set; }
//
//     [JsonProperty("USGovernmentObligationsBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USGovernmentObligationsBOYAmt")]
//     public string USGovernmentObligationsBOYAmt { get; set; }
//
//     [JsonProperty("USGovtObligationsEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USGovtObligationsEOYFMVAmt")]
//     public string USGovtObligationsEOYFMVAmt { get; set; }
//
//     [JsonProperty("GrantsPayableBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsPayableBOYAmt")]
//     public string GrantsPayableBOYAmt { get; set; }
//
//     [JsonProperty("GrantsPayableEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsPayableEOYAmt")]
//     public string GrantsPayableEOYAmt { get; set; }
//
//     [JsonProperty("LandBldgEquipCostOrOtherBssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LandBldgEquipCostOrOtherBssAmt")]
//     public string LandBldgEquipCostOrOtherBssAmt { get; set; }
//
//     [JsonProperty("LandBldgEquipAccumDeprecAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LandBldgEquipAccumDeprecAmt")]
//     public string LandBldgEquipAccumDeprecAmt { get; set; }
//
//     [JsonProperty("OtherNtsAndLoansRcvblAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherNtsAndLoansRcvblAmt")]
//     public string OtherNtsAndLoansRcvblAmt { get; set; }
//
//     [JsonProperty("DeferredRevenueBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DeferredRevenueBOYAmt")]
//     public string DeferredRevenueBOYAmt { get; set; }
//
//     [JsonProperty("DeferredRevenueEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DeferredRevenueEOYAmt")]
//     public string DeferredRevenueEOYAmt { get; set; }
//
//     [JsonProperty("LandBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LandBOYAmt")]
//     public string LandBOYAmt { get; set; }
//
//     [JsonProperty("LandEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LandEOYFMVAmt")]
//     public string LandEOYFMVAmt { get; set; }
//
//     [JsonProperty("InvstLandCostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvstLandCostOrOtherBasisAmt")]
//     public string InvstLandCostOrOtherBasisAmt { get; set; }
//
//     [JsonProperty("InvstLandAccumDepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvstLandAccumDepreciationAmt")]
//     public string InvstLandAccumDepreciationAmt { get; set; }
//
//     [JsonProperty("LandBldgInvestmentsBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LandBldgInvestmentsBOYAmt")]
//     public string LandBldgInvestmentsBOYAmt { get; set; }
//
//     [JsonProperty("LandBldgInvestmentsEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LandBldgInvestmentsEOYFMVAmt")]
//     public string LandBldgInvestmentsEOYFMVAmt { get; set; }
//
//     [JsonProperty("PledgesRcvblEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PledgesRcvblEOYFMVAmt")]
//     public string PledgesRcvblEOYFMVAmt { get; set; }
//
//     [JsonProperty("GrantsReceivableEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsReceivableEOYFMVAmt")]
//     public string GrantsReceivableEOYFMVAmt { get; set; }
//
//     [JsonProperty("InventoriesEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InventoriesEOYFMVAmt")]
//     public string InventoriesEOYFMVAmt { get; set; }
//
//     [JsonProperty("MortgageLoansEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MortgageLoansEOYFMVAmt")]
//     public string MortgageLoansEOYFMVAmt { get; set; }
//
//     [JsonProperty("RcvblFromOfficersEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RcvblFromOfficersEOYFMVAmt")]
//     public string RcvblFromOfficersEOYFMVAmt { get; set; }
//
//     [JsonProperty("OtherNtsAndLoansRcvblEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherNtsAndLoansRcvblEOYFMVAmt")]
//     public string OtherNtsAndLoansRcvblEOYFMVAmt { get; set; }
//
//     [JsonProperty("OrganizationFollowsSFAS117Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrganizationFollowsSFAS117Ind")]
//     public string OrganizationFollowsSFAS117Ind { get; set; }
//
//     [JsonProperty("UnrestrictedBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrestrictedBOYAmt")]
//     public string UnrestrictedBOYAmt { get; set; }
//
//     [JsonProperty("UnrestrictedEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrestrictedEOYAmt")]
//     public string UnrestrictedEOYAmt { get; set; }
//
//     [JsonProperty("OrgDoesNotFollowSFAS117Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrgDoesNotFollowSFAS117Ind")]
//     public string OrgDoesNotFollowSFAS117Ind { get; set; }
//
//     [JsonProperty("PermanentlyRestrictedBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PermanentlyRestrictedBOYAmt")]
//     public string PermanentlyRestrictedBOYAmt { get; set; }
//
//     [JsonProperty("PermanentlyRestrictedEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PermanentlyRestrictedEOYAmt")]
//     public string PermanentlyRestrictedEOYAmt { get; set; }
// }
//
// public class Form990SchASupportingOrgGrp
// {
//     [JsonProperty("ListedByNameGoverningDocInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ListedByNameGoverningDocInd")]
//     public string ListedByNameGoverningDocInd { get; set; }
//
//     [JsonProperty("SuprtOrgNoIRSDeterminationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SuprtOrgNoIRSDeterminationInd")]
//     public string SuprtOrgNoIRSDeterminationInd { get; set; }
//
//     [JsonProperty("SupportedOrgSectionC456Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportedOrgSectionC456Ind")]
//     public string SupportedOrgSectionC456Ind { get; set; }
//
//     [JsonProperty("SupportedOrgQualifiedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportedOrgQualifiedInd")]
//     public string SupportedOrgQualifiedInd { get; set; }
//
//     [JsonProperty("SuprtExclusivelySec170c2BInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SuprtExclusivelySec170c2BInd")]
//     public string SuprtExclusivelySec170c2BInd { get; set; }
//
//     [JsonProperty("SupportedOrgNotOrganizedUSInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportedOrgNotOrganizedUSInd")]
//     public string SupportedOrgNotOrganizedUSInd { get; set; }
//
//     [JsonProperty("OrganizationChangeSuprtOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrganizationChangeSuprtOrgInd")]
//     public string OrganizationChangeSuprtOrgInd { get; set; }
//
//     [JsonProperty("SupportNonSupportedOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportNonSupportedOrgInd")]
//     public string SupportNonSupportedOrgInd { get; set; }
//
//     [JsonProperty("PaymentSubstantialContribtrInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PaymentSubstantialContribtrInd")]
//     public string PaymentSubstantialContribtrInd { get; set; }
//
//     [JsonProperty("LoanDisqualifiedPersonInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoanDisqualifiedPersonInd")]
//     public string LoanDisqualifiedPersonInd { get; set; }
//
//     [JsonProperty("ControlledDisqualifiedPrsnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ControlledDisqualifiedPrsnInd")]
//     public string ControlledDisqualifiedPrsnInd { get; set; }
//
//     [JsonProperty("DisqualifiedPrsnControllIntInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisqualifiedPrsnControllIntInd")]
//     public string DisqualifiedPrsnControllIntInd { get; set; }
//
//     [JsonProperty("DisqualifiedPrsnOwnrIntInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisqualifiedPrsnOwnrIntInd")]
//     public string DisqualifiedPrsnOwnrIntInd { get; set; }
//
//     [JsonProperty("ExcessBusinessHoldingsRulesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessBusinessHoldingsRulesInd")]
//     public string ExcessBusinessHoldingsRulesInd { get; set; }
//
//     [JsonProperty("ContributionControllerInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributionControllerInd")]
//     public string ContributionControllerInd { get; set; }
//
//     [JsonProperty("ContributionFamilyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributionFamilyInd")]
//     public string ContributionFamilyInd { get; set; }
//
//     [JsonProperty("Contribution35ControlledInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Contribution35ControlledInd")]
//     public string Contribution35ControlledInd { get; set; }
//
//     [JsonProperty("ControlDecidingGrntFrgnOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ControlDecidingGrntFrgnOrgInd")]
//     public string ControlDecidingGrntFrgnOrgInd { get; set; }
//
//     [JsonProperty("SupportForeignOrgNoDetermInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportForeignOrgNoDetermInd")]
//     public string SupportForeignOrgNoDetermInd { get; set; }
//
//     [JsonProperty("SupportedOrgClassDesignatedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportedOrgClassDesignatedInd")]
//     public string SupportedOrgClassDesignatedInd { get; set; }
//
//     [JsonProperty("SubstitutionBeyondOrgCntlInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubstitutionBeyondOrgCntlInd")]
//     public string SubstitutionBeyondOrgCntlInd { get; set; }
//
//     [JsonProperty("ExcessBusinessHoldingsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessBusinessHoldingsInd")]
//     public string ExcessBusinessHoldingsInd { get; set; }
// }
//
// public class Form990SchAType1SuprtOrgGrp
// {
//     [JsonProperty("PowerAppointMajorityDirTrstInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PowerAppointMajorityDirTrstInd")]
//     public string PowerAppointMajorityDirTrstInd { get; set; }
//
//     [JsonProperty("OperateBenefitNonSuprtOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OperateBenefitNonSuprtOrgInd")]
//     public string OperateBenefitNonSuprtOrgInd { get; set; }
// }
//
// public class Form990SchAType3SprtOrgAllGrp
// {
//     [JsonProperty("TimelyProvidedDocumentsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TimelyProvidedDocumentsInd")]
//     public string TimelyProvidedDocumentsInd { get; set; }
//
//     [JsonProperty("OfficersCloseRelationshipInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OfficersCloseRelationshipInd")]
//     public string OfficersCloseRelationshipInd { get; set; }
//
//     [JsonProperty("SupportedOrgVoiceInvestmentInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportedOrgVoiceInvestmentInd")]
//     public string SupportedOrgVoiceInvestmentInd { get; set; }
// }
//
// public class Form990ScheduleAPartVIGrp
// {
//     [JsonProperty("FormAndLineReferenceDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FormAndLineReferenceDesc")]
//     public string FormAndLineReferenceDesc { get; set; }
//
//     [JsonProperty("ExplanationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExplanationTxt")]
//     public string ExplanationTxt { get; set; }
// }
//
// public class Form990TotalAssetsGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class FreeCareOthPercentageGrp
// {
//     [JsonProperty("OtherInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherInd")]
//     public string OtherInd { get; set; }
//
//     [JsonProperty("FreeCareOtherPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FreeCareOtherPct")]
//     public string FreeCareOtherPct { get; set; }
// }
//
// public class FSAuditedBasisGrp
// {
//     [JsonProperty("SeparateBasisFinclStmtInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SeparateBasisFinclStmtInd")]
//     public string SeparateBasisFinclStmtInd { get; set; }
//
//     [JsonProperty("ConsolidatedBasisFinclStmtInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ConsolidatedBasisFinclStmtInd")]
//     public string ConsolidatedBasisFinclStmtInd { get; set; }
// }
//
// public class FundraiserActivityInfoGrp
// {
//     [JsonProperty("OrganizationBusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrganizationBusinessName")]
//     public OrganizationBusinessName OrganizationBusinessName { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("FundraiserControlOfFundsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraiserControlOfFundsInd")]
//     public string FundraiserControlOfFundsInd { get; set; }
//
//     [JsonProperty("GrossReceiptsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossReceiptsAmt")]
//     public string GrossReceiptsAmt { get; set; }
//
//     [JsonProperty("RetainedByContractorAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RetainedByContractorAmt")]
//     public string RetainedByContractorAmt { get; set; }
//
//     [JsonProperty("NetToOrganizationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetToOrganizationAmt")]
//     public string NetToOrganizationAmt { get; set; }
// }
//
// public class FundraisingActivitiesInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class FundraisingEventInformationGrp
// {
//     [JsonProperty("Event1Nm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Event1Nm")]
//     public string Event1Nm { get; set; }
//
//     [JsonProperty("GrossReceiptsEvent1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossReceiptsEvent1Amt")]
//     public string GrossReceiptsEvent1Amt { get; set; }
//
//     [JsonProperty("CharitableContriEvent1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CharitableContriEvent1Amt")]
//     public string CharitableContriEvent1Amt { get; set; }
//
//     [JsonProperty("GrossRevenueEvent1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossRevenueEvent1Amt")]
//     public string GrossRevenueEvent1Amt { get; set; }
//
//     [JsonProperty("RentFacilityCostsEvent1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RentFacilityCostsEvent1Amt")]
//     public string RentFacilityCostsEvent1Amt { get; set; }
//
//     [JsonProperty("EntertainmentEvent1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EntertainmentEvent1Amt")]
//     public string EntertainmentEvent1Amt { get; set; }
//
//     [JsonProperty("OtherDirectExpensesEvent1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherDirectExpensesEvent1Amt")]
//     public string OtherDirectExpensesEvent1Amt { get; set; }
//
//     [JsonProperty("Event2Nm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Event2Nm")]
//     public string Event2Nm { get; set; }
//
//     [JsonProperty("GrossReceiptsEvent2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossReceiptsEvent2Amt")]
//     public string GrossReceiptsEvent2Amt { get; set; }
//
//     [JsonProperty("GrossRevenueEvent2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossRevenueEvent2Amt")]
//     public string GrossRevenueEvent2Amt { get; set; }
//
//     [JsonProperty("OtherDirectExpensesEvent2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherDirectExpensesEvent2Amt")]
//     public string OtherDirectExpensesEvent2Amt { get; set; }
//
//     [JsonProperty("OtherEventsTotalCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherEventsTotalCnt")]
//     public string OtherEventsTotalCnt { get; set; }
//
//     [JsonProperty("GrossReceiptsOtherEventsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossReceiptsOtherEventsAmt")]
//     public string GrossReceiptsOtherEventsAmt { get; set; }
//
//     [JsonProperty("CharitableContriOtherEventsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CharitableContriOtherEventsAmt")]
//     public string CharitableContriOtherEventsAmt { get; set; }
//
//     [JsonProperty("GrossRevenueOtherEventsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossRevenueOtherEventsAmt")]
//     public string GrossRevenueOtherEventsAmt { get; set; }
//
//     [JsonProperty("OthDirectExpnssOtherEventsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OthDirectExpnssOtherEventsAmt")]
//     public string OthDirectExpnssOtherEventsAmt { get; set; }
//
//     [JsonProperty("GrossReceiptsTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossReceiptsTotalAmt")]
//     public string GrossReceiptsTotalAmt { get; set; }
//
//     [JsonProperty("CharitableContributionsTotAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CharitableContributionsTotAmt")]
//     public string CharitableContributionsTotAmt { get; set; }
//
//     [JsonProperty("GrossRevenueTotalEventsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossRevenueTotalEventsAmt")]
//     public string GrossRevenueTotalEventsAmt { get; set; }
//
//     [JsonProperty("RentFcltyCostsTotalEventsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RentFcltyCostsTotalEventsAmt")]
//     public string RentFcltyCostsTotalEventsAmt { get; set; }
//
//     [JsonProperty("EntertainmentTotalEventsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EntertainmentTotalEventsAmt")]
//     public string EntertainmentTotalEventsAmt { get; set; }
//
//     [JsonProperty("OthDirectExpnssTotalEventsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OthDirectExpnssTotalEventsAmt")]
//     public string OthDirectExpnssTotalEventsAmt { get; set; }
//
//     [JsonProperty("DirectExpenseSummaryEventsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectExpenseSummaryEventsAmt")]
//     public string DirectExpenseSummaryEventsAmt { get; set; }
//
//     [JsonProperty("NetIncomeSummaryAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetIncomeSummaryAmt")]
//     public string NetIncomeSummaryAmt { get; set; }
//
//     [JsonProperty("FoodAndBeverageEvent1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FoodAndBeverageEvent1Amt")]
//     public string FoodAndBeverageEvent1Amt { get; set; }
//
//     [JsonProperty("CharitableContriEvent2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CharitableContriEvent2Amt")]
//     public string CharitableContriEvent2Amt { get; set; }
//
//     [JsonProperty("RentFacilityCostsEvent2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RentFacilityCostsEvent2Amt")]
//     public string RentFacilityCostsEvent2Amt { get; set; }
//
//     [JsonProperty("FoodAndBeverageTotalEventsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FoodAndBeverageTotalEventsAmt")]
//     public string FoodAndBeverageTotalEventsAmt { get; set; }
//
//     [JsonProperty("EntertainmentEvent2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EntertainmentEvent2Amt")]
//     public string EntertainmentEvent2Amt { get; set; }
//
//     [JsonProperty("FoodAndBeverageEvent2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FoodAndBeverageEvent2Amt")]
//     public string FoodAndBeverageEvent2Amt { get; set; }
//
//     [JsonProperty("NonCashPrizesEvent1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashPrizesEvent1Amt")]
//     public string NonCashPrizesEvent1Amt { get; set; }
//
//     [JsonProperty("NonCashPrizesTotalEventsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashPrizesTotalEventsAmt")]
//     public string NonCashPrizesTotalEventsAmt { get; set; }
//
//     [JsonProperty("FoodAndBeverageOtherEventsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FoodAndBeverageOtherEventsAmt")]
//     public string FoodAndBeverageOtherEventsAmt { get; set; }
//
//     [JsonProperty("CashPrizesEvent1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashPrizesEvent1Amt")]
//     public string CashPrizesEvent1Amt { get; set; }
//
//     [JsonProperty("CashPrizesTotalEventsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashPrizesTotalEventsAmt")]
//     public string CashPrizesTotalEventsAmt { get; set; }
//
//     [JsonProperty("CashPrizesEvent2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashPrizesEvent2Amt")]
//     public string CashPrizesEvent2Amt { get; set; }
//
//     [JsonProperty("NonCashPrizesEvent2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashPrizesEvent2Amt")]
//     public string NonCashPrizesEvent2Amt { get; set; }
//
//     [JsonProperty("CashPrizesOtherEventsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashPrizesOtherEventsAmt")]
//     public string CashPrizesOtherEventsAmt { get; set; }
//
//     [JsonProperty("NonCashPrizesOtherEventsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashPrizesOtherEventsAmt")]
//     public string NonCashPrizesOtherEventsAmt { get; set; }
//
//     [JsonProperty("RentFcltyCostsOtherEventsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RentFcltyCostsOtherEventsAmt")]
//     public string RentFcltyCostsOtherEventsAmt { get; set; }
//
//     [JsonProperty("EntertainmentOtherEventsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EntertainmentOtherEventsAmt")]
//     public string EntertainmentOtherEventsAmt { get; set; }
// }
//
// public class FundraisingGrossIncomeAmt
// {
//     [JsonProperty("@fndrsngEventContriPrevRptAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@fndrsngEventContriPrevRptAmt")]
//     public string FndrsngEventContriPrevRptAmt { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class GainLossSaleOtherAssetGrp
// {
//     [JsonProperty("AssetDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AssetDesc")]
//     public string AssetDesc { get; set; }
//
//     [JsonProperty("HowAcquiredTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HowAcquiredTxt")]
//     public string HowAcquiredTxt { get; set; }
//
//     [JsonProperty("BasisMethodTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BasisMethodTxt")]
//     public string BasisMethodTxt { get; set; }
//
//     [JsonProperty("SalesExpenseAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SalesExpenseAmt")]
//     public string SalesExpenseAmt { get; set; }
//
//     [JsonProperty("TotalNetAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalNetAmt")]
//     public string TotalNetAmt { get; set; }
// }
//
// public class GainLossSaleOtherAssetsSch
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("GainLossSaleOtherAssetGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GainLossSaleOtherAssetGrp")]
//     public List<GainLossSaleOtherAssetGrp> GainLossSaleOtherAssetGrp { get; } = new List<GainLossSaleOtherAssetGrp>();
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class GainOrLossGrp
// {
//     [JsonProperty("OtherAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherAmt")]
//     public string OtherAmt { get; set; }
//
//     [JsonProperty("SecuritiesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SecuritiesAmt")]
//     public string SecuritiesAmt { get; set; }
// }
//
// public class GainSalesAstOthThanInvntryGrp
// {
//     [JsonProperty("RelatedOrExemptFunctionIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFunctionIncmAmt")]
//     public string RelatedOrExemptFunctionIncmAmt { get; set; }
// }
//
// public class GamingActivitiesInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class GamingInformationGrp
// {
//     [JsonProperty("GrossRevenueBingoAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossRevenueBingoAmt")]
//     public string GrossRevenueBingoAmt { get; set; }
//
//     [JsonProperty("OtherDirectExpensesBingoAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherDirectExpensesBingoAmt")]
//     public string OtherDirectExpensesBingoAmt { get; set; }
//
//     [JsonProperty("VolunteerLaborBingoInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("VolunteerLaborBingoInd")]
//     public string VolunteerLaborBingoInd { get; set; }
//
//     [JsonProperty("GrossRevenueTotalGamingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossRevenueTotalGamingAmt")]
//     public string GrossRevenueTotalGamingAmt { get; set; }
//
//     [JsonProperty("OthDirectExpnssTotalGamingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OthDirectExpnssTotalGamingAmt")]
//     public string OthDirectExpnssTotalGamingAmt { get; set; }
//
//     [JsonProperty("DirectExpenseSummaryGamingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectExpenseSummaryGamingAmt")]
//     public string DirectExpenseSummaryGamingAmt { get; set; }
//
//     [JsonProperty("NetGamingIncomeSummaryAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetGamingIncomeSummaryAmt")]
//     public string NetGamingIncomeSummaryAmt { get; set; }
//
//     [JsonProperty("VolunteerLaborPullTabsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("VolunteerLaborPullTabsInd")]
//     public string VolunteerLaborPullTabsInd { get; set; }
//
//     [JsonProperty("VolunteerLaborOtherGamingInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("VolunteerLaborOtherGamingInd")]
//     public string VolunteerLaborOtherGamingInd { get; set; }
//
//     [JsonProperty("CashPrizesBingoAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashPrizesBingoAmt")]
//     public string CashPrizesBingoAmt { get; set; }
//
//     [JsonProperty("GrossRevenuePullTabsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossRevenuePullTabsAmt")]
//     public string GrossRevenuePullTabsAmt { get; set; }
//
//     [JsonProperty("CashPrizesPullTabsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashPrizesPullTabsAmt")]
//     public string CashPrizesPullTabsAmt { get; set; }
//
//     [JsonProperty("OtherDirectExpensesPullTabsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherDirectExpensesPullTabsAmt")]
//     public string OtherDirectExpensesPullTabsAmt { get; set; }
//
//     [JsonProperty("CashPrizesTotalGamingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashPrizesTotalGamingAmt")]
//     public string CashPrizesTotalGamingAmt { get; set; }
//
//     [JsonProperty("GrossRevenueOtherGamingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossRevenueOtherGamingAmt")]
//     public string GrossRevenueOtherGamingAmt { get; set; }
//
//     [JsonProperty("CashPrizesOtherGamingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashPrizesOtherGamingAmt")]
//     public string CashPrizesOtherGamingAmt { get; set; }
//
//     [JsonProperty("NonCashPrizesOtherGamingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashPrizesOtherGamingAmt")]
//     public string NonCashPrizesOtherGamingAmt { get; set; }
//
//     [JsonProperty("OthDirectExpnssOtherGamingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OthDirectExpnssOtherGamingAmt")]
//     public string OthDirectExpnssOtherGamingAmt { get; set; }
//
//     [JsonProperty("VolunteerLaborOtherGamingPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("VolunteerLaborOtherGamingPct")]
//     public string VolunteerLaborOtherGamingPct { get; set; }
//
//     [JsonProperty("NonCashPrizesTotalGamingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashPrizesTotalGamingAmt")]
//     public string NonCashPrizesTotalGamingAmt { get; set; }
//
//     [JsonProperty("RentFacilityCostsBingoAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RentFacilityCostsBingoAmt")]
//     public string RentFacilityCostsBingoAmt { get; set; }
//
//     [JsonProperty("RentFcltyCostsTotalGamingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RentFcltyCostsTotalGamingAmt")]
//     public string RentFcltyCostsTotalGamingAmt { get; set; }
//
//     [JsonProperty("NonCashPrizesBingoAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashPrizesBingoAmt")]
//     public string NonCashPrizesBingoAmt { get; set; }
//
//     [JsonProperty("NonCashPrizesPullTabsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashPrizesPullTabsAmt")]
//     public string NonCashPrizesPullTabsAmt { get; set; }
//
//     [JsonProperty("RentFacilityCostsPullTabsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RentFacilityCostsPullTabsAmt")]
//     public string RentFacilityCostsPullTabsAmt { get; set; }
//
//     [JsonProperty("RentFcltyCostsOtherGamingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RentFcltyCostsOtherGamingAmt")]
//     public string RentFcltyCostsOtherGamingAmt { get; set; }
//
//     [JsonProperty("VolunteerLaborPullTabsPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("VolunteerLaborPullTabsPct")]
//     public string VolunteerLaborPullTabsPct { get; set; }
//
//     [JsonProperty("VolunteerLaborBingoPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("VolunteerLaborBingoPct")]
//     public string VolunteerLaborBingoPct { get; set; }
// }
//
// public class GamingManagerBusinessName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
//
//     [JsonProperty("BusinessNameLine2Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine2Txt")]
//     public string BusinessNameLine2Txt { get; set; }
// }
//
// public class GDS10YearProperty
// {
//     [JsonProperty("BasisForDepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BasisForDepreciationAmt")]
//     public string BasisForDepreciationAmt { get; set; }
//
//     [JsonProperty("RecoveryPrd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecoveryPrd")]
//     public string RecoveryPrd { get; set; }
//
//     [JsonProperty("DepreciationConventionCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationConventionCd")]
//     public string DepreciationConventionCd { get; set; }
//
//     [JsonProperty("DepreciationMethodCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationMethodCd")]
//     public string DepreciationMethodCd { get; set; }
//
//     [JsonProperty("DepreciationDeductionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationDeductionAmt")]
//     public string DepreciationDeductionAmt { get; set; }
// }
//
// public class GDS5YearProperty
// {
//     [JsonProperty("BasisForDepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BasisForDepreciationAmt")]
//     public string BasisForDepreciationAmt { get; set; }
//
//     [JsonProperty("RecoveryPrd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecoveryPrd")]
//     public string RecoveryPrd { get; set; }
//
//     [JsonProperty("DepreciationConventionCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationConventionCd")]
//     public string DepreciationConventionCd { get; set; }
//
//     [JsonProperty("DepreciationMethodCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationMethodCd")]
//     public string DepreciationMethodCd { get; set; }
//
//     [JsonProperty("DepreciationDeductionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationDeductionAmt")]
//     public string DepreciationDeductionAmt { get; set; }
// }
//
// public class GDS7YearProperty
// {
//     [JsonProperty("BasisForDepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BasisForDepreciationAmt")]
//     public string BasisForDepreciationAmt { get; set; }
//
//     [JsonProperty("RecoveryPrd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecoveryPrd")]
//     public string RecoveryPrd { get; set; }
//
//     [JsonProperty("DepreciationConventionCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationConventionCd")]
//     public string DepreciationConventionCd { get; set; }
//
//     [JsonProperty("DepreciationMethodCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationMethodCd")]
//     public string DepreciationMethodCd { get; set; }
//
//     [JsonProperty("DepreciationDeductionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationDeductionAmt")]
//     public string DepreciationDeductionAmt { get; set; }
// }
//
// public class GDSNonRsdntlRealProp
// {
//     [JsonProperty("MonthAndYearPlacedInServiceDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MonthAndYearPlacedInServiceDt")]
//     public string MonthAndYearPlacedInServiceDt { get; set; }
//
//     [JsonProperty("BasisForDepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BasisForDepreciationAmt")]
//     public string BasisForDepreciationAmt { get; set; }
//
//     [JsonProperty("DepreciationDeductionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationDeductionAmt")]
//     public string DepreciationDeductionAmt { get; set; }
// }
//
// public class GenBusCrOrEligSmllBusCrGrp
// {
//     [JsonProperty("GeneralBusCrFromNnpssvActyGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GeneralBusCrFromNnpssvActyGrp")]
//     public GeneralBusCrFromNnpssvActyGrp GeneralBusCrFromNnpssvActyGrp { get; set; }
//
//     [JsonProperty("ConsolidatedBusinessCreditsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ConsolidatedBusinessCreditsGrp")]
//     public ConsolidatedBusinessCreditsGrp ConsolidatedBusinessCreditsGrp { get; set; }
//
//     [JsonProperty("GeneralBusCrCarryforwardsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GeneralBusCrCarryforwardsGrp")]
//     public GeneralBusCrCarryforwardsGrp GeneralBusCrCarryforwardsGrp { get; set; }
//
//     [JsonProperty("GeneralBusCrFromPassiveActyGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GeneralBusCrFromPassiveActyGrp")]
//     public List<GeneralBusCrFromPassiveActyGrp> GeneralBusCrFromPassiveActyGrp { get; } =
//         new List<GeneralBusCrFromPassiveActyGrp>();
// }
//
// public class GeneralBusCrCarryforwardsGrp
// {
//     [JsonProperty("GeneralBusCrCarryforwardsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GeneralBusCrCarryforwardsInd")]
//     public string GeneralBusCrCarryforwardsInd { get; set; }
//
//     [JsonProperty("BusinessCreditsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessCreditsGrp")]
//     public BusinessCreditsGrp BusinessCreditsGrp { get; set; }
// }
//
// public class GeneralBusCrFromNnpssvActyGrp
// {
//     [JsonProperty("GeneralBusCrFromNnpssvActyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GeneralBusCrFromNnpssvActyInd")]
//     public string GeneralBusCrFromNnpssvActyInd { get; set; }
//
//     [JsonProperty("BusinessCreditsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessCreditsGrp")]
//     public BusinessCreditsGrp BusinessCreditsGrp { get; set; }
// }
//
// public class GeneralBusCrFromPassiveActyGrp
// {
//     [JsonProperty("GeneralBusCrFromPassiveActyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GeneralBusCrFromPassiveActyInd")]
//     public string GeneralBusCrFromPassiveActyInd { get; set; }
//
//     [JsonProperty("BusinessCreditsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessCreditsGrp")]
//     public BusinessCreditsGrp BusinessCreditsGrp { get; set; }
// }
//
// public class GeneralDepreciationSystem
// {
//     [JsonProperty("GDS5YearProperty", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GDS5YearProperty")]
//     public GDS5YearProperty GDS5YearProperty { get; set; }
//
//     [JsonProperty("GDS7YearProperty", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GDS7YearProperty")]
//     public List<GDS7YearProperty> GDS7YearProperty { get; } = new List<GDS7YearProperty>();
//
//     [JsonProperty("GDS10YearProperty", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GDS10YearProperty")]
//     public GDS10YearProperty GDS10YearProperty { get; set; }
//
//     [JsonProperty("GDSNonRsdntlRealProp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GDSNonRsdntlRealProp")]
//     public GDSNonRsdntlRealProp GDSNonRsdntlRealProp { get; set; }
// }
//
// public class GeneralExplanationAttachment
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("GeneralExplanationGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GeneralExplanationGrp")]
//     public GeneralExplanationGrp GeneralExplanationGrp { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
// }
//
// public class GeneralExplanationGrp
// {
//     [JsonProperty("IdentifierTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IdentifierTxt")]
//     public string IdentifierTxt { get; set; }
//
//     [JsonProperty("FormAndLineReferenceDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FormAndLineReferenceDesc")]
//     public string FormAndLineReferenceDesc { get; set; }
//
//     [JsonProperty("MediumExplanationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MediumExplanationTxt")]
//     public string MediumExplanationTxt { get; set; }
// }
//
// public class GiftsGrantsContriRcvd170Grp
// {
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class GiftsGrantsContrisRcvd509Grp
// {
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class GovtFurnSrvcFcltsVl170Grp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
// }
//
// public class GovtFurnSrvcFcltsVl509Grp
// {
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
// }
//
// public class GrantOrContriApprvForFutGrp
// {
//     [JsonProperty("RecipientBusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecipientBusinessName")]
//     public RecipientBusinessName RecipientBusinessName { get; set; }
//
//     [JsonProperty("RecipientUSAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecipientUSAddress")]
//     public RecipientUSAddress RecipientUSAddress { get; set; }
//
//     [JsonProperty("RecipientRelationshipTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecipientRelationshipTxt")]
//     public string RecipientRelationshipTxt { get; set; }
//
//     [JsonProperty("RecipientFoundationStatusTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecipientFoundationStatusTxt")]
//     public string RecipientFoundationStatusTxt { get; set; }
//
//     [JsonProperty("GrantOrContributionPurposeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantOrContributionPurposeTxt")]
//     public string GrantOrContributionPurposeTxt { get; set; }
//
//     [JsonProperty("Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Amt")]
//     public string Amt { get; set; }
//
//     [JsonProperty("RecipientPersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecipientPersonNm")]
//     public string RecipientPersonNm { get; set; }
//
//     [JsonProperty("RecipientForeignAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecipientForeignAddress")]
//     public RecipientForeignAddress RecipientForeignAddress { get; set; }
// }
//
// public class GrantOrContributionPdDurYrGrp
// {
//     [JsonProperty("RecipientBusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecipientBusinessName")]
//     public RecipientBusinessName RecipientBusinessName { get; set; }
//
//     [JsonProperty("RecipientUSAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecipientUSAddress")]
//     public RecipientUSAddress RecipientUSAddress { get; set; }
//
//     [JsonProperty("RecipientFoundationStatusTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecipientFoundationStatusTxt")]
//     public string RecipientFoundationStatusTxt { get; set; }
//
//     [JsonProperty("GrantOrContributionPurposeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantOrContributionPurposeTxt")]
//     public string GrantOrContributionPurposeTxt { get; set; }
//
//     [JsonProperty("Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Amt")]
//     public string Amt { get; set; }
// }
//
// public class GrantsOtherAsstToIndivInUSGrp
// {
//     [JsonProperty("GrantTypeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantTypeTxt")]
//     public string GrantTypeTxt { get; set; }
//
//     [JsonProperty("RecipientCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecipientCnt")]
//     public string RecipientCnt { get; set; }
//
//     [JsonProperty("CashGrantAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashGrantAmt")]
//     public string CashGrantAmt { get; set; }
//
//     [JsonProperty("ValuationMethodUsedDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ValuationMethodUsedDesc")]
//     public string ValuationMethodUsedDesc { get; set; }
//
//     [JsonProperty("NonCashAssistanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashAssistanceAmt")]
//     public string NonCashAssistanceAmt { get; set; }
//
//     [JsonProperty("NonCashAssistanceDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashAssistanceDesc")]
//     public string NonCashAssistanceDesc { get; set; }
// }
//
// public class GrantsPayableGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class GrantsToDomesticIndividualsGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
// }
//
// public class GrantsToDomesticOrgsGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
// }
//
// public class GrantsToOrgOutsideUSGrp
// {
//     [JsonProperty("RegionTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RegionTxt")]
//     public string RegionTxt { get; set; }
//
//     [JsonProperty("PurposeOfGrantTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PurposeOfGrantTxt")]
//     public string PurposeOfGrantTxt { get; set; }
//
//     [JsonProperty("CashGrantAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashGrantAmt")]
//     public string CashGrantAmt { get; set; }
//
//     [JsonProperty("MannerOfCashDisbursementTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MannerOfCashDisbursementTxt")]
//     public string MannerOfCashDisbursementTxt { get; set; }
//
//     [JsonProperty("NonCashAssistanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashAssistanceAmt")]
//     public string NonCashAssistanceAmt { get; set; }
//
//     [JsonProperty("ValuationMethodUsedDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ValuationMethodUsedDesc")]
//     public string ValuationMethodUsedDesc { get; set; }
// }
//
// public class GrassrootsNontaxableGrp
// {
//     [JsonProperty("FilingOrganizationsTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FilingOrganizationsTotalAmt")]
//     public string FilingOrganizationsTotalAmt { get; set; }
//
//     [JsonProperty("AffiliatedGroupTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AffiliatedGroupTotalAmt")]
//     public string AffiliatedGroupTotalAmt { get; set; }
// }
//
// public class GrntAsstBnftInterestedPrsnGrp
// {
//     [JsonProperty("PersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonNm")]
//     public string PersonNm { get; set; }
//
//     [JsonProperty("CashGrantAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashGrantAmt")]
//     public string CashGrantAmt { get; set; }
//
//     [JsonProperty("TypeOfAssistanceTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TypeOfAssistanceTxt")]
//     public string TypeOfAssistanceTxt { get; set; }
//
//     [JsonProperty("AssistancePurposeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AssistancePurposeTxt")]
//     public string AssistancePurposeTxt { get; set; }
// }
//
// public class GrossAmountSalesAssetsGrp
// {
//     [JsonProperty("OtherAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherAmt")]
//     public string OtherAmt { get; set; }
//
//     [JsonProperty("SecuritiesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SecuritiesAmt")]
//     public string SecuritiesAmt { get; set; }
// }
//
// public class GrossInvestmentIncome170Grp
// {
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class GrossInvestmentIncome509Grp
// {
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class GrossProfitRevAndExpnssAmt
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
//
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
// }
//
// public class GrossReceiptsAdmissionsGrp
// {
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class GrossReceiptsNonUnrltBusGrp
// {
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
// }
//
// public class GrossRentsGrp
// {
//     [JsonProperty("PersonalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonalAmt")]
//     public string PersonalAmt { get; set; }
//
//     [JsonProperty("RealAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RealAmt")]
//     public string RealAmt { get; set; }
// }
//
// public class HealthImprovementAdvocacyGrp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
// }
//
// public class HealthProfessionsEducationGrp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
// }
//
// public class HeldWorksArtGrp
// {
//     [JsonProperty("RevenuesIncludedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RevenuesIncludedAmt")]
//     public string RevenuesIncludedAmt { get; set; }
//
//     [JsonProperty("AssetsIncludedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AssetsIncludedAmt")]
//     public string AssetsIncludedAmt { get; set; }
// }
//
// public class HospitalFacilitiesGrp
// {
//     [JsonProperty("FacilityNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FacilityNum")]
//     public string FacilityNum { get; set; }
//
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("LicensedHospitalInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LicensedHospitalInd")]
//     public string LicensedHospitalInd { get; set; }
//
//     [JsonProperty("GeneralMedicalAndSurgicalInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GeneralMedicalAndSurgicalInd")]
//     public string GeneralMedicalAndSurgicalInd { get; set; }
//
//     [JsonProperty("EmergencyRoom24HrsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EmergencyRoom24HrsInd")]
//     public string EmergencyRoom24HrsInd { get; set; }
//
//     [JsonProperty("WebsiteAddressTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("WebsiteAddressTxt")]
//     public string WebsiteAddressTxt { get; set; }
//
//     [JsonProperty("StateLicenseNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StateLicenseNum")]
//     public string StateLicenseNum { get; set; }
//
//     [JsonProperty("CriticalAccessHospitalInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CriticalAccessHospitalInd")]
//     public string CriticalAccessHospitalInd { get; set; }
//
//     [JsonProperty("EmergencyRoomOtherInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EmergencyRoomOtherInd")]
//     public string EmergencyRoomOtherInd { get; set; }
//
//     [JsonProperty("TeachingHospitalInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TeachingHospitalInd")]
//     public string TeachingHospitalInd { get; set; }
// }
//
// public class HospitalFacilityName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
// }
//
// public class HospitalFcltyPoliciesPrctcGrp
// {
//     [JsonProperty("HospitalFacilityName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HospitalFacilityName")]
//     public HospitalFacilityName HospitalFacilityName { get; set; }
//
//     [JsonProperty("FacilityNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FacilityNum")]
//     public string FacilityNum { get; set; }
//
//     [JsonProperty("FirstLicensedCYOrPYInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FirstLicensedCYOrPYInd")]
//     public string FirstLicensedCYOrPYInd { get; set; }
//
//     [JsonProperty("TaxExemptHospitalCYOrPYInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxExemptHospitalCYOrPYInd")]
//     public string TaxExemptHospitalCYOrPYInd { get; set; }
//
//     [JsonProperty("CHNAConductedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CHNAConductedInd")]
//     public string CHNAConductedInd { get; set; }
//
//     [JsonProperty("CommunityDefinitionInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CommunityDefinitionInd")]
//     public string CommunityDefinitionInd { get; set; }
//
//     [JsonProperty("CommunityDemographicsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CommunityDemographicsInd")]
//     public string CommunityDemographicsInd { get; set; }
//
//     [JsonProperty("ExistingResourcesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExistingResourcesInd")]
//     public string ExistingResourcesInd { get; set; }
//
//     [JsonProperty("HowDataObtainedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HowDataObtainedInd")]
//     public string HowDataObtainedInd { get; set; }
//
//     [JsonProperty("CommunityHealthNeedsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CommunityHealthNeedsInd")]
//     public string CommunityHealthNeedsInd { get; set; }
//
//     [JsonProperty("OtherHealthIssuesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherHealthIssuesInd")]
//     public string OtherHealthIssuesInd { get; set; }
//
//     [JsonProperty("CommunityHlthNeedsIdProcessInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CommunityHlthNeedsIdProcessInd")]
//     public string CommunityHlthNeedsIdProcessInd { get; set; }
//
//     [JsonProperty("ConsultingProcessInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ConsultingProcessInd")]
//     public string ConsultingProcessInd { get; set; }
//
//     [JsonProperty("PriorCHNAImpactInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorCHNAImpactInd")]
//     public string PriorCHNAImpactInd { get; set; }
//
//     [JsonProperty("CHNAConductedYr", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CHNAConductedYr")]
//     public string CHNAConductedYr { get; set; }
//
//     [JsonProperty("TakeIntoAccountOthersInputInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TakeIntoAccountOthersInputInd")]
//     public string TakeIntoAccountOthersInputInd { get; set; }
//
//     [JsonProperty("CHNAConductedWithOtherFcltsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CHNAConductedWithOtherFcltsInd")]
//     public string CHNAConductedWithOtherFcltsInd { get; set; }
//
//     [JsonProperty("CHNAConductedWithNonFcltsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CHNAConductedWithNonFcltsInd")]
//     public string CHNAConductedWithNonFcltsInd { get; set; }
//
//     [JsonProperty("CHNAReportWidelyAvailableInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CHNAReportWidelyAvailableInd")]
//     public string CHNAReportWidelyAvailableInd { get; set; }
//
//     [JsonProperty("RptAvailableOnOwnWebsiteInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RptAvailableOnOwnWebsiteInd")]
//     public string RptAvailableOnOwnWebsiteInd { get; set; }
//
//     [JsonProperty("OwnWebsiteURLTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OwnWebsiteURLTxt")]
//     public string OwnWebsiteURLTxt { get; set; }
//
//     [JsonProperty("PaperCopyPublicInspectionInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PaperCopyPublicInspectionInd")]
//     public string PaperCopyPublicInspectionInd { get; set; }
//
//     [JsonProperty("ImplementationStrategyAdoptInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ImplementationStrategyAdoptInd")]
//     public string ImplementationStrategyAdoptInd { get; set; }
//
//     [JsonProperty("ImplementationStrategyAdptYr", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ImplementationStrategyAdptYr")]
//     public string ImplementationStrategyAdptYr { get; set; }
//
//     [JsonProperty("StrategyPostedWebsiteInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StrategyPostedWebsiteInd")]
//     public string StrategyPostedWebsiteInd { get; set; }
//
//     [JsonProperty("StrategyWebsiteURLTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StrategyWebsiteURLTxt")]
//     public string StrategyWebsiteURLTxt { get; set; }
//
//     [JsonProperty("OrganizationIncurExciseTaxInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrganizationIncurExciseTaxInd")]
//     public string OrganizationIncurExciseTaxInd { get; set; }
//
//     [JsonProperty("EligCriteriaExplainedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EligCriteriaExplainedInd")]
//     public string EligCriteriaExplainedInd { get; set; }
//
//     [JsonProperty("FPGFamilyIncmLmtFreeDscntInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FPGFamilyIncmLmtFreeDscntInd")]
//     public string FPGFamilyIncmLmtFreeDscntInd { get; set; }
//
//     [JsonProperty("FPGFamilyIncmLmtFreeCarePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FPGFamilyIncmLmtFreeCarePct")]
//     public string FPGFamilyIncmLmtFreeCarePct { get; set; }
//
//     [JsonProperty("FPGFamilyIncmLmtDscntCarePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FPGFamilyIncmLmtDscntCarePct")]
//     public string FPGFamilyIncmLmtDscntCarePct { get; set; }
//
//     [JsonProperty("IncomeLevelCriteriaInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IncomeLevelCriteriaInd")]
//     public string IncomeLevelCriteriaInd { get; set; }
//
//     [JsonProperty("AssetLevelCriteriaInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AssetLevelCriteriaInd")]
//     public string AssetLevelCriteriaInd { get; set; }
//
//     [JsonProperty("MedicalIndigencyCriteriaInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MedicalIndigencyCriteriaInd")]
//     public string MedicalIndigencyCriteriaInd { get; set; }
//
//     [JsonProperty("InsuranceStatusCriteriaInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InsuranceStatusCriteriaInd")]
//     public string InsuranceStatusCriteriaInd { get; set; }
//
//     [JsonProperty("UnderinsuranceStatCriteriaInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnderinsuranceStatCriteriaInd")]
//     public string UnderinsuranceStatCriteriaInd { get; set; }
//
//     [JsonProperty("ExplainedBasisInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExplainedBasisInd")]
//     public string ExplainedBasisInd { get; set; }
//
//     [JsonProperty("AppFinancialAsstExplnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AppFinancialAsstExplnInd")]
//     public string AppFinancialAsstExplnInd { get; set; }
//
//     [JsonProperty("DescribedInfoInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DescribedInfoInd")]
//     public string DescribedInfoInd { get; set; }
//
//     [JsonProperty("DescribedSuprtDocInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DescribedSuprtDocInd")]
//     public string DescribedSuprtDocInd { get; set; }
//
//     [JsonProperty("ProvidedHospitalContactInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProvidedHospitalContactInd")]
//     public string ProvidedHospitalContactInd { get; set; }
//
//     [JsonProperty("IncludesPublicityMeasuresInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IncludesPublicityMeasuresInd")]
//     public string IncludesPublicityMeasuresInd { get; set; }
//
//     [JsonProperty("FAPAvailableOnWebsiteInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FAPAvailableOnWebsiteInd")]
//     public string FAPAvailableOnWebsiteInd { get; set; }
//
//     [JsonProperty("FAPAvailableOnWebsiteURLTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FAPAvailableOnWebsiteURLTxt")]
//     public string FAPAvailableOnWebsiteURLTxt { get; set; }
//
//     [JsonProperty("FAPAppAvailableOnWebsiteInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FAPAppAvailableOnWebsiteInd")]
//     public string FAPAppAvailableOnWebsiteInd { get; set; }
//
//     [JsonProperty("FAPAppAvailableOnWebsiteURLTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FAPAppAvailableOnWebsiteURLTxt")]
//     public string FAPAppAvailableOnWebsiteURLTxt { get; set; }
//
//     [JsonProperty("FAPSummaryOnWebsiteInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FAPSummaryOnWebsiteInd")]
//     public string FAPSummaryOnWebsiteInd { get; set; }
//
//     [JsonProperty("FAPSummaryOnWebsiteURLTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FAPSummaryOnWebsiteURLTxt")]
//     public string FAPSummaryOnWebsiteURLTxt { get; set; }
//
//     [JsonProperty("FAPAvlblOnRequestNoChargeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FAPAvlblOnRequestNoChargeInd")]
//     public string FAPAvlblOnRequestNoChargeInd { get; set; }
//
//     [JsonProperty("FAPAppAvlblOnRequestNoChrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FAPAppAvlblOnRequestNoChrgInd")]
//     public string FAPAppAvlblOnRequestNoChrgInd { get; set; }
//
//     [JsonProperty("FAPSumAvlblOnRequestNoChrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FAPSumAvlblOnRequestNoChrgInd")]
//     public string FAPSumAvlblOnRequestNoChrgInd { get; set; }
//
//     [JsonProperty("NotifiedFAPCopyBillDisplayInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NotifiedFAPCopyBillDisplayInd")]
//     public string NotifiedFAPCopyBillDisplayInd { get; set; }
//
//     [JsonProperty("CommuntityNotifiedFAPInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CommuntityNotifiedFAPInd")]
//     public string CommuntityNotifiedFAPInd { get; set; }
//
//     [JsonProperty("FAPActionsOnNonpaymentInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FAPActionsOnNonpaymentInd")]
//     public string FAPActionsOnNonpaymentInd { get; set; }
//
//     [JsonProperty("CollectionActivitiesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CollectionActivitiesInd")]
//     public string CollectionActivitiesInd { get; set; }
//
//     [JsonProperty("MadeEffortOrallyNotifyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MadeEffortOrallyNotifyInd")]
//     public string MadeEffortOrallyNotifyInd { get; set; }
//
//     [JsonProperty("ProcessedFAPApplicationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProcessedFAPApplicationInd")]
//     public string ProcessedFAPApplicationInd { get; set; }
//
//     [JsonProperty("MadePresumptiveEligDetermInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MadePresumptiveEligDetermInd")]
//     public string MadePresumptiveEligDetermInd { get; set; }
//
//     [JsonProperty("NondisEmergencyCarePolicyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NondisEmergencyCarePolicyInd")]
//     public string NondisEmergencyCarePolicyInd { get; set; }
//
//     [JsonProperty("LookBackMedicareInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LookBackMedicareInd")]
//     public string LookBackMedicareInd { get; set; }
//
//     [JsonProperty("AmountsGenerallyBilledInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AmountsGenerallyBilledInd")]
//     public string AmountsGenerallyBilledInd { get; set; }
//
//     [JsonProperty("GrossChargesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossChargesInd")]
//     public string GrossChargesInd { get; set; }
//
//     [JsonProperty("ProvidedNonprofitContactInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProvidedNonprofitContactInd")]
//     public string ProvidedNonprofitContactInd { get; set; }
//
//     [JsonProperty("FAPTranslatedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FAPTranslatedInd")]
//     public string FAPTranslatedInd { get; set; }
//
//     [JsonProperty("PermitNoActionsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PermitNoActionsInd")]
//     public string PermitNoActionsInd { get; set; }
//
//     [JsonProperty("ProspectiveMedicareMedicaidInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProspectiveMedicareMedicaidInd")]
//     public string ProspectiveMedicareMedicaidInd { get; set; }
//
//     [JsonProperty("OtherWebsiteInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherWebsiteInd")]
//     public string OtherWebsiteInd { get; set; }
//
//     [JsonProperty("OtherWebsiteURLTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherWebsiteURLTxt")]
//     public string OtherWebsiteURLTxt { get; set; }
//
//     [JsonProperty("OtherCriteriaInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherCriteriaInd")]
//     public string OtherCriteriaInd { get; set; }
//
//     [JsonProperty("RptAvailableThruOtherMethodInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RptAvailableThruOtherMethodInd")]
//     public string RptAvailableThruOtherMethodInd { get; set; }
//
//     [JsonProperty("ProvidedWrittenNoticeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProvidedWrittenNoticeInd")]
//     public string ProvidedWrittenNoticeInd { get; set; }
//
//     [JsonProperty("LookBackMedicarePrivateInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LookBackMedicarePrivateInd")]
//     public string LookBackMedicarePrivateInd { get; set; }
//
//     [JsonProperty("ResidencyCriteriaInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ResidencyCriteriaInd")]
//     public string ResidencyCriteriaInd { get; set; }
// }
//
// public class HospitalNameAndAddressGrp
// {
//     [JsonProperty("SupportedOrganizationName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportedOrganizationName")]
//     public SupportedOrganizationName SupportedOrganizationName { get; set; }
//
//     [JsonProperty("CityNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CityNm")]
//     public string CityNm { get; set; }
//
//     [JsonProperty("StateAbbreviationCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StateAbbreviationCd")]
//     public string StateAbbreviationCd { get; set; }
//
//     [JsonProperty("CountryCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CountryCd")]
//     public string CountryCd { get; set; }
// }
//
// public class IdDisregardedEntitiesGrp
// {
//     [JsonProperty("DisregardedEntityName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisregardedEntityName")]
//     public DisregardedEntityName DisregardedEntityName { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("PrimaryActivitiesTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrimaryActivitiesTxt")]
//     public string PrimaryActivitiesTxt { get; set; }
//
//     [JsonProperty("LegalDomicileStateCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LegalDomicileStateCd")]
//     public string LegalDomicileStateCd { get; set; }
//
//     [JsonProperty("TotalIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalIncomeAmt")]
//     public string TotalIncomeAmt { get; set; }
//
//     [JsonProperty("EndOfYearAssetsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EndOfYearAssetsAmt")]
//     public string EndOfYearAssetsAmt { get; set; }
//
//     [JsonProperty("DirectControllingEntityName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectControllingEntityName")]
//     public DirectControllingEntityName DirectControllingEntityName { get; set; }
//
//     [JsonProperty("EIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EIN")]
//     public string EIN { get; set; }
// }
//
// public class IdRelatedOrgTxblCorpTrGrp
// {
//     [JsonProperty("RelatedOrganizationName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrganizationName")]
//     public RelatedOrganizationName RelatedOrganizationName { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("EIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EIN")]
//     public string EIN { get; set; }
//
//     [JsonProperty("PrimaryActivitiesTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrimaryActivitiesTxt")]
//     public string PrimaryActivitiesTxt { get; set; }
//
//     [JsonProperty("LegalDomicileStateCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LegalDomicileStateCd")]
//     public string LegalDomicileStateCd { get; set; }
//
//     [JsonProperty("DirectControllingEntityName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectControllingEntityName")]
//     public DirectControllingEntityName DirectControllingEntityName { get; set; }
//
//     [JsonProperty("EntityTypeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EntityTypeTxt")]
//     public string EntityTypeTxt { get; set; }
//
//     [JsonProperty("ShareOfTotalIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ShareOfTotalIncomeAmt")]
//     public string ShareOfTotalIncomeAmt { get; set; }
//
//     [JsonProperty("ShareOfEOYAssetsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ShareOfEOYAssetsAmt")]
//     public string ShareOfEOYAssetsAmt { get; set; }
//
//     [JsonProperty("OwnershipPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OwnershipPct")]
//     public string OwnershipPct { get; set; }
//
//     [JsonProperty("ControlledOrganizationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ControlledOrganizationInd")]
//     public string ControlledOrganizationInd { get; set; }
// }
//
// public class IdRelatedOrgTxblPartnershipGrp
// {
//     [JsonProperty("RelatedOrganizationName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrganizationName")]
//     public RelatedOrganizationName RelatedOrganizationName { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("EIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EIN")]
//     public string EIN { get; set; }
//
//     [JsonProperty("PrimaryActivitiesTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrimaryActivitiesTxt")]
//     public string PrimaryActivitiesTxt { get; set; }
//
//     [JsonProperty("LegalDomicileStateCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LegalDomicileStateCd")]
//     public string LegalDomicileStateCd { get; set; }
//
//     [JsonProperty("DirectControllingNACd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectControllingNACd")]
//     public string DirectControllingNACd { get; set; }
//
//     [JsonProperty("DisproportionateAllocationsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisproportionateAllocationsInd")]
//     public string DisproportionateAllocationsInd { get; set; }
//
//     [JsonProperty("GeneralOrManagingPartnerInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GeneralOrManagingPartnerInd")]
//     public string GeneralOrManagingPartnerInd { get; set; }
// }
//
// public class IdRelatedTaxExemptOrgGrp
// {
//     [JsonProperty("DisregardedEntityName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisregardedEntityName")]
//     public DisregardedEntityName DisregardedEntityName { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("EIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EIN")]
//     public string EIN { get; set; }
//
//     [JsonProperty("PrimaryActivitiesTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrimaryActivitiesTxt")]
//     public string PrimaryActivitiesTxt { get; set; }
//
//     [JsonProperty("LegalDomicileStateCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LegalDomicileStateCd")]
//     public string LegalDomicileStateCd { get; set; }
//
//     [JsonProperty("ExemptCodeSectionTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExemptCodeSectionTxt")]
//     public string ExemptCodeSectionTxt { get; set; }
//
//     [JsonProperty("PublicCharityStatusTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PublicCharityStatusTxt")]
//     public string PublicCharityStatusTxt { get; set; }
//
//     [JsonProperty("DirectControllingNACd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectControllingNACd")]
//     public string DirectControllingNACd { get; set; }
//
//     [JsonProperty("ControlledOrganizationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ControlledOrganizationInd")]
//     public string ControlledOrganizationInd { get; set; }
// }
//
// public class IncludeFIN48FootnoteInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class IncmFromInvestBondProceedsGrp
// {
//     [JsonProperty("TotalRevenueColumnAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevenueColumnAmt")]
//     public string TotalRevenueColumnAmt { get; set; }
//
//     [JsonProperty("RelatedOrExemptFuncIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFuncIncomeAmt")]
//     public string RelatedOrExemptFuncIncomeAmt { get; set; }
//
//     [JsonProperty("UnrelatedBusinessRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessRevenueAmt")]
//     public string UnrelatedBusinessRevenueAmt { get; set; }
//
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
// }
//
// public class IncreasingResearchCrGrp
// {
//     [JsonProperty("ResearchActivitiesIncrCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ResearchActivitiesIncrCrAmt")]
//     public string ResearchActivitiesIncrCrAmt { get; set; }
//
//     [JsonProperty("PassThroughEntityEIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PassThroughEntityEIN")]
//     public string PassThroughEntityEIN { get; set; }
// }
//
// public class IndependentAuditFinclStmtInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class InformationTechnologyGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class InsuranceGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class IntangibleAssetsGrp
// {
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
//
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
// }
//
// public class InterestDeductionAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class InterestGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class IntOnSavAndTempCashInvstGrp
// {
//     [JsonProperty("ExclusionCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionCd")]
//     public string ExclusionCd { get; set; }
//
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
//
//     [JsonProperty("RelatedOrExemptFunctionIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFunctionIncmAmt")]
//     public string RelatedOrExemptFunctionIncmAmt { get; set; }
// }
//
// public class InventoriesForSaleOrUseGrp
// {
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
//
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
// }
//
// public class InventorySaleGrp
// {
//     [JsonProperty("CategoryTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CategoryTxt")]
//     public string CategoryTxt { get; set; }
//
//     [JsonProperty("GrossSalesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossSalesAmt")]
//     public string GrossSalesAmt { get; set; }
//
//     [JsonProperty("CostOfGoodsSoldAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CostOfGoodsSoldAmt")]
//     public string CostOfGoodsSoldAmt { get; set; }
//
//     [JsonProperty("NetAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetAmt")]
//     public string NetAmt { get; set; }
// }
//
// public class InvestmentCreditGrp
// {
//     [JsonProperty("InvestmentCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentCreditAmt")]
//     public string InvestmentCreditAmt { get; set; }
// }
//
// public class InvestmentIncomeAndUBTIGrp
// {
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class InvestmentIncomeGrp
// {
//     [JsonProperty("TotalRevenueColumnAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevenueColumnAmt")]
//     public string TotalRevenueColumnAmt { get; set; }
//
//     [JsonProperty("UnrelatedBusinessRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessRevenueAmt")]
//     public string UnrelatedBusinessRevenueAmt { get; set; }
//
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
//
//     [JsonProperty("RelatedOrExemptFuncIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFuncIncomeAmt")]
//     public string RelatedOrExemptFuncIncomeAmt { get; set; }
// }
//
// public class InvestmentLandGrp
// {
//     [JsonProperty("CategoryOrItemTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CategoryOrItemTxt")]
//     public string CategoryOrItemTxt { get; set; }
//
//     [JsonProperty("CostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CostOrOtherBasisAmt")]
//     public string CostOrOtherBasisAmt { get; set; }
//
//     [JsonProperty("AccumulatedDepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AccumulatedDepreciationAmt")]
//     public string AccumulatedDepreciationAmt { get; set; }
//
//     [JsonProperty("BookValueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BookValueAmt")]
//     public string BookValueAmt { get; set; }
// }
//
// public class InvestmentsCorpBondsSchedule
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("InvestmentsCorporateBondsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentsCorporateBondsGrp")]
//     public List<InvestmentsCorporateBondsGrp> InvestmentsCorporateBondsGrp { get; } =
//         new List<InvestmentsCorporateBondsGrp>();
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class InvestmentsCorporateBondsGrp
// {
//     [JsonProperty("BondNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BondNm")]
//     public string BondNm { get; set; }
//
//     [JsonProperty("EOYBookValueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYBookValueAmt")]
//     public string EOYBookValueAmt { get; set; }
//
//     [JsonProperty("EOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYFMVAmt")]
//     public string EOYFMVAmt { get; set; }
// }
//
// public class InvestmentsCorporateStockGrp
// {
//     [JsonProperty("StockNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StockNm")]
//     public string StockNm { get; set; }
//
//     [JsonProperty("EOYBookValueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYBookValueAmt")]
//     public string EOYBookValueAmt { get; set; }
//
//     [JsonProperty("EOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYFMVAmt")]
//     public string EOYFMVAmt { get; set; }
// }
//
// public class InvestmentsCorpStockSchedule
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("InvestmentsCorporateStockGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentsCorporateStockGrp")]
//     public InvestmentsCorporateStockGrp InvestmentsCorporateStockGrp { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class InvestmentsGovtObligationsSch
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("USGovtObligationsBookVlEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USGovtObligationsBookVlEOYAmt")]
//     public string USGovtObligationsBookVlEOYAmt { get; set; }
//
//     [JsonProperty("USGovtObligationsEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USGovtObligationsEOYFMVAmt")]
//     public string USGovtObligationsEOYFMVAmt { get; set; }
//
//     [JsonProperty("StateLocalSecBookVlEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StateLocalSecBookVlEOYAmt")]
//     public string StateLocalSecBookVlEOYAmt { get; set; }
//
//     [JsonProperty("StateLocalSecEOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StateLocalSecEOYFMVAmt")]
//     public string StateLocalSecEOYFMVAmt { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class InvestmentsLandSchedule2
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("InvestmentLandGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentLandGrp")]
//     public List<InvestmentLandGrp> InvestmentLandGrp { get; } = new List<InvestmentLandGrp>();
// }
//
// public class InvestmentsOtherGrp
// {
//     [JsonProperty("CategoryOrItemTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CategoryOrItemTxt")]
//     public string CategoryOrItemTxt { get; set; }
//
//     [JsonProperty("ListedAtCostOrFMVCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ListedAtCostOrFMVCd")]
//     public string ListedAtCostOrFMVCd { get; set; }
//
//     [JsonProperty("BookValueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BookValueAmt")]
//     public string BookValueAmt { get; set; }
//
//     [JsonProperty("EOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYFMVAmt")]
//     public string EOYFMVAmt { get; set; }
// }
//
// public class InvestmentsOtherSchedule2
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("InvestmentsOtherGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentsOtherGrp")]
//     public List<InvestmentsOtherGrp> InvestmentsOtherGrp { get; } = new List<InvestmentsOtherGrp>();
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class InvestmentsOtherSecuritiesGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class InvestmentsProgramRelatedGrp
// {
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
//
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
// }
//
// public class InvestmentsPubTradedSecGrp
// {
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
//
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
// }
//
// public class InvstProgramRelatedOrgGrp
// {
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("BookValueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BookValueAmt")]
//     public string BookValueAmt { get; set; }
//
//     [JsonProperty("MethodValuationCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodValuationCd")]
//     public string MethodValuationCd { get; set; }
// }
//
// public class IRS1041ScheduleD
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("TotalSTCGL1099BNotReceivedGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalSTCGL1099BNotReceivedGrp")]
//     public TotalSTCGL1099BNotReceivedGrp TotalSTCGL1099BNotReceivedGrp { get; set; }
//
//     [JsonProperty("NetSTCapitalGainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetSTCapitalGainOrLossAmt")]
//     public string NetSTCapitalGainOrLossAmt { get; set; }
//
//     [JsonProperty("TotalLTCGL1099BNotReceivedGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalLTCGL1099BNotReceivedGrp")]
//     public TotalLTCGL1099BNotReceivedGrp TotalLTCGL1099BNotReceivedGrp { get; set; }
//
//     [JsonProperty("Form4797GainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form4797GainOrLossAmt")]
//     public string Form4797GainOrLossAmt { get; set; }
//
//     [JsonProperty("NetLTCapitalGainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetLTCapitalGainOrLossAmt")]
//     public string NetLTCapitalGainOrLossAmt { get; set; }
//
//     [JsonProperty("EstateOrTrustCapGainOrLossGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EstateOrTrustCapGainOrLossGrp")]
//     public EstateOrTrustCapGainOrLossGrp EstateOrTrustCapGainOrLossGrp { get; set; }
//
//     [JsonProperty("TotalCapitalGainOrLossGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCapitalGainOrLossGrp")]
//     public TotalCapitalGainOrLossGrp TotalCapitalGainOrLossGrp { get; set; }
//
//     [JsonProperty("DisposeInvestmentQOFInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisposeInvestmentQOFInd")]
//     public string DisposeInvestmentQOFInd { get; set; }
//
//     [JsonProperty("STGainOrLossFromFormsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("STGainOrLossFromFormsAmt")]
//     public string STGainOrLossFromFormsAmt { get; set; }
//
//     [JsonProperty("NetSTGainOrLossFromSchK1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetSTGainOrLossFromSchK1Amt")]
//     public string NetSTGainOrLossFromSchK1Amt { get; set; }
//
//     [JsonProperty("LTGainOrLossFromFormsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LTGainOrLossFromFormsAmt")]
//     public string LTGainOrLossFromFormsAmt { get; set; }
//
//     [JsonProperty("NetLTGainOrLossFromSchK1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetLTGainOrLossFromSchK1Amt")]
//     public string NetLTGainOrLossFromSchK1Amt { get; set; }
//
//     [JsonProperty("CapitalLossLimitationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CapitalLossLimitationAmt")]
//     public string CapitalLossLimitationAmt { get; set; }
//
//     [JsonProperty("TaxableIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxableIncomeAmt")]
//     public string TaxableIncomeAmt { get; set; }
//
//     [JsonProperty("SmallerGainAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SmallerGainAmt")]
//     public string SmallerGainAmt { get; set; }
//
//     [JsonProperty("QlfyDividendsEstateTrustAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("QlfyDividendsEstateTrustAmt")]
//     public string QlfyDividendsEstateTrustAmt { get; set; }
//
//     [JsonProperty("GainPlusDividendsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GainPlusDividendsAmt")]
//     public string GainPlusDividendsAmt { get; set; }
//
//     [JsonProperty("InvestmentIncomeElectionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentIncomeElectionAmt")]
//     public string InvestmentIncomeElectionAmt { get; set; }
//
//     [JsonProperty("GainLessIncludedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GainLessIncludedAmt")]
//     public string GainLessIncludedAmt { get; set; }
//
//     [JsonProperty("TaxableIncomeLessGainAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxableIncomeLessGainAmt")]
//     public string TaxableIncomeLessGainAmt { get; set; }
//
//     [JsonProperty("SmallerTaxableIncmOrAllowedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SmallerTaxableIncmOrAllowedAmt")]
//     public string SmallerTaxableIncmOrAllowedAmt { get; set; }
//
//     [JsonProperty("SmllrTxiLessGainOrTxiOrAllwAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SmllrTxiLessGainOrTxiOrAllwAmt")]
//     public string SmllrTxiLessGainOrTxiOrAllwAmt { get; set; }
//
//     [JsonProperty("DiffOfSmallerAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DiffOfSmallerAmt")]
//     public string DiffOfSmallerAmt { get; set; }
//
//     [JsonProperty("SmallerTaxableIncomeOrNetAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SmallerTaxableIncomeOrNetAmt")]
//     public string SmallerTaxableIncomeOrNetAmt { get; set; }
//
//     [JsonProperty("NetIncomeMinusSmallerAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetIncomeMinusSmallerAmt")]
//     public string NetIncomeMinusSmallerAmt { get; set; }
//
//     [JsonProperty("SmllrTxblIncmOrOthAllowedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SmllrTxblIncmOrOthAllowedAmt")]
//     public string SmllrTxblIncmOrOthAllowedAmt { get; set; }
//
//     [JsonProperty("TxiLessGainPlusDiffOfSmllAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TxiLessGainPlusDiffOfSmllAmt")]
//     public string TxiLessGainPlusDiffOfSmllAmt { get; set; }
//
//     [JsonProperty("SmllrTxiOrAllwLessSmllrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SmllrTxiOrAllwLessSmllrAmt")]
//     public string SmllrTxiOrAllwLessSmllrAmt { get; set; }
//
//     [JsonProperty("SmallerOfCalcAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SmallerOfCalcAmt")]
//     public string SmallerOfCalcAmt { get; set; }
//
//     [JsonProperty("SmallerTimesPercentAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SmallerTimesPercentAmt")]
//     public string SmallerTimesPercentAmt { get; set; }
//
//     [JsonProperty("DiffOfSmllrPlusSmllrOfCalcAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DiffOfSmllrPlusSmllrOfCalcAmt")]
//     public string DiffOfSmllrPlusSmllrOfCalcAmt { get; set; }
//
//     [JsonProperty("NetSmallerAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetSmallerAmt")]
//     public string NetSmallerAmt { get; set; }
//
//     [JsonProperty("NetTimesPercentAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetTimesPercentAmt")]
//     public string NetTimesPercentAmt { get; set; }
//
//     [JsonProperty("NetGainsTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetGainsTaxAmt")]
//     public string NetGainsTaxAmt { get; set; }
//
//     [JsonProperty("TaxPlusTimePercentAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxPlusTimePercentAmt")]
//     public string TaxPlusTimePercentAmt { get; set; }
//
//     [JsonProperty("TaxOnTaxableIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxOnTaxableIncomeAmt")]
//     public string TaxOnTaxableIncomeAmt { get; set; }
//
//     [JsonProperty("TaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxAmt")]
//     public string TaxAmt { get; set; }
//
//     [JsonProperty("CapitalGainDistributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CapitalGainDistributionsAmt")]
//     public string CapitalGainDistributionsAmt { get; set; }
// }
//
// public class IRS1041ScheduleI
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("AdjustedTotalIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedTotalIncomeAmt")]
//     public string AdjustedTotalIncomeAmt { get; set; }
//
//     [JsonProperty("InterestAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InterestAmt")]
//     public string InterestAmt { get; set; }
//
//     [JsonProperty("TaxesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxesAmt")]
//     public string TaxesAmt { get; set; }
//
//     [JsonProperty("TotalRefundReceivedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRefundReceivedAmt")]
//     public string TotalRefundReceivedAmt { get; set; }
//
//     [JsonProperty("DepletionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepletionAmt")]
//     public string DepletionAmt { get; set; }
//
//     [JsonProperty("NetOperatingLossDeductionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetOperatingLossDeductionAmt")]
//     public string NetOperatingLossDeductionAmt { get; set; }
//
//     [JsonProperty("PropertyDispositionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PropertyDispositionAmt")]
//     public string PropertyDispositionAmt { get; set; }
//
//     [JsonProperty("AltTaxNetOperatingLossDedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AltTaxNetOperatingLossDedAmt")]
//     public string AltTaxNetOperatingLossDedAmt { get; set; }
//
//     [JsonProperty("AdjAlternativeMinTaxableIncAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjAlternativeMinTaxableIncAmt")]
//     public string AdjAlternativeMinTaxableIncAmt { get; set; }
//
//     [JsonProperty("AlternativeMinTaxableIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AlternativeMinTaxableIncomeAmt")]
//     public string AlternativeMinTaxableIncomeAmt { get; set; }
//
//     [JsonProperty("DepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationAmt")]
//     public string DepreciationAmt { get; set; }
//
//     [JsonProperty("PassiveActivityAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PassiveActivityAmt")]
//     public string PassiveActivityAmt { get; set; }
//
//     [JsonProperty("IntangibleDrillingCostAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IntangibleDrillingCostAmt")]
//     public string IntangibleDrillingCostAmt { get; set; }
//
//     [JsonProperty("EstateOrTrustShrLessExemptAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EstateOrTrustShrLessExemptAmt")]
//     public string EstateOrTrustShrLessExemptAmt { get; set; }
//
//     [JsonProperty("MaximumCapitalGainsOrNetAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MaximumCapitalGainsOrNetAmt")]
//     public string MaximumCapitalGainsOrNetAmt { get; set; }
//
//     [JsonProperty("TentativeAlternativeMinTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TentativeAlternativeMinTaxAmt")]
//     public string TentativeAlternativeMinTaxAmt { get; set; }
//
//     [JsonProperty("AdjustedRegularTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedRegularTaxAmt")]
//     public string AdjustedRegularTaxAmt { get; set; }
//
//     [JsonProperty("AlternativeMinimumTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AlternativeMinimumTaxAmt")]
//     public string AlternativeMinimumTaxAmt { get; set; }
//
//     [JsonProperty("RelatedAdjustmentAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedAdjustmentAmt")]
//     public string RelatedAdjustmentAmt { get; set; }
//
//     [JsonProperty("NetShareAltMinTaxbleIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetShareAltMinTaxbleIncomeAmt")]
//     public string NetShareAltMinTaxbleIncomeAmt { get; set; }
//
//     [JsonProperty("NetShareAltMinTxblIncmXPctAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetShareAltMinTxblIncmXPctAmt")]
//     public string NetShareAltMinTxblIncmXPctAmt { get; set; }
//
//     [JsonProperty("NetExemptionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetExemptionAmt")]
//     public string NetExemptionAmt { get; set; }
// }
//
// public class IRS1120ScheduleD
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("DisposeInvestmentQOFInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisposeInvestmentQOFInd")]
//     public string DisposeInvestmentQOFInd { get; set; }
//
//     [JsonProperty("TotalSTCGL1099BNotReceivedGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalSTCGL1099BNotReceivedGrp")]
//     public TotalSTCGL1099BNotReceivedGrp TotalSTCGL1099BNotReceivedGrp { get; set; }
//
//     [JsonProperty("NetSTCapitalGainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetSTCapitalGainOrLossAmt")]
//     public string NetSTCapitalGainOrLossAmt { get; set; }
//
//     [JsonProperty("TotalLTCGL1099BNotReceivedGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalLTCGL1099BNotReceivedGrp")]
//     public TotalLTCGL1099BNotReceivedGrp TotalLTCGL1099BNotReceivedGrp { get; set; }
//
//     [JsonProperty("Form4797GainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form4797GainOrLossAmt")]
//     public string Form4797GainOrLossAmt { get; set; }
//
//     [JsonProperty("NetLTCapitalGainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetLTCapitalGainOrLossAmt")]
//     public string NetLTCapitalGainOrLossAmt { get; set; }
//
//     [JsonProperty("ExcNetSTGainOverNetLTLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcNetSTGainOverNetLTLossAmt")]
//     public string ExcNetSTGainOverNetLTLossAmt { get; set; }
//
//     [JsonProperty("NetCapitalGainAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCapitalGainAmt")]
//     public string NetCapitalGainAmt { get; set; }
//
//     [JsonProperty("CapitalGainNetIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CapitalGainNetIncomeAmt")]
//     public string CapitalGainNetIncomeAmt { get; set; }
//
//     [JsonProperty("TotalSTCGL1099BBssRptNoAdjGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalSTCGL1099BBssRptNoAdjGrp")]
//     public string TotalSTCGL1099BBssRptNoAdjGrp { get; set; }
//
//     [JsonProperty("TotalSTCGL1099BShowsBasisGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalSTCGL1099BShowsBasisGrp")]
//     public string TotalSTCGL1099BShowsBasisGrp { get; set; }
//
//     [JsonProperty("TotalSTCGL1099BNotShowBasisGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalSTCGL1099BNotShowBasisGrp")]
//     public string TotalSTCGL1099BNotShowBasisGrp { get; set; }
//
//     [JsonProperty("TotalLTCGL1099BBssRptNoAdjGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalLTCGL1099BBssRptNoAdjGrp")]
//     public string TotalLTCGL1099BBssRptNoAdjGrp { get; set; }
//
//     [JsonProperty("TotalLTCGL1099BShowsBasisGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalLTCGL1099BShowsBasisGrp")]
//     public string TotalLTCGL1099BShowsBasisGrp { get; set; }
//
//     [JsonProperty("TotalLTCGL1099BNotShowBasisGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalLTCGL1099BNotShowBasisGrp")]
//     public string TotalLTCGL1099BNotShowBasisGrp { get; set; }
//
//     [JsonProperty("UnusedCapitalLossCarryoverAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnusedCapitalLossCarryoverAmt")]
//     public string UnusedCapitalLossCarryoverAmt { get; set; }
//
//     [JsonProperty("CapitalGainDistributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CapitalGainDistributionsAmt")]
//     public string CapitalGainDistributionsAmt { get; set; }
// }
//
// public class IRS3800
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("RegularTaxBeforeCreditsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RegularTaxBeforeCreditsAmt")]
//     public string RegularTaxBeforeCreditsAmt { get; set; }
//
//     [JsonProperty("AlternativeMinimumTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AlternativeMinimumTaxAmt")]
//     public string AlternativeMinimumTaxAmt { get; set; }
//
//     [JsonProperty("AdjustedRegTaxBeforeCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedRegTaxBeforeCreditAmt")]
//     public string AdjustedRegTaxBeforeCreditAmt { get; set; }
//
//     [JsonProperty("NetIncomeTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetIncomeTaxAmt")]
//     public string NetIncomeTaxAmt { get; set; }
//
//     [JsonProperty("NetRegularTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetRegularTaxAmt")]
//     public string NetRegularTaxAmt { get; set; }
//
//     [JsonProperty("ExcessNetRegularTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessNetRegularTaxAmt")]
//     public string ExcessNetRegularTaxAmt { get; set; }
//
//     [JsonProperty("AdjustedExcessNetRegularTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedExcessNetRegularTaxAmt")]
//     public string AdjustedExcessNetRegularTaxAmt { get; set; }
//
//     [JsonProperty("AdjustedNetIncomeTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedNetIncomeTaxAmt")]
//     public string AdjustedNetIncomeTaxAmt { get; set; }
//
//     [JsonProperty("EmpwrZoneAndComEmploymentCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EmpwrZoneAndComEmploymentCrAmt")]
//     public string EmpwrZoneAndComEmploymentCrAmt { get; set; }
//
//     [JsonProperty("NetIncomeTaxLessPctExcessAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetIncomeTaxLessPctExcessAmt")]
//     public string NetIncomeTaxLessPctExcessAmt { get; set; }
//
//     [JsonProperty("NetSmllrAndEmpwrZnEmplmnCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetSmllrAndEmpwrZnEmplmnCrAmt")]
//     public string NetSmllrAndEmpwrZnEmplmnCrAmt { get; set; }
//
//     [JsonProperty("AllwGenBusCrFromNonPssvActyAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AllwGenBusCrFromNonPssvActyAmt")]
//     public string AllwGenBusCrFromNonPssvActyAmt { get; set; }
//
//     [JsonProperty("TotAllwGenAndEligSmllBusCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotAllwGenAndEligSmllBusCrAmt")]
//     public string TotAllwGenAndEligSmllBusCrAmt { get; set; }
//
//     [JsonProperty("SmllrGenBusCrOrTotGenEligCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SmllrGenBusCrOrTotGenEligCrAmt")]
//     public string SmllrGenBusCrOrTotGenEligCrAmt { get; set; }
//
//     [JsonProperty("CurrentYearCreditAllowedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearCreditAllowedAmt")]
//     public string CurrentYearCreditAllowedAmt { get; set; }
//
//     [JsonProperty("GenBusCrOrEligSmllBusCrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GenBusCrOrEligSmllBusCrGrp")]
//     public GenBusCrOrEligSmllBusCrGrp GenBusCrOrEligSmllBusCrGrp { get; set; }
//
//     [JsonProperty("GeneralBusCrFromNnPssvActyAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GeneralBusCrFromNnPssvActyAmt")]
//     public string GeneralBusCrFromNnPssvActyAmt { get; set; }
//
//     [JsonProperty("CYGeneralBusCrCarryforwardAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYGeneralBusCrCarryforwardAmt")]
//     public string CYGeneralBusCrCarryforwardAmt { get; set; }
//
//     [JsonProperty("CYCreditsNotAllwAgainstTMTAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYCreditsNotAllwAgainstTMTAmt")]
//     public string CYCreditsNotAllwAgainstTMTAmt { get; set; }
//
//     [JsonProperty("SmllrCYNotAllwTMTOrTotAdjAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SmllrCYNotAllwTMTOrTotAdjAmt")]
//     public string SmllrCYNotAllwTMTOrTotAdjAmt { get; set; }
//
//     [JsonProperty("SumSmllrEmpwrZnEmplmnCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SumSmllrEmpwrZnEmplmnCrAmt")]
//     public string SumSmllrEmpwrZnEmplmnCrAmt { get; set; }
//
//     [JsonProperty("AllwGenAndEligSmllBusCfwdCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AllwGenAndEligSmllBusCfwdCrAmt")]
//     public string AllwGenAndEligSmllBusCfwdCrAmt { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("CurrYearPassiveActyCreditsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrYearPassiveActyCreditsAmt")]
//     public string CurrYearPassiveActyCreditsAmt { get; set; }
//
//     [JsonProperty("CarryBackGeneralBusinessCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CarryBackGeneralBusinessCrAmt")]
//     public string CarryBackGeneralBusinessCrAmt { get; set; }
//
//     [JsonProperty("TotalTaxCreditsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalTaxCreditsAmt")]
//     public string TotalTaxCreditsAmt { get; set; }
//
//     [JsonProperty("TentativeMinimumTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TentativeMinimumTaxAmt")]
//     public string TentativeMinimumTaxAmt { get; set; }
//
//     [JsonProperty("TentativeMinimunTaxTimesPctAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TentativeMinimunTaxTimesPctAmt")]
//     public string TentativeMinimunTaxTimesPctAmt { get; set; }
//
//     [JsonProperty("GreaterExcessOrTimesPctAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GreaterExcessOrTimesPctAmt")]
//     public string GreaterExcessOrTimesPctAmt { get; set; }
//
//     [JsonProperty("NetIncmTaxLessGreaterExcessAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetIncmTaxLessGreaterExcessAmt")]
//     public string NetIncmTaxLessGreaterExcessAmt { get; set; }
//
//     [JsonProperty("SubSmllrFromNetLessGreaterAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubSmllrFromNetLessGreaterAmt")]
//     public string SubSmllrFromNetLessGreaterAmt { get; set; }
//
//     [JsonProperty("TotEmpwrZoneGenBusCreditsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotEmpwrZoneGenBusCreditsAmt")]
//     public string TotEmpwrZoneGenBusCreditsAmt { get; set; }
//
//     [JsonProperty("GBCFromPssvActyAllPartsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GBCFromPssvActyAllPartsAmt")]
//     public string GBCFromPssvActyAllPartsAmt { get; set; }
//
//     [JsonProperty("TotalPassiveActivityCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalPassiveActivityCreditAmt")]
//     public string TotalPassiveActivityCreditAmt { get; set; }
//
//     [JsonProperty("GenBusEligSmllBusPssvActyCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GenBusEligSmllBusPssvActyCrAmt")]
//     public string GenBusEligSmllBusPssvActyCrAmt { get; set; }
//
//     [JsonProperty("OtherSpecifiedAllwGenBusCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherSpecifiedAllwGenBusCrAmt")]
//     public string OtherSpecifiedAllwGenBusCrAmt { get; set; }
//
//     [JsonProperty("AllwGenAndEligSmllBusCybkCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AllwGenAndEligSmllBusCybkCrAmt")]
//     public string AllwGenAndEligSmllBusCybkCrAmt { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("PssvActyForGenBusCrAllowedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PssvActyForGenBusCrAllowedAmt")]
//     public string PssvActyForGenBusCrAllowedAmt { get; set; }
// }
//
// public class IRS4136
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("NontaxableUseOfGasolineCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontaxableUseOfGasolineCrAmt")]
//     public NontaxableUseOfGasolineCrAmt NontaxableUseOfGasolineCrAmt { get; set; }
//
//     [JsonProperty("ExportedNontxUseOfGasCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExportedNontxUseOfGasCrAmt")]
//     public ExportedNontxUseOfGasCrAmt ExportedNontxUseOfGasCrAmt { get; set; }
//
//     [JsonProperty("AviationGasolineCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AviationGasolineCreditAmt")]
//     public AviationGasolineCreditAmt AviationGasolineCreditAmt { get; set; }
//
//     [JsonProperty("AviationNontxGasCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AviationNontxGasCrAmt")]
//     public AviationNontxGasCrAmt AviationNontxGasCrAmt { get; set; }
//
//     [JsonProperty("ExpNontxAviationGasCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpNontxAviationGasCrAmt")]
//     public ExpNontxAviationGasCrAmt ExpNontxAviationGasCrAmt { get; set; }
//
//     [JsonProperty("LUSTTxAvnFuelFrgnTradeCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LUSTTxAvnFuelFrgnTradeCrAmt")]
//     public LUSTTxAvnFuelFrgnTradeCrAmt LUSTTxAvnFuelFrgnTradeCrAmt { get; set; }
//
//     [JsonProperty("NontaxableUseOfUndyedDiesel", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontaxableUseOfUndyedDiesel")]
//     public NontaxableUseOfUndyedDiesel NontaxableUseOfUndyedDiesel { get; set; }
//
//     [JsonProperty("FarmPrpsUndyedDslFuelCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FarmPrpsUndyedDslFuelCrAmt")]
//     public FarmPrpsUndyedDslFuelCrAmt FarmPrpsUndyedDslFuelCrAmt { get; set; }
//
//     [JsonProperty("TrainUseOfUndyedDieselCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TrainUseOfUndyedDieselCrAmt")]
//     public TrainUseOfUndyedDieselCrAmt TrainUseOfUndyedDieselCrAmt { get; set; }
//
//     [JsonProperty("BusUseOfUndyedDieselCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusUseOfUndyedDieselCreditAmt")]
//     public BusUseOfUndyedDieselCreditAmt BusUseOfUndyedDieselCreditAmt { get; set; }
//
//     [JsonProperty("ExpUndyedDieselFuelCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpUndyedDieselFuelCreditAmt")]
//     public ExpUndyedDieselFuelCreditAmt ExpUndyedDieselFuelCreditAmt { get; set; }
//
//     [JsonProperty("FarmPrpsUndyedKeroseneCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FarmPrpsUndyedKeroseneCrAmt")]
//     public FarmPrpsUndyedKeroseneCrAmt FarmPrpsUndyedKeroseneCrAmt { get; set; }
//
//     [JsonProperty("BusUseOfUndyedKeroseneCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusUseOfUndyedKeroseneCrAmt")]
//     public BusUseOfUndyedKeroseneCrAmt BusUseOfUndyedKeroseneCrAmt { get; set; }
//
//     [JsonProperty("ExportedUndyedKeroseneCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExportedUndyedKeroseneCrAmt")]
//     public ExportedUndyedKeroseneCrAmt ExportedUndyedKeroseneCrAmt { get; set; }
//
//     [JsonProperty("NontxUseUndyedKrsnTxd044CrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontxUseUndyedKrsnTxd044CrAmt")]
//     public NontxUseUndyedKrsnTxd044CrAmt NontxUseUndyedKrsnTxd044CrAmt { get; set; }
//
//     [JsonProperty("NontxUseUndyedKrsnTxd219CrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontxUseUndyedKrsnTxd219CrAmt")]
//     public NontxUseUndyedKrsnTxd219CrAmt NontxUseUndyedKrsnTxd219CrAmt { get; set; }
//
//     [JsonProperty("KeroseneUsedInAvnTxd244CrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("KeroseneUsedInAvnTxd244CrAmt")]
//     public KeroseneUsedInAvnTxd244CrAmt KeroseneUsedInAvnTxd244CrAmt { get; set; }
//
//     [JsonProperty("KeroseneUsedInAvnTxd219CrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("KeroseneUsedInAvnTxd219CrAmt")]
//     public KeroseneUsedInAvnTxd219CrAmt KeroseneUsedInAvnTxd219CrAmt { get; set; }
//
//     [JsonProperty("NonTxKrsnUsedInAvnTxd244CrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonTxKrsnUsedInAvnTxd244CrAmt")]
//     public NonTxKrsnUsedInAvnTxd244CrAmt NonTxKrsnUsedInAvnTxd244CrAmt { get; set; }
//
//     [JsonProperty("NonTxKrsnUsedInAvnTxd219CrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonTxKrsnUsedInAvnTxd219CrAmt")]
//     public NonTxKrsnUsedInAvnTxd219CrAmt NonTxKrsnUsedInAvnTxd219CrAmt { get; set; }
//
//     [JsonProperty("LUSTTxKrsnAvnFrgnTrdCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LUSTTxKrsnAvnFrgnTrdCrAmt")]
//     public LUSTTxKrsnAvnFrgnTrdCrAmt LUSTTxKrsnAvnFrgnTrdCrAmt { get; set; }
//
//     [JsonProperty("SlsUndyedDslUseStLclGovtCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SlsUndyedDslUseStLclGovtCrAmt")]
//     public SlsUndyedDslUseStLclGovtCrAmt SlsUndyedDslUseStLclGovtCrAmt { get; set; }
//
//     [JsonProperty("SlsUndyedDieselUseBusCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SlsUndyedDieselUseBusCrAmt")]
//     public SlsUndyedDieselUseBusCrAmt SlsUndyedDieselUseBusCrAmt { get; set; }
//
//     [JsonProperty("SlsUndyedKrsnBlockPumpCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SlsUndyedKrsnBlockPumpCrAmt")]
//     public SlsUndyedKrsnBlockPumpCrAmt SlsUndyedKrsnBlockPumpCrAmt { get; set; }
//
//     [JsonProperty("SlsUndyedKrsnUseBusCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SlsUndyedKrsnUseBusCrAmt")]
//     public SlsUndyedKrsnUseBusCrAmt SlsUndyedKrsnUseBusCrAmt { get; set; }
//
//     [JsonProperty("SlsKrsnUsedInAvnTxd219CrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SlsKrsnUsedInAvnTxd219CrAmt")]
//     public SlsKrsnUsedInAvnTxd219CrAmt SlsKrsnUsedInAvnTxd219CrAmt { get; set; }
//
//     [JsonProperty("SlsKrsnUsedInAvnTxd244CrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SlsKrsnUsedInAvnTxd244CrAmt")]
//     public SlsKrsnUsedInAvnTxd244CrAmt SlsKrsnUsedInAvnTxd244CrAmt { get; set; }
//
//     [JsonProperty("SlsKrsnNnxmptUseInAvnCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SlsKrsnNnxmptUseInAvnCrAmt")]
//     public SlsKrsnNnxmptUseInAvnCrAmt SlsKrsnNnxmptUseInAvnCrAmt { get; set; }
//
//     [JsonProperty("SlsKrsnOthNontxTxd244CrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SlsKrsnOthNontxTxd244CrAmt")]
//     public SlsKrsnOthNontxTxd244CrAmt SlsKrsnOthNontxTxd244CrAmt { get; set; }
//
//     [JsonProperty("SlsKrsnOthNontxTxd219CrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SlsKrsnOthNontxTxd219CrAmt")]
//     public SlsKrsnOthNontxTxd219CrAmt SlsKrsnOthNontxTxd219CrAmt { get; set; }
//
//     [JsonProperty("LUSTTxSlsKrsnAvnFrgnTrdCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LUSTTxSlsKrsnAvnFrgnTrdCrAmt")]
//     public LUSTTxSlsKrsnAvnFrgnTrdCrAmt LUSTTxSlsKrsnAvnFrgnTrdCrAmt { get; set; }
//
//     [JsonProperty("BiodieselMixtureCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BiodieselMixtureCreditAmt")]
//     public BiodieselMixtureCreditAmt BiodieselMixtureCreditAmt { get; set; }
//
//     [JsonProperty("AgriBiodieselMixtureCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AgriBiodieselMixtureCreditAmt")]
//     public AgriBiodieselMixtureCreditAmt AgriBiodieselMixtureCreditAmt { get; set; }
//
//     [JsonProperty("RenewableDieselMixtureCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RenewableDieselMixtureCrAmt")]
//     public RenewableDieselMixtureCrAmt RenewableDieselMixtureCrAmt { get; set; }
//
//     [JsonProperty("NontxLiquifiedPetroleumGas", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontxLiquifiedPetroleumGas")]
//     public NontxLiquifiedPetroleumGas NontxLiquifiedPetroleumGas { get; set; }
//
//     [JsonProperty("NontxLiquefiedPtrlmGasCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontxLiquefiedPtrlmGasCrAmt")]
//     public NontxLiquefiedPtrlmGasCrAmt NontxLiquefiedPtrlmGasCrAmt { get; set; }
//
//     [JsonProperty("NontxPSeriesFuelsCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontxPSeriesFuelsCreditAmt")]
//     public NontxPSeriesFuelsCreditAmt NontxPSeriesFuelsCreditAmt { get; set; }
//
//     [JsonProperty("NontxCompressedNaturalGasCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontxCompressedNaturalGasCrAmt")]
//     public NontxCompressedNaturalGasCrAmt NontxCompressedNaturalGasCrAmt { get; set; }
//
//     [JsonProperty("NontxLiquefiedHydrogenCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontxLiquefiedHydrogenCrAmt")]
//     public NontxLiquefiedHydrogenCrAmt NontxLiquefiedHydrogenCrAmt { get; set; }
//
//     [JsonProperty("NontxLiqfdFuelDerFromCoalCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontxLiqfdFuelDerFromCoalCrAmt")]
//     public NontxLiqfdFuelDerFromCoalCrAmt NontxLiqfdFuelDerFromCoalCrAmt { get; set; }
//
//     [JsonProperty("NontxLiqFuelDerBiomassCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontxLiqFuelDerBiomassCrAmt")]
//     public NontxLiqFuelDerBiomassCrAmt NontxLiqFuelDerBiomassCrAmt { get; set; }
//
//     [JsonProperty("NontxLiquefiedNaturalGasCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontxLiquefiedNaturalGasCrAmt")]
//     public NontxLiquefiedNaturalGasCrAmt NontxLiquefiedNaturalGasCrAmt { get; set; }
//
//     [JsonProperty("NontxLiquefiedGasBiomassCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontxLiquefiedGasBiomassCrAmt")]
//     public NontxLiquefiedGasBiomassCrAmt NontxLiquefiedGasBiomassCrAmt { get; set; }
//
//     [JsonProperty("LiquefiedPetroleumGasCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LiquefiedPetroleumGasCrAmt")]
//     public LiquefiedPetroleumGasCrAmt LiquefiedPetroleumGasCrAmt { get; set; }
//
//     [JsonProperty("PSeriesFuelsCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PSeriesFuelsCreditAmt")]
//     public PSeriesFuelsCreditAmt PSeriesFuelsCreditAmt { get; set; }
//
//     [JsonProperty("CompressedNaturalGasCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompressedNaturalGasCreditAmt")]
//     public CompressedNaturalGasCreditAmt CompressedNaturalGasCreditAmt { get; set; }
//
//     [JsonProperty("LiquefiedHydrogenCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LiquefiedHydrogenCreditAmt")]
//     public LiquefiedHydrogenCreditAmt LiquefiedHydrogenCreditAmt { get; set; }
//
//     [JsonProperty("LiquidFuelDerFromCoalCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LiquidFuelDerFromCoalCreditAmt")]
//     public LiquidFuelDerFromCoalCreditAmt LiquidFuelDerFromCoalCreditAmt { get; set; }
//
//     [JsonProperty("LiquidFuelDerBiomassCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LiquidFuelDerBiomassCrAmt")]
//     public LiquidFuelDerBiomassCrAmt LiquidFuelDerBiomassCrAmt { get; set; }
//
//     [JsonProperty("LiquefiedNaturalGasCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LiquefiedNaturalGasCreditAmt")]
//     public LiquefiedNaturalGasCreditAmt LiquefiedNaturalGasCreditAmt { get; set; }
//
//     [JsonProperty("LiquefiedGasDerBiomassCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LiquefiedGasDerBiomassCrAmt")]
//     public LiquefiedGasDerBiomassCrAmt LiquefiedGasDerBiomassCrAmt { get; set; }
//
//     [JsonProperty("CompressedGasBiomassCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompressedGasBiomassCreditAmt")]
//     public CompressedGasBiomassCreditAmt CompressedGasBiomassCreditAmt { get; set; }
//
//     [JsonProperty("DslFuelSoldStLocalGovtCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DslFuelSoldStLocalGovtCrAmt")]
//     public DslFuelSoldStLocalGovtCrAmt DslFuelSoldStLocalGovtCrAmt { get; set; }
//
//     [JsonProperty("KrsnFuelSoldStLocalGovtCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("KrsnFuelSoldStLocalGovtCrAmt")]
//     public KrsnFuelSoldStLocalGovtCrAmt KrsnFuelSoldStLocalGovtCrAmt { get; set; }
//
//     [JsonProperty("KrsnAvnSoldStLocalGovtCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("KrsnAvnSoldStLocalGovtCrAmt")]
//     public KrsnAvnSoldStLocalGovtCrAmt KrsnAvnSoldStLocalGovtCrAmt { get; set; }
//
//     [JsonProperty("NontxUseDieselWtrEmulsionCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontxUseDieselWtrEmulsionCrAmt")]
//     public NontxUseDieselWtrEmulsionCrAmt NontxUseDieselWtrEmulsionCrAmt { get; set; }
//
//     [JsonProperty("ExpNontxUseDslWtrEmulsionCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpNontxUseDslWtrEmulsionCrAmt")]
//     public ExpNontxUseDslWtrEmulsionCrAmt ExpNontxUseDslWtrEmulsionCrAmt { get; set; }
//
//     [JsonProperty("BlndrCrUseDslWtrEmulsionCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BlndrCrUseDslWtrEmulsionCrAmt")]
//     public BlndrCrUseDslWtrEmulsionCrAmt BlndrCrUseDslWtrEmulsionCrAmt { get; set; }
//
//     [JsonProperty("ExportedDyedDieselFuelCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExportedDyedDieselFuelCrAmt")]
//     public ExportedDyedDieselFuelCrAmt ExportedDyedDieselFuelCrAmt { get; set; }
//
//     [JsonProperty("ExportedDyedKeroseneCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExportedDyedKeroseneCreditAmt")]
//     public ExportedDyedKeroseneCreditAmt ExportedDyedKeroseneCreditAmt { get; set; }
//
//     [JsonProperty("TotalFuelTaxCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalFuelTaxCreditAmt")]
//     public string TotalFuelTaxCreditAmt { get; set; }
// }
//
// public class IRS4562
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("BusinessOrActivityTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessOrActivityTxt")]
//     public string BusinessOrActivityTxt { get; set; }
//
//     [JsonProperty("MaximumDollarLimitationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MaximumDollarLimitationAmt")]
//     public string MaximumDollarLimitationAmt { get; set; }
//
//     [JsonProperty("ThresholdCostOfSect179PropAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ThresholdCostOfSect179PropAmt")]
//     public string ThresholdCostOfSect179PropAmt { get; set; }
//
//     [JsonProperty("MACRSDedForAstInSrvcBfrPYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MACRSDedForAstInSrvcBfrPYAmt")]
//     public string MACRSDedForAstInSrvcBfrPYAmt { get; set; }
//
//     [JsonProperty("TotalDepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalDepreciationAmt")]
//     public string TotalDepreciationAmt { get; set; }
//
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("OtherDepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherDepreciationAmt")]
//     public string OtherDepreciationAmt { get; set; }
//
//     [JsonProperty("GeneralDepreciationSystem", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GeneralDepreciationSystem")]
//     public GeneralDepreciationSystem GeneralDepreciationSystem { get; set; }
//
//     [JsonProperty("EvidenceToSupportDeductionInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EvidenceToSupportDeductionInd")]
//     public string EvidenceToSupportDeductionInd { get; set; }
//
//     [JsonProperty("EvidenceWrittenInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EvidenceWrittenInd")]
//     public string EvidenceWrittenInd { get; set; }
//
//     [JsonProperty("MoreThanHalfBusinessUseProp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MoreThanHalfBusinessUseProp")]
//     public MoreThanHalfBusinessUseProp MoreThanHalfBusinessUseProp { get; set; }
//
//     [JsonProperty("TotalListedDepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalListedDepreciationAmt")]
//     public string TotalListedDepreciationAmt { get; set; }
//
//     [JsonProperty("PolicyNoPrsnlOrCmmtngUseInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PolicyNoPrsnlOrCmmtngUseInd")]
//     public string PolicyNoPrsnlOrCmmtngUseInd { get; set; }
//
//     [JsonProperty("PolicyNoPrsnlExcCmmtngUseInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PolicyNoPrsnlExcCmmtngUseInd")]
//     public string PolicyNoPrsnlExcCmmtngUseInd { get; set; }
//
//     [JsonProperty("TreatAllVehUseAsPrsnlUseInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TreatAllVehUseAsPrsnlUseInd")]
//     public string TreatAllVehUseAsPrsnlUseInd { get; set; }
//
//     [JsonProperty("ProvideOverNumVehAndHaveRecInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProvideOverNumVehAndHaveRecInd")]
//     public string ProvideOverNumVehAndHaveRecInd { get; set; }
//
//     [JsonProperty("MeetRqrForAutoDemoUseInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MeetRqrForAutoDemoUseInd")]
//     public string MeetRqrForAutoDemoUseInd { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("SpecialAllowanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SpecialAllowanceAmt")]
//     public string SpecialAllowanceAmt { get; set; }
// }
//
// public class IRS8801
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("SumMinTaxCreditLossAndDedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SumMinTaxCreditLossAndDedAmt")]
//     public string SumMinTaxCreditLossAndDedAmt { get; set; }
//
//     [JsonProperty("MinTaxCreditExemptionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MinTaxCreditExemptionAmt")]
//     public string MinTaxCreditExemptionAmt { get; set; }
//
//     [JsonProperty("MinTaxCreditPhaseOutAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MinTaxCreditPhaseOutAmt")]
//     public string MinTaxCreditPhaseOutAmt { get; set; }
//
//     [JsonProperty("NetMinTaxCrMinusPhaseOutAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetMinTaxCrMinusPhaseOutAmt")]
//     public string NetMinTaxCrMinusPhaseOutAmt { get; set; }
//
//     [JsonProperty("NetMinTaxMinusExemptionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetMinTaxMinusExemptionAmt")]
//     public string NetMinTaxMinusExemptionAmt { get; set; }
//
//     [JsonProperty("NetMinTaxLessLossAndDedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetMinTaxLessLossAndDedAmt")]
//     public string NetMinTaxLessLossAndDedAmt { get; set; }
//
//     [JsonProperty("NetMinTaxOnExclusionItemsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetMinTaxOnExclusionItemsAmt")]
//     public string NetMinTaxOnExclusionItemsAmt { get; set; }
//
//     [JsonProperty("PYAlternativeMinimumTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PYAlternativeMinimumTaxAmt")]
//     public string PYAlternativeMinimumTaxAmt { get; set; }
//
//     [JsonProperty("NetAlternativeMinimumTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetAlternativeMinimumTaxAmt")]
//     public string NetAlternativeMinimumTaxAmt { get; set; }
//
//     [JsonProperty("AMTCarryforwardPlusNegativeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AMTCarryforwardPlusNegativeAmt")]
//     public string AMTCarryforwardPlusNegativeAmt { get; set; }
//
//     [JsonProperty("CYTentativeMinimumTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYTentativeMinimumTaxAmt")]
//     public string CYTentativeMinimumTaxAmt { get; set; }
//
//     [JsonProperty("TentMinTaxMinusRegTaxLiabAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TentMinTaxMinusRegTaxLiabAmt")]
//     public string TentMinTaxMinusRegTaxLiabAmt { get; set; }
//
//     [JsonProperty("AMTCrCarryforwardToNextYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AMTCrCarryforwardToNextYearAmt")]
//     public string AMTCrCarryforwardToNextYearAmt { get; set; }
//
//     [JsonProperty("AMTPriorYearCarryforwardAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AMTPriorYearCarryforwardAmt")]
//     public string AMTPriorYearCarryforwardAmt { get; set; }
// }
//
// public class IRS8949
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("ShortTermCapitalGainAndLossGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ShortTermCapitalGainAndLossGrp")]
//     public ShortTermCapitalGainAndLossGrp ShortTermCapitalGainAndLossGrp { get; set; }
//
//     [JsonProperty("LongTermCapitalGainAndLossGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LongTermCapitalGainAndLossGrp")]
//     public LongTermCapitalGainAndLossGrp LongTermCapitalGainAndLossGrp { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
// }
//
// public class IRS990
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("PrincipalOfficerNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrincipalOfficerNm")]
//     public string PrincipalOfficerNm { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("GrossReceiptsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossReceiptsAmt")]
//     public string GrossReceiptsAmt { get; set; }
//
//     [JsonProperty("GroupReturnForAffiliatesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GroupReturnForAffiliatesInd")]
//     public string GroupReturnForAffiliatesInd { get; set; }
//
//     [JsonProperty("Organization501cInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization501cInd")]
//     public Organization501cInd Organization501cInd { get; set; }
//
//     [JsonProperty("WebsiteAddressTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("WebsiteAddressTxt")]
//     public string WebsiteAddressTxt { get; set; }
//
//     [JsonProperty("TypeOfOrganizationTrustInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TypeOfOrganizationTrustInd")]
//     public string TypeOfOrganizationTrustInd { get; set; }
//
//     [JsonProperty("FormationYr", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FormationYr")]
//     public string FormationYr { get; set; }
//
//     [JsonProperty("LegalDomicileStateCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LegalDomicileStateCd")]
//     public string LegalDomicileStateCd { get; set; }
//
//     [JsonProperty("ActivityOrMissionDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivityOrMissionDesc")]
//     public string ActivityOrMissionDesc { get; set; }
//
//     [JsonProperty("VotingMembersGoverningBodyCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("VotingMembersGoverningBodyCnt")]
//     public string VotingMembersGoverningBodyCnt { get; set; }
//
//     [JsonProperty("VotingMembersIndependentCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("VotingMembersIndependentCnt")]
//     public string VotingMembersIndependentCnt { get; set; }
//
//     [JsonProperty("TotalEmployeeCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalEmployeeCnt")]
//     public string TotalEmployeeCnt { get; set; }
//
//     [JsonProperty("TotalVolunteersCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalVolunteersCnt")]
//     public string TotalVolunteersCnt { get; set; }
//
//     [JsonProperty("TotalGrossUBIAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalGrossUBIAmt")]
//     public string TotalGrossUBIAmt { get; set; }
//
//     [JsonProperty("NetUnrelatedBusTxblIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetUnrelatedBusTxblIncmAmt")]
//     public string NetUnrelatedBusTxblIncmAmt { get; set; }
//
//     [JsonProperty("PYContributionsGrantsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PYContributionsGrantsAmt")]
//     public string PYContributionsGrantsAmt { get; set; }
//
//     [JsonProperty("CYContributionsGrantsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYContributionsGrantsAmt")]
//     public string CYContributionsGrantsAmt { get; set; }
//
//     [JsonProperty("PYProgramServiceRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PYProgramServiceRevenueAmt")]
//     public string PYProgramServiceRevenueAmt { get; set; }
//
//     [JsonProperty("CYProgramServiceRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYProgramServiceRevenueAmt")]
//     public string CYProgramServiceRevenueAmt { get; set; }
//
//     [JsonProperty("PYInvestmentIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PYInvestmentIncomeAmt")]
//     public string PYInvestmentIncomeAmt { get; set; }
//
//     [JsonProperty("CYInvestmentIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYInvestmentIncomeAmt")]
//     public string CYInvestmentIncomeAmt { get; set; }
//
//     [JsonProperty("PYOtherRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PYOtherRevenueAmt")]
//     public string PYOtherRevenueAmt { get; set; }
//
//     [JsonProperty("CYOtherRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYOtherRevenueAmt")]
//     public string CYOtherRevenueAmt { get; set; }
//
//     [JsonProperty("PYTotalRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PYTotalRevenueAmt")]
//     public string PYTotalRevenueAmt { get; set; }
//
//     [JsonProperty("CYTotalRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYTotalRevenueAmt")]
//     public string CYTotalRevenueAmt { get; set; }
//
//     [JsonProperty("PYGrantsAndSimilarPaidAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PYGrantsAndSimilarPaidAmt")]
//     public string PYGrantsAndSimilarPaidAmt { get; set; }
//
//     [JsonProperty("CYGrantsAndSimilarPaidAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYGrantsAndSimilarPaidAmt")]
//     public string CYGrantsAndSimilarPaidAmt { get; set; }
//
//     [JsonProperty("PYBenefitsPaidToMembersAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PYBenefitsPaidToMembersAmt")]
//     public string PYBenefitsPaidToMembersAmt { get; set; }
//
//     [JsonProperty("CYBenefitsPaidToMembersAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYBenefitsPaidToMembersAmt")]
//     public string CYBenefitsPaidToMembersAmt { get; set; }
//
//     [JsonProperty("PYSalariesCompEmpBnftPaidAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PYSalariesCompEmpBnftPaidAmt")]
//     public string PYSalariesCompEmpBnftPaidAmt { get; set; }
//
//     [JsonProperty("CYSalariesCompEmpBnftPaidAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYSalariesCompEmpBnftPaidAmt")]
//     public string CYSalariesCompEmpBnftPaidAmt { get; set; }
//
//     [JsonProperty("PYTotalProfFndrsngExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PYTotalProfFndrsngExpnsAmt")]
//     public string PYTotalProfFndrsngExpnsAmt { get; set; }
//
//     [JsonProperty("CYTotalProfFndrsngExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYTotalProfFndrsngExpnsAmt")]
//     public string CYTotalProfFndrsngExpnsAmt { get; set; }
//
//     [JsonProperty("CYTotalFundraisingExpenseAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYTotalFundraisingExpenseAmt")]
//     public string CYTotalFundraisingExpenseAmt { get; set; }
//
//     [JsonProperty("PYOtherExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PYOtherExpensesAmt")]
//     public string PYOtherExpensesAmt { get; set; }
//
//     [JsonProperty("CYOtherExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYOtherExpensesAmt")]
//     public string CYOtherExpensesAmt { get; set; }
//
//     [JsonProperty("PYTotalExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PYTotalExpensesAmt")]
//     public string PYTotalExpensesAmt { get; set; }
//
//     [JsonProperty("CYTotalExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYTotalExpensesAmt")]
//     public string CYTotalExpensesAmt { get; set; }
//
//     [JsonProperty("PYRevenuesLessExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PYRevenuesLessExpensesAmt")]
//     public string PYRevenuesLessExpensesAmt { get; set; }
//
//     [JsonProperty("CYRevenuesLessExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYRevenuesLessExpensesAmt")]
//     public string CYRevenuesLessExpensesAmt { get; set; }
//
//     [JsonProperty("TotalAssetsBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAssetsBOYAmt")]
//     public string TotalAssetsBOYAmt { get; set; }
//
//     [JsonProperty("TotalAssetsEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAssetsEOYAmt")]
//     public string TotalAssetsEOYAmt { get; set; }
//
//     [JsonProperty("TotalLiabilitiesBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalLiabilitiesBOYAmt")]
//     public string TotalLiabilitiesBOYAmt { get; set; }
//
//     [JsonProperty("TotalLiabilitiesEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalLiabilitiesEOYAmt")]
//     public string TotalLiabilitiesEOYAmt { get; set; }
//
//     [JsonProperty("NetAssetsOrFundBalancesBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetAssetsOrFundBalancesBOYAmt")]
//     public string NetAssetsOrFundBalancesBOYAmt { get; set; }
//
//     [JsonProperty("NetAssetsOrFundBalancesEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetAssetsOrFundBalancesEOYAmt")]
//     public string NetAssetsOrFundBalancesEOYAmt { get; set; }
//
//     [JsonProperty("MissionDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MissionDesc")]
//     public string MissionDesc { get; set; }
//
//     [JsonProperty("SignificantNewProgramSrvcInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SignificantNewProgramSrvcInd")]
//     public string SignificantNewProgramSrvcInd { get; set; }
//
//     [JsonProperty("SignificantChangeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SignificantChangeInd")]
//     public string SignificantChangeInd { get; set; }
//
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("DescribedInSection501c3Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DescribedInSection501c3Ind")]
//     public string DescribedInSection501c3Ind { get; set; }
//
//     [JsonProperty("ScheduleBRequiredInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ScheduleBRequiredInd")]
//     public string ScheduleBRequiredInd { get; set; }
//
//     [JsonProperty("PoliticalCampaignActyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PoliticalCampaignActyInd")]
//     public string PoliticalCampaignActyInd { get; set; }
//
//     [JsonProperty("SubjectToProxyTaxInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubjectToProxyTaxInd")]
//     public string SubjectToProxyTaxInd { get; set; }
//
//     [JsonProperty("DonorAdvisedFundInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DonorAdvisedFundInd")]
//     public DonorAdvisedFundInd DonorAdvisedFundInd { get; set; }
//
//     [JsonProperty("ConservationEasementsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ConservationEasementsInd")]
//     public ConservationEasementsInd ConservationEasementsInd { get; set; }
//
//     [JsonProperty("CollectionsOfArtInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CollectionsOfArtInd")]
//     public CollectionsOfArtInd CollectionsOfArtInd { get; set; }
//
//     [JsonProperty("CreditCounselingInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CreditCounselingInd")]
//     public CreditCounselingInd CreditCounselingInd { get; set; }
//
//     [JsonProperty("DonorRstrOrQuasiEndowmentsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DonorRstrOrQuasiEndowmentsInd")]
//     public DonorRstrOrQuasiEndowmentsInd DonorRstrOrQuasiEndowmentsInd { get; set; }
//
//     [JsonProperty("ReportLandBuildingEquipmentInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReportLandBuildingEquipmentInd")]
//     public ReportLandBuildingEquipmentInd ReportLandBuildingEquipmentInd { get; set; }
//
//     [JsonProperty("ReportInvestmentsOtherSecInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReportInvestmentsOtherSecInd")]
//     public ReportInvestmentsOtherSecInd ReportInvestmentsOtherSecInd { get; set; }
//
//     [JsonProperty("ReportProgramRelatedInvstInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReportProgramRelatedInvstInd")]
//     public ReportProgramRelatedInvstInd ReportProgramRelatedInvstInd { get; set; }
//
//     [JsonProperty("ReportOtherAssetsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReportOtherAssetsInd")]
//     public ReportOtherAssetsInd ReportOtherAssetsInd { get; set; }
//
//     [JsonProperty("ReportOtherLiabilitiesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReportOtherLiabilitiesInd")]
//     public ReportOtherLiabilitiesInd ReportOtherLiabilitiesInd { get; set; }
//
//     [JsonProperty("IncludeFIN48FootnoteInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IncludeFIN48FootnoteInd")]
//     public IncludeFIN48FootnoteInd IncludeFIN48FootnoteInd { get; set; }
//
//     [JsonProperty("IndependentAuditFinclStmtInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IndependentAuditFinclStmtInd")]
//     public IndependentAuditFinclStmtInd IndependentAuditFinclStmtInd { get; set; }
//
//     [JsonProperty("ConsolidatedAuditFinclStmtInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ConsolidatedAuditFinclStmtInd")]
//     public ConsolidatedAuditFinclStmtInd ConsolidatedAuditFinclStmtInd { get; set; }
//
//     [JsonProperty("SchoolOperatingInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SchoolOperatingInd")]
//     public string SchoolOperatingInd { get; set; }
//
//     [JsonProperty("ForeignOfficeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignOfficeInd")]
//     public string ForeignOfficeInd { get; set; }
//
//     [JsonProperty("ForeignActivitiesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignActivitiesInd")]
//     public string ForeignActivitiesInd { get; set; }
//
//     [JsonProperty("MoreThan5000KToOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MoreThan5000KToOrgInd")]
//     public string MoreThan5000KToOrgInd { get; set; }
//
//     [JsonProperty("MoreThan5000KToIndividualsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MoreThan5000KToIndividualsInd")]
//     public string MoreThan5000KToIndividualsInd { get; set; }
//
//     [JsonProperty("ProfessionalFundraisingInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProfessionalFundraisingInd")]
//     public ProfessionalFundraisingInd ProfessionalFundraisingInd { get; set; }
//
//     [JsonProperty("FundraisingActivitiesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingActivitiesInd")]
//     public FundraisingActivitiesInd FundraisingActivitiesInd { get; set; }
//
//     [JsonProperty("GamingActivitiesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GamingActivitiesInd")]
//     public GamingActivitiesInd GamingActivitiesInd { get; set; }
//
//     [JsonProperty("OperateHospitalInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OperateHospitalInd")]
//     public string OperateHospitalInd { get; set; }
//
//     [JsonProperty("GrantsToOrganizationsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsToOrganizationsInd")]
//     public string GrantsToOrganizationsInd { get; set; }
//
//     [JsonProperty("GrantsToIndividualsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsToIndividualsInd")]
//     public string GrantsToIndividualsInd { get; set; }
//
//     [JsonProperty("ScheduleJRequiredInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ScheduleJRequiredInd")]
//     public string ScheduleJRequiredInd { get; set; }
//
//     [JsonProperty("TaxExemptBondsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxExemptBondsInd")]
//     public string TaxExemptBondsInd { get; set; }
//
//     [JsonProperty("LoanOutstandingInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoanOutstandingInd")]
//     public string LoanOutstandingInd { get; set; }
//
//     [JsonProperty("GrantToRelatedPersonInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantToRelatedPersonInd")]
//     public string GrantToRelatedPersonInd { get; set; }
//
//     [JsonProperty("BusinessRlnWithOrgMemInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessRlnWithOrgMemInd")]
//     public string BusinessRlnWithOrgMemInd { get; set; }
//
//     [JsonProperty("BusinessRlnWithFamMemInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessRlnWithFamMemInd")]
//     public string BusinessRlnWithFamMemInd { get; set; }
//
//     [JsonProperty("BusinessRlnWith35CtrlEntInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessRlnWith35CtrlEntInd")]
//     public string BusinessRlnWith35CtrlEntInd { get; set; }
//
//     [JsonProperty("DeductibleNonCashContriInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DeductibleNonCashContriInd")]
//     public string DeductibleNonCashContriInd { get; set; }
//
//     [JsonProperty("DeductibleArtContributionInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DeductibleArtContributionInd")]
//     public string DeductibleArtContributionInd { get; set; }
//
//     [JsonProperty("TerminateOperationsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TerminateOperationsInd")]
//     public string TerminateOperationsInd { get; set; }
//
//     [JsonProperty("PartialLiquidationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PartialLiquidationInd")]
//     public string PartialLiquidationInd { get; set; }
//
//     [JsonProperty("DisregardedEntityInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisregardedEntityInd")]
//     public string DisregardedEntityInd { get; set; }
//
//     [JsonProperty("RelatedEntityInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedEntityInd")]
//     public string RelatedEntityInd { get; set; }
//
//     [JsonProperty("RelatedOrganizationCtrlEntInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrganizationCtrlEntInd")]
//     public string RelatedOrganizationCtrlEntInd { get; set; }
//
//     [JsonProperty("ActivitiesConductedPrtshpInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesConductedPrtshpInd")]
//     public string ActivitiesConductedPrtshpInd { get; set; }
//
//     [JsonProperty("ScheduleORequiredInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ScheduleORequiredInd")]
//     public string ScheduleORequiredInd { get; set; }
//
//     [JsonProperty("IRPDocumentCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRPDocumentCnt")]
//     public string IRPDocumentCnt { get; set; }
//
//     [JsonProperty("IRPDocumentW2GCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRPDocumentW2GCnt")]
//     public string IRPDocumentW2GCnt { get; set; }
//
//     [JsonProperty("BackupWthldComplianceInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BackupWthldComplianceInd")]
//     public string BackupWthldComplianceInd { get; set; }
//
//     [JsonProperty("EmployeeCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EmployeeCnt")]
//     public string EmployeeCnt { get; set; }
//
//     [JsonProperty("UnrelatedBusIncmOverLimitInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusIncmOverLimitInd")]
//     public string UnrelatedBusIncmOverLimitInd { get; set; }
//
//     [JsonProperty("ForeignFinancialAccountInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignFinancialAccountInd")]
//     public string ForeignFinancialAccountInd { get; set; }
//
//     [JsonProperty("ProhibitedTaxShelterTransInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProhibitedTaxShelterTransInd")]
//     public string ProhibitedTaxShelterTransInd { get; set; }
//
//     [JsonProperty("TaxablePartyNotificationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxablePartyNotificationInd")]
//     public string TaxablePartyNotificationInd { get; set; }
//
//     [JsonProperty("NondeductibleContributionsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NondeductibleContributionsInd")]
//     public string NondeductibleContributionsInd { get; set; }
//
//     [JsonProperty("IndoorTanningServicesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IndoorTanningServicesInd")]
//     public string IndoorTanningServicesInd { get; set; }
//
//     [JsonProperty("SubjToTaxRmnrtnExPrchtPymtInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubjToTaxRmnrtnExPrchtPymtInd")]
//     public string SubjToTaxRmnrtnExPrchtPymtInd { get; set; }
//
//     [JsonProperty("SubjectToExcsTaxNetInvstIncInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubjectToExcsTaxNetInvstIncInd")]
//     public string SubjectToExcsTaxNetInvstIncInd { get; set; }
//
//     [JsonProperty("InfoInScheduleOPartVIInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InfoInScheduleOPartVIInd")]
//     public string InfoInScheduleOPartVIInd { get; set; }
//
//     [JsonProperty("GoverningBodyVotingMembersCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GoverningBodyVotingMembersCnt")]
//     public string GoverningBodyVotingMembersCnt { get; set; }
//
//     [JsonProperty("IndependentVotingMemberCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IndependentVotingMemberCnt")]
//     public string IndependentVotingMemberCnt { get; set; }
//
//     [JsonProperty("FamilyOrBusinessRlnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FamilyOrBusinessRlnInd")]
//     public string FamilyOrBusinessRlnInd { get; set; }
//
//     [JsonProperty("DelegationOfMgmtDutiesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DelegationOfMgmtDutiesInd")]
//     public string DelegationOfMgmtDutiesInd { get; set; }
//
//     [JsonProperty("ChangeToOrgDocumentsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ChangeToOrgDocumentsInd")]
//     public string ChangeToOrgDocumentsInd { get; set; }
//
//     [JsonProperty("MaterialDiversionOrMisuseInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MaterialDiversionOrMisuseInd")]
//     public string MaterialDiversionOrMisuseInd { get; set; }
//
//     [JsonProperty("MembersOrStockholdersInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MembersOrStockholdersInd")]
//     public string MembersOrStockholdersInd { get; set; }
//
//     [JsonProperty("ElectionOfBoardMembersInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ElectionOfBoardMembersInd")]
//     public string ElectionOfBoardMembersInd { get; set; }
//
//     [JsonProperty("DecisionsSubjectToApprovaInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DecisionsSubjectToApprovaInd")]
//     public string DecisionsSubjectToApprovaInd { get; set; }
//
//     [JsonProperty("MinutesOfGoverningBodyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MinutesOfGoverningBodyInd")]
//     public string MinutesOfGoverningBodyInd { get; set; }
//
//     [JsonProperty("MinutesOfCommitteesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MinutesOfCommitteesInd")]
//     public string MinutesOfCommitteesInd { get; set; }
//
//     [JsonProperty("OfficerMailingAddressInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OfficerMailingAddressInd")]
//     public string OfficerMailingAddressInd { get; set; }
//
//     [JsonProperty("LocalChaptersInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LocalChaptersInd")]
//     public string LocalChaptersInd { get; set; }
//
//     [JsonProperty("Form990ProvidedToGvrnBodyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form990ProvidedToGvrnBodyInd")]
//     public string Form990ProvidedToGvrnBodyInd { get; set; }
//
//     [JsonProperty("ConflictOfInterestPolicyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ConflictOfInterestPolicyInd")]
//     public string ConflictOfInterestPolicyInd { get; set; }
//
//     [JsonProperty("WhistleblowerPolicyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("WhistleblowerPolicyInd")]
//     public string WhistleblowerPolicyInd { get; set; }
//
//     [JsonProperty("DocumentRetentionPolicyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DocumentRetentionPolicyInd")]
//     public string DocumentRetentionPolicyInd { get; set; }
//
//     [JsonProperty("CompensationProcessCEOInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompensationProcessCEOInd")]
//     public string CompensationProcessCEOInd { get; set; }
//
//     [JsonProperty("CompensationProcessOtherInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompensationProcessOtherInd")]
//     public string CompensationProcessOtherInd { get; set; }
//
//     [JsonProperty("InvestmentInJointVentureInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentInJointVentureInd")]
//     public string InvestmentInJointVentureInd { get; set; }
//
//     [JsonProperty("UponRequestInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UponRequestInd")]
//     public string UponRequestInd { get; set; }
//
//     [JsonProperty("BooksInCareOfDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BooksInCareOfDetail")]
//     public BooksInCareOfDetail BooksInCareOfDetail { get; set; }
//
//     [JsonProperty("NoListedPersonsCompensatedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NoListedPersonsCompensatedInd")]
//     public string NoListedPersonsCompensatedInd { get; set; }
//
//     [JsonProperty("Form990PartVIISectionAGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form990PartVIISectionAGrp")]
//     public List<Form990PartVIISectionAGrp> Form990PartVIISectionAGrp { get; } = new List<Form990PartVIISectionAGrp>();
//
//     [JsonProperty("TotalReportableCompFromOrgAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalReportableCompFromOrgAmt")]
//     public string TotalReportableCompFromOrgAmt { get; set; }
//
//     [JsonProperty("TotReportableCompRltdOrgAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotReportableCompRltdOrgAmt")]
//     public string TotReportableCompRltdOrgAmt { get; set; }
//
//     [JsonProperty("TotalOtherCompensationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalOtherCompensationAmt")]
//     public string TotalOtherCompensationAmt { get; set; }
//
//     [JsonProperty("IndivRcvdGreaterThan100KCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IndivRcvdGreaterThan100KCnt")]
//     public string IndivRcvdGreaterThan100KCnt { get; set; }
//
//     [JsonProperty("FormerOfcrEmployeesListedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FormerOfcrEmployeesListedInd")]
//     public string FormerOfcrEmployeesListedInd { get; set; }
//
//     [JsonProperty("TotalCompGreaterThan150KInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCompGreaterThan150KInd")]
//     public string TotalCompGreaterThan150KInd { get; set; }
//
//     [JsonProperty("CompensationFromOtherSrcsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompensationFromOtherSrcsInd")]
//     public string CompensationFromOtherSrcsInd { get; set; }
//
//     [JsonProperty("CntrctRcvdGreaterThan100KCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CntrctRcvdGreaterThan100KCnt")]
//     public string CntrctRcvdGreaterThan100KCnt { get; set; }
//
//     [JsonProperty("ProgramServiceRevenueGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServiceRevenueGrp")]
//     public List<ProgramServiceRevenueGrp> ProgramServiceRevenueGrp { get; } = new List<ProgramServiceRevenueGrp>();
//
//     [JsonProperty("TotalProgramServiceRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalProgramServiceRevenueAmt")]
//     public string TotalProgramServiceRevenueAmt { get; set; }
//
//     [JsonProperty("InvestmentIncomeGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentIncomeGrp")]
//     public InvestmentIncomeGrp InvestmentIncomeGrp { get; set; }
//
//     [JsonProperty("TotalRevenueGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevenueGrp")]
//     public TotalRevenueGrp TotalRevenueGrp { get; set; }
//
//     [JsonProperty("BenefitsToMembersGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BenefitsToMembersGrp")]
//     public BenefitsToMembersGrp BenefitsToMembersGrp { get; set; }
//
//     [JsonProperty("FeesForSrvcInvstMgmntFeesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FeesForSrvcInvstMgmntFeesGrp")]
//     public FeesForSrvcInvstMgmntFeesGrp FeesForSrvcInvstMgmntFeesGrp { get; set; }
//
//     [JsonProperty("TotalFunctionalExpensesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalFunctionalExpensesGrp")]
//     public TotalFunctionalExpensesGrp TotalFunctionalExpensesGrp { get; set; }
//
//     [JsonProperty("SavingsAndTempCashInvstGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SavingsAndTempCashInvstGrp")]
//     public SavingsAndTempCashInvstGrp SavingsAndTempCashInvstGrp { get; set; }
//
//     [JsonProperty("InvestmentsOtherSecuritiesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentsOtherSecuritiesGrp")]
//     public InvestmentsOtherSecuritiesGrp InvestmentsOtherSecuritiesGrp { get; set; }
//
//     [JsonProperty("TotalAssetsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAssetsGrp")]
//     public TotalAssetsGrp TotalAssetsGrp { get; set; }
//
//     [JsonProperty("AccountsPayableAccrExpnssGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AccountsPayableAccrExpnssGrp")]
//     public AccountsPayableAccrExpnssGrp AccountsPayableAccrExpnssGrp { get; set; }
//
//     [JsonProperty("OtherLiabilitiesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherLiabilitiesGrp")]
//     public OtherLiabilitiesGrp OtherLiabilitiesGrp { get; set; }
//
//     [JsonProperty("TotalLiabilitiesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalLiabilitiesGrp")]
//     public TotalLiabilitiesGrp TotalLiabilitiesGrp { get; set; }
//
//     [JsonProperty("OrganizationFollowsFASB117Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrganizationFollowsFASB117Ind")]
//     public string OrganizationFollowsFASB117Ind { get; set; }
//
//     [JsonProperty("DonorRestrictionNetAssetsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DonorRestrictionNetAssetsGrp")]
//     public DonorRestrictionNetAssetsGrp DonorRestrictionNetAssetsGrp { get; set; }
//
//     [JsonProperty("TotalNetAssetsFundBalanceGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalNetAssetsFundBalanceGrp")]
//     public TotalNetAssetsFundBalanceGrp TotalNetAssetsFundBalanceGrp { get; set; }
//
//     [JsonProperty("TotLiabNetAssetsFundBalanceGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotLiabNetAssetsFundBalanceGrp")]
//     public TotLiabNetAssetsFundBalanceGrp TotLiabNetAssetsFundBalanceGrp { get; set; }
//
//     [JsonProperty("ReconcilationRevenueExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReconcilationRevenueExpnssAmt")]
//     public string ReconcilationRevenueExpnssAmt { get; set; }
//
//     [JsonProperty("OtherChangesInNetAssetsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherChangesInNetAssetsAmt")]
//     public string OtherChangesInNetAssetsAmt { get; set; }
//
//     [JsonProperty("MethodOfAccountingAccrualInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfAccountingAccrualInd")]
//     public string MethodOfAccountingAccrualInd { get; set; }
//
//     [JsonProperty("AccountantCompileOrReviewInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AccountantCompileOrReviewInd")]
//     public string AccountantCompileOrReviewInd { get; set; }
//
//     [JsonProperty("FSAuditedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FSAuditedInd")]
//     public string FSAuditedInd { get; set; }
//
//     [JsonProperty("FSAuditedBasisGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FSAuditedBasisGrp")]
//     public FSAuditedBasisGrp FSAuditedBasisGrp { get; set; }
//
//     [JsonProperty("AuditCommitteeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AuditCommitteeInd")]
//     public string AuditCommitteeInd { get; set; }
//
//     [JsonProperty("FederalGrantAuditRequiredInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FederalGrantAuditRequiredInd")]
//     public string FederalGrantAuditRequiredInd { get; set; }
//
//     [JsonProperty("TypeOfOrganizationCorpInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TypeOfOrganizationCorpInd")]
//     public string TypeOfOrganizationCorpInd { get; set; }
//
//     [JsonProperty("ExpenseAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpenseAmt")]
//     public string ExpenseAmt { get; set; }
//
//     [JsonProperty("TotalProgramServiceExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalProgramServiceExpensesAmt")]
//     public string TotalProgramServiceExpensesAmt { get; set; }
//
//     [JsonProperty("TransactionWithControlEntInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransactionWithControlEntInd")]
//     public string TransactionWithControlEntInd { get; set; }
//
//     [JsonProperty("EmploymentTaxReturnsFiledInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EmploymentTaxReturnsFiledInd")]
//     public string EmploymentTaxReturnsFiledInd { get; set; }
//
//     [JsonProperty("Form990TFiledInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form990TFiledInd")]
//     public string Form990TFiledInd { get; set; }
//
//     [JsonProperty("QuidProQuoContributionsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("QuidProQuoContributionsInd")]
//     public string QuidProQuoContributionsInd { get; set; }
//
//     [JsonProperty("Form8282PropertyDisposedOfInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form8282PropertyDisposedOfInd")]
//     public string Form8282PropertyDisposedOfInd { get; set; }
//
//     [JsonProperty("RcvFndsToPayPrsnlBnftCntrctInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RcvFndsToPayPrsnlBnftCntrctInd")]
//     public string RcvFndsToPayPrsnlBnftCntrctInd { get; set; }
//
//     [JsonProperty("PayPremiumsPrsnlBnftCntrctInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PayPremiumsPrsnlBnftCntrctInd")]
//     public string PayPremiumsPrsnlBnftCntrctInd { get; set; }
//
//     [JsonProperty("Form8899Filedind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form8899Filedind")]
//     public string Form8899Filedind { get; set; }
//
//     [JsonProperty("Form1098CFiledInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form1098CFiledInd")]
//     public string Form1098CFiledInd { get; set; }
//
//     [JsonProperty("DAFExcessBusinessHoldingsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DAFExcessBusinessHoldingsInd")]
//     public string DAFExcessBusinessHoldingsInd { get; set; }
//
//     [JsonProperty("TaxableDistributionsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxableDistributionsInd")]
//     public string TaxableDistributionsInd { get; set; }
//
//     [JsonProperty("DistributionToDonorInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributionToDonorInd")]
//     public string DistributionToDonorInd { get; set; }
//
//     [JsonProperty("MembershipDuesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MembershipDuesAmt")]
//     public string MembershipDuesAmt { get; set; }
//
//     [JsonProperty("TotalContributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalContributionsAmt")]
//     public string TotalContributionsAmt { get; set; }
//
//     [JsonProperty("GamingGrossIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GamingGrossIncomeAmt")]
//     public string GamingGrossIncomeAmt { get; set; }
//
//     [JsonProperty("GamingDirectExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GamingDirectExpensesAmt")]
//     public string GamingDirectExpensesAmt { get; set; }
//
//     [JsonProperty("NetIncomeFromGamingGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetIncomeFromGamingGrp")]
//     public NetIncomeFromGamingGrp NetIncomeFromGamingGrp { get; set; }
//
//     [JsonProperty("GrossSalesOfInventoryAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossSalesOfInventoryAmt")]
//     public string GrossSalesOfInventoryAmt { get; set; }
//
//     [JsonProperty("CostOfGoodsSoldAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CostOfGoodsSoldAmt")]
//     public string CostOfGoodsSoldAmt { get; set; }
//
//     [JsonProperty("NetIncomeOrLossGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetIncomeOrLossGrp")]
//     public NetIncomeOrLossGrp NetIncomeOrLossGrp { get; set; }
//
//     [JsonProperty("GrantsToDomesticOrgsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsToDomesticOrgsGrp")]
//     public GrantsToDomesticOrgsGrp GrantsToDomesticOrgsGrp { get; set; }
//
//     [JsonProperty("OtherSalariesAndWagesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherSalariesAndWagesGrp")]
//     public OtherSalariesAndWagesGrp OtherSalariesAndWagesGrp { get; set; }
//
//     [JsonProperty("PensionPlanContributionsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PensionPlanContributionsGrp")]
//     public PensionPlanContributionsGrp PensionPlanContributionsGrp { get; set; }
//
//     [JsonProperty("PayrollTaxesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PayrollTaxesGrp")]
//     public PayrollTaxesGrp PayrollTaxesGrp { get; set; }
//
//     [JsonProperty("FeesForServicesAccountingGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FeesForServicesAccountingGrp")]
//     public FeesForServicesAccountingGrp FeesForServicesAccountingGrp { get; set; }
//
//     [JsonProperty("OfficeExpensesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OfficeExpensesGrp")]
//     public OfficeExpensesGrp OfficeExpensesGrp { get; set; }
//
//     [JsonProperty("OccupancyGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OccupancyGrp")]
//     public OccupancyGrp OccupancyGrp { get; set; }
//
//     [JsonProperty("InsuranceGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InsuranceGrp")]
//     public InsuranceGrp InsuranceGrp { get; set; }
//
//     [JsonProperty("OtherExpensesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherExpensesGrp")]
//     public List<OtherExpensesGrp> OtherExpensesGrp { get; } = new List<OtherExpensesGrp>();
//
//     [JsonProperty("CashNonInterestBearingGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashNonInterestBearingGrp")]
//     public CashNonInterestBearingGrp CashNonInterestBearingGrp { get; set; }
//
//     [JsonProperty("OrgDoesNotFollowFASB117Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrgDoesNotFollowFASB117Ind")]
//     public string OrgDoesNotFollowFASB117Ind { get; set; }
//
//     [JsonProperty("RtnEarnEndowmentIncmOthFndsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RtnEarnEndowmentIncmOthFndsGrp")]
//     public RtnEarnEndowmentIncmOthFndsGrp RtnEarnEndowmentIncmOthFndsGrp { get; set; }
//
//     [JsonProperty("MethodOfAccountingCashInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfAccountingCashInd")]
//     public string MethodOfAccountingCashInd { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("Organization501c3Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization501c3Ind")]
//     public string Organization501c3Ind { get; set; }
//
//     [JsonProperty("LobbyingActivitiesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LobbyingActivitiesInd")]
//     public string LobbyingActivitiesInd { get; set; }
//
//     [JsonProperty("EngagedInExcessBenefitTransInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EngagedInExcessBenefitTransInd")]
//     public string EngagedInExcessBenefitTransInd { get; set; }
//
//     [JsonProperty("PYExcessBenefitTransInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PYExcessBenefitTransInd")]
//     public string PYExcessBenefitTransInd { get; set; }
//
//     [JsonProperty("TrnsfrExmptNonChrtblRltdOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TrnsfrExmptNonChrtblRltdOrgInd")]
//     public string TrnsfrExmptNonChrtblRltdOrgInd { get; set; }
//
//     [JsonProperty("Form8282FiledCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form8282FiledCnt")]
//     public string Form8282FiledCnt { get; set; }
//
//     [JsonProperty("IncmFromInvestBondProceedsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IncmFromInvestBondProceedsGrp")]
//     public IncmFromInvestBondProceedsGrp IncmFromInvestBondProceedsGrp { get; set; }
//
//     [JsonProperty("RoyaltiesRevenueGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RoyaltiesRevenueGrp")]
//     public RoyaltiesRevenueGrp RoyaltiesRevenueGrp { get; set; }
//
//     [JsonProperty("NetRentalIncomeOrLossGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetRentalIncomeOrLossGrp")]
//     public NetRentalIncomeOrLossGrp NetRentalIncomeOrLossGrp { get; set; }
//
//     [JsonProperty("NetGainOrLossInvestmentsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetGainOrLossInvestmentsGrp")]
//     public NetGainOrLossInvestmentsGrp NetGainOrLossInvestmentsGrp { get; set; }
//
//     [JsonProperty("NetIncmFromFundraisingEvtGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetIncmFromFundraisingEvtGrp")]
//     public NetIncmFromFundraisingEvtGrp NetIncmFromFundraisingEvtGrp { get; set; }
//
//     [JsonProperty("OtherRevenueTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherRevenueTotalAmt")]
//     public string OtherRevenueTotalAmt { get; set; }
//
//     [JsonProperty("GrantsToDomesticIndividualsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsToDomesticIndividualsGrp")]
//     public GrantsToDomesticIndividualsGrp GrantsToDomesticIndividualsGrp { get; set; }
//
//     [JsonProperty("ForeignGrantsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignGrantsGrp")]
//     public ForeignGrantsGrp ForeignGrantsGrp { get; set; }
//
//     [JsonProperty("CompCurrentOfcrDirectorsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompCurrentOfcrDirectorsGrp")]
//     public CompCurrentOfcrDirectorsGrp CompCurrentOfcrDirectorsGrp { get; set; }
//
//     [JsonProperty("CompDisqualPersonsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompDisqualPersonsGrp")]
//     public CompDisqualPersonsGrp CompDisqualPersonsGrp { get; set; }
//
//     [JsonProperty("OtherEmployeeBenefitsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherEmployeeBenefitsGrp")]
//     public OtherEmployeeBenefitsGrp OtherEmployeeBenefitsGrp { get; set; }
//
//     [JsonProperty("FeesForServicesManagementGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FeesForServicesManagementGrp")]
//     public FeesForServicesManagementGrp FeesForServicesManagementGrp { get; set; }
//
//     [JsonProperty("FeesForServicesLegalGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FeesForServicesLegalGrp")]
//     public FeesForServicesLegalGrp FeesForServicesLegalGrp { get; set; }
//
//     [JsonProperty("FeesForServicesLobbyingGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FeesForServicesLobbyingGrp")]
//     public FeesForServicesLobbyingGrp FeesForServicesLobbyingGrp { get; set; }
//
//     [JsonProperty("FeesForServicesProfFundraising", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FeesForServicesProfFundraising")]
//     public string FeesForServicesProfFundraising { get; set; }
//
//     [JsonProperty("FeesForServicesOtherGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FeesForServicesOtherGrp")]
//     public FeesForServicesOtherGrp FeesForServicesOtherGrp { get; set; }
//
//     [JsonProperty("AdvertisingGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdvertisingGrp")]
//     public AdvertisingGrp AdvertisingGrp { get; set; }
//
//     [JsonProperty("InformationTechnologyGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InformationTechnologyGrp")]
//     public InformationTechnologyGrp InformationTechnologyGrp { get; set; }
//
//     [JsonProperty("RoyaltiesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RoyaltiesGrp")]
//     public RoyaltiesGrp RoyaltiesGrp { get; set; }
//
//     [JsonProperty("TravelGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TravelGrp")]
//     public TravelGrp TravelGrp { get; set; }
//
//     [JsonProperty("PymtTravelEntrtnmntPubOfclGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PymtTravelEntrtnmntPubOfclGrp")]
//     public PymtTravelEntrtnmntPubOfclGrp PymtTravelEntrtnmntPubOfclGrp { get; set; }
//
//     [JsonProperty("ConferencesMeetingsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ConferencesMeetingsGrp")]
//     public ConferencesMeetingsGrp ConferencesMeetingsGrp { get; set; }
//
//     [JsonProperty("InterestGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InterestGrp")]
//     public InterestGrp InterestGrp { get; set; }
//
//     [JsonProperty("PaymentsToAffiliatesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PaymentsToAffiliatesGrp")]
//     public PaymentsToAffiliatesGrp PaymentsToAffiliatesGrp { get; set; }
//
//     [JsonProperty("DepreciationDepletionGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationDepletionGrp")]
//     public DepreciationDepletionGrp DepreciationDepletionGrp { get; set; }
//
//     [JsonProperty("AllOtherExpensesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AllOtherExpensesGrp")]
//     public AllOtherExpensesGrp AllOtherExpensesGrp { get; set; }
//
//     [JsonProperty("PledgesAndGrantsReceivableGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PledgesAndGrantsReceivableGrp")]
//     public PledgesAndGrantsReceivableGrp PledgesAndGrantsReceivableGrp { get; set; }
//
//     [JsonProperty("AccountsReceivableGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AccountsReceivableGrp")]
//     public AccountsReceivableGrp AccountsReceivableGrp { get; set; }
//
//     [JsonProperty("ReceivablesFromOfficersEtcGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReceivablesFromOfficersEtcGrp")]
//     public ReceivablesFromOfficersEtcGrp ReceivablesFromOfficersEtcGrp { get; set; }
//
//     [JsonProperty("RcvblFromDisqualifiedPrsnGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RcvblFromDisqualifiedPrsnGrp")]
//     public RcvblFromDisqualifiedPrsnGrp RcvblFromDisqualifiedPrsnGrp { get; set; }
//
//     [JsonProperty("OthNotesLoansReceivableNetGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OthNotesLoansReceivableNetGrp")]
//     public OthNotesLoansReceivableNetGrp OthNotesLoansReceivableNetGrp { get; set; }
//
//     [JsonProperty("InventoriesForSaleOrUseGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InventoriesForSaleOrUseGrp")]
//     public InventoriesForSaleOrUseGrp InventoriesForSaleOrUseGrp { get; set; }
//
//     [JsonProperty("PrepaidExpensesDefrdChargesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrepaidExpensesDefrdChargesGrp")]
//     public PrepaidExpensesDefrdChargesGrp PrepaidExpensesDefrdChargesGrp { get; set; }
//
//     [JsonProperty("LandBldgEquipBasisNetGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LandBldgEquipBasisNetGrp")]
//     public LandBldgEquipBasisNetGrp LandBldgEquipBasisNetGrp { get; set; }
//
//     [JsonProperty("InvestmentsPubTradedSecGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentsPubTradedSecGrp")]
//     public InvestmentsPubTradedSecGrp InvestmentsPubTradedSecGrp { get; set; }
//
//     [JsonProperty("InvestmentsProgramRelatedGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentsProgramRelatedGrp")]
//     public InvestmentsProgramRelatedGrp InvestmentsProgramRelatedGrp { get; set; }
//
//     [JsonProperty("IntangibleAssetsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IntangibleAssetsGrp")]
//     public IntangibleAssetsGrp IntangibleAssetsGrp { get; set; }
//
//     [JsonProperty("OtherAssetsTotalGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherAssetsTotalGrp")]
//     public OtherAssetsTotalGrp OtherAssetsTotalGrp { get; set; }
//
//     [JsonProperty("NoDonorRestrictionNetAssetsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NoDonorRestrictionNetAssetsGrp")]
//     public NoDonorRestrictionNetAssetsGrp NoDonorRestrictionNetAssetsGrp { get; set; }
//
//     [JsonProperty("InfoInScheduleOPartXIInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InfoInScheduleOPartXIInd")]
//     public string InfoInScheduleOPartXIInd { get; set; }
//
//     [JsonProperty("DoingBusinessAsName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DoingBusinessAsName")]
//     public DoingBusinessAsName DoingBusinessAsName { get; set; }
//
//     [JsonProperty("RevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RevenueAmt")]
//     public string RevenueAmt { get; set; }
//
//     [JsonProperty("AnnualDisclosureCoveredPrsnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AnnualDisclosureCoveredPrsnInd")]
//     public string AnnualDisclosureCoveredPrsnInd { get; set; }
//
//     [JsonProperty("RegularMonitoringEnfrcInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RegularMonitoringEnfrcInd")]
//     public string RegularMonitoringEnfrcInd { get; set; }
//
//     [JsonProperty("InfoInScheduleOPartIXInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InfoInScheduleOPartIXInd")]
//     public string InfoInScheduleOPartIXInd { get; set; }
//
//     [JsonProperty("LandBldgEquipCostOrOtherBssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LandBldgEquipCostOrOtherBssAmt")]
//     public string LandBldgEquipCostOrOtherBssAmt { get; set; }
//
//     [JsonProperty("LandBldgEquipAccumDeprecAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LandBldgEquipAccumDeprecAmt")]
//     public string LandBldgEquipAccumDeprecAmt { get; set; }
//
//     [JsonProperty("InfoInScheduleOPartXIIInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InfoInScheduleOPartXIIInd")]
//     public string InfoInScheduleOPartXIIInd { get; set; }
//
//     [JsonProperty("WrittenPolicyOrProcedureInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("WrittenPolicyOrProcedureInd")]
//     public string WrittenPolicyOrProcedureInd { get; set; }
//
//     [JsonProperty("StatesWhereCopyOfReturnIsFldCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StatesWhereCopyOfReturnIsFldCd")]
//     public string StatesWhereCopyOfReturnIsFldCd { get; set; }
//
//     [JsonProperty("FederatedCampaignsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FederatedCampaignsAmt")]
//     public string FederatedCampaignsAmt { get; set; }
//
//     [JsonProperty("AllOtherContributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AllOtherContributionsAmt")]
//     public string AllOtherContributionsAmt { get; set; }
//
//     [JsonProperty("TypeOfOrganizationOtherInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TypeOfOrganizationOtherInd")]
//     public string TypeOfOrganizationOtherInd { get; set; }
//
//     [JsonProperty("DeferredRevenueGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DeferredRevenueGrp")]
//     public DeferredRevenueGrp DeferredRevenueGrp { get; set; }
//
//     [JsonProperty("UnsecuredNotesLoansPayableGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnsecuredNotesLoansPayableGrp")]
//     public UnsecuredNotesLoansPayableGrp UnsecuredNotesLoansPayableGrp { get; set; }
//
//     [JsonProperty("InfoInScheduleOPartIIIInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InfoInScheduleOPartIIIInd")]
//     public string InfoInScheduleOPartIIIInd { get; set; }
//
//     [JsonProperty("ProgSrvcAccomActy2Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgSrvcAccomActy2Grp")]
//     public ProgSrvcAccomActy2Grp ProgSrvcAccomActy2Grp { get; set; }
//
//     [JsonProperty("ProgSrvcAccomActy3Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgSrvcAccomActy3Grp")]
//     public ProgSrvcAccomActy3Grp ProgSrvcAccomActy3Grp { get; set; }
//
//     [JsonProperty("InfoInScheduleOPartVInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InfoInScheduleOPartVInd")]
//     public string InfoInScheduleOPartVInd { get; set; }
//
//     [JsonProperty("ForeignCountryCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignCountryCd")]
//     public string ForeignCountryCd { get; set; }
//
//     [JsonProperty("NondeductibleContriDisclInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NondeductibleContriDisclInd")]
//     public string NondeductibleContriDisclInd { get; set; }
//
//     [JsonProperty("GovernmentGrantsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GovernmentGrantsAmt")]
//     public string GovernmentGrantsAmt { get; set; }
//
//     [JsonProperty("MortgNotesPyblScrdInvstPropGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MortgNotesPyblScrdInvstPropGrp")]
//     public MortgNotesPyblScrdInvstPropGrp MortgNotesPyblScrdInvstPropGrp { get; set; }
//
//     [JsonProperty("FederalGrantAuditPerformedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FederalGrantAuditPerformedInd")]
//     public string FederalGrantAuditPerformedInd { get; set; }
//
//     [JsonProperty("GrantAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantAmt")]
//     public string GrantAmt { get; set; }
//
//     [JsonProperty("OwnWebsiteInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OwnWebsiteInd")]
//     public string OwnWebsiteInd { get; set; }
//
//     [JsonProperty("OtherWebsiteInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherWebsiteInd")]
//     public string OtherWebsiteInd { get; set; }
//
//     [JsonProperty("NoncashContributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NoncashContributionsAmt")]
//     public string NoncashContributionsAmt { get; set; }
//
//     [JsonProperty("GrossAmountSalesAssetsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossAmountSalesAssetsGrp")]
//     public GrossAmountSalesAssetsGrp GrossAmountSalesAssetsGrp { get; set; }
//
//     [JsonProperty("LessCostOthBasisSalesExpnssGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LessCostOthBasisSalesExpnssGrp")]
//     public LessCostOthBasisSalesExpnssGrp LessCostOthBasisSalesExpnssGrp { get; set; }
//
//     [JsonProperty("GainOrLossGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GainOrLossGrp")]
//     public GainOrLossGrp GainOrLossGrp { get; set; }
//
//     [JsonProperty("OtherRevenueMiscGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherRevenueMiscGrp")]
//     public OtherRevenueMiscGrp OtherRevenueMiscGrp { get; set; }
//
//     [JsonProperty("NetUnrlzdGainsLossesInvstAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetUnrlzdGainsLossesInvstAmt")]
//     public string NetUnrlzdGainsLossesInvstAmt { get; set; }
//
//     [JsonProperty("InvestmentExpenseAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentExpenseAmt")]
//     public string InvestmentExpenseAmt { get; set; }
//
//     [JsonProperty("QuidProQuoContriDisclInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("QuidProQuoContriDisclInd")]
//     public string QuidProQuoContriDisclInd { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
//
//     [JsonProperty("FundraisingGrossIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingGrossIncomeAmt")]
//     public string FundraisingGrossIncomeAmt { get; set; }
//
//     [JsonProperty("ContriRptFundraisingEventAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContriRptFundraisingEventAmt")]
//     public string ContriRptFundraisingEventAmt { get; set; }
//
//     [JsonProperty("FundraisingDirectExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingDirectExpensesAmt")]
//     public string FundraisingDirectExpensesAmt { get; set; }
//
//     [JsonProperty("InfoInScheduleOPartXInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InfoInScheduleOPartXInd")]
//     public string InfoInScheduleOPartXInd { get; set; }
//
//     [JsonProperty("TypeOfOrganizationAssocInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TypeOfOrganizationAssocInd")]
//     public string TypeOfOrganizationAssocInd { get; set; }
//
//     [JsonProperty("AcctCompileOrReviewBasisGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AcctCompileOrReviewBasisGrp")]
//     public AcctCompileOrReviewBasisGrp AcctCompileOrReviewBasisGrp { get; set; }
//
//     [JsonProperty("ProgSrvcAccomActyOtherGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgSrvcAccomActyOtherGrp")]
//     public ProgSrvcAccomActyOtherGrp ProgSrvcAccomActyOtherGrp { get; set; }
//
//     [JsonProperty("GrantsPayableGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsPayableGrp")]
//     public GrantsPayableGrp GrantsPayableGrp { get; set; }
//
//     [JsonProperty("AddressChangeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressChangeInd")]
//     public string AddressChangeInd { get; set; }
//
//     [JsonProperty("PoliciesReferenceChaptersInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PoliciesReferenceChaptersInd")]
//     public string PoliciesReferenceChaptersInd { get; set; }
//
//     [JsonProperty("CapStkTrPrinCurrentFundsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CapStkTrPrinCurrentFundsGrp")]
//     public CapStkTrPrinCurrentFundsGrp CapStkTrPrinCurrentFundsGrp { get; set; }
//
//     [JsonProperty("PdInCapSrplsLandBldgEqpFundGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PdInCapSrplsLandBldgEqpFundGrp")]
//     public PdInCapSrplsLandBldgEqpFundGrp PdInCapSrplsLandBldgEqpFundGrp { get; set; }
//
//     [JsonProperty("OtherOrganizationDsc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherOrganizationDsc")]
//     public string OtherOrganizationDsc { get; set; }
//
//     [JsonProperty("TotalOtherProgSrvcExpenseAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalOtherProgSrvcExpenseAmt")]
//     public string TotalOtherProgSrvcExpenseAmt { get; set; }
//
//     [JsonProperty("TotalOtherProgSrvcGrantAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalOtherProgSrvcGrantAmt")]
//     public string TotalOtherProgSrvcGrantAmt { get; set; }
//
//     [JsonProperty("TotalOtherProgSrvcRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalOtherProgSrvcRevenueAmt")]
//     public string TotalOtherProgSrvcRevenueAmt { get; set; }
//
//     [JsonProperty("TotalOthProgramServiceRevGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalOthProgramServiceRevGrp")]
//     public TotalOthProgramServiceRevGrp TotalOthProgramServiceRevGrp { get; set; }
//
//     [JsonProperty("GrossRentsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossRentsGrp")]
//     public GrossRentsGrp GrossRentsGrp { get; set; }
//
//     [JsonProperty("LessRentalExpensesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LessRentalExpensesGrp")]
//     public LessRentalExpensesGrp LessRentalExpensesGrp { get; set; }
//
//     [JsonProperty("RentalIncomeOrLossGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RentalIncomeOrLossGrp")]
//     public RentalIncomeOrLossGrp RentalIncomeOrLossGrp { get; set; }
//
//     [JsonProperty("PriorPeriodAdjustmentsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorPeriodAdjustmentsAmt")]
//     public string PriorPeriodAdjustmentsAmt { get; set; }
//
//     [JsonProperty("RelatedOrganizationsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrganizationsAmt")]
//     public string RelatedOrganizationsAmt { get; set; }
//
//     [JsonProperty("ContractorCompensationGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContractorCompensationGrp")]
//     public List<ContractorCompensationGrp> ContractorCompensationGrp { get; } = new List<ContractorCompensationGrp>();
//
//     [JsonProperty("EscrowAccountLiabilityGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EscrowAccountLiabilityGrp")]
//     public EscrowAccountLiabilityGrp EscrowAccountLiabilityGrp { get; set; }
//
//     [JsonProperty("TaxExemptBondLiabilitiesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxExemptBondLiabilitiesGrp")]
//     public TaxExemptBondLiabilitiesGrp TaxExemptBondLiabilitiesGrp { get; set; }
//
//     [JsonProperty("LoansFromOfficersDirectorsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoansFromOfficersDirectorsGrp")]
//     public LoansFromOfficersDirectorsGrp LoansFromOfficersDirectorsGrp { get; set; }
//
//     [JsonProperty("DonatedServicesAndUseFcltsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DonatedServicesAndUseFcltsAmt")]
//     public string DonatedServicesAndUseFcltsAmt { get; set; }
//
//     [JsonProperty("OtherInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherInd")]
//     public string OtherInd { get; set; }
//
//     [JsonProperty("AmendedReturnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AmendedReturnInd")]
//     public string AmendedReturnInd { get; set; }
//
//     [JsonProperty("MiscellaneousRevenueGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MiscellaneousRevenueGrp")]
//     public MiscellaneousRevenueGrp MiscellaneousRevenueGrp { get; set; }
//
//     [JsonProperty("InvestTaxExemptBondsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestTaxExemptBondsInd")]
//     public string InvestTaxExemptBondsInd { get; set; }
//
//     [JsonProperty("EscrowAccountInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EscrowAccountInd")]
//     public string EscrowAccountInd { get; set; }
//
//     [JsonProperty("OnBehalfOfIssuerInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OnBehalfOfIssuerInd")]
//     public string OnBehalfOfIssuerInd { get; set; }
//
//     [JsonProperty("FinalReturnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FinalReturnInd")]
//     public string FinalReturnInd { get; set; }
//
//     [JsonProperty("ContractTerminationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContractTerminationInd")]
//     public string ContractTerminationInd { get; set; }
//
//     [JsonProperty("MembersAndShrGrossIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MembersAndShrGrossIncomeAmt")]
//     public string MembersAndShrGrossIncomeAmt { get; set; }
//
//     [JsonProperty("OtherSourcesGrossIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherSourcesGrossIncomeAmt")]
//     public string OtherSourcesGrossIncomeAmt { get; set; }
//
//     [JsonProperty("AllAffiliatesIncludedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AllAffiliatesIncludedInd")]
//     public string AllAffiliatesIncludedInd { get; set; }
//
//     [JsonProperty("GroupExemptionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GroupExemptionNum")]
//     public string GroupExemptionNum { get; set; }
//
//     [JsonProperty("ExcsTaxSect4951Or4952Or4953Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcsTaxSect4951Or4952Or4953Ind")]
//     public string ExcsTaxSect4951Or4952Or4953Ind { get; set; }
//
//     [JsonProperty("InfoInScheduleOPartVIIInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InfoInScheduleOPartVIIInd")]
//     public string InfoInScheduleOPartVIIInd { get; set; }
//
//     [JsonProperty("PrincipalOfcrBusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrincipalOfcrBusinessName")]
//     public PrincipalOfcrBusinessName PrincipalOfcrBusinessName { get; set; }
//
//     [JsonProperty("ActivityCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivityCd")]
//     public string ActivityCd { get; set; }
//
//     [JsonProperty("OrgFiledInLieuOfForm1041Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrgFiledInLieuOfForm1041Ind")]
//     public string OrgFiledInLieuOfForm1041Ind { get; set; }
//
//     [JsonProperty("TaxExemptInterestAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxExemptInterestAmt")]
//     public string TaxExemptInterestAmt { get; set; }
//
//     [JsonProperty("LicensedMoreThanOneStateInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LicensedMoreThanOneStateInd")]
//     public string LicensedMoreThanOneStateInd { get; set; }
//
//     [JsonProperty("InfoInScheduleOPartVIIIInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InfoInScheduleOPartVIIIInd")]
//     public string InfoInScheduleOPartVIIIInd { get; set; }
//
//     [JsonProperty("AuditedFinancialStmtAttInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AuditedFinancialStmtAttInd")]
//     public AuditedFinancialStmtAttInd AuditedFinancialStmtAttInd { get; set; }
//
//     [JsonProperty("InitialReturnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InitialReturnInd")]
//     public string InitialReturnInd { get; set; }
//
//     [JsonProperty("JointCostsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("JointCostsInd")]
//     public string JointCostsInd { get; set; }
//
//     [JsonProperty("TotalJointCostsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalJointCostsGrp")]
//     public TotalJointCostsGrp TotalJointCostsGrp { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("Organization4947a1NotPFInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization4947a1NotPFInd")]
//     public string Organization4947a1NotPFInd { get; set; }
//
//     [JsonProperty("Form8886TFiledInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form8886TFiledInd")]
//     public string Form8886TFiledInd { get; set; }
//
//     [JsonProperty("GrossReceiptsForPublicUseAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossReceiptsForPublicUseAmt")]
//     public string GrossReceiptsForPublicUseAmt { get; set; }
//
//     [JsonProperty("InitiationFeesAndCapContriAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InitiationFeesAndCapContriAmt")]
//     public string InitiationFeesAndCapContriAmt { get; set; }
//
//     [JsonProperty("Form720FiledInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form720FiledInd")]
//     public string Form720FiledInd { get; set; }
//
//     [JsonProperty("TempOrPermanentEndowmentsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TempOrPermanentEndowmentsInd")]
//     public TempOrPermanentEndowmentsInd TempOrPermanentEndowmentsInd { get; set; }
//
//     [JsonProperty("BusinessRlnWithOfficerEntInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessRlnWithOfficerEntInd")]
//     public string BusinessRlnWithOfficerEntInd { get; set; }
//
//     [JsonProperty("OrganizationFollowsSFAS117Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrganizationFollowsSFAS117Ind")]
//     public string OrganizationFollowsSFAS117Ind { get; set; }
//
//     [JsonProperty("UnrestrictedNetAssetsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrestrictedNetAssetsGrp")]
//     public UnrestrictedNetAssetsGrp UnrestrictedNetAssetsGrp { get; set; }
//
//     [JsonProperty("@accountingPeriodChangeCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@accountingPeriodChangeCd")]
//     public string AccountingPeriodChangeCd { get; set; }
//
//     [JsonProperty("@accountingPeriodChangeApprvCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@accountingPeriodChangeApprvCd")]
//     public string AccountingPeriodChangeApprvCd { get; set; }
//
//     [JsonProperty("MethodOfAccountingOtherInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfAccountingOtherInd")]
//     public MethodOfAccountingOtherInd MethodOfAccountingOtherInd { get; set; }
//
//     [JsonProperty("ForeignAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignAddress")]
//     public ForeignAddress ForeignAddress { get; set; }
//
//     [JsonProperty("LegalDomicileCountryCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LegalDomicileCountryCd")]
//     public string LegalDomicileCountryCd { get; set; }
//
//     [JsonProperty("NameChangeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NameChangeInd")]
//     public string NameChangeInd { get; set; }
//
//     [JsonProperty("TemporarilyRstrNetAssetsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TemporarilyRstrNetAssetsGrp")]
//     public TemporarilyRstrNetAssetsGrp TemporarilyRstrNetAssetsGrp { get; set; }
//
//     [JsonProperty("StateRequiredReservesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StateRequiredReservesAmt")]
//     public string StateRequiredReservesAmt { get; set; }
//
//     [JsonProperty("ReservesMaintainedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReservesMaintainedAmt")]
//     public string ReservesMaintainedAmt { get; set; }
//
//     [JsonProperty("ApplicationPendingInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ApplicationPendingInd")]
//     public string ApplicationPendingInd { get; set; }
//
//     [JsonProperty("PermanentlyRstrNetAssetsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PermanentlyRstrNetAssetsGrp")]
//     public PermanentlyRstrNetAssetsGrp PermanentlyRstrNetAssetsGrp { get; set; }
//
//     [JsonProperty("SpecialConditionDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SpecialConditionDesc")]
//     public string SpecialConditionDesc { get; set; }
//
//     [JsonProperty("OrgDoesNotFollowSFAS117Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrgDoesNotFollowSFAS117Ind")]
//     public string OrgDoesNotFollowSFAS117Ind { get; set; }
// }
//
// public class IRS990EZ
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("MethodOfAccountingAccrualInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfAccountingAccrualInd")]
//     public string MethodOfAccountingAccrualInd { get; set; }
//
//     [JsonProperty("ScheduleBNotRequiredInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ScheduleBNotRequiredInd")]
//     public string ScheduleBNotRequiredInd { get; set; }
//
//     [JsonProperty("WebsiteAddressTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("WebsiteAddressTxt")]
//     public string WebsiteAddressTxt { get; set; }
//
//     [JsonProperty("Organization501c3Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization501c3Ind")]
//     public Organization501c3Ind Organization501c3Ind { get; set; }
//
//     [JsonProperty("TypeOfOrganizationCorpInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TypeOfOrganizationCorpInd")]
//     public string TypeOfOrganizationCorpInd { get; set; }
//
//     [JsonProperty("GrossReceiptsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossReceiptsAmt")]
//     public string GrossReceiptsAmt { get; set; }
//
//     [JsonProperty("InfoInScheduleOPartIInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InfoInScheduleOPartIInd")]
//     public string InfoInScheduleOPartIInd { get; set; }
//
//     [JsonProperty("ContributionsGiftsGrantsEtcAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributionsGiftsGrantsEtcAmt")]
//     public string ContributionsGiftsGrantsEtcAmt { get; set; }
//
//     [JsonProperty("TotalRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevenueAmt")]
//     public string TotalRevenueAmt { get; set; }
//
//     [JsonProperty("OtherExpensesTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherExpensesTotalAmt")]
//     public string OtherExpensesTotalAmt { get; set; }
//
//     [JsonProperty("TotalExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensesAmt")]
//     public string TotalExpensesAmt { get; set; }
//
//     [JsonProperty("InfoInScheduleOPartIIInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InfoInScheduleOPartIIInd")]
//     public string InfoInScheduleOPartIIInd { get; set; }
//
//     [JsonProperty("CashSavingsAndInvestmentsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashSavingsAndInvestmentsGrp")]
//     public CashSavingsAndInvestmentsGrp CashSavingsAndInvestmentsGrp { get; set; }
//
//     [JsonProperty("Form990TotalAssetsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form990TotalAssetsGrp")]
//     public Form990TotalAssetsGrp Form990TotalAssetsGrp { get; set; }
//
//     [JsonProperty("SumOfTotalLiabilitiesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SumOfTotalLiabilitiesGrp")]
//     public SumOfTotalLiabilitiesGrp SumOfTotalLiabilitiesGrp { get; set; }
//
//     [JsonProperty("NetAssetsOrFundBalancesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetAssetsOrFundBalancesGrp")]
//     public NetAssetsOrFundBalancesGrp NetAssetsOrFundBalancesGrp { get; set; }
//
//     [JsonProperty("InfoInScheduleOPartIIIInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InfoInScheduleOPartIIIInd")]
//     public string InfoInScheduleOPartIIIInd { get; set; }
//
//     [JsonProperty("PrimaryExemptPurposeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrimaryExemptPurposeTxt")]
//     public string PrimaryExemptPurposeTxt { get; set; }
//
//     [JsonProperty("ProgramSrvcAccomplishmentGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramSrvcAccomplishmentGrp")]
//     public List<ProgramSrvcAccomplishmentGrp> ProgramSrvcAccomplishmentGrp { get; } =
//         new List<ProgramSrvcAccomplishmentGrp>();
//
//     [JsonProperty("TotalProgramServiceExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalProgramServiceExpensesAmt")]
//     public string TotalProgramServiceExpensesAmt { get; set; }
//
//     [JsonProperty("OfficerDirectorTrusteeEmplGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OfficerDirectorTrusteeEmplGrp")]
//     public List<OfficerDirectorTrusteeEmplGrp> OfficerDirectorTrusteeEmplGrp { get; } =
//         new List<OfficerDirectorTrusteeEmplGrp>();
//
//     [JsonProperty("ActivitiesNotPreviouslyRptInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesNotPreviouslyRptInd")]
//     public string ActivitiesNotPreviouslyRptInd { get; set; }
//
//     [JsonProperty("ChgMadeToOrgnzngDocNotRptInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ChgMadeToOrgnzngDocNotRptInd")]
//     public string ChgMadeToOrgnzngDocNotRptInd { get; set; }
//
//     [JsonProperty("OrganizationHadUBIInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrganizationHadUBIInd")]
//     public string OrganizationHadUBIInd { get; set; }
//
//     [JsonProperty("SubjectToProxyTaxInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubjectToProxyTaxInd")]
//     public SubjectToProxyTaxInd SubjectToProxyTaxInd { get; set; }
//
//     [JsonProperty("OrganizationDissolvedEtcInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrganizationDissolvedEtcInd")]
//     public OrganizationDissolvedEtcInd OrganizationDissolvedEtcInd { get; set; }
//
//     [JsonProperty("Form1120PolFiledInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form1120PolFiledInd")]
//     public string Form1120PolFiledInd { get; set; }
//
//     [JsonProperty("MadeLoansToFromOfficersInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MadeLoansToFromOfficersInd")]
//     public string MadeLoansToFromOfficersInd { get; set; }
//
//     [JsonProperty("EngagedInExcessBenefitTransInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EngagedInExcessBenefitTransInd")]
//     public EngagedInExcessBenefitTransInd EngagedInExcessBenefitTransInd { get; set; }
//
//     [JsonProperty("ProhibitedTaxShelterTransInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProhibitedTaxShelterTransInd")]
//     public string ProhibitedTaxShelterTransInd { get; set; }
//
//     [JsonProperty("BooksInCareOfDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BooksInCareOfDetail")]
//     public BooksInCareOfDetail BooksInCareOfDetail { get; set; }
//
//     [JsonProperty("ForeignFinancialAccountInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignFinancialAccountInd")]
//     public string ForeignFinancialAccountInd { get; set; }
//
//     [JsonProperty("ForeignOfficeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignOfficeInd")]
//     public string ForeignOfficeInd { get; set; }
//
//     [JsonProperty("DonorAdvisedFndsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DonorAdvisedFndsInd")]
//     public string DonorAdvisedFndsInd { get; set; }
//
//     [JsonProperty("OperateHospitalInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OperateHospitalInd")]
//     public string OperateHospitalInd { get; set; }
//
//     [JsonProperty("TanningServicesProvidedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TanningServicesProvidedInd")]
//     public string TanningServicesProvidedInd { get; set; }
//
//     [JsonProperty("RelatedOrganizationCtrlEntInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrganizationCtrlEntInd")]
//     public string RelatedOrganizationCtrlEntInd { get; set; }
//
//     [JsonProperty("TransactionWithControlEntInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransactionWithControlEntInd")]
//     public string TransactionWithControlEntInd { get; set; }
//
//     [JsonProperty("PoliticalCampaignActyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PoliticalCampaignActyInd")]
//     public PoliticalCampaignActyInd PoliticalCampaignActyInd { get; set; }
//
//     [JsonProperty("LobbyingActivitiesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LobbyingActivitiesInd")]
//     public string LobbyingActivitiesInd { get; set; }
//
//     [JsonProperty("SchoolOperatingInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SchoolOperatingInd")]
//     public string SchoolOperatingInd { get; set; }
//
//     [JsonProperty("TrnsfrExmptNonChrtblRltdOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TrnsfrExmptNonChrtblRltdOrgInd")]
//     public string TrnsfrExmptNonChrtblRltdOrgInd { get; set; }
//
//     [JsonProperty("PartVIOfCompOfHghstPdEmplTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PartVIOfCompOfHghstPdEmplTxt")]
//     public string PartVIOfCompOfHghstPdEmplTxt { get; set; }
//
//     [JsonProperty("PartVIHghstPdCntrctProfSrvcTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PartVIHghstPdCntrctProfSrvcTxt")]
//     public string PartVIHghstPdCntrctProfSrvcTxt { get; set; }
//
//     [JsonProperty("FiledScheduleAInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FiledScheduleAInd")]
//     public string FiledScheduleAInd { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("InitialReturnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InitialReturnInd")]
//     public string InitialReturnInd { get; set; }
//
//     [JsonProperty("AmendedReturnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AmendedReturnInd")]
//     public string AmendedReturnInd { get; set; }
//
//     [JsonProperty("MethodOfAccountingCashInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfAccountingCashInd")]
//     public string MethodOfAccountingCashInd { get; set; }
//
//     [JsonProperty("ProgramServiceRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServiceRevenueAmt")]
//     public string ProgramServiceRevenueAmt { get; set; }
//
//     [JsonProperty("MembershipDuesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MembershipDuesAmt")]
//     public string MembershipDuesAmt { get; set; }
//
//     [JsonProperty("InvestmentIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentIncomeAmt")]
//     public string InvestmentIncomeAmt { get; set; }
//
//     [JsonProperty("SaleOfAssetsGrossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SaleOfAssetsGrossAmt")]
//     public string SaleOfAssetsGrossAmt { get; set; }
//
//     [JsonProperty("CostOrOtherBasisExpenseSaleAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CostOrOtherBasisExpenseSaleAmt")]
//     public string CostOrOtherBasisExpenseSaleAmt { get; set; }
//
//     [JsonProperty("GainOrLossFromSaleOfAssetsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GainOrLossFromSaleOfAssetsAmt")]
//     public string GainOrLossFromSaleOfAssetsAmt { get; set; }
//
//     [JsonProperty("GamingGrossIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GamingGrossIncomeAmt")]
//     public string GamingGrossIncomeAmt { get; set; }
//
//     [JsonProperty("FundraisingGrossIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingGrossIncomeAmt")]
//     public FundraisingGrossIncomeAmt FundraisingGrossIncomeAmt { get; set; }
//
//     [JsonProperty("SpecialEventsDirectExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SpecialEventsDirectExpensesAmt")]
//     public string SpecialEventsDirectExpensesAmt { get; set; }
//
//     [JsonProperty("SpecialEventsNetIncomeLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SpecialEventsNetIncomeLossAmt")]
//     public string SpecialEventsNetIncomeLossAmt { get; set; }
//
//     [JsonProperty("GrossSalesOfInventoryAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossSalesOfInventoryAmt")]
//     public string GrossSalesOfInventoryAmt { get; set; }
//
//     [JsonProperty("CostOfGoodsSoldAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CostOfGoodsSoldAmt")]
//     public string CostOfGoodsSoldAmt { get; set; }
//
//     [JsonProperty("GrossProfitLossSlsOfInvntryAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossProfitLossSlsOfInvntryAmt")]
//     public string GrossProfitLossSlsOfInvntryAmt { get; set; }
//
//     [JsonProperty("OtherRevenueTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherRevenueTotalAmt")]
//     public string OtherRevenueTotalAmt { get; set; }
//
//     [JsonProperty("GrantsAndSimilarAmountsPaidAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsAndSimilarAmountsPaidAmt")]
//     public string GrantsAndSimilarAmountsPaidAmt { get; set; }
//
//     [JsonProperty("BenefitsPaidToOrForMembersAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BenefitsPaidToOrForMembersAmt")]
//     public string BenefitsPaidToOrForMembersAmt { get; set; }
//
//     [JsonProperty("SalariesOtherCompEmplBnftAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SalariesOtherCompEmplBnftAmt")]
//     public string SalariesOtherCompEmplBnftAmt { get; set; }
//
//     [JsonProperty("FeesAndOtherPymtToIndCntrctAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FeesAndOtherPymtToIndCntrctAmt")]
//     public string FeesAndOtherPymtToIndCntrctAmt { get; set; }
//
//     [JsonProperty("OccupancyRentUtltsAndMaintAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OccupancyRentUtltsAndMaintAmt")]
//     public string OccupancyRentUtltsAndMaintAmt { get; set; }
//
//     [JsonProperty("PrintingPublicationsPostageAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrintingPublicationsPostageAmt")]
//     public string PrintingPublicationsPostageAmt { get; set; }
//
//     [JsonProperty("ExcessOrDeficitForYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessOrDeficitForYearAmt")]
//     public string ExcessOrDeficitForYearAmt { get; set; }
//
//     [JsonProperty("NetAssetsOrFundBalancesBOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetAssetsOrFundBalancesBOYAmt")]
//     public string NetAssetsOrFundBalancesBOYAmt { get; set; }
//
//     [JsonProperty("OtherChangesInNetAssetsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherChangesInNetAssetsAmt")]
//     public string OtherChangesInNetAssetsAmt { get; set; }
//
//     [JsonProperty("NetAssetsOrFundBalancesEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetAssetsOrFundBalancesEOYAmt")]
//     public string NetAssetsOrFundBalancesEOYAmt { get; set; }
//
//     [JsonProperty("LandAndBuildingsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LandAndBuildingsGrp")]
//     public LandAndBuildingsGrp LandAndBuildingsGrp { get; set; }
//
//     [JsonProperty("OtherAssetsTotalDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherAssetsTotalDetail")]
//     public OtherAssetsTotalDetail OtherAssetsTotalDetail { get; set; }
//
//     [JsonProperty("DirectIndirectPltclExpendAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectIndirectPltclExpendAmt")]
//     public string DirectIndirectPltclExpendAmt { get; set; }
//
//     [JsonProperty("TaxImposedUnderIRC4911Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxImposedUnderIRC4911Amt")]
//     public string TaxImposedUnderIRC4911Amt { get; set; }
//
//     [JsonProperty("TaxImposedUnderIRC4912Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxImposedUnderIRC4912Amt")]
//     public string TaxImposedUnderIRC4912Amt { get; set; }
//
//     [JsonProperty("TaxImposedUnderIRC4955Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxImposedUnderIRC4955Amt")]
//     public string TaxImposedUnderIRC4955Amt { get; set; }
//
//     [JsonProperty("TaxImposedOnOrganizationMgrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxImposedOnOrganizationMgrAmt")]
//     public string TaxImposedOnOrganizationMgrAmt { get; set; }
//
//     [JsonProperty("TaxReimbursedByOrganizationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxReimbursedByOrganizationAmt")]
//     public string TaxReimbursedByOrganizationAmt { get; set; }
//
//     [JsonProperty("StatesWhereCopyOfReturnIsFldCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StatesWhereCopyOfReturnIsFldCd")]
//     public string StatesWhereCopyOfReturnIsFldCd { get; set; }
//
//     [JsonProperty("Organization501cInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization501cInd")]
//     public Organization501cInd Organization501cInd { get; set; }
//
//     [JsonProperty("MethodOfAccountingOtherDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfAccountingOtherDesc")]
//     public string MethodOfAccountingOtherDesc { get; set; }
//
//     [JsonProperty("TypeOfOrganizationOtherInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TypeOfOrganizationOtherInd")]
//     public string TypeOfOrganizationOtherInd { get; set; }
//
//     [JsonProperty("TypeOfOrganizationOtherDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TypeOfOrganizationOtherDesc")]
//     public string TypeOfOrganizationOtherDesc { get; set; }
//
//     [JsonProperty("InfoInScheduleOPartVInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InfoInScheduleOPartVInd")]
//     public string InfoInScheduleOPartVInd { get; set; }
//
//     [JsonProperty("InitiationFeesAndCapContriAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InitiationFeesAndCapContriAmt")]
//     public string InitiationFeesAndCapContriAmt { get; set; }
//
//     [JsonProperty("GrossReceiptsForPublicUseAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossReceiptsForPublicUseAmt")]
//     public string GrossReceiptsForPublicUseAmt { get; set; }
//
//     [JsonProperty("FinalReturnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FinalReturnInd")]
//     public string FinalReturnInd { get; set; }
//
//     [JsonProperty("Form720FiledInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form720FiledInd")]
//     public string Form720FiledInd { get; set; }
//
//     [JsonProperty("Organization4947a1NotPFInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization4947a1NotPFInd")]
//     public Organization4947a1NotPFInd Organization4947a1NotPFInd { get; set; }
//
//     [JsonProperty("TypeOfOrganizationTrustInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TypeOfOrganizationTrustInd")]
//     public string TypeOfOrganizationTrustInd { get; set; }
//
//     [JsonProperty("NECTFilingForm990Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NECTFilingForm990Ind")]
//     public NECTFilingForm990Ind NECTFilingForm990Ind { get; set; }
//
//     [JsonProperty("AddressChangeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressChangeInd")]
//     public string AddressChangeInd { get; set; }
//
//     [JsonProperty("GroupExemptionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GroupExemptionNum")]
//     public string GroupExemptionNum { get; set; }
//
//     [JsonProperty("TypeOfOrganizationAssocInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TypeOfOrganizationAssocInd")]
//     public string TypeOfOrganizationAssocInd { get; set; }
//
//     [JsonProperty("InfoInScheduleOPartIVInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InfoInScheduleOPartIVInd")]
//     public string InfoInScheduleOPartIVInd { get; set; }
//
//     [JsonProperty("InfoInScheduleOPartVIInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InfoInScheduleOPartVIInd")]
//     public string InfoInScheduleOPartVIInd { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("OtherEmployeePaidOver100kCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherEmployeePaidOver100kCnt")]
//     public string OtherEmployeePaidOver100kCnt { get; set; }
//
//     [JsonProperty("CntrctRcvdGreaterThan100KCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CntrctRcvdGreaterThan100KCnt")]
//     public string CntrctRcvdGreaterThan100KCnt { get; set; }
//
//     [JsonProperty("LoansToFromOfficersAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoansToFromOfficersAmt")]
//     public string LoansToFromOfficersAmt { get; set; }
//
//     [JsonProperty("OrganizationFiled990TInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrganizationFiled990TInd")]
//     public string OrganizationFiled990TInd { get; set; }
//
//     [JsonProperty("RelatedOrgSect527OrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrgSect527OrgInd")]
//     public string RelatedOrgSect527OrgInd { get; set; }
//
//     [JsonProperty("SpecialConditionDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SpecialConditionDesc")]
//     public string SpecialConditionDesc { get; set; }
//
//     [JsonProperty("ForeignFinancialAccountCntryCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignFinancialAccountCntryCd")]
//     public string ForeignFinancialAccountCntryCd { get; set; }
//
//     [JsonProperty("ForeignOfficeCountryCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignOfficeCountryCd")]
//     public string ForeignOfficeCountryCd { get; set; }
//
//     [JsonProperty("CompensationOfHghstPdCntrctGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompensationOfHghstPdCntrctGrp")]
//     public CompensationOfHghstPdCntrctGrp CompensationOfHghstPdCntrctGrp { get; set; }
//
//     [JsonProperty("NameChangeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NameChangeInd")]
//     public string NameChangeInd { get; set; }
//
//     [JsonProperty("ApplicationPendingInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ApplicationPendingInd")]
//     public string ApplicationPendingInd { get; set; }
//
//     [JsonProperty("@accountingPeriodChangeCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@accountingPeriodChangeCd")]
//     public string AccountingPeriodChangeCd { get; set; }
//
//     [JsonProperty("@accountingPeriodChangeApprvCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@accountingPeriodChangeApprvCd")]
//     public string AccountingPeriodChangeApprvCd { get; set; }
//
//     [JsonProperty("CompensationHighestPaidEmplGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompensationHighestPaidEmplGrp")]
//     public CompensationHighestPaidEmplGrp CompensationHighestPaidEmplGrp { get; set; }
// }
//
// public class IRS990PF
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("Organization501c3ExemptPFInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization501c3ExemptPFInd")]
//     public string Organization501c3ExemptPFInd { get; set; }
//
//     [JsonProperty("FMVAssetsEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FMVAssetsEOYAmt")]
//     public string FMVAssetsEOYAmt { get; set; }
//
//     [JsonProperty("MethodOfAccountingCashInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfAccountingCashInd")]
//     public string MethodOfAccountingCashInd { get; set; }
//
//     [JsonProperty("AnalysisOfRevenueAndExpenses", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AnalysisOfRevenueAndExpenses")]
//     public AnalysisOfRevenueAndExpenses AnalysisOfRevenueAndExpenses { get; set; }
//
//     [JsonProperty("Form990PFBalanceSheetsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form990PFBalanceSheetsGrp")]
//     public Form990PFBalanceSheetsGrp Form990PFBalanceSheetsGrp { get; set; }
//
//     [JsonProperty("ChgInNetAssetsFundBalancesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ChgInNetAssetsFundBalancesGrp")]
//     public ChgInNetAssetsFundBalancesGrp ChgInNetAssetsFundBalancesGrp { get; set; }
//
//     [JsonProperty("CapGainsLossTxInvstIncmDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CapGainsLossTxInvstIncmDetail")]
//     public CapGainsLossTxInvstIncmDetail CapGainsLossTxInvstIncmDetail { get; set; }
//
//     [JsonProperty("ExciseTaxBasedOnInvstIncmGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExciseTaxBasedOnInvstIncmGrp")]
//     public ExciseTaxBasedOnInvstIncmGrp ExciseTaxBasedOnInvstIncmGrp { get; set; }
//
//     [JsonProperty("StatementsRegardingActyGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StatementsRegardingActyGrp")]
//     public StatementsRegardingActyGrp StatementsRegardingActyGrp { get; set; }
//
//     [JsonProperty("StatementsRegardingActy4720Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StatementsRegardingActy4720Grp")]
//     public StatementsRegardingActy4720Grp StatementsRegardingActy4720Grp { get; set; }
//
//     [JsonProperty("OfficerDirTrstKeyEmplInfoGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OfficerDirTrstKeyEmplInfoGrp")]
//     public OfficerDirTrstKeyEmplInfoGrp OfficerDirTrstKeyEmplInfoGrp { get; set; }
//
//     [JsonProperty("SummaryOfDirectChrtblActyGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SummaryOfDirectChrtblActyGrp")]
//     public SummaryOfDirectChrtblActyGrp SummaryOfDirectChrtblActyGrp { get; set; }
//
//     [JsonProperty("SumOfProgramRelatedInvstGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SumOfProgramRelatedInvstGrp")]
//     public SumOfProgramRelatedInvstGrp SumOfProgramRelatedInvstGrp { get; set; }
//
//     [JsonProperty("MinimumInvestmentReturnGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MinimumInvestmentReturnGrp")]
//     public MinimumInvestmentReturnGrp MinimumInvestmentReturnGrp { get; set; }
//
//     [JsonProperty("DistributableAmountGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributableAmountGrp")]
//     public DistributableAmountGrp DistributableAmountGrp { get; set; }
//
//     [JsonProperty("QualifyingDistriPartXIIGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("QualifyingDistriPartXIIGrp")]
//     public QualifyingDistriPartXIIGrp QualifyingDistriPartXIIGrp { get; set; }
//
//     [JsonProperty("PrivateOperatingFoundationsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrivateOperatingFoundationsGrp")]
//     public string PrivateOperatingFoundationsGrp { get; set; }
//
//     [JsonProperty("AnalysisIncomeProducingActyGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AnalysisIncomeProducingActyGrp")]
//     public AnalysisIncomeProducingActyGrp AnalysisIncomeProducingActyGrp { get; set; }
//
//     [JsonProperty("TrnsfrTransRlnNonchrtblEOGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TrnsfrTransRlnNonchrtblEOGrp")]
//     public TrnsfrTransRlnNonchrtblEOGrp TrnsfrTransRlnNonchrtblEOGrp { get; set; }
//
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("MethodOfAccountingAccrualInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfAccountingAccrualInd")]
//     public string MethodOfAccountingAccrualInd { get; set; }
//
//     [JsonProperty("PFQualifyingDistributionsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PFQualifyingDistributionsGrp")]
//     public PFQualifyingDistributionsGrp PFQualifyingDistributionsGrp { get; set; }
//
//     [JsonProperty("SupplementaryInformationGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupplementaryInformationGrp")]
//     public SupplementaryInformationGrp SupplementaryInformationGrp { get; set; }
//
//     [JsonProperty("QlfyUndSect4940eReducedTaxGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("QlfyUndSect4940eReducedTaxGrp")]
//     public QlfyUndSect4940eReducedTaxGrp QlfyUndSect4940eReducedTaxGrp { get; set; }
//
//     [JsonProperty("UndistributedIncomeGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UndistributedIncomeGrp")]
//     public UndistributedIncomeGrp UndistributedIncomeGrp { get; set; }
//
//     [JsonProperty("RlnOfActyToAccomOfExmptPrpsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RlnOfActyToAccomOfExmptPrpsGrp")]
//     public RlnOfActyToAccomOfExmptPrpsGrp RlnOfActyToAccomOfExmptPrpsGrp { get; set; }
//
//     [JsonProperty("InitialReturnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InitialReturnInd")]
//     public string InitialReturnInd { get; set; }
//
//     [JsonProperty("AddressChangeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressChangeInd")]
//     public string AddressChangeInd { get; set; }
//
//     [JsonProperty("Organization4947a1TrtdPFInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization4947a1TrtdPFInd")]
//     public string Organization4947a1TrtdPFInd { get; set; }
//
//     [JsonProperty("InitialReturnFormerPubChrtyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InitialReturnFormerPubChrtyInd")]
//     public string InitialReturnFormerPubChrtyInd { get; set; }
//
//     [JsonProperty("MethodOfAccountingOtherInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfAccountingOtherInd")]
//     public MethodOfAccountingOtherInd MethodOfAccountingOtherInd { get; set; }
//
//     [JsonProperty("AmendedReturnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AmendedReturnInd")]
//     public string AmendedReturnInd { get; set; }
//
//     [JsonProperty("ApplicationPendingInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ApplicationPendingInd")]
//     public string ApplicationPendingInd { get; set; }
//
//     [JsonProperty("FinalReturnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FinalReturnInd")]
//     public string FinalReturnInd { get; set; }
//
//     [JsonProperty("PFStatusTermSect507b1AInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PFStatusTermSect507b1AInd")]
//     public string PFStatusTermSect507b1AInd { get; set; }
//
//     [JsonProperty("SpecialConditionDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SpecialConditionDesc")]
//     public string SpecialConditionDesc { get; set; }
//
//     [JsonProperty("PF60MonthTermSect507b1BInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PF60MonthTermSect507b1BInd")]
//     public string PF60MonthTermSect507b1BInd { get; set; }
//
//     [JsonProperty("NameChangeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NameChangeInd")]
//     public string NameChangeInd { get; set; }
//
//     [JsonProperty("Organization501c3TaxablePFInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization501c3TaxablePFInd")]
//     public string Organization501c3TaxablePFInd { get; set; }
//
//     [JsonProperty("ForeignOrganizationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignOrganizationInd")]
//     public string ForeignOrganizationInd { get; set; }
//
//     [JsonProperty("ForeignOrgMeeting85PctTestInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignOrgMeeting85PctTestInd")]
//     public string ForeignOrgMeeting85PctTestInd { get; set; }
//
//     [JsonProperty("@accountingPeriodChangeCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@accountingPeriodChangeCd")]
//     public string AccountingPeriodChangeCd { get; set; }
//
//     [JsonProperty("@accountingPeriodChangeApprvCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@accountingPeriodChangeApprvCd")]
//     public string AccountingPeriodChangeApprvCd { get; set; }
// }
//
// public class IRS990ScheduleA
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("PubliclySupportedOrg509a2Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PubliclySupportedOrg509a2Ind")]
//     public string PubliclySupportedOrg509a2Ind { get; set; }
//
//     [JsonProperty("GiftsGrantsContrisRcvd509Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GiftsGrantsContrisRcvd509Grp")]
//     public GiftsGrantsContrisRcvd509Grp GiftsGrantsContrisRcvd509Grp { get; set; }
//
//     [JsonProperty("Total509Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Total509Grp")]
//     public Total509Grp Total509Grp { get; set; }
//
//     [JsonProperty("PublicSupportTotal509Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PublicSupportTotal509Amt")]
//     public string PublicSupportTotal509Amt { get; set; }
//
//     [JsonProperty("TotalSupportCalendarYearGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalSupportCalendarYearGrp")]
//     public TotalSupportCalendarYearGrp TotalSupportCalendarYearGrp { get; set; }
//
//     [JsonProperty("PublicSupportCY509Pct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PublicSupportCY509Pct")]
//     public string PublicSupportCY509Pct { get; set; }
//
//     [JsonProperty("InvestmentIncomeCYPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentIncomeCYPct")]
//     public string InvestmentIncomeCYPct { get; set; }
//
//     [JsonProperty("InvestmentIncomePYPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentIncomePYPct")]
//     public string InvestmentIncomePYPct { get; set; }
//
//     [JsonProperty("ThirtyThrPctSuprtTestsCY509Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ThirtyThrPctSuprtTestsCY509Ind")]
//     public string ThirtyThrPctSuprtTestsCY509Ind { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("GrossReceiptsAdmissionsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossReceiptsAdmissionsGrp")]
//     public GrossReceiptsAdmissionsGrp GrossReceiptsAdmissionsGrp { get; set; }
//
//     [JsonProperty("GrossReceiptsNonUnrltBusGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossReceiptsNonUnrltBusGrp")]
//     public GrossReceiptsNonUnrltBusGrp GrossReceiptsNonUnrltBusGrp { get; set; }
//
//     [JsonProperty("TaxRevLeviedOrgnztnlBnft509Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxRevLeviedOrgnztnlBnft509Grp")]
//     public TaxRevLeviedOrgnztnlBnft509Grp TaxRevLeviedOrgnztnlBnft509Grp { get; set; }
//
//     [JsonProperty("GovtFurnSrvcFcltsVl509Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GovtFurnSrvcFcltsVl509Grp")]
//     public GovtFurnSrvcFcltsVl509Grp GovtFurnSrvcFcltsVl509Grp { get; set; }
//
//     [JsonProperty("AmountsRcvdDsqlfyPersonGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AmountsRcvdDsqlfyPersonGrp")]
//     public AmountsRcvdDsqlfyPersonGrp AmountsRcvdDsqlfyPersonGrp { get; set; }
//
//     [JsonProperty("SubstantialContributorsAmtGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubstantialContributorsAmtGrp")]
//     public SubstantialContributorsAmtGrp SubstantialContributorsAmtGrp { get; set; }
//
//     [JsonProperty("GrossInvestmentIncome509Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossInvestmentIncome509Grp")]
//     public GrossInvestmentIncome509Grp GrossInvestmentIncome509Grp { get; set; }
//
//     [JsonProperty("Post1975UBTIGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Post1975UBTIGrp")]
//     public Post1975UBTIGrp Post1975UBTIGrp { get; set; }
//
//     [JsonProperty("NetIncomeFromOtherUBIGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetIncomeFromOtherUBIGrp")]
//     public NetIncomeFromOtherUBIGrp NetIncomeFromOtherUBIGrp { get; set; }
//
//     [JsonProperty("OtherIncome509Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherIncome509Grp")]
//     public OtherIncome509Grp OtherIncome509Grp { get; set; }
//
//     [JsonProperty("First5Years509Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("First5Years509Ind")]
//     public string First5Years509Ind { get; set; }
//
//     [JsonProperty("SubstAndDsqlfyPrsnsTotGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubstAndDsqlfyPrsnsTotGrp")]
//     public SubstAndDsqlfyPrsnsTotGrp SubstAndDsqlfyPrsnsTotGrp { get; set; }
//
//     [JsonProperty("InvestmentIncomeAndUBTIGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentIncomeAndUBTIGrp")]
//     public InvestmentIncomeAndUBTIGrp InvestmentIncomeAndUBTIGrp { get; set; }
//
//     [JsonProperty("PublicSupportPY509Pct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PublicSupportPY509Pct")]
//     public string PublicSupportPY509Pct { get; set; }
//
//     [JsonProperty("Form990ScheduleAPartVIGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form990ScheduleAPartVIGrp")]
//     public Form990ScheduleAPartVIGrp Form990ScheduleAPartVIGrp { get; set; }
//
//     [JsonProperty("PublicOrganization170Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PublicOrganization170Ind")]
//     public string PublicOrganization170Ind { get; set; }
//
//     [JsonProperty("GiftsGrantsContriRcvd170Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GiftsGrantsContriRcvd170Grp")]
//     public GiftsGrantsContriRcvd170Grp GiftsGrantsContriRcvd170Grp { get; set; }
//
//     [JsonProperty("TaxRevLeviedOrgnztnlBnft170Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxRevLeviedOrgnztnlBnft170Grp")]
//     public TaxRevLeviedOrgnztnlBnft170Grp TaxRevLeviedOrgnztnlBnft170Grp { get; set; }
//
//     [JsonProperty("TotalCalendarYear170Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCalendarYear170Grp")]
//     public TotalCalendarYear170Grp TotalCalendarYear170Grp { get; set; }
//
//     [JsonProperty("PublicSupportTotal170Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PublicSupportTotal170Amt")]
//     public string PublicSupportTotal170Amt { get; set; }
//
//     [JsonProperty("GrossInvestmentIncome170Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossInvestmentIncome170Grp")]
//     public GrossInvestmentIncome170Grp GrossInvestmentIncome170Grp { get; set; }
//
//     [JsonProperty("UnrelatedBusinessNetIncm170Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessNetIncm170Grp")]
//     public UnrelatedBusinessNetIncm170Grp UnrelatedBusinessNetIncm170Grp { get; set; }
//
//     [JsonProperty("OtherIncome170Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherIncome170Grp")]
//     public OtherIncome170Grp OtherIncome170Grp { get; set; }
//
//     [JsonProperty("TotalSupportAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalSupportAmt")]
//     public string TotalSupportAmt { get; set; }
//
//     [JsonProperty("GrossReceiptsRltdActivitiesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossReceiptsRltdActivitiesAmt")]
//     public string GrossReceiptsRltdActivitiesAmt { get; set; }
//
//     [JsonProperty("First5Years170Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("First5Years170Ind")]
//     public string First5Years170Ind { get; set; }
//
//     [JsonProperty("PublicSupportCY170Pct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PublicSupportCY170Pct")]
//     public string PublicSupportCY170Pct { get; set; }
//
//     [JsonProperty("ThirtyThrPctSuprtTestsCY170Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ThirtyThrPctSuprtTestsCY170Ind")]
//     public string ThirtyThrPctSuprtTestsCY170Ind { get; set; }
//
//     [JsonProperty("SubstantialContributorsTotAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubstantialContributorsTotAmt")]
//     public string SubstantialContributorsTotAmt { get; set; }
//
//     [JsonProperty("PublicSupportPY170Pct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PublicSupportPY170Pct")]
//     public string PublicSupportPY170Pct { get; set; }
//
//     [JsonProperty("GovtFurnSrvcFcltsVl170Grp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GovtFurnSrvcFcltsVl170Grp")]
//     public GovtFurnSrvcFcltsVl170Grp GovtFurnSrvcFcltsVl170Grp { get; set; }
//
//     [JsonProperty("SupportingOrganization509a3Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportingOrganization509a3Ind")]
//     public string SupportingOrganization509a3Ind { get; set; }
//
//     [JsonProperty("SupportingOrgType1Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportingOrgType1Ind")]
//     public string SupportingOrgType1Ind { get; set; }
//
//     [JsonProperty("SupportedOrganizationsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportedOrganizationsCnt")]
//     public string SupportedOrganizationsCnt { get; set; }
//
//     [JsonProperty("SupportedOrgInformationGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportedOrgInformationGrp")]
//     public SupportedOrgInformationGrp SupportedOrgInformationGrp { get; set; }
//
//     [JsonProperty("SupportedOrganizationsTotalCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportedOrganizationsTotalCnt")]
//     public string SupportedOrganizationsTotalCnt { get; set; }
//
//     [JsonProperty("SupportSumAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportSumAmt")]
//     public string SupportSumAmt { get; set; }
//
//     [JsonProperty("OtherSupportSumAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherSupportSumAmt")]
//     public string OtherSupportSumAmt { get; set; }
//
//     [JsonProperty("Form990SchASupportingOrgGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form990SchASupportingOrgGrp")]
//     public Form990SchASupportingOrgGrp Form990SchASupportingOrgGrp { get; set; }
//
//     [JsonProperty("Form990SchAType1SuprtOrgGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form990SchAType1SuprtOrgGrp")]
//     public Form990SchAType1SuprtOrgGrp Form990SchAType1SuprtOrgGrp { get; set; }
//
//     [JsonProperty("TenPctFactsCrcmstncsTestCYInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TenPctFactsCrcmstncsTestCYInd")]
//     public string TenPctFactsCrcmstncsTestCYInd { get; set; }
//
//     [JsonProperty("HospitalInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HospitalInd")]
//     public string HospitalInd { get; set; }
//
//     [JsonProperty("SupportingOrgType3NonFuncInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportingOrgType3NonFuncInd")]
//     public string SupportingOrgType3NonFuncInd { get; set; }
//
//     [JsonProperty("Form990SchAType3SprtOrgAllGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form990SchAType3SprtOrgAllGrp")]
//     public Form990SchAType3SprtOrgAllGrp Form990SchAType3SprtOrgAllGrp { get; set; }
//
//     [JsonProperty("AdjustedNetIncomeGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedNetIncomeGrp")]
//     public AdjustedNetIncomeGrp AdjustedNetIncomeGrp { get; set; }
//
//     [JsonProperty("MinimumAssetAmountGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MinimumAssetAmountGrp")]
//     public MinimumAssetAmountGrp MinimumAssetAmountGrp { get; set; }
//
//     [JsonProperty("DistributableAmountGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributableAmountGrp")]
//     public DistributableAmountGrp DistributableAmountGrp { get; set; }
//
//     [JsonProperty("DistributionsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributionsGrp")]
//     public DistributionsGrp DistributionsGrp { get; set; }
//
//     [JsonProperty("DistributionAllocationsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributionAllocationsGrp")]
//     public DistributionAllocationsGrp DistributionAllocationsGrp { get; set; }
//
//     [JsonProperty("ChurchInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ChurchInd")]
//     public string ChurchInd { get; set; }
//
//     [JsonProperty("ThirtyThrPctSuprtTestsPY509Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ThirtyThrPctSuprtTestsPY509Ind")]
//     public string ThirtyThrPctSuprtTestsPY509Ind { get; set; }
//
//     [JsonProperty("GovernmentalUnitInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GovernmentalUnitInd")]
//     public string GovernmentalUnitInd { get; set; }
//
//     [JsonProperty("SchoolInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SchoolInd")]
//     public string SchoolInd { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("PrivateFoundation509Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrivateFoundation509Ind")]
//     public string PrivateFoundation509Ind { get; set; }
//
//     [JsonProperty("ThirtyThrPctSuprtTestsPY170Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ThirtyThrPctSuprtTestsPY170Ind")]
//     public string ThirtyThrPctSuprtTestsPY170Ind { get; set; }
//
//     [JsonProperty("IRSWrittenDeterminationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRSWrittenDeterminationInd")]
//     public string IRSWrittenDeterminationInd { get; set; }
//
//     [JsonProperty("SupportingOrgType3FuncIntInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportingOrgType3FuncIntInd")]
//     public string SupportingOrgType3FuncIntInd { get; set; }
//
//     [JsonProperty("Form990SchAType3FuncIntGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form990SchAType3FuncIntGrp")]
//     public string Form990SchAType3FuncIntGrp { get; set; }
//
//     [JsonProperty("FactsAndCircumstancesTestTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FactsAndCircumstancesTestTxt")]
//     public string FactsAndCircumstancesTestTxt { get; set; }
//
//     [JsonProperty("SupportingOrgType2Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportingOrgType2Ind")]
//     public string SupportingOrgType2Ind { get; set; }
//
//     [JsonProperty("MajorityDirTrstSupportedOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MajorityDirTrstSupportedOrgInd")]
//     public string MajorityDirTrstSupportedOrgInd { get; set; }
//
//     [JsonProperty("CollegeOrganizationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CollegeOrganizationInd")]
//     public string CollegeOrganizationInd { get; set; }
//
//     [JsonProperty("CommunityTrustInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CommunityTrustInd")]
//     public string CommunityTrustInd { get; set; }
//
//     [JsonProperty("PrivateFoundation170Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrivateFoundation170Ind")]
//     public string PrivateFoundation170Ind { get; set; }
//
//     [JsonProperty("MedicalResearchOrganizationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MedicalResearchOrganizationInd")]
//     public string MedicalResearchOrganizationInd { get; set; }
//
//     [JsonProperty("HospitalNameAndAddressGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HospitalNameAndAddressGrp")]
//     public HospitalNameAndAddressGrp HospitalNameAndAddressGrp { get; set; }
//
//     [JsonProperty("TenPctFactsCrcmstncsTestPYInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TenPctFactsCrcmstncsTestPYInd")]
//     public string TenPctFactsCrcmstncsTestPYInd { get; set; }
//
//     [JsonProperty("TrustIntegralPartTestInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TrustIntegralPartTestInd")]
//     public string TrustIntegralPartTestInd { get; set; }
//
//     [JsonProperty("TestPublicSafetyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TestPublicSafetyInd")]
//     public string TestPublicSafetyInd { get; set; }
//
//     [JsonProperty("AgriculturalResearchOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AgriculturalResearchOrgInd")]
//     public string AgriculturalResearchOrgInd { get; set; }
//
//     [JsonProperty("AgriculturalNameAndAddressGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AgriculturalNameAndAddressGrp")]
//     public AgriculturalNameAndAddressGrp AgriculturalNameAndAddressGrp { get; set; }
// }
//
// public class IRS990ScheduleB
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("Organization501c3ExemptPFInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization501c3ExemptPFInd")]
//     public string Organization501c3ExemptPFInd { get; set; }
//
//     [JsonProperty("GeneralRuleInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GeneralRuleInd")]
//     public string GeneralRuleInd { get; set; }
//
//     [JsonProperty("ContributorInformationGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributorInformationGrp")]
//     public ContributorInformationGrp ContributorInformationGrp { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("NonCashPropertyContributionGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashPropertyContributionGrp")]
//     public List<NonCashPropertyContributionGrp> NonCashPropertyContributionGrp { get; } =
//         new List<NonCashPropertyContributionGrp>();
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("Organization4947a1TrtdPFInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization4947a1TrtdPFInd")]
//     public string Organization4947a1TrtdPFInd { get; set; }
//
//     [JsonProperty("CharitableContributionsDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CharitableContributionsDetail")]
//     public CharitableContributionsDetail CharitableContributionsDetail { get; set; }
//
//     [JsonProperty("Organization501c3TaxablePFInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization501c3TaxablePFInd")]
//     public string Organization501c3TaxablePFInd { get; set; }
//
//     [JsonProperty("Organization501cInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization501cInd")]
//     public Organization501cInd Organization501cInd { get; set; }
//
//     [JsonProperty("TotalUnder1000ContributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalUnder1000ContributionsAmt")]
//     public string TotalUnder1000ContributionsAmt { get; set; }
// }
//
// public class IRS990ScheduleC
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("VolunteersInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("VolunteersInd")]
//     public string VolunteersInd { get; set; }
//
//     [JsonProperty("PaidStaffOrManagementInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PaidStaffOrManagementInd")]
//     public string PaidStaffOrManagementInd { get; set; }
//
//     [JsonProperty("MediaAdvertisementsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MediaAdvertisementsInd")]
//     public string MediaAdvertisementsInd { get; set; }
//
//     [JsonProperty("MailingsMembersInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MailingsMembersInd")]
//     public string MailingsMembersInd { get; set; }
//
//     [JsonProperty("PublicationsOrBroadcastInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PublicationsOrBroadcastInd")]
//     public string PublicationsOrBroadcastInd { get; set; }
//
//     [JsonProperty("GrantsOtherOrganizationsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsOtherOrganizationsInd")]
//     public string GrantsOtherOrganizationsInd { get; set; }
//
//     [JsonProperty("DirectContactLegislatorsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectContactLegislatorsInd")]
//     public string DirectContactLegislatorsInd { get; set; }
//
//     [JsonProperty("RalliesDemonstrationsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RalliesDemonstrationsInd")]
//     public string RalliesDemonstrationsInd { get; set; }
//
//     [JsonProperty("OtherActivitiesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherActivitiesInd")]
//     public string OtherActivitiesInd { get; set; }
//
//     [JsonProperty("NotDescribedSection501c3Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NotDescribedSection501c3Ind")]
//     public string NotDescribedSection501c3Ind { get; set; }
//
//     [JsonProperty("SubstantiallyAllDuesNondedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubstantiallyAllDuesNondedInd")]
//     public string SubstantiallyAllDuesNondedInd { get; set; }
//
//     [JsonProperty("OnlyInHouseLobbyingInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OnlyInHouseLobbyingInd")]
//     public string OnlyInHouseLobbyingInd { get; set; }
//
//     [JsonProperty("AgreeCarryoverPriorYearInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AgreeCarryoverPriorYearInd")]
//     public string AgreeCarryoverPriorYearInd { get; set; }
//
//     [JsonProperty("SupplementalInformationDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupplementalInformationDetail")]
//     public SupplementalInformationDetail SupplementalInformationDetail { get; set; }
//
//     [JsonProperty("MailingsMembersAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MailingsMembersAmt")]
//     public string MailingsMembersAmt { get; set; }
//
//     [JsonProperty("PublicationsOrBroadcastAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PublicationsOrBroadcastAmt")]
//     public string PublicationsOrBroadcastAmt { get; set; }
//
//     [JsonProperty("DirectContactLegislatorsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectContactLegislatorsAmt")]
//     public string DirectContactLegislatorsAmt { get; set; }
//
//     [JsonProperty("TotalLobbyingExpendituresAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalLobbyingExpendituresAmt")]
//     public string TotalLobbyingExpendituresAmt { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("Form4720FiledSection4955TaxInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form4720FiledSection4955TaxInd")]
//     public string Form4720FiledSection4955TaxInd { get; set; }
//
//     [JsonProperty("CorrectionMadeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CorrectionMadeInd")]
//     public string CorrectionMadeInd { get; set; }
//
//     [JsonProperty("Form4720FiledInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form4720FiledInd")]
//     public string Form4720FiledInd { get; set; }
//
//     [JsonProperty("DuesAssessmentsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DuesAssessmentsAmt")]
//     public string DuesAssessmentsAmt { get; set; }
//
//     [JsonProperty("NonDeductibleLbbyngPltclCYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonDeductibleLbbyngPltclCYAmt")]
//     public string NonDeductibleLbbyngPltclCYAmt { get; set; }
//
//     [JsonProperty("NonDeductibleLbbyngPltclTotAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonDeductibleLbbyngPltclTotAmt")]
//     public string NonDeductibleLbbyngPltclTotAmt { get; set; }
//
//     [JsonProperty("AggregateReportedDuesNtcAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AggregateReportedDuesNtcAmt")]
//     public string AggregateReportedDuesNtcAmt { get; set; }
//
//     [JsonProperty("TaxableAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxableAmt")]
//     public string TaxableAmt { get; set; }
//
//     [JsonProperty("Form1120POLFiledInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form1120POLFiledInd")]
//     public string Form1120POLFiledInd { get; set; }
//
//     [JsonProperty("TotalGrassrootsLobbyingGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalGrassrootsLobbyingGrp")]
//     public TotalGrassrootsLobbyingGrp TotalGrassrootsLobbyingGrp { get; set; }
//
//     [JsonProperty("TotalDirectLobbyingGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalDirectLobbyingGrp")]
//     public TotalDirectLobbyingGrp TotalDirectLobbyingGrp { get; set; }
//
//     [JsonProperty("TotalLobbyingExpendGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalLobbyingExpendGrp")]
//     public TotalLobbyingExpendGrp TotalLobbyingExpendGrp { get; set; }
//
//     [JsonProperty("OtherExemptPurposeExpendGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherExemptPurposeExpendGrp")]
//     public OtherExemptPurposeExpendGrp OtherExemptPurposeExpendGrp { get; set; }
//
//     [JsonProperty("TotalExemptPurposeExpendGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExemptPurposeExpendGrp")]
//     public TotalExemptPurposeExpendGrp TotalExemptPurposeExpendGrp { get; set; }
//
//     [JsonProperty("LobbyingNontaxableAmountGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LobbyingNontaxableAmountGrp")]
//     public LobbyingNontaxableAmountGrp LobbyingNontaxableAmountGrp { get; set; }
//
//     [JsonProperty("GrassrootsNontaxableGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrassrootsNontaxableGrp")]
//     public GrassrootsNontaxableGrp GrassrootsNontaxableGrp { get; set; }
//
//     [JsonProperty("TotLbbyngGrassrootMnsNonTxGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotLbbyngGrassrootMnsNonTxGrp")]
//     public TotLbbyngGrassrootMnsNonTxGrp TotLbbyngGrassrootMnsNonTxGrp { get; set; }
//
//     [JsonProperty("TotLbbyExpendMnsLbbyngNonTxGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotLbbyExpendMnsLbbyngNonTxGrp")]
//     public TotLbbyExpendMnsLbbyngNonTxGrp TotLbbyExpendMnsLbbyngNonTxGrp { get; set; }
//
//     [JsonProperty("RalliesDemonstrationsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RalliesDemonstrationsAmt")]
//     public string RalliesDemonstrationsAmt { get; set; }
//
//     [JsonProperty("OtherActivitiesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherActivitiesAmt")]
//     public string OtherActivitiesAmt { get; set; }
//
//     [JsonProperty("MediaAdvertisementsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MediaAdvertisementsAmt")]
//     public string MediaAdvertisementsAmt { get; set; }
//
//     [JsonProperty("AvgLobbyingNontaxableAmountGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AvgLobbyingNontaxableAmountGrp")]
//     public AvgLobbyingNontaxableAmountGrp AvgLobbyingNontaxableAmountGrp { get; set; }
//
//     [JsonProperty("LobbyingCeilingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LobbyingCeilingAmt")]
//     public string LobbyingCeilingAmt { get; set; }
//
//     [JsonProperty("AvgTotalLobbyingExpendGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AvgTotalLobbyingExpendGrp")]
//     public AvgTotalLobbyingExpendGrp AvgTotalLobbyingExpendGrp { get; set; }
//
//     [JsonProperty("AvgGrassrootsNontaxableGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AvgGrassrootsNontaxableGrp")]
//     public AvgGrassrootsNontaxableGrp AvgGrassrootsNontaxableGrp { get; set; }
//
//     [JsonProperty("GrassrootsCeilingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrassrootsCeilingAmt")]
//     public string GrassrootsCeilingAmt { get; set; }
//
//     [JsonProperty("AvgGrassrootsLobbyingExpendGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AvgGrassrootsLobbyingExpendGrp")]
//     public AvgGrassrootsLobbyingExpendGrp AvgGrassrootsLobbyingExpendGrp { get; set; }
//
//     [JsonProperty("Expended527ActivitiesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Expended527ActivitiesAmt")]
//     public string Expended527ActivitiesAmt { get; set; }
//
//     [JsonProperty("TotalExemptFunctionExpendAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExemptFunctionExpendAmt")]
//     public string TotalExemptFunctionExpendAmt { get; set; }
//
//     [JsonProperty("PoliticalExpendituresAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PoliticalExpendituresAmt")]
//     public string PoliticalExpendituresAmt { get; set; }
//
//     [JsonProperty("InternalFundsContributedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InternalFundsContributedAmt")]
//     public string InternalFundsContributedAmt { get; set; }
//
//     [JsonProperty("VolunteerHoursCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("VolunteerHoursCnt")]
//     public string VolunteerHoursCnt { get; set; }
//
//     [JsonProperty("Form4720Filed4912TaxInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form4720Filed4912TaxInd")]
//     public string Form4720Filed4912TaxInd { get; set; }
//
//     [JsonProperty("NonDedLbbyngPltclCyovAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonDedLbbyngPltclCyovAmt")]
//     public string NonDedLbbyngPltclCyovAmt { get; set; }
//
//     [JsonProperty("CarriedOverAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CarriedOverAmt")]
//     public string CarriedOverAmt { get; set; }
//
//     [JsonProperty("OrganizationBelongsAffltGrpInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrganizationBelongsAffltGrpInd")]
//     public OrganizationBelongsAffltGrpInd OrganizationBelongsAffltGrpInd { get; set; }
//
//     [JsonProperty("GrantsOtherOrganizationsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsOtherOrganizationsAmt")]
//     public string GrantsOtherOrganizationsAmt { get; set; }
//
//     [JsonProperty("Section527PoliticalOrgGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Section527PoliticalOrgGrp")]
//     public Section527PoliticalOrgGrp Section527PoliticalOrgGrp { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("Section4955OrganizationTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Section4955OrganizationTaxAmt")]
//     public string Section4955OrganizationTaxAmt { get; set; }
//
//     [JsonProperty("Section4955ManagersTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Section4955ManagersTaxAmt")]
//     public string Section4955ManagersTaxAmt { get; set; }
//
//     [JsonProperty("LimitedControlProvisionsAppInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LimitedControlProvisionsAppInd")]
//     public string LimitedControlProvisionsAppInd { get; set; }
// }
//
// public class IRS990ScheduleD
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("TotalBookValueLandBuildingsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalBookValueLandBuildingsAmt")]
//     public string TotalBookValueLandBuildingsAmt { get; set; }
//
//     [JsonProperty("OtherSecuritiesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherSecuritiesGrp")]
//     public List<OtherSecuritiesGrp> OtherSecuritiesGrp { get; } = new List<OtherSecuritiesGrp>();
//
//     [JsonProperty("TotalBookValueSecuritiesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalBookValueSecuritiesAmt")]
//     public string TotalBookValueSecuritiesAmt { get; set; }
//
//     [JsonProperty("OtherLiabilitiesOrgGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherLiabilitiesOrgGrp")]
//     public OtherLiabilitiesOrgGrp OtherLiabilitiesOrgGrp { get; set; }
//
//     [JsonProperty("TotalLiabilityAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalLiabilityAmt")]
//     public string TotalLiabilityAmt { get; set; }
//
//     [JsonProperty("CYEndwmtFundGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYEndwmtFundGrp")]
//     public CYEndwmtFundGrp CYEndwmtFundGrp { get; set; }
//
//     [JsonProperty("CYMinus1YrEndwmtFundGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYMinus1YrEndwmtFundGrp")]
//     public CYMinus1YrEndwmtFundGrp CYMinus1YrEndwmtFundGrp { get; set; }
//
//     [JsonProperty("CYMinus2YrEndwmtFundGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYMinus2YrEndwmtFundGrp")]
//     public CYMinus2YrEndwmtFundGrp CYMinus2YrEndwmtFundGrp { get; set; }
//
//     [JsonProperty("CYMinus3YrEndwmtFundGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYMinus3YrEndwmtFundGrp")]
//     public CYMinus3YrEndwmtFundGrp CYMinus3YrEndwmtFundGrp { get; set; }
//
//     [JsonProperty("CYMinus4YrEndwmtFundGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYMinus4YrEndwmtFundGrp")]
//     public CYMinus4YrEndwmtFundGrp CYMinus4YrEndwmtFundGrp { get; set; }
//
//     [JsonProperty("BoardDesignatedBalanceEOYPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BoardDesignatedBalanceEOYPct")]
//     public string BoardDesignatedBalanceEOYPct { get; set; }
//
//     [JsonProperty("EndowmentsHeldUnrelatedOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EndowmentsHeldUnrelatedOrgInd")]
//     public string EndowmentsHeldUnrelatedOrgInd { get; set; }
//
//     [JsonProperty("EndowmentsHeldRelatedOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EndowmentsHeldRelatedOrgInd")]
//     public string EndowmentsHeldRelatedOrgInd { get; set; }
//
//     [JsonProperty("BuildingsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BuildingsGrp")]
//     public BuildingsGrp BuildingsGrp { get; set; }
//
//     [JsonProperty("FootnoteTextInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FootnoteTextInd")]
//     public string FootnoteTextInd { get; set; }
//
//     [JsonProperty("TotalRevEtcAuditedFinclStmtAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevEtcAuditedFinclStmtAmt")]
//     public string TotalRevEtcAuditedFinclStmtAmt { get; set; }
//
//     [JsonProperty("OtherRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherRevenueAmt")]
//     public string OtherRevenueAmt { get; set; }
//
//     [JsonProperty("RevenueNotReportedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RevenueNotReportedAmt")]
//     public string RevenueNotReportedAmt { get; set; }
//
//     [JsonProperty("RevenueSubtotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RevenueSubtotalAmt")]
//     public string RevenueSubtotalAmt { get; set; }
//
//     [JsonProperty("RevenueNotReportedFinclStmtAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RevenueNotReportedFinclStmtAmt")]
//     public string RevenueNotReportedFinclStmtAmt { get; set; }
//
//     [JsonProperty("TotalRevenuePerForm990Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevenuePerForm990Amt")]
//     public string TotalRevenuePerForm990Amt { get; set; }
//
//     [JsonProperty("TotExpnsEtcAuditedFinclStmtAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotExpnsEtcAuditedFinclStmtAmt")]
//     public string TotExpnsEtcAuditedFinclStmtAmt { get; set; }
//
//     [JsonProperty("OtherExpensesIncludedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherExpensesIncludedAmt")]
//     public string OtherExpensesIncludedAmt { get; set; }
//
//     [JsonProperty("ExpensesNotReportedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpensesNotReportedAmt")]
//     public string ExpensesNotReportedAmt { get; set; }
//
//     [JsonProperty("ExpensesSubtotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpensesSubtotalAmt")]
//     public string ExpensesSubtotalAmt { get; set; }
//
//     [JsonProperty("ExpensesNotRptFinclStmtAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpensesNotRptFinclStmtAmt")]
//     public string ExpensesNotRptFinclStmtAmt { get; set; }
//
//     [JsonProperty("TotalExpensesPerForm990Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensesPerForm990Amt")]
//     public string TotalExpensesPerForm990Amt { get; set; }
//
//     [JsonProperty("SupplementalInformationDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupplementalInformationDetail")]
//     public List<SupplementalInformationDetail> SupplementalInformationDetail { get; } =
//         new List<SupplementalInformationDetail>();
//
//     [JsonProperty("LandGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LandGrp")]
//     public LandGrp LandGrp { get; set; }
//
//     [JsonProperty("LeaseholdImprovementsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LeaseholdImprovementsGrp")]
//     public LeaseholdImprovementsGrp LeaseholdImprovementsGrp { get; set; }
//
//     [JsonProperty("EquipmentGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EquipmentGrp")]
//     public EquipmentGrp EquipmentGrp { get; set; }
//
//     [JsonProperty("OtherLandBuildingsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherLandBuildingsGrp")]
//     public OtherLandBuildingsGrp OtherLandBuildingsGrp { get; set; }
//
//     [JsonProperty("OtherAssetsOrgGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherAssetsOrgGrp")]
//     public OtherAssetsOrgGrp OtherAssetsOrgGrp { get; set; }
//
//     [JsonProperty("TotalBookValueOtherAssetsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalBookValueOtherAssetsAmt")]
//     public string TotalBookValueOtherAssetsAmt { get; set; }
//
//     [JsonProperty("DonorAdvisedFundsHeldCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DonorAdvisedFundsHeldCnt")]
//     public string DonorAdvisedFundsHeldCnt { get; set; }
//
//     [JsonProperty("DonorAdvisedFundsContriAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DonorAdvisedFundsContriAmt")]
//     public string DonorAdvisedFundsContriAmt { get; set; }
//
//     [JsonProperty("DonorAdvisedFundsGrantsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DonorAdvisedFundsGrantsAmt")]
//     public string DonorAdvisedFundsGrantsAmt { get; set; }
//
//     [JsonProperty("DonorAdvisedFundsVlEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DonorAdvisedFundsVlEOYAmt")]
//     public string DonorAdvisedFundsVlEOYAmt { get; set; }
//
//     [JsonProperty("DisclosedOrgLegCtrlInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisclosedOrgLegCtrlInd")]
//     public string DisclosedOrgLegCtrlInd { get; set; }
//
//     [JsonProperty("DisclosedForCharitablePrpsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisclosedForCharitablePrpsInd")]
//     public string DisclosedForCharitablePrpsInd { get; set; }
//
//     [JsonProperty("NetUnrealizedGainsInvstAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetUnrealizedGainsInvstAmt")]
//     public string NetUnrealizedGainsInvstAmt { get; set; }
//
//     [JsonProperty("InvestmentExpensesNotIncldAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentExpensesNotIncldAmt")]
//     public string InvestmentExpensesNotIncldAmt { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("InclEscrowCustodialAcctLiabInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InclEscrowCustodialAcctLiabInd")]
//     public string InclEscrowCustodialAcctLiabInd { get; set; }
//
//     [JsonProperty("CollectionUsedPreservationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CollectionUsedPreservationInd")]
//     public string CollectionUsedPreservationInd { get; set; }
//
//     [JsonProperty("SolicitedAssetsSaleInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SolicitedAssetsSaleInd")]
//     public string SolicitedAssetsSaleInd { get; set; }
//
//     [JsonProperty("PrmnntEndowmentBalanceEOYPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrmnntEndowmentBalanceEOYPct")]
//     public string PrmnntEndowmentBalanceEOYPct { get; set; }
//
//     [JsonProperty("TermEndowmentBalanceEOYPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TermEndowmentBalanceEOYPct")]
//     public string TermEndowmentBalanceEOYPct { get; set; }
//
//     [JsonProperty("DonatedServicesAndUseFcltsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DonatedServicesAndUseFcltsAmt")]
//     public string DonatedServicesAndUseFcltsAmt { get; set; }
//
//     [JsonProperty("DonatedServicesUseFcltsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DonatedServicesUseFcltsAmt")]
//     public string DonatedServicesUseFcltsAmt { get; set; }
//
//     [JsonProperty("AgentTrusteeEtcInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AgentTrusteeEtcInd")]
//     public string AgentTrusteeEtcInd { get; set; }
//
//     [JsonProperty("BeginningBalanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BeginningBalanceAmt")]
//     public string BeginningBalanceAmt { get; set; }
//
//     [JsonProperty("AdditionsDuringYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdditionsDuringYearAmt")]
//     public string AdditionsDuringYearAmt { get; set; }
//
//     [JsonProperty("DistributionsDuringYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributionsDuringYearAmt")]
//     public string DistributionsDuringYearAmt { get; set; }
//
//     [JsonProperty("EndingBalanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EndingBalanceAmt")]
//     public string EndingBalanceAmt { get; set; }
//
//     [JsonProperty("InvestmentExpensesNotIncld2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentExpensesNotIncld2Amt")]
//     public string InvestmentExpensesNotIncld2Amt { get; set; }
//
//     [JsonProperty("ExplanationProvidedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExplanationProvidedInd")]
//     public string ExplanationProvidedInd { get; set; }
//
//     [JsonProperty("OtherExpensesNotIncludedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherExpensesNotIncludedAmt")]
//     public string OtherExpensesNotIncludedAmt { get; set; }
//
//     [JsonProperty("FundsAndOtherAccountsHeldCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundsAndOtherAccountsHeldCnt")]
//     public string FundsAndOtherAccountsHeldCnt { get; set; }
//
//     [JsonProperty("FundsAndOtherAccountsContriAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundsAndOtherAccountsContriAmt")]
//     public string FundsAndOtherAccountsContriAmt { get; set; }
//
//     [JsonProperty("FundsAndOtherAccountsGrantsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundsAndOtherAccountsGrantsAmt")]
//     public string FundsAndOtherAccountsGrantsAmt { get; set; }
//
//     [JsonProperty("FundsAndOtherAccountsVlEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundsAndOtherAccountsVlEOYAmt")]
//     public string FundsAndOtherAccountsVlEOYAmt { get; set; }
//
//     [JsonProperty("CollectionUsedPubExhibitionInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CollectionUsedPubExhibitionInd")]
//     public string CollectionUsedPubExhibitionInd { get; set; }
//
//     [JsonProperty("CollUsedLoanOrExchProgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CollUsedLoanOrExchProgInd")]
//     public string CollUsedLoanOrExchProgInd { get; set; }
//
//     [JsonProperty("CollectionUsedOtherPurposesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CollectionUsedOtherPurposesGrp")]
//     public CollectionUsedOtherPurposesGrp CollectionUsedOtherPurposesGrp { get; set; }
//
//     [JsonProperty("PreservationPublicUseInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PreservationPublicUseInd")]
//     public string PreservationPublicUseInd { get; set; }
//
//     [JsonProperty("PreservationOpenSpaceInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PreservationOpenSpaceInd")]
//     public string PreservationOpenSpaceInd { get; set; }
//
//     [JsonProperty("TotalEasementsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalEasementsCnt")]
//     public string TotalEasementsCnt { get; set; }
//
//     [JsonProperty("TotalAcreageCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAcreageCnt")]
//     public string TotalAcreageCnt { get; set; }
//
//     [JsonProperty("StatesEasementsHeldCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StatesEasementsHeldCnt")]
//     public string StatesEasementsHeldCnt { get; set; }
//
//     [JsonProperty("WrittenPolicyMonitoringInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("WrittenPolicyMonitoringInd")]
//     public string WrittenPolicyMonitoringInd { get; set; }
//
//     [JsonProperty("OtherRevenuesNotIncludedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherRevenuesNotIncludedAmt")]
//     public string OtherRevenuesNotIncludedAmt { get; set; }
//
//     [JsonProperty("Section170hRqrStsfdInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Section170hRqrStsfdInd")]
//     public string Section170hRqrStsfdInd { get; set; }
//
//     [JsonProperty("ArtPublicExhibitionAmountsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ArtPublicExhibitionAmountsGrp")]
//     public ArtPublicExhibitionAmountsGrp ArtPublicExhibitionAmountsGrp { get; set; }
//
//     [JsonProperty("HeldWorksArtGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HeldWorksArtGrp")]
//     public HeldWorksArtGrp HeldWorksArtGrp { get; set; }
//
//     [JsonProperty("FederalIncomeTaxLiabilityAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FederalIncomeTaxLiabilityAmt")]
//     public string FederalIncomeTaxLiabilityAmt { get; set; }
//
//     [JsonProperty("RelatedOrgListSchRInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrgListSchRInd")]
//     public string RelatedOrgListSchRInd { get; set; }
//
//     [JsonProperty("FinancialDerivativesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FinancialDerivativesGrp")]
//     public string FinancialDerivativesGrp { get; set; }
//
//     [JsonProperty("CloselyHeldEquityInterestsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CloselyHeldEquityInterestsGrp")]
//     public string CloselyHeldEquityInterestsGrp { get; set; }
//
//     [JsonProperty("InvstProgramRelatedOrgGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvstProgramRelatedOrgGrp")]
//     public List<InvstProgramRelatedOrgGrp> InvstProgramRelatedOrgGrp { get; } = new List<InvstProgramRelatedOrgGrp>();
//
//     [JsonProperty("TotalBookValueProgramRltdAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalBookValueProgramRltdAmt")]
//     public string TotalBookValueProgramRltdAmt { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("CollUsedScholarlyRsrchInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CollUsedScholarlyRsrchInd")]
//     public string CollUsedScholarlyRsrchInd { get; set; }
//
//     [JsonProperty("RecoveriesPriorYearGrantsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecoveriesPriorYearGrantsAmt")]
//     public string RecoveriesPriorYearGrantsAmt { get; set; }
//
//     [JsonProperty("PriorYearAdjustmentsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAdjustmentsAmt")]
//     public string PriorYearAdjustmentsAmt { get; set; }
//
//     [JsonProperty("LossesReportedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LossesReportedAmt")]
//     public string LossesReportedAmt { get; set; }
//
//     [JsonProperty("HistoricStructureInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HistoricStructureInd")]
//     public string HistoricStructureInd { get; set; }
//
//     [JsonProperty("HistoricStructureEasementsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HistoricStructureEasementsCnt")]
//     public string HistoricStructureEasementsCnt { get; set; }
//
//     [JsonProperty("HistoricStrctrEasementsAftrCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HistoricStrctrEasementsAftrCnt")]
//     public string HistoricStrctrEasementsAftrCnt { get; set; }
//
//     [JsonProperty("ModifiedEasementsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ModifiedEasementsCnt")]
//     public string ModifiedEasementsCnt { get; set; }
//
//     [JsonProperty("StaffHoursSpentEnforcementCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StaffHoursSpentEnforcementCnt")]
//     public string StaffHoursSpentEnforcementCnt { get; set; }
//
//     [JsonProperty("ExpensesIncurredEnforcementAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpensesIncurredEnforcementAmt")]
//     public string ExpensesIncurredEnforcementAmt { get; set; }
//
//     [JsonProperty("ProtectionNaturalHabitatInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProtectionNaturalHabitatInd")]
//     public string ProtectionNaturalHabitatInd { get; set; }
//
//     [JsonProperty("HistoricLandAreaInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HistoricLandAreaInd")]
//     public string HistoricLandAreaInd { get; set; }
// }
//
// public class IRS990ScheduleE
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("NondiscriminatoryPolicyStmtInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NondiscriminatoryPolicyStmtInd")]
//     public string NondiscriminatoryPolicyStmtInd { get; set; }
//
//     [JsonProperty("PolicyStmtInBrochuresEtcInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PolicyStmtInBrochuresEtcInd")]
//     public string PolicyStmtInBrochuresEtcInd { get; set; }
//
//     [JsonProperty("PlcyPblczdViaBroadcastMediaInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PlcyPblczdViaBroadcastMediaInd")]
//     public string PlcyPblczdViaBroadcastMediaInd { get; set; }
//
//     [JsonProperty("MaintainRacialCompRecsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MaintainRacialCompRecsInd")]
//     public string MaintainRacialCompRecsInd { get; set; }
//
//     [JsonProperty("MaintainScholarshipsRecsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MaintainScholarshipsRecsInd")]
//     public string MaintainScholarshipsRecsInd { get; set; }
//
//     [JsonProperty("MaintainCpyOfBrochuresEtcInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MaintainCpyOfBrochuresEtcInd")]
//     public string MaintainCpyOfBrochuresEtcInd { get; set; }
//
//     [JsonProperty("MaintainCpyOfAllSolInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MaintainCpyOfAllSolInd")]
//     public string MaintainCpyOfAllSolInd { get; set; }
//
//     [JsonProperty("DiscriminateRaceStdntsRghtsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DiscriminateRaceStdntsRghtsInd")]
//     public string DiscriminateRaceStdntsRghtsInd { get; set; }
//
//     [JsonProperty("DiscriminateRaceAdmissPlcyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DiscriminateRaceAdmissPlcyInd")]
//     public string DiscriminateRaceAdmissPlcyInd { get; set; }
//
//     [JsonProperty("DiscriminateRaceEmplmFcultyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DiscriminateRaceEmplmFcultyInd")]
//     public string DiscriminateRaceEmplmFcultyInd { get; set; }
//
//     [JsonProperty("DiscriminateRaceSchsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DiscriminateRaceSchsInd")]
//     public string DiscriminateRaceSchsInd { get; set; }
//
//     [JsonProperty("DiscriminateRaceEducPlcyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DiscriminateRaceEducPlcyInd")]
//     public string DiscriminateRaceEducPlcyInd { get; set; }
//
//     [JsonProperty("DiscriminateRaceUseOfFcltsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DiscriminateRaceUseOfFcltsInd")]
//     public string DiscriminateRaceUseOfFcltsInd { get; set; }
//
//     [JsonProperty("DiscriminateRaceAthltProgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DiscriminateRaceAthltProgInd")]
//     public string DiscriminateRaceAthltProgInd { get; set; }
//
//     [JsonProperty("DiscriminateRaceOtherActyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DiscriminateRaceOtherActyInd")]
//     public string DiscriminateRaceOtherActyInd { get; set; }
//
//     [JsonProperty("GovernmentFinancialAidRcvdInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GovernmentFinancialAidRcvdInd")]
//     public string GovernmentFinancialAidRcvdInd { get; set; }
//
//     [JsonProperty("GovernmentFinancialAidRvkdInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GovernmentFinancialAidRvkdInd")]
//     public string GovernmentFinancialAidRvkdInd { get; set; }
//
//     [JsonProperty("ComplianceWithRevProc7550Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ComplianceWithRevProc7550Ind")]
//     public string ComplianceWithRevProc7550Ind { get; set; }
//
//     [JsonProperty("SupplementalInformationDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupplementalInformationDetail")]
//     public SupplementalInformationDetail SupplementalInformationDetail { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
// }
//
// public class IRS990ScheduleF
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("GrantRecordsMaintainedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantRecordsMaintainedInd")]
//     public string GrantRecordsMaintainedInd { get; set; }
//
//     [JsonProperty("AccountActivitiesOutsideUSGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AccountActivitiesOutsideUSGrp")]
//     public AccountActivitiesOutsideUSGrp AccountActivitiesOutsideUSGrp { get; set; }
//
//     [JsonProperty("SubtotalOfficesCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubtotalOfficesCnt")]
//     public string SubtotalOfficesCnt { get; set; }
//
//     [JsonProperty("SubtotalEmployeesCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubtotalEmployeesCnt")]
//     public string SubtotalEmployeesCnt { get; set; }
//
//     [JsonProperty("ContinuationTotalOfficeCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContinuationTotalOfficeCnt")]
//     public string ContinuationTotalOfficeCnt { get; set; }
//
//     [JsonProperty("ContinuationTotalEmployeeCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContinuationTotalEmployeeCnt")]
//     public string ContinuationTotalEmployeeCnt { get; set; }
//
//     [JsonProperty("TotalOfficeCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalOfficeCnt")]
//     public string TotalOfficeCnt { get; set; }
//
//     [JsonProperty("TotalEmployeeCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalEmployeeCnt")]
//     public string TotalEmployeeCnt { get; set; }
//
//     [JsonProperty("SubtotalSpentAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubtotalSpentAmt")]
//     public string SubtotalSpentAmt { get; set; }
//
//     [JsonProperty("ContinuationSpentAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContinuationSpentAmt")]
//     public string ContinuationSpentAmt { get; set; }
//
//     [JsonProperty("TotalSpentAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalSpentAmt")]
//     public string TotalSpentAmt { get; set; }
//
//     [JsonProperty("GrantsToOrgOutsideUSGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsToOrgOutsideUSGrp")]
//     public List<GrantsToOrgOutsideUSGrp> GrantsToOrgOutsideUSGrp { get; } = new List<GrantsToOrgOutsideUSGrp>();
//
//     [JsonProperty("Total501c3OrgCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Total501c3OrgCnt")]
//     public string Total501c3OrgCnt { get; set; }
//
//     [JsonProperty("TotalOtherOrgCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalOtherOrgCnt")]
//     public string TotalOtherOrgCnt { get; set; }
//
//     [JsonProperty("TransferToForeignCorpInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransferToForeignCorpInd")]
//     public string TransferToForeignCorpInd { get; set; }
//
//     [JsonProperty("InterestInForeignTrustInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InterestInForeignTrustInd")]
//     public string InterestInForeignTrustInd { get; set; }
//
//     [JsonProperty("ForeignCorpOwnershipInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignCorpOwnershipInd")]
//     public string ForeignCorpOwnershipInd { get; set; }
//
//     [JsonProperty("PassiveForeignInvestmestCoInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PassiveForeignInvestmestCoInd")]
//     public string PassiveForeignInvestmestCoInd { get; set; }
//
//     [JsonProperty("ForeignPartnershipInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignPartnershipInd")]
//     public string ForeignPartnershipInd { get; set; }
//
//     [JsonProperty("BoycottCountriesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BoycottCountriesInd")]
//     public string BoycottCountriesInd { get; set; }
//
//     [JsonProperty("SupplementalInformationDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupplementalInformationDetail")]
//     public List<SupplementalInformationDetail> SupplementalInformationDetail { get; } =
//         new List<SupplementalInformationDetail>();
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("ForeignIndividualsGrantsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignIndividualsGrantsGrp")]
//     public List<ForeignIndividualsGrantsGrp> ForeignIndividualsGrantsGrp { get; } =
//         new List<ForeignIndividualsGrantsGrp>();
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class IRS990ScheduleG
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("GamingInformationGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GamingInformationGrp")]
//     public GamingInformationGrp GamingInformationGrp { get; set; }
//
//     [JsonProperty("MailSolicitationsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MailSolicitationsInd")]
//     public string MailSolicitationsInd { get; set; }
//
//     [JsonProperty("EmailSolicitationsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EmailSolicitationsInd")]
//     public string EmailSolicitationsInd { get; set; }
//
//     [JsonProperty("PhoneSolicitationsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PhoneSolicitationsInd")]
//     public string PhoneSolicitationsInd { get; set; }
//
//     [JsonProperty("InPersonSolicitationsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InPersonSolicitationsInd")]
//     public string InPersonSolicitationsInd { get; set; }
//
//     [JsonProperty("FundraiserActivityInfoGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraiserActivityInfoGrp")]
//     public FundraiserActivityInfoGrp FundraiserActivityInfoGrp { get; set; }
//
//     [JsonProperty("TotalGrossReceiptsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalGrossReceiptsAmt")]
//     public string TotalGrossReceiptsAmt { get; set; }
//
//     [JsonProperty("TotalNetToOrganizationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalNetToOrganizationAmt")]
//     public string TotalNetToOrganizationAmt { get; set; }
//
//     [JsonProperty("LicensedStatesCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LicensedStatesCd")]
//     public string LicensedStatesCd { get; set; }
//
//     [JsonProperty("FundraisingEventInformationGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingEventInformationGrp")]
//     public FundraisingEventInformationGrp FundraisingEventInformationGrp { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("SpecialFundraisingEventsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SpecialFundraisingEventsInd")]
//     public string SpecialFundraisingEventsInd { get; set; }
//
//     [JsonProperty("AgrmtProfFundraisingActyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AgrmtProfFundraisingActyInd")]
//     public string AgrmtProfFundraisingActyInd { get; set; }
//
//     [JsonProperty("LicensedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LicensedInd")]
//     public string LicensedInd { get; set; }
//
//     [JsonProperty("LicenseSuspendedEtcInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LicenseSuspendedEtcInd")]
//     public string LicenseSuspendedEtcInd { get; set; }
//
//     [JsonProperty("GamingWithNonmembersInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GamingWithNonmembersInd")]
//     public string GamingWithNonmembersInd { get; set; }
//
//     [JsonProperty("MemberOfOtherEntityInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MemberOfOtherEntityInd")]
//     public string MemberOfOtherEntityInd { get; set; }
//
//     [JsonProperty("CntrctWith3rdPrtyForGameRevInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CntrctWith3rdPrtyForGameRevInd")]
//     public string CntrctWith3rdPrtyForGameRevInd { get; set; }
//
//     [JsonProperty("CharitableDistributionRqrInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CharitableDistributionRqrInd")]
//     public string CharitableDistributionRqrInd { get; set; }
//
//     [JsonProperty("TotalRetainedByContractorsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRetainedByContractorsAmt")]
//     public string TotalRetainedByContractorsAmt { get; set; }
//
//     [JsonProperty("StatesWhereGamingConductedCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StatesWhereGamingConductedCd")]
//     public string StatesWhereGamingConductedCd { get; set; }
//
//     [JsonProperty("IndividualWithBooksNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IndividualWithBooksNm")]
//     public string IndividualWithBooksNm { get; set; }
//
//     [JsonProperty("PersonsWithBooksUSAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsWithBooksUSAddress")]
//     public PersonsWithBooksUSAddress PersonsWithBooksUSAddress { get; set; }
//
//     [JsonProperty("GamingManagerPersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GamingManagerPersonNm")]
//     public string GamingManagerPersonNm { get; set; }
//
//     [JsonProperty("GamingManagerIsEmployeeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GamingManagerIsEmployeeInd")]
//     public string GamingManagerIsEmployeeInd { get; set; }
//
//     [JsonProperty("SolicitationOfNonGovtGrantsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SolicitationOfNonGovtGrantsInd")]
//     public string SolicitationOfNonGovtGrantsInd { get; set; }
//
//     [JsonProperty("SolicitationOfGovtGrantsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SolicitationOfGovtGrantsInd")]
//     public string SolicitationOfGovtGrantsInd { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("GamingOwnFacilityPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GamingOwnFacilityPct")]
//     public string GamingOwnFacilityPct { get; set; }
//
//     [JsonProperty("GamingManagerServicesProvTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GamingManagerServicesProvTxt")]
//     public string GamingManagerServicesProvTxt { get; set; }
//
//     [JsonProperty("GamingManagerIsDirectorOfcrInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GamingManagerIsDirectorOfcrInd")]
//     public string GamingManagerIsDirectorOfcrInd { get; set; }
//
//     [JsonProperty("SupplementalInformationDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupplementalInformationDetail")]
//     public SupplementalInformationDetail SupplementalInformationDetail { get; set; }
//
//     [JsonProperty("AllStatesCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AllStatesCd")]
//     public string AllStatesCd { get; set; }
//
//     [JsonProperty("GamingOtherFacilityPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GamingOtherFacilityPct")]
//     public string GamingOtherFacilityPct { get; set; }
//
//     [JsonProperty("GamingManagerCompensationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GamingManagerCompensationAmt")]
//     public string GamingManagerCompensationAmt { get; set; }
//
//     [JsonProperty("DistributedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributedAmt")]
//     public string DistributedAmt { get; set; }
//
//     [JsonProperty("GamingRevenueReceivedByOrgAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GamingRevenueReceivedByOrgAmt")]
//     public string GamingRevenueReceivedByOrgAmt { get; set; }
//
//     [JsonProperty("GamingRevenueRtnBy3PrtyAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GamingRevenueRtnBy3PrtyAmt")]
//     public string GamingRevenueRtnBy3PrtyAmt { get; set; }
//
//     [JsonProperty("ThirdPartyBusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ThirdPartyBusinessName")]
//     public ThirdPartyBusinessName ThirdPartyBusinessName { get; set; }
//
//     [JsonProperty("ThirdPartyUSAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ThirdPartyUSAddress")]
//     public ThirdPartyUSAddress ThirdPartyUSAddress { get; set; }
//
//     [JsonProperty("ThirdPartyPersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ThirdPartyPersonNm")]
//     public string ThirdPartyPersonNm { get; set; }
//
//     [JsonProperty("PersonsWithBooksName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsWithBooksName")]
//     public PersonsWithBooksName PersonsWithBooksName { get; set; }
//
//     [JsonProperty("ExplanationIfNoTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExplanationIfNoTxt")]
//     public string ExplanationIfNoTxt { get; set; }
//
//     [JsonProperty("GamingManagerBusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GamingManagerBusinessName")]
//     public GamingManagerBusinessName GamingManagerBusinessName { get; set; }
//
//     [JsonProperty("GamingManagerIsIndCntrctInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GamingManagerIsIndCntrctInd")]
//     public string GamingManagerIsIndCntrctInd { get; set; }
// }
//
// public class IRS990ScheduleH
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("FinancialAssistancePolicyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FinancialAssistancePolicyInd")]
//     public string FinancialAssistancePolicyInd { get; set; }
//
//     [JsonProperty("WrittenPolicyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("WrittenPolicyInd")]
//     public string WrittenPolicyInd { get; set; }
//
//     [JsonProperty("AllHospitalsPolicyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AllHospitalsPolicyInd")]
//     public string AllHospitalsPolicyInd { get; set; }
//
//     [JsonProperty("FPGReferenceFreeCareInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FPGReferenceFreeCareInd")]
//     public string FPGReferenceFreeCareInd { get; set; }
//
//     [JsonProperty("Percent200Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Percent200Ind")]
//     public string Percent200Ind { get; set; }
//
//     [JsonProperty("FPGReferenceDiscountedCareInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FPGReferenceDiscountedCareInd")]
//     public string FPGReferenceDiscountedCareInd { get; set; }
//
//     [JsonProperty("Percent400Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Percent400Ind")]
//     public string Percent400Ind { get; set; }
//
//     [JsonProperty("FreeCareMedicallyIndigentInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FreeCareMedicallyIndigentInd")]
//     public string FreeCareMedicallyIndigentInd { get; set; }
//
//     [JsonProperty("FinancialAssistanceBudgetInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FinancialAssistanceBudgetInd")]
//     public string FinancialAssistanceBudgetInd { get; set; }
//
//     [JsonProperty("ExpensesExceedBudgetInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpensesExceedBudgetInd")]
//     public string ExpensesExceedBudgetInd { get; set; }
//
//     [JsonProperty("UnableToProvideCareInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnableToProvideCareInd")]
//     public string UnableToProvideCareInd { get; set; }
//
//     [JsonProperty("AnnualCommunityBnftReportInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AnnualCommunityBnftReportInd")]
//     public string AnnualCommunityBnftReportInd { get; set; }
//
//     [JsonProperty("ReportPublicallyAvailableInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReportPublicallyAvailableInd")]
//     public string ReportPublicallyAvailableInd { get; set; }
//
//     [JsonProperty("FinancialAssistanceAtCostTyp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FinancialAssistanceAtCostTyp")]
//     public FinancialAssistanceAtCostTyp FinancialAssistanceAtCostTyp { get; set; }
//
//     [JsonProperty("UnreimbursedMedicaidGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnreimbursedMedicaidGrp")]
//     public UnreimbursedMedicaidGrp UnreimbursedMedicaidGrp { get; set; }
//
//     [JsonProperty("TotalFinancialAssistanceTyp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalFinancialAssistanceTyp")]
//     public TotalFinancialAssistanceTyp TotalFinancialAssistanceTyp { get; set; }
//
//     [JsonProperty("CommunityHealthServicesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CommunityHealthServicesGrp")]
//     public CommunityHealthServicesGrp CommunityHealthServicesGrp { get; set; }
//
//     [JsonProperty("HealthProfessionsEducationGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HealthProfessionsEducationGrp")]
//     public HealthProfessionsEducationGrp HealthProfessionsEducationGrp { get; set; }
//
//     [JsonProperty("SubsidizedHealthServicesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubsidizedHealthServicesGrp")]
//     public SubsidizedHealthServicesGrp SubsidizedHealthServicesGrp { get; set; }
//
//     [JsonProperty("CashAndInKindContributionsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashAndInKindContributionsGrp")]
//     public CashAndInKindContributionsGrp CashAndInKindContributionsGrp { get; set; }
//
//     [JsonProperty("TotalOtherBenefitsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalOtherBenefitsGrp")]
//     public TotalOtherBenefitsGrp TotalOtherBenefitsGrp { get; set; }
//
//     [JsonProperty("TotalCommunityBenefitsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitsGrp")]
//     public TotalCommunityBenefitsGrp TotalCommunityBenefitsGrp { get; set; }
//
//     [JsonProperty("EconomicDevelopmentGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EconomicDevelopmentGrp")]
//     public EconomicDevelopmentGrp EconomicDevelopmentGrp { get; set; }
//
//     [JsonProperty("CommunitySupportGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CommunitySupportGrp")]
//     public CommunitySupportGrp CommunitySupportGrp { get; set; }
//
//     [JsonProperty("WorkforceDevelopmentGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("WorkforceDevelopmentGrp")]
//     public WorkforceDevelopmentGrp WorkforceDevelopmentGrp { get; set; }
//
//     [JsonProperty("TotalCommuntityBuildingActyGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommuntityBuildingActyGrp")]
//     public TotalCommuntityBuildingActyGrp TotalCommuntityBuildingActyGrp { get; set; }
//
//     [JsonProperty("BadDebtExpenseReportedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BadDebtExpenseReportedInd")]
//     public string BadDebtExpenseReportedInd { get; set; }
//
//     [JsonProperty("BadDebtExpenseAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BadDebtExpenseAmt")]
//     public string BadDebtExpenseAmt { get; set; }
//
//     [JsonProperty("BadDebtExpenseAttributableAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BadDebtExpenseAttributableAmt")]
//     public string BadDebtExpenseAttributableAmt { get; set; }
//
//     [JsonProperty("ReimbursedByMedicareAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReimbursedByMedicareAmt")]
//     public string ReimbursedByMedicareAmt { get; set; }
//
//     [JsonProperty("CostOfCareReimbursedByMedcrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CostOfCareReimbursedByMedcrAmt")]
//     public string CostOfCareReimbursedByMedcrAmt { get; set; }
//
//     [JsonProperty("MedicareSurplusOrShortfallAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MedicareSurplusOrShortfallAmt")]
//     public string MedicareSurplusOrShortfallAmt { get; set; }
//
//     [JsonProperty("CostingMethodologyUsedGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CostingMethodologyUsedGrp")]
//     public CostingMethodologyUsedGrp CostingMethodologyUsedGrp { get; set; }
//
//     [JsonProperty("WrittenDebtCollectionPolicyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("WrittenDebtCollectionPolicyInd")]
//     public string WrittenDebtCollectionPolicyInd { get; set; }
//
//     [JsonProperty("FinancialAssistancePrvsnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FinancialAssistancePrvsnInd")]
//     public string FinancialAssistancePrvsnInd { get; set; }
//
//     [JsonProperty("HospitalFacilitiesCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HospitalFacilitiesCnt")]
//     public string HospitalFacilitiesCnt { get; set; }
//
//     [JsonProperty("HospitalFacilitiesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HospitalFacilitiesGrp")]
//     public HospitalFacilitiesGrp HospitalFacilitiesGrp { get; set; }
//
//     [JsonProperty("HospitalFcltyPoliciesPrctcGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HospitalFcltyPoliciesPrctcGrp")]
//     public HospitalFcltyPoliciesPrctcGrp HospitalFcltyPoliciesPrctcGrp { get; set; }
//
//     [JsonProperty("SupplementalInformationGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupplementalInformationGrp")]
//     public List<SupplementalInformationGrp> SupplementalInformationGrp { get; } =
//         new List<SupplementalInformationGrp>();
//
//     [JsonProperty("FacilityNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FacilityNum")]
//     public string FacilityNum { get; set; }
//
//     [JsonProperty("OthHlthCareFcltsNotHospitalGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OthHlthCareFcltsNotHospitalGrp")]
//     public OthHlthCareFcltsNotHospitalGrp OthHlthCareFcltsNotHospitalGrp { get; set; }
//
//     [JsonProperty("SupplementalInformationDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupplementalInformationDetail")]
//     public List<SupplementalInformationDetail> SupplementalInformationDetail { get; } =
//         new List<SupplementalInformationDetail>();
//
//     [JsonProperty("Percent150Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Percent150Ind")]
//     public string Percent150Ind { get; set; }
//
//     [JsonProperty("Percent300Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Percent300Ind")]
//     public string Percent300Ind { get; set; }
//
//     [JsonProperty("HealthImprovementAdvocacyGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HealthImprovementAdvocacyGrp")]
//     public HealthImprovementAdvocacyGrp HealthImprovementAdvocacyGrp { get; set; }
//
//     [JsonProperty("FreeCareOthPercentageGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FreeCareOthPercentageGrp")]
//     public FreeCareOthPercentageGrp FreeCareOthPercentageGrp { get; set; }
//
//     [JsonProperty("Percent200DInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Percent200DInd")]
//     public string Percent200DInd { get; set; }
//
//     [JsonProperty("DiscountedCareOthPercentageGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DiscountedCareOthPercentageGrp")]
//     public DiscountedCareOthPercentageGrp DiscountedCareOthPercentageGrp { get; set; }
//
//     [JsonProperty("UnreimbursedCostsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnreimbursedCostsGrp")]
//     public UnreimbursedCostsGrp UnreimbursedCostsGrp { get; set; }
//
//     [JsonProperty("ResearchGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ResearchGrp")]
//     public ResearchGrp ResearchGrp { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("Percent100Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Percent100Ind")]
//     public string Percent100Ind { get; set; }
//
//     [JsonProperty("LeadershipDevelopmentGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LeadershipDevelopmentGrp")]
//     public LeadershipDevelopmentGrp LeadershipDevelopmentGrp { get; set; }
//
//     [JsonProperty("Percent250Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Percent250Ind")]
//     public string Percent250Ind { get; set; }
//
//     [JsonProperty("CoalitionBuildingGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CoalitionBuildingGrp")]
//     public CoalitionBuildingGrp CoalitionBuildingGrp { get; set; }
//
//     [JsonProperty("Percent350Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Percent350Ind")]
//     public string Percent350Ind { get; set; }
//
//     [JsonProperty("EnvironmentalImprovementsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EnvironmentalImprovementsGrp")]
//     public EnvironmentalImprovementsGrp EnvironmentalImprovementsGrp { get; set; }
//
//     [JsonProperty("PhysicalImprvAndHousingGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PhysicalImprvAndHousingGrp")]
//     public PhysicalImprvAndHousingGrp PhysicalImprvAndHousingGrp { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("ManagementCoAndJntVenturesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementCoAndJntVenturesGrp")]
//     public List<ManagementCoAndJntVenturesGrp> ManagementCoAndJntVenturesGrp { get; } =
//         new List<ManagementCoAndJntVenturesGrp>();
//
//     [JsonProperty("OtherCommuntityBuildingActyGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherCommuntityBuildingActyGrp")]
//     public OtherCommuntityBuildingActyGrp OtherCommuntityBuildingActyGrp { get; set; }
// }
//
// public class IRS990ScheduleI
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("GrantRecordsMaintainedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantRecordsMaintainedInd")]
//     public string GrantRecordsMaintainedInd { get; set; }
//
//     [JsonProperty("RecipientTable", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecipientTable")]
//     public RecipientTable RecipientTable { get; set; }
//
//     [JsonProperty("SupplementalInformationDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupplementalInformationDetail")]
//     public SupplementalInformationDetail SupplementalInformationDetail { get; set; }
//
//     [JsonProperty("GrantsOtherAsstToIndivInUSGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsOtherAsstToIndivInUSGrp")]
//     public GrantsOtherAsstToIndivInUSGrp GrantsOtherAsstToIndivInUSGrp { get; set; }
//
//     [JsonProperty("Total501c3OrgCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Total501c3OrgCnt")]
//     public string Total501c3OrgCnt { get; set; }
//
//     [JsonProperty("TotalOtherOrgCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalOtherOrgCnt")]
//     public string TotalOtherOrgCnt { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class IRS990ScheduleJ
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("SeverancePaymentInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SeverancePaymentInd")]
//     public string SeverancePaymentInd { get; set; }
//
//     [JsonProperty("SupplementalNonqualRtrPlanInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupplementalNonqualRtrPlanInd")]
//     public string SupplementalNonqualRtrPlanInd { get; set; }
//
//     [JsonProperty("EquityBasedCompArrngmInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EquityBasedCompArrngmInd")]
//     public string EquityBasedCompArrngmInd { get; set; }
//
//     [JsonProperty("CompBasedOnRevenueOfFlngOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompBasedOnRevenueOfFlngOrgInd")]
//     public string CompBasedOnRevenueOfFlngOrgInd { get; set; }
//
//     [JsonProperty("CompBsdOnRevRelatedOrgsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompBsdOnRevRelatedOrgsInd")]
//     public string CompBsdOnRevRelatedOrgsInd { get; set; }
//
//     [JsonProperty("CompBsdNetEarnsFlngOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompBsdNetEarnsFlngOrgInd")]
//     public string CompBsdNetEarnsFlngOrgInd { get; set; }
//
//     [JsonProperty("CompBsdNetEarnsRltdOrgsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompBsdNetEarnsRltdOrgsInd")]
//     public string CompBsdNetEarnsRltdOrgsInd { get; set; }
//
//     [JsonProperty("AnyNonFixedPaymentsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AnyNonFixedPaymentsInd")]
//     public string AnyNonFixedPaymentsInd { get; set; }
//
//     [JsonProperty("InitialContractExceptionInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InitialContractExceptionInd")]
//     public string InitialContractExceptionInd { get; set; }
//
//     [JsonProperty("RltdOrgOfficerTrstKeyEmplGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RltdOrgOfficerTrstKeyEmplGrp")]
//     public List<RltdOrgOfficerTrstKeyEmplGrp> RltdOrgOfficerTrstKeyEmplGrp { get; } =
//         new List<RltdOrgOfficerTrstKeyEmplGrp>();
//
//     [JsonProperty("SupplementalInformationDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupplementalInformationDetail")]
//     public List<SupplementalInformationDetail> SupplementalInformationDetail { get; } =
//         new List<SupplementalInformationDetail>();
//
//     [JsonProperty("TravelForCompanionsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TravelForCompanionsInd")]
//     public string TravelForCompanionsInd { get; set; }
//
//     [JsonProperty("WrittenPolicyRefTAndEExpnssInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("WrittenPolicyRefTAndEExpnssInd")]
//     public string WrittenPolicyRefTAndEExpnssInd { get; set; }
//
//     [JsonProperty("SubstantiationRequiredInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubstantiationRequiredInd")]
//     public string SubstantiationRequiredInd { get; set; }
//
//     [JsonProperty("CompensationCommitteeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompensationCommitteeInd")]
//     public string CompensationCommitteeInd { get; set; }
//
//     [JsonProperty("IndependentConsultantInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IndependentConsultantInd")]
//     public string IndependentConsultantInd { get; set; }
//
//     [JsonProperty("WrittenEmploymentContractInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("WrittenEmploymentContractInd")]
//     public string WrittenEmploymentContractInd { get; set; }
//
//     [JsonProperty("CompensationSurveyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompensationSurveyInd")]
//     public string CompensationSurveyInd { get; set; }
//
//     [JsonProperty("BoardOrCommitteeApprovalInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BoardOrCommitteeApprovalInd")]
//     public string BoardOrCommitteeApprovalInd { get; set; }
//
//     [JsonProperty("Form990OfOtherOrganizationsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form990OfOtherOrganizationsInd")]
//     public string Form990OfOtherOrganizationsInd { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("HousingAllowanceOrResidenceInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HousingAllowanceOrResidenceInd")]
//     public string HousingAllowanceOrResidenceInd { get; set; }
//
//     [JsonProperty("IdemnificationGrossUpPmtsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IdemnificationGrossUpPmtsInd")]
//     public string IdemnificationGrossUpPmtsInd { get; set; }
//
//     [JsonProperty("FirstClassOrCharterTravelInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FirstClassOrCharterTravelInd")]
//     public string FirstClassOrCharterTravelInd { get; set; }
//
//     [JsonProperty("ClubDuesOrFeesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ClubDuesOrFeesInd")]
//     public string ClubDuesOrFeesInd { get; set; }
//
//     [JsonProperty("DiscretionarySpendingAcctInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DiscretionarySpendingAcctInd")]
//     public string DiscretionarySpendingAcctInd { get; set; }
//
//     [JsonProperty("RebuttablePresumptionProcInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RebuttablePresumptionProcInd")]
//     public string RebuttablePresumptionProcInd { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("PersonalServicesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonalServicesInd")]
//     public string PersonalServicesInd { get; set; }
//
//     [JsonProperty("PaymentsForUseOfResidenceInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PaymentsForUseOfResidenceInd")]
//     public string PaymentsForUseOfResidenceInd { get; set; }
// }
//
// public class IRS990ScheduleK
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("TaxExemptBondsIssuesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxExemptBondsIssuesGrp")]
//     public object TaxExemptBondsIssuesGrp { get; set; }
//
//     [JsonProperty("TaxExemptBondsProceedsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxExemptBondsProceedsGrp")]
//     public object TaxExemptBondsProceedsGrp { get; set; }
//
//     [JsonProperty("TaxExemptBondsPrivateBusUseGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxExemptBondsPrivateBusUseGrp")]
//     public object TaxExemptBondsPrivateBusUseGrp { get; set; }
//
//     [JsonProperty("TaxExemptBondsArbitrageGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxExemptBondsArbitrageGrp")]
//     public object TaxExemptBondsArbitrageGrp { get; set; }
//
//     [JsonProperty("ProceduresCorrectiveActionGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProceduresCorrectiveActionGrp")]
//     public object ProceduresCorrectiveActionGrp { get; set; }
//
//     [JsonProperty("SupplementalInformationDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupplementalInformationDetail")]
//     public List<SupplementalInformationDetail> SupplementalInformationDetail { get; } =
//         new List<SupplementalInformationDetail>();
// }
//
// public class IRS990ScheduleL
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("BusTrInvolveInterestedPrsnGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusTrInvolveInterestedPrsnGrp")]
//     public BusTrInvolveInterestedPrsnGrp BusTrInvolveInterestedPrsnGrp { get; set; }
//
//     [JsonProperty("LoansBtwnOrgInterestedPrsnGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoansBtwnOrgInterestedPrsnGrp")]
//     public LoansBtwnOrgInterestedPrsnGrp LoansBtwnOrgInterestedPrsnGrp { get; set; }
//
//     [JsonProperty("TotalBalanceDueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalBalanceDueAmt")]
//     public string TotalBalanceDueAmt { get; set; }
//
//     [JsonProperty("SupplementalInformationDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupplementalInformationDetail")]
//     public SupplementalInformationDetail SupplementalInformationDetail { get; set; }
//
//     [JsonProperty("GrntAsstBnftInterestedPrsnGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrntAsstBnftInterestedPrsnGrp")]
//     public GrntAsstBnftInterestedPrsnGrp GrntAsstBnftInterestedPrsnGrp { get; set; }
//
//     [JsonProperty("DisqualifiedPersonExBnftTrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisqualifiedPersonExBnftTrGrp")]
//     public List<DisqualifiedPersonExBnftTrGrp> DisqualifiedPersonExBnftTrGrp { get; } =
//         new List<DisqualifiedPersonExBnftTrGrp>();
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("TaxImposedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxImposedAmt")]
//     public string TaxImposedAmt { get; set; }
//
//     [JsonProperty("TaxReimbursedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxReimbursedAmt")]
//     public string TaxReimbursedAmt { get; set; }
// }
//
// public class IRS990ScheduleM
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("RealEstateCommercialGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RealEstateCommercialGrp")]
//     public string RealEstateCommercialGrp { get; set; }
//
//     [JsonProperty("AnyPropertyThatMustBeHeldInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AnyPropertyThatMustBeHeldInd")]
//     public string AnyPropertyThatMustBeHeldInd { get; set; }
//
//     [JsonProperty("ReviewProcessUnusualNCGiftsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReviewProcessUnusualNCGiftsInd")]
//     public string ReviewProcessUnusualNCGiftsInd { get; set; }
//
//     [JsonProperty("ThirdPartiesUsedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ThirdPartiesUsedInd")]
//     public string ThirdPartiesUsedInd { get; set; }
//
//     [JsonProperty("SecuritiesPubliclyTradedGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SecuritiesPubliclyTradedGrp")]
//     public SecuritiesPubliclyTradedGrp SecuritiesPubliclyTradedGrp { get; set; }
//
//     [JsonProperty("BooksAndPublicationsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BooksAndPublicationsGrp")]
//     public string BooksAndPublicationsGrp { get; set; }
//
//     [JsonProperty("SupplementalInformationDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupplementalInformationDetail")]
//     public List<SupplementalInformationDetail> SupplementalInformationDetail { get; } =
//         new List<SupplementalInformationDetail>();
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("OtherNonCashContriTableGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherNonCashContriTableGrp")]
//     public OtherNonCashContriTableGrp OtherNonCashContriTableGrp { get; set; }
//
//     [JsonProperty("Form8283ReceivedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form8283ReceivedCnt")]
//     public string Form8283ReceivedCnt { get; set; }
//
//     [JsonProperty("RealEstateResidentialGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RealEstateResidentialGrp")]
//     public string RealEstateResidentialGrp { get; set; }
//
//     [JsonProperty("FoodInventoryGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FoodInventoryGrp")]
//     public FoodInventoryGrp FoodInventoryGrp { get; set; }
//
//     [JsonProperty("BoatsAndPlanesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BoatsAndPlanesGrp")]
//     public string BoatsAndPlanesGrp { get; set; }
//
//     [JsonProperty("WorksOfArtGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("WorksOfArtGrp")]
//     public string WorksOfArtGrp { get; set; }
//
//     [JsonProperty("ArtHistoricalTreasuresGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ArtHistoricalTreasuresGrp")]
//     public string ArtHistoricalTreasuresGrp { get; set; }
//
//     [JsonProperty("ArtFractionalInterestGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ArtFractionalInterestGrp")]
//     public string ArtFractionalInterestGrp { get; set; }
//
//     [JsonProperty("ClothingAndHouseholdGoodsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ClothingAndHouseholdGoodsGrp")]
//     public ClothingAndHouseholdGoodsGrp ClothingAndHouseholdGoodsGrp { get; set; }
//
//     [JsonProperty("CarsAndOtherVehiclesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CarsAndOtherVehiclesGrp")]
//     public CarsAndOtherVehiclesGrp CarsAndOtherVehiclesGrp { get; set; }
//
//     [JsonProperty("IntellectualPropertyGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IntellectualPropertyGrp")]
//     public string IntellectualPropertyGrp { get; set; }
//
//     [JsonProperty("SecuritiesCloselyHeldStockGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SecuritiesCloselyHeldStockGrp")]
//     public string SecuritiesCloselyHeldStockGrp { get; set; }
//
//     [JsonProperty("SecurPrtnrshpTrustIntrstsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SecurPrtnrshpTrustIntrstsGrp")]
//     public string SecurPrtnrshpTrustIntrstsGrp { get; set; }
//
//     [JsonProperty("SecuritiesMiscellaneousGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SecuritiesMiscellaneousGrp")]
//     public string SecuritiesMiscellaneousGrp { get; set; }
//
//     [JsonProperty("QualifiedContribHistStructGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("QualifiedContribHistStructGrp")]
//     public string QualifiedContribHistStructGrp { get; set; }
//
//     [JsonProperty("QualifiedContribOtherGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("QualifiedContribOtherGrp")]
//     public string QualifiedContribOtherGrp { get; set; }
//
//     [JsonProperty("RealEstateOtherGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RealEstateOtherGrp")]
//     public RealEstateOtherGrp RealEstateOtherGrp { get; set; }
//
//     [JsonProperty("CollectiblesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CollectiblesGrp")]
//     public string CollectiblesGrp { get; set; }
//
//     [JsonProperty("DrugsAndMedicalSuppliesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DrugsAndMedicalSuppliesGrp")]
//     public string DrugsAndMedicalSuppliesGrp { get; set; }
//
//     [JsonProperty("TaxidermyGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxidermyGrp")]
//     public string TaxidermyGrp { get; set; }
//
//     [JsonProperty("HistoricalArtifactsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("HistoricalArtifactsGrp")]
//     public string HistoricalArtifactsGrp { get; set; }
//
//     [JsonProperty("ScientificSpecimensGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ScientificSpecimensGrp")]
//     public string ScientificSpecimensGrp { get; set; }
//
//     [JsonProperty("ArchaeologicalArtifactsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ArchaeologicalArtifactsGrp")]
//     public string ArchaeologicalArtifactsGrp { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class IRS990ScheduleN
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("LiquidationOfAssetsTableGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LiquidationOfAssetsTableGrp")]
//     public LiquidationOfAssetsTableGrp LiquidationOfAssetsTableGrp { get; set; }
//
//     [JsonProperty("DirectorOfSuccessorInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectorOfSuccessorInd")]
//     public string DirectorOfSuccessorInd { get; set; }
//
//     [JsonProperty("EmployeeOfSuccessorInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EmployeeOfSuccessorInd")]
//     public string EmployeeOfSuccessorInd { get; set; }
//
//     [JsonProperty("OwnerOfSuccessorInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OwnerOfSuccessorInd")]
//     public string OwnerOfSuccessorInd { get; set; }
//
//     [JsonProperty("ReceiveCompensationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReceiveCompensationInd")]
//     public string ReceiveCompensationInd { get; set; }
//
//     [JsonProperty("AssetsDistributedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AssetsDistributedInd")]
//     public string AssetsDistributedInd { get; set; }
//
//     [JsonProperty("RequiredToNotifyAGInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RequiredToNotifyAGInd")]
//     public string RequiredToNotifyAGInd { get; set; }
//
//     [JsonProperty("LiabilitiesPaidInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LiabilitiesPaidInd")]
//     public string LiabilitiesPaidInd { get; set; }
//
//     [JsonProperty("BondsOutstandingInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BondsOutstandingInd")]
//     public string BondsOutstandingInd { get; set; }
//
//     [JsonProperty("DispositionOfAssetsDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DispositionOfAssetsDetail")]
//     public DispositionOfAssetsDetail DispositionOfAssetsDetail { get; set; }
//
//     [JsonProperty("DirectorOfSuccessor2Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectorOfSuccessor2Ind")]
//     public string DirectorOfSuccessor2Ind { get; set; }
//
//     [JsonProperty("EmployeeOfSuccessor2Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EmployeeOfSuccessor2Ind")]
//     public string EmployeeOfSuccessor2Ind { get; set; }
//
//     [JsonProperty("OwnerOfSuccessor2Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OwnerOfSuccessor2Ind")]
//     public string OwnerOfSuccessor2Ind { get; set; }
//
//     [JsonProperty("ReceiveCompensation2Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReceiveCompensation2Ind")]
//     public string ReceiveCompensation2Ind { get; set; }
//
//     [JsonProperty("SupplementalInformationDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupplementalInformationDetail")]
//     public List<SupplementalInformationDetail> SupplementalInformationDetail { get; } =
//         new List<SupplementalInformationDetail>();
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("AttorneyGeneralNotifiedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AttorneyGeneralNotifiedInd")]
//     public string AttorneyGeneralNotifiedInd { get; set; }
//
//     [JsonProperty("BondLiabilitiesDischargedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BondLiabilitiesDischargedInd")]
//     public string BondLiabilitiesDischargedInd { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class IRS990ScheduleO
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("SupplementalInformationDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupplementalInformationDetail")]
//     public List<SupplementalInformationDetail> SupplementalInformationDetail { get; } =
//         new List<SupplementalInformationDetail>();
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class IRS990ScheduleR
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("IdRelatedTaxExemptOrgGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IdRelatedTaxExemptOrgGrp")]
//     public IdRelatedTaxExemptOrgGrp IdRelatedTaxExemptOrgGrp { get; set; }
//
//     [JsonProperty("ReceiptOfIntAnntsRntsRyltsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReceiptOfIntAnntsRntsRyltsInd")]
//     public string ReceiptOfIntAnntsRntsRyltsInd { get; set; }
//
//     [JsonProperty("GiftGrntOrCapContriToOthOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GiftGrntOrCapContriToOthOrgInd")]
//     public string GiftGrntOrCapContriToOthOrgInd { get; set; }
//
//     [JsonProperty("GiftGrntCapContriFromOthOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GiftGrntCapContriFromOthOrgInd")]
//     public string GiftGrntCapContriFromOthOrgInd { get; set; }
//
//     [JsonProperty("LoansOrGuaranteesToOtherOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoansOrGuaranteesToOtherOrgInd")]
//     public string LoansOrGuaranteesToOtherOrgInd { get; set; }
//
//     [JsonProperty("LoansOrGuaranteesFromOthOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoansOrGuaranteesFromOthOrgInd")]
//     public string LoansOrGuaranteesFromOthOrgInd { get; set; }
//
//     [JsonProperty("DivRelatedOrganizationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DivRelatedOrganizationInd")]
//     public string DivRelatedOrganizationInd { get; set; }
//
//     [JsonProperty("AssetSaleToOtherOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AssetSaleToOtherOrgInd")]
//     public string AssetSaleToOtherOrgInd { get; set; }
//
//     [JsonProperty("AssetPurchaseFromOtherOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AssetPurchaseFromOtherOrgInd")]
//     public string AssetPurchaseFromOtherOrgInd { get; set; }
//
//     [JsonProperty("AssetExchangeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AssetExchangeInd")]
//     public string AssetExchangeInd { get; set; }
//
//     [JsonProperty("RentalOfFacilitiesToOthOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RentalOfFacilitiesToOthOrgInd")]
//     public string RentalOfFacilitiesToOthOrgInd { get; set; }
//
//     [JsonProperty("RentalOfFcltsFromOthOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RentalOfFcltsFromOthOrgInd")]
//     public string RentalOfFcltsFromOthOrgInd { get; set; }
//
//     [JsonProperty("PerformOfServicesForOthOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PerformOfServicesForOthOrgInd")]
//     public string PerformOfServicesForOthOrgInd { get; set; }
//
//     [JsonProperty("PerformOfServicesByOtherOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PerformOfServicesByOtherOrgInd")]
//     public string PerformOfServicesByOtherOrgInd { get; set; }
//
//     [JsonProperty("SharingOfFacilitiesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SharingOfFacilitiesInd")]
//     public string SharingOfFacilitiesInd { get; set; }
//
//     [JsonProperty("PaidEmployeesSharingInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PaidEmployeesSharingInd")]
//     public string PaidEmployeesSharingInd { get; set; }
//
//     [JsonProperty("ReimbursementPaidToOtherOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReimbursementPaidToOtherOrgInd")]
//     public string ReimbursementPaidToOtherOrgInd { get; set; }
//
//     [JsonProperty("ReimbursementPaidByOtherOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReimbursementPaidByOtherOrgInd")]
//     public string ReimbursementPaidByOtherOrgInd { get; set; }
//
//     [JsonProperty("TransferToOtherOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransferToOtherOrgInd")]
//     public string TransferToOtherOrgInd { get; set; }
//
//     [JsonProperty("TransferFromOtherOrgInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransferFromOtherOrgInd")]
//     public string TransferFromOtherOrgInd { get; set; }
//
//     [JsonProperty("TransactionsRelatedOrgGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransactionsRelatedOrgGrp")]
//     public TransactionsRelatedOrgGrp TransactionsRelatedOrgGrp { get; set; }
//
//     [JsonProperty("SupplementalInformationDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupplementalInformationDetail")]
//     public SupplementalInformationDetail SupplementalInformationDetail { get; set; }
//
//     [JsonProperty("IdRelatedOrgTxblCorpTrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IdRelatedOrgTxblCorpTrGrp")]
//     public IdRelatedOrgTxblCorpTrGrp IdRelatedOrgTxblCorpTrGrp { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("IdRelatedOrgTxblPartnershipGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IdRelatedOrgTxblPartnershipGrp")]
//     public IdRelatedOrgTxblPartnershipGrp IdRelatedOrgTxblPartnershipGrp { get; set; }
//
//     [JsonProperty("IdDisregardedEntitiesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IdDisregardedEntitiesGrp")]
//     public List<IdDisregardedEntitiesGrp> IdDisregardedEntitiesGrp { get; } = new List<IdDisregardedEntitiesGrp>();
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("UnrelatedOrgTxblPartnershipGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedOrgTxblPartnershipGrp")]
//     public UnrelatedOrgTxblPartnershipGrp UnrelatedOrgTxblPartnershipGrp { get; set; }
// }
//
// public class IRS990T
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("Organization501IndicatorGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization501IndicatorGrp")]
//     public Organization501IndicatorGrp Organization501IndicatorGrp { get; set; }
//
//     [JsonProperty("BookValueAssetsEOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BookValueAssetsEOYAmt")]
//     public string BookValueAssetsEOYAmt { get; set; }
//
//     [JsonProperty("Organization501cTrustInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization501cTrustInd")]
//     public string Organization501cTrustInd { get; set; }
//
//     [JsonProperty("Form990TScheduleAAttachedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form990TScheduleAAttachedCnt")]
//     public string Form990TScheduleAAttachedCnt { get; set; }
//
//     [JsonProperty("SubsidiaryCorporationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubsidiaryCorporationInd")]
//     public string SubsidiaryCorporationInd { get; set; }
//
//     [JsonProperty("BooksInCareOfDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BooksInCareOfDetail")]
//     public BooksInCareOfDetail BooksInCareOfDetail { get; set; }
//
//     [JsonProperty("TotalUBTIComputedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalUBTIComputedAmt")]
//     public string TotalUBTIComputedAmt { get; set; }
//
//     [JsonProperty("CharitableContributionsDedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CharitableContributionsDedAmt")]
//     public string CharitableContributionsDedAmt { get; set; }
//
//     [JsonProperty("TotalUBTIBeforeNOLSpecificAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalUBTIBeforeNOLSpecificAmt")]
//     public string TotalUBTIBeforeNOLSpecificAmt { get; set; }
//
//     [JsonProperty("NetOperatingLossDeductionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetOperatingLossDeductionAmt")]
//     public string NetOperatingLossDeductionAmt { get; set; }
//
//     [JsonProperty("SpecificDeductionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SpecificDeductionAmt")]
//     public string SpecificDeductionAmt { get; set; }
//
//     [JsonProperty("TotalDeductionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalDeductionAmt")]
//     public string TotalDeductionAmt { get; set; }
//
//     [JsonProperty("TotalUBTIAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalUBTIAmt")]
//     public string TotalUBTIAmt { get; set; }
//
//     [JsonProperty("TaxableTrustAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxableTrustAmt")]
//     public string TaxableTrustAmt { get; set; }
//
//     [JsonProperty("TaxRateScheduleInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxRateScheduleInd")]
//     public string TaxRateScheduleInd { get; set; }
//
//     [JsonProperty("TotalTaxComputationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalTaxComputationAmt")]
//     public string TotalTaxComputationAmt { get; set; }
//
//     [JsonProperty("TaxLessCreditsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxLessCreditsAmt")]
//     public string TaxLessCreditsAmt { get; set; }
//
//     [JsonProperty("TotalTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalTaxAmt")]
//     public string TotalTaxAmt { get; set; }
//
//     [JsonProperty("PaidTaxLiabilityAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PaidTaxLiabilityAmt")]
//     public string PaidTaxLiabilityAmt { get; set; }
//
//     [JsonProperty("ForeignAccountsQuestionInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignAccountsQuestionInd")]
//     public string ForeignAccountsQuestionInd { get; set; }
//
//     [JsonProperty("ForeignTrustQuestionInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignTrustQuestionInd")]
//     public string ForeignTrustQuestionInd { get; set; }
//
//     [JsonProperty("TaxExemptInterestAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxExemptInterestAmt")]
//     public string TaxExemptInterestAmt { get; set; }
//
//     [JsonProperty("AvlblPre2018NOLCarryoverAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AvlblPre2018NOLCarryoverAmt")]
//     public string AvlblPre2018NOLCarryoverAmt { get; set; }
//
//     [JsonProperty("Post2017NOLCarryoverGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Post2017NOLCarryoverGrp")]
//     public Post2017NOLCarryoverGrp Post2017NOLCarryoverGrp { get; set; }
//
//     [JsonProperty("ChangeInMethodOfAccountingInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ChangeInMethodOfAccountingInd")]
//     public string ChangeInMethodOfAccountingInd { get; set; }
//
//     [JsonProperty("Organization501cCorporationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization501cCorporationInd")]
//     public string Organization501cCorporationInd { get; set; }
//
//     [JsonProperty("TotalUBTIBeforeSection199AAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalUBTIBeforeSection199AAmt")]
//     public string TotalUBTIBeforeSection199AAmt { get; set; }
//
//     [JsonProperty("TaxableCorporationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxableCorporationAmt")]
//     public string TaxableCorporationAmt { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("OtherCreditsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherCreditsAmt")]
//     public OtherCreditsAmt OtherCreditsAmt { get; set; }
//
//     [JsonProperty("TotalCreditsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCreditsAmt")]
//     public string TotalCreditsAmt { get; set; }
//
//     [JsonProperty("OtherTaxesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherTaxesAmt")]
//     public string OtherTaxesAmt { get; set; }
//
//     [JsonProperty("EstimatedTaxPaymentsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EstimatedTaxPaymentsAmt")]
//     public string EstimatedTaxPaymentsAmt { get; set; }
//
//     [JsonProperty("CreditsAdjPaymentOtherInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CreditsAdjPaymentOtherInd")]
//     public CreditsAdjPaymentOtherInd CreditsAdjPaymentOtherInd { get; set; }
//
//     [JsonProperty("TotalOtherCreditsAdjPaymentAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalOtherCreditsAdjPaymentAmt")]
//     public string TotalOtherCreditsAdjPaymentAmt { get; set; }
//
//     [JsonProperty("TotalPaymentsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalPaymentsAmt")]
//     public string TotalPaymentsAmt { get; set; }
//
//     [JsonProperty("OverpaymentSection", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OverpaymentSection")]
//     public OverpaymentSection OverpaymentSection { get; set; }
//
//     [JsonProperty("ForeignCountryCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignCountryCd")]
//     public List<string> ForeignCountryCd { get; } = new List<string>();
//
//     [JsonProperty("ItmzdSupplementalInfoGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ItmzdSupplementalInfoGrp")]
//     public ItmzdSupplementalInfoGrp ItmzdSupplementalInfoGrp { get; set; }
//
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("NameChangeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NameChangeInd")]
//     public string NameChangeInd { get; set; }
//
//     [JsonProperty("OtherTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherTaxAmt")]
//     public string OtherTaxAmt { get; set; }
//
//     [JsonProperty("NoncompliantFacilityIncmTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NoncompliantFacilityIncmTaxAmt")]
//     public string NoncompliantFacilityIncmTaxAmt { get; set; }
//
//     [JsonProperty("CYGenBusinessCreditAllowedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CYGenBusinessCreditAllowedAmt")]
//     public string CYGenBusinessCreditAllowedAmt { get; set; }
//
//     [JsonProperty("PriorYearOverpaymentCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearOverpaymentCreditAmt")]
//     public string PriorYearOverpaymentCreditAmt { get; set; }
//
//     [JsonProperty("ExtsnRequestIncomeTaxPaidAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExtsnRequestIncomeTaxPaidAmt")]
//     public string ExtsnRequestIncomeTaxPaidAmt { get; set; }
//
//     [JsonProperty("ForeignTaxPdWithheldAtSrceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignTaxPdWithheldAtSrceAmt")]
//     public ForeignTaxPdWithheldAtSrceAmt ForeignTaxPdWithheldAtSrceAmt { get; set; }
//
//     [JsonProperty("BackupWithholdingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BackupWithholdingAmt")]
//     public BackupWithholdingAmt BackupWithholdingAmt { get; set; }
//
//     [JsonProperty("ESPenaltyAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ESPenaltyAmt")]
//     public string ESPenaltyAmt { get; set; }
//
//     [JsonProperty("BalanceDueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BalanceDueAmt")]
//     public string BalanceDueAmt { get; set; }
//
//     [JsonProperty("Form1041ScheduleDInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form1041ScheduleDInd")]
//     public Form1041ScheduleDInd Form1041ScheduleDInd { get; set; }
//
//     [JsonProperty("ProvChangeMethodOfAcctDescInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProvChangeMethodOfAcctDescInd")]
//     public string ProvChangeMethodOfAcctDescInd { get; set; }
//
//     [JsonProperty("AddressChangeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressChangeInd")]
//     public string AddressChangeInd { get; set; }
//
//     [JsonProperty("Form2220AttachedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form2220AttachedInd")]
//     public Form2220AttachedInd Form2220AttachedInd { get; set; }
//
//     [JsonProperty("GroupExemptionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GroupExemptionNum")]
//     public string GroupExemptionNum { get; set; }
//
//     [JsonProperty("ForeignTaxCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignTaxCreditAmt")]
//     public string ForeignTaxCreditAmt { get; set; }
//
//     [JsonProperty("AmendedReturnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AmendedReturnInd")]
//     public string AmendedReturnInd { get; set; }
//
//     [JsonProperty("ParentCorporationName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ParentCorporationName")]
//     public ParentCorporationName ParentCorporationName { get; set; }
//
//     [JsonProperty("PrntCorporationNameControlTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrntCorporationNameControlTxt")]
//     public string PrntCorporationNameControlTxt { get; set; }
//
//     [JsonProperty("ParentCorporationEIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ParentCorporationEIN")]
//     public string ParentCorporationEIN { get; set; }
//
//     [JsonProperty("AlternativeMinimumTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AlternativeMinimumTaxAmt")]
//     public string AlternativeMinimumTaxAmt { get; set; }
//
//     [JsonProperty("Section199ADeductionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Section199ADeductionAmt")]
//     public Section199ADeductionAmt Section199ADeductionAmt { get; set; }
//
//     [JsonProperty("Form4136Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form4136Ind")]
//     public Form4136Ind Form4136Ind { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
// }
//
// public class IRS990TScheduleA
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("PrincipalBusinessActivityCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrincipalBusinessActivityCd")]
//     public string PrincipalBusinessActivityCd { get; set; }
//
//     [JsonProperty("SequenceReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SequenceReferenceNum")]
//     public string SequenceReferenceNum { get; set; }
//
//     [JsonProperty("SequenceTotalNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SequenceTotalNum")]
//     public string SequenceTotalNum { get; set; }
//
//     [JsonProperty("TradeOrBusinessDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TradeOrBusinessDesc")]
//     public string TradeOrBusinessDesc { get; set; }
//
//     [JsonProperty("GrossReceiptsOrSalesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossReceiptsOrSalesAmt")]
//     public string GrossReceiptsOrSalesAmt { get; set; }
//
//     [JsonProperty("NetGrossReceiptsOrSalesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetGrossReceiptsOrSalesAmt")]
//     public string NetGrossReceiptsOrSalesAmt { get; set; }
//
//     [JsonProperty("GrossProfitAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrossProfitAmt")]
//     public string GrossProfitAmt { get; set; }
//
//     [JsonProperty("TotUnrltTrdBusIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotUnrltTrdBusIncmAmt")]
//     public string TotUnrltTrdBusIncmAmt { get; set; }
//
//     [JsonProperty("TotUnrltTrdBusIncmExpnssAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotUnrltTrdBusIncmExpnssAmt")]
//     public string TotUnrltTrdBusIncmExpnssAmt { get; set; }
//
//     [JsonProperty("TotNetUnrltTrdBusIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotNetUnrltTrdBusIncmAmt")]
//     public string TotNetUnrltTrdBusIncmAmt { get; set; }
//
//     [JsonProperty("TotalDepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalDepreciationAmt")]
//     public TotalDepreciationAmt TotalDepreciationAmt { get; set; }
//
//     [JsonProperty("DepreciationNetAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationNetAmt")]
//     public string DepreciationNetAmt { get; set; }
//
//     [JsonProperty("TotalDeductionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalDeductionsAmt")]
//     public string TotalDeductionsAmt { get; set; }
//
//     [JsonProperty("UBIBeforeNOLDedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UBIBeforeNOLDedAmt")]
//     public string UBIBeforeNOLDedAmt { get; set; }
//
//     [JsonProperty("UnrelatedBusinessTaxblIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessTaxblIncmAmt")]
//     public string UnrelatedBusinessTaxblIncmAmt { get; set; }
//
//     [JsonProperty("UnrelatedDebtFinancedPropGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedDebtFinancedPropGrp")]
//     public UnrelatedDebtFinancedPropGrp UnrelatedDebtFinancedPropGrp { get; set; }
//
//     [JsonProperty("OtherIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherIncomeAmt")]
//     public OtherIncomeAmt OtherIncomeAmt { get; set; }
//
//     [JsonProperty("SalariesAndWagesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SalariesAndWagesAmt")]
//     public string SalariesAndWagesAmt { get; set; }
//
//     [JsonProperty("RepairsAndMaintenanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RepairsAndMaintenanceAmt")]
//     public string RepairsAndMaintenanceAmt { get; set; }
//
//     [JsonProperty("InterestDeductionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InterestDeductionAmt")]
//     public InterestDeductionAmt InterestDeductionAmt { get; set; }
//
//     [JsonProperty("TaxesAndLicensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxesAndLicensesAmt")]
//     public string TaxesAndLicensesAmt { get; set; }
//
//     [JsonProperty("OtherDeductionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherDeductionsAmt")]
//     public OtherDeductionsAmt OtherDeductionsAmt { get; set; }
//
//     [JsonProperty("NetOperatingLossDeductionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetOperatingLossDeductionAmt")]
//     public NetOperatingLossDeductionAmt NetOperatingLossDeductionAmt { get; set; }
//
//     [JsonProperty("CapitalGainNetIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CapitalGainNetIncomeAmt")]
//     public CapitalGainNetIncomeAmt CapitalGainNetIncomeAmt { get; set; }
//
//     [JsonProperty("TotalPrtshpSCorpIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalPrtshpSCorpIncomeAmt")]
//     public TotalPrtshpSCorpIncomeAmt TotalPrtshpSCorpIncomeAmt { get; set; }
//
//     [JsonProperty("TotalRentIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRentIncomeAmt")]
//     public string TotalRentIncomeAmt { get; set; }
//
//     [JsonProperty("TotalRentDeductionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRentDeductionsAmt")]
//     public string TotalRentDeductionsAmt { get; set; }
//
//     [JsonProperty("TotalGrossDebtFinancedIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalGrossDebtFinancedIncmAmt")]
//     public string TotalGrossDebtFinancedIncmAmt { get; set; }
//
//     [JsonProperty("TotalAllocableDeductionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAllocableDeductionsAmt")]
//     public string TotalAllocableDeductionsAmt { get; set; }
//
//     [JsonProperty("TotalDividendsReceivedDedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalDividendsReceivedDedAmt")]
//     public string TotalDividendsReceivedDedAmt { get; set; }
//
//     [JsonProperty("TotalCtrlOrgPymtGrossIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCtrlOrgPymtGrossIncmAmt")]
//     public string TotalCtrlOrgPymtGrossIncmAmt { get; set; }
//
//     [JsonProperty("TotalCtrlOrgDeductionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCtrlOrgDeductionAmt")]
//     public string TotalCtrlOrgDeductionAmt { get; set; }
//
//     [JsonProperty("TotalInvestmentIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalInvestmentIncomeAmt")]
//     public string TotalInvestmentIncomeAmt { get; set; }
//
//     [JsonProperty("TotalDeductionSetAsidesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalDeductionSetAsidesAmt")]
//     public string TotalDeductionSetAsidesAmt { get; set; }
//
//     [JsonProperty("TotalGrossAdvertisingIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalGrossAdvertisingIncomeAmt")]
//     public string TotalGrossAdvertisingIncomeAmt { get; set; }
//
//     [JsonProperty("TotalDirectAdvertisingCostAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalDirectAdvertisingCostAmt")]
//     public string TotalDirectAdvertisingCostAmt { get; set; }
//
//     [JsonProperty("TotExcessReadershipCostsDedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotExcessReadershipCostsDedAmt")]
//     public string TotExcessReadershipCostsDedAmt { get; set; }
//
//     [JsonProperty("TotalUnrelatedBusinessCompAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalUnrelatedBusinessCompAmt")]
//     public string TotalUnrelatedBusinessCompAmt { get; set; }
// }
//
// public class ItmzdSupplementalInfoGrp
// {
//     [JsonProperty("PartNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PartNum")]
//     public string PartNum { get; set; }
//
//     [JsonProperty("LineNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LineNum")]
//     public string LineNum { get; set; }
//
//     [JsonProperty("ExplanationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExplanationTxt")]
//     public string ExplanationTxt { get; set; }
// }
//
// public class KeroseneUsedInAvnTxd219CrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class KeroseneUsedInAvnTxd244CrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class KrsnAvnSoldStLocalGovtCrAmt
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class KrsnFuelSoldStLocalGovtCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class LandAndBuildingsGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class LandBldgEquipBasisNetGrp
// {
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
//
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
// }
//
// public class LandBldgInvestmentsEOYAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
// }
//
// public class LandEOYAmt
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
//
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
// }
//
// public class LandEtcGrp
// {
//     [JsonProperty("CategoryOrItemTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CategoryOrItemTxt")]
//     public string CategoryOrItemTxt { get; set; }
//
//     [JsonProperty("CostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CostOrOtherBasisAmt")]
//     public string CostOrOtherBasisAmt { get; set; }
//
//     [JsonProperty("AccumulatedDepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AccumulatedDepreciationAmt")]
//     public string AccumulatedDepreciationAmt { get; set; }
//
//     [JsonProperty("BookValueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BookValueAmt")]
//     public string BookValueAmt { get; set; }
//
//     [JsonProperty("EOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYFMVAmt")]
//     public string EOYFMVAmt { get; set; }
// }
//
// public class LandEtcSchedule2
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("LandEtcGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LandEtcGrp")]
//     public LandEtcGrp LandEtcGrp { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class LandGrp
// {
//     [JsonProperty("OtherCostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherCostOrOtherBasisAmt")]
//     public string OtherCostOrOtherBasisAmt { get; set; }
//
//     [JsonProperty("BookValueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BookValueAmt")]
//     public string BookValueAmt { get; set; }
//
//     [JsonProperty("InvestmentCostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentCostOrOtherBasisAmt")]
//     public string InvestmentCostOrOtherBasisAmt { get; set; }
// }
//
// public class LeadershipDevelopmentGrp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
// }
//
// public class LeaseholdImprovementsGrp
// {
//     [JsonProperty("OtherCostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherCostOrOtherBasisAmt")]
//     public string OtherCostOrOtherBasisAmt { get; set; }
//
//     [JsonProperty("DepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationAmt")]
//     public string DepreciationAmt { get; set; }
//
//     [JsonProperty("BookValueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BookValueAmt")]
//     public string BookValueAmt { get; set; }
//
//     [JsonProperty("InvestmentCostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentCostOrOtherBasisAmt")]
//     public string InvestmentCostOrOtherBasisAmt { get; set; }
// }
//
// public class LegalFeesGrp
// {
//     [JsonProperty("CategoryTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CategoryTxt")]
//     public string CategoryTxt { get; set; }
//
//     [JsonProperty("LegalFeesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LegalFeesAmt")]
//     public string LegalFeesAmt { get; set; }
//
//     [JsonProperty("NetInvestmentIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetInvestmentIncomeAmt")]
//     public string NetInvestmentIncomeAmt { get; set; }
//
//     [JsonProperty("AdjustedNetIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedNetIncomeAmt")]
//     public string AdjustedNetIncomeAmt { get; set; }
//
//     [JsonProperty("DisbursementsCharitablePrpsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisbursementsCharitablePrpsAmt")]
//     public string DisbursementsCharitablePrpsAmt { get; set; }
// }
//
// public class LegalFeesRevAndExpnssAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
// }
//
// public class LegalFeesSchedule
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("LegalFeesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LegalFeesGrp")]
//     public LegalFeesGrp LegalFeesGrp { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class LenderNameGrp
// {
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
//
//     [JsonProperty("PersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonNm")]
//     public string PersonNm { get; set; }
// }
//
// public class LessCostOthBasisSalesExpnssGrp
// {
//     [JsonProperty("SecuritiesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SecuritiesAmt")]
//     public string SecuritiesAmt { get; set; }
//
//     [JsonProperty("OtherAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherAmt")]
//     public string OtherAmt { get; set; }
// }
//
// public class LessRentalExpensesGrp
// {
//     [JsonProperty("PersonalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonalAmt")]
//     public string PersonalAmt { get; set; }
//
//     [JsonProperty("RealAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RealAmt")]
//     public string RealAmt { get; set; }
// }
//
// public class LiquefiedGasDerBiomassCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class LiquefiedHydrogenCreditAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class LiquefiedNaturalGasCreditAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class LiquefiedPetroleumGasCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class LiquidationExplanationStmt
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("ExplanationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExplanationTxt")]
//     public string ExplanationTxt { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class LiquidationOfAssetsDetail
// {
//     [JsonProperty("AssetsDistriOrExpnssPaidDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AssetsDistriOrExpnssPaidDesc")]
//     public string AssetsDistriOrExpnssPaidDesc { get; set; }
//
//     [JsonProperty("DistributionDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributionDt")]
//     public string DistributionDt { get; set; }
//
//     [JsonProperty("FairMarketValueOfAssetAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FairMarketValueOfAssetAmt")]
//     public string FairMarketValueOfAssetAmt { get; set; }
//
//     [JsonProperty("MethodOfFMVDeterminationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfFMVDeterminationTxt")]
//     public string MethodOfFMVDeterminationTxt { get; set; }
//
//     [JsonProperty("EIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EIN")]
//     public string EIN { get; set; }
//
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
// }
//
// public class LiquidationOfAssetsTableGrp
// {
//     [JsonProperty("LiquidationOfAssetsDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LiquidationOfAssetsDetail")]
//     public LiquidationOfAssetsDetail LiquidationOfAssetsDetail { get; set; }
//
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
// }
//
// public class LiquidFuelDerBiomassCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class LiquidFuelDerFromCoalCreditAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class LoansBtwnOrgInterestedPrsnGrp
// {
//     [JsonProperty("PersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonNm")]
//     public string PersonNm { get; set; }
//
//     [JsonProperty("RelationshipWithOrgTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelationshipWithOrgTxt")]
//     public string RelationshipWithOrgTxt { get; set; }
//
//     [JsonProperty("LoanPurposeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoanPurposeTxt")]
//     public string LoanPurposeTxt { get; set; }
//
//     [JsonProperty("LoanToOrganizationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoanToOrganizationInd")]
//     public string LoanToOrganizationInd { get; set; }
//
//     [JsonProperty("OriginalPrincipalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OriginalPrincipalAmt")]
//     public string OriginalPrincipalAmt { get; set; }
//
//     [JsonProperty("BalanceDueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BalanceDueAmt")]
//     public string BalanceDueAmt { get; set; }
//
//     [JsonProperty("DefaultInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DefaultInd")]
//     public string DefaultInd { get; set; }
//
//     [JsonProperty("BoardOrCommitteeApprovalInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BoardOrCommitteeApprovalInd")]
//     public string BoardOrCommitteeApprovalInd { get; set; }
//
//     [JsonProperty("WrittenAgreementInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("WrittenAgreementInd")]
//     public string WrittenAgreementInd { get; set; }
//
//     [JsonProperty("LoanFromOrganizationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoanFromOrganizationInd")]
//     public string LoanFromOrganizationInd { get; set; }
// }
//
// public class LoansFromOfficerGrp
// {
//     [JsonProperty("LenderPersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LenderPersonNm")]
//     public string LenderPersonNm { get; set; }
//
//     [JsonProperty("TitleTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TitleTxt")]
//     public string TitleTxt { get; set; }
//
//     [JsonProperty("BalanceDueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BalanceDueAmt")]
//     public string BalanceDueAmt { get; set; }
//
//     [JsonProperty("LoanPurposeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoanPurposeTxt")]
//     public string LoanPurposeTxt { get; set; }
//
//     [JsonProperty("LoanOriginalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoanOriginalAmt")]
//     public string LoanOriginalAmt { get; set; }
//
//     [JsonProperty("SecurityProvidedBorrowerTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SecurityProvidedBorrowerTxt")]
//     public string SecurityProvidedBorrowerTxt { get; set; }
// }
//
// public class LoansFromOfficersDirectorsGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class LoansFromOfficersSchedule
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("LoansFromOfficerGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoansFromOfficerGrp")]
//     public LoansFromOfficerGrp LoansFromOfficerGrp { get; set; }
// }
//
// public class LobbyingNontaxableAmountGrp
// {
//     [JsonProperty("FilingOrganizationsTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FilingOrganizationsTotalAmt")]
//     public string FilingOrganizationsTotalAmt { get; set; }
//
//     [JsonProperty("AffiliatedGroupTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AffiliatedGroupTotalAmt")]
//     public string AffiliatedGroupTotalAmt { get; set; }
// }
//
// public class LocationOfBooksForeignAddress
// {
//     [JsonProperty("AddressLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine1Txt")]
//     public string AddressLine1Txt { get; set; }
//
//     [JsonProperty("CityNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CityNm")]
//     public string CityNm { get; set; }
//
//     [JsonProperty("ProvinceOrStateNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProvinceOrStateNm")]
//     public string ProvinceOrStateNm { get; set; }
//
//     [JsonProperty("CountryCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CountryCd")]
//     public string CountryCd { get; set; }
//
//     [JsonProperty("ForeignPostalCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignPostalCd")]
//     public string ForeignPostalCd { get; set; }
//
//     [JsonProperty("AddressLine2Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine2Txt")]
//     public string AddressLine2Txt { get; set; }
// }
//
// public class LocationOfBooksUSAddress
// {
//     [JsonProperty("AddressLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine1Txt")]
//     public string AddressLine1Txt { get; set; }
//
//     [JsonProperty("CityNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CityNm")]
//     public string CityNm { get; set; }
//
//     [JsonProperty("StateAbbreviationCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StateAbbreviationCd")]
//     public string StateAbbreviationCd { get; set; }
//
//     [JsonProperty("ZIPCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ZIPCd")]
//     public string ZIPCd { get; set; }
//
//     [JsonProperty("AddressLine2Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine2Txt")]
//     public string AddressLine2Txt { get; set; }
// }
//
// public class LongTermCapitalGainAndLossGrp
// {
//     [JsonProperty("TransactionsNotRptedOn1099BInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransactionsNotRptedOn1099BInd")]
//     public string TransactionsNotRptedOn1099BInd { get; set; }
//
//     [JsonProperty("CapitalGainAndLossAssetGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CapitalGainAndLossAssetGrp")]
//     public CapitalGainAndLossAssetGrp CapitalGainAndLossAssetGrp { get; set; }
//
//     [JsonProperty("TotalGainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalGainOrLossAmt")]
//     public string TotalGainOrLossAmt { get; set; }
//
//     [JsonProperty("TotalProceedsSalesPriceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalProceedsSalesPriceAmt")]
//     public string TotalProceedsSalesPriceAmt { get; set; }
//
//     [JsonProperty("TotalCostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCostOrOtherBasisAmt")]
//     public string TotalCostOrOtherBasisAmt { get; set; }
//
//     [JsonProperty("TotAdjustmentsToGainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotAdjustmentsToGainOrLossAmt")]
//     public string TotAdjustmentsToGainOrLossAmt { get; set; }
//
//     [JsonProperty("TransRptOn1099BThatShowBssInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransRptOn1099BThatShowBssInd")]
//     public string TransRptOn1099BThatShowBssInd { get; set; }
// }
//
// public class LowIncomeHousingCreditGrp
// {
//     [JsonProperty("LowIncomeHousingCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LowIncomeHousingCreditAmt")]
//     public string LowIncomeHousingCreditAmt { get; set; }
// }
//
// public class LUSTTxAvnFuelFrgnTradeCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class LUSTTxKrsnAvnFrgnTrdCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class LUSTTxSlsKrsnAvnFrgnTrdCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class MaintainedExpenditureRspnsInd
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ManagementCoAndJntVenturesGrp
// {
//     [JsonProperty("EntityName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EntityName")]
//     public EntityName EntityName { get; set; }
//
//     [JsonProperty("PrimaryActivitiesTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrimaryActivitiesTxt")]
//     public string PrimaryActivitiesTxt { get; set; }
//
//     [JsonProperty("OrgProfitOrOwnershipPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrgProfitOrOwnershipPct")]
//     public string OrgProfitOrOwnershipPct { get; set; }
//
//     [JsonProperty("OfcrEtcProfitOrOwnershipPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OfcrEtcProfitOrOwnershipPct")]
//     public string OfcrEtcProfitOrOwnershipPct { get; set; }
//
//     [JsonProperty("PhysiciansProfitOrOwnershipPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PhysiciansProfitOrOwnershipPct")]
//     public string PhysiciansProfitOrOwnershipPct { get; set; }
// }
//
// public class MethodOfAccountingOtherInd
// {
//     [JsonProperty("@methodOfAccountingOtherDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@methodOfAccountingOtherDesc")]
//     public string MethodOfAccountingOtherDesc { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class MineRescueTeamTrainingCrGrp
// {
//     [JsonProperty("MineRescueTeamTrainingCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MineRescueTeamTrainingCrAmt")]
//     public string MineRescueTeamTrainingCrAmt { get; set; }
// }
//
// public class MinimumAssetAmountGrp
// {
//     [JsonProperty("AverageMonthlyFMVOfSecGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AverageMonthlyFMVOfSecGrp")]
//     public AverageMonthlyFMVOfSecGrp AverageMonthlyFMVOfSecGrp { get; set; }
//
//     [JsonProperty("AverageMonthlyCashBalancesGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AverageMonthlyCashBalancesGrp")]
//     public AverageMonthlyCashBalancesGrp AverageMonthlyCashBalancesGrp { get; set; }
//
//     [JsonProperty("FMVOtherNonExemptUseAssetGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FMVOtherNonExemptUseAssetGrp")]
//     public FMVOtherNonExemptUseAssetGrp FMVOtherNonExemptUseAssetGrp { get; set; }
//
//     [JsonProperty("TotalFMVOfNonExemptUseAssetGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalFMVOfNonExemptUseAssetGrp")]
//     public TotalFMVOfNonExemptUseAssetGrp TotalFMVOfNonExemptUseAssetGrp { get; set; }
//
//     [JsonProperty("DiscountClaimedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DiscountClaimedAmt")]
//     public string DiscountClaimedAmt { get; set; }
//
//     [JsonProperty("AcquisitionIndebtednessGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AcquisitionIndebtednessGrp")]
//     public AcquisitionIndebtednessGrp AcquisitionIndebtednessGrp { get; set; }
//
//     [JsonProperty("AdjustedFMVLessIndebtednessGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedFMVLessIndebtednessGrp")]
//     public AdjustedFMVLessIndebtednessGrp AdjustedFMVLessIndebtednessGrp { get; set; }
//
//     [JsonProperty("CashDeemedCharitableGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashDeemedCharitableGrp")]
//     public CashDeemedCharitableGrp CashDeemedCharitableGrp { get; set; }
//
//     [JsonProperty("NetVlNonExemptUseAssetsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetVlNonExemptUseAssetsGrp")]
//     public NetVlNonExemptUseAssetsGrp NetVlNonExemptUseAssetsGrp { get; set; }
//
//     [JsonProperty("PctOfNetVlNonExemptUseAstGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PctOfNetVlNonExemptUseAstGrp")]
//     public PctOfNetVlNonExemptUseAstGrp PctOfNetVlNonExemptUseAstGrp { get; set; }
//
//     [JsonProperty("RecoveriesPYDistriMinAssetGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecoveriesPYDistriMinAssetGrp")]
//     public RecoveriesPYDistriMinAssetGrp RecoveriesPYDistriMinAssetGrp { get; set; }
//
//     [JsonProperty("TotalMinimumAssetGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalMinimumAssetGrp")]
//     public TotalMinimumAssetGrp TotalMinimumAssetGrp { get; set; }
// }
//
// public class MinimumInvestmentReturnGrp
// {
//     [JsonProperty("AverageMonthlyFMVOfSecAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AverageMonthlyFMVOfSecAmt")]
//     public string AverageMonthlyFMVOfSecAmt { get; set; }
//
//     [JsonProperty("AverageMonthlyCashBalancesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AverageMonthlyCashBalancesAmt")]
//     public string AverageMonthlyCashBalancesAmt { get; set; }
//
//     [JsonProperty("FMVAllOtherNoncharitableAstAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FMVAllOtherNoncharitableAstAmt")]
//     public string FMVAllOtherNoncharitableAstAmt { get; set; }
//
//     [JsonProperty("TotalFMVOfUnusedAssetsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalFMVOfUnusedAssetsAmt")]
//     public string TotalFMVOfUnusedAssetsAmt { get; set; }
//
//     [JsonProperty("ReductionClaimedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReductionClaimedAmt")]
//     public string ReductionClaimedAmt { get; set; }
//
//     [JsonProperty("AcquisitionIndebtednessAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AcquisitionIndebtednessAmt")]
//     public string AcquisitionIndebtednessAmt { get; set; }
//
//     [JsonProperty("AdjustedTotalFMVOfUnusedAstAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedTotalFMVOfUnusedAstAmt")]
//     public string AdjustedTotalFMVOfUnusedAstAmt { get; set; }
//
//     [JsonProperty("CashDeemedCharitableAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashDeemedCharitableAmt")]
//     public string CashDeemedCharitableAmt { get; set; }
//
//     [JsonProperty("NetVlNoncharitableAssetsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetVlNoncharitableAssetsAmt")]
//     public string NetVlNoncharitableAssetsAmt { get; set; }
//
//     [JsonProperty("MinimumInvestmentReturnAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MinimumInvestmentReturnAmt")]
//     public string MinimumInvestmentReturnAmt { get; set; }
// }
//
// public class MiscellaneousRevenueGrp
// {
//     [JsonProperty("TotalRevenueColumnAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevenueColumnAmt")]
//     public string TotalRevenueColumnAmt { get; set; }
//
//     [JsonProperty("RelatedOrExemptFuncIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFuncIncomeAmt")]
//     public string RelatedOrExemptFuncIncomeAmt { get; set; }
//
//     [JsonProperty("UnrelatedBusinessRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessRevenueAmt")]
//     public string UnrelatedBusinessRevenueAmt { get; set; }
//
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
// }
//
// public class MoreThanHalfBusinessUseProp
// {
//     [JsonProperty("PropertyDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PropertyDesc")]
//     public string PropertyDesc { get; set; }
//
//     [JsonProperty("PlacedInServiceDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PlacedInServiceDt")]
//     public string PlacedInServiceDt { get; set; }
//
//     [JsonProperty("CostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CostOrOtherBasisAmt")]
//     public string CostOrOtherBasisAmt { get; set; }
//
//     [JsonProperty("RecoveryPrd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecoveryPrd")]
//     public string RecoveryPrd { get; set; }
//
//     [JsonProperty("DeprecMthdAndConventionTypeCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DeprecMthdAndConventionTypeCd")]
//     public string DeprecMthdAndConventionTypeCd { get; set; }
//
//     [JsonProperty("DepreciationDeductionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationDeductionAmt")]
//     public string DepreciationDeductionAmt { get; set; }
//
//     [JsonProperty("BusinessInvestmentUsePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessInvestmentUsePct")]
//     public string BusinessInvestmentUsePct { get; set; }
//
//     [JsonProperty("BasisForDepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BasisForDepreciationAmt")]
//     public string BasisForDepreciationAmt { get; set; }
// }
//
// public class MortgagesAndNotesPayableEOYAmt
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class MortgagesAndNotesPayableSch
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("NotePayableGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NotePayableGrp")]
//     public NotePayableGrp NotePayableGrp { get; set; }
//
//     [JsonProperty("MortgageAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MortgageAmt")]
//     public string MortgageAmt { get; set; }
// }
//
// public class MortgNotesPyblScrdInvstPropGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class NameOfInterested
// {
//     [JsonProperty("PersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonNm")]
//     public string PersonNm { get; set; }
// }
//
// public class NECTFilingForm990Ind
// {
//     [JsonProperty("@interestAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@interestAmt")]
//     public string InterestAmt { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class NetAssetsOrFundBalancesGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class NetGainOrLossInvestmentsGrp
// {
//     [JsonProperty("TotalRevenueColumnAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevenueColumnAmt")]
//     public string TotalRevenueColumnAmt { get; set; }
//
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
//
//     [JsonProperty("RelatedOrExemptFuncIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFuncIncomeAmt")]
//     public string RelatedOrExemptFuncIncomeAmt { get; set; }
//
//     [JsonProperty("UnrelatedBusinessRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessRevenueAmt")]
//     public string UnrelatedBusinessRevenueAmt { get; set; }
// }
//
// public class NetIncmFromFundraisingEvtGrp
// {
//     [JsonProperty("TotalRevenueColumnAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevenueColumnAmt")]
//     public string TotalRevenueColumnAmt { get; set; }
//
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
//
//     [JsonProperty("UnrelatedBusinessRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessRevenueAmt")]
//     public string UnrelatedBusinessRevenueAmt { get; set; }
// }
//
// public class NetIncomeFromGamingGrp
// {
//     [JsonProperty("TotalRevenueColumnAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevenueColumnAmt")]
//     public string TotalRevenueColumnAmt { get; set; }
//
//     [JsonProperty("RelatedOrExemptFuncIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFuncIncomeAmt")]
//     public string RelatedOrExemptFuncIncomeAmt { get; set; }
//
//     [JsonProperty("UnrelatedBusinessRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessRevenueAmt")]
//     public string UnrelatedBusinessRevenueAmt { get; set; }
//
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
// }
//
// public class NetIncomeFromOtherUBIGrp
// {
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
// }
//
// public class NetIncomeOrLossGrp
// {
//     [JsonProperty("TotalRevenueColumnAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevenueColumnAmt")]
//     public string TotalRevenueColumnAmt { get; set; }
//
//     [JsonProperty("UnrelatedBusinessRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessRevenueAmt")]
//     public string UnrelatedBusinessRevenueAmt { get; set; }
//
//     [JsonProperty("RelatedOrExemptFuncIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFuncIncomeAmt")]
//     public string RelatedOrExemptFuncIncomeAmt { get; set; }
//
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
// }
//
// public class NetLongTermGainOrLossGrp
// {
//     [JsonProperty("TotalForYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalForYearAmt")]
//     public string TotalForYearAmt { get; set; }
//
//     [JsonProperty("UnrecapturedSection1250GainAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrecapturedSection1250GainAmt")]
//     public string UnrecapturedSection1250GainAmt { get; set; }
// }
//
// public class NetOperatingLossDeductionAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class NetRentalIncomeOrLossGrp
// {
//     [JsonProperty("TotalRevenueColumnAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevenueColumnAmt")]
//     public string TotalRevenueColumnAmt { get; set; }
//
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
//
//     [JsonProperty("RelatedOrExemptFuncIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFuncIncomeAmt")]
//     public string RelatedOrExemptFuncIncomeAmt { get; set; }
//
//     [JsonProperty("UnrelatedBusinessRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessRevenueAmt")]
//     public string UnrelatedBusinessRevenueAmt { get; set; }
// }
//
// public class NetSTCapitalGainAdjNetIncmGrp
// {
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class NetVlNonExemptUseAssetsGrp
// {
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class NewSubstantialContributorsInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class NoDonorRestrictionNetAssetsGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class NonCashPropertyContributionGrp
// {
//     [JsonProperty("ContributorNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributorNum")]
//     public string ContributorNum { get; set; }
//
//     [JsonProperty("NoncashPropertyDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NoncashPropertyDesc")]
//     public string NoncashPropertyDesc { get; set; }
//
//     [JsonProperty("FairMarketValueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FairMarketValueAmt")]
//     public string FairMarketValueAmt { get; set; }
//
//     [JsonProperty("ReceivedDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReceivedDt")]
//     public string ReceivedDt { get; set; }
// }
//
// public class NoncharitableExemptOrgName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
// }
//
// public class NontaxableUseOfGasolineCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class NontaxableUseOfUndyedDiesel
// {
//     [JsonProperty("NontaxableUseOfFuelTypeCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontaxableUseOfFuelTypeCd")]
//     public string NontaxableUseOfFuelTypeCd { get; set; }
//
//     [JsonProperty("GallonsQty", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GallonsQty")]
//     public string GallonsQty { get; set; }
// }
//
// public class NontxCompressedNaturalGasCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class NonTxKrsnUsedInAvnTxd219CrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class NonTxKrsnUsedInAvnTxd244CrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class NontxLiqfdFuelDerFromCoalCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class NontxLiqFuelDerBiomassCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class NontxLiquefiedGasBiomassCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class NontxLiquefiedHydrogenCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class NontxLiquefiedNaturalGasCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class NontxLiquefiedPtrlmGasCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class NontxLiquifiedPetroleumGas
// {
//     [JsonProperty("NontaxableUseOfFuelTypeCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontaxableUseOfFuelTypeCd")]
//     public string NontaxableUseOfFuelTypeCd { get; set; }
//
//     [JsonProperty("GallonsQty", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GallonsQty")]
//     public string GallonsQty { get; set; }
// }
//
// public class NontxPSeriesFuelsCreditAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class NontxUseDieselWtrEmulsionCrAmt
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class NontxUseUndyedKrsnTxd044CrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class NontxUseUndyedKrsnTxd219CrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class NotePayableGrp
// {
//     [JsonProperty("LenderNameGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LenderNameGrp")]
//     public LenderNameGrp LenderNameGrp { get; set; }
//
//     [JsonProperty("TitleTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TitleTxt")]
//     public string TitleTxt { get; set; }
//
//     [JsonProperty("InsiderRelationshipTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InsiderRelationshipTxt")]
//     public string InsiderRelationshipTxt { get; set; }
//
//     [JsonProperty("LoanOriginalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoanOriginalAmt")]
//     public string LoanOriginalAmt { get; set; }
//
//     [JsonProperty("BalanceDueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BalanceDueAmt")]
//     public string BalanceDueAmt { get; set; }
//
//     [JsonProperty("RepaymentTermsTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RepaymentTermsTxt")]
//     public string RepaymentTermsTxt { get; set; }
//
//     [JsonProperty("InterestRt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InterestRt")]
//     public string InterestRt { get; set; }
//
//     [JsonProperty("SecurityProvidedBorrowerTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SecurityProvidedBorrowerTxt")]
//     public string SecurityProvidedBorrowerTxt { get; set; }
//
//     [JsonProperty("LoanPurposeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoanPurposeTxt")]
//     public string LoanPurposeTxt { get; set; }
//
//     [JsonProperty("LenderConsiderationDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LenderConsiderationDesc")]
//     public string LenderConsiderationDesc { get; set; }
//
//     [JsonProperty("ConsiderationFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ConsiderationFMVAmt")]
//     public string ConsiderationFMVAmt { get; set; }
// }
//
// public class OccupancyGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class OfficeExpensesGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class OfficerDirectorTrusteeEmplGrp
// {
//     [JsonProperty("PersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonNm")]
//     public object PersonNm { get; set; }
//
//     [JsonProperty("TitleTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TitleTxt")]
//     public string TitleTxt { get; set; }
//
//     [JsonProperty("AverageHrsPerWkDevotedToPosRt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AverageHrsPerWkDevotedToPosRt")]
//     public string AverageHrsPerWkDevotedToPosRt { get; set; }
//
//     [JsonProperty("CompensationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompensationAmt")]
//     public string CompensationAmt { get; set; }
//
//     [JsonProperty("EmployeeBenefitProgramAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EmployeeBenefitProgramAmt")]
//     public string EmployeeBenefitProgramAmt { get; set; }
//
//     [JsonProperty("ExpenseAccountOtherAllwncAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpenseAccountOtherAllwncAmt")]
//     public string ExpenseAccountOtherAllwncAmt { get; set; }
// }
//
// public class OfficerDirTrstKeyEmplGrp
// {
//     [JsonProperty("PersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonNm")]
//     public object PersonNm { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("TitleTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TitleTxt")]
//     public string TitleTxt { get; set; }
//
//     [JsonProperty("AverageHrsPerWkDevotedToPosRt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AverageHrsPerWkDevotedToPosRt")]
//     public string AverageHrsPerWkDevotedToPosRt { get; set; }
//
//     [JsonProperty("CompensationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompensationAmt")]
//     public string CompensationAmt { get; set; }
//
//     [JsonProperty("EmployeeBenefitProgramAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EmployeeBenefitProgramAmt")]
//     public string EmployeeBenefitProgramAmt { get; set; }
//
//     [JsonProperty("ExpenseAccountOtherAllwncAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpenseAccountOtherAllwncAmt")]
//     public string ExpenseAccountOtherAllwncAmt { get; set; }
// }
//
// public class OfficerDirTrstKeyEmplInfoGrp
// {
//     [JsonProperty("OfficerDirTrstKeyEmplGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OfficerDirTrstKeyEmplGrp")]
//     public List<OfficerDirTrstKeyEmplGrp> OfficerDirTrstKeyEmplGrp { get; } = new List<OfficerDirTrstKeyEmplGrp>();
//
//     [JsonProperty("CompOfHghstPdEmplOrNONETxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompOfHghstPdEmplOrNONETxt")]
//     public string CompOfHghstPdEmplOrNONETxt { get; set; }
//
//     [JsonProperty("CompOfHghstPdCntrctOrNONETxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompOfHghstPdCntrctOrNONETxt")]
//     public string CompOfHghstPdCntrctOrNONETxt { get; set; }
//
//     [JsonProperty("OtherEmployeePaidOver50kCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherEmployeePaidOver50kCnt")]
//     public string OtherEmployeePaidOver50kCnt { get; set; }
//
//     [JsonProperty("ContractorPaidOver50kCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContractorPaidOver50kCnt")]
//     public string ContractorPaidOver50kCnt { get; set; }
//
//     [JsonProperty("CompensationOfHghstPdCntrctGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompensationOfHghstPdCntrctGrp")]
//     public List<CompensationOfHghstPdCntrctGrp> CompensationOfHghstPdCntrctGrp { get; } =
//         new List<CompensationOfHghstPdCntrctGrp>();
//
//     [JsonProperty("CompensationHighestPaidEmplGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompensationHighestPaidEmplGrp")]
//     public CompensationHighestPaidEmplGrp CompensationHighestPaidEmplGrp { get; set; }
// }
//
// public class OfficerOtherRcvblGrp
// {
//     [JsonProperty("BorrowerPersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BorrowerPersonNm")]
//     public string BorrowerPersonNm { get; set; }
//
//     [JsonProperty("BorrowerTitleTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BorrowerTitleTxt")]
//     public string BorrowerTitleTxt { get; set; }
//
//     [JsonProperty("BalanceDueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BalanceDueAmt")]
//     public string BalanceDueAmt { get; set; }
//
//     [JsonProperty("LoanOriginalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoanOriginalAmt")]
//     public string LoanOriginalAmt { get; set; }
//
//     [JsonProperty("InterestRt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InterestRt")]
//     public string InterestRt { get; set; }
//
//     [JsonProperty("ConsiderationFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ConsiderationFMVAmt")]
//     public string ConsiderationFMVAmt { get; set; }
//
//     [JsonProperty("NoteDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NoteDt")]
//     public string NoteDt { get; set; }
//
//     [JsonProperty("LoanMaturityDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoanMaturityDt")]
//     public string LoanMaturityDt { get; set; }
//
//     [JsonProperty("RepaymentTermsTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RepaymentTermsTxt")]
//     public string RepaymentTermsTxt { get; set; }
//
//     [JsonProperty("SecurityProvidedBorrowerTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SecurityProvidedBorrowerTxt")]
//     public string SecurityProvidedBorrowerTxt { get; set; }
//
//     [JsonProperty("LoanPurposeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoanPurposeTxt")]
//     public string LoanPurposeTxt { get; set; }
//
//     [JsonProperty("LenderConsiderationDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LenderConsiderationDesc")]
//     public string LenderConsiderationDesc { get; set; }
// }
//
// public class Organization4947a1NotPFInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class Organization501c3Ind
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
// }
//
// public class Organization501c3Name
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
// }
//
// public class Organization501cInd
// {
//     [JsonProperty("@organization501cTypeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@organization501cTypeTxt")]
//     public string Organization501cTypeTxt { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class Organization501IndicatorGrp
// {
//     [JsonProperty("Organization501Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization501Ind")]
//     public string Organization501Ind { get; set; }
//
//     [JsonProperty("Organization501cTypeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization501cTypeTxt")]
//     public string Organization501cTypeTxt { get; set; }
// }
//
// public class OrganizationBelongsAffltGrpInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class OrganizationBusinessName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
// }
//
// public class OrganizationDissolvedEtcInd
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class OtherAssetsBOYAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
// }
//
// public class OtherAssetsEOYAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
// }
//
// public class OtherAssetsEOYFMVAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
// }
//
// public class OtherAssetsOrgGrp
// {
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("BookValueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BookValueAmt")]
//     public string BookValueAmt { get; set; }
// }
//
// public class OtherAssetsSchedule
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("OtherAssetsScheduleGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherAssetsScheduleGrp")]
//     public OtherAssetsScheduleGrp OtherAssetsScheduleGrp { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class OtherAssetsScheduleGrp
// {
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("BOYBookValueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYBookValueAmt")]
//     public string BOYBookValueAmt { get; set; }
//
//     [JsonProperty("EOYBookValueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYBookValueAmt")]
//     public string EOYBookValueAmt { get; set; }
//
//     [JsonProperty("EOYFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYFMVAmt")]
//     public string EOYFMVAmt { get; set; }
// }
//
// public class OtherAssetsTotalDetail
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class OtherAssetsTotalGrp
// {
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
//
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
// }
//
// public class OtherCommuntityBuildingActyGrp
// {
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
//
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
// }
//
// public class OtherCreditsAmt
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class OtherCurrentYearCreditAmtGrp
// {
//     [JsonProperty("OtherCurrentYearCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherCurrentYearCreditAmt")]
//     public string OtherCurrentYearCreditAmt { get; set; }
// }
//
// public class OtherDecreasesDetail
// {
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Amt")]
//     public string Amt { get; set; }
// }
//
// public class OtherDecreasesSchedule
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("OtherDecreasesDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherDecreasesDetail")]
//     public List<OtherDecreasesDetail> OtherDecreasesDetail { get; } = new List<OtherDecreasesDetail>();
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class OtherDeductionsAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class OtherEmployeeBenefitsGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class OtherExemptPurposeExpendGrp
// {
//     [JsonProperty("FilingOrganizationsTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FilingOrganizationsTotalAmt")]
//     public string FilingOrganizationsTotalAmt { get; set; }
//
//     [JsonProperty("AffiliatedGroupTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AffiliatedGroupTotalAmt")]
//     public string AffiliatedGroupTotalAmt { get; set; }
// }
//
// public class OtherExpensesGrp
// {
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class OtherExpensesRevAndExpnssAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class OtherExpensesSchedule
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("OtherExpensesScheduleGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherExpensesScheduleGrp")]
//     public List<OtherExpensesScheduleGrp> OtherExpensesScheduleGrp { get; } = new List<OtherExpensesScheduleGrp>();
// }
//
// public class OtherExpensesScheduleGrp
// {
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("RevenueAndExpensesPerBooksAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RevenueAndExpensesPerBooksAmt")]
//     public string RevenueAndExpensesPerBooksAmt { get; set; }
//
//     [JsonProperty("NetInvestmentIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetInvestmentIncomeAmt")]
//     public string NetInvestmentIncomeAmt { get; set; }
//
//     [JsonProperty("AdjustedNetIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedNetIncomeAmt")]
//     public string AdjustedNetIncomeAmt { get; set; }
//
//     [JsonProperty("DisbursementsCharitablePrpsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisbursementsCharitablePrpsAmt")]
//     public string DisbursementsCharitablePrpsAmt { get; set; }
// }
//
// public class OtherGrossIncomeGrp
// {
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class OtherIncome170Grp
// {
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class OtherIncome509Grp
// {
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class OtherIncomeAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class OtherIncomeDetail
// {
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("RevenueAndExpensesPerBooksAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RevenueAndExpensesPerBooksAmt")]
//     public string RevenueAndExpensesPerBooksAmt { get; set; }
//
//     [JsonProperty("NetInvestmentIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetInvestmentIncomeAmt")]
//     public string NetInvestmentIncomeAmt { get; set; }
//
//     [JsonProperty("AdjustedNetIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedNetIncomeAmt")]
//     public string AdjustedNetIncomeAmt { get; set; }
// }
//
// public class OtherIncomeRevAndExpnssAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
// }
//
// public class OtherIncomeSchedule2
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("OtherIncomeDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherIncomeDetail")]
//     public List<OtherIncomeDetail> OtherIncomeDetail { get; } = new List<OtherIncomeDetail>();
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class OtherIncreasesDetail
// {
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Amt")]
//     public string Amt { get; set; }
// }
//
// public class OtherIncreasesSchedule
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("OtherIncreasesDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherIncreasesDetail")]
//     public OtherIncreasesDetail OtherIncreasesDetail { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class OtherInvestmentIncmPartVIIGrp
// {
//     [JsonProperty("RelatedOrExemptFunctionIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFunctionIncmAmt")]
//     public string RelatedOrExemptFunctionIncmAmt { get; set; }
// }
//
// public class OtherInvestmentsEOYAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class OtherLandBuildingsGrp
// {
//     [JsonProperty("OtherCostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherCostOrOtherBasisAmt")]
//     public string OtherCostOrOtherBasisAmt { get; set; }
//
//     [JsonProperty("DepreciationAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationAmt")]
//     public string DepreciationAmt { get; set; }
//
//     [JsonProperty("BookValueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BookValueAmt")]
//     public string BookValueAmt { get; set; }
//
//     [JsonProperty("InvestmentCostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentCostOrOtherBasisAmt")]
//     public string InvestmentCostOrOtherBasisAmt { get; set; }
// }
//
// public class OtherLiabilitiesBOYAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
// }
//
// public class OtherLiabilitiesDetail
// {
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("BOYBookValueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYBookValueAmt")]
//     public string BOYBookValueAmt { get; set; }
//
//     [JsonProperty("EOYBookValueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYBookValueAmt")]
//     public string EOYBookValueAmt { get; set; }
// }
//
// public class OtherLiabilitiesEOYAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
// }
//
// public class OtherLiabilitiesGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class OtherLiabilitiesOrgGrp
// {
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Amt")]
//     public string Amt { get; set; }
// }
//
// public class OtherLiabilitiesSchedule
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("OtherLiabilitiesDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherLiabilitiesDetail")]
//     public OtherLiabilitiesDetail OtherLiabilitiesDetail { get; set; }
// }
//
// public class OtherNonCashContriTableGrp
// {
//     [JsonProperty("NonCashCheckboxInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashCheckboxInd")]
//     public string NonCashCheckboxInd { get; set; }
//
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("ContributionCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributionCnt")]
//     public string ContributionCnt { get; set; }
//
//     [JsonProperty("NoncashContributionsRptF990Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NoncashContributionsRptF990Amt")]
//     public string NoncashContributionsRptF990Amt { get; set; }
//
//     [JsonProperty("MethodOfDeterminingRevenuesTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfDeterminingRevenuesTxt")]
//     public string MethodOfDeterminingRevenuesTxt { get; set; }
// }
//
// public class OtherNotesLoansRcvblLongGrp
// {
//     [JsonProperty("BorrowerNameGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BorrowerNameGrp")]
//     public BorrowerNameGrp BorrowerNameGrp { get; set; }
//
//     [JsonProperty("LoanOriginalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoanOriginalAmt")]
//     public string LoanOriginalAmt { get; set; }
//
//     [JsonProperty("BalanceDueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BalanceDueAmt")]
//     public string BalanceDueAmt { get; set; }
//
//     [JsonProperty("InterestRt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InterestRt")]
//     public string InterestRt { get; set; }
//
//     [JsonProperty("ConsiderationFMVAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ConsiderationFMVAmt")]
//     public string ConsiderationFMVAmt { get; set; }
//
//     [JsonProperty("InsiderRelationshipTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InsiderRelationshipTxt")]
//     public string InsiderRelationshipTxt { get; set; }
//
//     [JsonProperty("NoteDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NoteDt")]
//     public string NoteDt { get; set; }
//
//     [JsonProperty("LoanMaturityDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoanMaturityDt")]
//     public string LoanMaturityDt { get; set; }
//
//     [JsonProperty("RepaymentTermsTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RepaymentTermsTxt")]
//     public string RepaymentTermsTxt { get; set; }
//
//     [JsonProperty("LoanPurposeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoanPurposeTxt")]
//     public string LoanPurposeTxt { get; set; }
//
//     [JsonProperty("LenderConsiderationDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LenderConsiderationDesc")]
//     public string LenderConsiderationDesc { get; set; }
// }
//
// public class OtherNotesLoansRcvblLongSch
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("OtherNotesLoansRcvblLongGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherNotesLoansRcvblLongGrp")]
//     public OtherNotesLoansRcvblLongGrp OtherNotesLoansRcvblLongGrp { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
// }
//
// public class OtherNotesLoansRcvblShortGrp
// {
//     [JsonProperty("Organization501c3Name", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Organization501c3Name")]
//     public Organization501c3Name Organization501c3Name { get; set; }
//
//     [JsonProperty("BalanceDueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BalanceDueAmt")]
//     public string BalanceDueAmt { get; set; }
// }
//
// public class OtherNotesLoansRcvblShortSch2
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("OtherNotesLoansRcvblShortGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherNotesLoansRcvblShortGrp")]
//     public OtherNotesLoansRcvblShortGrp OtherNotesLoansRcvblShortGrp { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class OtherNtsAndLoansRcvblEOYAmt
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
//
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
// }
//
// public class OtherOrganizationName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
// }
//
// public class OtherProfessionalFeesDetail
// {
//     [JsonProperty("CategoryTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CategoryTxt")]
//     public string CategoryTxt { get; set; }
//
//     [JsonProperty("Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Amt")]
//     public string Amt { get; set; }
//
//     [JsonProperty("NetInvestmentIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetInvestmentIncomeAmt")]
//     public string NetInvestmentIncomeAmt { get; set; }
//
//     [JsonProperty("DisbursementsCharitablePrpsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisbursementsCharitablePrpsAmt")]
//     public string DisbursementsCharitablePrpsAmt { get; set; }
// }
//
// public class OtherProfessionalFeesSchedule
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("OtherProfessionalFeesDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherProfessionalFeesDetail")]
//     public OtherProfessionalFeesDetail OtherProfessionalFeesDetail { get; set; }
// }
//
// public class OtherProfFeesRevAndExpnssAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
// }
//
// public class OtherReceivablesOfficersSch
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("OfficerTravelAdvanceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OfficerTravelAdvanceAmt")]
//     public string OfficerTravelAdvanceAmt { get; set; }
//
//     [JsonProperty("OfficerOtherRcvblGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OfficerOtherRcvblGrp")]
//     public OfficerOtherRcvblGrp OfficerOtherRcvblGrp { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class OtherRevenueDescribedGrp
// {
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("ExclusionCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionCd")]
//     public string ExclusionCd { get; set; }
//
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
// }
//
// public class OtherRevenueMiscGrp
// {
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("BusinessCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessCd")]
//     public string BusinessCd { get; set; }
//
//     [JsonProperty("TotalRevenueColumnAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevenueColumnAmt")]
//     public string TotalRevenueColumnAmt { get; set; }
//
//     [JsonProperty("RelatedOrExemptFuncIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFuncIncomeAmt")]
//     public string RelatedOrExemptFuncIncomeAmt { get; set; }
//
//     [JsonProperty("UnrelatedBusinessRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessRevenueAmt")]
//     public string UnrelatedBusinessRevenueAmt { get; set; }
//
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
// }
//
// public class OtherSalariesAndWagesGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class OtherSecuritiesGrp
// {
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
// }
//
// public class OtherSpecifiedCreditAmtGrp
// {
//     [JsonProperty("OtherSpecifiedCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherSpecifiedCreditAmt")]
//     public string OtherSpecifiedCreditAmt { get; set; }
// }
//
// public class OthHlthCareFcltsGrp
// {
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("FacilityTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FacilityTxt")]
//     public string FacilityTxt { get; set; }
// }
//
// public class OthHlthCareFcltsNotHospitalGrp
// {
//     [JsonProperty("OthHlthCareFcltsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OthHlthCareFcltsGrp")]
//     public List<OthHlthCareFcltsGrp> OthHlthCareFcltsGrp { get; } = new List<OthHlthCareFcltsGrp>();
// }
//
// public class OthNotesLoansReceivableNetGrp
// {
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
//
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
// }
//
// public class OverpaymentSection
// {
//     [JsonProperty("OverpaymentAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OverpaymentAmt")]
//     public string OverpaymentAmt { get; set; }
//
//     [JsonProperty("AppliedToESTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AppliedToESTaxAmt")]
//     public string AppliedToESTaxAmt { get; set; }
//
//     [JsonProperty("RefundAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RefundAmt")]
//     public string RefundAmt { get; set; }
// }
//
// public class ParentCorporationName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
// }
//
// public class PaymentsToAffiliatesGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class PayrollTaxesGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class PctOfNetVlNonExemptUseAstGrp
// {
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class PdInCapSrplsLandBldgEqpFundGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class PensionPlanContributionsGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class PermanentlyRstrNetAssetsGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class PersonFullName
// {
//     [JsonProperty("PersonFirstNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonFirstNm")]
//     public string PersonFirstNm { get; set; }
//
//     [JsonProperty("PersonLastNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonLastNm")]
//     public string PersonLastNm { get; set; }
// }
//
// public class PersonsWithBooksName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
//
//     [JsonProperty("BusinessNameLine2Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine2Txt")]
//     public string BusinessNameLine2Txt { get; set; }
// }
//
// public class PersonsWithBooksUSAddress
// {
//     [JsonProperty("AddressLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine1Txt")]
//     public string AddressLine1Txt { get; set; }
//
//     [JsonProperty("CityNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CityNm")]
//     public string CityNm { get; set; }
//
//     [JsonProperty("StateAbbreviationCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StateAbbreviationCd")]
//     public string StateAbbreviationCd { get; set; }
//
//     [JsonProperty("ZIPCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ZIPCd")]
//     public string ZIPCd { get; set; }
//
//     [JsonProperty("AddressLine2Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine2Txt")]
//     public string AddressLine2Txt { get; set; }
// }
//
// public class PFQualifyingDistributionsGrp
// {
//     [JsonProperty("ExpensesAndContributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpensesAndContributionsAmt")]
//     public ExpensesAndContributionsAmt ExpensesAndContributionsAmt { get; set; }
//
//     [JsonProperty("QualifyingDistributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("QualifyingDistributionsAmt")]
//     public string QualifyingDistributionsAmt { get; set; }
//
//     [JsonProperty("ProgramRelatedInvstTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramRelatedInvstTotalAmt")]
//     public string ProgramRelatedInvstTotalAmt { get; set; }
//
//     [JsonProperty("SetAsideCashDistriTestAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SetAsideCashDistriTestAmt")]
//     public SetAsideCashDistriTestAmt SetAsideCashDistriTestAmt { get; set; }
//
//     [JsonProperty("CharitableAssetsAcquisPaidAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CharitableAssetsAcquisPaidAmt")]
//     public string CharitableAssetsAcquisPaidAmt { get; set; }
//
//     [JsonProperty("SetAsideSuitabilityTestAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SetAsideSuitabilityTestAmt")]
//     public string SetAsideSuitabilityTestAmt { get; set; }
// }
//
// public class PhysicalImprvAndHousingGrp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
// }
//
// public class PledgesAndGrantsReceivableGrp
// {
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
//
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
// }
//
// public class PoliticalCampaignActyInd
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class Post1975UBTIGrp
// {
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
// }
//
// public class Post2017NOLCarryoverGrp
// {
//     [JsonProperty("PrincipalBusinessActivityCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrincipalBusinessActivityCd")]
//     public string PrincipalBusinessActivityCd { get; set; }
//
//     [JsonProperty("AvlblPost2017NOLCarryoverAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AvlblPost2017NOLCarryoverAmt")]
//     public string AvlblPost2017NOLCarryoverAmt { get; set; }
// }
//
// public class PrepaidExpensesDefrdChargesGrp
// {
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
//
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
// }
//
// public class PreparerFirmGrp
// {
//     [JsonProperty("PreparerFirmEIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PreparerFirmEIN")]
//     public string PreparerFirmEIN { get; set; }
//
//     [JsonProperty("PreparerFirmName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PreparerFirmName")]
//     public PreparerFirmName PreparerFirmName { get; set; }
//
//     [JsonProperty("PreparerUSAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PreparerUSAddress")]
//     public PreparerUSAddress PreparerUSAddress { get; set; }
//
//     [JsonProperty("PreparerForeignAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PreparerForeignAddress")]
//     public PreparerForeignAddress PreparerForeignAddress { get; set; }
// }
//
// public class PreparerFirmName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
//
//     [JsonProperty("BusinessNameLine2Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine2Txt")]
//     public string BusinessNameLine2Txt { get; set; }
// }
//
// public class PreparerForeignAddress
// {
//     [JsonProperty("AddressLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine1Txt")]
//     public string AddressLine1Txt { get; set; }
//
//     [JsonProperty("CityNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CityNm")]
//     public string CityNm { get; set; }
//
//     [JsonProperty("ProvinceOrStateNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProvinceOrStateNm")]
//     public string ProvinceOrStateNm { get; set; }
//
//     [JsonProperty("CountryCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CountryCd")]
//     public string CountryCd { get; set; }
//
//     [JsonProperty("ForeignPostalCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignPostalCd")]
//     public string ForeignPostalCd { get; set; }
// }
//
// public class PreparerPersonGrp
// {
//     [JsonProperty("PreparerPersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PreparerPersonNm")]
//     public string PreparerPersonNm { get; set; }
//
//     [JsonProperty("PTIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PTIN")]
//     public string PTIN { get; set; }
//
//     [JsonProperty("PhoneNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PhoneNum")]
//     public string PhoneNum { get; set; }
//
//     [JsonProperty("PreparationDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PreparationDt")]
//     public string PreparationDt { get; set; }
//
//     [JsonProperty("SelfEmployedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SelfEmployedInd")]
//     public string SelfEmployedInd { get; set; }
//
//     [JsonProperty("SSN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SSN")]
//     public string SSN { get; set; }
//
//     [JsonProperty("ForeignPhoneNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignPhoneNum")]
//     public string ForeignPhoneNum { get; set; }
// }
//
// public class PreparerUSAddress
// {
//     [JsonProperty("AddressLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine1Txt")]
//     public string AddressLine1Txt { get; set; }
//
//     [JsonProperty("CityNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CityNm")]
//     public string CityNm { get; set; }
//
//     [JsonProperty("StateAbbreviationCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StateAbbreviationCd")]
//     public string StateAbbreviationCd { get; set; }
//
//     [JsonProperty("ZIPCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ZIPCd")]
//     public string ZIPCd { get; set; }
//
//     [JsonProperty("AddressLine2Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine2Txt")]
//     public string AddressLine2Txt { get; set; }
// }
//
// public class PrincipalOfcrBusinessName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
//
//     [JsonProperty("BusinessNameLine2Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine2Txt")]
//     public string BusinessNameLine2Txt { get; set; }
// }
//
// public class ProductionIncomeGrp
// {
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class ProfessionalFundraisingInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ProgramServiceRevenueDtl
// {
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("RelatedOrExemptFunctionIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFunctionIncmAmt")]
//     public string RelatedOrExemptFunctionIncmAmt { get; set; }
//
//     [JsonProperty("UnrelatedBusinessTaxblIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessTaxblIncmAmt")]
//     public string UnrelatedBusinessTaxblIncmAmt { get; set; }
//
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
// }
//
// public class ProgramServiceRevenueGrp
// {
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("TotalRevenueColumnAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevenueColumnAmt")]
//     public string TotalRevenueColumnAmt { get; set; }
//
//     [JsonProperty("RelatedOrExemptFuncIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFuncIncomeAmt")]
//     public string RelatedOrExemptFuncIncomeAmt { get; set; }
// }
//
// public class ProgramServiceRevPartVIIGrp
// {
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("RelatedOrExemptFunctionIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFunctionIncmAmt")]
//     public string RelatedOrExemptFunctionIncmAmt { get; set; }
// }
//
// public class ProgramSrvcAccomplishmentGrp
// {
//     [JsonProperty("DescriptionProgramSrvcAccomTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DescriptionProgramSrvcAccomTxt")]
//     public string DescriptionProgramSrvcAccomTxt { get; set; }
//
//     [JsonProperty("GrantsAndAllocationsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsAndAllocationsAmt")]
//     public string GrantsAndAllocationsAmt { get; set; }
//
//     [JsonProperty("ProgramServiceExpensesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServiceExpensesAmt")]
//     public string ProgramServiceExpensesAmt { get; set; }
// }
//
// public class ProgSrvcAccomActy2Grp
// {
//     [JsonProperty("ExpenseAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpenseAmt")]
//     public string ExpenseAmt { get; set; }
//
//     [JsonProperty("GrantAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantAmt")]
//     public string GrantAmt { get; set; }
//
//     [JsonProperty("RevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RevenueAmt")]
//     public string RevenueAmt { get; set; }
//
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("ActivityCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivityCd")]
//     public string ActivityCd { get; set; }
// }
//
// public class ProgSrvcAccomActy3Grp
// {
//     [JsonProperty("ExpenseAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpenseAmt")]
//     public string ExpenseAmt { get; set; }
//
//     [JsonProperty("RevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RevenueAmt")]
//     public string RevenueAmt { get; set; }
//
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("GrantAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantAmt")]
//     public string GrantAmt { get; set; }
//
//     [JsonProperty("ActivityCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivityCd")]
//     public string ActivityCd { get; set; }
// }
//
// public class ProgSrvcAccomActyOtherGrp
// {
//     [JsonProperty("ExpenseAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpenseAmt")]
//     public string ExpenseAmt { get; set; }
//
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
// }
//
// public class PSeriesFuelsCreditAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class PymtTravelEntrtnmntPubOfclGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class QlfyPlugInElecDriveMtrVehCrGrp
// {
//     [JsonProperty("QlfyPlugInElecDriveMtrVehCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("QlfyPlugInElecDriveMtrVehCrAmt")]
//     public string QlfyPlugInElecDriveMtrVehCrAmt { get; set; }
// }
//
// public class QlfyUndSect4940eReducedTaxGrp
// {
//     [JsonProperty("LiableSection4942TaxInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LiableSection4942TaxInd")]
//     public string LiableSection4942TaxInd { get; set; }
//
//     [JsonProperty("AdjustedQlfyDistriYr1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedQlfyDistriYr1Amt")]
//     public string AdjustedQlfyDistriYr1Amt { get; set; }
//
//     [JsonProperty("NetVlNoncharitableAssetsYr1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetVlNoncharitableAssetsYr1Amt")]
//     public string NetVlNoncharitableAssetsYr1Amt { get; set; }
//
//     [JsonProperty("DistributionYr1Rt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributionYr1Rt")]
//     public string DistributionYr1Rt { get; set; }
//
//     [JsonProperty("AdjustedQlfyDistriYr2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedQlfyDistriYr2Amt")]
//     public string AdjustedQlfyDistriYr2Amt { get; set; }
//
//     [JsonProperty("NetVlNoncharitableAssetsYr2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetVlNoncharitableAssetsYr2Amt")]
//     public string NetVlNoncharitableAssetsYr2Amt { get; set; }
//
//     [JsonProperty("DistributionYr2Rt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributionYr2Rt")]
//     public string DistributionYr2Rt { get; set; }
//
//     [JsonProperty("AdjustedQlfyDistriYr3Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedQlfyDistriYr3Amt")]
//     public string AdjustedQlfyDistriYr3Amt { get; set; }
//
//     [JsonProperty("NetVlNoncharitableAssetsYr3Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetVlNoncharitableAssetsYr3Amt")]
//     public string NetVlNoncharitableAssetsYr3Amt { get; set; }
//
//     [JsonProperty("DistributionYr3Rt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributionYr3Rt")]
//     public string DistributionYr3Rt { get; set; }
//
//     [JsonProperty("AdjustedQlfyDistriYr4Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedQlfyDistriYr4Amt")]
//     public string AdjustedQlfyDistriYr4Amt { get; set; }
//
//     [JsonProperty("NetVlNoncharitableAssetsYr4Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetVlNoncharitableAssetsYr4Amt")]
//     public string NetVlNoncharitableAssetsYr4Amt { get; set; }
//
//     [JsonProperty("DistributionYr4Rt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributionYr4Rt")]
//     public string DistributionYr4Rt { get; set; }
//
//     [JsonProperty("AdjustedQlfyDistriYr5Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedQlfyDistriYr5Amt")]
//     public string AdjustedQlfyDistriYr5Amt { get; set; }
//
//     [JsonProperty("NetVlNoncharitableAssetsYr5Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetVlNoncharitableAssetsYr5Amt")]
//     public string NetVlNoncharitableAssetsYr5Amt { get; set; }
//
//     [JsonProperty("DistributionYr5Rt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributionYr5Rt")]
//     public string DistributionYr5Rt { get; set; }
//
//     [JsonProperty("TotalDistributionRt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalDistributionRt")]
//     public string TotalDistributionRt { get; set; }
//
//     [JsonProperty("AverageDistributionRt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AverageDistributionRt")]
//     public string AverageDistributionRt { get; set; }
//
//     [JsonProperty("NetVlNoncharitableAssetsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetVlNoncharitableAssetsAmt")]
//     public string NetVlNoncharitableAssetsAmt { get; set; }
//
//     [JsonProperty("AdjNetVlNoncharitableAssetsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjNetVlNoncharitableAssetsAmt")]
//     public string AdjNetVlNoncharitableAssetsAmt { get; set; }
//
//     [JsonProperty("NetInvestmentIncomePctAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetInvestmentIncomePctAmt")]
//     public string NetInvestmentIncomePctAmt { get; set; }
//
//     [JsonProperty("AdjNonchrtblNetInvstIncmPctAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjNonchrtblNetInvstIncmPctAmt")]
//     public string AdjNonchrtblNetInvstIncmPctAmt { get; set; }
//
//     [JsonProperty("QualifyingDistributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("QualifyingDistributionsAmt")]
//     public string QualifyingDistributionsAmt { get; set; }
// }
//
// public class QualifiedRailroadTrackMaintGrp
// {
//     [JsonProperty("QualifiedRailroadTrackMaintAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("QualifiedRailroadTrackMaintAmt")]
//     public string QualifiedRailroadTrackMaintAmt { get; set; }
// }
//
// public class QualifyingDistriPartXIIGrp
// {
//     [JsonProperty("ExpensesAndContributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpensesAndContributionsAmt")]
//     public string ExpensesAndContributionsAmt { get; set; }
//
//     [JsonProperty("ProgramRelatedInvstTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramRelatedInvstTotalAmt")]
//     public string ProgramRelatedInvstTotalAmt { get; set; }
//
//     [JsonProperty("CharitableAssetsAcquisPaidAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CharitableAssetsAcquisPaidAmt")]
//     public string CharitableAssetsAcquisPaidAmt { get; set; }
//
//     [JsonProperty("SetAsideSuitabilityTestAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SetAsideSuitabilityTestAmt")]
//     public string SetAsideSuitabilityTestAmt { get; set; }
//
//     [JsonProperty("SetAsideCashDistriTestAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SetAsideCashDistriTestAmt")]
//     public string SetAsideCashDistriTestAmt { get; set; }
//
//     [JsonProperty("QualifyingDistributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("QualifyingDistributionsAmt")]
//     public string QualifyingDistributionsAmt { get; set; }
//
//     [JsonProperty("AdjustedQualifyingDistriAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdjustedQualifyingDistriAmt")]
//     public string AdjustedQualifyingDistriAmt { get; set; }
//
//     [JsonProperty("PctSect4940eOrgNetInvstIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PctSect4940eOrgNetInvstIncmAmt")]
//     public string PctSect4940eOrgNetInvstIncmAmt { get; set; }
// }
//
// public class RcvblFromDisqualifiedPrsnGrp
// {
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
//
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
// }
//
// public class RcvblFromOfficersEOYAmt
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class RealEstateOtherGrp
// {
//     [JsonProperty("NonCashCheckboxInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashCheckboxInd")]
//     public string NonCashCheckboxInd { get; set; }
//
//     [JsonProperty("ContributionCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributionCnt")]
//     public string ContributionCnt { get; set; }
//
//     [JsonProperty("NoncashContributionsRptF990Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NoncashContributionsRptF990Amt")]
//     public string NoncashContributionsRptF990Amt { get; set; }
//
//     [JsonProperty("MethodOfDeterminingRevenuesTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfDeterminingRevenuesTxt")]
//     public string MethodOfDeterminingRevenuesTxt { get; set; }
// }
//
// public class ReasonableCauseExplanation
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("ExplanationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExplanationTxt")]
//     public string ExplanationTxt { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class ReceivablesFromOfficersEtcGrp
// {
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
//
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
// }
//
// public class RecipientBusinessName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
//
//     [JsonProperty("BusinessNameLine2Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine2Txt")]
//     public string BusinessNameLine2Txt { get; set; }
// }
//
// public class RecipientForeignAddress
// {
//     [JsonProperty("AddressLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine1Txt")]
//     public string AddressLine1Txt { get; set; }
//
//     [JsonProperty("CityNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CityNm")]
//     public string CityNm { get; set; }
//
//     [JsonProperty("ProvinceOrStateNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProvinceOrStateNm")]
//     public string ProvinceOrStateNm { get; set; }
//
//     [JsonProperty("CountryCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CountryCd")]
//     public string CountryCd { get; set; }
//
//     [JsonProperty("ForeignPostalCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignPostalCd")]
//     public string ForeignPostalCd { get; set; }
// }
//
// public class RecipientTable
// {
//     [JsonProperty("RecipientBusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RecipientBusinessName")]
//     public RecipientBusinessName RecipientBusinessName { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("PurposeOfGrantTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PurposeOfGrantTxt")]
//     public string PurposeOfGrantTxt { get; set; }
// }
//
// public class RecipientUSAddress
// {
//     [JsonProperty("AddressLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine1Txt")]
//     public string AddressLine1Txt { get; set; }
//
//     [JsonProperty("CityNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CityNm")]
//     public string CityNm { get; set; }
//
//     [JsonProperty("StateAbbreviationCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StateAbbreviationCd")]
//     public string StateAbbreviationCd { get; set; }
//
//     [JsonProperty("ZIPCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ZIPCd")]
//     public string ZIPCd { get; set; }
//
//     [JsonProperty("AddressLine2Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine2Txt")]
//     public string AddressLine2Txt { get; set; }
// }
//
// public class RecoveriesPYDistributionsGrp
// {
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class RecoveriesPYDistriMinAssetGrp
// {
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class ReductionExplanationStatement
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("ShortExplanationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ShortExplanationTxt")]
//     public string ShortExplanationTxt { get; set; }
// }
//
// public class RelatedOrganizationName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
// }
//
// public class RelationshipScheduleDetail
// {
//     [JsonProperty("OrganizationBusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrganizationBusinessName")]
//     public OrganizationBusinessName OrganizationBusinessName { get; set; }
//
//     [JsonProperty("OrganizationTypeDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrganizationTypeDesc")]
//     public string OrganizationTypeDesc { get; set; }
//
//     [JsonProperty("RelationshipDescriptionTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelationshipDescriptionTxt")]
//     public string RelationshipDescriptionTxt { get; set; }
// }
//
// public class RenewableDieselMixtureCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class RenewableElectricityProdCrGrp
// {
//     [JsonProperty("RenewableElectricityProdCrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RenewableElectricityProdCrAmt")]
//     public string RenewableElectricityProdCrAmt { get; set; }
// }
//
// public class RentalIncomeOrLossGrp
// {
//     [JsonProperty("PersonalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonalAmt")]
//     public string PersonalAmt { get; set; }
//
//     [JsonProperty("RealAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RealAmt")]
//     public string RealAmt { get; set; }
// }
//
// public class ReportInvestmentsOtherSecInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ReportLandBuildingEquipmentInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ReportOtherAssetsInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ReportOtherLiabilitiesInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ReportProgramRelatedInvstInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ResearchGrp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
// }
//
// public class RlnOfActyToAccomOfExmptPrpsGrp
// {
//     [JsonProperty("RlnOfActyToAccomOfExmptPrpsGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RlnOfActyToAccomOfExmptPrpsGrp")]
//     public List<RlnOfActyToAccomOfExmptPrpsGrp> RlnOfActyToAccomOfExmptPrpsGrp { get; } =
//         new List<RlnOfActyToAccomOfExmptPrpsGrp>();
//
//     [JsonProperty("LineNumberTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LineNumberTxt")]
//     public string LineNumberTxt { get; set; }
//
//     [JsonProperty("RelationshipStatementTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelationshipStatementTxt")]
//     public string RelationshipStatementTxt { get; set; }
// }
//
// public class RltdOrgOfficerTrstKeyEmplGrp
// {
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
//
//     [JsonProperty("TitleTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TitleTxt")]
//     public string TitleTxt { get; set; }
//
//     [JsonProperty("BaseCompensationFilingOrgAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BaseCompensationFilingOrgAmt")]
//     public string BaseCompensationFilingOrgAmt { get; set; }
//
//     [JsonProperty("CompensationBasedOnRltdOrgsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompensationBasedOnRltdOrgsAmt")]
//     public string CompensationBasedOnRltdOrgsAmt { get; set; }
//
//     [JsonProperty("BonusFilingOrganizationAmount", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BonusFilingOrganizationAmount")]
//     public string BonusFilingOrganizationAmount { get; set; }
//
//     [JsonProperty("BonusRelatedOrganizationsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BonusRelatedOrganizationsAmt")]
//     public string BonusRelatedOrganizationsAmt { get; set; }
//
//     [JsonProperty("OtherCompensationFilingOrgAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherCompensationFilingOrgAmt")]
//     public string OtherCompensationFilingOrgAmt { get; set; }
//
//     [JsonProperty("OtherCompensationRltdOrgsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherCompensationRltdOrgsAmt")]
//     public string OtherCompensationRltdOrgsAmt { get; set; }
//
//     [JsonProperty("DeferredCompensationFlngOrgAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DeferredCompensationFlngOrgAmt")]
//     public string DeferredCompensationFlngOrgAmt { get; set; }
//
//     [JsonProperty("DeferredCompRltdOrgsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DeferredCompRltdOrgsAmt")]
//     public string DeferredCompRltdOrgsAmt { get; set; }
//
//     [JsonProperty("NontaxableBenefitsFilingOrgAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontaxableBenefitsFilingOrgAmt")]
//     public string NontaxableBenefitsFilingOrgAmt { get; set; }
//
//     [JsonProperty("NontaxableBenefitsRltdOrgsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NontaxableBenefitsRltdOrgsAmt")]
//     public string NontaxableBenefitsRltdOrgsAmt { get; set; }
//
//     [JsonProperty("TotalCompensationFilingOrgAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCompensationFilingOrgAmt")]
//     public string TotalCompensationFilingOrgAmt { get; set; }
//
//     [JsonProperty("TotalCompensationRltdOrgsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCompensationRltdOrgsAmt")]
//     public string TotalCompensationRltdOrgsAmt { get; set; }
//
//     [JsonProperty("CompReportPrior990FilingOrgAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompReportPrior990FilingOrgAmt")]
//     public string CompReportPrior990FilingOrgAmt { get; set; }
//
//     [JsonProperty("CompReportPrior990RltdOrgsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompReportPrior990RltdOrgsAmt")]
//     public string CompReportPrior990RltdOrgsAmt { get; set; }
// }
//
// public class RnwblElecCoalCrFromF8835Grp
// {
//     [JsonProperty("RnwblElecCoalCrFromF8835Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RnwblElecCoalCrFromF8835Amt")]
//     public string RnwblElecCoalCrFromF8835Amt { get; set; }
// }
//
// public class Root
// {
//     [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Id")]
//     public string Id { get; set; }
//
//     [JsonProperty("FileName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FileName")]
//     public string FileName { get; set; }
//
//     [JsonProperty("@binaryAttachmentCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@binaryAttachmentCnt")]
//     public string BinaryAttachmentCnt { get; set; }
//
//     [JsonProperty("ReturnTs", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReturnTs")]
//     public string ReturnTs { get; set; }
//
//     [JsonProperty("TaxPeriodEndDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxPeriodEndDt")]
//     public string TaxPeriodEndDt { get; set; }
//
//     [JsonProperty("PreparerFirmGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PreparerFirmGrp")]
//     public PreparerFirmGrp PreparerFirmGrp { get; set; }
//
//     [JsonProperty("ReturnTypeCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReturnTypeCd")]
//     public string ReturnTypeCd { get; set; }
//
//     [JsonProperty("TaxPeriodBeginDt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxPeriodBeginDt")]
//     public string TaxPeriodBeginDt { get; set; }
//
//     [JsonProperty("Filer", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Filer")]
//     public Filer Filer { get; set; }
//
//     [JsonProperty("BusinessOfficerGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessOfficerGrp")]
//     public BusinessOfficerGrp BusinessOfficerGrp { get; set; }
//
//     [JsonProperty("SigningOfficerGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SigningOfficerGrp")]
//     public SigningOfficerGrp SigningOfficerGrp { get; set; }
//
//     [JsonProperty("PreparerPersonGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PreparerPersonGrp")]
//     public PreparerPersonGrp PreparerPersonGrp { get; set; }
//
//     [JsonProperty("AdditionalFilerInformation", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AdditionalFilerInformation")]
//     public AdditionalFilerInformation AdditionalFilerInformation { get; set; }
//
//     [JsonProperty("TaxYr", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxYr")]
//     public string TaxYr { get; set; }
//
//     [JsonProperty("BuildTS", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BuildTS")]
//     public string BuildTS { get; set; }
//
//     [JsonProperty("@documentCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentCnt")]
//     public string DocumentCnt { get; set; }
//
//     [JsonProperty("IRS990", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990")]
//     public IRS990 IRS990 { get; set; }
//
//     [JsonProperty("IRS990ScheduleD", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990ScheduleD")]
//     public IRS990ScheduleD IRS990ScheduleD { get; set; }
//
//     [JsonProperty("IRS990ScheduleO", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990ScheduleO")]
//     public IRS990ScheduleO IRS990ScheduleO { get; set; }
//
//     [JsonProperty("IRS990ScheduleR", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990ScheduleR")]
//     public IRS990ScheduleR IRS990ScheduleR { get; set; }
//
//     [JsonProperty("IRSResponsiblePrtyInfoCurrInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRSResponsiblePrtyInfoCurrInd")]
//     public string IRSResponsiblePrtyInfoCurrInd { get; set; }
//
//     [JsonProperty("IRS990EZ", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990EZ")]
//     public IRS990EZ IRS990EZ { get; set; }
//
//     [JsonProperty("IRS990ScheduleA", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990ScheduleA")]
//     public IRS990ScheduleA IRS990ScheduleA { get; set; }
//
//     [JsonProperty("IRS990ScheduleG", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990ScheduleG")]
//     public IRS990ScheduleG IRS990ScheduleG { get; set; }
//
//     [JsonProperty("IRS990ScheduleJ", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990ScheduleJ")]
//     public IRS990ScheduleJ IRS990ScheduleJ { get; set; }
//
//     [JsonProperty("IRS990PF", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990PF")]
//     public IRS990PF IRS990PF { get; set; }
//
//     [JsonProperty("CashDeemedCharitableExplnStmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashDeemedCharitableExplnStmt")]
//     public CashDeemedCharitableExplnStmt CashDeemedCharitableExplnStmt { get; set; }
//
//     [JsonProperty("CashDistributionExplnStmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CashDistributionExplnStmt")]
//     public CashDistributionExplnStmt CashDistributionExplnStmt { get; set; }
//
//     [JsonProperty("LoansFromOfficersSchedule", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoansFromOfficersSchedule")]
//     public LoansFromOfficersSchedule LoansFromOfficersSchedule { get; set; }
//
//     [JsonProperty("OtherExpensesSchedule", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherExpensesSchedule")]
//     public OtherExpensesSchedule OtherExpensesSchedule { get; set; }
//
//     [JsonProperty("OtherLiabilitiesSchedule", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherLiabilitiesSchedule")]
//     public OtherLiabilitiesSchedule OtherLiabilitiesSchedule { get; set; }
//
//     [JsonProperty("OtherProfessionalFeesSchedule", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherProfessionalFeesSchedule")]
//     public OtherProfessionalFeesSchedule OtherProfessionalFeesSchedule { get; set; }
//
//     [JsonProperty("IRS990ScheduleC", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990ScheduleC")]
//     public IRS990ScheduleC IRS990ScheduleC { get; set; }
//
//     [JsonProperty("OtherIncomeSchedule2", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherIncomeSchedule2")]
//     public OtherIncomeSchedule2 OtherIncomeSchedule2 { get; set; }
//
//     [JsonProperty("IRS990ScheduleB", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990ScheduleB")]
//     public IRS990ScheduleB IRS990ScheduleB { get; set; }
//
//     [JsonProperty("TaxesSchedule", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxesSchedule")]
//     public TaxesSchedule TaxesSchedule { get; set; }
//
//     [JsonProperty("IRS990T", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990T")]
//     public IRS990T IRS990T { get; set; }
//
//     [JsonProperty("IRS990TScheduleA", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990TScheduleA")]
//     public IRS990TScheduleA IRS990TScheduleA { get; set; }
//
//     [JsonProperty("IRS1041ScheduleD", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS1041ScheduleD")]
//     public IRS1041ScheduleD IRS1041ScheduleD { get; set; }
//
//     [JsonProperty("IRS1041ScheduleI", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS1041ScheduleI")]
//     public IRS1041ScheduleI IRS1041ScheduleI { get; set; }
//
//     [JsonProperty("IRS8949", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS8949")]
//     public IRS8949 IRS8949 { get; set; }
//
//     [JsonProperty("IRS990ScheduleF", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990ScheduleF")]
//     public IRS990ScheduleF IRS990ScheduleF { get; set; }
//
//     [JsonProperty("InvestmentsCorpStockSchedule", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentsCorpStockSchedule")]
//     public InvestmentsCorpStockSchedule InvestmentsCorpStockSchedule { get; set; }
//
//     [JsonProperty("SubstantialContributorsSch", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubstantialContributorsSch")]
//     public SubstantialContributorsSch SubstantialContributorsSch { get; set; }
//
//     [JsonProperty("IRS990ScheduleI", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990ScheduleI")]
//     public IRS990ScheduleI IRS990ScheduleI { get; set; }
//
//     [JsonProperty("IRS990ScheduleM", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990ScheduleM")]
//     public IRS990ScheduleM IRS990ScheduleM { get; set; }
//
//     [JsonProperty("OtherDecreasesSchedule", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherDecreasesSchedule")]
//     public OtherDecreasesSchedule OtherDecreasesSchedule { get; set; }
//
//     [JsonProperty("ReasonableCauseExplanation", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReasonableCauseExplanation")]
//     public ReasonableCauseExplanation ReasonableCauseExplanation { get; set; }
//
//     [JsonProperty("AccountingFeesSchedule", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AccountingFeesSchedule")]
//     public AccountingFeesSchedule AccountingFeesSchedule { get; set; }
//
//     [JsonProperty("InvestmentsOtherSchedule2", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentsOtherSchedule2")]
//     public InvestmentsOtherSchedule2 InvestmentsOtherSchedule2 { get; set; }
//
//     [JsonProperty("CompensationExplanation", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CompensationExplanation")]
//     public CompensationExplanation CompensationExplanation { get; set; }
//
//     [JsonProperty("LegalFeesSchedule", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LegalFeesSchedule")]
//     public LegalFeesSchedule LegalFeesSchedule { get; set; }
//
//     [JsonProperty("OtherIncreasesSchedule", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherIncreasesSchedule")]
//     public OtherIncreasesSchedule OtherIncreasesSchedule { get; set; }
//
//     [JsonProperty("InvestmentsCorpBondsSchedule", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentsCorpBondsSchedule")]
//     public InvestmentsCorpBondsSchedule InvestmentsCorpBondsSchedule { get; set; }
//
//     [JsonProperty("OtherAssetsSchedule", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherAssetsSchedule")]
//     public OtherAssetsSchedule OtherAssetsSchedule { get; set; }
//
//     [JsonProperty("TransferPrsnlBnftContractsDecl", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransferPrsnlBnftContractsDecl")]
//     public TransferPrsnlBnftContractsDecl TransferPrsnlBnftContractsDecl { get; set; }
//
//     [JsonProperty("IRS990ScheduleL", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990ScheduleL")]
//     public IRS990ScheduleL IRS990ScheduleL { get; set; }
//
//     [JsonProperty("GainLossSaleOtherAssetsSch", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GainLossSaleOtherAssetsSch")]
//     public GainLossSaleOtherAssetsSch GainLossSaleOtherAssetsSch { get; set; }
//
//     [JsonProperty("InvestmentsGovtObligationsSch", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentsGovtObligationsSch")]
//     public InvestmentsGovtObligationsSch InvestmentsGovtObligationsSch { get; set; }
//
//     [JsonProperty("ExplnOfNonFilingWithAGStmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExplnOfNonFilingWithAGStmt")]
//     public ExplnOfNonFilingWithAGStmt ExplnOfNonFilingWithAGStmt { get; set; }
//
//     [JsonProperty("IRS990ScheduleN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990ScheduleN")]
//     public IRS990ScheduleN IRS990ScheduleN { get; set; }
//
//     [JsonProperty("GeneralExplanationAttachment", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GeneralExplanationAttachment")]
//     public GeneralExplanationAttachment GeneralExplanationAttachment { get; set; }
//
//     [JsonProperty("OtherNotesLoansRcvblShortSch2", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherNotesLoansRcvblShortSch2")]
//     public OtherNotesLoansRcvblShortSch2 OtherNotesLoansRcvblShortSch2 { get; set; }
//
//     [JsonProperty("OtherNotesLoansRcvblLongSch", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherNotesLoansRcvblLongSch")]
//     public OtherNotesLoansRcvblLongSch OtherNotesLoansRcvblLongSch { get; set; }
//
//     [JsonProperty("IRS990ScheduleK", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990ScheduleK")]
//     public List<IRS990ScheduleK> IRS990ScheduleK { get; } = new List<IRS990ScheduleK>();
//
//     [JsonProperty("DepreciationSchedule", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DepreciationSchedule")]
//     public DepreciationSchedule DepreciationSchedule { get; set; }
//
//     [JsonProperty("ExpenditureResponsibilityStmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExpenditureResponsibilityStmt")]
//     public ExpenditureResponsibilityStmt ExpenditureResponsibilityStmt { get; set; }
//
//     [JsonProperty("AllOthProgRltdInvestmentsSch", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AllOthProgRltdInvestmentsSch")]
//     public AllOthProgRltdInvestmentsSch AllOthProgRltdInvestmentsSch { get; set; }
//
//     [JsonProperty("IRS990ScheduleE", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990ScheduleE")]
//     public IRS990ScheduleE IRS990ScheduleE { get; set; }
//
//     [JsonProperty("AffiliateListing", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AffiliateListing")]
//     public AffiliateListing AffiliateListing { get; set; }
//
//     [JsonProperty("IRS4562", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS4562")]
//     public IRS4562 IRS4562 { get; set; }
//
//     [JsonProperty("LandEtcSchedule2", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LandEtcSchedule2")]
//     public LandEtcSchedule2 LandEtcSchedule2 { get; set; }
//
//     [JsonProperty("IRS990ScheduleH", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS990ScheduleH")]
//     public IRS990ScheduleH IRS990ScheduleH { get; set; }
//
//     [JsonProperty("IRS1120ScheduleD", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS1120ScheduleD")]
//     public IRS1120ScheduleD IRS1120ScheduleD { get; set; }
//
//     [JsonProperty("LiquidationExplanationStmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LiquidationExplanationStmt")]
//     public LiquidationExplanationStmt LiquidationExplanationStmt { get; set; }
//
//     [JsonProperty("InvestmentsLandSchedule2", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvestmentsLandSchedule2")]
//     public InvestmentsLandSchedule2 InvestmentsLandSchedule2 { get; set; }
//
//     [JsonProperty("MortgagesAndNotesPayableSch", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MortgagesAndNotesPayableSch")]
//     public MortgagesAndNotesPayableSch MortgagesAndNotesPayableSch { get; set; }
//
//     [JsonProperty("AppliedToPriorYearElection", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AppliedToPriorYearElection")]
//     public AppliedToPriorYearElection AppliedToPriorYearElection { get; set; }
//
//     [JsonProperty("AmortizationSchedule", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AmortizationSchedule")]
//     public AmortizationSchedule AmortizationSchedule { get; set; }
//
//     [JsonProperty("DistributionFromCorpusElection", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributionFromCorpusElection")]
//     public DistributionFromCorpusElection DistributionFromCorpusElection { get; set; }
//
//     [JsonProperty("SalesOfInventoryList", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SalesOfInventoryList")]
//     public SalesOfInventoryList SalesOfInventoryList { get; set; }
//
//     [JsonProperty("AffiliatedGroupSchedule", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AffiliatedGroupSchedule")]
//     public AffiliatedGroupSchedule AffiliatedGroupSchedule { get; set; }
//
//     [JsonProperty("OtherReceivablesOfficersSch", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherReceivablesOfficersSch")]
//     public OtherReceivablesOfficersSch OtherReceivablesOfficersSch { get; set; }
//
//     [JsonProperty("DissolutionStmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DissolutionStmt")]
//     public DissolutionStmt DissolutionStmt { get; set; }
//
//     [JsonProperty("Form8822BAttachedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form8822BAttachedInd")]
//     public string Form8822BAttachedInd { get; set; }
//
//     [JsonProperty("AveragingAttachment", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AveragingAttachment")]
//     public AveragingAttachment AveragingAttachment { get; set; }
//
//     [JsonProperty("DisasterReliefTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisasterReliefTxt")]
//     public string DisasterReliefTxt { get; set; }
//
//     [JsonProperty("ContractorCompensationExpln", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContractorCompensationExpln")]
//     public ContractorCompensationExpln ContractorCompensationExpln { get; set; }
//
//     [JsonProperty("IRS3800", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS3800")]
//     public IRS3800 IRS3800 { get; set; }
//
//     [JsonProperty("TransfersToControlledEntities", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransfersToControlledEntities")]
//     public TransfersToControlledEntities TransfersToControlledEntities { get; set; }
//
//     [JsonProperty("IRS8801", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS8801")]
//     public IRS8801 IRS8801 { get; set; }
//
//     [JsonProperty("TransfersFrmControlledEntities", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransfersFrmControlledEntities")]
//     public TransfersFrmControlledEntities TransfersFrmControlledEntities { get; set; }
//
//     [JsonProperty("BorrowedFundsElection", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BorrowedFundsElection")]
//     public BorrowedFundsElection BorrowedFundsElection { get; set; }
//
//     [JsonProperty("IRS4136", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IRS4136")]
//     public IRS4136 IRS4136 { get; set; }
//
//     [JsonProperty("ExplanOfLegisPoliticalActvts", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExplanOfLegisPoliticalActvts")]
//     public ExplanOfLegisPoliticalActvts ExplanOfLegisPoliticalActvts { get; set; }
//
//     [JsonProperty("ReductionExplanationStatement", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReductionExplanationStatement")]
//     public ReductionExplanationStatement ReductionExplanationStatement { get; set; }
// }
//
// public class RoyaltiesGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class RoyaltiesRevenueGrp
// {
//     [JsonProperty("TotalRevenueColumnAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevenueColumnAmt")]
//     public string TotalRevenueColumnAmt { get; set; }
//
//     [JsonProperty("RelatedOrExemptFuncIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFuncIncomeAmt")]
//     public string RelatedOrExemptFuncIncomeAmt { get; set; }
//
//     [JsonProperty("UnrelatedBusinessRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessRevenueAmt")]
//     public string UnrelatedBusinessRevenueAmt { get; set; }
//
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
// }
//
// public class RtnEarnEndowmentIncmOthFndsGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class SalesOfInventoryList
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
//
//     [JsonProperty("InventorySaleGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InventorySaleGrp")]
//     public InventorySaleGrp InventorySaleGrp { get; set; }
// }
//
// public class SavingsAndTempCashInvstGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class Section199ADeductionAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class Section527PoliticalOrgGrp
// {
//     [JsonProperty("OrganizationBusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrganizationBusinessName")]
//     public OrganizationBusinessName OrganizationBusinessName { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("EIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EIN")]
//     public string EIN { get; set; }
// }
//
// public class SecuritiesPubliclyTradedGrp
// {
//     [JsonProperty("NonCashCheckboxInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NonCashCheckboxInd")]
//     public string NonCashCheckboxInd { get; set; }
//
//     [JsonProperty("ContributionCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributionCnt")]
//     public string ContributionCnt { get; set; }
//
//     [JsonProperty("NoncashContributionsRptF990Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NoncashContributionsRptF990Amt")]
//     public string NoncashContributionsRptF990Amt { get; set; }
//
//     [JsonProperty("MethodOfDeterminingRevenuesTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfDeterminingRevenuesTxt")]
//     public string MethodOfDeterminingRevenuesTxt { get; set; }
// }
//
// public class SetAsideCashDistriTestAmt
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ShortTermCapitalGainAndLossGrp
// {
//     [JsonProperty("TransactionsNotRptedOn1099BInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransactionsNotRptedOn1099BInd")]
//     public string TransactionsNotRptedOn1099BInd { get; set; }
//
//     [JsonProperty("CapitalGainAndLossAssetGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CapitalGainAndLossAssetGrp")]
//     public List<CapitalGainAndLossAssetGrp> CapitalGainAndLossAssetGrp { get; } =
//         new List<CapitalGainAndLossAssetGrp>();
//
//     [JsonProperty("TotalGainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalGainOrLossAmt")]
//     public string TotalGainOrLossAmt { get; set; }
//
//     [JsonProperty("TotalProceedsSalesPriceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalProceedsSalesPriceAmt")]
//     public string TotalProceedsSalesPriceAmt { get; set; }
//
//     [JsonProperty("TotalCostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCostOrOtherBasisAmt")]
//     public string TotalCostOrOtherBasisAmt { get; set; }
//
//     [JsonProperty("TotAdjustmentsToGainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotAdjustmentsToGainOrLossAmt")]
//     public string TotAdjustmentsToGainOrLossAmt { get; set; }
// }
//
// public class SigningOfficerGrp
// {
//     [JsonProperty("PersonFullName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonFullName")]
//     public PersonFullName PersonFullName { get; set; }
//
//     [JsonProperty("SSN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SSN")]
//     public string SSN { get; set; }
// }
//
// public class SlsKrsnNnxmptUseInAvnCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class SlsKrsnOthNontxTxd219CrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class SlsKrsnOthNontxTxd244CrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class SlsKrsnUsedInAvnTxd219CrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class SlsKrsnUsedInAvnTxd244CrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class SlsUndyedDieselUseBusCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class SlsUndyedDslUseStLclGovtCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class SlsUndyedKrsnBlockPumpCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class SlsUndyedKrsnUseBusCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class SmallEmployerHIPCreditAmtGrp
// {
//     [JsonProperty("SmallEmployerHIPCreditAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SmallEmployerHIPCreditAmt")]
//     public string SmallEmployerHIPCreditAmt { get; set; }
// }
//
// public class StatementsRegardingActy4720Grp
// {
//     [JsonProperty("SaleOrExchDisqualifiedPrsnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SaleOrExchDisqualifiedPrsnInd")]
//     public string SaleOrExchDisqualifiedPrsnInd { get; set; }
//
//     [JsonProperty("BrrwOrLendDisqualifiedPrsnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BrrwOrLendDisqualifiedPrsnInd")]
//     public string BrrwOrLendDisqualifiedPrsnInd { get; set; }
//
//     [JsonProperty("FurnGoodsDisqualifiedPrsnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FurnGoodsDisqualifiedPrsnInd")]
//     public string FurnGoodsDisqualifiedPrsnInd { get; set; }
//
//     [JsonProperty("PayCompDisqualifiedPrsnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PayCompDisqualifiedPrsnInd")]
//     public string PayCompDisqualifiedPrsnInd { get; set; }
//
//     [JsonProperty("TransferAstDisqualifiedPrsnInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransferAstDisqualifiedPrsnInd")]
//     public string TransferAstDisqualifiedPrsnInd { get; set; }
//
//     [JsonProperty("PaymentToGovernmentOfficialInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PaymentToGovernmentOfficialInd")]
//     public string PaymentToGovernmentOfficialInd { get; set; }
//
//     [JsonProperty("UncorrectedPriorActsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UncorrectedPriorActsInd")]
//     public string UncorrectedPriorActsInd { get; set; }
//
//     [JsonProperty("UndistributedIncomePYInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UndistributedIncomePYInd")]
//     public string UndistributedIncomePYInd { get; set; }
//
//     [JsonProperty("BusinessHoldingsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessHoldingsInd")]
//     public string BusinessHoldingsInd { get; set; }
//
//     [JsonProperty("JeopardyInvestmentsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("JeopardyInvestmentsInd")]
//     public string JeopardyInvestmentsInd { get; set; }
//
//     [JsonProperty("UncorrectedPYJeopardyInvstInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UncorrectedPYJeopardyInvstInd")]
//     public string UncorrectedPYJeopardyInvstInd { get; set; }
//
//     [JsonProperty("InfluenceLegislationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InfluenceLegislationInd")]
//     public string InfluenceLegislationInd { get; set; }
//
//     [JsonProperty("InfluenceElectionInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InfluenceElectionInd")]
//     public string InfluenceElectionInd { get; set; }
//
//     [JsonProperty("GrantsToIndividualsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsToIndividualsInd")]
//     public string GrantsToIndividualsInd { get; set; }
//
//     [JsonProperty("GrantsToOrganizationsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantsToOrganizationsInd")]
//     public string GrantsToOrganizationsInd { get; set; }
//
//     [JsonProperty("NoncharitablePurposeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NoncharitablePurposeInd")]
//     public string NoncharitablePurposeInd { get; set; }
//
//     [JsonProperty("RcvFndsToPayPrsnlBnftCntrctInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RcvFndsToPayPrsnlBnftCntrctInd")]
//     public string RcvFndsToPayPrsnlBnftCntrctInd { get; set; }
//
//     [JsonProperty("PayPremiumsPrsnlBnftCntrctInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PayPremiumsPrsnlBnftCntrctInd")]
//     public string PayPremiumsPrsnlBnftCntrctInd { get; set; }
//
//     [JsonProperty("ProhibitedTaxShelterTransInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProhibitedTaxShelterTransInd")]
//     public string ProhibitedTaxShelterTransInd { get; set; }
//
//     [JsonProperty("SubjToTaxRmnrtnExPrchtPymtInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubjToTaxRmnrtnExPrchtPymtInd")]
//     public string SubjToTaxRmnrtnExPrchtPymtInd { get; set; }
//
//     [JsonProperty("UndistributedIncomePY1Yr", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UndistributedIncomePY1Yr")]
//     public string UndistributedIncomePY1Yr { get; set; }
//
//     [JsonProperty("UndistributedIncomePY2Yr", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UndistributedIncomePY2Yr")]
//     public string UndistributedIncomePY2Yr { get; set; }
//
//     [JsonProperty("UndistrIncmSect4942a2NotAppInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UndistrIncmSect4942a2NotAppInd")]
//     public string UndistrIncmSect4942a2NotAppInd { get; set; }
//
//     [JsonProperty("UndistributedIncomePY3Yr", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UndistributedIncomePY3Yr")]
//     public string UndistributedIncomePY3Yr { get; set; }
//
//     [JsonProperty("ActsFailToQlfyAsExceptionsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActsFailToQlfyAsExceptionsInd")]
//     public string ActsFailToQlfyAsExceptionsInd { get; set; }
//
//     [JsonProperty("ExcessBusinessHoldingsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessBusinessHoldingsInd")]
//     public string ExcessBusinessHoldingsInd { get; set; }
//
//     [JsonProperty("TransactionsFailToQlfyAsExcInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransactionsFailToQlfyAsExcInd")]
//     public string TransactionsFailToQlfyAsExcInd { get; set; }
//
//     [JsonProperty("MaintainedExpenditureRspnsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MaintainedExpenditureRspnsInd")]
//     public MaintainedExpenditureRspnsInd MaintainedExpenditureRspnsInd { get; set; }
//
//     [JsonProperty("ProceedsOrNetIncomeInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProceedsOrNetIncomeInd")]
//     public string ProceedsOrNetIncomeInd { get; set; }
//
//     [JsonProperty("UndistributedIncomePY4Yr", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UndistributedIncomePY4Yr")]
//     public string UndistributedIncomePY4Yr { get; set; }
//
//     [JsonProperty("RelyingCurrentNtcDsstrAsst1Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelyingCurrentNtcDsstrAsst1Ind")]
//     public string RelyingCurrentNtcDsstrAsst1Ind { get; set; }
//
//     [JsonProperty("UndistrIncmSect4942a2AppYr2Yr", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UndistrIncmSect4942a2AppYr2Yr")]
//     public string UndistrIncmSect4942a2AppYr2Yr { get; set; }
//
//     [JsonProperty("UndistrIncmSect4942a2AppYr3Yr", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UndistrIncmSect4942a2AppYr3Yr")]
//     public string UndistrIncmSect4942a2AppYr3Yr { get; set; }
//
//     [JsonProperty("UndistrIncmSect4942a2AppYr4Yr", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UndistrIncmSect4942a2AppYr4Yr")]
//     public string UndistrIncmSect4942a2AppYr4Yr { get; set; }
// }
//
// public class StatementsRegardingActyGrp
// {
//     [JsonProperty("LegislativePoliticalActyInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LegislativePoliticalActyInd")]
//     public string LegislativePoliticalActyInd { get; set; }
//
//     [JsonProperty("MoreThan100SpentInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MoreThan100SpentInd")]
//     public string MoreThan100SpentInd { get; set; }
//
//     [JsonProperty("Form1120POLFiledInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form1120POLFiledInd")]
//     public string Form1120POLFiledInd { get; set; }
//
//     [JsonProperty("Section4955OrganizationTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Section4955OrganizationTaxAmt")]
//     public string Section4955OrganizationTaxAmt { get; set; }
//
//     [JsonProperty("Section4955ManagersTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Section4955ManagersTaxAmt")]
//     public string Section4955ManagersTaxAmt { get; set; }
//
//     [JsonProperty("TaxReimbursedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxReimbursedAmt")]
//     public string TaxReimbursedAmt { get; set; }
//
//     [JsonProperty("ActivitiesNotPreviouslyRptInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesNotPreviouslyRptInd")]
//     public string ActivitiesNotPreviouslyRptInd { get; set; }
//
//     [JsonProperty("ChangesToArticlesOrBylawsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ChangesToArticlesOrBylawsInd")]
//     public string ChangesToArticlesOrBylawsInd { get; set; }
//
//     [JsonProperty("UnrelatedBusIncmOverLimitInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusIncmOverLimitInd")]
//     public string UnrelatedBusIncmOverLimitInd { get; set; }
//
//     [JsonProperty("OrganizationDissolvedEtcInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrganizationDissolvedEtcInd")]
//     public string OrganizationDissolvedEtcInd { get; set; }
//
//     [JsonProperty("Section508eRqrSatisfiedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Section508eRqrSatisfiedInd")]
//     public string Section508eRqrSatisfiedInd { get; set; }
//
//     [JsonProperty("AtLeast5000InAssetsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AtLeast5000InAssetsInd")]
//     public string AtLeast5000InAssetsInd { get; set; }
//
//     [JsonProperty("OrgReportOrRegisterStateCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrgReportOrRegisterStateCd")]
//     public string OrgReportOrRegisterStateCd { get; set; }
//
//     [JsonProperty("Form990PFFiledWithAttyGenInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form990PFFiledWithAttyGenInd")]
//     public string Form990PFFiledWithAttyGenInd { get; set; }
//
//     [JsonProperty("PrivateOperatingFoundationInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrivateOperatingFoundationInd")]
//     public string PrivateOperatingFoundationInd { get; set; }
//
//     [JsonProperty("NewSubstantialContributorsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NewSubstantialContributorsInd")]
//     public NewSubstantialContributorsInd NewSubstantialContributorsInd { get; set; }
//
//     [JsonProperty("OwnControlledEntityInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OwnControlledEntityInd")]
//     public string OwnControlledEntityInd { get; set; }
//
//     [JsonProperty("DonorAdvisedFundInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DonorAdvisedFundInd")]
//     public string DonorAdvisedFundInd { get; set; }
//
//     [JsonProperty("ComplyWithPublicInspRqrInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ComplyWithPublicInspRqrInd")]
//     public string ComplyWithPublicInspRqrInd { get; set; }
//
//     [JsonProperty("WebsiteAddressTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("WebsiteAddressTxt")]
//     public string WebsiteAddressTxt { get; set; }
//
//     [JsonProperty("IndividualWithBooksNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IndividualWithBooksNm")]
//     public string IndividualWithBooksNm { get; set; }
//
//     [JsonProperty("PhoneNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PhoneNum")]
//     public string PhoneNum { get; set; }
//
//     [JsonProperty("LocationOfBooksUSAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LocationOfBooksUSAddress")]
//     public LocationOfBooksUSAddress LocationOfBooksUSAddress { get; set; }
//
//     [JsonProperty("ForeignAccountsQuestionInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignAccountsQuestionInd")]
//     public string ForeignAccountsQuestionInd { get; set; }
//
//     [JsonProperty("PersonsWithBooksName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsWithBooksName")]
//     public PersonsWithBooksName PersonsWithBooksName { get; set; }
//
//     [JsonProperty("Form990TFiledInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Form990TFiledInd")]
//     public string Form990TFiledInd { get; set; }
//
//     [JsonProperty("TaxExemptInterestAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxExemptInterestAmt")]
//     public string TaxExemptInterestAmt { get; set; }
//
//     [JsonProperty("NECTFilingInLieuOFForm1041Ind", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NECTFilingInLieuOFForm1041Ind")]
//     public string NECTFilingInLieuOFForm1041Ind { get; set; }
//
//     [JsonProperty("LocationOfBooksForeignAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LocationOfBooksForeignAddress")]
//     public LocationOfBooksForeignAddress LocationOfBooksForeignAddress { get; set; }
//
//     [JsonProperty("ForeignCountryCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignCountryCd")]
//     public string ForeignCountryCd { get; set; }
// }
//
// public class SubjectToProxyTaxInd
// {
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class SubsidizedHealthServicesGrp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
// }
//
// public class SubstAndDsqlfyPrsnsTotGrp
// {
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class SubstantialContributorDetail
// {
//     [JsonProperty("PersonNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonNm")]
//     public string PersonNm { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
// }
//
// public class SubstantialContributorsAmtGrp
// {
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
// }
//
// public class SubstantialContributorsSch
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("SubstantialContributorDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SubstantialContributorDetail")]
//     public SubstantialContributorDetail SubstantialContributorDetail { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class SubtotalsIncmProducingActyGrp
// {
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
//
//     [JsonProperty("RelatedOrExemptFunctionIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFunctionIncmAmt")]
//     public string RelatedOrExemptFunctionIncmAmt { get; set; }
//
//     [JsonProperty("UnrelatedBusinessTaxblIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessTaxblIncmAmt")]
//     public string UnrelatedBusinessTaxblIncmAmt { get; set; }
// }
//
// public class SummaryOfDirectChrtblActyGrp
// {
//     [JsonProperty("Description1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Description1Txt")]
//     public string Description1Txt { get; set; }
//
//     [JsonProperty("Expenses1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Expenses1Amt")]
//     public string Expenses1Amt { get; set; }
//
//     [JsonProperty("Description2Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Description2Txt")]
//     public string Description2Txt { get; set; }
//
//     [JsonProperty("Expenses2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Expenses2Amt")]
//     public string Expenses2Amt { get; set; }
// }
//
// public class SumOfProgramRelatedInvstGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class SumOfTotalLiabilitiesGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class SupplementalInformationDetail
// {
//     [JsonProperty("FormAndLineReferenceDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FormAndLineReferenceDesc")]
//     public string FormAndLineReferenceDesc { get; set; }
//
//     [JsonProperty("ExplanationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExplanationTxt")]
//     public string ExplanationTxt { get; set; }
// }
//
// public class SupplementalInformationGrp
// {
//     [JsonProperty("FormAndLineReferenceDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FormAndLineReferenceDesc")]
//     public string FormAndLineReferenceDesc { get; set; }
//
//     [JsonProperty("ExplanationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExplanationTxt")]
//     public string ExplanationTxt { get; set; }
// }
//
// public class SupplementaryInformationGrp
// {
//     [JsonProperty("OnlyContriToPreselectedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OnlyContriToPreselectedInd")]
//     public string OnlyContriToPreselectedInd { get; set; }
//
//     [JsonProperty("GrantOrContributionPdDurYrGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantOrContributionPdDurYrGrp")]
//     public List<GrantOrContributionPdDurYrGrp> GrantOrContributionPdDurYrGrp { get; } =
//         new List<GrantOrContributionPdDurYrGrp>();
//
//     [JsonProperty("TotalGrantOrContriPdDurYrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalGrantOrContriPdDurYrAmt")]
//     public string TotalGrantOrContriPdDurYrAmt { get; set; }
//
//     [JsonProperty("ContributingManagerNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ContributingManagerNm")]
//     public List<string> ContributingManagerNm { get; } = new List<string>();
//
//     [JsonProperty("ShareholderManagerNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ShareholderManagerNm")]
//     public string ShareholderManagerNm { get; set; }
//
//     [JsonProperty("ApplicationSubmissionInfoGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ApplicationSubmissionInfoGrp")]
//     public ApplicationSubmissionInfoGrp ApplicationSubmissionInfoGrp { get; set; }
//
//     [JsonProperty("TotalGrantOrContriApprvFutAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalGrantOrContriApprvFutAmt")]
//     public string TotalGrantOrContriApprvFutAmt { get; set; }
//
//     [JsonProperty("GrantOrContriApprvForFutGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GrantOrContriApprvForFutGrp")]
//     public List<GrantOrContriApprvForFutGrp> GrantOrContriApprvForFutGrp { get; } =
//         new List<GrantOrContriApprvForFutGrp>();
// }
//
// public class SupportedOrganizationName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
//
//     [JsonProperty("BusinessNameLine2Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine2Txt")]
//     public string BusinessNameLine2Txt { get; set; }
// }
//
// public class SupportedOrgInformationGrp
// {
//     [JsonProperty("SupportedOrganizationName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportedOrganizationName")]
//     public SupportedOrganizationName SupportedOrganizationName { get; set; }
//
//     [JsonProperty("EIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EIN")]
//     public string EIN { get; set; }
//
//     [JsonProperty("OrganizationTypeCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OrganizationTypeCd")]
//     public string OrganizationTypeCd { get; set; }
//
//     [JsonProperty("GoverningDocumentListedInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GoverningDocumentListedInd")]
//     public string GoverningDocumentListedInd { get; set; }
//
//     [JsonProperty("SupportAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SupportAmt")]
//     public string SupportAmt { get; set; }
//
//     [JsonProperty("OtherSupportAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherSupportAmt")]
//     public string OtherSupportAmt { get; set; }
// }
//
// public class TaxesDetail
// {
//     [JsonProperty("CategoryTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CategoryTxt")]
//     public string CategoryTxt { get; set; }
//
//     [JsonProperty("Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Amt")]
//     public string Amt { get; set; }
//
//     [JsonProperty("NetInvestmentIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetInvestmentIncomeAmt")]
//     public string NetInvestmentIncomeAmt { get; set; }
//
//     [JsonProperty("DisbursementsCharitablePrpsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisbursementsCharitablePrpsAmt")]
//     public string DisbursementsCharitablePrpsAmt { get; set; }
// }
//
// public class TaxesRevAndExpnssAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class TaxesSchedule
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("TaxesDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TaxesDetail")]
//     public List<TaxesDetail> TaxesDetail { get; } = new List<TaxesDetail>();
//
//     [JsonProperty("@softwareId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareId")]
//     public string SoftwareId { get; set; }
//
//     [JsonProperty("@softwareVersionNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@softwareVersionNum")]
//     public string SoftwareVersionNum { get; set; }
//
//     [JsonProperty("@documentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentName")]
//     public string DocumentName { get; set; }
// }
//
// public class TaxExemptBondLiabilitiesGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class TaxRevLeviedOrgnztnlBnft170Grp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
// }
//
// public class TaxRevLeviedOrgnztnlBnft509Grp
// {
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
// }
//
// public class TemporarilyRstrNetAssetsGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class TempOrPermanentEndowmentsInd
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class ThirdPartyBusinessName
// {
//     [JsonProperty("BusinessNameLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessNameLine1Txt")]
//     public string BusinessNameLine1Txt { get; set; }
// }
//
// public class ThirdPartyUSAddress
// {
//     [JsonProperty("AddressLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine1Txt")]
//     public string AddressLine1Txt { get; set; }
//
//     [JsonProperty("CityNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CityNm")]
//     public string CityNm { get; set; }
//
//     [JsonProperty("StateAbbreviationCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StateAbbreviationCd")]
//     public string StateAbbreviationCd { get; set; }
//
//     [JsonProperty("ZIPCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ZIPCd")]
//     public string ZIPCd { get; set; }
//
//     [JsonProperty("AddressLine2Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine2Txt")]
//     public string AddressLine2Txt { get; set; }
// }
//
// public class Total509Grp
// {
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class TotalAdjustedNetIncomeGrp
// {
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class TotalAssetsGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class TotalCalendarYear170Grp
// {
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class TotalCapitalGainOrLossGrp
// {
//     [JsonProperty("NetSTCapitalGainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetSTCapitalGainOrLossAmt")]
//     public string NetSTCapitalGainOrLossAmt { get; set; }
//
//     [JsonProperty("NetLongTermGainOrLossGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetLongTermGainOrLossGrp")]
//     public NetLongTermGainOrLossGrp NetLongTermGainOrLossGrp { get; set; }
//
//     [JsonProperty("TotalNetGainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalNetGainOrLossAmt")]
//     public string TotalNetGainOrLossAmt { get; set; }
// }
//
// public class TotalCommunityBenefitsGrp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
// }
//
// public class TotalCommuntityBuildingActyGrp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
// }
//
// public class TotalDepreciationAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class TotalDirectLobbyingGrp
// {
//     [JsonProperty("FilingOrganizationsTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FilingOrganizationsTotalAmt")]
//     public string FilingOrganizationsTotalAmt { get; set; }
//
//     [JsonProperty("AffiliatedGroupTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AffiliatedGroupTotalAmt")]
//     public string AffiliatedGroupTotalAmt { get; set; }
// }
//
// public class TotalExemptPurposeExpendGrp
// {
//     [JsonProperty("FilingOrganizationsTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FilingOrganizationsTotalAmt")]
//     public string FilingOrganizationsTotalAmt { get; set; }
//
//     [JsonProperty("AffiliatedGroupTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AffiliatedGroupTotalAmt")]
//     public string AffiliatedGroupTotalAmt { get; set; }
// }
//
// public class TotalFinancialAssistanceTyp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
// }
//
// public class TotalFMVOfNonExemptUseAssetGrp
// {
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class TotalFunctionalExpensesGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class TotalGrassrootsLobbyingGrp
// {
//     [JsonProperty("FilingOrganizationsTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FilingOrganizationsTotalAmt")]
//     public string FilingOrganizationsTotalAmt { get; set; }
//
//     [JsonProperty("AffiliatedGroupTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AffiliatedGroupTotalAmt")]
//     public string AffiliatedGroupTotalAmt { get; set; }
// }
//
// public class TotalJointCostsGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
// }
//
// public class TotalLiabilitiesGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class TotalLobbyingExpendGrp
// {
//     [JsonProperty("FilingOrganizationsTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FilingOrganizationsTotalAmt")]
//     public string FilingOrganizationsTotalAmt { get; set; }
//
//     [JsonProperty("AffiliatedGroupTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AffiliatedGroupTotalAmt")]
//     public string AffiliatedGroupTotalAmt { get; set; }
// }
//
// public class TotalLTCGL1099BNotReceivedGrp
// {
//     [JsonProperty("TotalGainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalGainOrLossAmt")]
//     public string TotalGainOrLossAmt { get; set; }
//
//     [JsonProperty("TotalProceedsSalesPriceAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalProceedsSalesPriceAmt")]
//     public string TotalProceedsSalesPriceAmt { get; set; }
//
//     [JsonProperty("TotalCostOrOtherBasisAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCostOrOtherBasisAmt")]
//     public string TotalCostOrOtherBasisAmt { get; set; }
// }
//
// public class TotalMinimumAssetGrp
// {
//     [JsonProperty("PriorYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearAmt")]
//     public string PriorYearAmt { get; set; }
//
//     [JsonProperty("CurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentYearAmt")]
//     public string CurrentYearAmt { get; set; }
// }
//
// public class TotalNetAssetsFundBalanceGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class TotalOtherBenefitsGrp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
// }
//
// public class TotalOthProgramServiceRevGrp
// {
//     [JsonProperty("TotalRevenueColumnAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevenueColumnAmt")]
//     public string TotalRevenueColumnAmt { get; set; }
//
//     [JsonProperty("RelatedOrExemptFuncIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFuncIncomeAmt")]
//     public string RelatedOrExemptFuncIncomeAmt { get; set; }
//
//     [JsonProperty("UnrelatedBusinessRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessRevenueAmt")]
//     public string UnrelatedBusinessRevenueAmt { get; set; }
//
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
// }
//
// public class TotalPrtshpSCorpIncomeAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class TotalRevenueGrp
// {
//     [JsonProperty("TotalRevenueColumnAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalRevenueColumnAmt")]
//     public string TotalRevenueColumnAmt { get; set; }
//
//     [JsonProperty("RelatedOrExemptFuncIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelatedOrExemptFuncIncomeAmt")]
//     public string RelatedOrExemptFuncIncomeAmt { get; set; }
//
//     [JsonProperty("UnrelatedBusinessRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UnrelatedBusinessRevenueAmt")]
//     public string UnrelatedBusinessRevenueAmt { get; set; }
//
//     [JsonProperty("ExclusionAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExclusionAmt")]
//     public string ExclusionAmt { get; set; }
// }
//
// public class TotalSTCGL1099BNotReceivedGrp
// {
//     [JsonProperty("TotalGainOrLossAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalGainOrLossAmt")]
//     public string TotalGainOrLossAmt { get; set; }
// }
//
// public class TotalSupportCalendarYearGrp
// {
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
// }
//
// public class TotLbbyExpendMnsLbbyngNonTxGrp
// {
//     [JsonProperty("FilingOrganizationsTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FilingOrganizationsTotalAmt")]
//     public string FilingOrganizationsTotalAmt { get; set; }
//
//     [JsonProperty("AffiliatedGroupTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AffiliatedGroupTotalAmt")]
//     public string AffiliatedGroupTotalAmt { get; set; }
// }
//
// public class TotLbbyngGrassrootMnsNonTxGrp
// {
//     [JsonProperty("FilingOrganizationsTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FilingOrganizationsTotalAmt")]
//     public string FilingOrganizationsTotalAmt { get; set; }
//
//     [JsonProperty("AffiliatedGroupTotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AffiliatedGroupTotalAmt")]
//     public string AffiliatedGroupTotalAmt { get; set; }
// }
//
// public class TotLiabNetAssetsFundBalanceGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class TrainUseOfUndyedDieselCrAmt
// {
//     [JsonProperty("@creditReferenceNum", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@creditReferenceNum")]
//     public string CreditReferenceNum { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class TransactionsRelatedOrgGrp
// {
//     [JsonProperty("OtherOrganizationName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OtherOrganizationName")]
//     public OtherOrganizationName OtherOrganizationName { get; set; }
//
//     [JsonProperty("TransactionTypeTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransactionTypeTxt")]
//     public string TransactionTypeTxt { get; set; }
//
//     [JsonProperty("InvolvedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvolvedAmt")]
//     public string InvolvedAmt { get; set; }
//
//     [JsonProperty("MethodOfAmountDeterminationTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("MethodOfAmountDeterminationTxt")]
//     public string MethodOfAmountDeterminationTxt { get; set; }
// }
//
// public class TransferPrsnlBnftContractsDecl
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("DeclarationDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DeclarationDesc")]
//     public string DeclarationDesc { get; set; }
// }
//
// public class TransferScheduleDetail
// {
//     [JsonProperty("LineNumberTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LineNumberTxt")]
//     public string LineNumberTxt { get; set; }
//
//     [JsonProperty("InvolvedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("InvolvedAmt")]
//     public string InvolvedAmt { get; set; }
//
//     [JsonProperty("NoncharitableExemptOrgName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NoncharitableExemptOrgName")]
//     public NoncharitableExemptOrgName NoncharitableExemptOrgName { get; set; }
//
//     [JsonProperty("TransfersTransAndShrArrngmDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransfersTransAndShrArrngmDesc")]
//     public string TransfersTransAndShrArrngmDesc { get; set; }
// }
//
// public class TransfersFrmControlledEntities
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("TransfersFromControlledEntGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransfersFromControlledEntGrp")]
//     public List<TransfersFromControlledEntGrp> TransfersFromControlledEntGrp { get; } =
//         new List<TransfersFromControlledEntGrp>();
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class TransfersFromControlledEntGrp
// {
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("EIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EIN")]
//     public string EIN { get; set; }
//
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Amt")]
//     public string Amt { get; set; }
//
//     [JsonProperty("ForeignAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignAddress")]
//     public ForeignAddress ForeignAddress { get; set; }
// }
//
// public class TransfersToControlledEntGrp
// {
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
//
//     [JsonProperty("ForeignAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ForeignAddress")]
//     public ForeignAddress ForeignAddress { get; set; }
//
//     [JsonProperty("EIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EIN")]
//     public string EIN { get; set; }
//
//     [JsonProperty("Desc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Desc")]
//     public string Desc { get; set; }
//
//     [JsonProperty("Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Amt")]
//     public string Amt { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
// }
//
// public class TransfersToControlledEntities
// {
//     [JsonProperty("@documentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@documentId")]
//     public string DocumentId { get; set; }
//
//     [JsonProperty("TransfersToControlledEntGrp", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransfersToControlledEntGrp")]
//     public TransfersToControlledEntGrp TransfersToControlledEntGrp { get; set; }
//
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
// }
//
// public class TravelGrp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("ManagementAndGeneralAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ManagementAndGeneralAmt")]
//     public string ManagementAndGeneralAmt { get; set; }
//
//     [JsonProperty("ProgramServicesAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ProgramServicesAmt")]
//     public string ProgramServicesAmt { get; set; }
//
//     [JsonProperty("FundraisingAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FundraisingAmt")]
//     public string FundraisingAmt { get; set; }
// }
//
// public class TrnsfrTransRlnNonchrtblEOGrp
// {
//     [JsonProperty("TrnsfrOfCashToNonchrtblEOInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TrnsfrOfCashToNonchrtblEOInd")]
//     public string TrnsfrOfCashToNonchrtblEOInd { get; set; }
//
//     [JsonProperty("TrnsfrOtherAssetNonchrtblEOInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TrnsfrOtherAssetNonchrtblEOInd")]
//     public string TrnsfrOtherAssetNonchrtblEOInd { get; set; }
//
//     [JsonProperty("SalesOrExchangesOfAssetsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SalesOrExchangesOfAssetsInd")]
//     public string SalesOrExchangesOfAssetsInd { get; set; }
//
//     [JsonProperty("PurchaseOfAssetsNonchrtblEOInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PurchaseOfAssetsNonchrtblEOInd")]
//     public string PurchaseOfAssetsNonchrtblEOInd { get; set; }
//
//     [JsonProperty("RentalOfFacilitiesOthAssetsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RentalOfFacilitiesOthAssetsInd")]
//     public string RentalOfFacilitiesOthAssetsInd { get; set; }
//
//     [JsonProperty("ReimbursementArrangementsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ReimbursementArrangementsInd")]
//     public string ReimbursementArrangementsInd { get; set; }
//
//     [JsonProperty("LoansOrLoanGuaranteesInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LoansOrLoanGuaranteesInd")]
//     public string LoansOrLoanGuaranteesInd { get; set; }
//
//     [JsonProperty("PerformanceOfServicesEtcInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PerformanceOfServicesEtcInd")]
//     public string PerformanceOfServicesEtcInd { get; set; }
//
//     [JsonProperty("SharingOfFacilitiesEtcInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("SharingOfFacilitiesEtcInd")]
//     public string SharingOfFacilitiesEtcInd { get; set; }
//
//     [JsonProperty("RelationshipsNonchrtblEOInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelationshipsNonchrtblEOInd")]
//     public string RelationshipsNonchrtblEOInd { get; set; }
//
//     [JsonProperty("RelationshipScheduleDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RelationshipScheduleDetail")]
//     public RelationshipScheduleDetail RelationshipScheduleDetail { get; set; }
//
//     [JsonProperty("TransferScheduleDetail", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TransferScheduleDetail")]
//     public TransferScheduleDetail TransferScheduleDetail { get; set; }
// }
//
// public class TrustedCustomerGrp
// {
//     [JsonProperty("TrustedCustomerCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TrustedCustomerCd")]
//     public string TrustedCustomerCd { get; set; }
//
//     [JsonProperty("AuthenticationAssuranceLevelCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AuthenticationAssuranceLevelCd")]
//     public string AuthenticationAssuranceLevelCd { get; set; }
//
//     [JsonProperty("IdentityAssuranceLevelCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("IdentityAssuranceLevelCd")]
//     public string IdentityAssuranceLevelCd { get; set; }
//
//     [JsonProperty("OOBSecurityVerificationCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OOBSecurityVerificationCd")]
//     public string OOBSecurityVerificationCd { get; set; }
//
//     [JsonProperty("FederatedAssuranceLevelCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("FederatedAssuranceLevelCd")]
//     public string FederatedAssuranceLevelCd { get; set; }
// }
//
// public class UndistributedIncomeGrp
// {
//     [JsonProperty("DistributableAsAdjustedAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DistributableAsAdjustedAmt")]
//     public string DistributableAsAdjustedAmt { get; set; }
//
//     [JsonProperty("UndistributedIncomeCYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UndistributedIncomeCYAmt")]
//     public string UndistributedIncomeCYAmt { get; set; }
//
//     [JsonProperty("ExcessDistributionCyovYr1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessDistributionCyovYr1Amt")]
//     public string ExcessDistributionCyovYr1Amt { get; set; }
//
//     [JsonProperty("TotalExcessDistributionCyovAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExcessDistributionCyovAmt")]
//     public string TotalExcessDistributionCyovAmt { get; set; }
//
//     [JsonProperty("QualifyingDistributionsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("QualifyingDistributionsAmt")]
//     public string QualifyingDistributionsAmt { get; set; }
//
//     [JsonProperty("AppliedToCurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AppliedToCurrentYearAmt")]
//     public string AppliedToCurrentYearAmt { get; set; }
//
//     [JsonProperty("RemainingDistriFromCorpusAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("RemainingDistriFromCorpusAmt")]
//     public string RemainingDistriFromCorpusAmt { get; set; }
//
//     [JsonProperty("TotalCorpusAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCorpusAmt")]
//     public string TotalCorpusAmt { get; set; }
//
//     [JsonProperty("ExcessDistriCyovToNextYrAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessDistriCyovToNextYrAmt")]
//     public string ExcessDistriCyovToNextYrAmt { get; set; }
//
//     [JsonProperty("ExcessFromYear1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessFromYear1Amt")]
//     public string ExcessFromYear1Amt { get; set; }
//
//     [JsonProperty("ExcessFromCurrentYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessFromCurrentYearAmt")]
//     public string ExcessFromCurrentYearAmt { get; set; }
//
//     [JsonProperty("UndistributedIncomePYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("UndistributedIncomePYAmt")]
//     public string UndistributedIncomePYAmt { get; set; }
//
//     [JsonProperty("TotalForPriorYearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalForPriorYearsAmt")]
//     public string TotalForPriorYearsAmt { get; set; }
//
//     [JsonProperty("ExcessDistributionCyovYr3Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessDistributionCyovYr3Amt")]
//     public string ExcessDistributionCyovYr3Amt { get; set; }
//
//     [JsonProperty("AppliedToYear1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AppliedToYear1Amt")]
//     public string AppliedToYear1Amt { get; set; }
//
//     [JsonProperty("AppliedToPriorYearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AppliedToPriorYearsAmt")]
//     public string AppliedToPriorYearsAmt { get; set; }
//
//     [JsonProperty("TreatedAsDistriFromCorpusAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TreatedAsDistriFromCorpusAmt")]
//     public string TreatedAsDistriFromCorpusAmt { get; set; }
//
//     [JsonProperty("ExcessDistriCyovAppCYCorpusAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessDistriCyovAppCYCorpusAmt")]
//     public string ExcessDistriCyovAppCYCorpusAmt { get; set; }
//
//     [JsonProperty("ExcessDistributionCyovAppCYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessDistributionCyovAppCYAmt")]
//     public string ExcessDistributionCyovAppCYAmt { get; set; }
//
//     [JsonProperty("PriorYearUndistributedIncmAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearUndistributedIncmAmt")]
//     public string PriorYearUndistributedIncmAmt { get; set; }
//
//     [JsonProperty("PriorYearDeficiencyOrTaxAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYearDeficiencyOrTaxAmt")]
//     public string PriorYearDeficiencyOrTaxAmt { get; set; }
//
//     [JsonProperty("Taxable1Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Taxable1Amt")]
//     public string Taxable1Amt { get; set; }
//
//     [JsonProperty("Taxable2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("Taxable2Amt")]
//     public string Taxable2Amt { get; set; }
//
//     [JsonProperty("CorpusDistri170b1EOr4942g3Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CorpusDistri170b1EOr4942g3Amt")]
//     public string CorpusDistri170b1EOr4942g3Amt { get; set; }
//
//     [JsonProperty("ExcessDistriCyovFromYr5Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessDistriCyovFromYr5Amt")]
//     public string ExcessDistriCyovFromYr5Amt { get; set; }
//
//     [JsonProperty("ExcessFromYear3Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessFromYear3Amt")]
//     public string ExcessFromYear3Amt { get; set; }
//
//     [JsonProperty("ExcessDistributionCyovYr4Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessDistributionCyovYr4Amt")]
//     public string ExcessDistributionCyovYr4Amt { get; set; }
//
//     [JsonProperty("ExcessDistributionCyovYr2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessDistributionCyovYr2Amt")]
//     public string ExcessDistributionCyovYr2Amt { get; set; }
//
//     [JsonProperty("ExcessFromYear4Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessFromYear4Amt")]
//     public string ExcessFromYear4Amt { get; set; }
//
//     [JsonProperty("ExcessFromYear2Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessFromYear2Amt")]
//     public string ExcessFromYear2Amt { get; set; }
//
//     [JsonProperty("ExcessDistributionCyovYr5Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ExcessDistributionCyovYr5Amt")]
//     public string ExcessDistributionCyovYr5Amt { get; set; }
//
//     [JsonProperty("PriorYear1Yr", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYear1Yr")]
//     public string PriorYear1Yr { get; set; }
//
//     [JsonProperty("PriorYear2Yr", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYear2Yr")]
//     public string PriorYear2Yr { get; set; }
//
//     [JsonProperty("PriorYear3Yr", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PriorYear3Yr")]
//     public string PriorYear3Yr { get; set; }
// }
//
// public class UnreimbursedCostsGrp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
// }
//
// public class UnreimbursedMedicaidGrp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
// }
//
// public class UnrelatedBusinessNetIncm170Grp
// {
//     [JsonProperty("TotalAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalAmt")]
//     public string TotalAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus4YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus4YearsAmt")]
//     public string CurrentTaxYearMinus4YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus3YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus3YearsAmt")]
//     public string CurrentTaxYearMinus3YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus2YearsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus2YearsAmt")]
//     public string CurrentTaxYearMinus2YearsAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearMinus1YearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearMinus1YearAmt")]
//     public string CurrentTaxYearMinus1YearAmt { get; set; }
//
//     [JsonProperty("CurrentTaxYearAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CurrentTaxYearAmt")]
//     public string CurrentTaxYearAmt { get; set; }
// }
//
// public class UnrelatedDebtFinancedPropGrp
// {
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("AverageAcquisitionAdjBasisPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AverageAcquisitionAdjBasisPct")]
//     public string AverageAcquisitionAdjBasisPct { get; set; }
// }
//
// public class UnrelatedOrgTxblPartnershipGrp
// {
//     [JsonProperty("BusinessName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BusinessName")]
//     public BusinessName BusinessName { get; set; }
//
//     [JsonProperty("USAddress", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("USAddress")]
//     public USAddress USAddress { get; set; }
//
//     [JsonProperty("EIN", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EIN")]
//     public string EIN { get; set; }
//
//     [JsonProperty("PrimaryActivitiesTxt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PrimaryActivitiesTxt")]
//     public string PrimaryActivitiesTxt { get; set; }
//
//     [JsonProperty("LegalDomicileStateCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("LegalDomicileStateCd")]
//     public string LegalDomicileStateCd { get; set; }
//
//     [JsonProperty("PredominateIncomeDesc", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PredominateIncomeDesc")]
//     public string PredominateIncomeDesc { get; set; }
//
//     [JsonProperty("AllPartnersC3SInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AllPartnersC3SInd")]
//     public string AllPartnersC3SInd { get; set; }
//
//     [JsonProperty("ShareOfTotalIncomeAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ShareOfTotalIncomeAmt")]
//     public string ShareOfTotalIncomeAmt { get; set; }
//
//     [JsonProperty("ShareOfEOYAssetsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ShareOfEOYAssetsAmt")]
//     public string ShareOfEOYAssetsAmt { get; set; }
//
//     [JsonProperty("DisproportionateAllocationsInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DisproportionateAllocationsInd")]
//     public string DisproportionateAllocationsInd { get; set; }
//
//     [JsonProperty("GeneralOrManagingPartnerInd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("GeneralOrManagingPartnerInd")]
//     public string GeneralOrManagingPartnerInd { get; set; }
//
//     [JsonProperty("OwnershipPct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("OwnershipPct")]
//     public string OwnershipPct { get; set; }
// }
//
// public class UnrestrictedNetAssetsGrp
// {
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
//
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
// }
//
// public class UnsecuredNotesLoansPayableGrp
// {
//     [JsonProperty("EOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("EOYAmt")]
//     public string EOYAmt { get; set; }
//
//     [JsonProperty("BOYAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("BOYAmt")]
//     public string BOYAmt { get; set; }
// }
//
// public class USAddress
// {
//     [JsonProperty("AddressLine1Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine1Txt")]
//     public string AddressLine1Txt { get; set; }
//
//     [JsonProperty("CityNm", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("CityNm")]
//     public string CityNm { get; set; }
//
//     [JsonProperty("StateAbbreviationCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("StateAbbreviationCd")]
//     public string StateAbbreviationCd { get; set; }
//
//     [JsonProperty("ZIPCd", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ZIPCd")]
//     public string ZIPCd { get; set; }
//
//     [JsonProperty("AddressLine2Txt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("AddressLine2Txt")]
//     public string AddressLine2Txt { get; set; }
// }
//
// public class USGovernmentObligationsEOYAmt
// {
//     [JsonProperty("@referenceDocumentId", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentId")]
//     public string ReferenceDocumentId { get; set; }
//
//     [JsonProperty("@referenceDocumentName", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("@referenceDocumentName")]
//     public string ReferenceDocumentName { get; set; }
//
//     [JsonProperty("#text", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("#text")]
//     public string Text { get; set; }
// }
//
// public class WorkforceDevelopmentGrp
// {
//     [JsonProperty("TotalCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalCommunityBenefitExpnsAmt")]
//     public string TotalCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("DirectOffsettingRevenueAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("DirectOffsettingRevenueAmt")]
//     public string DirectOffsettingRevenueAmt { get; set; }
//
//     [JsonProperty("NetCommunityBenefitExpnsAmt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("NetCommunityBenefitExpnsAmt")]
//     public string NetCommunityBenefitExpnsAmt { get; set; }
//
//     [JsonProperty("TotalExpensePct", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("TotalExpensePct")]
//     public string TotalExpensePct { get; set; }
//
//     [JsonProperty("ActivitiesOrProgramsCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("ActivitiesOrProgramsCnt")]
//     public string ActivitiesOrProgramsCnt { get; set; }
//
//     [JsonProperty("PersonsServedCnt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("PersonsServedCnt")]
//     public string PersonsServedCnt { get; set; }
// }
//
// public class WorkOpportunityCrFrom5884Grp
// {
//     [JsonProperty("WorkOpportunityCrFrom5884Amt", NullValueHandling = NullValueHandling.Ignore)]
//     [JsonPropertyName("WorkOpportunityCrFrom5884Amt")]
//     public string WorkOpportunityCrFrom5884Amt { get; set; }
// }