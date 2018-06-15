using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class EarthBender : Bender
{
    private double groundSaturation;

    public EarthBender(string name, int power,double gSaturation) : base(name, power)
    {
        this.GroundSaturation = gSaturation;
    }

    public double GroundSaturation
    {
        get
        {
            return this.groundSaturation;
        }
        set
        {
            this.groundSaturation = value;
        }
    }

    public override double GetTotalPower()
    {
        return this.Power * this.GroundSaturation;
    }
    public override string ToString()
    {
        return $"Bender: {this.Name}, Power: {this.Power}, Ground Saturation: {this.groundSaturation:f2}";
    }
}
