using System.ComponentModel.Composition;
using Muhaki.Extensibility.Contracts;

namespace Muhaki.Extensibility.Attributes;

[MetadataAttribute]
[AttributeUsage(AttributeTargets.Class)]
public class MicrocontrollerAttribute : ExportAttribute
{
    public string Name { get; }

    public MicrocontrollerAttribute(string name)
        : base(typeof(IMicrocontrollerSource))
    {
        Name = name;
    }
}