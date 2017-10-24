using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FotoApp.Main;
using FotoAppClient;
using FotoAppCommands;
using FotoAppService;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Unity;

namespace FotoApp
{
    class Bootstraper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            
            if (Application.Current.MainWindow != null) Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            Container.RegisterType<IFotoAppCommand, FotoAppCommand>(new ContainerControlledLifetimeManager());
        }

        protected override void ConfigureViewModelLocator()
        {
            ViewModelLocationProvider.Register<Shell, ShellViewModel>();

        }

        protected override void ConfigureModuleCatalog()
        {
            var catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(FotoAppClientModule));
            catalog.AddModule(typeof(FotoAppServiceModule));
        }
    }
}
