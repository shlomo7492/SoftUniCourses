using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WaterBender : Bender
{
    private double waterClarity;

    public WaterBender(string name, int power, double wClarity) : base(name, power)
    {
        this.WaterClarity = wClarity;
    }

    public double WaterClarity
    {
        get
        {
            return this.waterClarity;
        }
        set
        {
            this.waterClarity = value;
        }
    }

    public override double GetTotalPower()
    {
        return this.Power*this.WaterClarity;
    }
    public override string ToString()
    {
        return $"Bender: {this.Name}, Power: {this.Power}, Water Clarity: {this.waterClarity:f2}";
    }
}
