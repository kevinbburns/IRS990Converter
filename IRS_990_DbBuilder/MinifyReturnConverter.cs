namespace IRS_990_DbBuilder;

public static class MinifyReturnConverter
{
        public static List<IRS990Minified> Minify(this Return ret)
        {
                var converts = new List<IRS990Minified>();
                if (ret.IRS990ScheduleJ != null &&
                    ret.IRS990ScheduleJ.RltdOrgOfficerTrstKeyEmplGrp.Count != 0)
                {
                        converts.AddRange(
                                ret.IRS990ScheduleJ.RltdOrgOfficerTrstKeyEmplGrp.Select(officer => new IRS990Minified
                        {
                                Id = ret.Id.ToString(),
                                FileName = ret.FileName,
                                EIN = ret.Filer?.EIN,
                                TaxYr = ret.TaxYr,
                                ReturnTs = ret.ReturnTs,
                                TaxPeriodEndDt = ret.TaxPeriodEndDt,
                                TaxPeriodBeginDt = ret.TaxPeriodBeginDt,
                                BusinessNameLine1Txt = ret.Filer?.BusinessName?.BusinessNameLine1Txt,
                                AddressLine1Txt = ret.Filer?.USAddress?.AddressLine1Txt,
                                CityNm = ret.Filer?.USAddress?.CityNm,
                                StateAbbreviationCd = ret.Filer?.USAddress?.StateAbbreviationCd,
                                ZIPCd = ret.Filer?.USAddress?.ZIPCd,
                                TotalEmployeeCnt = ret.IRS990?.TotalEmployeeCnt,
                                PYTotalRevenueAmt = ret.IRS990?.PYTotalRevenueAmt,
                                CYTotalRevenueAmt = ret.IRS990?.CYTotalRevenueAmt,
                                PYRevenuesLessExpensesAmt = ret.IRS990?.PYRevenuesLessExpensesAmt,
                                CYRevenuesLessExpensesAmt = ret.IRS990?.CYRevenuesLessExpensesAmt,
                                TotalAssetsBOYAmt = ret.IRS990?.TotalAssetsBOYAmt,
                                TotalAssetsEOYAmt = ret.IRS990?.TotalAssetsEOYAmt,
                                SupplementalNonqualRtrPlanInd = ret.IRS990ScheduleJ.SupplementalNonqualRtrPlanInd,
                                Name = officer.PersonNm,
                                Title = officer.TitleTxt,
                                BaseCompensationFilingOrgAmt = officer.BaseCompensationFilingOrgAmt,
                                BonusFilingOrganizationAmount = officer.BonusFilingOrganizationAmount,
                                BonusRelatedOrganizationsAmt = officer.BonusRelatedOrganizationsAmt,
                                OtherCompensationFilingOrgAmt = officer.OtherCompensationFilingOrgAmt,
                                OtherCompensationRltdOrgsAmt = officer.OtherCompensationRltdOrgsAmt,
                                DeferredCompensationFlngOrgAmt = officer.DeferredCompensationFlngOrgAmt,
                                DeferredCompRltdOrgsAmt = officer.DeferredCompRltdOrgsAmt,
                                NontaxableBenefitsFilingOrgAmt = officer.NontaxableBenefitsFilingOrgAmt,
                                NontaxableBenefitsRltdOrgsAmt = officer.NontaxableBenefitsRltdOrgsAmt,
                                TotalCompensationFilingOrgAmt = officer.TotalCompensationFilingOrgAmt,
                                TotalCompensationRltdOrgsAmt = officer.TotalCompensationRltdOrgsAmt,
                                CompReportPrior990FilingOrgAmt = officer.CompReportPrior990FilingOrgAmt,
                                CompReportPrior990RltdOrgsAmt = officer.CompReportPrior990RltdOrgsAmt
                        }));

                        return converts
                                .OrderBy(x => x.Name)
                                   .ToList();
                }
                else
                {
                        converts.Add(new IRS990Minified
                        {
                                Id = ret.Id.ToString(),
                                FileName = ret.FileName,
                                EIN = ret.Filer?.EIN,
                                TaxYr = ret.TaxYr,
                                ReturnTs = ret.ReturnTs,
                                TaxPeriodEndDt = ret.TaxPeriodEndDt,
                                TaxPeriodBeginDt = ret.TaxPeriodBeginDt,
                                BusinessNameLine1Txt = ret.Filer?.BusinessName?.BusinessNameLine1Txt,
                                AddressLine1Txt = ret.Filer?.USAddress?.AddressLine1Txt,
                                CityNm = ret.Filer?.USAddress?.CityNm,
                                StateAbbreviationCd = ret.Filer?.USAddress?.StateAbbreviationCd,
                                ZIPCd = ret.Filer?.USAddress?.ZIPCd,
                                TotalEmployeeCnt = ret.IRS990?.TotalEmployeeCnt,
                                PYTotalRevenueAmt = ret.IRS990?.PYTotalRevenueAmt,
                                CYTotalRevenueAmt = ret.IRS990?.CYTotalRevenueAmt,
                                PYRevenuesLessExpensesAmt = ret.IRS990?.PYRevenuesLessExpensesAmt,
                                CYRevenuesLessExpensesAmt = ret.IRS990?.CYRevenuesLessExpensesAmt,
                                TotalAssetsBOYAmt = ret.IRS990?.TotalAssetsBOYAmt,
                                TotalAssetsEOYAmt = ret.IRS990?.TotalAssetsEOYAmt
                        });
                        
                        return converts;
                }

        }
}