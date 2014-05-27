using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using StudentEnrollment.SeleniumTests.Pages;
using Assert = NUnit.Framework.Assert;

namespace StudentEnrollment.SeleniumTests
{
    [TestClass]
    public class DemoTests
    {
        private HomePage _homePage;
        private ChromeDriver _browserWindow;
        
        [TestInitialize]
        public void TestInitialize()
        {
              _browserWindow = new ChromeDriver();
              _browserWindow.Navigate().GoToUrl("http://azurestudentenrollmentdemo.cloudapp.net/");
              _homePage =  new HomePage(_browserWindow);
          }
        
        [TestMethod]
        public void CreateStudent()
        {
            CreateStudentPage createStudentPage = _homePage.ClickCreateStudent();
            createStudentPage.FirstName.SendKeys("Steve");
            createStudentPage.LastName.SendKeys("Gray");
            createStudentPage.EnrolmentDate.SendKeys("01/01/2015");
            createStudentPage.ClickCreate();
            Assert.That(_homePage.GetStudentRow(1).Text, Is.EqualTo("Gray Steve 1/1/2015 Edit | Details | Delete"));
        }

         //Run after each test
        [TestCleanup]
        public void TestCleanup()
        {
             _browserWindow.Quit();
        }

        //Run Once after all tets have run
        [ClassCleanup]
        public static void ClassCleanup()
        {
        }
      
    }
}
