using ExampleVMCommunication.Contracts;
using ExampleVMCommunication.Services;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace ExampleVMCommunication.ViewModels
{
    internal class LeftViewModel : BindableBase
    {
        #region Fields

        private readonly ICarService _carService;
        private Car _seletedCar;

        #endregion

        #region Properties

        public ObservableCollection<Car> Cars { get; private set; }

        public Car SelectedCar
        {
            get => _seletedCar;
            set
            {
                _seletedCar = value;
                _carService.SetSelectedCar(value);
            }
        }

        #endregion

        public LeftViewModel(ICarService carService)
        {
            _carService = carService;

            InitCars();
        }

        /// <summary>
        /// Инициализация с дефолтными значениями
        /// </summary>
        private void InitCars()
        {
            Cars = new()
            {
                new()
                {
                    Brand = "Toyota",
                    Model = "Camry",
                    Year = 2022
                },
                new()
                {
                    Brand = "Ford",
                    Model = "F-150",
                    Year = 2021
                },
                new()
                {
                    Brand = "Honda",
                    Model = "Civic",
                    Year = 2019
                },
                new()
                {
                    Brand = "Chevrolet",
                    Model = "Malibu",
                    Year = 2020
                },
                new()
                {
                    Brand = "Nissan",
                    Model = "Altima",
                    Year = 2022
                }
            };
        }
    }
}
