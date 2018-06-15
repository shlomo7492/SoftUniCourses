using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;

    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            this.firstName = value;
        }
    }
    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            this.lastName = value;
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
    public double Salary
    {
        get
        {
            return this.salary;
        }
        set
        {
            this.salary = value;
        }
    }
    public string ToString(double bonus)
    {
        IncreaseSalary(bonus);
        return $"{this.firstName} {this.lastName} get {this.salary:f2} leva";
    }
    public void IncreaseSalary(double bonus)
    {
        if (this.age > 30)
        {
            this.salary *= (1d + bonus / 100);
        }
        else
        {
            this.salary *= (1d + bonus / 200);
        }
    }
    
}