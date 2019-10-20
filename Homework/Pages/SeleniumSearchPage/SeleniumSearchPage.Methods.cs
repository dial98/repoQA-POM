using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pages //.SeleniumSearchPage
{
   public partial class SeleniumSearchPage
    {
        public void Navigate(GoogleSearchPage googleSearchpage)
        {

            googleSearchpage.Navigate("http://www.google.com");
            googleSearchpage.googleSearchBar.SendKeys("Selenium");
            googleSearchpage.googleSearchBtn.Click();


        }

    }
}
