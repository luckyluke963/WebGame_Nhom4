using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace Test_Bc
{
    [TestFixture]
    public class Test_Login
    {
        private IWebDriver driver;
        private string baseURL;
        [SetUp]
        public void Setuptest()
        {
            driver = new ChromeDriver();
            baseURL = "http://webdt.somee.com/";
        }
        public void TeardownTest()
        {
            driver.Quit();
        }

        [Test]
        public void TC_AddCategory_01()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='active']/li[2]/a")).Click();

            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[1]/th[4]/a/img")).Click();
            driver.FindElement(By.XPath("//*[@id='fname']")).SendKeys("8");
            driver.FindElement(By.XPath("//*[@id='lname']")).SendKeys("Test3");

            driver.FindElement(By.XPath("//*[@id='wrapper']/div/form/input[3]")).Click();
            Assert.AreEqual("Quản Lý Thể Loại", driver.FindElement(By.XPath("//*[@id='wrapper']/center/h2")).Text);
            //Assert.AreEqual("Sign out ", driver.FindElement(By.CssSelector("a.logout")).Text);




        }
        [Test]
        public void TC_AddCategory_02()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='active']/li[2]/a")).Click();

            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[1]/th[4]/a/img")).Click();
            //driver.FindElement(By.XPath("//*[@id='fname']")).SendKeys("");
            //driver.FindElement(By.XPath("//*[@id='lname']")).SendKeys("Test3");

            driver.FindElement(By.XPath("//*[@id='wrapper']/div/form/input[3]")).Click();
            Assert.AreEqual("Thêm Thể Loại", driver.FindElement(By.XPath("//*[@id='wrapper']/center/h2")).Text);
            //Assert.AreEqual("Sign out ", driver.FindElement(By.CssSelector("a.logout")).Text);




        }
        [Test]
        public void TC_AddCategory_03()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='active']/li[2]/a")).Click();

            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[1]/th[4]/a/img")).Click();
            //driver.FindElement(By.XPath("//*[@id='fname']")).SendKeys("6");
            driver.FindElement(By.XPath("//*[@id='lname']")).SendKeys("Test3");

            driver.FindElement(By.XPath("//*[@id='wrapper']/div/form/input[3]")).Click();
            Assert.AreEqual("Thêm Thể Loại", driver.FindElement(By.XPath("//*[@id='wrapper']/center/h2")).Text);
            //Assert.AreEqual("Quản Lý Thể Loại", driver.FindElement(By.XPath("//*[@id='wrapper']/center/h2")).Text);
            //Assert.AreEqual("Sign out ", driver.FindElement(By.CssSelector("a.logout")).Text);




        }
        [Test]
        public void TC_AddCategory_04()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='active']/li[2]/a")).Click();

            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[1]/th[4]/a/img")).Click();
            driver.FindElement(By.XPath("//*[@id='fname']")).SendKeys("6");
            //driver.FindElement(By.XPath("//*[@id='lname']")).SendKeys("Test3");

            driver.FindElement(By.XPath("//*[@id='wrapper']/div/form/input[3]")).Click();
            Assert.AreEqual("Thêm Thể Loại", driver.FindElement(By.XPath("//*[@id='wrapper']/center/h2")).Text);
            //Assert.AreEqual("Sign out ", driver.FindElement(By.CssSelector("a.logout")).Text);




        }
        [Test]
        public void TC_AddCategory_05()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='active']/li[2]/a")).Click();

            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[1]/th[4]/a/img")).Click();
            driver.FindElement(By.XPath("//*[@id='fname']")).SendKeys("1");
            driver.FindElement(By.XPath("//*[@id='lname']")).SendKeys("Test3");

            driver.FindElement(By.XPath("//*[@id='wrapper']/div/form/input[3]")).Click();
            Assert.AreEqual("Thêm Thể Loại", driver.FindElement(By.XPath("//*[@id='wrapper']/center/h2")).Text);
            //Assert.AreEqual("Sign out ", driver.FindElement(By.CssSelector("a.logout")).Text);




        }
        [Test]
        public void TC_AddCategory_06()
        {
            driver.Navigate().GoToUrl(baseURL + "/Admin");
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='active']/li[2]/a")).Click();

            driver.FindElement(By.XPath("//*[@id='wrapper']/table/tbody/tr[1]/th[4]/a/img")).Click();
            driver.FindElement(By.XPath("//*[@id='fname']")).SendKeys("10");
            driver.FindElement(By.XPath("//*[@id='lname']")).SendKeys("Test");

            driver.FindElement(By.XPath("//*[@id='wrapper']/div/form/input[3]")).Click();
            Assert.AreEqual("Thêm Thể Loại", driver.FindElement(By.XPath("//*[@id='wrapper']/center/h2")).Text);
            //Assert.AreEqual("Sign out ", driver.FindElement(By.CssSelector("a.logout")).Text);




        }
        [Test]
        public void TC_Login_01()
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
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.AreEqual("Hello Admin@gmail.com!", driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li[1]/a")).Text);
            //Assert.AreEqual("Sign out ", driver.FindElement(By.CssSelector("a.logout")).Text);




        }
        [Test]
        public void TC_Login_02()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='loginLink']")).Click();

            driver.FindElement(By.XPath("//*[@id='Email']")).SendKeys("");

            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys("");
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[4]/div/input")).SendKeys(" ");

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.AreEqual("The Email field is required.", driver.FindElement(By.CssSelector("#Email-error")).Text);
            Assert.AreEqual("The Password field is required.", driver.FindElement(By.CssSelector("#Password-error")).Text);




        }
        [Test]
        public void TC_Login_03()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='loginLink']")).Click();

            driver.FindElement(By.XPath("//*[@id='Email']")).SendKeys("");

            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys("A@Z200711");
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[4]/div/input")).SendKeys(" ");

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.AreEqual("The Email field is required.", driver.FindElement(By.CssSelector("#Email-error")).Text);
            //Assert.AreEqual("The Password field is required.", driver.FindElement(By.CssSelector("#Password-error")).Text);




        }
        [Test]
        public void TC_Login_04()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='loginLink']")).Click();

            driver.FindElement(By.XPath("//*[@id='Email']")).SendKeys("Admin@gmail.com");

            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys("");
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[4]/div/input")).SendKeys(" ");

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Assert.AreEqual("The Email field is required.", driver.FindElement(By.CssSelector("#Email-error")).Text);
            Assert.AreEqual("The Password field is required.", driver.FindElement(By.CssSelector("#Password-error")).Text);




        }
        [Test]
        public void TC_Login_05()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='loginLink']")).Click();

            driver.FindElement(By.XPath("//*[@id='Email']")).SendKeys("Admin");

            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys("A@Z200711");
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[4]/div/input")).SendKeys(" ");

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.AreEqual("The Email field is not a valid e-mail address.", driver.FindElement(By.CssSelector("#Email-error")).Text);
            //Assert.AreEqual("The Password field is required.", driver.FindElement(By.CssSelector("#Password-error")).Text);



        }
        [Test]
        public void TC_Login_06()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='loginLink']")).Click();

            driver.FindElement(By.XPath("//*[@id='Email']")).SendKeys("AAmin@gmail.com");

            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys("A@Z200711");
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[4]/div/input")).SendKeys(" ");

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.AreEqual("Invalid login attempt.", driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[1]/ul/li")).Text);
            //Assert.AreEqual("The Password field is required.", driver.FindElement(By.CssSelector("#Password-error")).Text);



        }
        [Test]
        public void TC_Login_07()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='loginLink']")).Click();

            driver.FindElement(By.XPath("//*[@id='Email']")).SendKeys("Amin@gmail.com");

            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys("AA@Z200711");
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[4]/div/input")).SendKeys(" ");

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.AreEqual("Invalid login attempt.", driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[1]/ul/li")).Text);
            //Assert.AreEqual("The Password field is required.", driver.FindElement(By.CssSelector("#Password-error")).Text);



        }
        [Test]
        public void TC_Login_08()
        {
            driver.Navigate().GoToUrl(baseURL + "");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.XPath("//*[@id='active']/li[4]/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='loginLink']")).Click();

            driver.FindElement(By.XPath("//*[@id='Email']")).SendKeys("AAmin@gmail.com");

            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys("AA@Z200711");
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[4]/div/input")).SendKeys(" ");

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.AreEqual("Invalid login attempt.", driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[1]/ul/li")).Text);
            //Assert.AreEqual("The Password field is required.", driver.FindElement(By.CssSelector("#Password-error")).Text);



        }


    }
}