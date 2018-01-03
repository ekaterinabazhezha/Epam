using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestFramework;
using TestFramework.Driver;
using TestFramework.Pages;


[TestClass]
public class Tests
{
    public Tests()
    {
        //
        // TODO: добавьте здесь логику конструктора
        //
    }

    private TestContext testContextInstance;

    /// <summary>
    ///Получает или устанавливает контекст теста, в котором предоставляются
    ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
    ///</summary>
    public TestContext TestContext
    {
        get
        {
            return testContextInstance;
        }
        set
        {
            testContextInstance = value;
        }
    }

    #region Дополнительные атрибуты тестирования
    //
    // При написании тестов можно использовать следующие дополнительные атрибуты:
    //
    // ClassInitialize используется для выполнения кода до запуска первого теста в классе
    // [ClassInitialize()]
    // public static void MyClassInitialize(TestContext testContext) { }
    //
    // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
    // [ClassCleanup()]
    // public static void MyClassCleanup() { }
    //
    // TestInitialize используется для выполнения кода перед запуском каждого теста 
    // [TestInitialize()]
    // public void MyTestInitialize() { }
    //
    // TestCleanup используется для выполнения кода после завершения каждого теста
    // [TestCleanup()]
    // public void MyTestCleanup() { }
    //
    #endregion

    [TestMethod]
    public void LackOfaCity()
    {
        var driver = DriverInstance.GetInstance();
        MainPage page = new MainPage(driver);
        page.OpenPage();
      
        page.TestB1("Минск", "Москва");

     
        //
        // TODO: добавьте здесь логику теста
        //
    }

    [TestMethod]
    public void AmountOfChildren()
    {
        var driver = DriverInstance.GetInstance();
        MainPage page = new MainPage(driver);
        page.OpenPage();

        page.TestB2("Москва", "Санкт-Петербург","1","9");
    }

    [TestMethod]
    public void AnotherCity()
    {
        var driver = DriverInstance.GetInstance();
        MainPage page = new MainPage(driver);
        page.OpenPage();

        page.TestB3("Москва", "Москва, Москва, Шереметьево"/*, new DateTime(2017, 12, 27*/);
    }

    [TestMethod]
    public void DepartureAbroad()
    {
        var driver = DriverInstance.GetInstance();
        MainPage page = new MainPage(driver);
        page.OpenPage();

        page.TestB4("Москва", "Бангкок","3","3", "09.01.2018");
    }

    [TestMethod]
    public void TravelAbroadByFamily()
    {
        var driver = DriverInstance.GetInstance();
        MainPage page = new MainPage(driver);
        page.OpenPage();

        page.TestB5("Москва", "Бангкок", "3", "2", "2", "09.01.2018");
    }

    [TestMethod]
    public void PromoEconomyAbroad()
    {
        var driver = DriverInstance.GetInstance();
        MainPage page = new MainPage(driver);
        page.OpenPage();
        page.TestB6("Москва", "Бангкок", "3", "2", "2", "09.01.2018");
    }

    [TestMethod]
    public void PromoEconomyBorder()
    {
        var driver = DriverInstance.GetInstance();
        MainPage page = new MainPage(driver);
        page.OpenPage();
        page.TestB7("Москва", "Санкт-Петербург", "3", "2", "2", "03.01.2018");
    }

    [TestMethod]
    public void PersonalInformation()
    {
        var driver = DriverInstance.GetInstance();
        MainPage page = new MainPage(driver);
        page.OpenPage();
        page.TestB8("Москва", "Бангкок", "09.01.2018");
    }

    [TestMethod]
    public void BirthDateError()
    {
        var driver = DriverInstance.GetInstance();
        MainPage page = new MainPage(driver);
        page.OpenPage();
        page.TestB9("Москва", "Санкт-Петербург", "03.01.2018","01.05.1900");
    }

    [TestMethod]
    public void TicketSearch()
    {
        var driver = DriverInstance.GetInstance();
        MainPage page = new MainPage(driver);
        page.OpenPage();
        page.TestB10("123456789100", "Иванов ");
    }

    //[TestMethod]
    //public void Date()
    //{
    //    var driver = DriverInstance.GetInstance();
    //    MainPage page = new MainPage(driver);


    //    page.OpenPage();
    //    page.TestB11(new DateTime(2018, 12, 27));
    //}

}
//}
