namespace CSSPModels;

[NotMapped]
public partial class LoginModel
{
    [CSSPMaxLength(100)]
    [CSSPMinLength(5)]
    public string LoginEmail { get; set; } = string.Empty;
    [CSSPMaxLength(50)]
    [CSSPMinLength(5)]
    public string Password { get; set; } = string.Empty;

    public LoginModel()
    {

    }
}

