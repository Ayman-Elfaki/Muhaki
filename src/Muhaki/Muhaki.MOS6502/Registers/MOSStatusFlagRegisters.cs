using Muhaki.Extensibility.Contracts;
using Muhaki.Extensibility.Models;

namespace Muhaki.MOS6502.Registers;

public sealed class MOSStatusFlagRegisters : IRegistersSource
{
    public IEnumerable<Register> GetRegisters()
    {
        yield return new("C", 1);
        yield return new("Z", 1);
        yield return new("I", 1);
        yield return new("D", 1);
        yield return new("B", 1);
        yield return new("V", 1);
        yield return new("N", 1);
    }
}