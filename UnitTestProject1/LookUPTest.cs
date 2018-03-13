using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using UnitTestProjectsummary.PageElements;
using System.Threading;
using UnitTestProjectsummary.LookUP;

namespace UnitTestProjectsummary
{
    [TestClass]
    public class LookUPTest
    {
        
        public IWebDriver Driver;
        public WebDriverWait Wait;

        public LookUPTest(IWebDriver webDriver)
        {
           
            this.webDriver = webDriver;
        }
        public LookUPTest()
        { 
        }

        [TestInitialize]
        public void SetupTest()
        {
            this.Driver = new ChromeDriver();
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(60));
            Driver.Manage().Window.Maximize();
        }

        //[TestCleanup]
        //public void TeardownTest()
        //{
        //    this.Driver.Quit();
        //}


      
        [TestMethod]
        public void FFT48_CreateParentQueastionare()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            LookUpMainPage lookup = new LookUpMainPage(this.Driver);
            lookup.NavidateToUDF();
            Thread.Sleep(2000);
            lookup.SelectUDFQuentionnaireDropedown();
            lookup.EnterFieldNameForParentQuentionare();
            lookup.SelectDataTypeFromDropedown_Boolean();
            lookup.SelectUDFGroupDropedown();
            //Thread.Sleep(2000);
            lookup.ClickOnSave_AddMoreButton();
         }

        [TestMethod]
        public void FFT48_CreateChildQuestionnaire()
        {
            
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            
            LookUpMainPage lookup = new LookUpMainPage(this.Driver);
            lookup.NavidateToUDF();
            Thread.Sleep(2000);
            lookup.SelectUDFQuentionnaireDropedown();
            lookup.EnterFieldNameForChildQuentionare();
            lookup.SelectDataTypeFromDropedown_Boolean();
            lookup.SelectUDFGroupDropedown();
            Thread.Sleep(2000);
            lookup.IsDependentYes();
            Thread.Sleep(2000);
            lookup.ParentUDFDropedown_Questioonare();
            lookup.ClickOnSave_AddMoreButton();
        }

        [TestMethod]
        public void FFT48_UpdateParentQuestionnaires()
        {

            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            LookUpMainPage lookup = new LookUpMainPage(this.Driver);
            lookup.NavidateToUDF();
            Thread.Sleep(3000);
            lookup.SelectUDFQuentionnaireDropedown();
            lookup.UDfSearchForEditQuestionare_Parent();
            Thread.Sleep(2000);
            lookup.UDF_ClickOnEditRsecordFirst1();
            Thread.Sleep(2000);
            lookup.ENterUpdatedFieldNameForChildQuestionare();
            lookup.ClickOnSave_AddMoreButton();
        }
        [TestMethod]
        public void FFT48_DeleteChildQuestionnaires()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            LookUpMainPage lookup = new LookUpMainPage(this.Driver);
            lookup.NavidateToUDF();
            Thread.Sleep(2000);
            lookup.SelectUDFQuentionnaireDropedown();
            //this will search record for delete operatoion
            lookup.UDFSearchForDeleteQuestionare();
            Thread.Sleep(2000);
            lookup.UDF_ClickOnDeleteRecord();
            Thread.Sleep(2000);
          }

        [TestMethod]
        public void CreateParentBookingUDF()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            
            LookUpMainPage lookup = new LookUpMainPage(this.Driver);
            lookup.NavidateToUDF();
            Thread.Sleep(1000);
            lookup.SelectUDF_BookingDropedown();
            lookup.EnterFieldName_ParentBookingUDF();
            lookup.SelectDataTypeFromDropedown_Boolean();
            lookup.SelectUDFGroupDropedown();
            //.Sleep(2000);
            lookup.ClickOnSave_AddMoreButton();
        }

        [TestMethod]
        public void CreateChildtBookingUDF()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            LookUpMainPage lookup = new LookUpMainPage(this.Driver);
            lookup.NavidateToUDF();
            Thread.Sleep(1000);
            lookup.SelectUDF_BookingDropedown();
            lookup.ENterFieldName_ChildBookingUDF();
            Thread.Sleep(2000);
            lookup.IsDependentYes();
            Thread.Sleep(2000);
            lookup.ParentUDFDropedown_Booking();
            lookup.ClickOnSave_AddMoreButton();
            Thread.Sleep(2000); 
        }
       
        [TestMethod]
        public void FFT85_MainTest()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            DiaryMainPage diary = new DiaryMainPage(this.Driver);
            diary.FFTTest49_SelectAndContinueWithBooking_UDF();
            Thread.Sleep(2000);
            diary.FFTTest46_EnterFromandToDateSlot_10111();
            diary.FFTTest46_clickOncontinuewithbookingTime_1011();
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.FFT49_ENterUDFValues();
            bookingsummary.EnterTitle();
            Thread.Sleep(2000);
            bookingsummary.clickonsave(); 
        }

        [TestMethod]
        public void FFT50()
        {   LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            DiaryMainPage diary = new DiaryMainPage(this.Driver);
            diary.FFTTest49_SelectAndContinueWithBooking_UDF();
          
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.FFT_50_ClearChildUDFSelection();
            Thread.Sleep(2000);
            bookingsummary.clickonsave();
            Thread.Sleep(3000);
            bookingsummary.FFT_50InvalidUDFContent();}

        [TestMethod]
        public void FFT49_And_FFT86()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            DiaryMainPage diary = new DiaryMainPage(this.Driver);
            diary.FFTTest49_SelectAndContinueWithBooking_UDF();
           
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.FFT_50_ClearParentUDFSelection();
            Thread.Sleep(5000);
            bookingsummary.FFT49and86_PopUPCLearValueFromDependentField();
            Thread.Sleep(2000);
            bookingsummary.clickonsaveAndExit();
            Thread.Sleep(3000);
           }

          [TestMethod]
        public void FFT98_DeactivateChildUdfandVerfiyForBooking()
        { 
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            LookUpMainPage lookup = new LookUpMainPage(this.Driver);
            lookup.NavidateToUDF();
            Thread.Sleep(3000);
            lookup.SelectUDF_BookingDropedown();
            Thread.Sleep(2000);
            lookup.UDFSearchFor_deactivateCHildBookingUDF();

            //GOTO dIARY AND VERFIY FOR DEACTIVATED UDF
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            DiaryMainPage diary = new DiaryMainPage(this.Driver);
            Thread.Sleep(4000);
            diary.FFTTest49_SelectAndContinueWithBooking_UDF();
         }



























        public IWebDriver webDriver { get; set; }
    }
}
