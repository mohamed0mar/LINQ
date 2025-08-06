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
                // Toyota Cars
                new Car(1, "Toyota", "Camry", 2022, "1HGBH41JXMN109186", "White", 180),
                new Car(2, "Toyota", "Corolla", 2021, "1HGBH41JXMN109187", "Black", 165),
                new Car(3, "Toyota", "RAV4", 2023, "1HGBH41JXMN109188", "Blue", 175),
                new Car(4, "Toyota", "Prius", 2022, "1HGBH41JXMN109189", "Green", 160),
                new Car(5, "Toyota", "Highlander", 2021, "1HGBH41JXMN109190", "Silver", 185),
                
                // Honda Cars
                new Car(6, "Honda", "Civic", 2021, "2HGFC2F59MH123456", "Black", 175),
                new Car(7, "Honda", "Accord", 2023, "2HGFC2F59MH123457", "White", 180),
                new Car(8, "Honda", "CR-V", 2022, "2HGFC2F59MH123458", "Red", 170),
                new Car(9, "Honda", "Pilot", 2021, "2HGFC2F59MH123459", "Gray", 185),
                new Car(10, "Honda", "Fit", 2020, "2HGFC2F59MH123460", "Blue", 155),
                
                // BMW Cars
                new Car(11, "BMW", "X5", 2023, "WBAFV1C50DD123789", "Blue", 220),
                new Car(12, "BMW", "3 Series", 2022, "WBAFV1C50DD123790", "Black", 210),
                new Car(13, "BMW", "X3", 2021, "WBAFV1C50DD123791", "White", 200),
                new Car(14, "BMW", "5 Series", 2023, "WBAFV1C50DD123792", "Silver", 225),
                new Car(15, "BMW", "Z4", 2022, "WBAFV1C50DD123793", "Red", 240),
                
                // Mercedes Cars
                new Car(16, "Mercedes", "C-Class", 2022, "WDDGF4HB8DR456123", "Silver", 200),
                new Car(17, "Mercedes", "E-Class", 2023, "WDDGF4HB8DR456124", "Black", 215),
                new Car(18, "Mercedes", "GLC", 2021, "WDDGF4HB8DR456125", "White", 195),
                new Car(19, "Mercedes", "S-Class", 2023, "WDDGF4HB8DR456126", "Gray", 230),
                new Car(20, "Mercedes", "A-Class", 2022, "WDDGF4HB8DR456127", "Blue", 185),
                
                // Audi Cars
                new Car(21, "Audi", "A4", 2021, "WAUZZZ8K2LA987654", "Red", 190),
                new Car(22, "Audi", "Q5", 2023, "WAUZZZ8K2LA987655", "Black", 205),
                new Car(23, "Audi", "A6", 2022, "WAUZZZ8K2LA987656", "White", 210),
                new Car(24, "Audi", "Q7", 2021, "WAUZZZ8K2LA987657", "Silver", 220),
                new Car(25, "Audi", "TT", 2023, "WAUZZZ8K2LA987658", "Yellow", 235),
                
                // Ford Cars
                new Car(26, "Ford", "Mustang", 2023, "1FA6P8TH5N5321456", "Yellow", 250),
                new Car(27, "Ford", "F-150", 2022, "1FA6P8TH5N5321457", "Black", 180),
                new Car(28, "Ford", "Explorer", 2021, "1FA6P8TH5N5321458", "White", 175),
                new Car(29, "Ford", "Edge", 2023, "1FA6P8TH5N5321459", "Gray", 170),
                new Car(30, "Ford", "Escape", 2022, "1FA6P8TH5N5321460", "Blue", 165),
                
                // Chevrolet Cars
                new Car(31, "Chevrolet", "Malibu", 2020, "1G1ZD5ST4LF789123", "Gray", 170),
                new Car(32, "Chevrolet", "Camaro", 2023, "1G1ZD5ST4LF789124", "Red", 245),
                new Car(33, "Chevrolet", "Equinox", 2022, "1G1ZD5ST4LF789125", "White", 165),
                new Car(34, "Chevrolet", "Tahoe", 2021, "1G1ZD5ST4LF789126", "Black", 190),
                new Car(35, "Chevrolet", "Corvette", 2023, "1G1ZD5ST4LF789127", "Yellow", 280),
                
                // Nissan Cars
                new Car(36, "Nissan", "Altima", 2022, "1N4AL3AP8NC654987", "White", 165),
                new Car(37, "Nissan", "Sentra", 2021, "1N4AL3AP8NC654988", "Black", 160),
                new Car(38, "Nissan", "Rogue", 2023, "1N4AL3AP8NC654989", "Silver", 170),
                new Car(39, "Nissan", "Pathfinder", 2022, "1N4AL3AP8NC654990", "Blue", 175),
                new Car(40, "Nissan", "370Z", 2021, "1N4AL3AP8NC654991", "Red", 230),
                
                // Hyundai Cars
                new Car(41, "Hyundai", "Elantra", 2021, "KMHL14JA1MA147258", "Black", 160),
                new Car(42, "Hyundai", "Sonata", 2023, "KMHL14JA1MA147259", "White", 175),
                new Car(43, "Hyundai", "Tucson", 2022, "KMHL14JA1MA147260", "Gray", 170),
                new Car(44, "Hyundai", "Santa Fe", 2021, "KMHL14JA1MA147261", "Blue", 180),
                new Car(45, "Hyundai", "Genesis", 2023, "KMHL14JA1MA147262", "Silver", 220),
                
                // Kia Cars
                new Car(46, "Kia", "Optima", 2023, "5XXG54J27PG369741", "Blue", 175),
                new Car(47, "Kia", "Forte", 2022, "5XXG54J27PG369742", "White", 165),
                new Car(48, "Kia", "Sorento", 2021, "5XXG54J27PG369743", "Black", 185),
                new Car(49, "Kia", "Sportage", 2023, "5XXG54J27PG369744", "Red", 180),
                new Car(50, "Kia", "Stinger", 2022, "5XXG54J27PG369745", "Gray", 215),
                
                // Lexus Cars
                new Car(51, "Lexus", "ES", 2022, "58ABK1GG8NU852963", "Silver", 185),
                new Car(52, "Lexus", "RX", 2023, "58ABK1GG8NU852964", "White", 190),
                new Car(53, "Lexus", "IS", 2021, "58ABK1GG8NU852965", "Black", 200),
                new Car(54, "Lexus", "GX", 2022, "58ABK1GG8NU852966", "Gray", 195),
                new Car(55, "Lexus", "LC", 2023, "58ABK1GG8NU852967", "Blue", 245),
                
                // Infiniti Cars
                new Car(56, "Infiniti", "Q50", 2021, "JN1EV7AR5LM741852", "Red", 195),
                new Car(57, "Infiniti", "Q60", 2023, "JN1EV7AR5LM741853", "White", 210),
                new Car(58, "Infiniti", "QX50", 2022, "JN1EV7AR5LM741854", "Black", 185),
                new Car(59, "Infiniti", "QX80", 2021, "JN1EV7AR5LM741855", "Silver", 200),
                new Car(60, "Infiniti", "Q70", 2020, "JN1EV7AR5LM741856", "Gray", 190),
                
                // Acura Cars
                new Car(61, "Acura", "TLX", 2023, "19UUB2F36PA963147", "White", 180),
                new Car(62, "Acura", "MDX", 2022, "19UUB2F36PA963148", "Black", 185),
                new Car(63, "Acura", "RDX", 2021, "19UUB2F36PA963149", "Silver", 175),
                new Car(64, "Acura", "ILX", 2023, "19UUB2F36PA963150", "Blue", 170),
                new Car(65, "Acura", "NSX", 2022, "19UUB2F36PA963151", "Red", 290),
                
                // Cadillac Cars
                new Car(66, "Cadillac", "CTS", 2020, "1G6AR5SX3L0258741", "Black", 210),
                new Car(67, "Cadillac", "Escalade", 2023, "1G6AR5SX3L0258742", "White", 200),
                new Car(68, "Cadillac", "XT5", 2022, "1G6AR5SX3L0258743", "Gray", 190),
                new Car(69, "Cadillac", "CT6", 2021, "1G6AR5SX3L0258744", "Silver", 205),
                new Car(70, "Cadillac", "ATS", 2020, "1G6AR5SX3L0258745", "Blue", 195),
                
                // Lincoln Cars
                new Car(71, "Lincoln", "MKZ", 2022, "3LN6L2GK0NR159753", "Gray", 188),
                new Car(72, "Lincoln", "Navigator", 2023, "3LN6L2GK0NR159754", "Black", 195),
                new Car(73, "Lincoln", "Continental", 2021, "3LN6L2GK0NR159755", "White", 185),
                new Car(74, "Lincoln", "Corsair", 2022, "3LN6L2GK0NR159756", "Silver", 180),
                new Car(75, "Lincoln", "Aviator", 2023, "3LN6L2GK0NR159757", "Blue", 190),
                
                // Volkswagen Cars
                new Car(76, "Volkswagen", "Jetta", 2022, "3VW2K7AJ5NM456789", "White", 170),
                new Car(77, "Volkswagen", "Passat", 2021, "3VW2K7AJ5NM456790", "Black", 175),
                new Car(78, "Volkswagen", "Tiguan", 2023, "3VW2K7AJ5NM456791", "Gray", 180),
                new Car(79, "Volkswagen", "Atlas", 2022, "3VW2K7AJ5NM456792", "Blue", 185),
                new Car(80, "Volkswagen", "Golf", 2021, "3VW2K7AJ5NM456793", "Red", 165),
                
                // Subaru Cars
                new Car(81, "Subaru", "Outback", 2023, "4S4BSANC5N3258741", "Green", 175),
                new Car(82, "Subaru", "Forester", 2022, "4S4BSANC5N3258742", "White", 170),
                new Car(83, "Subaru", "Impreza", 2021, "4S4BSANC5N3258743", "Black", 165),
                new Car(84, "Subaru", "Legacy", 2023, "4S4BSANC5N3258744", "Silver", 180),
                new Car(85, "Subaru", "WRX", 2022, "4S4BSANC5N3258745", "Blue", 220),
                
                // Mazda Cars
                new Car(86, "Mazda", "Mazda3", 2022, "JM1BK32F7N1456789", "Red", 170),
                new Car(87, "Mazda", "CX-5", 2023, "JM1BK32F7N1456790", "White", 175),
                new Car(88, "Mazda", "Mazda6", 2021, "JM1BK32F7N1456791", "Black", 180),
                new Car(89, "Mazda", "CX-9", 2022, "JM1BK32F7N1456792", "Gray", 185),
                new Car(90, "Mazda", "MX-5", 2023, "JM1BK32F7N1456793", "Yellow", 200),
                
                // Mitsubishi Cars
                new Car(91, "Mitsubishi", "Outlander", 2022, "JA4J3TA89NZ456789", "Silver", 175),
                new Car(92, "Mitsubishi", "Eclipse", 2021, "JA4J3TA89NZ456790", "Black", 190),
                new Car(93, "Mitsubishi", "Lancer", 2020, "JA4J3TA89NZ456791", "White", 165),
                new Car(94, "Mitsubishi", "ASX", 2023, "JA4J3TA89NZ456792", "Blue", 170),
                new Car(95, "Mitsubishi", "Pajero", 2022, "JA4J3TA89NZ456793", "Gray", 180),
                
                // Jeep Cars
                new Car(96, "Jeep", "Wrangler", 2023, "1C4HJWEG5NL456789", "Green", 185),
                new Car(97, "Jeep", "Grand Cherokee", 2022, "1C4HJWEG5NL456790", "Black", 190),
                new Car(98, "Jeep", "Compass", 2021, "1C4HJWEG5NL456791", "White", 175),
                new Car(99, "Jeep", "Cherokee", 2023, "1C4HJWEG5NL456792", "Red", 180),
                new Car(100, "Jeep", "Gladiator", 2022, "1C4HJWEG5NL456793", "Blue", 195)
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
