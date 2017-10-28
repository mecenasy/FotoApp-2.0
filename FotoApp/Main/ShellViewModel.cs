using System.Runtime.InteropServices;
using System.Windows.Documents;
using FotoAppService.Views;
using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using FotoAppClient.Views;
using Prism.Commands;

namespace FotoApp.Main
{
    class ShellViewModel: BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;
        private readonly IEventAggregator _aggregator;
        private Tables _table;
        private Service _service;
        public  DelegateCommand Command { get; set; }
        private IRegion _region;
        private string _title = "Fotghhkhgcmbvcmbcmbco App";
        private int _height = 800;
        private int _width = 1200;

        public ShellViewModel(IEventAggregator aggregator, IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
            _aggregator = aggregator;
            _aggregator.GetEvent<PubSubEvent<string>>().Subscribe(Update);
            //region.RegisterViewWithRegion("Tables", typeof(Tables));
//            Command = new DelegateCommand(Update);
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

        public void Update(string messages)
        {
            _region = _regionManager.Regions["Table"];

            var toActiveView = _region.GetView(messages);
            var activNameView = _region.Name;
            var toDeActiveView = _region.GetView(activNameView);
            _region.Deactivate(toDeActiveView);
            _region.Activate(toActiveView);
        }
    }
}
