
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question2
{
    public static class Actions
    {
        public static List<string> GetDropDownList()
        {
            LoginPage lPage = new LoginPage();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            lPage.languageDDL.Click();
            
            List<string> ActualVal = new List<string>(){
               lPage.English.Text,
               lPage.Dutch.Text,
           };
            return ActualVal;
        }

        public static void FillLoginForm(string fullname, string orgName, string email)
        {
            LoginPage lPage = new LoginPage();
            lPage.fullName.Clear();
            lPage.OrgName.Clear();
            lPage.Email.Clear();
            lPage.fullName.SendKeys(fullname);
            lPage.OrgName.SendKeys(orgName);
            lPage.Email.SendKeys(email);
            lPage.IAgree.Click();
            lPage.GetStarted.Click();
        }
        public static void CreateEmailAccount(string email)
        {
            EmailPage ePage = new EmailPage();
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("window.open();"); //For opening new tab in browser.
            Driver.driver.SwitchTo().Window(Driver.driver.WindowHandles.Last());
            Driver.driver.Navigate().GoToUrl("https://mailpoof.com/");
            ePage.EmailID.SendKeys(email);
            ePage.CreateBtn.Click();
            Driver.driver.SwitchTo().Window(Driver.driver.WindowHandles.First());
        }
        public static void LogIntoEmailAccount(string email)
        {
            EmailPage ePage = new EmailPage();
            Driver.driver.SwitchTo().Window(Driver.driver.WindowHandles.Last());
            Driver.driver.Navigate().Refresh();
        }
        public static IList<IWebElement> GetAllMessages()
        {
            IList<IWebElement> allMessages = Driver.driver.FindElements(By.XPath("//*[contains(text(), 'Please Complete JabaTalks Account')]"));
            return allMessages;
        }


    }
}
