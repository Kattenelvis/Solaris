using UnityEngine;
public class Region : IRegion
{
    public Country owner {get; set;}
    public float resources {get; set;}
    public int hydrocarbons {get; set;}
    public int refineries {get; set;}
    public int fuel {get; set;}
    public string name {get; set;}
    public Region(string _name, Country _owner)
    {
        name = _name;
        owner = _owner;
        hydrocarbons = 10000;
        refineries = 10;
        fuel = 1000;
    }
}