using ExampleVMCommunication.Contracts;
using System;

namespace ExampleVMCommunication.Services
{
    internal class CarService : ICarService
    {
        public event EventHandler<Car> SelectedCarChanged;

        public void SetSelectedCar(Car car)
        {
            SelectedCarChanged?.Invoke(this, car);
        }
    }
}
