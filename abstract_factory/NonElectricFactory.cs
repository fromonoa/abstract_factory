namespace AbstractFactory
{
    internal class NonElectricFactory : VehicleFactory
    {

        public NonElectricFactory()
        {


        }

        public Car CreateCar()
        {
            return new SUV();

        }

        public Bike CreateBike()
        {
            return new Mountainbike();

        }
    }

}
