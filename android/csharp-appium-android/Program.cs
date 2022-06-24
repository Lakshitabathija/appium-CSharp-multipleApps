using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Appium.iOS;
using System.Threading;

namespace csharp_appium

{
    class Program
    {
        static void Main(string[] args)
        {
            AppiumOptions caps = new AppiumOptions();
 
            caps.AddAdditionalCapability("LT_USERNAME", "LT_USERNAME");  //Add the LT Username
            caps.AddAdditionalCapability("LT_ACCESS_KEY", "LT_ACCESS_KEY");  //Add the LT Access key

            // Set URL of the application under test
            caps.AddAdditionalCapability("app", "App_ID"); //Add the App ID

            // Specify device and os_version
            caps.AddAdditionalCapability("deviceName", "Galaxy S21 Ultra 5G");  //Add the Device Details
            caps.AddAdditionalCapability("platformVersion", "11");
            caps.AddAdditionalCapability("platformName", "Android");
            caps.AddAdditionalCapability("isRealMobile", true);
            caps.AddAdditionalCapability("network", true);

            caps.AddAdditionalCapability("project", "CSharp Sample Android");
            caps.AddAdditionalCapability("build", "CSharp Sample Android");
            caps.AddAdditionalCapability("name", "CSharp Sample Android");

            // ADD THE APP URL OF OTHER APPS THAT YOU'D LIKE TO INSTALL ON THE SAME DEVICE

            caps.AddAdditionalCapability("otherApps", "['App_1', 'App_2']");   //ENTER THE OTHER APP URLs HERE IN AN ARRAY FORMAT

            // Initialize the remote Webdriver using LambdaTest remote URL
            // and desired capabilities defined above
            IOSDriver<IOSElement> driver = new IOSDriver<IOSElement>(
                new Uri("https://mobile-hub.lambdatest.com/wd/hub"), caps);

            // Test case for the sample iOS app. 
            // If you have uploaded your app, update the test case here.
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
