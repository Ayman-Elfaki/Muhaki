using Muhaki.Extensibility.Contracts;
using Muhaki.Extensibility.Models;

namespace Muhaki.MOS6502.Registers;

public sealed class MOSGeneralRegisters : IRegistersSource
{
    public IEnumerable<Register> GetRegisters()
    {
        yield return new("A", 8);
        yield return new("X", 8);
        yield return new("Y", 8);
    }
}
