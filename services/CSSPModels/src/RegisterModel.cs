namespace CSSPModels;

[NotMapped]
public partial class RegisterModel
{
    [CSSPMaxLength(100)]
    [CSSPMinLength(1)]
    public string FirstName { get; set; } = string.Empty;
    [CSSPMaxLength(100)]
    [CSSPAllowNull]
    public string Initial { get; set; } = string.Empty;
    [CSSPMaxLength(100)]
    [CSSPMinLength(1)]
    public string LastName { get; set; } = string.Empty;
    [CSSPMaxLength(100)]
    [CSSPMinLength(5)]
    public string LoginEmail { get; set; } = string.Empty;
    [CSSPMaxLength(50)]
    [CSSPMinLength(5)]
    public string Password { get; set; } = string.Empty;
    [CSSPMaxLength(50)]
    [CSSPMinLength(5)]
    public string ConfirmPassword { get; set; } = string.Empty;
    [CSSPAllowNull]
    [CSSPEnumType]
    public ContactTitleEnum? ContactTitle { get; set; } = ContactTitleEnum.Technician;

    public RegisterModel()
    {

    }
}

