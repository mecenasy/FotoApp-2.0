using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using FotoAppService.Views;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace FotoAppService
{
    public class FotoAppServiceModule : IModule
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;
        private IRegion _region;

        public FotoAppServiceModule(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        public void Initialize()
        {
            var service = _container.Resolve<Service>();
            _region = _regionManager.Regions["Table"];
            _region.Add(service, "Service");
           // _region.Activate(service);
        }
    }
}
