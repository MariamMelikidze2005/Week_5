using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week__5
{
    public class Car
    {
        public string Brand {  get; set; }

        public int Year { get; set; }

        public Car(string brand, int year)
        {
            Brand = brand;
            Year = year;
            ValidationOfTheYear();
        }


        public void ValidationOfTheYear()
        {
            if (Year < 1886) Year = 1886;
            if (Year > DateTime.Now.Year) Year  = DateTime.Now.Year;
        }
    }
}
