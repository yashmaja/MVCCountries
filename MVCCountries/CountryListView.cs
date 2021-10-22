using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountries
{
    class CountryListView
    {
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }

        public void Display()
        {
            int i = 1;
            Countries.ForEach(country => Console.WriteLine($"{i++}. {country.Name}"));
        }
    }
}
