using Prism.Commands;

namespace FotoAppCommands
{
    public class FotoAppCommand :IFotoAppCommand
    {
        private CompositeCommand _templateCommand;
        public FotoAppCommand()
        {
            _templateCommand = new CompositeCommand();
        }
        public CompositeCommand TemplateCommand
        {
            get => _templateCommand;
        }
    }
}
