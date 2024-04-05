namespace CursoArraysCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRouteRepository repository = new BusRouteRepository();

            Console.WriteLine("Where do you want to go to?");
            string location = Console.ReadLine();

            BusRoute[] routes = repository.FindBusesTo(location);

            if (routes.Length > 0)
                foreach (BusRoute route in routes)
                    Console.WriteLine($"You can use route {route}");
            else
                Console.WriteLine($"No routes go to{location}");
        }

    }
}