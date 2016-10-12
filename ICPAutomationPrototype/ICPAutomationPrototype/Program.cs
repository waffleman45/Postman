using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using PageActions;

namespace ICPAutomationPrototype
{
    class AutomationFrontEnd
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Running UI tests on Chrome...");
            PageObjectsAndActions action = new PageObjectsAndActions();
            action.LogUserIn();
            Console.ReadKey();
        }
    }
}
