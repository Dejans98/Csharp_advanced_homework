using VehicleInfo.Vehicles;

namespace VehicleInfo.Helper
{
    public static class VehicleExtensions
    {
        public static void Drive( Vehicle car)
        {
            Console.WriteLine("The car is driving");
        }
        public static void Whellie(Vehicle bike)
        {
            Console.WriteLine("The motor bike is driving on one wheel");
        }
        public static void Sail(Vehicle boat)
        {
            Console.WriteLine("The boat is sailing");
        }
        public static void Fly(Vehicle plain)
        {
            Console.WriteLine("The plain is flying");
        }
    }
}
