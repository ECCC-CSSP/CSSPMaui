namespace CSSPModels;

[NotMapped]
public partial class VarNameAndValue
{
    [CSSPMaxLength(200)]
    public string VariableName { get; set; } = string.Empty;
    [CSSPMaxLength(300)]
    public string VariableValue { get; set; } = string.Empty;

    public VarNameAndValue()
    {

    }
}

