namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory efactory = new ElecticFactory();
            VehicleClient client1 = new VehicleClient(efactory);
            client1.ShowVehicles();

            VehicleFactory factory = new NonElectricFactory();
            VehicleClient client2 = new VehicleClient(factory);
            client2.ShowVehicles();


        }
    }
}