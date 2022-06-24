using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Appium.iOS;
using System.Threading;

namespace csharp_appium_first

{
    class Program
    {
        static void Main(string[] args)
        {
            AppiumOptions caps = new AppiumOptions();

            caps.AddAdditionalCapability("LT_USERNAME", "Your_Username"); //Enter the Username here
            caps.AddAdditionalCapability("LT_ACCESSKEY", "Your_AccessKey");  //Enter the Access key here

            // Set URL of the application under test
            caps.AddAdditionalCapability("app", "LT_App"); //Enter the App URL here.

            // Specify device and os_version
            caps.AddAdditionalCapability("deviceName", "iPhone 12"); //Change the device name here
            caps.AddAdditionalCapability("platformVersion", "15"); 
            caps.AddAdditionalCapability("platformName", "iOS");
            caps.AddAdditionalCapability("isRealMobile", true);
            caps.AddAdditionalCapability("network", true);

            caps.AddAdditionalCapability("project", "First CSharp project");
            caps.AddAdditionalCapability("build", "CSharp iOS");
            caps.AddAdditionalCapability("name", "first_test");

            // ADD THE APP URL OF OTHER APPS THAT YOU'D LIKE TO INSTALL ON THE SAME DEVICE

            caps.AddAdditionalCapability("otherApps", "['App_1', 'App_2']");   //ENTER THE OTHER APP URLs HERE IN AN ARRAY FORMAT

            IOSDriver<IOSElement> driver = new IOSDriver<IOSElement>(
                new Uri("https://mobile-hub.lambdatest.com/wd/hub"), caps);

            IOSElement color = (IOSElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Id("color"))
            );
            color.Click();
            color.Click();

            IOSElement text = (IOSElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Id("Text"))
            );
            text.Click();

            IOSElement toast = (IOSElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Id("toast"))
            );
            toast.Click();

            IOSElement nf = (IOSElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Id("notification"))
            );
            nf.Click();

            driver.Quit();

        }
    }
}
