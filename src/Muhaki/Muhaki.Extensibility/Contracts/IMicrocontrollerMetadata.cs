namespace Muhaki.Extensibility.Contracts;

public interface IMicrocontrollerMetadata
{
    string Name { get; }
    Type Registers { get; }
    
}