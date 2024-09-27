namespace AbstractFactory
{
    internal class VehicleClient
    {
        private Car car;
        private Bike bike;

        public VehicleClient(VehicleFactory factory)
        {
            car = factory.CreateCar();
            bike = factory.CreateBike();
        }

        public void ShowVehicles()
        {
            car.Driving();
            bike.Riding();
        }
    }
}
