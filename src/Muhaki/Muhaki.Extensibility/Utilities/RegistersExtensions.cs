using Muhaki.Extensibility.Core;
using Muhaki.Extensibility.Models;

namespace Muhaki.Extensibility.Utilities;

public static class Extensions
{
    public static Registers? ToRegisters(this IEnumerable<Register> registers)
        => registers.ToDictionary(r => r.Name, v => 0L) as Registers;

}
