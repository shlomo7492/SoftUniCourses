using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Provider
{
    private string id;
    private double energyOutput;
    public Provider(string id,double energyOutput)
    {
        this.id = id;
        this.EnergyOutput = energyOutput;
    }
    public string Id
    {
        get
        {
            return this.id;
        }
        set
        {
            this.id = value;
        }
    }
    public double EnergyOutput
    {
        get
        {
            return this.energyOutput;
        }
        set
        {
            if (value <= 0 || value > 10000)
            {
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            }
            this.energyOutput = value;
        }
    }
    public abstract string GetProviderType();
    public override string ToString()
    {
        return $"{this.GetProviderType()} Provider - {this.id}\nEnergy Output: {this.energyOutput}";
    }
}
