using Muhaki.Extensibility.Contracts;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

var extensionsPath = @"D:\GitHub\Muhaki\src\Muhaki\Muhaki.MOS6502\bin\Debug\net7.0";
var catalogs = new AggregateCatalog();

catalogs.Catalogs.Add(new AssemblyCatalog(typeof(Program).Assembly));
catalogs.Catalogs.Add(new DirectoryCatalog(extensionsPath));

CompositionContainer container = new(catalogs);

var microcontroller = container.GetExportedValue<Microcontroller>();

Console.WriteLine($" *** {microcontroller?.Name} ***");

foreach ((string name, int size) register in microcontroller!.Registers)
{
    Console.WriteLine($"Register : {register.name} - {register.size} bits");
}


[Export]
public class Microcontroller
{
    private Lazy<IMicrocontrollerSourceProvider, IMicrocontrollerMetadata>? _microcontrollerSource;
    public string Name { get; }
    public IReadOnlyList<(string name, int size)> Registers { get; }

    [ImportingConstructor]
    public Microcontroller(
        [Import] Lazy<IMicrocontrollerSourceProvider, IMicrocontrollerMetadata>? microcontrollerSource)
    {
        _microcontrollerSource = microcontrollerSource;
        
        var registersSource = (IRegistersSource)Activator.CreateInstance(_microcontrollerSource?.Metadata.Registers);
        
        Name = _microcontrollerSource.Metadata.Name;
        Registers = registersSource?.GetRegisters().ToList();

    }
}