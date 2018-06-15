﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Family
{
    private List<Person> members = new List<Person>();

    public void AddMember(Person member)
    {
        this.members.Add(member);
    }

    public Person GetOldestMember()
    {
        return this.members.OrderByDescending(m => m.Age).First();
    }
}