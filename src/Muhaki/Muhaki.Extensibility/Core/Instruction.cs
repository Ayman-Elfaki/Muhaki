using Muhaki.Extensibility.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhaki.Extensibility.Core;
public record class Instruction(string Name, string OpCode, Action<Processor, Memory> Execute);

