using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PerformanceCar:Car
{
    private List<string> addOns = new List<string>();
    public PerformanceCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability,List<string> addOns)
        :base(brand,model,yearOfProduction,horsePower,acceleration,suspension,durability)
    {
        this.addOns = addOns;
    }
    public List<string> AddOns
    {
        get
        {
            return this.addOns;
        }
        set
        {
            this.addOns = value;
        }
    } 
    public int TotalPower()
    {
        return this.HorsePower+(this.HorsePower/2);
    }
    public int TotalSuspension()
    {
        return this.Suspension * 75 / 100;
    }

}