using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceShip : MonoBehaviour, ResourceShipInterface
{
    public int resources { get; set; }
    private void OnMouseDown()
    {
        Debug.Log(resources);
    }

    public void mineResources(int n)
    {
        resources += n;
    }
}
