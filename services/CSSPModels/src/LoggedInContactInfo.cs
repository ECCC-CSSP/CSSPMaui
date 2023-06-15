namespace CSSPModels;

[NotMapped]
public partial class LoggedInContactInfo
{
    public Contact? LoggedInContact { get; set; } = new Contact();
    public List<TVTypeUserAuthorization> TVTypeUserAuthorizationList { get; set; } = new List<TVTypeUserAuthorization>();
    public List<TVItemUserAuthorization> TVItemUserAuthorizationList { get; set; } = new List<TVItemUserAuthorization>();

    public LoggedInContactInfo()
    {

    }
}

