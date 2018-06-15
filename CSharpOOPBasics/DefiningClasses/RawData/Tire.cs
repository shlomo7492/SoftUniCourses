using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tire
{
    private double presure;
    private int age;
    
    public double Presure
    {
        get
        {
            return this.presure;
        }
        set
        {
            this.presure = value;
        }
    }
    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            this.age = value;
        }
    }
    
}