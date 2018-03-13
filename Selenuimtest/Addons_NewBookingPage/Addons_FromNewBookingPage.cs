using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;

namespace UnitTestProjectsummary.Addons_NewBookingPage
{
   public class Addons_FromNewBookingPage
    {
       public Addons_FromNewBookingPage(IWebDriver browser)
       { 
           this.browser = browser;
       }

       public Addons_FromNewBookingPage()
        {
       }
       public AddonsCreateBookingPageElements AddonMapBooking
       {
           get
           {
               return new AddonsCreateBookingPageElements(this.browser);
           }
       }
       public void CliCkOnAddAddon_FromBookingSummary()
       {
           this.AddonMapBooking.BookingSummaryClickOnAddAddon.Click();

       }
       public void GetAllAddonTextFromDifferentCatagory()
       {

           IReadOnlyCollection<IWebElement> ec = browser.FindElements(By.ClassName("fieldset_addons"));
           IList<IWebElement> all = new List<IWebElement>(ec);
           foreach (var item in all)
           {
               Console.WriteLine(item.Text);
               Console.WriteLine("\n");
           }
       }
       public void AddAddon_Cake_BySearch()
       {
           this.AddonMapBooking.Add_AddonForSearch.SendKeys("Cake");
           Thread.Sleep(2000);
           this.AddonMapBooking.CLickOnAddonSearchButton.Click();
           Thread.Sleep(2000);
           this.AddonMapBooking.SelectFirstAddon_AddonSearch_Cake.Click();
       }
       public void add_addon_Bread_VerifyStock()
       {
           this.AddonMapBooking.Add_AddonForSearch.SendKeys("Bread (Garlic)");
           Thread.Sleep(2000);
           this.AddonMapBooking.CLickOnAddonSearchButton.Click();
           Thread.Sleep(2000);
           this.AddonMapBooking.SelectFirstAddon_AddonSearch_Cake.Click();
       }
       public void FFT256_add_addon_Milk()
       {
           this.AddonMapBooking.Add_AddonForSearch.SendKeys("Milk / Lait");
           Thread.Sleep(2000);
           this.AddonMapBooking.CLickOnAddonSearchButton.Click();
           Thread.Sleep(2000);
           this.AddonMapBooking.SelectFirstAddon_AddonSearch_Cake.Click();
       }
       public void FFT256_add_addon_Juice()
       {
           this.AddonMapBooking.Add_AddonForSearch.Clear();
           this.AddonMapBooking.Add_AddonForSearch.SendKeys("Juice / Jus");
           Thread.Sleep(2000);
           this.AddonMapBooking.CLickOnAddonSearchButton.Click();
           Thread.Sleep(2000);
           this.AddonMapBooking.SelectFirstAddon_AddonSearch_Cake.Click();
       }
       public void FFT256_add_addon_Tea()
       {
           this.AddonMapBooking.Add_AddonForSearch.SendKeys("Tea / Thé");
           Thread.Sleep(2000);
           this.AddonMapBooking.CLickOnAddonSearchButton.Click();
           Thread.Sleep(2000);
           this.AddonMapBooking.SelectFirstAddon_AddonSearch_Cake.Click();
       }
       public void FFT_263_Add_addon_CheeseTray()
       {
           this.AddonMapBooking.Add_AddonForSearch.SendKeys("Cheese Tray / Plateau de fromages");
           Thread.Sleep(2000);
           this.AddonMapBooking.CLickOnAddonSearchButton.Click();
           Thread.Sleep(2000);
           this.AddonMapBooking.SelectFirstAddon_AddonSearch_Cake.Click();
       }
       public void AddonQuantity5()
       {
           //Actions action = new Actions(browser);
           //action.MoveToElement(this.AddonMapBooking.AddonQuantity);
           //action.Click().DoubleClick();
           //action.SendKeys("5");

           this.AddonMapBooking.AddonQuantity.Clear();
           Thread.Sleep(2000);
           this.AddonMapBooking.AddonQuantity.SendKeys("5");
       }
       public void EditAddon()
       {
           this.AddonMapBooking.clickOnEditAddonQuantity.Click();
           Thread.Sleep(2000);
           this.AddonMapBooking.UpdateNewAddonQuantity.Clear();
           this.AddonMapBooking.UpdateNewAddonQuantity.SendKeys("3");
           Thread.Sleep(1000);
           this.AddonMapBooking.ClickOnSaveUpdatedAddon.Click();

       }

       public void AddonQuantity3()
       {
           this.AddonMapBooking.AddonQuantity.Clear();
           Thread.Sleep(2000);
           this.AddonMapBooking.AddonQuantity.SendKeys("3");
       }
       public void AcceptAddonNotificationMessageAndGetHeaderText()
       {
           var ssg=this.AddonMapBooking.GetAddonNotificationMessageHeader.Text;
           Console.WriteLine("Addon Notification Message Header Is=" + ssg);
           Thread.Sleep(2000);
           this.AddonMapBooking.AcceptAddonNotificationMessage.Click();
       }
       
       public void ClickOnAddAddonButton()
       {
           this.AddonMapBooking.AddSelectedAddons.Click();
       }
       public void VerifyAddAddonButtonIsEnabled()
       { 
           IWebElement AddButton=this.AddonMapBooking.AddSelectedAddons;
           Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(AddButton.Enabled);
       }

       public void GetAddedAddonName()
       {
           var addonname = this.AddonMapBooking.VerifyAddedAddonName.Text;
           Console.WriteLine("AddonName= " + addonname);
       }

       public void SummaryButtonFromAddonPageIsEnabled()
       {
           Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(this.AddonMapBooking.GoToSummaryFromAddons.Enabled);
       }
       public void clickOnGoToSummaryFromAddonPage()
       {
           this.AddonMapBooking.GoToSummaryFromAddons.Click();
       }

       public void verfiy_AddonCuttOffMessage_Enabled()
       {
           NUnit.Framework.Assert.IsTrue(this.AddonMapBooking.VerifyAddonCutt_Message.Enabled);
       }









       public IWebDriver browser { get; set; }

       
    }
}
