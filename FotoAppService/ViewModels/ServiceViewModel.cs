using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Events;
using SubEvent;

namespace FotoAppService.ViewModels
{
    public class ServiceViewModel
    {
        private readonly IEventAggregator _aggregator;

        public ServiceViewModel(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
            Command = new DelegateCommand(Update);

        }

        private void Update()
        {
            _aggregator.GetEvent<PubSubModuleEvent>().Publish("Table");
        }

        public DelegateCommand Command { get; set; }
    }
}
