using Muhaki.Extensibility.Core;

namespace Muhaki.MOS6502.Core;

public class MOSMicrocontrollerSource : MicrocontrollerSource
{
    private readonly Extensibility.Core.Registers _registers;
    private readonly Memory _memory;

    public MOSMicrocontrollerSource(Extensibility.Core.Registers registers, Memory memory)
    {
        _registers = registers;
        _memory = memory;
    }

    public override void Rest()
    {
        _registers["PC"] = 0xFFFC;
        _registers["SP"] = 0x0100;

        _registers["A"] = 0;
        _registers["X"] = 0;
        _registers["Y"] = 0;

        _registers["D"] = 0;
    }
}