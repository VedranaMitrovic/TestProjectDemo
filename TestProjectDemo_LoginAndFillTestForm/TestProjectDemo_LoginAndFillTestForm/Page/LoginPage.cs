using OpenQA.Selenium;
using TestProjectDemo_LoginAndFillTestForm.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver = TestProjectDemo_LoginAndFillTestForm.Driver.WebDriver;

namespace TestProjectDemo_LoginAndFillTestForm.Page
{
    public class LoginPage
    {
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement FullName => driver.FindElement(By.Id("name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login"));

        public void LoginOnPage(string name, string password)
        {
            FullName.SendKeys(name);
            Password.SendKeys(password);
            LoginButton.Click();
        }
    }
}
