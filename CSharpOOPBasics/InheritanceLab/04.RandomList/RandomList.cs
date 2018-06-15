using System;
using System.Collections;

public class RandomList : ArrayList
{
    private Random rnd;
    public RandomList()
    {
        this.rnd = new Random();
    }
    public object RandomString()
    {
        int element = rnd.Next(0, this.Count - 1);
        string str = (string)this[element];
        this.Remove(str);
        return str;
    }
}
