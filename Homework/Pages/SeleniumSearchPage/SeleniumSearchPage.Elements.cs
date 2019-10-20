using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pages
{
    public partial class SeleniumSearchPage :BasePage
    {

        public SeleniumSearchPage(IWebDriver driver)
           : base(driver)
        {
        }

        public new string Url => "https://www.google.com/search?sxsrf=ACYBGNQ-lHCgwnrINs6ZW3AAcUb1bVBydQ%3A1570737560978&source=hp&ei=mI2fXbz0OIPDmwW0073ABA&q=Selenium&oq=Selenium&gs_l=psy-ab.3..35i39l2j0l7j0i203.1818649.1820788..1821157...0.0..0.242.1188.1j6j2......0....1..gws-wiz.....10..35i362i39j0i10i203.H9PBrJngBbk&ved=0ahUKEwi8oOuyvZLlAhWD4aYKHbRpD0gQ4dUDCAY&uact=5";

        //        public new IWebElement SearchResult1 => Driver.FindElement(By.XPath(@"//*[@id=""rso""]/div[1]/div/div/div[2]/div[1]/a/h3"));

        public new IWebElement SearchResult1 => Driver.FindElement(By.XPath(@"//*[@id=""rso""]/div[1]/div/div/div/div[1]/a[1]"));

        //   //*[@id="rso"]/div[1]/div/div

    }
}
