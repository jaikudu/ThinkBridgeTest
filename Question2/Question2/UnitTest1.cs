using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace Question2
{
    public class Tests
    {
        [OneTimeSetUp]
        public void Setup()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Navigate().GoToUrl("http://jt-dev.azurewebsites.net/#/SignUp");
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);  
        }
        [Test]
        public void ValidateDropdown()
        {
            List<string> ActualVal_DDL = Actions.GetDropDownList();
            //Assert Multiple is used so that all values in drop down list will be verified.
            Assert.Multiple(() =>
                {
                    foreach (var item in Config.ExpectedValues)
                    {
                        Assert.That(ActualVal_DDL.Contains(item));
                    }
                });
        }
        [Test]
        public void ValidateEmail()
        {
            Actions.CreateEmailAccount(Config.EmailDetails.email);
            Actions.FillLoginForm(Config.LoginDetails.fullName, Config.LoginDetails.orgName, Config.LoginDetails.Email);
            LoginPage lPage = new LoginPage();
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromMilliseconds(10000));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#content > div > div.main-body > div > section > div.form-container > form > div > span")));

            Assert.Multiple(() =>
            {
                Assert.True(lPage.WelcomeEmailMsg.Displayed);
                Assert.AreEqual(Config.WelcomeMsg, lPage.WelcomeEmailMsg.Text);
            });

            Actions.LogIntoEmailAccount(Config.EmailDetails.email);
            IList<IWebElement> allMessages = Actions.GetAllMessages();
            if (allMessages.Count!= 0)
            {
                Assert.Pass("Email Received");
            }
            else
            {
                Assert.Fail("Email Not Received");
            }
        }
        [OneTimeTearDown]
        public void CleanUP()
        {
            Driver.driver.Quit();
        }
    }
}