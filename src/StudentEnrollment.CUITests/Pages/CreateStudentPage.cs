using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace StudentEnrollment.CUITests
{
    public class CreateStudentPage
    {
        private readonly BrowserWindow _browser;
        private HtmlInputButton _createStudent;
        private HtmlEdit _enrolmentDate;
        private HtmlEdit _lastName;
        private HtmlEdit _firstName;

        public CreateStudentPage(BrowserWindow browserWindow)
        {
            _browser = browserWindow;
        }

        public HtmlEdit FirstName
        {
            get
            {
                _firstName = new HtmlEdit(_browser);
                _firstName.SearchProperties[HtmlControl.PropertyNames.Id] = "student-firstname";
                return _firstName;
            }
        }
        public HtmlEdit LastName
        {
            get
            {
                _lastName = new HtmlEdit(_browser);
                _lastName.SearchProperties[HtmlControl.PropertyNames.Id] = "student-lastname";
                return _lastName;
            }
        }

        public HtmlEdit EnrolmentDate
        {
            get
            {
                _enrolmentDate = new HtmlEdit(_browser);
                _enrolmentDate.SearchProperties[HtmlControl.PropertyNames.Id] = "student-enrollmentdate";
                return _enrolmentDate;
            }
        }

        public HtmlInputButton CreateStudent
        {
            get
            {
                _createStudent = new HtmlInputButton(_browser);
                _createStudent.SearchProperties[HtmlControl.PropertyNames.Id] = "create-button";
                return _createStudent;

            }
        }
        public void ClickCreate()
        {
            Mouse.Click(CreateStudent);
        }

        
    }
}