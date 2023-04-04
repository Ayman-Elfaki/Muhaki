namespace Muhaki.Extensibility.Core;

public sealed class Memory : Dictionary<long, long>
{
    public Memory() : base() { }

    public Memory(int capacity) : base(capacity) { }

    public void Initialize()
    {
        foreach (var item in this)
        {
            this[item.Key] = 0L;
        }
    }

}
