using Prism.Commands;

namespace FotoAppCommands
{
    public interface IFotoAppCommand
    {
        CompositeCommand TemplateCommand { get; }
    }
}
