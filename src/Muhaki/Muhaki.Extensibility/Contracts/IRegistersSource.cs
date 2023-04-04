using Muhaki.Extensibility.Models;
using System.Runtime.InteropServices;

namespace Muhaki.Extensibility.Contracts;

public interface IRegistersSource
{
    IEnumerable<Register> GetRegisters();
}
