namespace CSSPAppGenerateCode.Services;

public interface IConfigService
{
    Task<Config> ReadAppSettings();
}

public partial class ConfigService : IConfigService
{
    public ConfigService()
    {
        ReadAppSettings().GetAwaiter().GetResult();
    }

    public async Task<Config> ReadAppSettings()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("AppSettings.json");
        using var reader = new StreamReader(stream);

        var contents = reader.ReadToEnd();

        Config config = JsonSerializer.Deserialize<Config>(contents) ?? new Config();

        return await Task.FromResult(config);
    }
}
