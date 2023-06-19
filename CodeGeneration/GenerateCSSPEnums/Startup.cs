namespace GenerateCSSPEnums;

public partial class Startup
{
    private IConfiguration Configuration { get; set; }

    public Startup(IConfiguration Configuration)
    {
        this.Configuration = Configuration;
    }
}
