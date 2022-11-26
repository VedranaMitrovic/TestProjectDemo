using NUnit.Framework;
using OpenQA.Selenium;
using TestProjectDemo_LoginAndFillTestForm.Driver;
using TestProjectDemo_LoginAndFillTestForm.Page;
using WebDriver = TestProjectDemo_LoginAndFillTestForm.Driver.WebDriver;

namespace TestProjectDemo_LoginAndFillTestForm
{
    public class Tests
    {
        private LoginPage loginPage;
        private TestFormPage testFormPage;

        [SetUp]
        public void BeforeScenario()
        {
            WebDriver.Initialize();
            loginPage = new LoginPage();
            testFormPage= new TestFormPage();
        }

        [TearDown]
        public void AfterScenario()
        {
            WebDriver.CleanUp();
        }


        [Test]
        public void TC01_FillTestFormWithValidData_AllDataShouldBeDisplayedInTesstForm()
        {
            Login("Vedrana", "12345");
           
            testFormPage.SelectOptions("Serbia");
            testFormPage.Address.SendKeys("Beograd 2022");
            testFormPage.Email.SendKeys("vedrana@mail.com");
            testFormPage.Phone.SendKeys("063123456");
            testFormPage.SaveButton.Click();
            testFormPage.LogoutButton.Click();

        }


        public void Login(string name, string pass)
        {
            loginPage.LoginOnPage(name, pass);
           
        }
    }
}