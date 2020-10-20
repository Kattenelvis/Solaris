using System.Collections.Generic;
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
        this.refineries = 10;
        this.fuel = 1000;
        this.hydrocarbons = 3125;
    }

    


}