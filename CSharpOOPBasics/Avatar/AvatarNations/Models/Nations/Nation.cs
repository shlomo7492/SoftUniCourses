using System.Collections.Generic;
using System.Linq;


public abstract class Nation
{
    private List<Bender> benders;
    private List<Monument> monuments;

    public Nation()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }
    public List<Bender> Benders
    {
        get
        {
            return this.benders;
        }
        set
        {
            this.benders = value;
        }
    }
    public List<Monument> Monuments
    {
        get
        {
            return this.monuments;
        }
        set
        {
            this.monuments = value;
        }
    }
    public double NationPower()
    {
       return this.Benders.Sum(m => m.GetTotalPower());
    }
    public int MonumentBonus()
    {
        return this.Monuments.Sum(m => m.Affinity);
    }
    public double GetNationTotalPower()
    {
        return this.NationPower() + ((this.NationPower() / 100) * this.MonumentBonus());
    } 
}