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
        private const string UrlUnderTest = "http://azurestudentenrollmentdemo.cloudapp.net/";
        
        [TestMethod]
        public void CreateStudent()
        {
            //1.	Open the browser
            BrowserWindow browserWindow = BrowserWindow.Launch(UrlUnderTest);
            HomePage homePage = new HomePage(browserWindow);


            //2.	Select Create Student on the nav bar
            CreateStudentPage createStudentPage = homePage.ClickCreateStudentLink();

           //3.	Enter student details on the Create Student Page
            createStudentPage.FirstName.Text = "Steve";
            createStudentPage.LastName.Text = "Gray";
            createStudentPage.EnrolmentDate.Text = "01/01/2015";

            //4.	Click Create
            homePage = createStudentPage.ClickCreate();
            
            
            //5.	Assert the student is shown on the homepage 
            //A future post will deal with this not being a very good test
            Assert.That(homePage.GetStudentRowText(1), Is.EqualTo("Gray Steve 1/1/2015 Edit | Details | Delete "));
        }
    }
}
