using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountries
{
    class CountryView
    {
        Country DisplayCountry { get; set; }
        public CountryView(Country country)
        {
            DisplayCountry = country;
        }

        public void Display()
        {
            //create string to hold all colors in list of country colors
            string colors = "";
            DisplayCountry.Colors.ForEach(color => colors += $"{color} ");
         
            Console.WriteLine($"\n{new string('*', 50)}");
            Console.BackgroundColor = DisplayCountry.Colors[0];
            Console.WriteLine($"Country: {DisplayCountry.Name}");

            if (DisplayCountry.Colors.Count > 1)
            {
                Console.BackgroundColor = DisplayCountry.Colors[1];
            }
            else
            {
                Console.ResetColor();
            }
            
            Console.WriteLine($"Continent: {DisplayCountry.Continent}");
            
            if (DisplayCountry.Colors.Count == 3)
            {
                Console.BackgroundColor = DisplayCountry.Colors[2];
            }
            else
            {
                Console.ResetColor();
            }

            Console.WriteLine($"Colors: {colors}");
            Console.ResetColor();
            Console.WriteLine($"{new string('*', 50)}");
        }
    }
}
