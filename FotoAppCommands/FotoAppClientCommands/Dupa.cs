using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;

namespace FotoAppCommands.FotoAppClientCommands
{
    public class Dupa :IDupa
    {
        private CompositeCommand _dupa;
        public Dupa()
        {
            _dupa = new CompositeCommand();
        }
        public CompositeCommand dupa
        {
            get => _dupa;
        }
    }
}
