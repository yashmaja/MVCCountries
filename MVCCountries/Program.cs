using System;

namespace MVCCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.ResetColor();
                CountryController newCountry = new CountryController();
                newCountry.WelcomeAction();
                newCountry.CountryListAction();
                repeat = Validator.Validator.Repeat("Would you like to learn about another country? ");
            }
        }
    }
}
