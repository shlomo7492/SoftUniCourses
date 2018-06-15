using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Monument
{
    private string name;
    private int affinity;
    public Monument(string name)
    {
        this.name = name;
    }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }
    public int Affinity
    {
        get
        {
            return this.affinity;
        }
        set
        {
            this.affinity = value;
        }
    }
}
