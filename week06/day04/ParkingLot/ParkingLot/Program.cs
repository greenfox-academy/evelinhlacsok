﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Car class with 2 enum properties
            //enum of car types
            //The types of these cars or vehicles is up to you
            //enum of colors
            //Create 256 Vehicles randomly and put them into a List
            //Count and Print the number of same vehicles for each type
            //Count and Print the number of same vehicles for each color
            //Print the most frequently occurring vehicle

            Random random = new Random();
            int carNumber = 256;
            List<Car> carList = new List<Car>();
            int randomTypeMax = Enum.GetValues(typeof(Type)).Length;
            int randomColorMax = Enum.GetValues(typeof(Color)).Length;


            for (int i = 1; i <= carNumber; i++)
            {
                 carList.Add(new Car((Type)random.Next(randomTypeMax), (Color)random.Next(randomColorMax)));
            }

            Console.WriteLine("List of cars: ");

            foreach (var car in carList)
            {
                 Console.WriteLine(car.Type.ToString() + " "+ car.Color.ToString());
            }
            Console.WriteLine();

            FindSameTypeCars(carList);
            Console.WriteLine();
            FindSameTypeCarsWLambda(carList);
            Console.WriteLine();
            FindSameTypeCarsWQuery(carList);
            Console.WriteLine();

            FindSameColorCarsWLambda(carList);
            Console.WriteLine();
            FindSameColorCarsWQuery(carList);
            Console.WriteLine();

            MostFrequentVehicleQuery(carList);
            Console.WriteLine();
            MostFrequentVehicleLambda(carList);
            Console.ReadLine();
        }

        private static void FindSameTypeCars(List<Car> carList)
        {
            var sameTypeHonda = from honda in carList
                                where honda.Type == Type.Honda
                                select honda;

            var sameTypeToyota = from toyota in carList
                                 where toyota.Type == Type.Toyota
                                 select toyota;

            var sameTypeVolvo = from volvo in carList
                                where volvo.Type == Type.Volvo
                                select volvo;

            var sameTypeAudi = from audi in carList
                               where audi.Type == Type.Audi
                               select audi;
           
            Console.WriteLine("Number of Honda: {0}, number of Toyota: {1}, number of Volvo: {2}, number of Audi: {3}",
                    sameTypeHonda.Count(), sameTypeToyota.Count(), sameTypeVolvo.Count(), sameTypeAudi.Count());
        }

        private static void FindSameTypeCarsWLambda(List<Car> carList)
        {
            var sameType = carList.GroupBy(x => x.Type).ToDictionary(x => x.Key, x => x.Count());

            foreach (var car in sameType)
            {
                Console.WriteLine("Car number in type: \n" + car);
            }
        }

        private static void FindSameTypeCarsWQuery(List<Car> carList)
        {
            var sameTypeWQuery = from car in carList
                                 group car by new { car.Type } into sameType
                                 select new { sameType.Key, Count = (from car in sameType select car).Count() };

            foreach (var car in sameTypeWQuery)
            {
                Console.WriteLine("Car number in type: \n" + car);
            }
        }

        private static void FindSameColorCarsWLambda(List<Car> carList)
        {
            var sameColor = carList.GroupBy(x => x.Color).ToDictionary(x => x.Key, x => x.Count());

            foreach (var car in sameColor)
            {
                Console.WriteLine("Car number in color: \n" + car);
            }
        }

        private static void FindSameColorCarsWQuery(List<Car> carList)
        {
            var sameColorWQuery = from car in carList
                                  group car by new { car.Color } into sameColor
                                  select new { sameColor.Key, Count = (from car in sameColor select car).Count() };

            foreach (var car in sameColorWQuery)
            {
                Console.WriteLine("Car number in color: with query \n" + car);
            }
        }

        private static void MostFrequentVehicleQuery(List<Car> carList)
        {
            var mostFrequent = (from freq in carList
                                group freq by new { freq.Color, freq.Type } into mostOccouring
                                orderby mostOccouring.Count() descending
                                select new { mostOccouring.Key, Count = (from freq in mostOccouring select freq).Count() }).Take(1);

            foreach (var car in mostFrequent)
            {
                Console.WriteLine("The most frequent type and color car is: " + car);
            }
        }

        private static void MostFrequentVehicleLambda(List<Car> carList)
        {
            var mostFrequentCar = carList
                .GroupBy(car => new { Color = car.Color, Type = car.Type })
                .ToDictionary(item => item.Key, item => item.Count())
                .OrderByDescending(item => item.Value)
                .Take(1);

            foreach (var car in mostFrequentCar)
            {
                Console.WriteLine("The most frequent type and color car is: " + car);
            }
        }
    }
}
