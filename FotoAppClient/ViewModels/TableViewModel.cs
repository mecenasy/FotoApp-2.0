using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using FotoAppCommands;
using FotoAppCommands.FotoAppClientCommands;
using Prism.Commands;
using Prism.Mvvm;

namespace FotoAppClient.ViewModels
{
    public class TableViewModel : BindableBase
    {
        private readonly IDupa _duoa;

//        public TableViewModel(IDupa duoa)
        public TableViewModel()
        {
           // _duoa = duoa;
            cos = "kfhuj ci w dupe";
            Command  = new DelegateCommand(Update);

            //_duoa.dupa.RegisterCommand(Command);
        }

        private void Update()
        {
            throw new NotImplementedException();
        }

        public DelegateCommand Command { get; set; }
        public string  cos { get; set; }
    }
}
