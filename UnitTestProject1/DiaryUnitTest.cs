using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using UnitTestProjectsummary;
using UnitTestProjectsummary.PageElements;
using System.Threading;
//using Seleniumtest.WebAppLogin;
using UnitTestProjectsummary.WebAppDiary;
using UnitTestProjectsummary.BookingSearchAndUpdateBooking;

namespace UnitTestProjectsummary
{
    [TestClass]
    public class DiaryUnitTest
   // public class DiaryUnitTest:LoginMainPage
    {
        public DiaryUnitTest()
        { 
        }

        public IWebDriver Driver;
        public WebDriverWait Wait;
        private IWebDriver webDriver;

        public DiaryUnitTest(IWebDriver webDriver)
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
           //this.Driver.Quit();
        }


          [TestMethod]
         public void SelectDiaryCell()
        {
           LoginMainPage gg=new LoginMainPage(this.Driver);
             gg.Navigate();
             Thread.Sleep(3000);
             gg.Login();
             Thread.Sleep(3000);
             DiaryMainPage diary=new DiaryMainPage(this.Driver);
             diary.selectDiaryCellandContinuwithBooking();
             Thread.Sleep(4000);
          }


          [TestMethod]
          public void FFT47_pre_CreateRecurringBooking10AMto11AM()
          {
              LoginMainPage gg = new LoginMainPage(this.Driver);
              gg.Navigate();
              gg.Login();
              Thread.Sleep(2000);
              DiaryMainPage diary = new DiaryMainPage(this.Driver);
              diary.FFT47_selectDiaryCellForRecurBooking();
              Thread.Sleep(1000);
              diary.SelectRecurBooking_Checkbox();
              Thread.Sleep(2000);
              diary.FFTTest46_EnterFromandToDateSlot_10111();
              diary.SelectDailyRecurringBooking();
              diary.SelectDailyRecurBookingDates();
              diary.ShowTargetDate_ContinueBooking_recur();
              diary.FFTTest46_clickOncontinuewithbookingTime_1011();
              Thread.Sleep(4000);
              diary.EnterTitleForRecurringBooking();
              Thread.Sleep(2000);
              BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
              bookingsummary.clickonsaveAndExit();
              Thread.Sleep(10000);
              bookingsummary.clickonGoToDIary();
          }


          [TestMethod]
          public void FFT47_Main() //UpdateRecurringBooking And Verify for updated records
          {
              LoginMainPage gg = new LoginMainPage(this.Driver);
              gg.Navigate();
              gg.Login();
              Thread.Sleep(2000);
              DiaryMainPage diary = new DiaryMainPage(this.Driver);
              BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
              Thread.Sleep(1000);
              diary.FFT47_selectDiaryCellForRecurBooking();
              Thread.Sleep(1000);
              diary.FFT47_SwitchtorecurringBookingPanel();
              Thread.Sleep(1000);
              diary.FFT47_SelectEntireSeries();
              Thread.Sleep(3000);
              BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
              booksearch.UpdateSpecialRequest_bookingStatus();
              Thread.Sleep(2000);
              diary.FFT_47_RecurBookingupdatedTitle();
              Thread.Sleep(2000);
              bookingsummary.clickonsaveAndExit();
              Thread.Sleep(5000);
              bookingsummary.clickonGoToDIary();
              Thread.Sleep(3000);
              diary.FFT47_SwitchtoDateTableOnDiary();
              diary.FFT_47_SelectNextDate();
              Thread.Sleep(3000);
              diary.FFT47_selectDiaryCellForRecurBooking();
              Thread.Sleep(5000);
              diary.FFT47_SwitchtorecurringBookingPanel();
              Thread.Sleep(5000);
              diary.FFT47_SelectEntireSeries();
              Thread.Sleep(6000);
              diary.FFT_47_ValidateUpdatedBookingTitle();
              Thread.Sleep(2000);
          }
    [TestMethod]
    public void FFT203_SetUPBreakdownOverlap()
    {
        //createFirstBookingWithsetUPbreakdownTime12To1
        LoginMainPage gg = new LoginMainPage(this.Driver);
        gg.Navigate();
        Thread.Sleep(3000);
        gg.Login();
        Thread.Sleep(2000);
        DiaryMainPage diary = new DiaryMainPage(this.Driver);
        diary.FFTTest203_SelectAndContinueWithBookingFirst12to1PM();
        diary.EnterFromandToDateSlot_12to1PM();
        diary.FFTTest46_clickOncontinuewithbookingTime_1011();   //JustClickingOnContinuewithBooking
        BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
        Thread.Sleep(3000);
        bookingsummary.ENterSetUPtime();
        bookingsummary.ENterBreakdowntime();
        bookingsummary.EnterTitle();
        bookingsummary.clickonsave();
        Thread.Sleep(2000);
        bookingsummary.clickonGoToDIary();
        Thread.Sleep(3000);

        //CreateBooking with setUp Breakdown Time 2to3
        diary.FFTTest203_SelectAndContinueWithBookingFirst2PMto3PM();
        diary.EnterFromandToDateSlot_2PMto3PM();
        diary.FFTTest46_clickOncontinuewithbookingTime_1011(); 
        Thread.Sleep(3000);
        bookingsummary.ENterSetUPtime();
        bookingsummary.ENterBreakdowntime();
        bookingsummary.EnterTitle();
        bookingsummary.clickonsave();
        Thread.Sleep(2000);
        bookingsummary.clickonGoToDIary();
        Thread.Sleep(3000);
        diary.FFTTest203_DragandDropto_NewTime();
        Thread.Sleep(5000);
        Driver.SwitchTo().Frame(Driver.FindElement(By.Id("frmPnlMove")));
        Thread.Sleep(2000);
        diary.FFTTest203_ChangeDateTime_ForMoveBooking();
        Thread.Sleep(4000);
        diary.ClickOn_confirmMoveBooking();}







           
              

             

           
          
        

        //public IWebDriver webDriver { get; set; }
    }
}
