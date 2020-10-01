using System.Collections.Generic;
public class Region : IRegion
{
    public Country owner {get; set;}
    public int hydrocarbons{get; set;}
    public int refineries {get; set;}
    public int fuel {get; set;}
    public string name {get; set;}
    public Region(string _name, Country _owner)
    {
        name = _name;
        owner = _owner;
        refineries = 10;
        fuel = 1000;
    }

    


}