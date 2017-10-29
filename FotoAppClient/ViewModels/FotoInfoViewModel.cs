using System.Windows;
using System.Windows.Media.Imaging;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;

namespace FotoAppClient.ViewModels
{
    public class FotoInfoViewModel: BindableBase
    {
        private readonly IEventAggregator _aggregator;

        #region Propertis

        private BitmapImage _image;
        private int _countImage;
        public BitmapImage Image
        {
            get => _image;
            private set
            {
                _image = value;
                OnPropertyChanged(() => Image);
            }
        }

        public int CountImage
        {
            get => _countImage;
            set
            {
                _countImage = value;
                OnPropertyChanged(() => CountImage);
            }
        }
      

        #endregion

        # region Text Buttons
        
        private string _okButton;
        private string _upButton;
        private string _downButton;

        public string DownButton
        {
            get => _downButton;
            set
            {
                _downButton = value;
                OnPropertyChanged(() => DownButton);
            }
        }

        public string OkButton
        {
            get => _okButton;
            set
            {
                _okButton = value; 
                OnPropertyChanged(() => OkButton);
            }
        }
        public string UpButton
        {
            get => _upButton;
            set
            {
                _upButton = value;
                OnPropertyChanged(() => UpButton);
            }
        }
        #endregion

        #region Command

        public DelegateCommand DownCommand { get; private set; }
        public DelegateCommand UpCommand { get; private set; }
        public DelegateCommand OkCommand { get; private set; }

        #endregion

        #region Constractor

        public FotoInfoViewModel(IEventAggregator aggregator)
        {
            

            _aggregator = aggregator;
            InitializeButtons();
            InicialiseCommands();
        }

        private void InicialiseCommands()
        {
            _downButton = "Sub";
            _upButton = "Up";
            _okButton = "Zatwierdź";
            _countImage = 1;
        }

        private void InitializeButtons()
        {
            DownCommand = new DelegateCommand(Sub,CanSub).ObservesProperty(() => CountImage);
            UpCommand = new DelegateCommand(Add);
            OkCommand = new DelegateCommand(Ok, CanOk).ObservesProperty(() => CountImage);
        }

        private void Add()
        {
            ++CountImage;
        }

        private bool CanOk() => _countImage > 1;

        private void Ok()
        {
            MessageBox.Show("ok");
        }

        private bool CanSub() => _countImage > 1;

        private void Sub()
        {
            --CountImage;
        }

        #endregion

    }
}
