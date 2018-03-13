using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using UnitTestProjectsummary.PageElements;
using System.Threading;
using NUnit;
using UnitTestProjectsummary.Addons_ResourceManagement;
using UnitTestProjectsummary.Addons_NewBookingPage;
using NUnit.Framework;
using System.Collections.Generic;
using UnitTestProjectsummary.BookingSearchAndUpdateBooking;
using UnitTestProjectsummary.PropertySetting_page;
using UnitTestProjectsummary.BRE;

namespace UnitTestProjectsummary
{
    [TestClass]
    public class AddonTestCases
    {
        public IWebDriver Driver;
        public WebDriverWait Wait;
        public AddonTestCases(IWebDriver webDriver)
        {

            this.webDriver = webDriver;
        }
        public AddonTestCases()
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
        public void FFT227andFFT228_AddonNotificationMessage()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_227AddonNotificationMessage();
            Thread.Sleep(2000);
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(3000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.AddAddon_Cake_BySearch();
            Thread.Sleep(2000);
            addAddon.AcceptAddonNotificationMessageAndGetHeaderText();
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.GetAddedAddonName();
        }

        [TestMethod]
        public void FFT229_DisableAddonNotificationMessage()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_229DisableAddonNotificationMessage();
            Thread.Sleep(2000);
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.clickonGoToDIary();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(3000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.AddAddon_Cake_BySearch();
            Thread.Sleep(2000);
            addAddon.VerifyAddAddonButtonIsEnabled();
            Thread.Sleep(2000);
        }
        [TestMethod]
        public void FFT230_AddonsDisplayingUndeResourceCatagoey()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.GetAllAddonTextFromDifferentCatagory();
        }

        [TestMethod]
        public void FFT231_AddonNoSTockType()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_231StockType_NoStock();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(2000);
            addAddon.add_addon_Bread_VerifyStock();
            addAddon.ClickOnAddAddonButton();
            addAddon.SummaryButtonFromAddonPageIsEnabled();
        }
      
            
            
           
        
        



        [TestMethod]
        public void FFT232_AddonStockItem()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_232StockType_WithStockAndCOnfigurations();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(2000);
            addAddon.add_addon_Bread_VerifyStock();
            Thread.Sleep(3000);
            addAddon.AddonQuantity5();
            addAddon.ClickOnAddAddonButton();
            addAddon.clickOnGoToSummaryFromAddonPage();
            addAddon.SummaryButtonFromAddonPageIsEnabled();
        }

        [TestMethod]
        public void FFT233_AddonStockType()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_232StockType_WithStockAndCOnfigurations();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);

            //***create Booking with addon quantity 4
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(2000);
            addAddon.add_addon_Bread_VerifyStock();
            addAddon.ClickOnAddAddonButton();
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(3000);
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.EnterTitle();
            Thread.Sleep(2000);
            bookingsummary.clickonsave();

            //****Create Booking with addon quantity 3
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(2000);
            addAddon.add_addon_Bread_VerifyStock();
            Thread.Sleep(3000);
            addAddon.AddonQuantity3();
            addAddon.ClickOnAddAddonButton();
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
            bookingsummary.clickonsave();
            Thread.Sleep(2000);
            bookingsummary.FFT233_Is_AddonOutOfStock_PopUPEnabled();
        }
        [TestMethod]
        public void FFT256_AddonRecurringBooking()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);

            //createRecurring Booking with Addons
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.ClickOnRecurBookingButton();
            DiaryMainPage diary = new DiaryMainPage(this.Driver);
            Thread.Sleep(2000);
            bookingsummary.SelectDailyRecurBooking_FromBookingSummaryPage();
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(2000);

            //adding two addons
            addAddon.FFT256_add_addon_Milk();
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.FFT256_add_addon_Juice();
            addAddon.ClickOnAddAddonButton();
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
            bookingsummary.EnterTitleForFFT_256();
            bookingsummary.clickonsaveAndExit();
            Thread.Sleep(10000);
            bookingsummary.clickonGoToDIary();

            //BookingSearch and Update Second occurance with new Addon
            CreateBooking.CreateBookingNavigation();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            booksearch.NavigateBookingSearch();
            Thread.Sleep(2000);
            booksearch.FFT_256_BookingSearch_SelectSecondOccurance();
            Thread.Sleep(2000);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.EditAddon();
            Thread.Sleep(1000);
            addAddon.FFT256_add_addon_Tea();
            addAddon.ClickOnAddAddonButton();
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
            bookingsummary.clickonsaveAndExit();
            Thread.Sleep(10000);
            bookingsummary.clickonGoToDIary();

            //Booking search and update last occurance for time 2-3PM
            CreateBooking.CreateBookingNavigation();
            booksearch.NavigateBookingSearch();
            Thread.Sleep(2000);
            booksearch.FFT_256_BookingSearch_SelectThirdOccurance();
            Thread.Sleep(2000);
            bookingsummary.FFT256_ClickOnDateAndTimeOptionOnBookingSummaryPage();
            bookingsummary.SelectTimecalender_Time2PM();
            bookingsummary.NavigateTosrviceTrackerPage();
        }

        [TestMethod] //256 should be executed
        public void FFT_257_AddOnRecurringBooking()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            booksearch.NavigateBookingSearch();
            Thread.Sleep(2000);
            booksearch.FFT_256_BookingSearch_SelectThirdOccurance();
            Thread.Sleep(2000);
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.FFT256_ClickOnDateAndTimeOptionOnBookingSummaryPage();
            bookingsummary.ClickOnTimeViewPopUP_Select3PM();
            Thread.Sleep(15000);
            bookingsummary.NavigateTosrviceTrackerPage();
        }
        [TestMethod]
        public void FFT_259_AddOnRecurringBooking()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            booksearch.NavigateBookingSearch();
            Thread.Sleep(2000);
            booksearch.FFT_256_BookingSearch_SelectThirdOccurance();
            Thread.Sleep(2000);
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.ChangeBookingStatustoCancelled();
            bookingsummary.clickonsaveAndExit();
            bookingsummary.clickonGoToDIary();
            bookingsummary.NavigateTosrviceTrackerPage();
        }

        [TestMethod]
        public void FFT_263Addon_CutOFF_period()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_263_SetBookingCutOffPeriod_2Hrs();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectTime_1PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.verfiy_AddonCuttOffMessage_Enabled();
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void FFT_264Addon_CutOFF_period()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            //addon.FFT_263_SetBookingCutOffPeriod_2Hrs();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectTime_3PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void FFT_265Addon_CutOFF_period()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_265_SetBookingCutOffTime_3PM();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectTime_1PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void FFT_266Addon_CutOFF_period()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_265_SetBookingCutOffTime_12PM();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectTime_1PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.verfiy_AddonCuttOffMessage_Enabled();
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void FFT_267CutoffNoticePeriod()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            PropertySettingMainPage propertyset = new PropertySettingMainPage(this.Driver);
            propertyset.Set_AddonNotice24_CutOff_3Pm();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_267_ClearCutOffPeriodAndTime();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectTomorrowsDate();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.verfiy_AddonCuttOffMessage_Enabled();
            Thread.Sleep(2000);
        }
        [TestMethod]
        public void FFT_268CutoffNoticePeriod()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            PropertySettingMainPage propertyset = new PropertySettingMainPage(this.Driver);
            propertyset.Set_AddonNotice8_CutOff_3PM();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_267_ClearCutOffPeriodAndTime();
            Thread.Sleep(2000);
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectTomorrowsDate();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.verfiy_AddonCuttOffMessage_Enabled();
            Thread.Sleep(2000);
        }
        [TestMethod]
        public void FFT_269CutoffWeekendRule()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            PropertySettingMainPage propertyset = new PropertySettingMainPage(this.Driver);
            propertyset.Clear_AddonNotice_CutOff();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_269_Set48HoursforWeekend_CutOffTime3PM();
            BREMainPage bre = new BREMainPage(this.Driver);
            bre.FFT_269_48CutOffRuleForFriday();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectTomorrowsDate_Time10AM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.verfiy_AddonCuttOffMessage_Enabled();
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void FFT_270CutoffWeekendRule()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            PropertySettingMainPage propertyset = new PropertySettingMainPage(this.Driver);
            propertyset.Clear_AddonNotice_CutOff();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_269_Set48HoursforWeekend_CutOffTime3PM();
            BREMainPage bre = new BREMainPage(this.Driver);
            bre.FFT_269_48CutOffRuleForFriday();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectDate2Days_FromTodaysDateTime10To11AM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.verfiy_AddonCuttOffMessage_Enabled();
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void FFT_271CutoffWeekendRule()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            PropertySettingMainPage propertyset = new PropertySettingMainPage(this.Driver);
            propertyset.Clear_AddonNotice_CutOff();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_269_Set48HoursforWeekend_CutOffTime3PM();
            BREMainPage bre = new BREMainPage(this.Driver);
            bre.FFT_269_48CutOffRuleForFriday();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectDate3Days_FromTodaysDateTime10To11AM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void FFT_272Cutoffs()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            PropertySettingMainPage propertyset = new PropertySettingMainPage(this.Driver);
            propertyset.Clear_AddonNotice_CutOff();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT272_SetCutOFfTime_4Pm_2Hrs();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.CreateBookingNavigation();
            Thread.Sleep(2000);
            CreateBooking.SelectTodaysDate_Time2PM_3PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.verfiy_AddonCuttOffMessage_Enabled();
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void FFT_273Cutoffs()
        {
            //Creating New Booking With Titile FFT273
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.SelectTodaysDate_Time12_30PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.EnterTtileFor_FFT_273();
            Thread.Sleep(2000);
            bookingsummary.clickonsaveAndExit();
            Thread.Sleep(3000);
            bookingsummary.clickonGoToDIary();

            //Updating AddonSettings
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_263_SetBookingCutOffPeriod_2Hrs();

            //update ExistingBooking
            bookingsummary.clickonGoToDIary();
            CreateBooking.CreateBookingNavigation();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            booksearch.FFT_273_BookingSearch();
            Thread.Sleep(2000);
            bookingsummary.FFT256_ClickOnDateAndTimeOptionOnBookingSummaryPage();
            bookingsummary.SelectToDateTime2_30();
            Thread.Sleep(6000);
            bookingsummary.NavigateTosrviceTrackerPage();
        }


        [TestMethod]
        public void FFT_274Cutoffs()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            CreateBooking.SelectTodaysDate_Time12_30PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.EnterTtileFor_FFT_274();
            Thread.Sleep(2000);
            bookingsummary.clickonsaveAndExit();
            Thread.Sleep(3000);
            bookingsummary.clickonGoToDIary();

            //Updating AddonSettings
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_265_SetBookingCutOffTime_12PM();

            //update ExistingBooking
            bookingsummary.clickonGoToDIary();
            CreateBooking.CreateBookingNavigation();
            BookingSearchMainPage booksearch = new BookingSearchMainPage(this.Driver);
            booksearch.FFT_274_BookingSearch();
            Thread.Sleep(2000);
            bookingsummary.FFT256_ClickOnDateAndTimeOptionOnBookingSummaryPage();
            bookingsummary.SelectToDateTime2_30();
            Thread.Sleep(6000);
            bookingsummary.NavigateTosrviceTrackerPage(); }


 [TestMethod]
  public void FFT_275Cutoffs()
        {
            LoginMainPage logint = new LoginMainPage(this.Driver);
            logint.Navigate();
            logint.Login();
            Thread.Sleep(2000);
            AddonMainPage addon = new AddonMainPage(this.Driver);
            addon.FFT_275_CutOffTime_12PM_2hours();
            CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
            Thread.Sleep(2000);
            CreateBooking.SelectTodaysDate_Time12_30PM();
            CreateBooking.searchButtonclick();
            Thread.Sleep(5000);
            CreateBooking.CreateBookingValidate().TestResourceCheckbox();
            CreateBooking.selectingtheresource();
            Thread.Sleep(3000);
            CreateBooking.GotoSummaryPage();
            Thread.Sleep(4000);
            Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
            addAddon.CliCkOnAddAddon_FromBookingSummary();
            Thread.Sleep(3000);
            addAddon.FFT_263_Add_addon_CheeseTray();
            Thread.Sleep(2000);
            addAddon.ClickOnAddAddonButton();
            Thread.Sleep(2000);
            addAddon.clickOnGoToSummaryFromAddonPage();
            Thread.Sleep(2000);
            BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
            bookingsummary.EnterTtileFor_FFT_275();
            Thread.Sleep(2000);
            bookingsummary.clickonsaveAndExit();
            Thread.Sleep(3000);
            bookingsummary.clickonGoToDIary();
            Thread.Sleep(3000);
            bookingsummary.NavigateTosrviceTrackerPage();
          
        }
 [TestMethod]
 public void FFT_276Cutoffs()
 {
     LoginMainPage logint = new LoginMainPage(this.Driver);
     logint.Navigate();
     logint.Login();
     Thread.Sleep(2000);
     PropertySettingMainPage propertyset = new PropertySettingMainPage(this.Driver);
     //propertyset.Clear_AddonNotice_CutOff();
     Thread.Sleep(2000);
     AddonMainPage addon = new AddonMainPage(this.Driver);
    // addon.FFT_276_Set48HoursforWeekend_CutOffTime3PM_2HrPeriod();
     BREMainPage bre = new BREMainPage(this.Driver);
     //bre.FFT_269_48CutOffRuleForFriday();
     CreateBookingMainPage CreateBooking = new CreateBookingMainPage(this.Driver);
  
     Thread.Sleep(2000);
     CreateBooking.SelectTime_3AM();
     CreateBooking.searchButtonclick();
     Thread.Sleep(5000);
     CreateBooking.CreateBookingValidate().TestResourceCheckbox();
     CreateBooking.selectingtheresource();
     Thread.Sleep(3000);
     CreateBooking.GotoSummaryPage();
     Thread.Sleep(4000);
     Addons_FromNewBookingPage addAddon = new Addons_FromNewBookingPage(this.Driver);
     addAddon.CliCkOnAddAddon_FromBookingSummary();
     Thread.Sleep(3000);
     addAddon.FFT_263_Add_addon_CheeseTray();
     Thread.Sleep(2000);
     addAddon.ClickOnAddAddonButton();
     Thread.Sleep(2000);
     addAddon.clickOnGoToSummaryFromAddonPage();
     Thread.Sleep(2000);
     BookingSummaryMainPage bookingsummary = new BookingSummaryMainPage(this.Driver);
     bookingsummary.EnterTtileFor_FFT_276();
     Thread.Sleep(2000);
     bookingsummary.clickonsaveAndExit();
     Thread.Sleep(3000);
     bookingsummary.clickonGoToDIary();
     Thread.Sleep(3000);
     bookingsummary.NavigateTosrviceTrackerPage();
    
 }



        public IWebDriver webDriver { get; set; }
    }
}
