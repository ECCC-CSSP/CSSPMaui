﻿namespace CSSPModels;

[NotMapped]
public partial class PolSourceInactiveReasonEnumTextAndID
{
    [CSSPMaxLength(1000)]
    public string Text { get; set; } = string.Empty;
    [CSSPRange(1, -1)]
    public int ID { get; set; }

    public PolSourceInactiveReasonEnumTextAndID()
    {

    }
}

