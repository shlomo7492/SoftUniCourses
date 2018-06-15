using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NationsBuilder
{
    private List<string> warStarters;
    private AirNation airNation;
    private EarthNation earthNation;
    private FireNation fireNation;
    private WaterNation waterNation;

    private HashSet<Nation> nations;
    public NationsBuilder()
    {
        this.warStarters = new List<string>();
        this.airNation = new AirNation();
        this.earthNation = new EarthNation();
        this.fireNation = new FireNation();
        this.waterNation = new WaterNation();
        this.nations = new HashSet<Nation>();    
    }
    public void AssignBender(List<string> benderArgs)
    {
        string benderType = benderArgs[0];
        string benderName = benderArgs[1];
        int benderPower = int.Parse(benderArgs[2]);
        double benderProp = double.Parse(benderArgs[3]);

        switch (benderType)
        {
            case "Air":
                {
                    this.airNation.Benders.Add(new AirBender(benderName,benderPower,benderProp));
                    this.nations.Add(airNation);
                }
                break;
            case "Fire":
                {
                    this.fireNation.Benders.Add(new FireBender(benderName, benderPower, benderProp));
                    this.nations.Add(fireNation);
                }
                break;
            case "Earth":
                {
                    this.earthNation.Benders.Add(new EarthBender(benderName, benderPower, benderProp));
                    this.nations.Add(earthNation);
                }
                break;
            case "Water":
                {
                    this.waterNation.Benders.Add(new WaterBender(benderName, benderPower, benderProp));
                    this.nations.Add(waterNation);
                }
                break;
            default:break;
        }

    }
    public void AssignMonument(List<string> monumentArgs)
    {
        string monumentType = monumentArgs[0];
        string monumentName = monumentArgs[1];
        int monumentAffinity = int.Parse(monumentArgs[2]);

        switch (monumentType)
        {
            case "Air":
                {
                    this.airNation.Monuments.Add(new AirMonument(monumentName, monumentAffinity));
                    this.nations.Add(airNation);
                }
                break;
            case "Fire":
                {
                    this.fireNation.Monuments.Add(new FireMonument(monumentName, monumentAffinity));
                    this.nations.Add(fireNation);
                }
                break;
            case "Earth":
                {
                    this.earthNation.Monuments.Add(new EarthMonument(monumentName, monumentAffinity));
                    this.nations.Add(earthNation);
                }
                break;
            case "Water":
                {
                    this.waterNation.Monuments.Add(new WaterMonument(monumentName, monumentAffinity));
                    this.nations.Add(waterNation);
                }
                break;
            default: break;
        }
    }
    public string GetStatus(string nationsType)
    {
        StringBuilder statusString = new StringBuilder();
        switch(nationsType)
        {
            case "Air":
                {
                    statusString.Append(nationsType+" Nation\n");
                    statusString.Append("Benders:");
                    if (this.airNation.Benders.Count != 0)
                    {
                        statusString.Append("\n");
                    }
                    else
                    {
                        statusString.Append(" None\n");
                    }
                    foreach (var bender in this.airNation.Benders)
                    {
                        statusString.Append("###" + nationsType +" "+ bender.ToString());
                       
                        statusString.Append("\n");
                        
                    }
                    statusString.Append("Monuments:");
                    if (this.airNation.Monuments.Count != 0)
                    {
                        statusString.Append("\n");
                    }
                    else
                    {
                        statusString.Append(" None");
                    }
                    foreach (var monument in this.airNation.Monuments)
                    {
                        statusString.Append("###" + nationsType + " Monument: " + monument.Name + ", " + nationsType + " Affinity: " + monument.Affinity);
                        if (monument != this.airNation.Monuments.Last())
                        {
                            statusString.Append("\n");
                        }
                    }
                }
                break;
            case "Fire":
                {
                    statusString.Append(nationsType + " Nation\n");
                    statusString.Append("Benders:");
                    if (this.fireNation.Benders.Count != 0)
                    {
                        statusString.Append("\n");
                    }
                    else
                    {
                        statusString.Append(" None\n");
                    }
                    foreach (var bender in this.fireNation.Benders)
                    {
                        statusString.Append("###" + nationsType + " " + bender.ToString());

                        statusString.Append("\n");

                    }
                    statusString.Append("Monuments:");
                    if (this.fireNation.Monuments.Count != 0)
                    {
                        statusString.Append("\n");
                    }
                    else
                    {
                        statusString.Append(" None");
                    }
                    foreach (var monument in this.fireNation.Monuments)
                    {
                        statusString.Append("###" + nationsType + " Monument: " + monument.Name + ", " + nationsType + " Affinity: " + monument.Affinity);
                        if (monument != this.fireNation.Monuments.Last())
                        {
                            statusString.Append("\n");
                        }
                    }
                }
                break;
            case "Earth":
                {
                    statusString.Append(nationsType + " Nation\n");
                    statusString.Append("Benders:");
                    if (this.earthNation.Benders.Count != 0)
                    {
                        statusString.Append("\n");
                    }
                    else
                    {
                        statusString.Append(" None\n");
                    }
                    foreach (var bender in this.earthNation.Benders)
                    {
                        statusString.Append("###" + nationsType + " " + bender.ToString());

                        statusString.Append("\n");

                    }
                    statusString.Append("Monuments:");
                    if (this.earthNation.Monuments.Count != 0)
                    {
                        statusString.Append("\n");
                    }
                    else
                    {
                        statusString.Append(" None");
                    }
                    foreach (var monument in this.earthNation.Monuments)
                    {
                        statusString.Append("###" + nationsType + " Monument: " + monument.Name + ", " + nationsType + " Affinity: " + monument.Affinity);
                        if (monument != this.earthNation.Monuments.Last())
                        {
                            statusString.Append("\n");
                        }
                    }
                }
                break;
            case "Water":
                {
                    statusString.Append(nationsType + " Nation\n");
                    statusString.Append("Benders:");
                    if (this.waterNation.Benders.Count != 0)
                    {
                        statusString.Append("\n");
                    }
                    else
                    {
                        statusString.Append(" None\n");
                    }
                    foreach (var bender in this.waterNation.Benders)
                    {
                        statusString.Append("###" + nationsType + " " + bender.ToString());

                        statusString.Append("\n");

                    }
                    statusString.Append("Monuments:");
                    if (this.waterNation.Monuments.Count != 0)
                    {
                        statusString.Append("\n");
                    }
                    else
                    {
                        statusString.Append(" None");
                    }
                    foreach (var monument in this.waterNation.Monuments)
                    {
                        statusString.Append("###" + nationsType + " Monument: " + monument.Name + ", " + nationsType + " Affinity: " + monument.Affinity);
                        if (monument != this.waterNation.Monuments.Last())
                        {
                            statusString.Append("\n");
                        }
                    }
                }
                break;
            default: break;
        }
        return statusString.ToString();
    }
    public void IssueWar(string nationsType)
    {

        double maxPower = double.MinValue;
        warStarters.Add(nationsType);
        foreach (var nation in nations)
        {
            if (nation.GetNationTotalPower() > maxPower)
            {
                maxPower = nation.GetNationTotalPower();
            }
        }
        foreach (var nation in nations.Where(n=>n.GetNationTotalPower()<maxPower))
        {
            nation.Benders.Clear();
            nation.Monuments.Clear();
        }
    }
    public string GetWarsRecord()
    {
        StringBuilder warRecord = new StringBuilder();
        int i = 0;
        foreach (var record in warStarters)
        {
            i++;
            warRecord.Append($"War {i} issued by "+record + "\n");
           
        }
        return warRecord.ToString();
    }

}
