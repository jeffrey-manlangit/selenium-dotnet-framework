using FluentAssertions;
using SeleniumDotNetFramework.Pages;

namespace SeleniumDotNetFramework.Tests;

public class LoginTests : BaseTest
{
    [Test]
    public void VerifySauceDemoHomePageTitle()
    {
        var loginPage = new LoginPage(Driver);

        loginPage.Open();
        loginPage.Login("standard_user", "secret_sauce");

        Driver.Url.Should().Be("https://www.saucedemo.com/inventory.html");
    }
}