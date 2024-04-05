﻿namespace CursoArraysCollections
{
    public class BusRouteRepository
    {
        public static BusRoute[] InitializeRoutes()
        {
            return new BusRoute[] {
                new BusRoute(40, "Morecambe", "Preston" ),
                new BusRoute(42, "Lancaster", "Blackpool"),
                new BusRoute(100, "University", "Morecambe"),
                new BusRoute(555, "Lancaster",  "Keswick")
            };
        }
    }
}