using OpenQA.Selenium;

namespace SeleniumDotNetFramework.Pages;

public abstract class BasePage
{
    protected readonly IWebDriver Driver;

    protected BasePage(IWebDriver driver)
    {
        Driver = driver;
    }

    protected void Click(By locator)
    {
        Driver.FindElement(locator).Click();
    }
    protected void Type(By locator, string text)
    {
        Driver.FindElement(locator).Clear();
        Driver.FindElement(locator).SendKeys(text);
    }

    protected string GetText(By locator) 
    { 
        return Driver.FindElement(locator).Text;
    }

    protected bool IsDisplayed(By locator)
    {
        return Driver.FindElement(locator).Displayed;
    }

     protected string GetPageTitle()
    {
        return Driver.Title;
    }
    protected string GetCurrentUrl()
    {
        return Driver.Url;
    }

    protected void RefreshPage()
    {
        Driver.Navigate().Refresh();
    }

    protected void GoBack()
    {
        Driver.Navigate().Back();
    }

    protected void ScrollToElement(By locator)
    {
        var element = Driver.FindElement(locator);
        ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
    }
    
    protected void PressEnterKey(By locator)
    {
        Driver.FindElement(locator).SendKeys(Keys.Enter);
    }
}