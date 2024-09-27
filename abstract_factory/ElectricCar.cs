namespace AbstractFactory
{
    internal class ElectricCar : Car
    {
        public ElectricCar()
        {
        }

        public void Driving()
        {

            Console.WriteLine("Someone is currently driving an Electric Car.");

        }
    }
}
