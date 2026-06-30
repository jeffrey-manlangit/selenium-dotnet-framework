using OpenQA.Selenium;
using SeleniumDotNetFramework.Drivers;

namespace SeleniumDotNetFramework.Tests;

public class BaseTest
{
    protected IWebDriver Driver;

    [SetUp]
    public void Setup()
    {
        Driver = DriverFactory.CreateDriver();
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}