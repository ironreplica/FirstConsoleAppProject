using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static FirstConsoleAppProject.DaysUntilChristmas;
using static FirstConsoleAppProject.FahrenheitToCelcius;

namespace FirstConsoleAppProject
{
    internal class Questions
    {
        private DaysUntilChristmas daysUntilChristmas = new DaysUntilChristmas();
        private FahrenheitToCelcius fahrenheitToCelcius = new FahrenheitToCelcius();
        public void AskAboutYou(string name)
        {
            
            Console.WriteLine($"Hello, {name}, where are you from?");
            string location = Console.ReadLine();
            if (location != null && location != "") {
                IHaventBeenThere(location);
            }
            
        }
        public void IHaventBeenThere(string location)
        {
            Console.WriteLine($"I have never been to, {location}. I bet it is awesome there.");
            Console.WriteLine("Press any key to continue...");
            if (Console.ReadKey() != null)
            {
                DaysUntilChristmas();
            }
        }
        public void DaysUntilChristmas()
        {
            Console.WriteLine($"Todays date is {DateTime.Today.ToString()}");
            Console.WriteLine(daysUntilChristmas.daysUntilChristmas());
            Console.WriteLine("Press any key to continue...");
            if (Console.ReadKey() != null)
            {
                CtoF();
            }
        }
        public void CtoF()
        {
            Console.WriteLine($"Wanna see a cool trick? Give me a temperature value in Fahrenheit, and I will convert it to Celcius for you:");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your input: {f}");
            Console.WriteLine($"Celcius value: {fahrenheitToCelcius.FtoC(f)}");
        }
    }
}
