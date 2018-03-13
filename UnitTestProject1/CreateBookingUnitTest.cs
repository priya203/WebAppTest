using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using UnitTestProjectsummary.PageElements;
using UnitTestProjectsummary.WebAppCreateBookingPage;
using System;
using System.Threading;


namespace UnitTestProjectsummary
{
     
    public class CreateBookingUnitTest
    {
        public CreateBookingUnitTest()
        { 
        }

        public IWebDriver Driver;

        public WebDriverWait Wait;
        private IWebDriver webDriver;

        public CreateBookingUnitTest(IWebDriver webDriver)
        {
            // TODO: Complete member initialization
            this.webDriver = webDriver;
        }

      [TestInitialize]
        public void SetupTest()
        {
            this.Driver = new ChromeDriver();
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(60));
            Driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            this.Driver.Quit();
        }
        [TestMethod]
        public void NavigateToCreateBookingPage()
        {

            //SearchEngineTests test = new SearchEngineTests();
            //test.LoginMainPageSuccess();
            //CreateBookingMainPage cc = new CreateBookingMainPage();
            //cc.CreateBookingNavigation();
            LoginMainPage ll = new LoginMainPage(this.Driver);
            ll.Navigate();
            ll.Login();
            CreateBookingMainPage cc = new CreateBookingMainPage(this.Driver);
            cc.CreateBookingNavigation();
        }

        [TestMethod]
        public void Selecting_The_Resource()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(4000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(7000);
           
        }


        [TestMethod]
        public void VerifyFor_SummaryPageRecord()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(3000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(2000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(7000);

        }
        [TestMethod]
        public void Testdummy()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(3000);
           
            //CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            //CreateBooking.CreateBookingNavigation();
            //Thread.Sleep(3000);
            //var drop = Driver.FindElement(By.Id("ctl00_MainContentPlaceHolder_ddlHours"));
            //drop.Click();
            //Thread.Sleep(3000);
            //var SelectElement = new SelectElement(drop);
            //Thread.Sleep(3000);
            //SelectElement.SelectByIndex(4);
            //Thread.Sleep(6000);
            //drop.Click();
            //Thread.Sleep(2000);
        }


      //  public IWebDriver webDriver { get; set; }
    }
}
