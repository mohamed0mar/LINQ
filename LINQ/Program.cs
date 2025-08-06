namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = CarRepository.GetCars();

            Console.WriteLine("All Cars:");
            CarRepository.PrintCars(cars);

            Console.WriteLine("\n\nCars manufactured after 2021:");
            var newCars = cars.Where(c => c.ManufactureYear > 2021);
            CarRepository.PrintCars(newCars);
        }
    }
}
