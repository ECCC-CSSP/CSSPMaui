﻿namespace CSSPModels;

[NotMapped]
public partial class MonitoringStatBySeason
{
    [CSSPEnumType]
    public SeasonEnum Season { get; set; } = SeasonEnum.Winter;
    public int MWQMSiteCount { get; set; }
    public int MWQMRunCount { get; set; }
    public int MWQMSampleCount { get; set; }

    public MonitoringStatBySeason()
    {

    }
}


