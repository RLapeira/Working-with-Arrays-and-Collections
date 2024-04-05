namespace CursoArraysCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BusRoute> allRoutes = BusRouteRepository.InitializeRoutes();

            Console.WriteLine($"Before: There are {allRoutes.Count} routes:");
            for (int i = 0; i < allRoutes.Count; i++)
            {
                Console.WriteLine($"Route: {allRoutes[i]}");
            }

            allRoutes.RemoveAll(route => route.Origin.StartsWith("Test "));

            Console.WriteLine($"\r\nAfter: There are {allRoutes.Count} routes:");
            foreach (BusRoute route in allRoutes)
                Console.WriteLine($"Route: {route}");
        }
    }
}