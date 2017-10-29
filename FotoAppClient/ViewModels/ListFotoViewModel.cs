using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;

namespace FotoAppClient.ViewModels
{
    public class ListFotoViewModel : BindableBase
    {
        private readonly IEventAggregator _aggregator;
        private int _page;
        private int _totalPage;
        public DelegateCommand UpCommand { get; private set; }
        public DelegateCommand DawnCommand { get; private set; }

        public int TotalPages
        {
            get => _totalPage;
            set
            {
                _totalPage = value;
                OnPropertyChanged(() => TotalPages);
            }
            
        }
        public int Page
        {
            get => _page;
            private set
            {
                _page = value;
                OnPropertyChanged(() => Page);
            }
        }

        public ListFotoViewModel(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
            InicialiseCommand();
            _totalPage = 10;
            _page = 2;
        }
        
        private void InicialiseCommand()
        {
            UpCommand = new DelegateCommand(Up, CanUp).ObservesProperty(() => Page);
            DawnCommand = new DelegateCommand(Down, CanDawn).ObservesProperty(() => Page);
        }

        private bool CanDawn() => _page > 1;
        private bool CanUp() => _totalPage > _page;
        private void Down()
        {
           --Page;
        }

        private void Up()
        {
            ++Page;
        }
    }
}
