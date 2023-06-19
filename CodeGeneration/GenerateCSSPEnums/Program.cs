namespace GenerateCSSPEnums;

partial class Program
{
    #region Variables
    #endregion Variables

    #region Entry
    public static async Task Main(string[] args)
    {
        string appSettings = "appsettings.json";

        DirectoryInfo? di = Directory.GetParent(AppContext.BaseDirectory);
        if (di == null)
        {
            Console.WriteLine("Directory.GetParent(AppContext.BaseDirectory) is null");
            return;
        }

        FileInfo fi = new FileInfo($@"{di.FullName}\{appSettings}");
        if (!fi.Exists)
        {
            Console.WriteLine($"{fi.FullName} does not exist");
            return;
        }

        IConfiguration Configuration = new ConfigurationBuilder()
           .SetBasePath(di.FullName)
           .AddJsonFile(appSettings)
           .Build();

        Startup startup = new Startup(Configuration);
        await startup.Generate();

    }
    #endregion Entry

    #region Functions private
    #endregion Functions private


}
