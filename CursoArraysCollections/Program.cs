﻿namespace CursoArraysCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var allRoutes = BusRouteRepository.InitializeRoutes();

            Console.WriteLine("Which route do you want to look up?");
            int number = int.Parse(Console.ReadLine());

            BusRoute answer = allRoutes[number];

            if (answer != null)
            {
                Console.WriteLine($"The route you asked for is {answer}");
            }
            else
            {
                Console.WriteLine($"There is no route with number {number}");
            }
        }
    }
}