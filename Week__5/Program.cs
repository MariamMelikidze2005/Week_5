using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Week__5;

class Program
{
    static void Main(string[] args)
    {
        // Read 
        string jsonString = File.ReadAllText("C:\\Users\\us store plus\\source\\repos\\Week__5\\Week__5\\data.json");

        // Deserialize
        var DataOfPeople = JsonConvert.DeserializeObject<PeopleWrapper>(jsonString);

       
        foreach (var person in DataOfPeople.People)
        {
            person.ValidateCars();
            person.ValidationOfTheAge();
            person.ValidationOfTheProduct();
            
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

            foreach (var car in person.OwnedCars)
            {
                Console.WriteLine($"Car: {car.Brand}, Year: {car.Year}");
            }

            foreach (var product in person.PurchasedProducts)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}, Currency: {product.Currency}, Discount: {product.Discount}");
            }

            Console.WriteLine(); 
        }
    }
}

public class PeopleWrapper
{
    public List<Person> People { get; set; }
}
