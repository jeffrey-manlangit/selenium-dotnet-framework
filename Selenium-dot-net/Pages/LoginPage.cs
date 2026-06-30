using OpenQA.Selenium;
using SeleniumDotNetFramework.Utilities;

namespace SeleniumDotNetFramework.Pages;

public class LoginPage : BasePage
{
    // Constructor
    public LoginPage(IWebDriver driver)
        : base(driver)
    {
    }

    // Locators
    private readonly By UsernameTextbox = By.Id("user-name");
    private readonly By PasswordTextbox = By.Id("password");
    private readonly By LoginButton = By.Id("login-button");

    // Methods
    public void Open()
    {
        Driver.Navigate().GoToUrl(ConfigurationHelper.BaseUrl);
    }

    public void EnterUsername(string username)
    {
        Driver.FindElement(UsernameTextbox).SendKeys(username);
    }

    public void EnterPassword(string password)
    {
        Driver.FindElement(PasswordTextbox).SendKeys(password);
    }

    public void ClickLogin()
    {
        Driver.FindElement(LoginButton).Click();
    }

    public void Login(string username, string password)
    {
        EnterUsername(username);
        EnterPassword(password);
        ClickLogin();
    }
}