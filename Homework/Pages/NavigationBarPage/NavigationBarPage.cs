using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Homework.Pages //.NavigationBarPage
{
   public class NavigationBarPage : BasePage
    {
        public NavigationBarPage(IWebDriver driver)
           : base(driver)
        {            
        }
         public new string Url => "http://softuni.bg/";
         public IWebElement Courses => Driver.FindElement(By.XPath(@"//*[@id=""header-nav""]/div[1]/ul/li[2]/a"));

        public IWebElement QACourse => Driver.FindElement(By.XPath(@"//*[@id=""header-nav""]/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/ul[2]/div[1]/ul/li/a"));


    }
}
