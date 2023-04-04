namespace Muhaki.Extensibility.Contracts;

public interface IMicrocontrollerMetadata
{
    string Name { get; }
    IEnumerable<Type> Registers { get; }
    IEnumerable<Type> Instructions { get; }

}