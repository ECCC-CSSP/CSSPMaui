namespace CSSPModels;

[NotMapped]
public partial class MonitoringStatsModel
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<MonitoringStatByYear> MonitoringStatByYearList { get; set; } = new List<MonitoringStatByYear>();
    public List<MonitoringStatByMonth> MonitoringStatByMonthList { get; set; } = new List<MonitoringStatByMonth>();
    public List<MonitoringStatBySeason> MonitoringStatBySeasonList { get; set; } = new List<MonitoringStatBySeason>();

    public MonitoringStatsModel()
    {

    }
}

