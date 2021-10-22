using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountries
{
    class CountryController
    {
        public List<Country> CountryDb { get; set; }

        public CountryController()
        {
            CountryDb = new List<Country>()
            {
                new Country("USA", Continents.North_America, new List<ConsoleColor> {ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Blue }),
                new Country("Madagascar", Continents.Africa, new List<ConsoleColor> { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.White }),
                new Country("Brazil", Continents.South_America, new List<ConsoleColor> { ConsoleColor.Green, ConsoleColor.Yellow }),
                new Country("Sri Lanka", Continents.Asia, new List<ConsoleColor> { ConsoleColor.Blue, ConsoleColor.Yellow}),
                new Country("Germany", Continents.Europe, new List<ConsoleColor> { ConsoleColor.Black, ConsoleColor.Red, ConsoleColor.DarkYellow}),
                new Country("Fiji", Continents.Oceania, new List<ConsoleColor> {ConsoleColor.Blue}),
            };
        }
        
        public void CountryAction(Country c)
        {
            CountryView country1 = new CountryView(c);
            country1.Display();
        }

        public void WelcomeAction()
        {
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");            
        }

        public void CountryListAction()
        {
            CountryListView countryList1 = new CountryListView(CountryDb);
            countryList1.Display();

            int indexChoice = Validator.Validator.GetInt(1, CountryDb.Count) - 1; //account for index starting at 0
            Country countryChoice = CountryDb[indexChoice];

            CountryAction(countryChoice);
        }
    }
}
