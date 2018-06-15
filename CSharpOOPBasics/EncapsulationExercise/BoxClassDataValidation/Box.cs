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
    public Box(double length, double width, double height)
    {
        if (length <= 0)
        {
            throw new ArgumentException("Length cannot be zero or negative. ");
        }
        else if (width <= 0)
        {
            throw new ArgumentException("Width cannot be zero or negative. ");
        }
        else if (height <= 0)
        {
            throw new ArgumentException("Height cannot be zero or negative. ");
        }
        else
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
    }
    public void SurfaceArea()
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