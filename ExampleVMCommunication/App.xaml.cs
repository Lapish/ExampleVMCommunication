using ExampleVMCommunication.Contracts;
using ExampleVMCommunication.Services;
using ExampleVMCommunication.Views;
using Prism.Ioc;
using Prism.Regions;
using System.Windows;

namespace ExampleVMCommunication
{
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void OnInitialized()
        {
            var regionManager = Container.Resolve<IRegionManager>();

            //Регистрируем в регионах 2 UserControl
            regionManager.RegisterViewWithRegion(Regions.LeftRegion, typeof(LeftView));
            regionManager.RegisterViewWithRegion(Regions.RightRegion, typeof(RightView));

            base.OnInitialized();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ICarService, CarService>();
        }
    }
}
