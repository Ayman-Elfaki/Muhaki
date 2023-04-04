using Muhaki.Extensibility.Contracts;
using System.ComponentModel.Composition;

namespace Muhaki.Extensibility.Attributes;

[MetadataAttribute]
[AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]
public class ExportInstructionsAttribute<T> : Attribute where T : IInstructionsSource
{
    public Type Instructions { get; }
    public ExportInstructionsAttribute()
    {
        Instructions = typeof(T);
    }
}

