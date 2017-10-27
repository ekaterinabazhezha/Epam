using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace lab5
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

        // [TestMethod]
        //public void TestMethod1()
        //{
        //    webDriverChrome.Navigate().GoToUrl("https://nordwindairlines.ru/");
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).Click();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).Clear();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).SendKeys("Минск");


        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).Click();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).Clear();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).SendKeys("Москва");
        //    System.Threading.Thread.Sleep(2000);
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > div > div > a:nth-child(1)")).Click();


        //    webDriverChrome.FindElement(By.XPath("//button[@class='search-form__button button button_type_submit button_theme_main button_size_md button__control js-form-search-button']")).Click();
        //    System.Threading.Thread.Sleep(5000);
        //}

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    webDriverChrome.Navigate().GoToUrl("https://nordwindairlines.ru/");
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).Click();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).Clear();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).SendKeys("Москва");
        //    System.Threading.Thread.Sleep(2000);
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > div > div > a:nth-child(2)")).Click();

        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).Click();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).Clear();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).SendKeys("Санкт-Петербург");
        //    System.Threading.Thread.Sleep(2000);
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > div > div > a.menu__item.js-location-item.item_show")).Click();

        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(2) > div.number.number_theme_main.js-counter-container > input")).Click();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(2) > div.number.number_theme_main.js-counter-container > input")).Clear();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(2) > div.number.number_theme_main.js-counter-container > input")).SendKeys("9");

        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(3) > div.number.number_theme_main.js-counter-container > input")).Click();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(3) > div.number.number_theme_main.js-counter-container > input")).Clear();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(3) > div.number.number_theme_main.js-counter-container > input")).SendKeys("1");

        //    webDriverChrome.FindElement(By.XPath("//button[@class='search-form__button button button_type_submit button_theme_main button_size_md button__control js-form-search-button']")).Click();
        //    System.Threading.Thread.Sleep(5000);
        //    //webDriverChrome.FindElement(By.XPath("//button[@id='index_login_button']")).Click();//кнопку не нахожу
        //}

        //[TestMethod]
        //public void TestMethod3()
        //{
        //    webDriverChrome.Navigate().GoToUrl("https://nordwindairlines.ru/");
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).Click();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).Clear();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).SendKeys("Москва");
        //    System.Threading.Thread.Sleep(2000);
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > div > div > a:nth-child(2)")).Click();

        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).Click();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).Clear();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).SendKeys("Москва");
        //    System.Threading.Thread.Sleep(2000);
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > div > div > a:nth-child(1)")).Click();


        //    webDriverChrome.FindElement(By.XPath("//button[@class='search-form__button button button_type_submit button_theme_main button_size_md button__control js-form-search-button']")).Click();
        //    System.Threading.Thread.Sleep(5000);
        //}

        //[TestMethod]
        //public void TestMethod4()
        //{
        //    webDriverChrome.Navigate().GoToUrl("https://nordwindairlines.ru/");
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).Click();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).Clear();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).SendKeys("Москва");
        //    System.Threading.Thread.Sleep(2000);
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > div > div > a:nth-child(2)")).Click();

        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).Click();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).Clear();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).SendKeys("Бангкок");
        //    System.Threading.Thread.Sleep(2000);
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > div > div > a.menu__item.js-location-item.item_show")).Click();

        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(1) > div.number.number_theme_main.js-counter-container > input")).Click();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(1) > div.number.number_theme_main.js-counter-container > input")).Clear();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(1) > div.number.number_theme_main.js-counter-container > input")).SendKeys("3");

        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(2) > div.number.number_theme_main.js-counter-container > input")).Click();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(2) > div.number.number_theme_main.js-counter-container > input")).Clear();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(2) > div.number.number_theme_main.js-counter-container > input")).SendKeys("3");


        //    webDriverChrome.FindElement(By.XPath("//button[@class='search-form__button button button_type_submit button_theme_main button_size_md button__control js-form-search-button']")).Click();
        //    System.Threading.Thread.Sleep(5000);
        //}


        //[TestMethod]
        //public void TestMethod5()
        //{
        //    webDriverChrome.Navigate().GoToUrl("https://nordwindairlines.ru/");
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).Click();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).Clear();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).SendKeys("Москва");
        //    System.Threading.Thread.Sleep(2000);
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > div > div > a:nth-child(2)")).Click();

        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).Click();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).Clear();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).SendKeys("Бангкок");
        //    System.Threading.Thread.Sleep(2000);
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > div > div > a.menu__item.js-location-item.item_show")).Click();

        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(1) > div.number.number_theme_main.js-counter-container > input")).Click();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(1) > div.number.number_theme_main.js-counter-container > input")).Clear();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(1) > div.number.number_theme_main.js-counter-container > input")).SendKeys("3");

        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(2) > div.number.number_theme_main.js-counter-container > input")).Click();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(2) > div.number.number_theme_main.js-counter-container > input")).Clear();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(2) > div.number.number_theme_main.js-counter-container > input")).SendKeys("2");

        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(3) > div.number.number_theme_main.js-counter-container > input")).Click();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(3) > div.number.number_theme_main.js-counter-container > input")).Clear();
        //    webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(3) > div.number.number_theme_main.js-counter-container > input")).SendKeys("2");

        //    webDriverChrome.FindElement(By.XPath("//button[@class='search-form__button button button_type_submit button_theme_main button_size_md button__control js-form-search-button']")).Click();
        //    System.Threading.Thread.Sleep(5000);
        //}

        [TestMethod]
        public void TestMethod6()
        {
            webDriverChrome.Navigate().GoToUrl("https://nordwindairlines.ru/");
            webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).Click();
            webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).Clear();
            webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")).SendKeys("Москва");
            System.Threading.Thread.Sleep(2000);
            webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > div > div > a:nth-child(2)")).Click();

            webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).Click();
            webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).Clear();
            webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")).SendKeys("Бангкок");
            System.Threading.Thread.Sleep(2000);
            webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > div > div > a.menu__item.js-location-item.item_show")).Click();

            webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(1) > div.number.number_theme_main.js-counter-container > input")).Click();
            webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(1) > div.number.number_theme_main.js-counter-container > input")).Clear();
            webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(1) > div.number.number_theme_main.js-counter-container > input")).SendKeys("3");

            webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(2) > div.number.number_theme_main.js-counter-container > input")).Click();
            webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(2) > div.number.number_theme_main.js-counter-container > input")).Clear();
            webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(2) > div.number.number_theme_main.js-counter-container > input")).SendKeys("2");

            webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(3) > div.number.number_theme_main.js-counter-container > input")).Click();
            webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(3) > div.number.number_theme_main.js-counter-container > input")).Clear();
            webDriverChrome.FindElement(By.CssSelector("body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(3) > div.number.number_theme_main.js-counter-container > input")).SendKeys("2");

            webDriverChrome.FindElement(By.XPath("//button[@class='search-form__button button button_type_submit button_theme_main button_size_md button__control js-form-search-button']")).Click();

            webDriverChrome.FindElement(By.CssSelector("body > div > section > div.content.content-search-result > div > div > wrap > search-mono-brand-cartesian-variants > div > div > div.flightTableWrap.mobileHide > div.flightTable > table > tbody > tr.headrow > td:nth-child(2) > div > span > a")).Click();
            System.Threading.Thread.Sleep(2000);
            webDriverChrome.FindElement(By.CssSelector("#compare > div.title > div > a")).Click();
            System.Threading.Thread.Sleep(2000);
            webDriverChrome.FindElement(By.CssSelector("body > div > section > div.content.content-search-result > div > div > wrap > search-mono-brand-cartesian-variants > div > div > div.flightTableWrap.mobileHide > div.flightTable > table > tbody > tr.contentRow > td.active > wrap > a")).Click();
        }



        // разрушение объекта драйвера после окончание теста.
        [TestCleanup]
        public void TearDown()
        {

            webDriverChrome.Quit();
        }
    }
}