using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class FireBender : Bender
{
    private double heatAggression;

    public FireBender(string name, int power,double hAggression) : base(name, power)
    {
        this.HeatAggression = hAggression;
    }

    public double HeatAggression
    {

        get
        {
            return this.heatAggression;
        }
        set
        {
            this.heatAggression = value;
        }
    }

    public override double GetTotalPower()
    {
        return this.Power * this.HeatAggression;
    }
    public override string ToString()
    {
        return $"Bender: {this.Name}, Power: {this.Power}, Heat Aggression: {this.heatAggression:f2}";
    }
}