using Microsoft.Extensions.Configuration;

namespace SeleniumDotNetFramework.Utilities;

public static class ConfigurationHelper
{
    private static readonly IConfigurationRoot Configuration;

    static ConfigurationHelper()
    {
        Configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
    }

    public static string BaseUrl =>
        Configuration["Application:BaseUrl"]!;

    public static string Browser =>
        Configuration["Browser:Name"]!;

    public static bool Headless =>
        bool.Parse(Configuration["Browser:Headless"]!);

    public static int ImplicitWait =>
        int.Parse(Configuration["Timeouts:ImplicitWait"]!);

    public static int ExplicitWait =>
        int.Parse(Configuration["Timeouts:ExplicitWait"]!);
}