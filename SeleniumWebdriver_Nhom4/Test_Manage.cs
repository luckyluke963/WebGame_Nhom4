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
    class Test_Manage
    {
        private IWebDriver driver;
        private string baseURL;
        [SetUp]
        public void Setuptest()
        {
            driver = new ChromeDriver();
            baseURL = "http://webdt.somee.com";
        }
        public void TeardownTest()
        {
            driver.Quit();
        }
        [Test]
        public void TCchangeInformation01()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.XPath("/html/body/nav[1]/div/div/div[1]/span/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/nav/div[2]/ul/li[5]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/table/tbody/tr[2]/td[8]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/form/table/tbody/tr[2]/td/input")).SendKeys("1");
            driver.FindElement(By.XPath("/html/body/div[1]/form/table/tbody/tr[4]/td/input")).SendKeys("090778");
            driver.FindElement(By.XPath("/html/body/div[1]/form/table/tbody/tr[5]/td/input")).SendKeys("BinhDuong");
            driver.FindElement(By.XPath("/html/body/div[1]/form/table/tbody/tr[7]/td/input")).Click();
            Assert.AreEqual("Admin1", driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[2]/td[1]")).Text);
        }

        [Test]
        public void TCchangeInformation02()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.XPath("/html/body/nav[1]/div/div/div[1]/span/a")).Click();
            driver.FindElement(By.XPath("/html/body/div/nav/div[2]/ul/li[4]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div/table/tbody/tr[2]/td[10]/form/select/option[4]")).Click();


            driver.FindElement(By.XPath("/html/body/div/table/tbody/tr[2]/td[10]/form/input[2]")).Click();
            Assert.AreEqual("Đã giao", driver.FindElement(By.XPath("/html/body/div/table/tbody/tr[2]/td[7]")).Text);
        }


        [Test]
        public void TCEditProduct02()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.Id("loginLink")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("Admin@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("A@Z200711");
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[4]/div/input")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/nav[1]/div/div/div[1]/span/a")).Click();
            driver.FindElement(By.XPath("/html/body/div/nav/div[2]/ul/li[1]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div/table/tbody/tr[2]/td[4]/a/img")).Click();
            driver.FindElement(By.Id("lname")).SendKeys("1");
            driver.FindElement(By.XPath("/html/body/div/div/form/select/option[1]")).Click();
            driver.FindElement(By.XPath("/html/body/div/div/form/input[3]")).Click();
            Assert.AreEqual("0", driver.FindElement(By.XPath("/html/body/div/table/tbody/tr[2]/td[3]")).Text);
        }

        [Test]
        public void TCEditProduct03()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.Id("loginLink")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("Admin@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("A@Z200711");
            driver.FindElement(By.XPath("/html/body/nav[1]/div/div/div[1]/span/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/div/nav/div[2]/ul/li[2]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div/table/tbody/tr[5]/td[4]/a/img")).Click();

            driver.FindElement(By.XPath("/html/body/div/div/form/input[2]")).SendKeys("1");
            driver.FindElement(By.XPath("/html/body/div/div/form/select/option[1]")).Click();
            driver.FindElement(By.XPath("/html/body/div/div/form/input[3]")).Click();
            Assert.AreEqual("0", driver.FindElement(By.XPath("/html/body/div/table/tbody/tr[2]/td[3]")).Text);
        }


        [Test]
        public void TCEditCategory03()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.Id("loginLink")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("Admin@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("A@Z200711");
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[4]/div/input")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/nav[1]/div/div/div[1]/span/a")).Click();
            driver.FindElement(By.XPath("/html/body/div/nav/div[2]/ul/li[1]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div/table/tbody/tr[2]/td[4]/a/img")).Click();
            driver.FindElement(By.Id("lname")).SendKeys("1");
            driver.FindElement(By.XPath("/html/body/div/div/form/select/option[2]")).Click();
            driver.FindElement(By.XPath("/html/body/div/div/form/input[3]")).Click();
            Assert.AreEqual("0", driver.FindElement(By.XPath("/html/body/div/table/tbody/tr[5]/td[3]")).Text);
        }

        [Test]
        public void TCEditCategory04()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.Id("loginLink")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("Admin@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("A@Z200711");
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[4]/div/input")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/nav[1]/div/div/div[1]/span/a")).Click();
            driver.FindElement(By.XPath("/html/body/div/nav/div[2]/ul/li[1]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div/table/tbody/tr[2]/td[4]/a/img")).Click();

            driver.FindElement(By.XPath("/html/body/div/div/form/select/option[1]")).Click();
            driver.FindElement(By.XPath("/html/body/div/div/form/input[3]")).Click();
            Assert.AreEqual("0", driver.FindElement(By.XPath("/html/body/div/table/tbody/tr[5]/td[3]")).Text);
        }
        [Test]
        public void TCLockCategory04()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.Id("loginLink")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("Admin@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("A@Z200711");
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[4]/div/input")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/nav[1]/div/div/div[1]/span/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/nav/div[2]/ul/li[2]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/table/tbody/tr[5]/td[5]/a/img")).Click();


            driver.FindElement(By.XPath("/html/body/div[1]/div/form/input[3]")).Click();
            Assert.AreEqual("1", driver.FindElement(By.XPath("/html/body/div/table/tbody/tr[5]/td[3]")).Text);
        }
        [Test]
        public void TCLockProduct04()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.Id("loginLink")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("Admin@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("A@Z200711");
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[4]/div/input")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/nav[1]/div/div/div[1]/span/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/nav/div[2]/ul/li[1]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/table/tbody/tr[2]/td[5]/a/img")).Click();


            driver.FindElement(By.XPath("/html/body/div[1]/div/form/input[3]")).Click();
            Assert.AreEqual("1", driver.FindElement(By.XPath("/html/body/div[1]/table/tbody/tr[2]/td[3]")).Text);
        }
    }
}
