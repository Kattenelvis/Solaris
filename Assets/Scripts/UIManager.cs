using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] planetUIs;
    public void updateUI()
    {
        //showPlanet("Earth");
    }

    public void showPlanet(string planetName, bool show)
    {
        if (show)
        {
            Transform UIelement = this.transform.Find("Astronomical Objects").Find(planetName);
            if (UIelement != null)
            {
                UIelement.gameObject.SetActive(show);
            }
        }
    }
}