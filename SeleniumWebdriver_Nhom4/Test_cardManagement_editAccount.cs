using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebdriver_Nhom4
{
    [TestFixture]
    class Test_cardManagement_editAccount
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
        public void TC_cartmanagement_01()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='loginLink']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.XPath("//*[@id='Email']")).SendKeys("Admin@gmail.com");

            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys("A@Z200711");

            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[4]/div/input")).SendKeys(" ");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='menu']/div/div[2]/ul/li[2]/a")).Click();

            driver.FindElement(By.CssSelector("#page-content > div > div:nth-child(2) > div:nth-child(1) > div > div > div:nth-child(1) > div > div.image")).Click();
            driver.FindElement(By.CssSelector("#main-content > div.product > div:nth-child(2) > div > form > input.btn.btn-2")).SendKeys(" ");


            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.AreEqual("Continue To Shopping", driver.FindElement(By.CssSelector("#page-content > div > div:nth-child(3) > div > center > a")).Text);
            //Assert.AreEqual("The Password field is required.", driver.FindElement(By.CssSelector("#Password-error")).Text);



        }
        [Test]
        public void TC_cartmanagement_03()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='loginLink']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.XPath("//*[@id='Email']")).SendKeys("Admin@gmail.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys("A@Z200711");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[4]/div/input")).SendKeys(" ");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='menu']/div/div[2]/ul/li[2]/a")).Click();

            driver.FindElement(By.CssSelector("#page-content > div > div:nth-child(2) > div:nth-child(1) > div > div > div:nth-child(1) > div > div.image")).Click();
            driver.FindElement(By.CssSelector("#main-content > div.product > div:nth-child(2) > div > form > input.btn.btn-2")).SendKeys(" ");
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.CssSelector("#cart > a")).Click();
            driver.FindElement(By.CssSelector("#page-content > div > div:nth-child(2) > div > div.col-md-9 > div > form > input.form-inline.quantity")).SendKeys("10");
            driver.FindElement(By.CssSelector("#page-content > div > div:nth-child(2) > div > div.col-md-9 > div > form > input.btn.btn-2")).SendKeys(" ");



            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.AreEqual("202", driver.FindElement(By.CssSelector("#page-content > div > div:nth-child(4) > div > div > table > tbody > tr:nth-child(1) > td:nth-child(2)")).Text);
            //Assert.AreEqual("The Password field is required.", driver.FindElement(By.CssSelector("#Password-error")).Text);



        }
        [Test]
        public void TC_cartmanagement_02()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='loginLink']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.XPath("//*[@id='Email']")).SendKeys("Admin@gmail.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys("A@Z200711");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[4]/div/input")).SendKeys(" ");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='cart']/a")).Click();
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.CssSelector("#cart > a")).Click();


            driver.FindElement(By.CssSelector("#page-content > div > div:nth-child(2) > div > div.col-md-9 > div > a")).SendKeys(" ");
            driver.FindElement(By.CssSelector("#page-content > div > div:nth-child(2) > div > div.col-md-9 > div > a")).Click();


            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.AreEqual("CART : 0 ITEM", driver.FindElement(By.XPath("//*[@id='cart']/a")).Text);
            //Assert.AreEqual("The Password field is required.", driver.FindElement(By.CssSelector("#Password-error")).Text);



        }


        [Test]
        public void TC_Editaccount_01()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            driver.FindElement(By.XPath("//*[@id='active']/li[5]/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[3]/td[8]/a")).Click();

            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(3) > td > input[type=date]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(2) > td > input[type=text]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(4) > td > input[type=number]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(5) > td > input[type=text]")).Clear();
            driver.FindElement(By.XPath("//*[@id='wrapper']/form/table/tbody/tr[6]/td/input")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(7) > td > input[type=submit]")).Click();
            Assert.AreEqual("Thêm Thông Tin Cá Nhân", driver.FindElement(By.CssSelector("#wrapper > h2")).Text);
            //Assert.AreEqual("Sign out ", driver.FindElement(By.CssSelector("a.logout")).Text);




        }
        [Test]
        public void TC_Editaccount_02()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            driver.FindElement(By.XPath("//*[@id='active']/li[5]/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[3]/td[8]/a")).Click();


            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(2) > td > input[type=text]")).Clear();

            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(3) > td > input[type=date]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(3) > td > input[type=date]")).SendKeys("10102002");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(4) > td > input[type=number]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(4) > td > input[type=number]")).SendKeys("1234");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(5) > td > input[type=text]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(5) > td > input[type=text]")).SendKeys("eqweq");

            driver.FindElement(By.XPath("//*[@id='wrapper']/form/table/tbody/tr[6]/td/input")).Clear();
            driver.FindElement(By.XPath("//*[@id='wrapper']/form/table/tbody/tr[6]/td/input")).SendKeys("Nam");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(7) > td > input[type=submit]")).Click();
            Assert.AreEqual("Thêm Thông Tin Cá Nhân", driver.FindElement(By.CssSelector("#wrapper > h2")).Text);
            //Assert.AreEqual("Sign out ", driver.FindElement(By.CssSelector("a.logout")).Text);




        }
        [Test]
        public void TC_Editaccount_03()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            driver.FindElement(By.XPath("//*[@id='active']/li[5]/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[3]/td[8]/a")).Click();


            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(2) > td > input[type=text]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(2) > td > input[type=text]")).SendKeys("abc");

            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(3) > td > input[type=date]")).Clear();
            //driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(3) > td > input[type=date]")).SendKeys("10102002");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(4) > td > input[type=number]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(4) > td > input[type=number]")).SendKeys("1234");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(5) > td > input[type=text]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(5) > td > input[type=text]")).SendKeys("eqweq");

            driver.FindElement(By.XPath("//*[@id='wrapper']/form/table/tbody/tr[6]/td/input")).Clear();
            driver.FindElement(By.XPath("//*[@id='wrapper']/form/table/tbody/tr[6]/td/input")).SendKeys("Nam");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(7) > td > input[type=submit]")).Click();
            Assert.AreEqual("Thêm Thông Tin Cá Nhân", driver.FindElement(By.CssSelector("#wrapper > h2")).Text);
            //Assert.AreEqual("Sign out ", driver.FindElement(By.CssSelector("a.logout")).Text);




        }
        [Test]
        public void TC_Editaccount_04()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            driver.FindElement(By.XPath("//*[@id='active']/li[5]/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[3]/td[8]/a")).Click();


            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(2) > td > input[type=text]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(2) > td > input[type=text]")).SendKeys("abc");

            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(3) > td > input[type=date]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(3) > td > input[type=date]")).SendKeys("10102002");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(4) > td > input[type=number]")).Clear();
            //driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(4) > td > input[type=number]")).SendKeys("1234");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(5) > td > input[type=text]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(5) > td > input[type=text]")).SendKeys("eqweq");

            driver.FindElement(By.XPath("//*[@id='wrapper']/form/table/tbody/tr[6]/td/input")).Clear();
            driver.FindElement(By.XPath("//*[@id='wrapper']/form/table/tbody/tr[6]/td/input")).SendKeys("Nam");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(7) > td > input[type=submit]")).Click();
            Assert.AreEqual("Thêm Thông Tin Cá Nhân", driver.FindElement(By.CssSelector("#wrapper > h2")).Text);
            //Assert.AreEqual("Sign out ", driver.FindElement(By.CssSelector("a.logout")).Text);




        }
        [Test]
        public void TC_Editaccount_05()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            driver.FindElement(By.XPath("//*[@id='active']/li[5]/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[3]/td[8]/a")).Click();


            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(2) > td > input[type=text]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(2) > td > input[type=text]")).SendKeys("abc");

            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(3) > td > input[type=date]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(3) > td > input[type=date]")).SendKeys("10102002");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(4) > td > input[type=number]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(4) > td > input[type=number]")).SendKeys("1234");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(5) > td > input[type=text]")).Clear();
            //driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(5) > td > input[type=text]")).SendKeys("eqweq");

            driver.FindElement(By.XPath("//*[@id='wrapper']/form/table/tbody/tr[6]/td/input")).Clear();
            driver.FindElement(By.XPath("//*[@id='wrapper']/form/table/tbody/tr[6]/td/input")).SendKeys("Nam");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(7) > td > input[type=submit]")).Click();
            Assert.AreEqual("Thêm Thông Tin Cá Nhân", driver.FindElement(By.CssSelector("#wrapper > h2")).Text);
            //Assert.AreEqual("Sign out ", driver.FindElement(By.CssSelector("a.logout")).Text);




        }
        [Test]
        public void TC_Editaccount_06()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            driver.FindElement(By.XPath("//*[@id='active']/li[5]/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[3]/td[8]/a")).Click();


            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(2) > td > input[type=text]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(2) > td > input[type=text]")).SendKeys("abc");

            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(3) > td > input[type=date]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(3) > td > input[type=date]")).SendKeys("10102002");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(4) > td > input[type=number]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(4) > td > input[type=number]")).SendKeys("1234");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(5) > td > input[type=text]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(5) > td > input[type=text]")).SendKeys("eqweq");

            driver.FindElement(By.XPath("//*[@id='wrapper']/form/table/tbody/tr[6]/td/input")).Clear();
            //driver.FindElement(By.XPath("//*[@id='wrapper']/form/table/tbody/tr[6]/td/input")).SendKeys("Nam");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(7) > td > input[type=submit]")).Click();
            Assert.AreEqual("Thêm Thông Tin Cá Nhân", driver.FindElement(By.CssSelector("#wrapper > h2")).Text);
            //Assert.AreEqual("Sign out ", driver.FindElement(By.CssSelector("a.logout")).Text);




        }
        [Test]
        public void TC_Editaccount_07()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            driver.FindElement(By.XPath("//*[@id='active']/li[5]/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[3]/td[8]/a")).Click();


            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(2) > td > input[type=text]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(2) > td > input[type=text]")).SendKeys("abc");

            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(3) > td > input[type=date]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(3) > td > input[type=date]")).SendKeys("10102002");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(4) > td > input[type=number]")).Clear();
            driver.FindElement(By.XPath("//*[@id='wrapper']/form/table/tbody/tr[4]/td/input")).SendKeys("e");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(5) > td > input[type=text]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(5) > td > input[type=text]")).SendKeys("eqweq");

            driver.FindElement(By.XPath("//*[@id='wrapper']/form/table/tbody/tr[6]/td/input")).Clear();
            driver.FindElement(By.XPath("//*[@id='wrapper']/form/table/tbody/tr[6]/td/input")).SendKeys("Nam");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(7) > td > input[type=submit]")).Click();
            Assert.AreEqual("Thêm Thông Tin Cá Nhân", driver.FindElement(By.CssSelector("#wrapper > h2")).Text);
            //Assert.AreEqual("Sign out ", driver.FindElement(By.CssSelector("a.logout")).Text);




        }
        [Test]
        public void TC_Editaccount_08()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            driver.FindElement(By.XPath("//*[@id='active']/li[5]/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[3]/td[8]/a")).Click();


            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(2) > td > input[type=text]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(2) > td > input[type=text]")).SendKeys("abc");

            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(3) > td > input[type=date]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(3) > td > input[type=date]")).SendKeys("10102002");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(4) > td > input[type=number]")).Clear();
            driver.FindElement(By.XPath("//*[@id='wrapper']/form/table/tbody/tr[4]/td/input")).SendKeys("123");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(5) > td > input[type=text]")).Clear();
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(5) > td > input[type=text]")).SendKeys("bd");

            driver.FindElement(By.XPath("//*[@id='wrapper']/form/table/tbody/tr[6]/td/input")).Clear();
            driver.FindElement(By.XPath("//*[@id='wrapper']/form/table/tbody/tr[6]/td/input")).SendKeys("Nam");
            driver.FindElement(By.CssSelector("#wrapper > form > table > tbody > tr:nth-child(7) > td > input[type=submit]")).Click();
            Assert.AreEqual("Quản Lý Tài Khoản", driver.FindElement(By.XPath("//*[@id='wrapper']/h2")).Text);
            //Assert.AreEqual("Sign out ", driver.FindElement(By.CssSelector("a.logout")).Text);




        }
    }
}
