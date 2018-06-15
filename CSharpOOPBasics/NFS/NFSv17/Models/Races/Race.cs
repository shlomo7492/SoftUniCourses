using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private List<Car> participants;
    public Race(int length, string route, int prizePool, List<Car> participants)
    {
        this.length = length;
        this.route = route;
        this.prizePool = prizePool;
        this.participants = participants;
    }
    public int Length
    {
        get
        {
            return this.length;
        }
        set
        {
            this.length = value;
        }
    }
    public string Route
    {
        get
        {
            return this.route;
        }
        set
        {
            this.route = value;
        }
    }
    public int PrizePool
    {
        get
        {
            return this.prizePool;
        }
        set
        {
            this.prizePool = value;
        }
    }
    public List<Car> Participants
    {
        get
        {
            return this.participants;
        }
        set
        {
            this.participants = value;
        }
    }

}
