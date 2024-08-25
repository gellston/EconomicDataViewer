using ConvMVVM.Core.IOC;
using ConvMVVM.WPF.Component;
using EconomicDataViewer.Service;
using EconomicDataViewer.View;
using EconomicDataViewer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EconomicDataViewer
{
    public class App : ConvMVVMApp
    {

        #region Protected Functions
        protected override void ConfigureServiceCollection(IServiceCollection serviceCollection)
        {

            //Service
            serviceCollection.RegisterCache<FedAPIService>();
            serviceCollection.RegisterCache<AppSettingService>();

            //ViewModel
            serviceCollection.RegisterCache<MainWindowViewModel>();

        }

        protected override void ConfigureServiceLocator()
        {
           
        }

        protected override void ConfigureServiceProvider(IServiceContainer serviceProvider)
        {
            
        }

        protected override Window CreateWindow(IServiceContainer serviceProvider)
        {
            return new MainWindowView();
        }
        #endregion
    }
}
