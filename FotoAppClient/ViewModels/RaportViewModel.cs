using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using Prism.Mvvm;

namespace FotoAppClient.ViewModels
{
    public class RaportViewModel: BindableBase
    {
        private readonly IEventAggregator _aggregator;
        private double _totalPrice;
        private string _raport;

        public double TotalPrice
        {
            get => _totalPrice;
            private set
            {
                _totalPrice = value;
                OnPropertyChanged(() => TotalPrice);
            }
        }

        #region Constractor

        public RaportViewModel(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
            _totalPrice = 124.32;
        }

        #endregion
    }
}
