using Muhaki.Extensibility.Contracts;
using Muhaki.Extensibility.Core;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

var extensionsPath = @"D:\GitHub\Muhaki\src\Muhaki\Muhaki.MOS6502\bin\Debug\net7.0";
var catalogs = new AggregateCatalog();

catalogs.Catalogs.Add(new AssemblyCatalog(typeof(Program).Assembly));
catalogs.Catalogs.Add(new DirectoryCatalog(extensionsPath));

CompositionContainer container = new(catalogs);

var microcontroller = container.GetExportedValue<Microcontroller>();

Console.WriteLine($" *** {microcontroller?.Name} ***");

Console.WriteLine("----------------------------------");

foreach (var register in microcontroller!.Registers)
{
    Console.WriteLine($"Register : {register.Name} - {register.Size} bits");
}
Console.WriteLine("----------------------------------");

foreach (var instructions in microcontroller!.Instructions)
{
    Console.WriteLine($"Instructions : {instructions.Name} - OpCode : {instructions.OpCode}.");
}


#nullable disable
[Export]
public class Microcontroller
{
    private Lazy<IMicrocontrollerSource, IMicrocontrollerMetadata> _msp;
    public string Name { get; }
    public IReadOnlyList<Register> Registers { get; }
    public IReadOnlyList<Instruction> Instructions { get; }


    [ImportingConstructor]
    public Microcontroller(
        [Import] Lazy<IMicrocontrollerSource, IMicrocontrollerMetadata> msp)
    {
        _msp = msp;

        Name = _msp.Metadata.Name;
        Registers = _msp.Metadata.Registers.SelectMany(a => CreateInstance<IRegistersSource>(a).GetRegisters()).ToList();
        Instructions = _msp.Metadata.Instructions.SelectMany(a => CreateInstance<IInstructionsSource>(a).GetInstructions()).ToList();

    }


    private static T CreateInstance<T>(Type type)
    {
        return (T)Activator.CreateInstance(type);
    }
}