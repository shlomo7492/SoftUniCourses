using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DraftManager
{
    private double oreStored;
    private double energyStored;
    private List<Provider> providers;

    private List<Harvester> harvesters;
    private string mode;
    public DraftManager()
    {
        oreStored = 0;
        energyStored = 0;
        providers = new List<Provider>();
        harvesters = new List<Harvester>();
        mode = "Full";
    }
    public string RegisterHarvester(List<string> arguments)
    {
        SonicHarvester sonicHarvester;
        HammerHarvester hammerHarvester;
        string registerMessage = $"Successfully registered {arguments[1]} Harvester - {arguments[2]}";
        switch (arguments[1])
        {
            case "Sonic":
                {
                    try
                    {
                        sonicHarvester = new SonicHarvester(arguments[2], double.Parse(arguments[3]), double.Parse(arguments[4]), int.Parse(arguments[5]));
                        harvesters.Add(sonicHarvester);
                    }
                    catch (ArgumentException ex)
                    {
                        registerMessage = ex.Message.ToString();
                    }
                }
                break;
            case "Hammer":
                {
                    try
                    {
                        hammerHarvester = new HammerHarvester(arguments[2], double.Parse(arguments[3]), double.Parse(arguments[4]));
                        harvesters.Add(hammerHarvester);
                    }
                    catch (ArgumentException ex)
                    {
                        registerMessage = ex.Message.ToString();
                    }
                }
                break;
            default:break;
        }
        return registerMessage;
    }
    public string RegisterProvider(List<string> arguments)
    {
        SolarProvider solarProvider;
        PressureProvider presureProvider;
        string registerMessage = $"Successfully registered {arguments[1]} Provider - {arguments[2]}";
        switch (arguments[1])
        {
            case "Solar":
                {
                    try
                    {
                        solarProvider = new SolarProvider(arguments[2], double.Parse(arguments[3]));
                        providers.Add(solarProvider);
                    }
                    catch (ArgumentException ex)
                    {
                        registerMessage = ex.Message.ToString();
                    }
                }
                break;
            case "Pressure":
                {
                    try
                    {
                        presureProvider = new PressureProvider(arguments[2], double.Parse(arguments[3]));
                        providers.Add(presureProvider);
                    }
                    catch (ArgumentException ex)
                    {
                        registerMessage = ex.Message.ToString();
                    }
                }
                break;
            default: break;
        }
        return registerMessage;
    }
    public string Day()
    {
        double summedEnergyOutput = providers.Sum(p => p.EnergyOutput);
        energyStored += summedEnergyOutput;
        double summedOreOutput = 0;
        switch (mode)
        {
            case "Full":
                {
                    if (energyStored >= (harvesters.Sum(h => h.EnergyRequirement)))
                    {
                        summedOreOutput += harvesters.Sum(h => h.OreOutput) * (int)(energyStored / harvesters.Sum(h => h.EnergyRequirement));
                        energyStored -= harvesters.Sum(h => h.EnergyRequirement) * (int)(energyStored / harvesters.Sum(h => h.EnergyRequirement));
                    }
                        
                    oreStored += summedOreOutput;
                }
                break;
            case "Half":
                {
                    if (energyStored >= (harvesters.Sum(h => h.EnergyRequirement) * 0.6))
                    {
                        summedOreOutput += (harvesters.Sum(sh => sh.OreOutput) * 0.5) * (int)(energyStored / (harvesters.Sum(h => h.EnergyRequirement) * 0.6));
                        energyStored -= (harvesters.Sum(h => h.EnergyRequirement) * 0.6) * (int)(energyStored / (harvesters.Sum(h => h.EnergyRequirement) * 0.6));
                    }
                    oreStored += summedOreOutput;
                }
                break;
            case "Energy":
                {
                    summedOreOutput = 0;                    
                }
                break;
            default:break;
        }
    return $"A day has passed.\nEnergy Provided: { summedEnergyOutput}\nPlumbus Ore Mined: { summedOreOutput}";


    }
    public string Mode(List<string> arguments)
    {
        mode = arguments[1];

        return $"Successfully changed working mode to {arguments[1]} Mode";
    }


    public string Check(List<string> arguments)
    {
        string checkMessage = $"No element found with id - {arguments[1]}";
        int count = providers.Where(p => p.Id == arguments[1]).Count();
        if(count==1)
        {
            checkMessage = providers.Where(p => p.Id == arguments[1]).SingleOrDefault().ToString();
        }
        count = harvesters.Where(p => p.Id == arguments[1]).Count();
        if (count == 1)
        {
            checkMessage = harvesters.Where(p => p.Id == arguments[1]).SingleOrDefault().ToString();
        }
        return checkMessage;
            }
    public string ShutDown()
    {
        return $"System Shutdown\nTotal Energy Stored: {energyStored}\nTotal Mined Plumbus Ore: {oreStored}";
    }

}
