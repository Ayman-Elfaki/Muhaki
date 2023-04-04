using Muhaki.Extensibility.Contracts;

namespace Muhaki.MOS6502;

public class RegistersSource : IRegistersSource
{
    public IEnumerable<(string name, int size)> GetRegisters()
    {
        yield return ("A", 8);
        yield return ("X", 8);
        yield return ("Y", 8);
        yield return ("PC", 16);
        yield return ("SP", 16);
    }
}