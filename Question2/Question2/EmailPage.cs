using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Question2
{
    /// <summary>
    /// /This is POM for "https://mailpoof.com/"
    /// </summary>
    public class EmailPage
    {
        public EmailPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement EmailID { get; set; }
        [FindsBy(How = How.CssSelector, Using = "body > main > div.container-fluid > div > div.col-xl-3.tm-sidebar > div.tm-create > form:nth-child(1) > input[type = submit]:nth-child(5)")]
        public IWebElement CreateBtn { get; set; }
    }
}
