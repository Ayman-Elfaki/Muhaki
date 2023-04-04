

using Muhaki.Extensibility.Attributes;
using Muhaki.Extensibility.Contracts;
using Muhaki.Extensibility.Core;
using Muhaki.MOS6502.Instructions;
using Muhaki.MOS6502.Registers;

namespace Muhaki.MOS6502.Core;

[Microcontroller("MOS Technology 6502")]
[ExportRegisters<MOSGeneralRegisters>]
[ExportRegisters<MOSPointerRegisters>]
[ExportRegisters<MOSStatusFlagRegisters>]
[ExportInstructions<MOSLoadInstructions>]
public sealed class MOSMicrocontroller : IMicrocontrollerSourceProvider
{
    public MicrocontrollerSource TryCreateMicrocontroller(Extensibility.Core.Registers registers, Memory memory)
    {
        return new MOSMicrocontrollerSource(registers, memory);
    }
}


