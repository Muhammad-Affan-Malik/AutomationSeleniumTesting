using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationSeleniumTesting
{
    internal class LoginPage : CorePage
    {
        public void Login(string url, string username, string password)
        {


            driver.Url = url;
            driver.FindElement(By.Id("username")).SendKeys(username);
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.Id("login")).Click();


        }
    }
}
