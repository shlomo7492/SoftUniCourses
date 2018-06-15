using System.Collections.Generic;
using System.Linq;

public class StackOfStrings
{
    private List<string> data;

    public void Push(string item)
    {
        this.data.Add(item);
    }

    public string Pop()
    {
        var elem = this.data[this.data.Count-1];
        this.data.Remove(elem);
        return elem;
    }

    public string Peek()
    {
        return this.data[this.data.Count - 1];
    }

    public bool IsEmpty()
    {
        return this.data.Count > 0;
    }
}