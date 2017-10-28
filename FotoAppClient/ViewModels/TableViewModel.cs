using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using SubEvent;

namespace FotoAppClient.ViewModels
{
    public class TablesViewModel : BindableBase
    {
        private readonly IEventAggregator _aggregator;
       

       
        public TablesViewModel(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
            cos = "kfhuj ci w dupe";
            Command  = new DelegateCommand(Update);
        }

        private void Update()
        {
            _aggregator.GetEvent<PubSubModuleEvent>().Publish("Service");
        }

        public DelegateCommand Command { get; set; }
        public string  cos { get; set; }
    }
}
