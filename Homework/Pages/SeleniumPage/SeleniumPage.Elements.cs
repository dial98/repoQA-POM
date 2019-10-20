using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pages //.SeleniumPage
{
    public partial class SeleniumPage :BasePage
    {
        public SeleniumPage(IWebDriver driver)
          : base(driver)
        {
        }

        public new string Url => "https://www.seleniumhq.org/";

        public new IWebElement title => Driver.FindElement(By.XPath(@"/html/head/title"));


    }
}
