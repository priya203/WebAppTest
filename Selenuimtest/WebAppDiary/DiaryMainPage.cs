using OpenQA.Selenium;
using UnitTestProjectsummary.WebAppDiary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Runtime.InteropServices;
namespace UnitTestProjectsummary.PageElements{
public class DiaryMainPage
    {
        public DiaryMainPage(IWebDriver browser)
          {
            this.browser = browser;
         }
        public DiaryMainPage()
         { }

        protected DiaryPageElements Map1
            {
            get
            {
                
                return new DiaryPageElements(this.browser);
            }
            }
       
         public DiaryPageValidators Validate1()
          {
            
            return new DiaryPageValidators(this.browser);
         }


       public void selectDiaryCellandContinuwithBooking()
       {
           Actions builder = new Actions(this.browser);
           builder.DoubleClick(this.Map1.SelectDiaryCell).Build().Perform();
           Thread.Sleep(2000);
           this.Map1.ClickOnContinueWIthBooking.Click();
        
       }

        public void FFT47_selectDiaryCellForRecurBooking()
        {
            Actions builder = new Actions(this.browser);
            builder.DoubleClick(this.Map1.FFT47_SelectDiaryCellRecurBooking).Build().Perform();
            Thread.Sleep(2000);
        }
        public void SelectRecurBooking_Checkbox()
        {
            this.Map1.SelectRecurBooking.Click();
            
        }
        public void SelectDailyRecurringBooking()
        {
            
            this.Map1.SelectDailyRecurBooking.Click();
        }

   

        public void EnterFromToDateForDailyRecurring()
        {
            Thread.Sleep(2000);
            this.Map1.ToDateForDailyRecur.Clear();
            Thread.Sleep(3000);
            this.Map1.ToDateForDailyRecur.Click();
            Thread.Sleep(2000);
            //this.Map1.FromDateForDailyRecur.Click();
            //this.Map1.FromDateForDailyRecur.Clear();
            this.Map1.FromDateForDailyRecur.SendKeys("22/02/2018");
            //Thread.Sleep(2000);
            //this.Map1.ToDateForDailyRecur.Click();
            
            Thread.Sleep(2000);
            this.Map1.ToDateForDailyRecur.Clear();
            this.Map1.ToDateForDailyRecur.SendKeys("25/02/2018"); }

        public void SelectDailyRecurBookingDates()
        {
            Thread.Sleep(2000);
            this.Map1.ToDateForDailyRecur.Clear();
            Thread.Sleep(3000);
            this.Map1.ToDateForDailyRecur.Click();
            Thread.Sleep(2000);

            var today = DateTime.Today;
            var tomorrow = today.AddDays(2);
            string todayFrom = today.ToString("dd/MM/yyyy");
            string tomorrowTo = tomorrow.ToString("dd/MM/yyyy");
            
            this.Map1.FromDateForDailyRecur.SendKeys(todayFrom);
            Thread.Sleep(2000);
            this.Map1.ToDateForDailyRecur.Clear();
            this.Map1.ToDateForDailyRecur.SendKeys(tomorrowTo);
            }



        public void ShowTargetDate_ContinueBooking_recur()
        {
            this.Map1.ShowTargetDate_RecurBooking.Click();
            Thread.Sleep(2000);
            this.Map1.ContinueBooking_RecurBooking.Click();
        }

   //****FFTTest202**********
        public void FFTTest202_SelectAndContinueWithBooking()
        {
            Actions builder = new Actions(this.browser);
            builder.DoubleClick(this.Map1.FFT202Source_SelectDiaryCell).Build().Perform();
            Thread.Sleep(2000);
            this.Map1.ClickOnContinueWIthBooking.Click();
        }
        public void FFTTest202_DragandDrop()
        {
            Actions Drag = new Actions(this.browser);
            Drag.DragAndDrop(this.Map1.FFT202Source_SelectDiaryCell, this.Map1.FFT202Target_SelectDiaryCell);
            Thread.Sleep(2000);
            Drag.Build().Perform();
        }
        public void ClickOn_confirmMoveBooking()
        {
            Thread.Sleep(6000);
            this.Map1.FFT202ClickOn_ConfirmMoveBooking.Click();
            Thread.Sleep(3000);
        }
        public void FFTTest202_ClickOnMovedBooking_Time()
        {
            //Thread.Sleep(2000);
            Actions MovedBooking = new Actions(this.browser);
            MovedBooking.DoubleClick(this.Map1.FFT202Target_SelectDiaryCell).Build().Perform();
            Thread.Sleep(2000);
        }

   //*******FFTTest200******
        public void FFTTest200_SelectAndContinueWithBooking()
        {
            Actions action1 = new Actions(this.browser);
            action1.DoubleClick(this.Map1.FFT200Source_SelectDiaryCell).Build().Perform();
            Thread.Sleep(2000);
            this.Map1.ClickOnContinueWIthBooking.Click();
        }
         public void FFTTest200_DragandDrop_Chnageroom()
        {
            Actions Drag = new Actions(this.browser);
            Drag.DragAndDrop(this.Map1.FFT200Source_SelectDiaryCell, this.Map1.FFT200Targert_SelectDiaryCell);
            Thread.Sleep(2000);
            Drag.Build().Perform();
        }
        public void ClickConfirmChangeRoom()
        {
            this.Map1.FFT200TConfirm_ChangeRoom.Click();
            Thread.Sleep(5000);
            this.Map1.FFT200TConfirm_ChangeRoomSavedSuccessfully.Click();
            Thread.Sleep(5000);
        }
        public void ClickOnMovedBooking_Room()
        {
            Thread.Sleep(2000);
            Actions MovedBooking = new Actions(this.browser);
            MovedBooking.DoubleClick(this.Map1.FFT200Targert_SelectDiaryCell).Build().Perform();
            Thread.Sleep(2000);
        }
//******FFT46*******
        public void FFTTest46_SelectAndContinueWithBookingFirst()
        {
            Actions action1 = new Actions(this.browser);
            action1.DoubleClick(this.Map1.FFT46_Source_SelectDiaryCell).Build().Perform();
            Thread.Sleep(1000);
        }
        public void FFTTest46_EnterFromandToDateSlot_10111()
        {
            this.Map1.EnterFrom_TimeForBookingCreation.Clear();
            this.Map1.EnterFrom_TimeForBookingCreation.SendKeys("10:00 AM");
            Thread.Sleep(2000);
            this.Map1.EnterTo_TimeForBookingCreation.Clear();
            this.Map1.EnterTo_TimeForBookingCreation.SendKeys("11:00 AM");
        }
        public void FFTTest46_clickOncontinuewithbookingTime_1011()
        {
            this.Map1.ClickOnContinueWIthBooking.Click();
        }
        public void FFTTest46_SelectAndContinueWithBookingTarget()
        {
            Actions action1 = new Actions(this.browser);
            action1.DoubleClick(this.Map1.FFT46_Target_SelectDiaryCell).Build().Perform();
            Thread.Sleep(2000);
            this.Map1.EnterFrom_TimeForBookingCreation.SendKeys("12:00 PM");
            Thread.Sleep(2000);
            this.Map1.EnterTo_TimeForBookingCreation.Clear();
            this.Map1.EnterTo_TimeForBookingCreation.SendKeys("01:00 PM");
            this.Map1.ClickOnContinueWIthBooking.Click();
        }
        public void FFTTest46_DragandDrop()
        {
            Actions Drag = new Actions(this.browser);
            Drag.DragAndDrop(this.Map1.FFT46_Source_SelectDiaryCell, this.Map1.FFT46_Target_SelectDiaryCell);
            Thread.Sleep(2000);
            Drag.Build().Perform();
            Thread.Sleep(6000);
        }
//*********203*************
        public void FFTTest203_SelectAndContinueWithBookingFirst12to1PM()
        {
            Actions action1 = new Actions(this.browser);
            action1.DoubleClick(this.Map1.FFT203_SelectFirstDiaryCellForBooking_12to1PM).Build().Perform();
            Thread.Sleep(2000);
        }
        public void EnterFromandToDateSlot_12to1PM()
        {
            this.Map1.EnterFrom_TimeForBookingCreation.Clear();
            this.Map1.EnterFrom_TimeForBookingCreation.SendKeys("12:00 PM");
            Thread.Sleep(2000);
            this.Map1.EnterTo_TimeForBookingCreation.Clear();
            this.Map1.EnterTo_TimeForBookingCreation.SendKeys("01:00 PM");
        }
        public void FFTTest203_SelectAndContinueWithBookingFirst2PMto3PM()
        {
            Actions action1 = new Actions(this.browser);
            action1.DoubleClick(this.Map1.FFT203_SelectSdecondtDiaryCellForBooking_2PMto3PM).Build().Perform();
            Thread.Sleep(2000);
        }
        public void EnterFromandToDateSlot_2PMto3PM()
        {
            this.Map1.EnterFrom_TimeForBookingCreation.Clear();
            this.Map1.EnterFrom_TimeForBookingCreation.SendKeys("02:00 PM");
            Thread.Sleep(2000);
            this.Map1.EnterTo_TimeForBookingCreation.Clear();
            this.Map1.EnterTo_TimeForBookingCreation.SendKeys("03:00 PM");
        }
        public void FFTTest203_DragandDropto_NewTime()
        { 
            Actions Drag = new Actions(this.browser);
            Drag.DragAndDrop(this.Map1.FFT203_SelectFirstDiaryCellForBooking_12to1PM, this.Map1.FFT203_SelectSdecondtDiaryCellForBooking_2PMto3PM);
            Thread.Sleep(3000);
            Drag.Build().Perform();
       }
        public void FFTTest203_ChangeDateTime_ForMoveBooking()
        { 
          //this.Map1.EnterFromTime_ForMoveBooking.Clear();
          //this.Map1.EnterFromTime_ForMoveBooking.SendKeys("14/02/2018 12:30 PM");
          //Thread.Sleep(2000);
          //this.Map1.EnterToDateTime_ForMoveBooking.Clear();
          //this.Map1.EnterToDateTime_ForMoveBooking.SendKeys("14/02/2018 1:30 PM");

          var today = DateTime.Today;
          string todayFrom = today.ToString("dd/MM/yyyy");

          this.Map1.EnterFromTime_ForMoveBooking.Clear();
          this.Map1.EnterFromTime_ForMoveBooking.SendKeys(todayFrom + " 12:30 PM");
          Thread.Sleep(3000);
          this.Map1.EnterToDateTime_ForMoveBooking.Clear();
          this.Map1.EnterToDateTime_ForMoveBooking.SendKeys(todayFrom + " 01:30 PM");
          Thread.Sleep(3000);
        }

        
//***47*******
        //for updaing recurring booking
        public void FFT47_SwitchtorecurringBookingPanel()
        {
         browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='recurrenceDiv']/table[1]/tbody[1]/tr[1]/td[1]"));
         }
        public void FFT47_SelectEntireSeries()
        {
            this.Map1.FFT_47_SelectEntireSeries.Click();
            this.Map1.FFT_47_ClickOnOK_SelectENtireSeries.Click();
            Thread.Sleep(3000);
        }
        public void FFT47_SwitchtoDateTableOnDiary()
        {
            browser.SwitchTo().ActiveElement().FindElement(By.XPath("//*[@id='topbutntable']/tbody/tr/td[1]/table/tbody/tr/td[3]/table"));
        }
        public void FFT_47_SelectNextDate()
        { 
            this.Map1.FFT_47_ClickOnNextDate.Click();
        }
        //provide title for creating recurring Booking
        public void EnterTitleForRecurringBooking()
        {
            this.Map1.BookingTitle.SendKeys("RecurringBooking");
        }
        public void FFT_47_RecurBookingupdatedTitle()
        {
            this.Map1.BookingTitle.Clear();
            this.Map1.BookingTitle.SendKeys("Recurringupdatedtitle");
        }
        public void FFT_47_ValidateUpdatedBookingTitle()
        {
            IWebElement updatedTitle1 = this.Map1.BookingTitle;
            Thread.Sleep(2000);
            string value = updatedTitle1.GetAttribute("value");
            Console.WriteLine(value);
            Assert.IsTrue(value.Equals("Recurringupdatedtitle"), "Your Test Failed due to mismatch In the title");
        }

//*******49**********
        public void FFTTest49_SelectAndContinueWithBooking_UDF()
        {
            Actions action1 = new Actions(this.browser);
            action1.DoubleClick(this.Map1.FFT49_SelectDiarycellForUDF).Build().Perform();
           
        }


        

  

           public IWebDriver webDriver { get; set; }
        
       
        public OpenQA.Selenium.IWebDriver browser { get; set; }


        public OpenQA.Selenium.IWebDriver driver { get; set; }

       
    }
}






