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

    private void EnterUsername(string username)
    {
        //Driver.FindElement(UsernameTextbox).SendKeys(username);
        Type(UsernameTextbox, username);
    }

    private void EnterPassword(string password)
    {
        // Driver.FindElement(PasswordTextbox).SendKeys(password);
        Type(PasswordTextbox, password);
    }

    private void ClickLogin()
    {
        Click(LoginButton);
    }

    public void Login(string username, string password)
    {
        EnterUsername(username);
        EnterPassword(password);
        ClickLogin();
    }
}