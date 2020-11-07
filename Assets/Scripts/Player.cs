using System.Collections.Generic;
using UnityEngine;
public class Player
{
    public enum controlledBy
    {
        HUMAN,
        AI,
        NOONE
    }
    public controlledBy controller;
    public List<IRegion> regionsControlled;
    //Each nation gets its own tag so one can look it up in a table or whatever.
    //It's used by paradox interactive.
    public string tag { get; }
    public string name { get; }
    public int totalFuel;
    //List<Resource> resources;
    public Player(controlledBy controller, string name)
    {
        this.controller = controller;
        this.name = name;
        regionsControlled = new List<IRegion>();
    }
    public void ExtractResources()
    {
        foreach (IRegion region in regionsControlled)
        {
            totalFuel += region.fuel;
        }
    }
}