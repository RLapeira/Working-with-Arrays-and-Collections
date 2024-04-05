namespace CursoArraysCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var allRoutes = BusRouteRepository.InitializeRoutes();

            Console.WriteLine("Which route do you want to look up?");
            int number = int.Parse(Console.ReadLine());

            bool success = allRoutes.TryGetValue(number, out BusRoute answer);
            // Si existe, devuelve true y el valor por answer
            // más rápido que:

            // bool success = allRoutes.ContainsKey(number);
            // Solo devuelve true o false

            // porque solo busca el valor una vez

            if (answer != null)
            {
                Console.WriteLine($"The route you asked for is {answer}"); // {allRoutes[number]}
            }
            else
            {
                Console.WriteLine($"There is no route with number {number}");
            }
        }
    }
}