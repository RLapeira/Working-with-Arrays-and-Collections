namespace CursoArraysCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRoute route40 = new BusRoute(40, "Morecambe", "Preston");
            BusRoute route42 = new BusRoute(42, "Lancaster", "Blackpool");

            BusRoute[] routes = new BusRoute[4];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{i}: {routes[i]}");
            }

            //foreach (BusRoute route in routes)
            //{
            //    Console.WriteLine(route);
            //}
        }
    }
}