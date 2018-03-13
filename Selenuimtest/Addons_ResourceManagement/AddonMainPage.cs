using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace UnitTestProjectsummary.Addons_ResourceManagement
{
    public class AddonMainPage
    {
        public AddonMainPage(IWebDriver browser)
        {
            this.browser = browser;
        }
        public AddonMainPage()
        {

        }

        public AddonPageElements AddonMap
        {
            get
            {
                return new AddonPageElements(this.browser);
            }
        }

        public void NavigateToAddonPage()
        {
            this.AddonMap.NavigatetoAdministration.Click();
            this.AddonMap.ClickOnResouceManagementICon.Click();
            this.AddonMap.ClickOnAddonIcon.Click();
        }
        public void AddonSearch_WithName_cakeAndProperty_ForNotificationMsg()
        {
            this.AddonMap.AddonNameSearchTextBox.SendKeys("Cake");
            this.AddonMap.PropertyNameSearchTextBox.SendKeys(Keys.Enter);
            this.AddonMap.PropertyNameSearchTextBox.SendKeys("Toronto - NEW");
            this.AddonMap.PropertyNameSearchTextBox.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            this.AddonMap.SelectFirstRecordFromSearchResult.Click();
        }
        public void AddonSearch_WithName_BreadGarlicAndProperty_ForStockIteam()
        {
            this.AddonMap.AddonNameSearchTextBox.SendKeys("Bread (Garlic)");
            this.AddonMap.PropertyNameSearchTextBox.SendKeys(Keys.Enter);
            this.AddonMap.PropertyNameSearchTextBox.SendKeys("Toronto - NEW");
            this.AddonMap.PropertyNameSearchTextBox.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            this.AddonMap.SelectFirstRecordFromSearchResult.Click();
        }

          public void AddonSearch_WithName_CheeseTray()
        {
            this.AddonMap.AddonNameSearchTextBox.SendKeys("Cheese Tray / Plateau de fromages");
            this.AddonMap.PropertyNameSearchTextBox.SendKeys(Keys.Enter);
            this.AddonMap.PropertyNameSearchTextBox.SendKeys("Toronto - NEW");
            this.AddonMap.PropertyNameSearchTextBox.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            this.AddonMap.SelectFirstRecordFromSearchResult.Click();
        }
        public void SetAddonNotificationYes()
        {
            this.AddonMap.Set_AddonNotification_Yes.Click();
        }
        public void SetAddonNotificationNo()
        {
            this.AddonMap.Set_AddonNotification_No.Click();
        }
        public void SelectDropedownNoStock()
        {
            var drop1=this.AddonMap.StockType;
            SelectElement ssg = new SelectElement(drop1);
            ssg.SelectByIndex(0);
        }
        public void FFT269_Add48_HoursWeekends_Yes()
        {
            this.AddonMap.Add48_HoursWeekend_Yes.Click();
        }
        public void SelectDropedownStock_AndConfigurations()
        {
            var drop1 = this.AddonMap.StockType;
            SelectElement ssg = new SelectElement(drop1);
            ssg.SelectByIndex(1);
            Thread.Sleep(2000);

            Actions action = new Actions(browser);
            action.MoveToElement(this.AddonMap.TotalNoofAddons);
            action.Click();
            action.SendKeys("6");
            action.Build().Perform();
            browser.SwitchTo().DefaultContent();

            Thread.Sleep(2000);
            Actions action1 = new Actions(browser);
            action1.MoveToElement(this.AddonMap.MaximumAddOnperBooking);
            action1.Click();
            action1.SendKeys("4");
            action1.Build().Perform();
            browser.SwitchTo().DefaultContent();

            action.MoveToElement(this.AddonMap.QuantityDeductedfromtheTotalAddons);
            action.Click();
            action.SendKeys("4");
            action.Build().Perform();
        }

        public void EditAddon_Notes()
        {
            
            this.AddonMap.Enter_AddonNotes.SendKeys("Addon1234%^%^%^%hhh");
        }
        public void Save_Addon()
        {
            this.AddonMap.SaveAddon.Click();
        }
        public void FFT_227AddonNotificationMessage()
        {
            NavigateToAddonPage();
            AddonSearch_WithName_cakeAndProperty_ForNotificationMsg();
            SetAddonNotificationYes();
            EditAddon_Notes();
            Save_Addon();
        }
        public void FFT_229DisableAddonNotificationMessage()
        {
            NavigateToAddonPage();
            AddonSearch_WithName_cakeAndProperty_ForNotificationMsg();
            SetAddonNotificationNo();
            Save_Addon();
        }
        public void FFT_231StockType_NoStock()
        {
            NavigateToAddonPage();
            AddonSearch_WithName_BreadGarlicAndProperty_ForStockIteam();
            SelectDropedownNoStock();
            Thread.Sleep(2000);
            Save_Addon();
        }

        public void FFT_232StockType_WithStockAndCOnfigurations()
        {
            NavigateToAddonPage();
            AddonSearch_WithName_BreadGarlicAndProperty_ForStockIteam();
            SelectDropedownStock_AndConfigurations();
            Thread.Sleep(2000);
            Save_Addon();
        }
//FFT_263_AddonCutOffPeriod
        public void FFT_263_SetBookingCutOffPeriod_2Hrs()
        { 
        NavigateToAddonPage();
        AddonSearch_WithName_CheeseTray();
        Thread.Sleep(2000);
        this.AddonMap.BookingCutOffPeriod.Clear();
        this.AddonMap.BookingCutOffPeriod.SendKeys("2");
        this.AddonMap.CutOFfTime_TextField.Clear();
        Save_Addon();
        Thread.Sleep(2000);
        }
 //FFT_265_SetBookingCutOffTime_3PM
        public void FFT_265_SetBookingCutOffTime_3PM()
        { 
         NavigateToAddonPage();
         AddonSearch_WithName_CheeseTray();
         Thread.Sleep(2000);
         this.AddonMap.BookingCutOffPeriod.Clear();
         this.AddonMap.BookingCutOffPeriod.SendKeys("0");
         this.AddonMap.CutOFfTime_TextField.Clear();
         var cuttime = this.AddonMap.CutOFfTime_TextField;
         Actions act = new Actions(browser);
         act.MoveToElement(cuttime).SendKeys("03:00 PM").Build().Perform();
         Thread.Sleep(2000);
         Save_Addon();
         Thread.Sleep(2000);
        }
//FFT_266_SetBookingCutOffTime_12PM
        public void FFT_265_SetBookingCutOffTime_12PM()
        {
            NavigateToAddonPage();
            AddonSearch_WithName_CheeseTray();
            Thread.Sleep(2000);
            this.AddonMap.BookingCutOffPeriod.Clear();
            this.AddonMap.BookingCutOffPeriod.SendKeys("0");
            this.AddonMap.CutOFfTime_TextField.Clear();
            var cuttime = this.AddonMap.CutOFfTime_TextField;
            Actions act = new Actions(browser);
            act.MoveToElement(cuttime).SendKeys("12PM").Build().Perform();
            Thread.Sleep(2000);
            Save_Addon();
            Thread.Sleep(2000); }

  //FFT_275_CutOffTime_12PM_hours_2
        public void FFT_275_CutOffTime_12PM_2hours()
        {   NavigateToAddonPage();
            AddonSearch_WithName_CheeseTray();
            Thread.Sleep(2000);
            this.AddonMap.BookingCutOffPeriod.Clear();
            this.AddonMap.BookingCutOffPeriod.SendKeys("2");
            this.AddonMap.CutOFfTime_TextField.Clear();
            var cuttime = this.AddonMap.CutOFfTime_TextField;
            Actions act = new Actions(browser);
            act.MoveToElement(cuttime).SendKeys("12PM").Build().Perform();
            Thread.Sleep(2000);
            Save_Addon();
            Thread.Sleep(2000);
        }


//FFT_272_SetCutOffTime_4Pm_period_2hours
        public void FFT272_SetCutOFfTime_4Pm_2Hrs()
        {
            NavigateToAddonPage();
            AddonSearch_WithName_CheeseTray();
            Thread.Sleep(2000);
            this.AddonMap.BookingCutOffPeriod.Clear();
            this.AddonMap.BookingCutOffPeriod.SendKeys("2");
            this.AddonMap.CutOFfTime_TextField.Clear();
            var cuttime = this.AddonMap.CutOFfTime_TextField;
            Actions act = new Actions(browser);
            act.MoveToElement(cuttime).SendKeys("4PM").Build().Perform();
            Thread.Sleep(2000);
            Save_Addon();
            Thread.Sleep(2000);}

        public void FFT_267_ClearCutOffPeriodAndTime()
        {
            NavigateToAddonPage();
            AddonSearch_WithName_CheeseTray();
            Thread.Sleep(2000);
            this.AddonMap.BookingCutOffPeriod.Clear();
            this.AddonMap.BookingCutOffPeriod.SendKeys("0");
            this.AddonMap.CutOFfTime_TextField.Clear();
            Thread.Sleep(3000);
            Save_Addon();
            Thread.Sleep(2000);
        }
        public void FFT_269_Set48HoursforWeekend_CutOffTime3PM()
        {
            NavigateToAddonPage();
            AddonSearch_WithName_CheeseTray();
            Thread.Sleep(2000);
            this.AddonMap.BookingCutOffPeriod.Clear();
            this.AddonMap.BookingCutOffPeriod.SendKeys("0");
            this.AddonMap.CutOFfTime_TextField.Clear();
            var cuttime = this.AddonMap.CutOFfTime_TextField;
            Actions act = new Actions(browser);
            act.MoveToElement(cuttime).SendKeys("3PM").Build().Perform();
            Thread.Sleep(2000);
            FFT269_Add48_HoursWeekends_Yes();
            Thread.Sleep(1000);
            Save_Addon();
            Thread.Sleep(2000);}

        public void FFT_276_Set48HoursforWeekend_CutOffTime3PM_2HrPeriod()
        {
            NavigateToAddonPage();
            AddonSearch_WithName_CheeseTray();
            Thread.Sleep(2000);
            this.AddonMap.BookingCutOffPeriod.Clear();
            this.AddonMap.BookingCutOffPeriod.SendKeys("2");
            this.AddonMap.CutOFfTime_TextField.Clear();
            var cuttime = this.AddonMap.CutOFfTime_TextField;
            Actions act = new Actions(browser);
            act.MoveToElement(cuttime).SendKeys("3PM").Build().Perform();
            Thread.Sleep(2000);
            FFT269_Add48_HoursWeekends_Yes();
            Thread.Sleep(1000);
            Save_Addon();
            Thread.Sleep(2000);
        }

        public IWebDriver browser { get; set; }

        public IWebDriver driver { get; set; }
    }
}




