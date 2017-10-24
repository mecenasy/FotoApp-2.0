using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using FotoAppCommands;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;

namespace FotoAppClient.ViewModels
{
    public class TableViewModel : BindableBase
    {
        private readonly IEventAggregator _aggregator;
        private readonly IFotoAppCommand _duoa;

//        public TableViewModel(IFotoAppCommand duoa)
        public TableViewModel(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
            // _duoa = duoa;
            cos = "kfhuj ci w dupe";
            Command  = new DelegateCommand(Update);

            //_duoa.TemplateCommand.RegisterCommand(Command);
        }

        private void Update()
        {
            throw new NotImplementedException();
        }

        public DelegateCommand Command { get; set; }
        public string  cos { get; set; }
    }
}
