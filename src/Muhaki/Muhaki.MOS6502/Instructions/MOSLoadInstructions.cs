using Muhaki.Extensibility.Contracts;
using Muhaki.Extensibility.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhaki.MOS6502.Instructions;

public sealed class MOSLoadInstructions : IInstructionsSource
{
    public IEnumerable<Instruction> GetInstructions()
    {
        yield return new("LDA", "0xA9", (processor, memory) =>
        {

        });
    }
}
