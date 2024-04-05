namespace CursoArraysCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRoute route40 = new BusRoute(40, "Morecambe", "Preston");
            BusRoute route42 = new BusRoute(42, "Lancaster", "Blackpool");

            BusRoute[] routes =
            {
                route40,
                route42,
                new BusRoute(100, "University", "Morecambe"),
                new BusRoute(555, "Lancaster", "Keswick")
            };

            BusRoute firstRoute = routes[0];
            Console.WriteLine($"The third route is {routes[2]}");
            BusRoute lastRoute = routes[^1];  // igual a routes[routes.Length-1];
            Console.WriteLine($"The last route is {lastRoute}");

            //foreach (BusRoute route in routes)
            //{
            //    Console.WriteLine(route);
            //}
        }
    }
}