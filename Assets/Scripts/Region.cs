using System.Collections.Generic;
using System;
public class Region : IRegion
{
    public Player owner { get; set; }
    public int hydrocarbons { get; set; }
    public int refineries { get; set; }
    public int fuel { get; set; }
    public string name { get; set; }
    //public string TAG { get; }
    public Region(string name)
    {
        this.name = name;
        this.owner = new Player(Player.controlledBy.NOONE, "Nothing");

        this.refineries = 10 + new Random().Next(1, 40 + Convert.ToInt32(name[0]));
        this.fuel = 1000 + new Random().Next(1, 40 + Convert.ToInt32(name[0]));
        this.hydrocarbons = 3125 + new Random().Next(1, 40 + Convert.ToInt32(name[0]));
    }

    public Region(string name, int refineries, int hydrocarbons)
    {
        this.name = name;
        this.owner = new Player(Player.controlledBy.NOONE, "Nothing");

        this.refineries = refineries;
        this.hydrocarbons = hydrocarbons;
        this.fuel = 1000 + new Random().Next(1, 40 + Convert.ToInt32(name[0]));
    }
}