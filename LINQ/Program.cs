namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = CarRepository.GetCars();

            Console.WriteLine("All Cars:");
            CarRepository.PrintCars(cars);

           
        }
    }
}
