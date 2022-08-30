///*
// * Auto generated from C:\CSSPTools\src\codegen\_package\net5.0\GenerateCSSPDBLocalModels.exe
// *
// * Do not edit this file.
// *
// */

//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;

//namespace CSSPDBLocalModels
//{
//    public partial class CSSPDBLocalContext : DbContext
//    {
//        #region Properties
//        public virtual DbSet<LocalAddress> LocalAddresses { get; set; }
//        public virtual DbSet<LocalAppErrLog> LocalAppErrLogs { get; set; }
//        public virtual DbSet<LocalAppTask> LocalAppTasks { get; set; }
//        public virtual DbSet<LocalAppTaskLanguage> LocalAppTaskLanguages { get; set; }
//        public virtual DbSet<LocalBoxModel> LocalBoxModels { get; set; }
//        public virtual DbSet<LocalBoxModelLanguage> LocalBoxModelLanguages { get; set; }
//        public virtual DbSet<LocalBoxModelResult> LocalBoxModelResults { get; set; }
//        public virtual DbSet<LocalClassification> LocalClassifications { get; set; }
//        public virtual DbSet<LocalClimateDataValue> LocalClimateDataValues { get; set; }
//        public virtual DbSet<LocalClimateSite> LocalClimateSites { get; set; }
//        public virtual DbSet<LocalContact> LocalContacts { get; set; }
//        public virtual DbSet<LocalContactPreference> LocalContactPreferences { get; set; }
//        public virtual DbSet<LocalContactShortcut> LocalContactShortcuts { get; set; }
//        public virtual DbSet<LocalDocTemplate> LocalDocTemplates { get; set; }
//        public virtual DbSet<LocalDrogueRun> LocalDrogueRuns { get; set; }
//        public virtual DbSet<LocalDrogueRunPosition> LocalDrogueRunPositions { get; set; }
//        public virtual DbSet<LocalEmail> LocalEmails { get; set; }
//        public virtual DbSet<LocalEmailDistributionList> LocalEmailDistributionLists { get; set; }
//        public virtual DbSet<LocalEmailDistributionListContact> LocalEmailDistributionListContacts { get; set; }
//        public virtual DbSet<LocalEmailDistributionListContactLanguage> LocalEmailDistributionListContactLanguages { get; set; }
//        public virtual DbSet<LocalEmailDistributionListLanguage> LocalEmailDistributionListLanguages { get; set; }
//        public virtual DbSet<LocalHelpDoc> LocalHelpDocs { get; set; }
//        public virtual DbSet<LocalHydrometricDataValue> LocalHydrometricDataValues { get; set; }
//        public virtual DbSet<LocalHydrometricSite> LocalHydrometricSites { get; set; }
//        public virtual DbSet<LocalInfrastructure> LocalInfrastructures { get; set; }
//        public virtual DbSet<LocalInfrastructureLanguage> LocalInfrastructureLanguages { get; set; }
//        public virtual DbSet<LocalLabSheet> LocalLabSheets { get; set; }
//        public virtual DbSet<LocalLabSheetDetail> LocalLabSheetDetails { get; set; }
//        public virtual DbSet<LocalLabSheetTubeMPNDetail> LocalLabSheetTubeMPNDetails { get; set; }
//        public virtual DbSet<LocalLog> LocalLogs { get; set; }
//        public virtual DbSet<LocalMapInfo> LocalMapInfos { get; set; }
//        public virtual DbSet<LocalMapInfoPoint> LocalMapInfoPoints { get; set; }
//        public virtual DbSet<LocalMikeBoundaryCondition> LocalMikeBoundaryConditions { get; set; }
//        public virtual DbSet<LocalMikeScenario> LocalMikeScenarios { get; set; }
//        public virtual DbSet<LocalMikeScenarioResult> LocalMikeScenarioResults { get; set; }
//        public virtual DbSet<LocalMikeSource> LocalMikeSources { get; set; }
//        public virtual DbSet<LocalMikeSourceStartEnd> LocalMikeSourceStartEnds { get; set; }
//        public virtual DbSet<LocalMWQMAnalysisReportParameter> LocalMWQMAnalysisReportParameters { get; set; }
//        public virtual DbSet<LocalMWQMLookupMPN> LocalMWQMLookupMPNs { get; set; }
//        public virtual DbSet<LocalMWQMRun> LocalMWQMRuns { get; set; }
//        public virtual DbSet<LocalMWQMRunLanguage> LocalMWQMRunLanguages { get; set; }
//        public virtual DbSet<LocalMWQMSample> LocalMWQMSamples { get; set; }
//        public virtual DbSet<LocalMWQMSampleLanguage> LocalMWQMSampleLanguages { get; set; }
//        public virtual DbSet<LocalMWQMSite> LocalMWQMSites { get; set; }
//        public virtual DbSet<LocalMWQMSiteStartEndDate> LocalMWQMSiteStartEndDates { get; set; }
//        public virtual DbSet<LocalMWQMSubsector> LocalMWQMSubsectors { get; set; }
//        public virtual DbSet<LocalMWQMSubsectorLanguage> LocalMWQMSubsectorLanguages { get; set; }
//        public virtual DbSet<LocalPolSourceGrouping> LocalPolSourceGroupings { get; set; }
//        public virtual DbSet<LocalPolSourceGroupingLanguage> LocalPolSourceGroupingLanguages { get; set; }
//        public virtual DbSet<LocalPolSourceObservation> LocalPolSourceObservations { get; set; }
//        public virtual DbSet<LocalPolSourceObservationIssue> LocalPolSourceObservationIssues { get; set; }
//        public virtual DbSet<LocalPolSourceSite> LocalPolSourceSites { get; set; }
//        public virtual DbSet<LocalPolSourceSiteEffect> LocalPolSourceSiteEffects { get; set; }
//        public virtual DbSet<LocalPolSourceSiteEffectTerm> LocalPolSourceSiteEffectTerms { get; set; }
//        public virtual DbSet<LocalRainExceedance> LocalRainExceedances { get; set; }
//        public virtual DbSet<LocalRainExceedanceClimateSite> LocalRainExceedanceClimateSites { get; set; }
//        public virtual DbSet<LocalRatingCurve> LocalRatingCurves { get; set; }
//        public virtual DbSet<LocalRatingCurveValue> LocalRatingCurveValues { get; set; }
//        public virtual DbSet<LocalReportSection> LocalReportSections { get; set; }
//        public virtual DbSet<LocalReportType> LocalReportTypes { get; set; }
//        public virtual DbSet<LocalResetPassword> LocalResetPasswords { get; set; }
//        public virtual DbSet<LocalSamplingPlan> LocalSamplingPlans { get; set; }
//        public virtual DbSet<LocalSamplingPlanEmail> LocalSamplingPlanEmails { get; set; }
//        public virtual DbSet<LocalSamplingPlanSubsector> LocalSamplingPlanSubsectors { get; set; }
//        public virtual DbSet<LocalSamplingPlanSubsectorSite> LocalSamplingPlanSubsectorSites { get; set; }
//        public virtual DbSet<LocalSpill> LocalSpills { get; set; }
//        public virtual DbSet<LocalSpillLanguage> LocalSpillLanguages { get; set; }
//        public virtual DbSet<LocalTel> LocalTels { get; set; }
//        public virtual DbSet<LocalTideDataValue> LocalTideDataValues { get; set; }
//        public virtual DbSet<LocalTideLocation> LocalTideLocations { get; set; }
//        public virtual DbSet<LocalTideSite> LocalTideSites { get; set; }
//        public virtual DbSet<LocalTVFile> LocalTVFiles { get; set; }
//        public virtual DbSet<LocalTVFileLanguage> LocalTVFileLanguages { get; set; }
//        public virtual DbSet<LocalTVItem> LocalTVItems { get; set; }
//        public virtual DbSet<LocalTVItemLanguage> LocalTVItemLanguages { get; set; }
//        public virtual DbSet<LocalTVItemLink> LocalTVItemLinks { get; set; }
//        public virtual DbSet<LocalTVItemStat> LocalTVItemStats { get; set; }
//        public virtual DbSet<LocalTVItemUserAuthorization> LocalTVItemUserAuthorizations { get; set; }
//        public virtual DbSet<LocalTVTypeUserAuthorization> LocalTVTypeUserAuthorizations { get; set; }
//        public virtual DbSet<LocalUseOfSite> LocalUseOfSites { get; set; }
//        public virtual DbSet<LocalVPAmbient> LocalVPAmbients { get; set; }
//        public virtual DbSet<LocalVPResult> LocalVPResults { get; set; }
//        public virtual DbSet<LocalVPScenario> LocalVPScenarios { get; set; }
//        public virtual DbSet<LocalVPScenarioLanguage> LocalVPScenarioLanguages { get; set; }
//        #endregion Properties

//        public CSSPDBLocalContext()
//        {
//        }

//        public CSSPDBLocalContext(DbContextOptions<CSSPDBLocalContext> options)
//            : base(options)
//        {
//        }

//        #region Overrides
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//        }
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);
//        }
//        #endregion Overrides


//    }
//}
