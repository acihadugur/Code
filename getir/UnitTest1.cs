using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace getir
{
    [TimeFixture]

    public class Tests
    {

        IWebDriver driver;


        [OneTimeSetUp]
        public void Setup()
        {

            driver = new ChromeDriver();

        }

        [Test]
        public void FirstTest()
        {
            driver.Url = "https://getir.com/yemek/";
            IWebElement giris = driver.FindElement(By.Id("button"));
            IWebElement telefon = driver.FindElement(By.Xpath("//body/div[4]/div[2]/div[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[2]/div[1]/div[1]/input[1]"));
            

            giris.click();
            telefon.SendKeys("5343557468");


        }


        [OneTimeTearDown]

        public void Close()

        {
            
            //driver.Close()
            
        }
    }
}