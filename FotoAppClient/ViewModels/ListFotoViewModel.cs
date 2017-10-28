using FotoAppClient.Views;
using Microsoft.Practices.Unity;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;

namespace FotoAppClient.ViewModels
{
    public class ListFotoViewModel : BindableBase
    {
        private readonly IEventAggregator _aggregator;
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;
        private IRegion _region;
        private int _page;


        public DelegateCommand UpCommand { get; private set; }
        public DelegateCommand DawnCommand { get; private set; }

        public int Page
        {
            get => _page;
            private set
            {
                _page = value;
                OnPropertyChanged(() => Page);
            }
        }

        public ListFotoViewModel(IEventAggregator aggregator, IRegionManager regionManager, IUnityContainer container)
        {
            _aggregator = aggregator;
            _regionManager = regionManager;
            _container = container;
        }

        

        private void InicialiseCommand()
        {
            UpCommand = new DelegateCommand(Up, CanUp);
            DawnCommand = new DelegateCommand(Dawn, CanDawn);
        }

        private bool CanDawn()
        {
            throw new System.NotImplementedException();
        }

        private void Dawn()
        {
            throw new System.NotImplementedException();
        }

        private bool CanUp()
        {
            throw new System.NotImplementedException();
        }

        private void Up()
        {
            throw new System.NotImplementedException();
        }
    }
}
