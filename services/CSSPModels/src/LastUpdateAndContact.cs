namespace CSSPModels;

[NotMapped]
public partial class LastUpdateAndContact
{
    [CSSPAfter(Year = 1980)]
    public DateTime LastUpdateAndContactDate_UTC { get; set; } = DateTime.MinValue;
    [CSSPRange(1, -1)]
    public int LastUpdateAndContactTVItemID { get; set; }

    public LastUpdateAndContact()
    {

    }
}

