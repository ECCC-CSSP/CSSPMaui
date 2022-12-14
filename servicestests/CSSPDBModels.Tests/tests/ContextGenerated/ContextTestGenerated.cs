/*
 * Auto generated from C:\CSSPTools\src\codegen\GenerateCSSPDBModels_TestsGenerated\bin\Debug\net6.0\GenerateCSSPDBModels_TestsGenerated.exe
 *
 * Do not edit this file.
 *
 */ 

namespace CSSPDBModels.Tests;

public partial class ContextTest
{
    public ContextTest() : base()
    {

    }

    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Context_Constructor_Good_Test(string culture)
    {
        Assert.True(await ContextDBModelSetup(culture));
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task CSSPDBContext_Good_Test(string culture)
    {
        Assert.True(await ContextDBModelSetup(culture));

        CSSPDBContext csspDBContext = new();
        Assert.NotNull(csspDBContext);

        CSSPDBContext csspDBContext2 = Provider.GetService<CSSPDBContext>();
        Assert.NotNull(csspDBContext2);

        var Addresses = csspDBContext2.Addresses;
        Assert.NotNull(Addresses);

        var AppErrLogs = csspDBContext2.AppErrLogs;
        Assert.NotNull(AppErrLogs);

        var AppTasks = csspDBContext2.AppTasks;
        Assert.NotNull(AppTasks);

        var AppTaskLanguages = csspDBContext2.AppTaskLanguages;
        Assert.NotNull(AppTaskLanguages);

        var BoxModels = csspDBContext2.BoxModels;
        Assert.NotNull(BoxModels);

        var BoxModelLanguages = csspDBContext2.BoxModelLanguages;
        Assert.NotNull(BoxModelLanguages);

        var BoxModelResults = csspDBContext2.BoxModelResults;
        Assert.NotNull(BoxModelResults);

        var Classifications = csspDBContext2.Classifications;
        Assert.NotNull(Classifications);

        var ClimateDataValues = csspDBContext2.ClimateDataValues;
        Assert.NotNull(ClimateDataValues);

        var ClimateSites = csspDBContext2.ClimateSites;
        Assert.NotNull(ClimateSites);

        var CoCoRaHSSites = csspDBContext2.CoCoRaHSSites;
        Assert.NotNull(CoCoRaHSSites);

        var CoCoRaHSValues = csspDBContext2.CoCoRaHSValues;
        Assert.NotNull(CoCoRaHSValues);

        var Contacts = csspDBContext2.Contacts;
        Assert.NotNull(Contacts);

        var ContactPreferences = csspDBContext2.ContactPreferences;
        Assert.NotNull(ContactPreferences);

        var ContactShortcuts = csspDBContext2.ContactShortcuts;
        Assert.NotNull(ContactShortcuts);

        var DocTemplates = csspDBContext2.DocTemplates;
        Assert.NotNull(DocTemplates);

        var DrogueRuns = csspDBContext2.DrogueRuns;
        Assert.NotNull(DrogueRuns);

        var DrogueRunPositions = csspDBContext2.DrogueRunPositions;
        Assert.NotNull(DrogueRunPositions);

        var Emails = csspDBContext2.Emails;
        Assert.NotNull(Emails);

        var EmailDistributionLists = csspDBContext2.EmailDistributionLists;
        Assert.NotNull(EmailDistributionLists);

        var EmailDistributionListContacts = csspDBContext2.EmailDistributionListContacts;
        Assert.NotNull(EmailDistributionListContacts);

        var EmailDistributionListContactLanguages = csspDBContext2.EmailDistributionListContactLanguages;
        Assert.NotNull(EmailDistributionListContactLanguages);

        var EmailDistributionListLanguages = csspDBContext2.EmailDistributionListLanguages;
        Assert.NotNull(EmailDistributionListLanguages);

        var HelpDocs = csspDBContext2.HelpDocs;
        Assert.NotNull(HelpDocs);

        var HydrometricDataValues = csspDBContext2.HydrometricDataValues;
        Assert.NotNull(HydrometricDataValues);

        var HydrometricSites = csspDBContext2.HydrometricSites;
        Assert.NotNull(HydrometricSites);

        var Infrastructures = csspDBContext2.Infrastructures;
        Assert.NotNull(Infrastructures);

        var InfrastructureLanguages = csspDBContext2.InfrastructureLanguages;
        Assert.NotNull(InfrastructureLanguages);

        var LabSheets = csspDBContext2.LabSheets;
        Assert.NotNull(LabSheets);

        var LabSheetDetails = csspDBContext2.LabSheetDetails;
        Assert.NotNull(LabSheetDetails);

        var LabSheetTubeMPNDetails = csspDBContext2.LabSheetTubeMPNDetails;
        Assert.NotNull(LabSheetTubeMPNDetails);

        var Logs = csspDBContext2.Logs;
        Assert.NotNull(Logs);

        var MapInfos = csspDBContext2.MapInfos;
        Assert.NotNull(MapInfos);

        var MapInfoPoints = csspDBContext2.MapInfoPoints;
        Assert.NotNull(MapInfoPoints);

        var MikeBoundaryConditions = csspDBContext2.MikeBoundaryConditions;
        Assert.NotNull(MikeBoundaryConditions);

        var MikeScenarios = csspDBContext2.MikeScenarios;
        Assert.NotNull(MikeScenarios);

        var MikeScenarioResults = csspDBContext2.MikeScenarioResults;
        Assert.NotNull(MikeScenarioResults);

        var MikeSources = csspDBContext2.MikeSources;
        Assert.NotNull(MikeSources);

        var MikeSourceStartEnds = csspDBContext2.MikeSourceStartEnds;
        Assert.NotNull(MikeSourceStartEnds);

        var MWQMAnalysisReportParameters = csspDBContext2.MWQMAnalysisReportParameters;
        Assert.NotNull(MWQMAnalysisReportParameters);

        var MWQMLookupMPNs = csspDBContext2.MWQMLookupMPNs;
        Assert.NotNull(MWQMLookupMPNs);

        var MWQMRuns = csspDBContext2.MWQMRuns;
        Assert.NotNull(MWQMRuns);

        var MWQMRunLanguages = csspDBContext2.MWQMRunLanguages;
        Assert.NotNull(MWQMRunLanguages);

        var MWQMSamples = csspDBContext2.MWQMSamples;
        Assert.NotNull(MWQMSamples);

        var MWQMSampleLanguages = csspDBContext2.MWQMSampleLanguages;
        Assert.NotNull(MWQMSampleLanguages);

        var MWQMSites = csspDBContext2.MWQMSites;
        Assert.NotNull(MWQMSites);

        var MWQMSiteStartEndDates = csspDBContext2.MWQMSiteStartEndDates;
        Assert.NotNull(MWQMSiteStartEndDates);

        var MWQMSubsectors = csspDBContext2.MWQMSubsectors;
        Assert.NotNull(MWQMSubsectors);

        var MWQMSubsectorLanguages = csspDBContext2.MWQMSubsectorLanguages;
        Assert.NotNull(MWQMSubsectorLanguages);

        var PolSourceGroupings = csspDBContext2.PolSourceGroupings;
        Assert.NotNull(PolSourceGroupings);

        var PolSourceGroupingLanguages = csspDBContext2.PolSourceGroupingLanguages;
        Assert.NotNull(PolSourceGroupingLanguages);

        var PolSourceObservations = csspDBContext2.PolSourceObservations;
        Assert.NotNull(PolSourceObservations);

        var PolSourceObservationIssues = csspDBContext2.PolSourceObservationIssues;
        Assert.NotNull(PolSourceObservationIssues);

        var PolSourceSites = csspDBContext2.PolSourceSites;
        Assert.NotNull(PolSourceSites);

        var PolSourceSiteEffects = csspDBContext2.PolSourceSiteEffects;
        Assert.NotNull(PolSourceSiteEffects);

        var PolSourceSiteEffectTerms = csspDBContext2.PolSourceSiteEffectTerms;
        Assert.NotNull(PolSourceSiteEffectTerms);

        var RainExceedances = csspDBContext2.RainExceedances;
        Assert.NotNull(RainExceedances);

        var RainExceedanceClimateSites = csspDBContext2.RainExceedanceClimateSites;
        Assert.NotNull(RainExceedanceClimateSites);

        var RatingCurves = csspDBContext2.RatingCurves;
        Assert.NotNull(RatingCurves);

        var RatingCurveValues = csspDBContext2.RatingCurveValues;
        Assert.NotNull(RatingCurveValues);

        var ReportSections = csspDBContext2.ReportSections;
        Assert.NotNull(ReportSections);

        var ReportTypes = csspDBContext2.ReportTypes;
        Assert.NotNull(ReportTypes);

        var ResetPasswords = csspDBContext2.ResetPasswords;
        Assert.NotNull(ResetPasswords);

        var SamplingPlans = csspDBContext2.SamplingPlans;
        Assert.NotNull(SamplingPlans);

        var SamplingPlanEmails = csspDBContext2.SamplingPlanEmails;
        Assert.NotNull(SamplingPlanEmails);

        var SamplingPlanSubsectors = csspDBContext2.SamplingPlanSubsectors;
        Assert.NotNull(SamplingPlanSubsectors);

        var SamplingPlanSubsectorSites = csspDBContext2.SamplingPlanSubsectorSites;
        Assert.NotNull(SamplingPlanSubsectorSites);

        var Spills = csspDBContext2.Spills;
        Assert.NotNull(Spills);

        var SpillLanguages = csspDBContext2.SpillLanguages;
        Assert.NotNull(SpillLanguages);

        var Tels = csspDBContext2.Tels;
        Assert.NotNull(Tels);

        var TideDataValues = csspDBContext2.TideDataValues;
        Assert.NotNull(TideDataValues);

        var TideLocations = csspDBContext2.TideLocations;
        Assert.NotNull(TideLocations);

        var TideSites = csspDBContext2.TideSites;
        Assert.NotNull(TideSites);

        var TVFiles = csspDBContext2.TVFiles;
        Assert.NotNull(TVFiles);

        var TVFileLanguages = csspDBContext2.TVFileLanguages;
        Assert.NotNull(TVFileLanguages);

        var TVItems = csspDBContext2.TVItems;
        Assert.NotNull(TVItems);

        var TVItemLanguages = csspDBContext2.TVItemLanguages;
        Assert.NotNull(TVItemLanguages);

        var TVItemLinks = csspDBContext2.TVItemLinks;
        Assert.NotNull(TVItemLinks);

        var TVItemStats = csspDBContext2.TVItemStats;
        Assert.NotNull(TVItemStats);

        var TVItemUserAuthorizations = csspDBContext2.TVItemUserAuthorizations;
        Assert.NotNull(TVItemUserAuthorizations);

        var TVTypeUserAuthorizations = csspDBContext2.TVTypeUserAuthorizations;
        Assert.NotNull(TVTypeUserAuthorizations);

        var UseOfSites = csspDBContext2.UseOfSites;
        Assert.NotNull(UseOfSites);

        var VPAmbients = csspDBContext2.VPAmbients;
        Assert.NotNull(VPAmbients);

        var VPResults = csspDBContext2.VPResults;
        Assert.NotNull(VPResults);

        var VPScenarios = csspDBContext2.VPScenarios;
        Assert.NotNull(VPScenarios);

        var VPScenarioLanguages = csspDBContext2.VPScenarioLanguages;
        Assert.NotNull(VPScenarioLanguages);

    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task CSSPDBLocalContext_Good_Test(string culture)
    {
        Assert.True(await ContextDBModelSetup(culture));

        CSSPDBLocalContext csspDBLocalContext = new();
        Assert.NotNull(csspDBLocalContext);

        CSSPDBLocalContext csspDBLocalContext2 = Provider.GetService<CSSPDBLocalContext>();
        Assert.NotNull(csspDBLocalContext2);

        var Addresses = csspDBLocalContext2.Addresses;
        Assert.NotNull(Addresses);

        var AppErrLogs = csspDBLocalContext2.AppErrLogs;
        Assert.NotNull(AppErrLogs);

        var AppTasks = csspDBLocalContext2.AppTasks;
        Assert.NotNull(AppTasks);

        var AppTaskLanguages = csspDBLocalContext2.AppTaskLanguages;
        Assert.NotNull(AppTaskLanguages);

        var BoxModels = csspDBLocalContext2.BoxModels;
        Assert.NotNull(BoxModels);

        var BoxModelLanguages = csspDBLocalContext2.BoxModelLanguages;
        Assert.NotNull(BoxModelLanguages);

        var BoxModelResults = csspDBLocalContext2.BoxModelResults;
        Assert.NotNull(BoxModelResults);

        var Classifications = csspDBLocalContext2.Classifications;
        Assert.NotNull(Classifications);

        var ClimateDataValues = csspDBLocalContext2.ClimateDataValues;
        Assert.NotNull(ClimateDataValues);

        var ClimateSites = csspDBLocalContext2.ClimateSites;
        Assert.NotNull(ClimateSites);

        var CoCoRaHSSites = csspDBLocalContext2.CoCoRaHSSites;
        Assert.NotNull(CoCoRaHSSites);

        var CoCoRaHSValues = csspDBLocalContext2.CoCoRaHSValues;
        Assert.NotNull(CoCoRaHSValues);

        var Contacts = csspDBLocalContext2.Contacts;
        Assert.NotNull(Contacts);

        var ContactPreferences = csspDBLocalContext2.ContactPreferences;
        Assert.NotNull(ContactPreferences);

        var ContactShortcuts = csspDBLocalContext2.ContactShortcuts;
        Assert.NotNull(ContactShortcuts);

        var DocTemplates = csspDBLocalContext2.DocTemplates;
        Assert.NotNull(DocTemplates);

        var DrogueRuns = csspDBLocalContext2.DrogueRuns;
        Assert.NotNull(DrogueRuns);

        var DrogueRunPositions = csspDBLocalContext2.DrogueRunPositions;
        Assert.NotNull(DrogueRunPositions);

        var Emails = csspDBLocalContext2.Emails;
        Assert.NotNull(Emails);

        var EmailDistributionLists = csspDBLocalContext2.EmailDistributionLists;
        Assert.NotNull(EmailDistributionLists);

        var EmailDistributionListContacts = csspDBLocalContext2.EmailDistributionListContacts;
        Assert.NotNull(EmailDistributionListContacts);

        var EmailDistributionListContactLanguages = csspDBLocalContext2.EmailDistributionListContactLanguages;
        Assert.NotNull(EmailDistributionListContactLanguages);

        var EmailDistributionListLanguages = csspDBLocalContext2.EmailDistributionListLanguages;
        Assert.NotNull(EmailDistributionListLanguages);

        var HelpDocs = csspDBLocalContext2.HelpDocs;
        Assert.NotNull(HelpDocs);

        var HydrometricDataValues = csspDBLocalContext2.HydrometricDataValues;
        Assert.NotNull(HydrometricDataValues);

        var HydrometricSites = csspDBLocalContext2.HydrometricSites;
        Assert.NotNull(HydrometricSites);

        var Infrastructures = csspDBLocalContext2.Infrastructures;
        Assert.NotNull(Infrastructures);

        var InfrastructureLanguages = csspDBLocalContext2.InfrastructureLanguages;
        Assert.NotNull(InfrastructureLanguages);

        var LabSheets = csspDBLocalContext2.LabSheets;
        Assert.NotNull(LabSheets);

        var LabSheetDetails = csspDBLocalContext2.LabSheetDetails;
        Assert.NotNull(LabSheetDetails);

        var LabSheetTubeMPNDetails = csspDBLocalContext2.LabSheetTubeMPNDetails;
        Assert.NotNull(LabSheetTubeMPNDetails);

        var Logs = csspDBLocalContext2.Logs;
        Assert.NotNull(Logs);

        var MapInfos = csspDBLocalContext2.MapInfos;
        Assert.NotNull(MapInfos);

        var MapInfoPoints = csspDBLocalContext2.MapInfoPoints;
        Assert.NotNull(MapInfoPoints);

        var MikeBoundaryConditions = csspDBLocalContext2.MikeBoundaryConditions;
        Assert.NotNull(MikeBoundaryConditions);

        var MikeScenarios = csspDBLocalContext2.MikeScenarios;
        Assert.NotNull(MikeScenarios);

        var MikeScenarioResults = csspDBLocalContext2.MikeScenarioResults;
        Assert.NotNull(MikeScenarioResults);

        var MikeSources = csspDBLocalContext2.MikeSources;
        Assert.NotNull(MikeSources);

        var MikeSourceStartEnds = csspDBLocalContext2.MikeSourceStartEnds;
        Assert.NotNull(MikeSourceStartEnds);

        var MWQMAnalysisReportParameters = csspDBLocalContext2.MWQMAnalysisReportParameters;
        Assert.NotNull(MWQMAnalysisReportParameters);

        var MWQMLookupMPNs = csspDBLocalContext2.MWQMLookupMPNs;
        Assert.NotNull(MWQMLookupMPNs);

        var MWQMRuns = csspDBLocalContext2.MWQMRuns;
        Assert.NotNull(MWQMRuns);

        var MWQMRunLanguages = csspDBLocalContext2.MWQMRunLanguages;
        Assert.NotNull(MWQMRunLanguages);

        var MWQMSamples = csspDBLocalContext2.MWQMSamples;
        Assert.NotNull(MWQMSamples);

        var MWQMSampleLanguages = csspDBLocalContext2.MWQMSampleLanguages;
        Assert.NotNull(MWQMSampleLanguages);

        var MWQMSites = csspDBLocalContext2.MWQMSites;
        Assert.NotNull(MWQMSites);

        var MWQMSiteStartEndDates = csspDBLocalContext2.MWQMSiteStartEndDates;
        Assert.NotNull(MWQMSiteStartEndDates);

        var MWQMSubsectors = csspDBLocalContext2.MWQMSubsectors;
        Assert.NotNull(MWQMSubsectors);

        var MWQMSubsectorLanguages = csspDBLocalContext2.MWQMSubsectorLanguages;
        Assert.NotNull(MWQMSubsectorLanguages);

        var PolSourceGroupings = csspDBLocalContext2.PolSourceGroupings;
        Assert.NotNull(PolSourceGroupings);

        var PolSourceGroupingLanguages = csspDBLocalContext2.PolSourceGroupingLanguages;
        Assert.NotNull(PolSourceGroupingLanguages);

        var PolSourceObservations = csspDBLocalContext2.PolSourceObservations;
        Assert.NotNull(PolSourceObservations);

        var PolSourceObservationIssues = csspDBLocalContext2.PolSourceObservationIssues;
        Assert.NotNull(PolSourceObservationIssues);

        var PolSourceSites = csspDBLocalContext2.PolSourceSites;
        Assert.NotNull(PolSourceSites);

        var PolSourceSiteEffects = csspDBLocalContext2.PolSourceSiteEffects;
        Assert.NotNull(PolSourceSiteEffects);

        var PolSourceSiteEffectTerms = csspDBLocalContext2.PolSourceSiteEffectTerms;
        Assert.NotNull(PolSourceSiteEffectTerms);

        var RainExceedances = csspDBLocalContext2.RainExceedances;
        Assert.NotNull(RainExceedances);

        var RainExceedanceClimateSites = csspDBLocalContext2.RainExceedanceClimateSites;
        Assert.NotNull(RainExceedanceClimateSites);

        var RatingCurves = csspDBLocalContext2.RatingCurves;
        Assert.NotNull(RatingCurves);

        var RatingCurveValues = csspDBLocalContext2.RatingCurveValues;
        Assert.NotNull(RatingCurveValues);

        var ReportSections = csspDBLocalContext2.ReportSections;
        Assert.NotNull(ReportSections);

        var ReportTypes = csspDBLocalContext2.ReportTypes;
        Assert.NotNull(ReportTypes);

        var ResetPasswords = csspDBLocalContext2.ResetPasswords;
        Assert.NotNull(ResetPasswords);

        var SamplingPlans = csspDBLocalContext2.SamplingPlans;
        Assert.NotNull(SamplingPlans);

        var SamplingPlanEmails = csspDBLocalContext2.SamplingPlanEmails;
        Assert.NotNull(SamplingPlanEmails);

        var SamplingPlanSubsectors = csspDBLocalContext2.SamplingPlanSubsectors;
        Assert.NotNull(SamplingPlanSubsectors);

        var SamplingPlanSubsectorSites = csspDBLocalContext2.SamplingPlanSubsectorSites;
        Assert.NotNull(SamplingPlanSubsectorSites);

        var Spills = csspDBLocalContext2.Spills;
        Assert.NotNull(Spills);

        var SpillLanguages = csspDBLocalContext2.SpillLanguages;
        Assert.NotNull(SpillLanguages);

        var Tels = csspDBLocalContext2.Tels;
        Assert.NotNull(Tels);

        var TideDataValues = csspDBLocalContext2.TideDataValues;
        Assert.NotNull(TideDataValues);

        var TideLocations = csspDBLocalContext2.TideLocations;
        Assert.NotNull(TideLocations);

        var TideSites = csspDBLocalContext2.TideSites;
        Assert.NotNull(TideSites);

        var TVFiles = csspDBLocalContext2.TVFiles;
        Assert.NotNull(TVFiles);

        var TVFileLanguages = csspDBLocalContext2.TVFileLanguages;
        Assert.NotNull(TVFileLanguages);

        var TVItems = csspDBLocalContext2.TVItems;
        Assert.NotNull(TVItems);

        var TVItemLanguages = csspDBLocalContext2.TVItemLanguages;
        Assert.NotNull(TVItemLanguages);

        var TVItemLinks = csspDBLocalContext2.TVItemLinks;
        Assert.NotNull(TVItemLinks);

        var TVItemStats = csspDBLocalContext2.TVItemStats;
        Assert.NotNull(TVItemStats);

        var TVItemUserAuthorizations = csspDBLocalContext2.TVItemUserAuthorizations;
        Assert.NotNull(TVItemUserAuthorizations);

        var TVTypeUserAuthorizations = csspDBLocalContext2.TVTypeUserAuthorizations;
        Assert.NotNull(TVTypeUserAuthorizations);

        var UseOfSites = csspDBLocalContext2.UseOfSites;
        Assert.NotNull(UseOfSites);

        var VPAmbients = csspDBLocalContext2.VPAmbients;
        Assert.NotNull(VPAmbients);

        var VPResults = csspDBLocalContext2.VPResults;
        Assert.NotNull(VPResults);

        var VPScenarios = csspDBLocalContext2.VPScenarios;
        Assert.NotNull(VPScenarios);

        var VPScenarioLanguages = csspDBLocalContext2.VPScenarioLanguages;
        Assert.NotNull(VPScenarioLanguages);

    }

}
