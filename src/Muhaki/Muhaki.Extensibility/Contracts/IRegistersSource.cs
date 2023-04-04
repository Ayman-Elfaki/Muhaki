using Muhaki.Extensibility.Core;
using System.Runtime.InteropServices;

namespace Muhaki.Extensibility.Contracts;

public interface IRegistersSource
{
    IEnumerable<Register> GetRegisters();
}
