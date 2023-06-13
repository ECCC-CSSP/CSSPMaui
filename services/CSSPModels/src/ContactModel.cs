namespace CSSPModels;

[NotMapped]
public partial class ContactModel
{
    public Contact Contact { get; set; } = new Contact();
    public List<int> ContactEmailTVItemIDList { get; set; } = new List<int>();
    public List<int> ContactTelTVItemIDList { get; set; } = new List<int>();
    public List<int> ContactAddressTVItemIDList { get; set; } = new List<int>();

    public ContactModel()
    {

    }
}

