using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using UnitTestProjectsummary.PageElements;
using UnitTestProjectsummary.BookingSearchAndUpdateBooking;
using System.Threading;

namespace UnitTestProjectsummary
{
    [TestClass]
    public class BookingSearcAndUpdatesUniTest
    {
        
        public IWebDriver Driver;
        public WebDriverWait Wait;

        public BookingSearcAndUpdatesUniTest(IWebDriver webDriver)
        {
           
            this.webDriver = webDriver;
        }
        public BookingSearcAndUpdatesUniTest()
        { 
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
           // this.Driver.Quit();
        }

        [TestMethod]
        public void BookingSearchPageNavigation()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            booksearch.NavigateBookingSearch();
            Thread.Sleep(2000);
                

        }
        [TestMethod]
        public void BookingSearch()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            booksearch.NavigateBookingSearch();
            Thread.Sleep(2000);
            booksearch.EnterSearcCriteria();
            booksearch.selectBookingTypedrop();
            booksearch.selectpropertyDroperdown();
            booksearch.SelectStatusDroperdown();
            booksearch.CLickOnBookingSearchandSelectTheRecord();
         }

        [TestMethod]
        public void UpdateBooking_withResource_addon()
        {
            BookingSearch();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            booksearch.ClickOnBookAnatherResourceForUpdateBooking();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            Thread.Sleep(3000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(8000);
            CreateBooking.GotoSummaryPage();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(3000);
            bookingsummary.clickOnAddAddon();
            Thread.Sleep(3000);
            booksearch.ClickonSaveEditedrecord();
        }
        [TestMethod]
        public void UpdateBooking_HostAndRequester()
        {
            BookingSearch();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
          //  booksearch.ClickOnBookAnatherResourceForUpdateBooking();
            //CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            //Thread.Sleep(3000);
            //CreateBooking.searchButtonclick();
            //Thread.Sleep(5000);
            //CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            //CreateBooking.selectingtheresource();
           //Thread.Sleep(8000);
            //CreateBooking.GotoSummaryPage();
            //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(3000);
            booksearch.UpdateHost();
            booksearch.UpdateRequester();
            booksearch.ClickonSaveEditedrecord();
}
        [TestMethod]
        public void UpdateBooking_BookingType_SpecialRequests_Notes_Title()
        {
            BookingSearch();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            //booksearch.ClickOnBookAnatherResourceForUpdateBooking();
            //CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            //Thread.Sleep(3000);
            //CreateBooking.searchButtonclick();
            //Thread.Sleep(5000);
            //CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            //CreateBooking.selectingtheresource();
            //Thread.Sleep(8000);
            //CreateBooking.GotoSummaryPage();
            //BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(3000);
           // booksearch.UpdateRequester();
            booksearch.UpdateParticipants_BookingType();
            booksearch.Update_Notes();
            booksearch.UpdateSpecialRequest_bookingStatus();
            booksearch.EnterNewTitle();
            booksearch.ClickonSaveEditedrecord();
        
        }


        [TestMethod]
        public void UpdateBooking_AllParams()
        {
           BookingSearch();
           BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
           booksearch.ClickOnBookAnatherResourceForUpdateBooking();
           CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
           Thread.Sleep(3000);
           CreateBooking.searchButtonclick();
           Thread.Sleep(5000);
           CreateBooking.CreateBookingValidate().TestResourceCheckbox();
           CreateBooking.selectingtheresource();
           Thread.Sleep(8000);
           CreateBooking.GotoSummaryPage();
           BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
           Thread.Sleep(3000);
           bookingsummary.clickOnAddAddon();
           Thread.Sleep(3000);
           booksearch.UpdateHost();
           booksearch.UpdateRequester();
           booksearch.UpdateParticipants_BookingType();
           booksearch.Update_Notes();
           booksearch.UpdateSpecialRequest_bookingStatus();
           booksearch.EnterNewTitle();
           booksearch.ClickonSaveEditedrecord();
 }


       
public  IWebDriver webDriver { get; set; }}
     


        //public IWebDriver webDriver { get; set; }
    }

