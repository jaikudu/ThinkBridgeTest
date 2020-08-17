using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Question2
{
    /// <summary>
    /// /This is POM for "http://jt-dev.azurewebsites.net/#/SignUp"
    /// </summary>
    public class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#language > div.ui-select-match.ng-scope > span > span.ui-select-match-text.pull-left")]
        public IWebElement languageDDL { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#ui-select-choices-row-1-0 > a > div")]
        public IWebElement English { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#ui-select-choices-row-1-1 > a > div")]
        public IWebElement Dutch { get; set; }
        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement fullName { get; set; }
        [FindsBy(How = How.Id, Using = "orgName")]
        public IWebElement OrgName { get; set; }
        [FindsBy(How = How.Id, Using = "singUpEmail")]
        public IWebElement Email { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#content > div > div.main-body > div > section > div.form-container > form > fieldset > div:nth-child(4) > label > span")]
        public IWebElement IAgree { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#content > div > div.main-body > div > section > div.form-container > form > fieldset > div:nth-child(5) > button")]
        public IWebElement GetStarted { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#content > div > div.main-body > div > section > div.form-container > form > div > span")]
        public IWebElement WelcomeEmailMsg { get; set; }
    }
}
