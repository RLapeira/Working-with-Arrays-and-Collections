namespace CursoArraysCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRoute[] allRoutes = BusRouteRepository.InitializeRoutes();

            Console.WriteLine($"Before: There are {allRoutes.Length} routes:");
            foreach (BusRoute route in allRoutes)
            {
                Console.WriteLine($"Route: {route}");
            }

            Array.Resize(ref allRoutes, 4);

            Console.WriteLine($"\r\nAfter: There are {allRoutes.Length} routes:");
            foreach (BusRoute route in allRoutes)
                Console.WriteLine($"Route: {route}");
        }
    }
}