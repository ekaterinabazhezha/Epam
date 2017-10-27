using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace TestFramework.Pages
{
    public class MainPage
    {
        private const string BASE_URL = "https://nordwindairlines.ru/";

        [FindsBy(How = How.CssSelector, Using = "body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > span > span.input__box > input")]
        private IWebElement Сity​​OfDeparture;

        [FindsBy(How = How.CssSelector, Using = "body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > span > span > input")]
        private IWebElement Сity​​OfArrival;

        [FindsBy(How = How.CssSelector, Using = "body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > button")]
        private IWebElement buttonTicketSearch;

        [FindsBy(How = How.CssSelector, Using = "body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(1) > div.number.number_theme_main.js-counter-container > input")]
        private IWebElement NumberOfAdults;

        [FindsBy(How = How.CssSelector, Using = "body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(2) > div.number.number_theme_main.js-counter-container > input")]
        private IWebElement NumberOfTeenagers;

        [FindsBy(How = How.CssSelector, Using = "body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(3) > div > div:nth-child(3) > div.number.number_theme_main.js-counter-container > input")]
        private IWebElement NumberOfInfants;

        [FindsBy(How = How.XPath, Using = "#dp1514901065273")]
        private IWebElement DepartureDate;

        //выпадающий список куда//
        [FindsBy(How = How.CssSelector, Using = "body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > div > div > a:nth-child(1)")]
        private IWebElement WhenceMoscow;

        [FindsBy(How = How.CssSelector, Using = "body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > div > div > a:nth-child(1)")]
        private IWebElement WhenceMinsk;

        //выпадающий список куда//
        [FindsBy(How = How.CssSelector, Using = "body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(1) > div > div > a:nth-child(2)")]
        private IWebElement WhenceMoscowSh;

        [FindsBy(How = How.CssSelector, Using = "body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > div > div > a:nth-child(4)")]
        private IWebElement WhencePiter;

        [FindsBy(How = How.CssSelector, Using = "body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__extra > div:nth-child(2) > div:nth-child(2) > div > div > a:nth-child(6)")]
        private IWebElement WhenceBankock;

        [FindsBy(How = How.CssSelector, Using = "#dp1514907851252")]
        private IWebElement Date;

        [FindsBy(How = How.CssSelector, Using = "body > div > section > div.content.content-search-result > div > div > wrap > search-mono-brand-cartesian-variants > div > div > div.flightTableWrap.mobileHide > div.flightTable > table > tbody > tr.headrow > td:nth-child(2) > div > span")]
        private IWebElement Search;

        [FindsBy(How = How.CssSelector, Using = "# compare > div.title > div > a")]
        private IWebElement Close;

        [FindsBy(How = How.CssSelector, Using = "body > div > section > div.content.content-search-result > div > div > wrap > search-mono-brand-cartesian-variants > div > div > div.flightTableWrap.mobileHide > div.flightTable > table > tbody > tr.contentRow > td.active > wrap > a")]
        private IWebElement Flight;

        [FindsBy(How = How.CssSelector, Using = "body > div.wrapper > main > div.search.search_type_flights.search_theme_main > div.search__wrap > form > div > div.search-form__tabs.search-tab > a.search-tab__item.search-tab__item_view_ticket")]
        private IWebElement MyTicket;

        [FindsBy(How = How.CssSelector, Using = "body > div > section > div.content > div > div > div > div.orderSearchForm__i > div > form > div.formBodyItem > div > div > div > div > div:nth-child(1) > div > div > input")]
        private IWebElement NumberOfTicket;

        [FindsBy(How = How.CssSelector, Using = "body > div > section > div.content > div > div > div > div.orderSearchForm__i > div > form > div.formBodyItem > div > div > div > div > div:nth-child(2) > div > div > input")]
        private IWebElement ReservationName;

        [FindsBy(How = How.CssSelector, Using = "body > div > section > div.content > div > div > div > div.orderSearchForm__i > div > form > div.formBodyItem > div > div > button")]
        private IWebElement buttonSearch;

        private IWebDriver driver;
        private WebDriverWait wait;

        public object Utils { get; private set; }

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            // Utils.WriteFile.Write("Main page opened");
        }

        public void TestB1(string there, string back)
        {
            Сity​​OfDeparture.Clear();
            Сity​​OfDeparture.SendKeys(there);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            Сity​​OfArrival.Clear();
            Сity​​OfArrival.SendKeys(back);

            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", buttonTicketSearch);
        }
        public void TestB2(string there, string back, string adults, string infants)
        {
            Сity​​OfDeparture.Clear();
            Сity​​OfDeparture.SendKeys(there);

            WhenceMoscow.Click();

            Сity​​OfArrival.Clear();
            Сity​​OfArrival.SendKeys(back);

            WhencePiter.Click();

            NumberOfAdults.Clear();
            NumberOfAdults.SendKeys(adults);

            NumberOfInfants.Clear();
            NumberOfInfants.SendKeys(infants);

            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", buttonTicketSearch);
        }
        public void TestB3(string there, string back)
        {
            Сity​​OfDeparture.Clear();
            Сity​​OfDeparture.SendKeys(there);

            WhenceMoscow.Click();

            Сity​​OfArrival.Clear();
            Сity​​OfArrival.SendKeys(back);

            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", buttonTicketSearch);
        }
        public void TestB4(string there, string back, string adults, string teenagers, DateTime date)
        {
            Сity​​OfDeparture.Clear();
            Сity​​OfDeparture.SendKeys(there);

            WhenceMoscow.Click();

            Сity​​OfArrival.Clear();
            Сity​​OfArrival.SendKeys(back);

            WhenceBankock.Click();

            NumberOfAdults.Clear();
            NumberOfAdults.SendKeys(adults);

            NumberOfInfants.Clear();
            NumberOfInfants.SendKeys(teenagers);

            DepartureDate.Clear();
            DepartureDate.SendKeys(Convert.ToString(date));
            //  Date.Click();

            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", buttonTicketSearch);
        }
        public void TestB5(string there, string back, string adults, string teenagers, string infants, DateTime date)
        {
            Сity​​OfDeparture.Clear();
            Сity​​OfDeparture.SendKeys(there);

            WhenceMoscow.Click();

            Сity​​OfArrival.Clear();
            Сity​​OfArrival.SendKeys(back);

            WhenceBankock.Click();

            NumberOfAdults.Clear();
            NumberOfAdults.SendKeys(adults);

            NumberOfInfants.Clear();
            NumberOfInfants.SendKeys(teenagers);

            NumberOfAdults.Clear();
            NumberOfAdults.SendKeys(infants);

            DepartureDate.Clear();
            DepartureDate.SendKeys(Convert.ToString(date));

            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", buttonTicketSearch);
        }


        public void TestB6(string there, string back, string adults, string teenagers, string infants, DateTime date)
        {

            Сity​​OfDeparture.Clear();
            Сity​​OfDeparture.SendKeys(there);

            WhenceMoscow.Click();

            Сity​​OfArrival.Clear();
            Сity​​OfArrival.SendKeys(back);

            WhenceBankock.Click();

            NumberOfAdults.Clear();
            NumberOfAdults.SendKeys(adults);

            NumberOfInfants.Clear();
            NumberOfInfants.SendKeys(teenagers);

            NumberOfAdults.Clear();
            NumberOfAdults.SendKeys(infants);

            DepartureDate.Clear();
            DepartureDate.SendKeys(Convert.ToString(date));

            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", buttonTicketSearch);

            IJavaScriptExecutor sr = (IJavaScriptExecutor)driver;
            sr.ExecuteScript("arguments[0].click();", Search);

            IJavaScriptExecutor cl = (IJavaScriptExecutor)driver;
            cl.ExecuteScript("arguments[0].click();", Close);

            Flight.Click();

        }

        public void TestB7(string there, string back, string adults, string teenagers, string infants, DateTime date)
        {

            Сity​​OfDeparture.Clear();
            Сity​​OfDeparture.SendKeys(there);

            WhenceMoscow.Click();

            Сity​​OfArrival.Clear();
            Сity​​OfArrival.SendKeys(back);

            WhencePiter.Click();

            NumberOfAdults.Clear();
            NumberOfAdults.SendKeys(adults);

            NumberOfInfants.Clear();
            NumberOfInfants.SendKeys(teenagers);

            NumberOfAdults.Clear();
            NumberOfAdults.SendKeys(infants);

            DepartureDate.Clear();
            DepartureDate.SendKeys(Convert.ToString(date));

            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", buttonTicketSearch);

            IJavaScriptExecutor sr = (IJavaScriptExecutor)driver;
            sr.ExecuteScript("arguments[0].click();", Search);

            IJavaScriptExecutor cl = (IJavaScriptExecutor)driver;
            cl.ExecuteScript("arguments[0].click();", Close);

            Flight.Click();

        }

        public void TestB8(string there, string back, DateTime date)
        {

            Сity​​OfDeparture.Clear();
            Сity​​OfDeparture.SendKeys(there);

            WhenceMoscow.Click();

            Сity​​OfArrival.Clear();
            Сity​​OfArrival.SendKeys(back);

            WhenceBankock.Click();


            DepartureDate.Clear();
            DepartureDate.SendKeys(Convert.ToString(date));

            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", buttonTicketSearch);

            IJavaScriptExecutor sr = (IJavaScriptExecutor)driver;
            sr.ExecuteScript("arguments[0].click();", Search);

            IJavaScriptExecutor cl = (IJavaScriptExecutor)driver;
            cl.ExecuteScript("arguments[0].click();", Close);

            Flight.Click();

        }

        public void TestB9(string there, string back, DateTime date)
        {

            Сity​​OfDeparture.Clear();
            Сity​​OfDeparture.SendKeys(there);

            WhenceMoscow.Click();

            Сity​​OfArrival.Clear();
            Сity​​OfArrival.SendKeys(back);

            WhenceBankock.Click();

            DepartureDate.Clear();
            DepartureDate.SendKeys(Convert.ToString(date));

            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", buttonTicketSearch);

            IJavaScriptExecutor sr = (IJavaScriptExecutor)driver;
            sr.ExecuteScript("arguments[0].click();", Search);

            IJavaScriptExecutor cl = (IJavaScriptExecutor)driver;
            cl.ExecuteScript("arguments[0].click();", Close);

            Flight.Click();

        }

        public void TestB10(string number, string name)
        {

            IJavaScriptExecutor tk = (IJavaScriptExecutor)driver;
            tk.ExecuteScript("arguments[0].click();", MyTicket);

            NumberOfTicket.SendKeys(number);

            ReservationName.SendKeys(name);

            IJavaScriptExecutor cl = (IJavaScriptExecutor)driver;
            cl.ExecuteScript("arguments[0].click();", buttonSearch);
        }

        //public void TestB11(DateTime date)
        //{

        //    Date.Clear();
        //    Date.SendKeys(Convert.ToString(date));

        //}
    }
}
