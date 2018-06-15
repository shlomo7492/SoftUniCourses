using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Box
{
    private double length;
    private double width;
    private double height;
    public Box(double length,double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }
    public void SurfaceArea ()
    {
        Console.WriteLine($"Surface Area - {this.length * this.width * 2 + (this.length + this.width) * this.height * 2:f2}");
    }

    public void LateralSurfaceArea()
    {
        Console.WriteLine($"Lateral Surface Area - {(this.length + this.width) * this.height * 2:f2}");
    }
    public void Volume()
    {
        Console.WriteLine($"Volume - {this.length * this.width * this.height:f2}");
    }
}