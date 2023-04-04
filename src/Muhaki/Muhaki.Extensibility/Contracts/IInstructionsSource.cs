using Muhaki.Extensibility.Models;

namespace Muhaki.Extensibility.Contracts;

public interface IInstructionsSource
{
    IEnumerable<Instruction> GetInstructions();
}