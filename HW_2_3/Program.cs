namespace HW_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
            {
                new Airplane(100.0,1_000_000.0, "AiroplaneModel1", 27650.0),
                new Airplane(90.0,1_120_000.0, "AiroplaneModel2", 24650.0),
                new Airplane(105.0,1_050_000.0, "AiroplaneModel3", 23650.0),
                new Airplane(95.0,1_101_000.0, "AiroplaneModel4", 22650.0),

                new Bus(80.0,8_000, "BusModel1"),
                new Bus(90.0,9_100_000.0, "BusModel2"),

                new FamilyCar(100.0,3_000.0, "FamilyCarModel1"),
                new SportCar(300.0,1_100.0, "SportCarModel2")
            };
            Array.Sort(vehicles);

            vehicles.Write();

            Vehicle[] flybles = vehicles.FindAll(el => el is IFlyble).ToArray();
            flybles.Write();

            Vehicle[] fast = vehicles.FindAll(el => el.Speed >= 95).ToArray();
            fast.Write();

            Console.ReadKey();

        }
    }
}