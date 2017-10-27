//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;


//namespace lab5
//{
//    [TestClass]
//    class Test1: UnitTest1
//    {
//        private object webDriverChrome;

//        [TestMethod]
//        public void TestMethod1()
//        {
//            webDriverChrome.Navigate().GoToUrl("https://nordwindairlines.ru/");
//            webDriverChrome.FindElement(By.Id("user[login]")).SendKeys("hi");
//            webDriverChrome.FindElement(By.Id("user[email]")).SendKeys("hellow");
//            webDriverChrome.FindElement(By.Id("user[password]")).SendKeys("world");
//            webDriverChrome.FindElement(By.XPath("//button[@class='btn btn-primary btn-large f4 btn-block']")).Click();
//            System.Threading.Thread.Sleep(5000);
//            //webDriverChrome.FindElement(By.XPath("//button[@id='index_login_button']")).Click();//кнопку не нахожу
//        }

//        // разрушение объекта драйвера после окончание теста.
//        [TestCleanup]
//        public void TearDown()
//        {

//            webDriverChrome.Quit();
//        }
//    }
//}
