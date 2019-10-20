using Homework.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Homework
{
    [TestFixture]
    public class POMTests
    {
        private LoginPage _loginPage;
        private RegistrationPage _regPage;
        private RegistrationUser _user;
        

        private NavigationBarPage _navPage;
        private QaAutomationPage _qaPage;

        private GoogleSearchPage _gsPage;
        private SeleniumSearchPage _seleniumsearchPage;
        private SeleniumPage _selPage;

        [SetUp]
        public void CalssInit()
        {
            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();


            _loginPage = new LoginPage(driver);
            _regPage = new RegistrationPage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            _user = UserFactory.CreateValidUser();

            _navPage = new NavigationBarPage(driver);
            _qaPage = new QaAutomationPage(driver);

            _gsPage = new GoogleSearchPage(driver);
            _seleniumsearchPage = new SeleniumSearchPage(driver);
            _selPage = new SeleniumPage(driver);


        }

        [Test]
        public void FillRegistrationFormWithoutPhoneNumber()
        {
            _user.Phone = "";
            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);
                      

            Assert.AreEqual("You must register at least one phone number.",_regPage.ErrorMessage.Text);
        }

        [Test]
        public void FillRegistrationFormWithoutFirstName()
        {
            _user.FirstName = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            
            Assert.AreEqual("firstname is required.", _regPage.ErrorMessage.Text);
        }
        [Test]
        public void FillRegistrationFormWithoutFNameAndPhone()
        {
            _user.FirstName = "";
            _user.Phone = "";
            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

           
            Assert.AreEqual("You must register at least one phone number.", _regPage.ErrorMessage.Text);
            Assert.AreEqual("firstname is required.", _regPage.SecondErrorMessage.Text);
        }

        [Test]
        public void FillRegistrationFormWithoutLNameAndPass()
        {
            _user.LastName = "";
            _user.Password = "";
            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            
            Assert.AreEqual("lastname is required.", _regPage.ErrorMessage.Text);
            Assert.AreEqual("passwd is required.", _regPage.SecondErrorMessage.Text);
        }

        [Test]
        public void FillRegistrationFormWithoutAddressAndCity()
        {
            _user.Address = "";
            _user.City = "";
            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            
            Assert.AreEqual("address1 is required.", _regPage.ErrorMessage.Text);
            Assert.AreEqual("city is required.", _regPage.SecondErrorMessage.Text);
        }
        [Test]
        public void FillRegistrationFormWithoutPCodeAndCountry()
        {
            _user.PostCode ="";
            _user.State = "-";
            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            
            Assert.AreEqual("The Zip/Postal code you've entered is invalid. It must follow this format: 00000", _regPage.ErrorMessage.Text);
            Assert.AreEqual("This country requires you to choose a State.", _regPage.SecondErrorMessage.Text);
        }

        [Test]
        public void GStest()
        {
           

          _seleniumsearchPage.Navigate(_gsPage);
            _selPage.Navigate(_seleniumsearchPage);
            Assert.AreEqual("https://www.seleniumhq.org/", _selPage.Url);


        }
        [Test]
        public void GStestTwo()
        {
            _seleniumsearchPage.Navigate(_gsPage);
            _selPage.Navigate(_seleniumsearchPage);
            Assert.AreEqual("Selenium - Web Browser Automation", _selPage.title.GetAttribute("innerHTML"));

        }

        [Test]
        public void QaCourseSearch(){            

           _qaPage.Navigate(_navPage);

            Assert.AreEqual("QA Automation - септември 2019", _qaPage.header1.Text);

        }


    }
}
