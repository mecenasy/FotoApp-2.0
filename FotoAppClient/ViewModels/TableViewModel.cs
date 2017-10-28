using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using FotoAppClient.Views;
using FotoAppCommands;
using FotoAppService.Views;
using Microsoft.Practices.Unity;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Events;

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
            _aggregator.GetEvent<PubSubEvent<string>>().Publish("Service");
        }

        public DelegateCommand Command { get; set; }
        public string  cos { get; set; }
    }

    internal class MessageSentEvent
    {
    }
}
