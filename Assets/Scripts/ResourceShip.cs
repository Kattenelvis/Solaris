using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceShip : MonoBehaviour
{
    public int resources;
    private void OnMouseDown()
    {
        Debug.Log(resources);
    }

    public void mineResources(int n)
    {
        resources += n;
    }
}
