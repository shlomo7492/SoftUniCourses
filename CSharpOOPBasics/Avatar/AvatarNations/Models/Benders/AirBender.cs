using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AirBender : Bender
{
    private double aerialIntegrity;
    public AirBender(string name, int power, double aIntegrity):base(name,power)
    {
        this.AerialIntegrity = aIntegrity;
    }
    public double AerialIntegrity
    {
        get
        {
            return this.aerialIntegrity;
        }
        set
        {
            this.aerialIntegrity = value;
        }
    }

    public override double GetTotalPower()
    {
        return this.Power * this.AerialIntegrity;
    }
    public override string ToString()
    {
        return $"Bender: {this.Name}, Power: {this.Power}, Aerial Integrity: {this.aerialIntegrity:f2}";
    }
}
