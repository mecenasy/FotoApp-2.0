using System;
using System.Collections.Generic;
using System.Text;
using FotoAppCommands.FotoAppClientCommands;
using Prism.Commands;

namespace FotoAppCommands
{
    public class Cos
    {
        private readonly IDupa _dupa;

        public Cos(IDupa dupa)
        {
            _dupa = dupa;

            UpdateCommand = new DelegateCommand(Update);

            _dupa.dupa.RegisterCommand(UpdateCommand);

        }

        private void Update()
        {
            throw new NotImplementedException();
        }

        public DelegateCommand UpdateCommand { get; set; }
    }
}
