using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationSeleniumTesting
{
    internal class SearchPage : CorePage
    {
        #region Locators
        By locationDropDown = By.Id("location");
        By hotelsDropDown = By.Id("hotels");
        By roomTypeDropDown = By.Id("room_type");
        By roomNumberDropDown = By.Id("room_nos");
        By checkInDateTxt = By.Id("datepick_in");
        By checkOutDateTxt = By.Id("datepick_out");
        By adultCountDropDown = By.Id("adult_room");
        By childCountDropDown = By.Id("child_room");
        By searchBtn = By.Id("Submit");
        By resetBtn = By.Id("Reset");
        #endregion

        public void SearchHotel()
        {
            driver.FindElement(locationDropDown).SendKeys("Sydney");
            driver.FindElement(hotelsDropDown).SendKeys("Hotel Creek");
            driver.FindElement(roomTypeDropDown).SendKeys("Standard");
            driver.FindElement(roomNumberDropDown).SendKeys("1 - One");
            driver.FindElement(checkInDateTxt).SendKeys("01/08/2025");
            driver.FindElement(checkOutDateTxt).SendKeys("02/08/2025");
            driver.FindElement(adultCountDropDown).SendKeys("1 - One");
            driver.FindElement(childCountDropDown).SendKeys("0 - None");
            driver.FindElement(searchBtn).Click();
        }
    }
}
