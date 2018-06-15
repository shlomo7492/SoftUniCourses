using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Harvester
{
    private string id;
    private double oreOutput;
    private double energyRequirement;
    public Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.id = id;
        this.oreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
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
    public double OreOutput
    {
        get
        {
            return this.oreOutput;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Harvester is not registered, because of it's OreOutput");
            }
            this.oreOutput = value;
        }
    }
    public double EnergyRequirement
    {
        get
        {
            return this.energyRequirement;
        }
        set
        {
            if (value <= 0 || value > 20000)
            {
                throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
            }
            this.energyRequirement = value;
        }
    }
    public abstract string GetHarvesterType();
    public override string ToString()
    {
        return $"{this.GetHarvesterType()} Harvester - {this.Id}\nOre Output: {this.OreOutput}\nEnergy Requirement: {this.EnergyRequirement}";
    }
}
