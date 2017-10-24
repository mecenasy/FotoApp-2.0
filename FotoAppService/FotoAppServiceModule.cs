using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Prism.Modularity;
using Prism.Regions;

namespace FotoAppService
{
    public class FotoAppServiceModule : IModule
    {
        private readonly RegionManager _region;

        public FotoAppServiceModule(RegionManager region)
        {
            _region = region;
        }

        public void Initialize()
        {
            _region.RegisterViewWithRegion("Table", typeof(Table));
        }
    }
}
