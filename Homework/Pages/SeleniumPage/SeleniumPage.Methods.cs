using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pages 
{
   public partial class SeleniumPage
    {

        public void Navigate(SeleniumSearchPage selPage)
        {
            selPage.Navigate("https://www.google.com/search?sxsrf=ACYBGNQ-lHCgwnrINs6ZW3AAcUb1bVBydQ%3A1570737560978&source=hp&ei=mI2fXbz0OIPDmwW0073ABA&q=Selenium&oq=Selenium&gs_l=psy-ab.3..35i39l2j0l7j0i203.1818649.1820788..1821157...0.0..0.242.1188.1j6j2......0....1..gws-wiz.....10..35i362i39j0i10i203.H9PBrJngBbk&ved=0ahUKEwi8oOuyvZLlAhWD4aYKHbRpD0gQ4dUDCAY&uact=5");

            selPage.SearchResult1.Click();

        }

    }
}
