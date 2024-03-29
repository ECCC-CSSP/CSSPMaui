﻿namespace CSSPModels;

[NotMapped]
public partial class URLNumberOfSamples
{
    [CSSPMaxLength(255)]
    [CSSPMinLength(1)]
    public string url { get; set; } = string.Empty;
    [CSSPRange(1, -1)]
    public int NumberOfSamples { get; set; }

    public URLNumberOfSamples()
    {

    }
}

