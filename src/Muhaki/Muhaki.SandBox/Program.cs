using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

using Muhaki.Extensibility.Contracts;
using Muhaki.Extensibility.Core;
using Muhaki.Extensibility.Models;
using Muhaki.Extensibility.Utilities;

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
    public string Name { get; }
    public IReadOnlyList<Register> Registers { get; }
    public IReadOnlyList<Instruction> Instructions { get; }

    private readonly MicrocontrollerSource _microcontroller;

    [ImportingConstructor]
    public Microcontroller(
        [Import] Lazy<IMicrocontrollerSourceProvider, IMicrocontrollerMetadata> msp)
    {
        var registers = msp.Metadata.Registers.SelectMany(a => CreateInstance<IRegistersSource>(a).GetRegisters()).ToList();
        var instructions = msp.Metadata.Instructions.SelectMany(a => CreateInstance<IInstructionsSource>(a).GetInstructions()).ToList();

        Name = msp.Metadata.Name;
        Registers = registers;
        Instructions = instructions;

        _microcontroller = msp.Value.TryCreateMicrocontroller(registers.ToRegisters(), new Memory());

    }

    public void Rest()
    {
        _microcontroller.Rest();
    }


    private static T CreateInstance<T>(Type type)
    {
        return (T)Activator.CreateInstance(type);
    }
}