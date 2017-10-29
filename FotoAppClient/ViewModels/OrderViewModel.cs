using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;

namespace FotoAppClient.ViewModels
{
    public  class OrderViewModel: BindableBase
    {
        private readonly IEventAggregator _aggregator;
        private string _selectedItem;
        public DelegateCommand DelCommnand { get; private set; }

        public string SelectedItem
        {
            get=> _selectedItem;
            set => _selectedItem = value;
        }
        public OrderViewModel(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
            InicialiseCommands();
        }

        private void InicialiseCommands()
        {
           DelCommnand = new DelegateCommand(Del);
        }

        private void Del()
        {
            throw new NotImplementedException();
        }
    }
}
