﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cargo
{
    private int weight;
    private string type;

    public int Weight
    {
        get
        {
            return this.weight;
        }
        set
        {
            this.weight = value;
        }

    }
    public string Type
    {
        get
        {
            return this.type;
        }
        set
        {
            this.type = value;
        }
    }
}
