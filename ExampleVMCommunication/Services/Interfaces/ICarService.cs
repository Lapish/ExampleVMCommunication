using ExampleVMCommunication.Contracts;
using System;

namespace ExampleVMCommunication.Services
{
    internal interface ICarService
    {
        event EventHandler<Car> SelectedCarChanged;
        void SetSelectedCar(Car car);
    }
}
