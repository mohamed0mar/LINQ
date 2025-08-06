namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = CarRepository.GetCars();
            ///LINQ - Language Integrated Query
            ///LINQ is a powerful feature in C# that allows you to query collections in a more readable and concise way.
            ///It provides a consistent way to query different data sources like arrays, lists, databases, XML, etc.
            ///LINQ can be used with any collection that implements IEnumerable<T> or IQueryable<T> interface.
            ///LINQ provides two main syntaxes:
            ///1. Query Syntax: This syntax is similar to SQL and is more readable for complex queries.
            ///2. Method Syntax: This syntax uses extension methods and is more concise for simple queries.



            #region Print Cars
            //Console.WriteLine("All Cars:");
            //CarRepository.PrintCars(cars);

            //Console.WriteLine("\n\nCars manufactured after 2021:");
            //var newCars = cars.Where(c => c.ManufactureYear > 2021);
            //CarRepository.PrintCars(newCars); 
            #endregion

            #region Where
            //LINQ Where method is used to filter a sequence of values based on a predicate[Condition].

            //LINQ query syntax
            //var result = from c in cars
            //             where c.MaxSpeed > 200 && c.ManufactureYear >= 2023
            //             select c;

            //LINQ method syntax [Extintion method syntax ]
            //var result = cars.Where((c, i) => c.MaxSpeed > 200 && i <= 20);
            //CarRepository.PrintCars(result);

            #endregion


            #region First || FirstOrDefault
            //LINQ First method is used to return the first element of a sequence that satisfies a specified condition.
            //If no element satisfies the condition, it throws an exception Or is no Element in Collection.
            ////LINQ FirstOrDefault method is used to return the first element of a sequence that satisfies a specified condition.
            //If no element satisfies the condition, it returns the default value of the type (null for reference types, 0 for numeric types, etc.)

            //var result = cars.First();
            //var result = cars.First(c => c.ManufactureYear >= 2023);


            //cars = []; //Empty collection to demonstrate FirstOrDefault
            //var result = cars.FirstOrDefault();
            //var result = cars.FirstOrDefault(c => c.VIN == "1HGBH41JXMN109186");
            //if the cars is empty we can Dafault value of the type 
            
            Car defaultCar = new Car(1, "Default Car", "Default",2000, "Default", "Default",000);
        
            var result = cars.FirstOrDefault(defaultCar);


            Console.WriteLine(result);
            #endregion


        }
    }
}
