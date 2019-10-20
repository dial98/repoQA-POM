using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pages //.QAAutomationPage
{
   public partial class QaAutomationPage
    {
        public void Navigate(NavigationBarPage navBarPage )
        {
            navBarPage.Navigate("https://softuni.bg");

            navBarPage.Courses.Click();
            navBarPage.QACourse.Click();
            
            
        }


    }
}
