using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhaki.Extensibility.Core;
public sealed class Registers : Dictionary<string, long>
{
    public Registers() : base() { }

    public Registers(int capacity) : base(capacity) { }

}
