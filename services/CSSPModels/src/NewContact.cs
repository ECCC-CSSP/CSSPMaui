namespace CSSPModels;

[NotMapped]
public partial class NewContact
{
    [CSSPMaxLength(200)]
    [CSSPMinLength(1)]
    public string LoginEmail { get; set; } = string.Empty;
    [CSSPMaxLength(200)]
    [CSSPMinLength(1)]
    public string FirstName { get; set; } = string.Empty;
    [CSSPMaxLength(200)]
    [CSSPMinLength(1)]
    public string LastName { get; set; } = string.Empty;
    [CSSPMaxLength(50)]
    [CSSPAllowNull]
    public string Initial { get; set; } = string.Empty;
    [CSSPEnumType]
    [CSSPAllowNull]
    public ContactTitleEnum? ContactTitle { get; set; } = ContactTitleEnum.Technician;
    [CSSPMaxLength(100)]
    [CSSPEnumTypeText(EnumTypeName = "ContactTitleEnum", EnumType = "ContactTitle")]
    [CSSPAllowNull]
    public string ContactTitleText { get; set; } = string.Empty;

    public NewContact()
    {

    }
}

