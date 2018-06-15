using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private Tire[] tire = new Tire[4];
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
    }
    public Engine Engine
    {
        get
        {
            return this.engine;
        }
        set
        {
            this.engine = value;
        }
    }
    public Cargo Cargo
    {
        get
        {
            return this.cargo;
        }
        set
        {
            this.cargo = value;
        }
    }
    public Tire[] Tire
    {
        get
        {
            return this.tire;
        }
        set
        {
            this.tire = value;
        }
    }
}