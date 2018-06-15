using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FireMonument : Monument
{
    private int fireAffinity;
    public FireMonument(string name, int fireAffinity):base(name)
    {
        this.FireAffinity = fireAffinity;
        this.Affinity = this.FireAffinity;
    }
        public int FireAffinity
    {
        get
        {
            return this.fireAffinity;
        }
        set
        {
            this.fireAffinity = value;
        }
    }
}
