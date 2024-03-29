﻿namespace ManageServices;

public partial class CommandLog
{
    [Key]
    public int CommandLogID { get; set; }
    [CSSPMaxLength(200)]
    public string AppName { get; set; } = string.Empty;
    [CSSPMaxLength(200)]
    public string CommandName { get; set; } = string.Empty;
    [CSSPMaxLength(10000000)]
    public string Error { get; set; } = string.Empty;
    [CSSPMaxLength(10000000)]
    public string Log { get; set; } = string.Empty;
    [CSSPAfter(Year = 1980)]
    public DateTime DateTimeUTC { get; set; } = DateTime.MinValue;

    public CommandLog()
    {

    }
}

