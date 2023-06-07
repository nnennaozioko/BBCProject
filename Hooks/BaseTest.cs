using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;
using System.Reflection;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace BBCProject.Hooks
{
    [Binding]
    public class BaseTest
    {

        public ExtentReports extent;
        public ExtentTest test;
        
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            String reportPath = projectDirectory + "//index.html";
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            extent = new ExtentReports();  // you create extent Object
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Host Name", "Local host");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("Username", "Nelly");


            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            
             driver.Manage().Window.Maximize();
            var chromeOptions = new ChromeOptions();
            //chromeOptions.AddArguments(new List<string>() { "headless" });
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);


        }



        [AfterScenario]
        public void AfterScenario()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = TestContext.CurrentContext.Result.StackTrace;


            DateTime time = DateTime.Now;
            String fileName = "ScreenShot_" + time.ToString("h_mm_ss") + ".png";

            if (status == TestStatus.Failed)
            {
                test.Fail("Test failed", CaptureScreenshot(driver, fileName)); //Attach screenshot to show that test //note
                test.Log(Status.Fail, "test failed with logtrace" + stackTrace); // note
            }

            else if (status == TestStatus.Passed)
            {

            }
            //extent.Flush();
            //driver.Quit();
        }

        public MediaEntityModelProvider CaptureScreenshot(IWebDriver driver, String screenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            var screenshot = ts.GetScreenshot().AsBase64EncodedString;
            //How to convert Asbase64EncodedStinr to medis entity

            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenShotName).Build();

        }

        [AfterScenario]
        public void AfterScenario2()
        {
            driver.Quit();
            Kill("chromedriver");
        }

        public static void Kill(string processName)
        {
            try
            {

                Process[] runningProcesses = Process.GetProcesses();
                foreach (var process in runningProcesses)
                {
                    if (process.ProcessName.Contains(processName))
                    {
                        process.Kill();

                    }
                }
            }
            catch (Exception)
            {

            }

        }

    }
}