using ExampleVMCommunication.Contracts;
using ExampleVMCommunication.Services;
using Prism.Mvvm;

namespace ExampleVMCommunication.ViewModels
{
    internal class RightViewModel : BindableBase
    {
        private Car _selectedCar;
        public Car SelectedCar
        {
            get => _selectedCar;
            set => SetProperty(ref _selectedCar, value);
        }

        public RightViewModel(ICarService carService)
        {
            //Подписываемся на событие и в лямбде присваиваем значение
            carService.SelectedCarChanged += (s, car) => SelectedCar = car;
        }
    }
}
