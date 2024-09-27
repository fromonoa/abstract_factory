namespace AbstractFactory
{
    internal class ElecticFactory : VehicleFactory
    {
        public ElecticFactory()
        {


        }
        public Car CreateCar()
        {

            return new ElectricCar();

        }

        public Bike CreateBike()
        {

            return new ElecticBike();

        }


    }
}
