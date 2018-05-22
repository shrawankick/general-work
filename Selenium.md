new console applacation 
add pakages 
---------------------------------------------
Packages

Install-Package Selenium.WebDriver -Version 3.11.0
Install-Package Selenium.Chrome.WebDriver -Version 2.37.0
Install-Package NUnit -Version 3.10.1
Install-Package NUnit3TestAdapter -Version 3.10.0 

-------------------------------
other packages 
<packages>
  <package id="Ghpr.Core" version="0.7.0" targetFramework="net452" />
  <package id="Ghpr.NUnit" version="0.6.0" targetFramework="net452" />
  <package id="Newtonsoft.Json" version="10.0.3" targetFramework="net452" />
  <package id="NUnit" version="3.7.1" targetFramework="net452" />
  <package id="NUnit.Engine" version="3.7.0" targetFramework="net452" />
  <package id="NUnitTestAdapter" version="2.1.1" targetFramework="net452" />
  <package id="ReportUnit" version="1.5.0-beta1" targetFramework="net452" />
  <package id="Selenium.Firefox.WebDriver" version="0.18.0" targetFramework="net452" />
  <package id="Selenium.Support" version="3.5.1" targetFramework="net452" />
  <package id="Selenium.WebDriver" version="3.5.1" targetFramework="net452" />
  <package id="Selenium.WebDriver.ChromeDriver" version="2.31.0" targetFramework="net452" />
</packages>



Xpath
    http://scraping.pro/res/xpath-cheat/xpath_css_dom_ref.pdf
    https://devhints.io/xpath

driver.FindElement(By.XPath("//*[contains(@id,'btnNewNoteBook')]"));


public string popupWindowHandle;

creating window handle
			//string windowHandle = driver.CurrentWindowHandle;
            //IWebElement element =
            //    driver.FindElement(
            //        By.XPath(
            //            "//*[@id=\"ruleGroup_ctl01_hypAddRules_input\"]"));

            ////*[@id="ruleGroup_ctl01_hypAddRules_input"]
            //string popupWindowHandle =
            //        (new PopupWindowFinder(
            //                driver)).Click(element);

popup control
            //driver.SwitchTo().Window(popupWindowHandle);
			
			//code 
			
			 driver.SwitchTo().Window(windowHandle);
			
finding frame		
			driver.SwitchTo().Frame("radCustomFieldsWindow");//id last value 
			driver.SwitchTo().ParentFrame();
			
			 driver.SwitchTo().ActiveElement();
			 
			 
			 driver.FindElement(By.XPath("//li[text()=\"Contacts\"]")).Click();
			 
switching to mainhandle 
			 
			 var mainWindowHandle = driver.CurrentWindowHandle;

            popupWindowHandle = Utils.GetPopupHandleAfterClickWithId(driver, "eventCrtl_hypInviteAttendees_input");

handle examples
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | meetingAttendeesWindow | ]]
            driver.SwitchTo().Window(popupWindowHandle);
			
			
finding using sapn 			
			//span[@class='rpText' and contains(text(),'HRM')]
			//span[contains(text() , 'Log Off')]
			
			
nunit test console 			
			nunit-console /fixture:NUnit.Tests.AssertionTests nunit.tests.dll
			
			
			nunit3-console /fixture:SeleniumFirst.Tests.ApplicationButtons SeleniumFirst.exe
			
			nunit3-console --test:SeleniumFirst.Test.Desktop.Notes.NotesNewNote SeleniumFirst.exe
			
						
						nunit3-console --test:SeleniumFirst.Test SeleniumFirst.exe
						nunit3-console --test:SeleniumFirst.Test.CRM SeleniumFirst.exe
						
						
						
						Thread.Sleep(1000);
javascript click events 
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", element);
            Thread.Sleep(1000);
			
            driver.FindElement(By.XPath("//*/div[@class='rfdSelectBox rfdSelectBox_Default rfdSelectBoxDropDown']/ul/li[2]")).Click();
			
			Thread.Sleep(1000);
            Utils.javascriptClickWithXpath(driver, "//*/div[@class='rfdSelectBox rfdSelectBox_Default rfdSelectBoxDropDown']/ul/li[2]");
            Thread.Sleep(1000);
						
wait events 					
			var wait =
                new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(
                w => driver
                    .FindElements(
                        By.LinkText(LinkedText))
                    .ToList()
                    .Any(o => o.Displayed));
            return wait;


javascript click wait events 
	protected IWebDriver driver = new ChromeDriver();
	var element = driver.FindElement(By.CssSelector(LinkedTextToclick));
						Thread.Sleep(1000);
						((IJavaScriptExecutor) driver).ExecuteScript("arguments[0].click()", element);
					Thread.Sleep(1000);
					var wait =
					new WebDriverWait(driver, new TimeSpan(0, 0, 5));
					wait.Until(
	w => driver
	.FindElements(
	By.LinkText(LinkedText))
	.ToList()
	.Any(o => o.Displayed));
	return wait;	
alert 
  accept the alert 
  driver.SwitchTo().Alert().Accept();
 
click with dropdownlist 
  we can use this for ddl 
     driver.FindElement(By.CssSelector("span.rfdSelectText")).Click();        
     driver.FindElement(By.XPath("//*[@id=\"ddlUsers\"]/option[2]")).Click();
	 ------------------

    How to slow the test till the element loads in the page 

     private IWebDriver _driver;

        public IWebDriver driver
        {
            get
            {
                Thread.Sleep(500);
                return _driver;
            }

            set
            { _driver = value; }
        }

add this in base calss 


xpath
//a[contains(@id,'ctl04_hypGetDetails')]
            key,"value"

 #region screenshot 
        ///// <summary>
        ///// </summary>
        //protected void screenShortMethod()
        //{
        //    var firingDriver = new EventFiringWebDriver(new ChromeDriver());

        //    // firingDriver.ExceptionThrown += firingDriver_GetTxtOnException;
        //    firingDriver.ExceptionThrown += firingDriver_TakeScreenshotOnException;
        //    driver = firingDriver;
        //}

        ///// <summary>
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e">Exception</param>
        //protected void firingDriver_TakeScreenshotOnException(object sender, WebDriverExceptionEventArgs e)
        //{
        //    var timestamp = DateTime.UtcNow.ToString("yyyy-MM-ddTHH-mm-ss.fff");
        //    var filePath = "C:\\Users\\shraw\\Desktop\\Selenium_Screenshort\\"; //"C:\\temp\\";
        //    var expname = e.ThrownException.Message;
        //    var LineNumber = e.ThrownException.StackTrace;
        //    var test = sender.ToString();
        //    var exceptionData = e.ThrownException;
        //    var msg = expname.Substring(0, expname.IndexOf("\n"));
        //    var fileName = filePath + msg + "_Exception-" + timestamp + ".txt";

        //    if (expname.Contains("\n"))
        //    {
        //        //var msg = expname.Substring(0, expname.IndexOf("\n"));
        //        // add screenshort
        //        driver.TakeScreenshot().SaveAsFile(filePath + msg + "_Exception-" + timestamp + ".png", ImageFormat.Png);
        //        //adds text file 
        //        File.WriteAllText(fileName, exceptionData.ToString());
        //    }
        //    // add screenshort 
        //    driver.TakeScreenshot().SaveAsFile(filePath + expname + "_Exception-" + timestamp + ".png", ImageFormat.Png);
        //    //adds text file 
        //    File.WriteAllText(fileName, exceptionData.ToString());
        //}
#endregion
          