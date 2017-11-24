
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
	 -------------------
  