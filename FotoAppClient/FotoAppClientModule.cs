using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FotoAppClient.Views;
using Prism.Modularity;
using Prism.Regions;

namespace FotoAppClient
{
    public class FotoAppClientModule : IModule
    {
        private readonly RegionManager _region;

        public FotoAppClientModule(RegionManager region)
        {
            _region = region;
        }
        public void Initialize()
        {
            _region.RegisterViewWithRegion("Table", typeof(Table));
        }
    }
}
