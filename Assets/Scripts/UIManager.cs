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
    public GameObject regionDataUI;
    public GameObject regionUI;
    public void displayRegionalData(List<float> displayableStatistics, string regionName)
    {
        GameObject regiUI = Instantiate(regionUI, new Vector3(500,100,100), transform.rotation, this.transform);


        for (int i = 0; i < 3; i++)
        {
            GameObject textUIObject = Instantiate(regionDataUI, new Vector3(500,20*(i-1),100), transform.rotation, regiUI.transform);
            Text textUI = textUIObject.GetComponent<Text>();
            textUI.text = displayableStatistics[i].ToString();
        }
        Text regiUIMainText = regiUI.GetComponentInChildren<Text>();
        regiUIMainText.text = regionName;
    }

    //Temporary for testing displayPlanetaryData
    private void Start() {
        AstronomicalObject ast = new AstronomicalObject();
        ast.regions.Add(new Region("yolo", new Country(Country.controlledBy.NOONE)));
        List<float> statistics = new List<float>{
            ast.regions[0].fuel,
            ast.regions[0].refineries,
            ast.regions[0].hydrocarbons,

        };
        displayRegionalData(statistics, ast.name);
    }
}