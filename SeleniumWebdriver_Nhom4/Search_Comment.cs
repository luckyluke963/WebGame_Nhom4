using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace SeleniumWebdriver_Nhom4
{
    [TestFixture]
    class Search_Comment
    {
        private IWebDriver driver;
        private string bastURL;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            bastURL = "http://webdtvn.somee.com/";

        }
        [TearDown]
        public void TeardownTest()
        {
            driver.Quit();
        }

        [Test]
        public void TCSearch01()
        {
            driver.Navigate().GoToUrl(bastURL);
            driver.FindElement(By.XPath("/html/body/header/div/div[2]/form/input[5]")).SendKeys("a");

            driver.FindElement(By.ClassName("btn")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Assert.AreEqual("2,00 ₫", driver.FindElement(By.ClassName("price")).Text);
        }


        [Test]
        public void TCSearch02()
        {
            driver.Navigate().GoToUrl(bastURL);
            driver.FindElement(By.XPath("/html/body/header/div/div[2]/form/input[5]")).Click();

            driver.FindElement(By.ClassName("btn")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Assert.AreEqual("2,00 ₫", driver.FindElement(By.ClassName("price")).Text);
        }


        [Test]
        public void TCSearch03()
        {
            driver.Navigate().GoToUrl(bastURL);
            driver.FindElement(By.XPath("/html/body/header/div/div[2]/form/input[5]")).SendKeys("a");

            driver.FindElement(By.ClassName("btn")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/div/div/form/select[1]/option[1]")).Click();
            driver.FindElement(By.XPath("/html/body/div/div/form/select[2]/option[4]")).Click();

            driver.FindElement(By.XPath("/html/body/div/div/form/input[1]")).SendKeys("55212");
            driver.FindElement(By.XPath("/html/body/div/div/form/input[2]")).SendKeys("65212");
            driver.FindElement(By.XPath("/html/body/div/div/form/input[3]")).SendKeys("a1");
            driver.FindElement(By.XPath("/html/body/div/div/form/input[4]")).Click();
            Assert.AreEqual("55.212,00 ₫", driver.FindElement(By.ClassName("price")).Text);
        }



        [Test]
        public void TCSearch04()
        {

            driver.Navigate().GoToUrl(bastURL);
            driver.FindElement(By.XPath("/html/body/header/div/div[2]/form/input[5]")).SendKeys("a");

            driver.FindElement(By.ClassName("btn")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            driver.FindElement(By.XPath("/html/body/div/div/form/input[2]")).SendKeys("65212");
            driver.FindElement(By.XPath("/html/body/div/div/form/input[3]")).SendKeys("a1");
            driver.FindElement(By.XPath("/html/body/div/div/form/input[4]")).Click();
            Assert.AreEqual("2,00 ₫", driver.FindElement(By.XPath("/html/body/div/div/div/div/div[1]/div/div/div[1]/div/div[3]/div[2]")).Text);

        }


        [Test]
        public void TCSearch05()
        {

            driver.Navigate().GoToUrl(bastURL);
            driver.FindElement(By.XPath("/html/body/header/div/div[2]/form/input[5]")).SendKeys("a");

            driver.FindElement(By.ClassName("btn")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.XPath("/html/body/div/div/form/input[1]")).SendKeys("55212");
            driver.FindElement(By.XPath("/html/body/div/div/form/input[3]")).SendKeys("a1");

            driver.FindElement(By.XPath("/html/body/div/div/form/input[4]")).Click();

            Assert.AreEqual("2,00 ₫", driver.FindElement(By.XPath("/html/body/div/div/div/div/div[1]/div/div/div[1]/div/div[3]/div[2]")).Text);

        }

        [Test]
        public void TCSearch06()
        {

            driver.Navigate().GoToUrl(bastURL);
            driver.FindElement(By.XPath("/html/body/header/div/div[2]/form/input[5]")).SendKeys("a");

            driver.FindElement(By.ClassName("btn")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.XPath("/html/body/div/div/form/input[2]")).SendKeys("55212");
            driver.FindElement(By.XPath("/html/body/div/div/form/input[3]")).SendKeys("a1");

            driver.FindElement(By.XPath("/html/body/div/div/form/input[4]")).Click();

            Assert.AreEqual("2,00 ₫", driver.FindElement(By.XPath("/html/body/div/div/div/div/div[1]/div/div/div[1]/div/div[3]/div[2]")).Text);

        }

        [Test]
        public void TCSearch07()
        {
            driver.Navigate().GoToUrl(bastURL);
            driver.FindElement(By.XPath("/html/body/header/div/div[2]/form/input[5]")).SendKeys("a");

            driver.FindElement(By.ClassName("btn")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.XPath("/html/body/div/div/form/input[1]")).SendKeys("s");
            driver.FindElement(By.XPath("/html/body/div/div/form/input[2]")).SendKeys("s");

            driver.FindElement(By.XPath("/html/body/div/div/form/input[4]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.AreEqual("An error occurred while processing your request.", driver.FindElement(By.XPath("/html/body/h2")).Text);

        }
        [Test]
        public void TCComment08()
        {
            driver.Navigate().GoToUrl(bastURL);
            driver.FindElement(By.XPath("//*[@id='loginLink']")).Click();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.Id("Email")).SendKeys("tomviet963@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("123456@Asd");
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/section/form/div[4]/div/input")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/div/div/div[3]/div/div[2]/div[1]/div/div[1]/a/img")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[3]/form/textarea")).SendKeys("tuyet");
            driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[3]/form/input[2]")).Click();
            Assert.AreEqual("tomviet963@gmail.com : tuyet", driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[3]/div[2]/div/span[1]")).Text);
        }
        [Test]
        public void TCComment09()
        {
            driver.Navigate().GoToUrl(bastURL);
            driver.FindElement(By.XPath("/html/body/div/div/div[3]/div/div[2]/div[1]/div/div[1]/a/img")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.AreEqual("Vui lòng đăng nhập để bình luận", driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[3]/h2")).Text);
        }
    }
}
