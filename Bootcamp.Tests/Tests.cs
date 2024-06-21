using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Bootcamp.Tests
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Gebruik WebDriverManager om de ChromeDriver te configureren
            driver = new ChromeDriver();
        }

        [Test]
        public void TestLogin()
        {
            // Navigeer naar de loginpagina
            driver.Navigate().GoToUrl("https://greatshop.polteq-testing.com/index.php?controller=authentication&back=my-account");

            // Vul gebruikersnaam en wachtwoord in
            IWebElement usernameField = driver.FindElement(By.Id("email"));
            IWebElement passwordField = driver.FindElement(By.Id("passwd"));
            IWebElement loginButton = driver.FindElement(By.Id("SubmitLogin"));

            usernameField.SendKeys("rtj.lans@gmail.com");
            passwordField.SendKeys("password123");
            loginButton.Click();

            // Controleer of we succesvol zijn ingelogd door te zoeken naar 'Sign out' in de header
            bool isLoggedIn = driver.FindElement(By.XPath("//*[contains(text(), 'Sign out')]")).Displayed;
            Assert.IsTrue(isLoggedIn, "Login niet succesvol");
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}
