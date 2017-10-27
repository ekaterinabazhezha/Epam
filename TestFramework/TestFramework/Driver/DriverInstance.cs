﻿using OpenQA.Selenium;
using System;
using System.Diagnostics;
using OpenQA.Selenium.Chrome;


namespace TestFramework.Driver
{
    public class DriverInstance
    {

        private static IWebDriver driver;

        private DriverInstance() { }

        public static IWebDriver GetInstance()
        {

            if (driver == null)
            {

         
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static void CloseBrowser()
        {
            driver.Quit();
            driver = null;

            foreach (var process in Process.GetProcessesByName("geckodriver"))
            {
                process.Kill();
            }
        }
    }
}