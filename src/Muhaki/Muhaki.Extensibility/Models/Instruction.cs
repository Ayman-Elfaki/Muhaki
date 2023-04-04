using Muhaki.Extensibility.Contracts;
using Muhaki.Extensibility.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhaki.Extensibility.Models;
public record class Instruction(string Name, string OpCode, Action<MicrocontrollerSource> Execute);

