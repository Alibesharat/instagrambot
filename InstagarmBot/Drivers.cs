using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace InstagarmBot
{
    public class Drivers
    {

        public static IWebDriver init(string Drvierpath,string FirefoxPath)
        {

            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService($"{Drvierpath}");
            service.FirefoxBinaryPath = $"{FirefoxPath}"; // May not be necessary
            FirefoxOptions options = new FirefoxOptions();
            options.AddArgument("-no-sandbox");
            TimeSpan time = TimeSpan.FromSeconds(60);
            return new FirefoxDriver(service, options, time);
        }






    }
}
