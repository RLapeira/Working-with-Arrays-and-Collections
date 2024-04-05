namespace CursoArraysCollections
{
    public class BusRouteRepository
    {
        public static List<BusRoute> InitializeRoutes()
        {
            List<BusRoute> result = new List<BusRoute>();
            result.Add(new BusRoute(40, new string[] {
                "Morecambe", "Lancaster", "Garstang", "Preston" }));
            result.Add(new BusRoute(42, new string[] {
                "Lancaster", "Garstang", "Blackpool" }));
            result.Add(new BusRoute(1_000, new string[] {
                "Test origin", "Test destination" }));
            result.Add(new BusRoute(5, new string[] {
                "Overton", "Morecambe", "Carnforth" }));
            result.Add(new BusRoute(555, new string[] {
                "Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick" }));
            return result;
        }

    }
}