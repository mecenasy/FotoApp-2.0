using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace FotoAppService.ViewModels
{
    public class ServiceViewModel
    {
        private readonly IEventAggregator _aggregator;

        public ServiceViewModel(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
        }
    }
}
