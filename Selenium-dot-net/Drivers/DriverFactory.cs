using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumDotNetFramework.Utilities;

namespace SeleniumDotNetFramework.Drivers;

public static class DriverFactory
{
    public static IWebDriver CreateDriver()
    {
        ChromeOptions options = new ChromeOptions();

        options.AddArgument("--start-maximized");

        IWebDriver driver = new ChromeDriver(options);

        driver.Manage().Timeouts().ImplicitWait =
        TimeSpan.FromSeconds(ConfigurationHelper.ImplicitWait);

        return driver;
    }
}