using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Open chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// Open turn up portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/");

//Enter valid user name and password
IWebElement userNameTextbox = driver.FindElement(By.Id("UserName"));
userNameTextbox.SendKeys("hari");
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

IWebElement logInButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
logInButton.Click();

//checking user is successfully logged in or not
IWebElement loggedInUser = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (loggedInUser.Text == "Hello hari!")
{
    Console.WriteLine("User Logged in Successfully");
}
else
{
    Console.WriteLine("User is not logged in successfully");
}

