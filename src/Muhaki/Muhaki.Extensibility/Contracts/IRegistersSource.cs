using System.Runtime.InteropServices;

namespace Muhaki.Extensibility.Contracts;

public interface IRegistersSource
{
    IEnumerable<(string name, int size)> GetRegisters();
}