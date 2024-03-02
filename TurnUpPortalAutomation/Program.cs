using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortalAutomation.Pages;

public class Program
{
   private static void Main(string[] args)
    {
        //Open chrome browser
        IWebDriver driver = new ChromeDriver();
       
        
        LoginPage loginPage = new LoginPage();
        loginPage.LoginActions(driver, "hari", "123123");

        HomePage homePage = new HomePage();
        homePage.VerifyLoggedInUser(driver);
        homePage.NavigateToTMPage(driver);

        TimeAndMaterialPage timeAndMaterialPage = new TimeAndMaterialPage();
        timeAndMaterialPage.CreateTimeandMaterial(driver);
        timeAndMaterialPage.editTimeAndMaterial(driver);
        timeAndMaterialPage.deleteTimeAndMaterial(driver);

   }
}