using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace StudentEnrollment.SeleniumTests.Pages
{
    public class HomePage
    {
        private const string CreateStudentLink = "create-student-link";
        private readonly IWebDriver _driver;

        private const string StudentTable = "student-table";
        private const string StudentTableXpath = "id('" + StudentTable + "')/tbody/tr";

        public IWebElement GetStudentRow(int row)
        {
            ReadOnlyCollection<IWebElement> readOnlyCollection = Studentlist.FindElements((By.XPath(StudentTableXpath)));
            return readOnlyCollection[row];
        }


        [FindsBy(How = How.Id, Using = StudentTable)] 
        public IWebElement Studentlist;
        
        public HomePage(IWebDriver webDriver)
        {
            _driver = webDriver;
            //var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(50));
            //wait.Until((d) => d.FindElement(By.Id(CreateStudentLink)));
            PageFactory.InitElements(_driver, this);
        }

        public CreateStudentPage ClickCreateStudent()
        {
            CreateStudent.Click();
            return new CreateStudentPage(_driver);
        }

        [FindsBy(How = How.Id, Using = CreateStudentLink)] public IWebElement CreateStudent;

    }
}