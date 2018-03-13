﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectsummary.WebAppDiary
{
    public class DiaryPageElements 
    {

        private readonly IWebDriver browser;
        public DiaryPageElements(IWebDriver browser)
        {
            this.browser = browser;
        }

        public DiaryPageElements()
        {
            // TODO: Complete member initialization
        }

       public IWebElement LogoutButton
        {
            get
            {
                return this.browser.FindElement(By.Id("ctl00_lblLogout"));
            }   
        }

        
       public IWebElement LoggedinUser
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_lblLogin"));
           }
       }

       public IWebElement RendezvousLogo
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_imgNFSLogo"));
           }
       }
       public IWebElement SelectDiaryCell
       {
           get
           { 
             return this.browser.FindElement(By.Id("Cell013013"));
           }
       }
       public IWebElement FFT47_SelectDiaryCellRecurBooking
       {
           get
           {
               return this.browser.FindElement(By.Id("Cell034110"));
           }
       }

       public IWebElement SelectRecurBooking
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_chkRecurrence"));
           }
       }
         public IWebElement SelectDailyRecurBooking
       {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_rcRepeat_rbtDaily"));
           }
       }
        
        
         
//From Diary Page
         public IWebElement FromDateForDailyRecur
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_rcRepeat_dtFrom_dateInput"));
             }
         }
         public IWebElement ToDateForDailyRecur
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_rcRepeat_dtTo_dateInput"));
             }
         }
           public IWebElement ShowTargetDate_RecurBooking
         {
             get
             {
                 return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_rcRepeat_btnShowTargetDates"));
             }
         }
           public IWebElement ContinueBooking_RecurBooking
           {
               get
               {
                   return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnCreate"));
               }
           }

  //****FFT202***
            public IWebElement FFT202Source_SelectDiaryCell
           {
               get
               {
                   return this.browser.FindElement(By.Id("Cell02410"));
               }
           }
            public IWebElement FFT202Target_SelectDiaryCell
           {
               get
               {
                   return this.browser.FindElement(By.Id("Cell041117"));
               }
           }

            public IWebElement FFT202SwicthToFrame_COnfirmBooking
           {
               get
               {
                   return this.browser.FindElement(By.Id("frmPnlMove"));
               }
           }
            public IWebElement FFT202ClickOn_ConfirmMoveBooking
           {
               get
               {
                   return this.browser.FindElement(By.XPath("//input[@id='rcRepeat_btRepeats']"));
               }
           }
//**************FFT200************
        public IWebElement FFT200Source_SelectDiaryCell
        {
             get
            {
                 return this.browser.FindElement(By.Id("Cell07230"));      
            }
        }

        public IWebElement FFT200Targert_SelectDiaryCell
        {
            get
            {
                return this.browser.FindElement(By.Id("Cell09640"));
            }
        }
        public IWebElement FFT200TConfirm_ChangeRoom
        {
            get
            {
                return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnChangeRoomOK"));
            }
        }
            public IWebElement FFT200TConfirm_ChangeRoomSavedSuccessfully
        {
            get
            {
                return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnChangeRoomCancel"));
            }
        }
 //**********EndFFT200*************
//***********FFT203********DragandDrop BreakdownTimeOverlap
            public IWebElement FFT203_SelectFirstDiaryCellForBooking_12to1PM
            {
                get
                {
                    return this.browser.FindElement(By.Id("Cell084312"));
                }
            }
            public IWebElement FFT203_SelectSdecondtDiaryCellForBooking_2PMto3PM
            {
                get
                {
                    return this.browser.FindElement(By.Id("Cell086314"));
                }
            }
            public IWebElement EnterFromTime_ForMoveBooking
            {
                get
                {
                    return this.browser.FindElement(By.Id("rcRepeat_ftdCopyMove_dtFrom_dateInput"));
                }
            }
            public IWebElement EnterToDateTime_ForMoveBooking
            {
                get
                {
                    return this.browser.FindElement(By.Id("rcRepeat_ftdCopyMove_dtTo_dateInput"));
                }
            }


  //**********FFT46*********
            public IWebElement FFT46_Source_SelectDiaryCell
            {
                get
                {
                    return this.browser.FindElement(By.Id("Cell010010"));
                }
            }
            public IWebElement FFT46_Target_SelectDiaryCell
            {
                get
                {
                    return this.browser.FindElement(By.Id("Cell012012"));
                }
            }
            public IWebElement EnterFrom_TimeForBookingCreation
            { 
                get
                {
                     return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_dtDiaryFromTime_dateInput"));
                }
            }
            public IWebElement EnterTo_TimeForBookingCreation
            {
                get
                {
                    return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_dtDiaryToTime_dateInput"));
                }
            }
         
            
  //**********EndFFT46*************
  //***************FFT478*******
            public IWebElement FFT_47_SwitchtoRecuringBookingPanel
            {
                get
                {
                    return this.browser.FindElement(By.Id("//*[@id='recurrenceDiv']"));
                }
            }
            public IWebElement FFT_47_SelectEntireSeries
            {
                get
                {
                    return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_rbtnEntireSeries"));
                }
            }
            public IWebElement FFT_47_ClickOnOK_SelectENtireSeries
            {
                get
                {
                    return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnOkay"));
                }
            }
          public IWebElement FFT_47_ClickOnNextDate
            {
                get
                {
                    return this.browser.FindElement(By.Id("lbtnRight"));
                }
            }
        

 //***************EndFFT478*******     
  
//*******FFT49*********
          public IWebElement FFT49_SelectDiarycellForUDF
          {
              get
              {
                  return this.browser.FindElement(By.Id("Cell058210"));
              }
          
          }
          public IWebElement BookingTitle
          {
              get
              {
                  return this.browser.FindElement(By.Name("ctl00$MainContentPlaceHolder$txtTitle"));
                                                            
              }
          }
        public IWebElement ClickOnContinueWIthBooking
         {
           get
           {
               return this.browser.FindElement(By.Id("ctl00_MainContentPlaceHolder_btnCreate"));
           }
         }
//****FFT
      



       //public IWebDriver browser { get; set; }
    

    }
}
