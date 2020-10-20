using System.Collections.Generic;
using System;
public class Region : IRegion
{
    public Country owner {get; set;}
    public int hydrocarbons{get; set;}
    public int refineries {get; set;}
    public int fuel {get; set;}
    public string name {get; set;}
    public Region(string name, Country owner)
    {
        this.name = name;
        this.owner = owner;
       
        this.refineries = 10 + new Random().Next(1,40 + Convert.ToInt32(name[0]));
        this.fuel = 1000;
        this.hydrocarbons = 3125;
    }

    


}