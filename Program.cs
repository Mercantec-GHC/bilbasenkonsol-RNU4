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
        public int NumberOfCylinders;

        public Car(string brand, string model, int year, string color, int cylinders, int horsepower)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Color = color;
            this.NumberOfCylinders = cylinders;
            this.HorsePower = horsepower;
        }
    }

    public class ElectricCar : Car
    {
        public int BatteryCapacity;

        public ElectricCar(string brand, string model, int year, string color, int batteryCapacity, int horsepower)
            : base(brand, model, year, color, 0, horsepower)
        {
            this.BatteryCapacity = batteryCapacity;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car fordMustang1963 = new Car("Ford", "Mustang", 1963, "Red", 8, 430);
            Car toyotaCamry2020 = new Car("Toyota", "Camry", 2020, "Blue", 6, 200);
            Car chevyCorvette2022 = new Car("Chevrolet", "Corvette", 2022, "Silver", 8, 650);
            ElectricCar teslaModelS = new ElectricCar("Tesla", "Model S", 2023, "Black", 100, 670);
            ElectricCar nissanLeaf2019 = new ElectricCar("Nissan", "Leaf", 2019, "Green", 60, 147); // Example value

            List<Car> CarList = new List<Car>();

            CarList.Add(fordMustang1963);
            CarList.Add(toyotaCamry2020);
            CarList.Add(chevyCorvette2022);
            CarList.Add(teslaModelS);
            CarList.Add(nissanLeaf2019);

            // Print all cars with over 200 horsepower
            Console.WriteLine("Print all cars with over 200 horsepower:");
            foreach (Car car in CarList)
            {
                if (car.HorsePower > 200)
                    Console.WriteLine(car.Brand + " " + car.Model);
            }
            Console.WriteLine();

            // Print all red cars
            Console.WriteLine("Print all red cars:");
            foreach (Car car in CarList)
            {
                if (car.Color == "Red")
                    Console.WriteLine(car.Brand + " " + car.Model);
            }
            Console.WriteLine();

            // Print all cars between the years 1980 and 1999
            Console.WriteLine("Print all cars between the years 1980 and 1999:");
            foreach (Car car in CarList)
            {
                if (car.Year > 1980 && car.Year < 1999)
                    Console.WriteLine(car.Brand + " " + car.Model);
            }
            Console.WriteLine();
        }
    }
}
