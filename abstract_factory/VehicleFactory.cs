using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface VehicleFactory
    {
        void createCar(Car car);
        void createBike(Bike bike);

    }
}
