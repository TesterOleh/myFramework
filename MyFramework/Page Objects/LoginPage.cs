﻿using OpenQA.Selenium;

namespace MyFramework.Page_Objects
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        /// <summary>
        /// Method is filling username and password and clicks login button
        /// </summary>
        /// <param name="username">username input</param>
        /// <param name="password">password input</param>
        /// <returns>Login page with web driver - can be used by next method</returns>
        public LoginPage Login(string username, string password)
        {
            driver.FindElement(By.Name("loginForm.login")).SendKeys(username);
            driver.FindElement(By.Name("loginForm.password")).SendKeys(password);
            driver.FindElement(By.Name("ok")).Click();
            return new LoginPage(driver);
        }

        /// <summary>
        /// Method cleasr username field on Login page
        /// </summary>
        /// <returns>Login page with web driver - can be used by next method</returns>
        public LoginPage ClearUsernameField()
        {
            driver.FindElement(By.Name("loginForm.login")).Clear();
            return new LoginPage(driver);
        }

    }
}
