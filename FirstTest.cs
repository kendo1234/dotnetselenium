using NUnit;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Firefox;



[TestFixture]

public class TestProgram


{
    private IWebDriver driver;

    [SetUp]

    public void SetupTest()
    {

        FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"/home/kendo/Downloads/geckodriver-v0.24.0-linux64/", "geckodriver");

        service.Port = 64444;

        driver = new FirefoxDriver(service);
        driver.Url ="https://code.visualstudio.com/";
    }

    [TearDown]

public void TeardownTest()

{

driver.Quit();

}

[Test]

public void testMethod()

{

String title = driver.Title;

System.Console.WriteLine("title of site is : " +title);

IWebElement button = driver.FindElement(By.CssSelector(".flex-box > button:nth-child(1)"));

Assert.AreEqual(".deb\nDebian, Ubuntu..." , button.Text);

}

}
