﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    private int speed;
    private int power;
    public int Speed
    {
        get
        {
            return this.speed;
        }
        set
        {
            this.speed = value;
        }
    }
    public int Power
    {
        get
        {
            return this.power;
        }
        set
        {
            this.power = value;
        }
    }
}
