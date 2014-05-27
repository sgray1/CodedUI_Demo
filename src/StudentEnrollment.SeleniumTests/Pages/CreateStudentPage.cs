using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace StudentEnrollment.SeleniumTests.Pages
{
    public class CreateStudentPage
    {
        private readonly IWebDriver _driver;
      
        
        public CreateStudentPage(IWebDriver webDriver)
        {
            _driver = webDriver;
            PageFactory.InitElements(_driver, this);
        }


        [FindsBy(How = How.Id, Using = "student-firstname")] 
        public IWebElement FirstName;

        [FindsBy(How = How.Id, Using = "student-lastname")] 
        public IWebElement LastName;

        [FindsBy(How = How.Id, Using = "student-enrollmentdate")] 
        public IWebElement EnrolmentDate;

        [FindsBy(How = How.Id, Using = "create-button")]
        public IWebElement Create;
        
        public void ClickCreate()
        {
            Create.Click();
        }

        
    }
}