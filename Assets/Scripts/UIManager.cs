using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    
    [SerializeField]
    private GameObject[] planetUIs;
    public void updateUI()
    {
        //showPlanet("Earth");
    }

    public void showPlanet(AstronomicalObject astronomicalObject, bool show)
    {
        if (astronomicalObject != null)
        {
            Transform UIelement = this.transform.Find("Astronomical Objects").Find(astronomicalObject.name);
            StartCoroutine(bugfixer(UIelement, show));
        }
    }

    //A bug, most likely caused by unity, is preventing the regions from showing up when you click a planet. 
    //Only the background shows. Stupid ass ugly fix.
    IEnumerator bugfixer(Transform UIelement, bool show)
    {
        UIelement.gameObject.SetActive(show);
        yield return new WaitForSeconds(0.1f);
        UIelement.gameObject.SetActive(show);
        yield return new WaitForSeconds(0.1f);
        yield return null;
    }
    public GameObject fuelUI;
    public void displayPlanetaryData(AstronomicalObject astroObject)
    {
        GameObject fuel = Instantiate(fuelUI, new Vector3(500,100,100), transform.rotation, this.transform);
        Text fuelText = fuel.GetComponent<Text>();
        fuelText.text = astroObject.regions[0].refineries.ToString();
    }

    //Temporary for testing displayPlanetaryData
    private void Start() {
        AstronomicalObject ast = new AstronomicalObject();
        ast.regions.Add(new Region("yolo", new Country(Country.controlledBy.NOONE)));
        displayPlanetaryData(ast);
    }
}