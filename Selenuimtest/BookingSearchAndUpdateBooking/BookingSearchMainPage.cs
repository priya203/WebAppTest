using OpenQA.Selenium;
using UnitTestProjectsummary.WebAppCreateBookingPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnitTestProjectsummary.WebAppBookingSummaryPage;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

namespace UnitTestProjectsummary.BookingSearchAndUpdateBooking
{
    public class BookingSearchMainPage
    {
        private readonly string ExistingBookingTitle = ConfigurationSettings.AppSettings["ExistingBooking_Title"];
        private readonly string ExistingBookingRefNumber = ConfigurationSettings.AppSettings["ExistingBooking_RefNumber"];
        private readonly string ExistingBookingFromDate = ConfigurationSettings.AppSettings["ExistingBooking_FromDate"];
        private readonly string ExistingBookingToDate = ConfigurationSettings.AppSettings["ExistingBooking_ToDate"];
        private readonly string ExistingBookingHost = ConfigurationSettings.AppSettings["ExistingBooking_Host"];


        private readonly string New_Title = ConfigurationSettings.AppSettings["New_Title"];
        private readonly string New_Host = ConfigurationSettings.AppSettings["New_Host"];
        private readonly string New_Requester = ConfigurationSettings.AppSettings["New_Requester"];
        private readonly string Notes = ConfigurationSettings.AppSettings["Notes"];
        private readonly string SpecialRequest = ConfigurationSettings.AppSettings["SpecialRequest"];
        private readonly string participants_Count = ConfigurationSettings.AppSettings["participants_Count"];

        public BookingSearchMainPage(IWebDriver browser)
        {
            this.browser = browser;
        }
        public BookingSearchMainPage()
        {

        }

        public BookingSearchPageElements SearchMap
        {
            get
            {
                return new BookingSearchPageElements(this.browser);
            }


        }

        public BookingSearchPageValidators SearchValidate()
        {
            return new BookingSearchPageValidators(this.browser);
        }

        public void NavigateBookingSearch()
        {
            this.SearchMap.NavigatetoBookingSearch.Click();

        }

        public void EnterSearcCriteria()
        {
            this.SearchMap.BookingTitle.SendKeys(ExistingBookingTitle);
            Thread.Sleep(2000);
            this.SearchMap.BookingReference.SendKeys(ExistingBookingRefNumber);
            Thread.Sleep(2000);
            this.SearchMap.StartDate.Clear();
            Thread.Sleep(2000);
            this.SearchMap.StartDate.SendKeys(ExistingBookingFromDate);
            Thread.Sleep(2000);
            this.SearchMap.EndDate.SendKeys(ExistingBookingToDate);
            Thread.Sleep(2000);
            this.SearchMap.BookingHost.SendKeys(ExistingBookingHost);
        }

       
        public void selectBookingTypedrop()
        {
            var dropedown1 = this.SearchMap.BookingType;
            var SelectElement = new SelectElement(dropedown1);
            Thread.Sleep(2000);
            SelectElement.SelectByIndex(2);
            Thread.Sleep(3000);
        }

        public void selectpropertyDroperdown()
        {
            var dropedown2 = this.SearchMap.BookingProperty;
            var SelectElement = new SelectElement(dropedown2);
            Thread.Sleep(2000);
            SelectElement.SelectByIndex(4);
            Thread.Sleep(3000);
        }

        public void SelectStatusDroperdown()
        {
            var dropedown2 = this.SearchMap.Bookingstatus;
            var SelectElement = new SelectElement(dropedown2);
            Thread.Sleep(2000);
            SelectElement.SelectByIndex(3);
            Thread.Sleep(3000);
        }
        public void CLickOnBookingSearchandSelectTheRecord()
        {
            this.SearchMap.BookingSearcButton.Click();
            Thread.Sleep(2000);
            this.SearchMap.ClickonExistingBooking.Click();
            Thread.Sleep(2000);
        }
        public void ClickOnBookAnatherResourceForUpdateBooking()
        {
            this.SearchMap.clickonBookAnathrResorceForUpdate.Click();
        }
        public void UpdateHost()
        {
            Thread.Sleep(5000);
            this.SearchMap.clickOnHostSearchIcon.Click();
            Thread.Sleep(2000);
            IWebElement Frame1 = this.SearchMap.LocatingFrameForHostPopUP;
            browser.SwitchTo().Frame(Frame1);
            this.SearchMap.UpdateTheNewHostName.Click();
            Thread.Sleep(2000);
            this.SearchMap.UpdateTheNewHostName.SendKeys(New_Host);
            Thread.Sleep(2000);
            this.SearchMap.ClickOnSearchButtonOnHostPopUP.Click();
            Thread.Sleep(2000);
            this.SearchMap.ClickOnAddnewHostWhichMatchesSearchCriteria.Click();
            Thread.Sleep(4000);
            browser.SwitchTo().DefaultContent();
        }

        public void Update_Notes()
        {
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_pvSummary']/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/fieldset[1]/table[1]/tbody[1]/tr[1]/td[2]"));
            Thread.Sleep(3000);
            this.SearchMap.ClickOnNotes.Click();
            Thread.Sleep(2000);
            this.SearchMap.ENterNotes.SendKeys("Notes");
            Thread.Sleep(2000);
            this.SearchMap.ClickonSaveNotes.Click();
            this.SearchMap.ClickonRegion.Click();
            Thread.Sleep(2000);
            this.SearchMap.ClickonRegion.Click();
            browser.SwitchTo().DefaultContent();
        }
        public void UpdateSpecialRequest_bookingStatus()
        {
            browser.SwitchTo().DefaultContent();
            Thread.Sleep(1000);
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='ctl00_MainContentPlaceHolder_pvSummary']/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/fieldset[1]/table[1]/tbody[1]/tr[1]/td[3]"));
            Thread.Sleep(1000);
            this.SearchMap.ClickOnSpecialRequest.Click();
            Thread.Sleep(1000);
            this.SearchMap.EnterSpecialRequest.SendKeys(SpecialRequest);
            Thread.Sleep(2000);
            this.SearchMap.ClickonSaveNotes.Click();
            Thread.Sleep(2000);
            this.SearchMap.BookingStausDropdown.Click();
            var statusdropdown = this.SearchMap.BookingStausDropdown;
            SelectElement drop = new SelectElement(statusdropdown);
            drop.SelectByIndex(3);
            Thread.Sleep(1000);
            this.SearchMap.BookingStausDropdown.Click();
            browser.SwitchTo().DefaultContent();
        }
        public void UpdateParticipants_BookingType()
        {

            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id=\'ctl00_MainContentPlaceHolder_pvSummary\']/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/fieldset[1]/table[1]/tbody[1]/tr[1]/td[1]"));
            Thread.Sleep(3000);
            this.SearchMap.participants.Click();
            Thread.Sleep(3000);
            this.SearchMap.participants.SendKeys(participants_Count);
            Thread.Sleep(3000);
            var dropedown11 = this.SearchMap.BookingTypedrop;
            SelectElement sel = new SelectElement(dropedown11);
            sel.SelectByIndex(5);
            this.SearchMap.PrimaryLocation.Click();
            Thread.Sleep(3000);
            this.SearchMap.PrimaryLocation.Click();
            browser.SwitchTo().DefaultContent();
        }



        public void UpdateRequester()
        {
            Thread.Sleep(3000);
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id=\'ctl00_MainContentPlaceHolder_tblBookingRole\']/tbody[1]/tr[1]/td[1]/fieldset[1]/div[2]/table[1]/tbody[1]/tr[1]/td[5]"));
                                                                     //*[@id="ctl00_MainContentPlaceHolder_tblBookingRole"]/tbody[1]/tr[1]/td[1]/fieldset[1]/div[2]/table[1]/tbody[1]/tr[1]/td[5]
            Thread.Sleep(2000);
            this.SearchMap.Requester.Click();
            IWebElement Frame1 = this.SearchMap.LocatingFrameForHostPopUP;
            browser.SwitchTo().Frame(Frame1);
            Thread.Sleep(3000);
            this.SearchMap.UpdateTheNewHostName.Click();
            Thread.Sleep(2000);
            this.SearchMap.UpdateTheNewHostName.SendKeys(New_Requester);
            Thread.Sleep(2000);
            this.SearchMap.ClickOnSearchButtonOnHostPopUP.Click();
            Thread.Sleep(2000);
            this.SearchMap.ClickOnAddnewHostWhichMatchesSearchCriteria.Click();
            Thread.Sleep(4000);
            browser.SwitchTo().DefaultContent();
        }

        public void EnterNewTitle()
        {
            this.SearchMap.EnterUpdatedTitle.Clear();
            Thread.Sleep(2000);
            this.SearchMap.EnterUpdatedTitle.SendKeys(New_Title);
            Thread.Sleep(2000);
        }
        public void ClickonSaveEditedrecord()
        {
            this.SearchMap.ClickOnSAveandExitUpdatedRecord.Click();
        }
//FFT_256_Booking Search
        public void FFT_256_BookingSearch_SelectSecondOccurance()
        {
            this.SearchMap.BookingTitle.SendKeys("FFT266RecurringBooking5");
            this.SearchMap.BookingSearcButton.Click();
            Thread.Sleep(2000);
            this.SearchMap.FFT256_SelectSecondOccurance.Click();
            Thread.Sleep(2000);
            this.SearchMap.FFT256_ClickOnOkbuttonFor_openrecurringBooking.Click();
        }
        public void FFT_256_BookingSearch_SelectThirdOccurance()
        {
            this.SearchMap.BookingTitle.SendKeys("FFT266RecurringBooking5");
            this.SearchMap.BookingSearcButton.Click();
            Thread.Sleep(2000);
            this.SearchMap.FFT256_SelectThirdOccurance.Click();
            Thread.Sleep(2000);
            this.SearchMap.FFT256_OpenENtireSeries.Click();
            this.SearchMap.FFT256_ClickOnOkbuttonFor_openrecurringBooking.Click();
        }
  //FFT_273_BookingSeach
        public void FFT_273_BookingSearch()
        {
            NavigateBookingSearch();
            Thread.Sleep(2000);
            this.SearchMap.BookingTitle.SendKeys("FFT_273");
            this.SearchMap.BookingSearcButton.Click();
            Thread.Sleep(2000);
            this.SearchMap.SelectFirstOccurance.Click();
            Thread.Sleep(2000);}

 //FFT_274_BookingSearch
        public void FFT_274_BookingSearch()
        {
            NavigateBookingSearch();
            Thread.Sleep(2000);
            this.SearchMap.BookingTitle.SendKeys("FFT_274");
            this.SearchMap.BookingSearcButton.Click();
            Thread.Sleep(2000);
            this.SearchMap.SelectFirstOccurance.Click();
            Thread.Sleep(2000);
        }


    

       

        public IWebDriver browser { get; set; }
    }
}

        
        




    


