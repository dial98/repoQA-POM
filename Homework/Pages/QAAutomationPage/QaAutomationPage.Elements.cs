using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pages //.QAAutomationPage
{
    public partial class QaAutomationPage : BasePage
    {

        public QaAutomationPage(IWebDriver driver)
           : base(driver)
        {
        }

        public new string Url => "https://softuni.bg/trainings/2308/qa-automation-september-2019";

        public new IWebElement header1 => Driver.FindElement(By.XPath("/html/body/div[2]/header/h1"));


    }
}
