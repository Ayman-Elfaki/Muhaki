using Muhaki.Extensibility.Contracts;
using System.ComponentModel.Composition;

namespace Muhaki.Extensibility.Attributes;

[MetadataAttribute]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class RegistersAttribute<T> : Attribute where T : IRegistersSource
{
    public Type Registers { get; }
    public RegistersAttribute()
    {
        Registers = typeof(T);
    }
}

