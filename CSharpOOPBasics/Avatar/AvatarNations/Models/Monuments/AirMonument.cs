using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AirMonument : Monument
{
    private int airAffinity;
    public AirMonument(string name,int airAffinity):base(name)
    {
        this.AirAffinity = airAffinity;
        this.Affinity = this.AirAffinity;
    }
    public int AirAffinity
    {
        get
        {
            return this.airAffinity;
        }
        set
        {
            this.airAffinity = value;
        }
    }
}