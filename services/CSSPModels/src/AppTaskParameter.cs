namespace CSSPModels;

[NotMapped]
public partial class AppTaskParameter
{
    [CSSPMaxLength(255)]
    public string Name { get; set; } = string.Empty;
    [CSSPMaxLength(255)]
    public string Value { get; set; } = string.Empty;

    public AppTaskParameter() : base()
    {
    }
}

