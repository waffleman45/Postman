using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace PageActions
{
    public class PageObjectsAndActions
    {
        public object explicitWait { get; private set; }

        // Log the user in if the web elements are found.
        public void LogUserIn()
        {
            try
            {
                // Initialize the driver object for use, and set the path to the driver for Chrome.
                ChromeDriver chromeDriver = new ChromeDriver(@"C:\Users\bbmoore\Documents\Visual Studio 2015\Projects\ICPAutomationPrototype\Drivers");
                // Initialize an explicit wait.  The project executes fast and this gives the driver time to find the elements.
                WebDriverWait explicitWait = new WebDriverWait(chromeDriver, new TimeSpan(0, 0, 0, 0, 5000));
                // Navigate the driver object to the BB Transact page.
                chromeDriver.Navigate().GoToUrl(@"https://qa-web.icpdev.io/users/app/#/login");
                // Find the username field.
                explicitWait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name(@"userName")));
                // Send the username to the field.
                chromeDriver.FindElement(By.Name(@"userName")).SendKeys(@"brian@email.com");
                // Find the password field.
                explicitWait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name(@"password")));
                // Send the password to the field.
                chromeDriver.FindElement(By.Name(@"password")).SendKeys(@"Test@1234");
                // Find the 'sign in' button.
                explicitWait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id(@"sign-in-button")));
                // Click the 'sign in' button to log the user in.
                chromeDriver.FindElement(By.Id(@"sign-in-button")).Click();
                // Find the 'My Profile' link.
                explicitWait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id(@"myProfile")));
                // Click the 'My Profile' link.
                chromeDriver.FindElement(By.Id(@"myProfile")).Click();
                Thread.Sleep(5000);
                // Find the 'My Accounts' link.
                explicitWait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id(@"myAccounts")));
                // Click the 'My Accounts' link.
                chromeDriver.FindElement(By.Id(@"myAccounts")).Click();
                Thread.Sleep(5000);
                // Find the 'Logout' link.
                explicitWait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id(@"logout")));
                // Click the 'Logout' link.
                chromeDriver.FindElement(By.Id(@"logout")).Click();
            }
            catch (Exception exc) 
            {
                Console.WriteLine(exc.Message);
            }
        }

        // Click on the 'My Profile' link if the web elements are found.
        public void ClickMyProfile()
        {
            try
            {
                // Initialize the driver object for use, and set the path to the driver for Chrome.
                ChromeDriver chromeDriver = new ChromeDriver(@"C:\Users\bbmoore\Documents\Visual Studio 2015\Projects\ICPAutomationPrototype\Drivers");
                // Initialize an explicit wait.  The project executes fast and this gives the driver time to find the elements.
                WebDriverWait explicitWait = new WebDriverWait(chromeDriver, new TimeSpan(0, 0, 0, 0, 500));
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        // Click on the 'My Accounts' link if the web elements are found.
        public void ClickMyAccounts()
        {
            try
            {
                // Initialize the driver object for use, and set the path to the driver for Chrome.
                ChromeDriver chromeDriver = new ChromeDriver(@"C:\Users\bbmoore\Documents\Visual Studio 2015\Projects\ICPAutomationPrototype\Drivers");
                // Initialize an explicit wait.  The project executes fast and this gives the driver time to find the elements.
                WebDriverWait explicitWait = new WebDriverWait(chromeDriver, new TimeSpan(0, 0, 0, 0, 500));
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        // Log the user out.
        public void LogUserOut()
        {
            try
            {
                // Initialize the driver object for use, and set the path to the driver for Chrome.
                ChromeDriver chromeDriver = new ChromeDriver(@"C:\Users\bbmoore\Documents\Visual Studio 2015\Projects\ICPAutomationPrototype\Drivers");
                // Initialize an explicit wait.  The project executes fast and this gives the driver time to find the elements.
                WebDriverWait explicitWait = new WebDriverWait(chromeDriver, new TimeSpan(0, 0, 0, 0, 500));

                explicitWait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id(@"logout")));
                chromeDriver.FindElement(By.Id(@"logout")).Click();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
