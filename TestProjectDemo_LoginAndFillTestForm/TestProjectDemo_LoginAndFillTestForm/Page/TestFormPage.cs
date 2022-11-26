using OpenQA.Selenium;
using TestProjectDemo_LoginAndFillTestForm.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver = TestProjectDemo_LoginAndFillTestForm.Driver.WebDriver;
using OpenQA.Selenium.Support.UI;

namespace TestProjectDemo_LoginAndFillTestForm.Page
{
    public class TestFormPage
    {
        private IWebDriver driver = WebDriver.Instance;

       
        public void SelectOptions(string text)
        {
            SelectElement Country = new SelectElement(driver.FindElement(By.Id("country")));
            Country.SelectByText(text);
        }

        public IWebElement Address => driver.FindElement(By.Id("address"));
        public IWebElement Email => driver.FindElement(By.Id("email"));
        public IWebElement Phone => driver.FindElement(By.Id("phone"));
        public IWebElement SaveButton => driver.FindElement(By.Id("save"));
        public IWebElement LogoutButton => driver.FindElement(By.Id("logout"));

    }
}
