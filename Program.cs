using System;
using System.Collections.Generic;

namespace BilbasenKonsol
{
    public class Car
    {
        public string Brand = "";
        public string Model = "";
        public int Year;
        public string Color = "";
        public int HorsePower;
        public int NumberOfcylinders;

        public Car(string brand, string model, int year, string color, int cylinders)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Color = color;
            this.NumberOfcylinders = cylinders;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car fordMustang1963 = new Car("Ford", "Mustang", 1963, "Red", 430);
            Car toyotaCamry2020 = new Car("Toyota", "Camry", 2020, "Blue", 200);
            Car chevyCorvette2022 = new Car("Chevrolet", "Corvette", 2022, "Silver", 650);
            Car tesla = new Car("Tesla", "Model S", 2023, "Black", 600);

            List<Car> CarList = new List<Car>();

            CarList.Add(fordMustang1963);
            CarList.Add(toyotaCamry2020);
            CarList.Add(chevyCorvette2022);
            CarList.Add(tesla);


            //Udskriv alle biler som har over 200HK.
            Console.WriteLine("Udskriv alle biler som har over 200HK.");
            foreach (Car car in CarList)
            {
                if (car.NumberOfcylinders>200)
                Console.WriteLine(car.Brand);
            }Console.WriteLine();

            Console.WriteLine("Udskriv alle røde biler.");
            foreach (Car car in CarList)
            {
                if (car.Color=="Red")
                Console.WriteLine(car.Brand);
            }Console.WriteLine();

            Console.WriteLine("Udskriv alle biler som er mellem årgang 1980 og 1999");
            foreach (Car car in CarList)
            {
                if (car.Year > 1980 && car.Year < 1999)
                Console.WriteLine(car.Brand);
            }Console.WriteLine();
            /*
            1. Udskriv alle biler som deler mærke med den første bil i jeres datasæt.
            2. Udskriv alle biler som har over 200HK.
            3. Udskriv alle røde biler.
            4. Udskriv antallet af biler som har samme mærke som den første bil
            5. Udskriv alle biler som er mellem årgang 1980 og 1999
            */
        }
    }
}
