using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronomicalObject : MonoBehaviour, IAstronomicalObject
{
    public List<Region> regions { get; set; }
    public string name;
    
}
