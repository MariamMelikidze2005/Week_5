using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Week_5;

namespace Week__5
{
    public class Product
    {
        public string Name {  get; set; }
        public decimal Price { get; set; }
        public Currency Currency { get; set; }
        public double Discount { get; set; }

        public void ValidationOfTheProduct()
        {
            if (Price < 0)
            {
                Price = 0;
            }
            

            if (Discount < 0)
            {
                Discount = 0;
            }
            else if (Discount > 1)
            {
                Discount = 1;
            }
        }

        public Product(string name, decimal price, Currency currency, double discount)
        {
            Name = name;
            Currency=currency;
            Discount = discount;
            Price = price;
            ValidationOfTheProduct();


        }

    }

   
}
