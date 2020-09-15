using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] planetUIs;
    public void updateUI()
    {
        togglePlanet("Earth");
    }

    public void togglePlanet(string planetName)
    {
        Transform UIelement = this.transform.Find("Astronomical Objects").Find(planetName);
        if (UIelement != null)
        {
            UIelement.gameObject.SetActive(!UIelement.gameObject.activeInHierarchy);
        }
    }
}