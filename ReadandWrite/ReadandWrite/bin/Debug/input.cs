using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;

namespace SeleniumFirst.Test
{

    [TestFixture]
    public class UsersImportExport
    {
        IWebDriver driver = new ChromeDriver();

        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void Initialize()
        {
            //Navigate to Google Page
            driver.Navigate().GoToUrl(
                ConfigurationManager.AppSettings["webUrl"]);
            Utils.Login(driver);
            Console.WriteLine("Opened URL");
            verificationErrors = new StringBuilder();

        }

        [TearDown]
        public void Cleanup()
        {
            Utils.LogOff(driver);
            driver.Close();
            Console.WriteLine("Closed the Browser");
        }

        [Test, Category("DesktopUsers")]
        public void TheUsersImportExportTest()
        {
            Utils.ClickOnApplicationCategory(driver, "Desktop");
            Utils.ClickOnApplication(driver, "Users");
            driver.SwitchTo().Frame("aframe");
            driver.FindElement(By.LinkText("Import/Export")).Click();
            driver.FindElement(By.Id("eiImportCsv_imgDetails")).Click();
            //driver.FindElement(By.LinkText("Close")).Click();
            driver.FindElement(By.Id("eiImportVcard_imgDetails")).Click();
            //driver.FindElement(By.XPath("//form/div[6]/table/tbody/tr[1]/td[2]/a")).Click();
            driver.FindElement(By.Id("eiImportLDAP_imgDetails")).Click();
            //driver.FindElement(By.XPath("//div[5]/table/tbody/tr/td[2]/a[@class=\"rtCloseButton\"]")).Click();
            driver.FindElement(By.Id("eiImportCsv_divTextBlock")).Click();
            driver.FindElement(By.Id("btnImport_input")).Click();
            driver.FindElement(By.XPath("//*[@id=\"hypCancel_input\"]")).Click();
            driver.FindElement(By.Id("eiExport_divTextBlock")).Click();
            driver.FindElement(By.Id("radExportCsv")).Click();
            driver.FindElement(By.Id("btnContinueExport_input")).Click();
            driver.FindElement(By.Id("hypCancel_input")).Click();
            driver.SwitchTo().ParentFrame();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
