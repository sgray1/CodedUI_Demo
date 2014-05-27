using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace StudentEnrollment.CUITests.Pages
{
    public class HomePage
    {
        private readonly BrowserWindow _browser;
        private HtmlHyperlink _createStudentHyperlink;
        private HtmlTable _studentTable;

        public HomePage(BrowserWindow browserWindow)
        {
             _browser = browserWindow;
        }

        public CreateStudentPage ClickCreateStudentLink()
        {
            Mouse.Click(CreateStudentLink);
            return new CreateStudentPage(_browser);
        }

        public HtmlHyperlink CreateStudentLink
        {
            get
            {
                _createStudentHyperlink = new HtmlHyperlink(_browser);
                _createStudentHyperlink.SearchProperties[HtmlControl.PropertyNames.Id] = "create-student-link";
                return _createStudentHyperlink;

            }
        }

        public string GetStudentRowText(int row)
        {
            return StudentTable.GetRow(row).InnerText;
        }

        public HtmlTable StudentTable
        {
            get
            {
                _studentTable = new HtmlTable(_browser);
                _studentTable.SearchProperties[HtmlControl.PropertyNames.Id] = "student-table";
                return _studentTable;

            }
        }
    }
}