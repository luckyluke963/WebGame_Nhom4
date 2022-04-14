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
    class Test_Register
    {
        private IWebDriver driver;
        private String baseURL;
        [SetUp]
        public void SetupText()
        {
            driver = new ChromeDriver();
            baseURL = "http://webdt.somee.com";

        }
        [TearDown]
        public void TearDownTest()
        {
            driver.Quit();
        }

        [Test]
        public void TC_Register_01()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.FindElement(By.LinkText("Register")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("Password")).SendKeys("Abc@123");
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Abc@123");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/form/div[5]/div/input")).SendKeys(" ");
            Assert.AreEqual("The Email field is required.", driver.FindElement(By.XPath("/html/body/form/div[1]/ul/li")).Text);


        }
        [Test]
        public void TC_Register_02()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.FindElement(By.LinkText("Register")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("Email")).SendKeys("Abc@gmail.com");
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Abc@123");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/form/div[5]/div/input")).SendKeys(" ");
            Assert.AreEqual("The Password field is required.", driver.FindElement(By.XPath("/html/body/form/div[1]/ul/li[1]")).Text);
            Assert.AreEqual("The password and confirmation password do not match.", driver.FindElement(By.XPath("/html/body/form/div[1]/ul/li[2]")).Text);
        }

        [Test]
        public void TC_Register_03()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.FindElement(By.LinkText("Register")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("Email")).SendKeys("Abc@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("Abc@123");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/form/div[5]/div/input")).SendKeys(" ");
            Assert.AreEqual("The password and confirmation password do not match.", driver.FindElement(By.XPath("/html/body/form/div[1]/ul/li")).Text);

        }
        [Test]
        public void TC_Register_04()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.FindElement(By.LinkText("Register")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("Email")).SendKeys("snghaer@a.c");
            driver.FindElement(By.Id("Password")).SendKeys("Abc@123");
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Abc@123");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/form/div[5]/div/input")).SendKeys(" ");
            Assert.AreEqual("The Email field is not a valid e-mail address.", driver.FindElement(By.XPath("//*[@id='logo']/img")).Text);

        }

        [Test]
        public void TC_Register_05()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.FindElement(By.LinkText("Register")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("Email")).SendKeys("Abc@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("Abc123");
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Abc123");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/form/div[5]/div/input")).SendKeys(" ");
            Assert.AreEqual("Passwords must have at least one non letter or digit character.", driver.FindElement(By.XPath("/html/body/form/div[1]/ul/li")).Text);

        }

        [Test]
        public void TC_Register_06()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.FindElement(By.LinkText("Register")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("Email")).SendKeys("");
            driver.FindElement(By.Id("Password")).SendKeys("");
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys("");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/form/div[5]/div/input")).SendKeys(" ");
            Assert.AreEqual("The Email field is required.", driver.FindElement(By.XPath("/html/body/form/div[1]/ul/li[1]")).Text);
            Assert.AreEqual("The Email field is required.", driver.FindElement(By.XPath("/html/body/form/div[1]/ul/li[1]")).Text);
        }


        [Test]
        public void TC_Register_07()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.FindElement(By.LinkText("Register")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("Email")).SendKeys("Abc@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("Abc@123");
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Abc123");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/form/div[5]/div/input")).SendKeys(" ");
            Assert.AreEqual("The password and confirmation password do not match.", driver.FindElement(By.XPath("/html/body/form/div[1]/ul/li")).Text);

        }


        [Test]
        public void TC_Register_08()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.FindElement(By.LinkText("Register")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("Email")).SendKeys("Abc@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("Abc@123");
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Abc@123");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/form/div[5]/div/input")).SendKeys(" ");
            Assert.AreEqual("Log off", driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li[2]/a")).Text);

        }

        [Test]
        public void TC_AddProducer_01()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");

            driver.FindElement(By.XPath("//*[@id='active']/li[1]/a")).Click();

            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[1]/th[4]/a/img")).Click();
            driver.FindElement(By.XPath("//*[@id='lname']")).SendKeys("KT");

            driver.FindElement(By.XPath("//*[@id='wrapper']/div/form/input[3]")).Click();
            Assert.AreEqual("Thêm Nhà Sản Xuất", driver.FindElement(By.CssSelector("#wrapper > center > h2")).Text);
        }


        [Test]
        public void TC_AddProducer_02()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            driver.FindElement(By.XPath("//*[@id='active']/li[1]/a")).Click();

            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[1]/th[4]/a/img")).Click();
            driver.FindElement(By.XPath("//*[@id='fname']")).SendKeys("001");

            driver.FindElement(By.XPath("//*[@id='wrapper']/div/form/input[3]")).Click();
            Assert.AreEqual("Thêm Nhà Sản Xuất", driver.FindElement(By.CssSelector("#wrapper > center > h2")).Text);
        }


        [Test]
        public void TC_AddProducer_03()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            driver.FindElement(By.XPath("//*[@id='active']/li[1]/a")).Click();

            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[1]/th[4]/a/img")).Click();
            driver.FindElement(By.XPath("//*[@id='fname']")).SendKeys("1");
            driver.FindElement(By.XPath("//*[@id='lname']")).SendKeys("Action");

            driver.FindElement(By.XPath("//*[@id='wrapper']/div/form/input[3]")).Click();
            Assert.AreEqual("Thêm Nhà Sản Xuất", driver.FindElement(By.CssSelector("#wrapper > center > h2")).Text);
        }

        [Test]
        public void TC_AddProducer_04()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            driver.FindElement(By.XPath("//*[@id='active']/li[1]/a")).Click();

            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[1]/th[4]/a/img")).Click();
            driver.FindElement(By.XPath("//*[@id='fname']")).SendKeys("");
            driver.FindElement(By.XPath("//*[@id='lname']")).SendKeys("");

            driver.FindElement(By.XPath("//*[@id='wrapper']/div/form/input[3]")).Click();
            Assert.AreEqual("Thêm Nhà Sản Xuất", driver.FindElement(By.CssSelector("#wrapper > center > h2")).Text);
        }

        [Test]
        public void TC_AddProducer_05()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            driver.FindElement(By.XPath("//*[@id='active']/li[1]/a")).Click();

            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[1]/th[4]/a/img")).Click();
            driver.FindElement(By.XPath("//*[@id='fname']")).SendKeys("00");
            driver.FindElement(By.XPath("//*[@id='lname']")).SendKeys("ama");

            driver.FindElement(By.XPath("//*[@id='wrapper']/div/form/input[3]")).Click();
            Assert.AreEqual("Quản Lý Nhà Sản Xuất", driver.FindElement(By.CssSelector("#wrapper > center > h2")).Text);
        }

        [Test]
        public void TC_AddProducer_06()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            driver.FindElement(By.XPath("//*[@id='active']/li[1]/a")).Click();

            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[1]/th[4]/a/img")).Click();
            driver.FindElement(By.XPath("//*[@id='fname']")).SendKeys("123");
            driver.FindElement(By.XPath("//*[@id='lname']")).SendKeys("Action");

            driver.FindElement(By.XPath("//*[@id='wrapper']/div/form/input[3]")).Click();
            Assert.AreEqual("Manufactuner name duplicate", driver.FindElement(By.CssSelector("#wrapper > center > h2")).Text);
        }

    }
}
