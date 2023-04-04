using Muhaki.Extensibility.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhaki.Extensibility.Contracts;

public interface IMicrocontrollerSource
{
    Processor CreateProcessor();
    Memory CreateMemory();
}
