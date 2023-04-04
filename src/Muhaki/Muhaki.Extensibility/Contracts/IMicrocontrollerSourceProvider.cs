using Muhaki.Extensibility.Core;


namespace Muhaki.Extensibility.Contracts;

public interface IMicrocontrollerSourceProvider
{
    MicrocontrollerSource TryCreateMicrocontroller(Registers registers, Memory memory);
}