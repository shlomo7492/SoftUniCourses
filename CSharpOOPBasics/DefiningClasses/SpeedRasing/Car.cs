using System;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelPerKm;
    private int distance;

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
    public double FuelAmount
    {
        get
        {
            return this.fuelAmount;
        }
        set
        {
            this.fuelAmount = value;
        }
    }
    public double FuelPerKm
    {
        get
        {
            return this.fuelPerKm;
        }
        set
        {
            this.fuelPerKm = value;
        }
    }
    public int Distance
    {
        get
        {
            return this.distance;
        }
        set
        {
            this.distance = value;
        }
    }
    public void AddDistance(int distance)
    {
        this.distance += distance;
    }
    public void IsTravelPossible(int distance)
    {
        if(this.fuelAmount/this.fuelPerKm >= distance)
        {
            AddDistance(distance);
            this.fuelAmount -= distance * this.fuelPerKm;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
    public override string ToString()
    {
        return $"{this.model} {this.fuelAmount:f2} {this.distance}";
    }
}
