using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using StudentEnrollment.CUITests.Pages;
using Assert = NUnit.Framework.Assert;

namespace StudentEnrollment.CUITests
{
    [CodedUITest]
    public class DemoTest
    {
        private BrowserWindow _browserWindow;
        private HomePage _homePage;
        private const string UrlUnderTest = "http://azurestudentenrollmentdemo.cloudapp.net/";

        [TestInitialize]
        public void TestInitialize()
        {
            //Load the browser 
            _browserWindow = BrowserWindow.Launch(UrlUnderTest);
            _homePage = new HomePage(_browserWindow);
        }

        

        [TestMethod]
        public void TestMethod1()
        {
            CreateStudentPage createStudentPage = _homePage.ClickCreateStudentLink();
            createStudentPage.FirstName.Text = "Steve";
            createStudentPage.LastName.Text = "Gray";
            createStudentPage.EnrolmentDate.Text = "01/01/2015";
            createStudentPage.ClickCreate();
            Assert.That(_homePage.GetStudentRowText(1), Is.EqualTo("Gray Steve 1/1/2015 Edit | Details | Delete "));
            
        }
    }
}
