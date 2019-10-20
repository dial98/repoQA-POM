using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;



namespace Homework.Pages 
{
    public class GoogleSearchPage : BasePage
    {

        public GoogleSearchPage(IWebDriver driver)
            : base(driver)
        {
        }

        public new string Url => "http://www.google.com";


        public IWebElement googleSearchBar => Driver.FindElement(By.Name("q"));

        public IWebElement googleSearchBtn => Driver.FindElement(By.Name("btnK"));
    }
}
