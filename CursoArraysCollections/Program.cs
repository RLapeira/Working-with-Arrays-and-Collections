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
                route42
            };

            Console.WriteLine(route40);
            Console.WriteLine(route42);
        }
    }
}