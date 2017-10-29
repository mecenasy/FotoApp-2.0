using System.Windows;
using FotoAppClient.Views;
using Microsoft.Practices.Unity;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;

namespace FotoAppClient.ViewModels
{
    public class GetFotoViewModel :BindableBase
    {
        private readonly IEventAggregator _aggregator;
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;
        private IRegion _region;
        private string _okButton;
        private string _cancelButton;
        public DelegateCommand OkCommand { get; private set; }
        public DelegateCommand CancelCommand { get; private set; }

        public string CancelButton
        {
            get => _cancelButton;
            private set => _cancelButton = value;
        }
        public string OkButton
        {
            get => _okButton;
            private set
            {
                _okButton = value;
                OnPropertyChanged(() => OkButton);
            }
        }
        public GetFotoViewModel(IEventAggregator aggregator, IRegionManager regionManager, IUnityContainer container)
        {
            _aggregator = aggregator;
            _regionManager = regionManager;
            _container = container;
            InicialiseCommand();
            InicialisePanel();

        }
        private void InicialisePanel()
        {
            _regionManager.RegisterViewWithRegion("Main", typeof(ListFotoView));
            _regionManager.RegisterViewWithRegion("LeftRegion", typeof(FotoInfoView));

        }
        public void InicialiseCommand()
        {
            _cancelButton = "Rezygnacja";
            _okButton = "Zatwierdź";
            OkCommand = new DelegateCommand(Ok, CanOK);
            CancelCommand = new DelegateCommand(Cancel);
        }

        private void Ok()
        {
            MessageBox.Show("ok");
        }

        private bool CanOK()
        {
            return true;
        }

        private void Cancel()
        {
            MessageBox.Show("ok");
        }
    }
}
