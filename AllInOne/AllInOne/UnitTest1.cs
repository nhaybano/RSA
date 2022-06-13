using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;



namespace AllInOne
{
    public class Tests
    {
        private IWebDriver drivel;
        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            drivel = new ChromeDriver();
            drivel.Manage().Window.Maximize();

        }
        [TearDown]
        public void TearDown()
        {

        }
        [Test]
        public void Test1()
        {
            drivel.Navigate().GoToUrl("https://www.rahulshettyacademy.com/AutomationPractice/");
            var radiobutton1 = drivel.FindElements(By.XPath("//*[@id='radio-btn-example']/fieldset/label[1]/input")).SingleOrDefault();
            radiobutton1.Click();
            

            var textbox1 = drivel.FindElements(By.XPath("//*[@id='autocomplete']")).SingleOrDefault();
            textbox1.SendKeys("Text ENtered");

            Thread.Sleep(1000);
            var combobox1 = drivel.FindElements(By.XPath("//*[@id='dropdown-class-example']")).SingleOrDefault();
            var dropdown1 = new SelectElement(combobox1);
            dropdown1.SelectByIndex(1);
            Thread.Sleep(1000);


            var checkbox1 = drivel.FindElements(By.XPath("//*[@id='checkBoxOption1']")).SingleOrDefault();
            checkbox1.Click();

            


        }
    }
}