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

        
        /// <summary>
        /// Use the Coded UI mouse class to click the UI Element create student link
        /// </summary>
        /// <returns>The Create Student Page </returns>
        public CreateStudentPage ClickCreateStudentLink()
        {
            Mouse.Click(CreateStudentLink);
            return new CreateStudentPage(_browser);
        }
        
        /// <summary>
        /// Property representing a UI element
        /// </summary>
        public HtmlHyperlink CreateStudentLink
        {
            get
            {
                _createStudentHyperlink = new HtmlHyperlink(_browser);
                //ID's are the best way to identifiy UI elements on the page
                _createStudentHyperlink.SearchProperties[HtmlControl.PropertyNames.Id] = "create-student-link";
                return _createStudentHyperlink;

            }
        }

        /// <summary>
        /// Returns the inner text of the Row
        /// </summary>
        /// <param name="row">Row number, zero based</param>
        /// <returns>Text from the row</returns>
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