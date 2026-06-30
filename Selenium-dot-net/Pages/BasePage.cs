using OpenQA.Selenium;

namespace SeleniumDotNetFramework.Pages;

public abstract class BasePage
{
    protected readonly IWebDriver Driver;

    protected BasePage(IWebDriver driver)
    {
        Driver = driver;
    }
}