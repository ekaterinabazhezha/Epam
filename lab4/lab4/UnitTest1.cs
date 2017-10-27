using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace lab4
{
    [TestClass]
    public class UnitTest1
    {
        private static IWebDriver webDriverChrome;
        [AssemblyInitialize]
        public static void SetUP(TestContext testContext)
        {
            try
            {
                webDriverChrome = new ChromeDriver(@"C:\Program Files\ChromeAndGeckoDrivres\");
            }
            catch (Exception exception)
            {
                exception.StackTrace.ToString();
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            webDriverChrome.Navigate().GoToUrl("http://www.github.com/");
            webDriverChrome.FindElement(By.Id("user[login]")).SendKeys("hi");
            webDriverChrome.FindElement(By.Id("user[email]")).SendKeys("hellow");
            webDriverChrome.FindElement(By.Id("user[password]")).SendKeys("world");
            webDriverChrome.FindElement(By.XPath("//button[@class='btn btn-primary btn-large f4 btn-block']")).Click();
            System.Threading.Thread.Sleep(5000);
            //webDriverChrome.FindElement(By.XPath("//button[@id='index_login_button']")).Click();//кнопку не нахожу
        }

        // разрушение объекта драйвера после окончание теста.
        [TestCleanup]
        public void TearDown()
        {

            webDriverChrome.Quit();
        }
    }
}