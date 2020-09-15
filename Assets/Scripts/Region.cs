using UnityEngine;
public class Region : MonoBehaviour
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