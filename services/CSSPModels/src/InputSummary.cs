﻿namespace CSSPModels;

[NotMapped]
public partial class InputSummary
{
    [CSSPMaxLength(1000000)]
    public string Summary { get; set; } = string.Empty;

    public InputSummary()
    {

    }
}

