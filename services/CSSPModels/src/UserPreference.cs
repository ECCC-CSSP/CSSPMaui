namespace CSSPModels;

[NotMapped]
public partial class UserPreferenceModel
{
    public List<TVItemModel> History { get; set; } = new List<TVItemModel>();
    public int StatRunsForDetail { get; set; }
    public int AnalysisRuns { get; set; }
    public bool AnalysisFullYear { get; set; }
    [CSSPEnumType]
    public AnalysisCalculationTypeEnum AnalysisCalculationType { get; set; } = AnalysisCalculationTypeEnum.All;
    public int AnalysisHighlightSalFromAverage { get; set; }
    public int AnalysisShortRange { get; set; }
    public int AnalysisMidRange { get; set; }
    public int AnalysisDry24h { get; set; }
    public int AnalysisDry48h { get; set; }
    public int AnalysisDry72h { get; set; }
    public int AnalysisDry96h { get; set; }
    public int AnalysisWet24h { get; set; }
    public int AnalysisWet48h { get; set; }
    public int AnalysisWet72h { get; set; }
    public int AnalysisWet96h { get; set; }
    public bool AnalysisFCDataVisible { get; set; }
    public bool AnalysisTempDataVisible { get; set; }
    public bool AnalysisSalDataVisible { get; set; }
    public bool AnalysisP90DataVisible { get; set; }
    public bool AnalysisGeoMeanDataVisible { get; set; }
    public bool AnalysisMedianDataVisible { get; set; }
    public bool AnalysisPerOver43DataVisible { get; set; }
    public bool AnalysisPerOver260DataVisible { get; set; }
    [CSSPEnumType]
    public TopComponentEnum TopComponent { get; set; } = TopComponentEnum.Home;
    [CSSPEnumType]
    public ShellSubComponentEnum ShellSubComponent { get; set; } = ShellSubComponentEnum.Country;
    [CSSPEnumType]
    public RootSubComponentEnum RootSubComponent { get; set; } = RootSubComponentEnum.Countries;
    [CSSPEnumType]
    public CountrySubComponentEnum CountrySubComponent { get; set; } = CountrySubComponentEnum.Provinces;
    [CSSPEnumType]
    public ProvinceSubComponentEnum ProvinceSubComponent { get; set; } = ProvinceSubComponentEnum.Areas;
    [CSSPEnumType]
    public AreaSubComponentEnum AreaSubComponent { get; set; } = AreaSubComponentEnum.Sectors;
    [CSSPEnumType]
    public SectorSubComponentEnum SectorSubComponent { get; set; } = SectorSubComponentEnum.Subsectors;
    [CSSPEnumType]
    public SubsectorSubComponentEnum SubsectorSubComponent { get; set; } = SubsectorSubComponentEnum.MWQMSites;
    [CSSPEnumType]
    public MunicipalitySubComponentEnum MunicipalitySubComponent { get; set; } = MunicipalitySubComponentEnum.Infrastructures;
    public int CurrentRootTVItemID { get; set; }
    public int CurrentCountryTVItemID { get; set; }
    public int CurrentProvinceTVItemID { get; set; }
    public int CurrentMunicipalityTVItemID { get; set; }
    public int CurrentAreaTVItemID { get; set; }
    public int CurrentSectorTVItemID { get; set; }
    public int CurrentSubsectorTVItemID { get; set; }
    public bool DetailVisible { get; set; }
    public bool StatCountVisible { get; set; }
    public bool LastUpdateVisible { get; set; }
    public bool InactVisible { get; set; }
    public bool LeftSideNavVisible { get; set; }
    public bool EditVisible { get; set; }
    public bool MapVisible { get; set; }
    public string MapWidthText { get; set; } = string.Empty;
    public string MapMarkerColorArea { get; set; } = string.Empty;
    public string MapMarkerColorClimateSite { get; set; } = string.Empty;
    public string MapMarkerColorCountry { get; set; } = string.Empty;
    public string MapMarkerColorFailed { get; set; } = string.Empty;
    public string MapMarkerColorHydrometricSite { get; set; } = string.Empty;
    public string MapMarkerColorInfrastructure { get; set; } = string.Empty;
    public string MapMarkerColorLessThan10 { get; set; } = string.Empty;    
    public string MapMarkerColorLiftStation { get; set; } = string.Empty;
    public string MapMarkerColorLineOverflow { get; set; } = string.Empty;
    public string MapMarkerColorMeshNode { get; set; } = string.Empty;
    public string MapMarkerColorMikeBoundaryConditionMesh { get; set; } = string.Empty;
    public string MapMarkerColorMikeBoundaryConditionWebTide { get; set; } = string.Empty;
    public string MapMarkerColorMikeScenario { get; set; } = string.Empty;
    public string MapMarkerColorMikeSource { get; set; } = string.Empty;
    public string MapMarkerColorMikeSourceIncluded { get; set; } = string.Empty;
    public string MapMarkerColorMikeSourceIsRiver { get; set; } = string.Empty;
    public string MapMarkerColorMikeSourceNotIncluded { get; set; } = string.Empty;
    public string MapMarkerColorMunicipality { get; set; } = string.Empty;
    public string MapMarkerColorMWQMRun { get; set; } = string.Empty;
    public string MapMarkerColorMWQMSite { get; set; } = string.Empty;
    public string MapMarkerColorNoData { get; set; } = string.Empty;
    public string MapMarkerColorNoDepuration { get; set; } = string.Empty;
    public string MapMarkerColorOtherInfrastructure { get; set; } = string.Empty;
    public string MapMarkerColorOutfall { get; set; } = string.Empty;
    public string MapMarkerColorPassed { get; set; } = string.Empty;
    public string MapMarkerColorPolSourceSite { get; set; } = string.Empty;
    public string MapMarkerColorProvince { get; set; } = string.Empty;
    public string MapMarkerColorSector { get; set; } = string.Empty;
    public string MapMarkerColorSeeOtherMunicipality { get; set; } = string.Empty;
    public string MapMarkerColorSubsector { get; set; } = string.Empty;
    public string MapMarkerColorTideSite { get; set; } = string.Empty;
    public string MapMarkerColorWasteWaterTreatmentPlant { get; set; } = string.Empty;
    public string MapMarkerColorWebTideNode { get; set; } = string.Empty;
    public string ClassificationColorApproved { get; set; } = string.Empty;
    public string ClassificationColorConditionallyApproved { get; set; } = string.Empty;
    public string ClassificationColorConditionallyRestricted { get; set; } = string.Empty;
    public string ClassificationColorProhibited { get; set; } = string.Empty;
    public string ClassificationColorRestricted { get; set; } = string.Empty;
    public string MapPolylineColorInfrastructureLineOverflowToOutfall { get; set; } = string.Empty;
    public string MapPolylineColorInfrastructureLiftStationToLiftStation { get; set; } = string.Empty;
    public string MapPolylineColorInfrastructureLiftStationToOutfall { get; set; } = string.Empty;
    public string MapPolylineColorInfrastructureLiftStationToWWTP { get; set; } = string.Empty;
    public string MapPolylineColorInfrastructureWWTPToOutfall { get; set; } = string.Empty;
    public string MapPolygonColorArea { get; set; } = string.Empty;
    public string MapPolygonColorCountry { get; set; } = string.Empty;
    public string MapPolygonColorProvince { get; set; } = string.Empty;
    public string MapPolygonColorSector { get; set; } = string.Empty;
    public string MapPolygonColorSubsector { get; set; } = string.Empty;
    public string MapColorNotFound { get; set; } = string.Empty;
    [CSSPEnumType]
    public AscDescEnum AreaSectorsSortOrder { get; set; } = AscDescEnum.Ascending;
    [CSSPEnumType]
    public FilesSortPropEnum AreaFilesSortByProp { get; set; } = FilesSortPropEnum.FileName;
    [CSSPEnumType]
    public AscDescEnum CountryProvincesSortOrder { get; set; } = AscDescEnum.Ascending;
    [CSSPEnumType]
    public FilesSortPropEnum CountryFilesSortByProp { get; set; } = FilesSortPropEnum.FileName;
    [CSSPEnumType]
    public FilesSortPropEnum InfrastructureFilesSortByProp { get; set; } = FilesSortPropEnum.FileName;
    [CSSPEnumType]
    public AscDescEnum MunicipalityContactsSortOrder { get; set; } = AscDescEnum.Ascending;
    [CSSPEnumType]
    public FilesSortPropEnum MunicipalityFilesSortByProp { get; set; } = FilesSortPropEnum.FileName;
    [CSSPEnumType]
    public AscDescEnum MunicipalityInfrastructuresSortOrder { get; set; } = AscDescEnum.Ascending;
    [CSSPEnumType]
    public AscDescEnum MunicipalityMikeScenariosSortOrder { get; set; } = AscDescEnum.Ascending;
    [CSSPEnumType]
    public FilesSortPropEnum MWQMSiteFilesSortByProp { get; set; } = FilesSortPropEnum.FileName;
    [CSSPEnumType]
    public FilesSortPropEnum PolSourceSiteFilesSortByProp { get; set; } = FilesSortPropEnum.FileName;
    [CSSPEnumType]
    public AscDescEnum ProvinceAreasSortOrder { get; set; } = AscDescEnum.Ascending;
    [CSSPEnumType]
    public FilesSortPropEnum ProvinceFilesSortByProp { get; set; } = FilesSortPropEnum.FileName;
    [CSSPEnumType]
    public AscDescEnum ProvinceMunicipalitiesSortOrder { get; set; } = AscDescEnum.Ascending;
    [CSSPEnumType]
    public AscDescEnum RootCountriesSortOrder { get; set; } = AscDescEnum.Ascending;
    [CSSPEnumType]
    public FilesSortPropEnum RootFilesSortByProp { get; set; } = FilesSortPropEnum.FileName;
    [CSSPEnumType]
    public FilesSortPropEnum SectorFilesSortByProp { get; set; } = FilesSortPropEnum.FileName;
    [CSSPEnumType]
    public AscDescEnum SectorSubsectorsSortOrder { get; set; } = AscDescEnum.Ascending;
    [CSSPEnumType]
    public FilesSortPropEnum SubsectorFilesSortByProp { get; set; } = FilesSortPropEnum.FileName;
    [CSSPEnumType]
    public AscDescEnum SubsectorMWQMRunsSortOrder { get; set; } = AscDescEnum.Ascending;
    [CSSPEnumType]
    public AscDescEnum SubsectorMWQMSitesSortOrder { get; set; } = AscDescEnum.Ascending;
    [CSSPEnumType]
    public AscDescEnum SubsectorPolSourceSitesSortOrder { get; set; } = AscDescEnum.Ascending;

    public UserPreferenceModel()
    {

    }
}

