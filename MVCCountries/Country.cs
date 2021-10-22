using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountries
{
    class Country
    {
        public string Name { get; set; }
        public Continents Continent { get; set; }
        public List<ConsoleColor> Colors { get; set; }

        public Country(string name, Continents continent, List<ConsoleColor> colors)
        {
            Name = name;
            Colors = colors;
            Continent = continent;
        }
    }
}
