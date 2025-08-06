using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public record Car(
       int Id,
       string Make,
       string Model,
       int ManufactureYear,
       string VIN,
       string Color,
       int MaxSpeed
   );

    internal class CarRepository
    {
        public static IEnumerable<Car> GetCars()
        {
            return new List<Car>
            {
                new Car(1, "Toyota", "Camry", 2022, "1HGBH41JXMN109186", "White", 180),
                new Car(2, "Honda", "Civic", 2021, "2HGFC2F59MH123456", "Black", 175),
                new Car(3, "BMW", "X5", 2023, "WBAFV1C50DD123789", "Blue", 220),
                new Car(4, "Mercedes", "C-Class", 2022, "WDDGF4HB8DR456123", "Silver", 200),
                new Car(5, "Audi", "A4", 2021, "WAUZZZ8K2LA987654", "Red", 190),
                new Car(6, "Ford", "Mustang", 2023, "1FA6P8TH5N5321456", "Yellow", 250),
                new Car(7, "Chevrolet", "Malibu", 2020, "1G1ZD5ST4LF789123", "Gray", 170),
                new Car(8, "Nissan", "Altima", 2022, "1N4AL3AP8NC654987", "White", 165),
                new Car(9, "Hyundai", "Elantra", 2021, "KMHL14JA1MA147258", "Black", 160),
                new Car(10, "Kia", "Optima", 2023, "5XXG54J27PG369741", "Blue", 175),
                new Car(11, "Lexus", "ES", 2022, "58ABK1GG8NU852963", "Silver", 185),
                new Car(12, "Infiniti", "Q50", 2021, "JN1EV7AR5LM741852", "Red", 195),
                new Car(13, "Acura", "TLX", 2023, "19UUB2F36PA963147", "White", 180),
                new Car(14, "Cadillac", "CTS", 2020, "1G6AR5SX3L0258741", "Black", 210),
                new Car(15, "Lincoln", "MKZ", 2022, "3LN6L2GK0NR159753", "Gray", 188)
            };
        }
        public static void PrintCars(IEnumerable<Car> cars)
        {
            Console.WriteLine($"{"ID",-3} {"Make",-12} {"Model",-10} {"Year",-6} {"VIN",-17} {"Color",-8} {"MaxSpeed",-10}");
            Console.WriteLine(new string('-', 75));

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Id,-3} {car.Make,-12} {car.Model,-10} {car.ManufactureYear,-6} {car.VIN,-17} {car.Color,-8} {car.MaxSpeed,-10}");
            }
        }
    }
}
