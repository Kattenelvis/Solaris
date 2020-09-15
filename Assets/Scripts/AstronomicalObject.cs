using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronomicalObject : MonoBehaviour, IAstronomicalObject
{
    public List<Region> regions { get; set; }
    public string name;
}

public class Region
{
    public Country owner;
    public float resources;
    public string name;
    public Region(string _name, Country _owner)
    {
        name = _name;
        owner = _owner;
    }
}