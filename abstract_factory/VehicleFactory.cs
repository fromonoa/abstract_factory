namespace AbstractFactory
{
    internal interface VehicleFactory
    {
        Car CreateCar();
        Bike CreateBike();

    }
}
