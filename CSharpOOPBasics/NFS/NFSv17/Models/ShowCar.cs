using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ShowCar:Car
{
    private int stars;
    public ShowCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability, int stars)
        : base(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability)
    {
        this.stars = stars;
    }
    public int Stars
    {
        get
        {
            return this.stars;
        }
        set
        {
            this.stars = value;
        }
    }
}
