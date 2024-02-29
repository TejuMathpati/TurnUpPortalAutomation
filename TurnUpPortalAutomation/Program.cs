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


// Atomation for time and material
// Navigate to Time and material modeule
IWebElement administartionDrpdown = driver.FindElement(By.XPath("//a[text()='Administration ']"));
administartionDrpdown.Click();

IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("//a[contains(text(),'Time & Materials')]"));
timeAndMaterialOption.Click();

//create new Time and material entry
IWebElement createNewButton = driver.FindElement(By.XPath("//a[contains(text(),'Create New')]"));
createNewButton.Click();


IWebElement selectTimeOptionDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
selectTimeOptionDropdown.Click();

IWebElement selectTimeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
selectTimeOption.Click();

IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("123");

IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("Testing");

IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceTextbox.SendKeys("50");

// save new time and material entry
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(2000);

// check that entry is saved or not
IWebElement pageArrowButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
pageArrowButton.Click();

IWebElement newRecordDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
Thread.Sleep(2000);
if (newRecordDescription.Text == "Testing")
{
    Console.WriteLine("Record is created successsfully");

}
else
{
    Console.WriteLine("Record is not created");
}