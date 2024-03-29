﻿namespace CSSPDBModels;

public partial class CSSPDBContext : DbContext
{
    public virtual DbSet<Address> Addresses { get; set; }
    public virtual DbSet<AppErrLog> AppErrLogs { get; set; }
    public virtual DbSet<AppTask> AppTasks { get; set; }
    public virtual DbSet<AppTaskLanguage> AppTaskLanguages { get; set; }
    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
    public virtual DbSet<BoxModel> BoxModels { get; set; }
    public virtual DbSet<BoxModelLanguage> BoxModelLanguages { get; set; }
    public virtual DbSet<BoxModelResult> BoxModelResults { get; set; }
    public virtual DbSet<Classification> Classifications { get; set; }
    public virtual DbSet<ClimateDataValue> ClimateDataValues { get; set; }
    public virtual DbSet<ClimateSite> ClimateSites { get; set; }
    public virtual DbSet<CoCoRaHSSite> CoCoRaHSSites { get; set; }
    public virtual DbSet<CoCoRaHSValue> CoCoRaHSValues { get; set; }
    public virtual DbSet<Contact> Contacts { get; set; }
    public virtual DbSet<ContactPreference> ContactPreferences { get; set; }
    public virtual DbSet<ContactShortcut> ContactShortcuts { get; set; }
    //public virtual DbSet<DeviceCode> DeviceCodes { get; set; }
    public virtual DbSet<DocTemplate> DocTemplates { get; set; }
    public virtual DbSet<DrogueRun> DrogueRuns { get; set; }
    public virtual DbSet<DrogueRunPosition> DrogueRunPositions { get; set; }
    public virtual DbSet<Email> Emails { get; set; }
    public virtual DbSet<EmailDistributionList> EmailDistributionLists { get; set; }
    public virtual DbSet<EmailDistributionListLanguage> EmailDistributionListLanguages { get; set; }
    public virtual DbSet<EmailDistributionListContact> EmailDistributionListContacts { get; set; }
    public virtual DbSet<EmailDistributionListContactLanguage> EmailDistributionListContactLanguages { get; set; }
    public virtual DbSet<HelpDoc> HelpDocs { get; set; }
    public virtual DbSet<HydrometricDataValue> HydrometricDataValues { get; set; }
    public virtual DbSet<HydrometricSite> HydrometricSites { get; set; }
    public virtual DbSet<Infrastructure> Infrastructures { get; set; }
    public virtual DbSet<InfrastructureLanguage> InfrastructureLanguages { get; set; }
    public virtual DbSet<LabSheetDetail> LabSheetDetails { get; set; }
    public virtual DbSet<LabSheetTubeMPNDetail> LabSheetTubeMPNDetails { get; set; }
    public virtual DbSet<LabSheet> LabSheets { get; set; }
    public virtual DbSet<Log> Logs { get; set; }
    public virtual DbSet<MapInfoPoint> MapInfoPoints { get; set; }
    public virtual DbSet<MapInfo> MapInfos { get; set; }
    public virtual DbSet<MikeBoundaryCondition> MikeBoundaryConditions { get; set; }
    public virtual DbSet<MikeScenarioResult> MikeScenarioResults { get; set; }
    public virtual DbSet<MikeScenario> MikeScenarios { get; set; }
    public virtual DbSet<MikeSourceStartEnd> MikeSourceStartEnds { get; set; }
    public virtual DbSet<MWQMAnalysisReportParameter> MWQMAnalysisReportParameters { get; set; }
    public virtual DbSet<MikeSource> MikeSources { get; set; }
    public virtual DbSet<MWQMLookupMPN> MWQMLookupMPNs { get; set; }
    public virtual DbSet<MWQMRunLanguage> MWQMRunLanguages { get; set; }
    public virtual DbSet<MWQMRun> MWQMRuns { get; set; }
    public virtual DbSet<MWQMSampleLanguage> MWQMSampleLanguages { get; set; }
    public virtual DbSet<MWQMSample> MWQMSamples { get; set; }
    public virtual DbSet<MWQMSiteStartEndDate> MWQMSiteStartEndDates { get; set; }
    public virtual DbSet<MWQMSite> MWQMSites { get; set; }
    public virtual DbSet<MWQMSubsectorLanguage> MWQMSubsectorLanguages { get; set; }
    public virtual DbSet<MWQMSubsector> MWQMSubsectors { get; set; }
    //public virtual DbSet<PersistedGrant> PersistedGrants { get; set; }
    public virtual DbSet<PolSourceGroupingLanguage> PolSourceGroupingLanguages { get; set; }
    public virtual DbSet<PolSourceGrouping> PolSourceGroupings { get; set; }
    public virtual DbSet<PolSourceObservationIssue> PolSourceObservationIssues { get; set; }
    public virtual DbSet<PolSourceObservation> PolSourceObservations { get; set; }
    public virtual DbSet<PolSourceSite> PolSourceSites { get; set; }
    public virtual DbSet<PolSourceSiteEffect> PolSourceSiteEffects { get; set; }
    public virtual DbSet<PolSourceSiteEffectTerm> PolSourceSiteEffectTerms { get; set; }
    public virtual DbSet<RainExceedance> RainExceedances { get; set; }
    public virtual DbSet<RainExceedanceClimateSite> RainExceedanceClimateSites { get; set; }
    public virtual DbSet<RatingCurveValue> RatingCurveValues { get; set; }
    public virtual DbSet<RatingCurve> RatingCurves { get; set; }
    public virtual DbSet<ResetPassword> ResetPasswords { get; set; }
    public virtual DbSet<ReportSection> ReportSections { get; set; }
    public virtual DbSet<ReportType> ReportTypes { get; set; }
    public virtual DbSet<SamplingPlanSubsectorSite> SamplingPlanSubsectorSites { get; set; }
    public virtual DbSet<SamplingPlanSubsector> SamplingPlanSubsectors { get; set; }
    public virtual DbSet<SamplingPlanEmail> SamplingPlanEmails { get; set; }
    public virtual DbSet<SamplingPlan> SamplingPlans { get; set; }
    public virtual DbSet<SpillLanguage> SpillLanguages { get; set; }
    public virtual DbSet<Spill> Spills { get; set; }
    public virtual DbSet<Tel> Tels { get; set; }
    public virtual DbSet<TideDataValue> TideDataValues { get; set; }
    public virtual DbSet<TideLocation> TideLocations { get; set; }
    public virtual DbSet<TideSite> TideSites { get; set; }
    public virtual DbSet<TVFileLanguage> TVFileLanguages { get; set; }
    public virtual DbSet<TVFile> TVFiles { get; set; }
    public virtual DbSet<TVItem> TVItems { get; set; }
    public virtual DbSet<TVItemLanguage> TVItemLanguages { get; set; }
    public virtual DbSet<TVItemLink> TVItemLinks { get; set; }
    public virtual DbSet<TVItemStat> TVItemStats { get; set; }
    public virtual DbSet<TVItemUserAuthorization> TVItemUserAuthorizations { get; set; }
    public virtual DbSet<TVTypeUserAuthorization> TVTypeUserAuthorizations { get; set; }
    public virtual DbSet<UseOfSite> UseOfSites { get; set; }
    public virtual DbSet<VPAmbient> VPAmbients { get; set; }
    public virtual DbSet<VPResult> VPResults { get; set; }
    public virtual DbSet<VPScenarioLanguage> VPScenarioLanguages { get; set; }
    public virtual DbSet<VPScenario> VPScenarios { get; set; }

    public CSSPDBContext()
    {
    }

    public CSSPDBContext(DbContextOptions<CSSPDBContext> options)
        : base(options)
    {
    }
}
