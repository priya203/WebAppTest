using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProjectsummary.PageElements;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UnitTestProjectsummary.WebAppCreateBookingPage;
using System.Threading;
using UnitTestProjectsummary.WebAppBookingSummaryPage;
using UnitTestProjectsummary.WebAppDiary;
using UnitTestProjectsummary.Addons_NewBookingPage;

namespace UnitTestProjectsummary
{
    [TestClass]
    public class BookingSummaryUnitTest
    {

        public IWebDriver Driver;
        public WebDriverWait Wait;

        public BookingSummaryUnitTest(IWebDriver webDriver)
        {
           
            this.webDriver = webDriver; 
        }
        public BookingSummaryUnitTest()
        { 
        }

        [TestInitialize]
        public void SetupTest()
        {
            this.Driver = new ChromeDriver();
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
            Driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            this.Driver.Quit();
        }

        [TestMethod]
        public void FFT200()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            DiaryMainPage dd = new DiaryMainPage(this.Driver);
            dd.FFTTest200_SelectAndContinueWithBooking();
           Thread.Sleep(1000);
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
         //  addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            Thread.Sleep(2000);
            bookingsummary.clickOnAddAddon();
            Thread.Sleep(3000);
            bookingsummary.EnterTitleFFT_200();
            Thread.Sleep(5000);
            bookingsummary.clickonsaveAndExit();
            Thread.Sleep(7000);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(7000);
            dd.FFTTest200_DragandDrop_Chnageroom();
            Thread.Sleep(7000);
            dd.ClickConfirmChangeRoom();
            Thread.Sleep(3000);
            dd.ClickOnMovedBooking_Room();
            Thread.Sleep(3000);
            bookingsummary.FFT200_clickonAddAdon_Button_Verify_AddedAddon();
            Thread.Sleep(3000);
        }
        [TestMethod]
        public void FFT46()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            DiaryMainPage dd = new DiaryMainPage(this.Driver);
            dd.FFTTest46_SelectAndContinueWithBookingFirst();
            dd.FFTTest46_EnterFromandToDateSlot_10111();
            dd.FFTTest46_clickOncontinuewithbookingTime_1011();

            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(3000);
            bookingsummary.EnterTitleFFT_46Case1();
            Thread.Sleep(1000);
            bookingsummary.clickonsaveAndExit();
            Thread.Sleep(9000);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(7000);
            dd.FFTTest46_SelectAndContinueWithBookingTarget();
            Thread.Sleep(5000);
            bookingsummary.EnterTitleFFT_46Case2();
            Thread.Sleep(1000);
            bookingsummary.clickonsaveAndExit();
            Thread.Sleep(7000);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(7000);
            dd.FFTTest46_DragandDrop();
            Thread.Sleep(3000);
            Driver.SwitchTo().Frame(Driver.FindElement(By.Id("frmPnlMove")));
            Thread.Sleep(1000);
            dd.ClickOn_confirmMoveBooking();
            Thread.Sleep(8000);
            bookingsummary.BookingSummaryValidate().DisplayAlternteResource();
            Thread.Sleep(5000);}



        [TestMethod]
        public void FFT202()
        {
           LoginMainPage logint = new LoginMainPage(this.Driver);
           logint.Navigate();
           logint.Login();
           Thread.Sleep(3000);
           DiaryMainPage dd = new DiaryMainPage(this.Driver);
           dd.FFTTest202_SelectAndContinueWithBooking();
           Thread.Sleep(3000);
           BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
           bookingsummary.EnterTitleFFT_202();
           Thread.Sleep(2000);
           bookingsummary.ENterSetUPtime();
           Thread.Sleep(2000);
           bookingsummary.ENterBreakdowntime();
           Thread.Sleep(2000);
           bookingsummary.clickonsaveAndExit();
           Thread.Sleep(7000);
           bookingsummary.clickonGoToDIary();
           Thread.Sleep(7000);
           dd.FFTTest202_DragandDrop();
           Thread.Sleep(6000);
           Driver.SwitchTo().Frame(Driver.FindElement(By.Id("frmPnlMove")));
           dd.ClickOn_confirmMoveBooking();
           Thread.Sleep(6000);
           dd.FFTTest202_ClickOnMovedBooking_Time();
           Thread.Sleep(4000);
           bookingsummary.VerifySetUpBreakdownTime_ForMovedBooking();
    }
        

        [TestMethod]
        public void Create_SimpleBooking_FromNewBookingOption()
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
            Thread.Sleep(8000);
            CreateBooking.GotoSummaryPage();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(5000);
            bookingsummary.EnterTitle();
            Thread.Sleep(5000);
            bookingsummary.clickonsave();
            Thread.Sleep(2000);
        }
       


        [TestMethod]
        public void Search_availibe_resourcBysearchCriteria()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(3000);
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.ENterFromDate();
            Thread.Sleep(2000);
            bookingsummary.EnterToDate();
            Thread.Sleep(2000);
            bookingsummary.enterresourceType();
            Thread.Sleep(3000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(3000);
        
        }



        [TestMethod]
        public void CreateBooking_withAddon()
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
            Thread.Sleep(8000);
            CreateBooking.GotoSummaryPage();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(3000);
            bookingsummary.clickOnAddAddon();
            Thread.Sleep(3000);
            bookingsummary.EnterTitle();
            Thread.Sleep(5000);
            bookingsummary.clickonsave();
            Thread.Sleep(2000);
        }

      //  [TestMethod]
        public void CreateBooking_AddingInternalVisitors_WithoutPopUPHandling()
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
            Thread.Sleep(8000);
            CreateBooking.GotoSummaryPage();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(3000);
            bookingsummary.clickonAddPplTab();
            Thread.Sleep(3000);
            bookingsummary.AddInternalVisitors();
            Thread.Sleep(3000);
            bookingsummary.GotoSummaryPagefromVisitors();
            bookingsummary.EnterTitle();
            Thread.Sleep(5000);
            bookingsummary.clickonsave();
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void CreateBooking_AddingInternalVisitors_WithPopUPHandling()
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
            Thread.Sleep(8000);
            CreateBooking.GotoSummaryPage();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(3000);
            bookingsummary.clickonAddPplTab();
            //Thread.Sleep(3000);
            bookingsummary.AddInternalVisitors();
            Thread.Sleep(3000);
            bookingsummary.PopUPHandling();
            Thread.Sleep(3000);
            bookingsummary.GotoSummaryPagefromVisitors();
            Thread.Sleep(3000);
            bookingsummary.EnterTitle();
            Thread.Sleep(5000);
            bookingsummary.clickonsave();
            Thread.Sleep(2000);
        }
         [TestMethod]
        public void CreateBooking_withAddon_andVisitors()
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
            Thread.Sleep(8000);
            CreateBooking.GotoSummaryPage();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(3000);
            bookingsummary.clickOnAddAddon();
            Thread.Sleep(3000);
            bookingsummary.clickonAddPplTab();
            //Thread.Sleep(3000);
            bookingsummary.AddInternalVisitors();
            Thread.Sleep(3000);
            bookingsummary.PopUPHandling();
            Thread.Sleep(3000);
            bookingsummary.GotoSummaryPagefromVisitors();
            Thread.Sleep(3000);
            bookingsummary.EnterTitle();
            Thread.Sleep(5000);
            bookingsummary.clickonsave();
            Thread.Sleep(2000);
        }
       
         public void CreateBooking_withInternaland_ExternalVisitors_NoPopUP()
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
             Thread.Sleep(8000);
             CreateBooking.GotoSummaryPage();
             BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
             Thread.Sleep(3000);
             bookingsummary.clickonAddPplTab();
             Thread.Sleep(3000);
             bookingsummary.AddInternalVisitors();
             //Thread.Sleep(3000);
             //bookingsummary.PopUPHandling();
             Thread.Sleep(3000);
             bookingsummary.ExternalVisitors();
            // Thread.Sleep(4000);
            // bookingsummary.PopUPHandling();
             Thread.Sleep(3000);
             bookingsummary.GotoSummaryPagefromVisitors();
             Thread.Sleep(3000);
             bookingsummary.EnterTitle();
             Thread.Sleep(5000);
             bookingsummary.clickonsave();
             Thread.Sleep(2000);
         
         
         }
        [TestMethod]
         public void CreateBookingFromDiary_Addons_Vissitors()
         {
             LoginMainPage logint = new LoginMainPage(this.Driver);
             logint.Navigate();
             logint.Login();
             DiaryMainPage dd = new DiaryMainPage(this.Driver);
             dd.selectDiaryCellandContinuwithBooking();
             BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
             Thread.Sleep(3000);
             bookingsummary.clickOnAddAddon();
             Thread.Sleep(3000);
             bookingsummary.clickonAddPplTab();
             //Thread.Sleep(3000);
             bookingsummary.AddInternalVisitors();
             Thread.Sleep(3000);
             bookingsummary.PopUPHandling();
             Thread.Sleep(3000);
             bookingsummary.GotoSummaryPagefromVisitors();
             Thread.Sleep(3000);
             bookingsummary.EnterTitle();
             Thread.Sleep(5000);
             bookingsummary.clickonsave();
             Thread.Sleep(2000);
         }

        [TestMethod]
        public void CreateBookingSimpleFromDiary()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            DiaryMainPage dd = new DiaryMainPage(this.Driver);
            dd.selectDiaryCellandContinuwithBooking();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            Thread.Sleep(3000);
            bookingsummary.EnterTitle();
            Thread.Sleep(5000);
            bookingsummary.clickonsave();
            Thread.Sleep(2000);
        }
      


      




        public IWebDriver webDriver { get; set; }
    }
}
