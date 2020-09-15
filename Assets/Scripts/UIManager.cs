using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class UIManager : MonoBehaviour
{
    [SerializeField]
    private AstronomicalObject[] planetUIs;
    public void updateUI()
    {
        //showPlanet("Earth");
    }

    public void showPlanet(AstronomicalObject astronomicalObject, bool show)
    {
        if (astronomicalObject != null)
        {
            Transform UIelement = this.transform.Find("Astronomical Objects").Find(astronomicalObject.name);
            UIelement.gameObject.SetActive(show);
        }
    }
}