using FluentAssertions;
using SeleniumDotNetFramework.Utilities;

namespace SeleniumDotNetFramework.Tests;

public class LoginTests : BaseTest
{
    [Test]
    public void VerifySauceDemoHomePageTitle()
    {
        //Driver.Navigate().GoToUrl("https://www.saucedemo.com");
        Driver.Navigate().GoToUrl(ConfigurationHelper.BaseUrl);
        Driver.Title.Should().Be("Swag Labs");
    }
}