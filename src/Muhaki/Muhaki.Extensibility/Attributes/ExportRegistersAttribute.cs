using Muhaki.Extensibility.Contracts;
using System.ComponentModel.Composition;

namespace Muhaki.Extensibility.Attributes;

[MetadataAttribute]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class ExportRegistersAttribute<T> : Attribute where T : IRegistersSource
{
    public Type Registers { get; }
    public ExportRegistersAttribute()
    {
        Registers = typeof(T);
    }
}

