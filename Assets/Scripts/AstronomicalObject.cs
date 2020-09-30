using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronomicalObject : MonoBehaviour, IAstronomicalObject
{
    public List<IRegion> regions { get; set; }
    public string Name;
    public AstronomicalObject()
    {
        regions = new List<IRegion>();
    }
}
