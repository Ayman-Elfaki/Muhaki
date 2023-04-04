using Muhaki.Extensibility.Contracts;
using Muhaki.Extensibility.Core;

namespace Muhaki.MOS6502.Registers;

public sealed class MOSPointerRegisters : IRegistersSource
{
    public IEnumerable<Register> GetRegisters()
    {
        yield return new("PC", 16);
        yield return new("SP", 16);
    }
}
