using Muhaki.Extensibility.Core;

namespace Muhaki.Extensibility.Contracts;

public interface IInstructionsSource
{
    IEnumerable<Instruction> GetInstructions();
}