using Muhaki.Extensibility.Attributes;
using Muhaki.Extensibility.Contracts;
using Muhaki.Extensibility.Core;
using Muhaki.MOS6502.Instructions;
using Muhaki.MOS6502.Registers;

namespace Muhaki.MOS6502.Core;

[Microcontroller("MOS Technology 6502")]
[Registers<MOSGeneralRegisters>]
[Registers<MOSPointerRegisters>]
[Registers<MOSStatusFlagRegisters>]
[Instructions<MOSLoadInstructions>]
public sealed class MOSMicrocontroller : IMicrocontrollerSource
{
    public Memory CreateMemory()
    {
        return new MOSMemory();
    }

    public Processor CreateProcessor()
    {
        return new MOSProcessor();
    }
}
