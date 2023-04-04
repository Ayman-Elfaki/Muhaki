using Muhaki.Extensibility.Attributes;
using Muhaki.Extensibility.Contracts;

namespace Muhaki.MOS6502;

[Microcontroller("MOS 6502")]
[Registers<RegistersSource>]
public sealed class MicrocontrollerSourceProvider : IMicrocontrollerSourceProvider
{
}