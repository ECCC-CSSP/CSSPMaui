namespace CSSPDBModels;

public partial class ResetPassword : LastUpdate
{
    [Key]
    public int ResetPasswordID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; }
    [CSSPMaxLength(256)]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = string.Empty;
    [CSSPAfter(Year = 1980)]
    public DateTime ExpireDate_Local { get; set; }
    [CSSPMaxLength(8)]
    public string Code { get; set; } = string.Empty;

    public ResetPassword() : base()
    {
    }
}

