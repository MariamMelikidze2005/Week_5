using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week__5
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Car> OwnedCars { get; set; }
        public List<Product> PurchasedProducts { get; set; }

        public Person()
        {
            OwnedCars = new List<Car>();
            PurchasedProducts = new List<Product>();
            ValidationOfTheAge();
        }
        public void ValidationOfTheAge()
        {
            if (Age < 0) Age = 0;
            if (Age > 120) Age = 120;
        }

        public void ValidateCars()
        {
            foreach (var car in OwnedCars)
            {
                car.ValidationOfTheYear();
            }
        }

        public void ValidationOfTheProduct()
        {
            foreach (var Name in PurchasedProducts)
            {
                Name.ValidationOfTheProduct();
            }
        }
    }
}
