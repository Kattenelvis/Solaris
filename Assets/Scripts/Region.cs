using UnityEngine;
public class Region : MonoBehaviour
{
    public Country owner;
    public float resources;
    public int hydrocarbons;
    public int refineries;
    public int fuel;
    public string name;
    public Region(string _name, Country _owner)
    {
        name = _name;
        owner = _owner;
        hydrocarbons = 10000;
        refineries = 10;
        fuel = 1000;
    }
}