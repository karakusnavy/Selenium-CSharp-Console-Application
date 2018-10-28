using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Selenium_with_console
{
    class Program
    {
       
        static void Main(string[] args)
        {
            IWebDriver driver;
            void opendriver()
            {
                driver = new ChromeDriver();
            }
            string answer;
            Console.WriteLine("Welcome to navigation center.");
            Console.WriteLine("1-) Go to Google");
            Console.WriteLine("2-) Go to My Facebook Profile");
            Console.WriteLine("3-) Go to My Twitter Profile");
            Console.WriteLine("4-) Go to My Instagram Profile");
            Console.WriteLine("5-) Go to My Github Profile");
            Console.Write("Select a number: ");
            answer = Console.ReadLine();
            if (answer == "1")
            { 
            opendriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            }
            else if (answer == "2")
            {
                opendriver();
                driver.Navigate().GoToUrl("https://www.facebook.com/karakusnavy");
            }
            else if (answer == "3")
            {
                opendriver();
                driver.Navigate().GoToUrl("https://www.twitter.com/karakusnavy");
            }
            else if (answer == "4")
            {
                opendriver();
                driver.Navigate().GoToUrl("https://www.instagram.com/karakusnavy");
            }
            else if (answer == "5")
            {
                opendriver();
                driver.Navigate().GoToUrl("https://www.github.com/karakusnavy");
            }

            Console.ReadKey();
        }
    }
}
