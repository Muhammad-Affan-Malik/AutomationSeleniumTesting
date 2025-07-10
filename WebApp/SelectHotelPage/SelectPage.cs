using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationSeleniumTesting.WebApp.SelectHotelPage
{
    internal class SelectPage : CorePage
    {
        #region Locators
        By selectHotelRadioBtn = By.Id("radiobutton_0");
        By continueBtn = By.Id("continue");
        By cancelBtn = By.Id("cancel");
        #endregion
        public void SelectHotel()
        {
            driver.FindElement(selectHotelRadioBtn).Click();
            driver.FindElement(continueBtn).Click();
        }
    }
}
