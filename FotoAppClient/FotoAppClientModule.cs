using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FotoAppClient.Views;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace FotoAppClient
{
    public class FotoAppClientModule : IModule
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;
        private IRegion _region;
        public FotoAppClientModule(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
            
        }
        public void Initialize()
        {
            var table = _container.Resolve<GetFotoView>();
            _region = _regionManager.Regions["Table"];
            _region.Add(table, "Table");
            _region.Activate(table);
        }
    }
}
