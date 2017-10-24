﻿using System.Windows.Documents;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;

namespace FotoApp.Main
{
    class ShellViewModel: BindableBase
    {
        private readonly IEventAggregator _aggregator;
        private string _title = "Foto App";
        private int _height = 800;
        private int _width = 1200;

        public ShellViewModel(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
            //region.RegisterViewWithRegion("Table", typeof(Table));
        }
        public string Title
        {
            get => _title;
            set => _title = value;
        }
        public int Height
        {
            get => _height;
            set => _height = value;
        }
        public int Width
        {
            get => _width;
            set => _width = value;
        }
    }
}
