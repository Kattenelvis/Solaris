using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
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

    [SerializeField] GameObject button;
    [SerializeField] GameObject planetUI;
    [SerializeField] GameObject regionalUI;
    public void displayPlanet(List<IRegion> regions)
    {
        int i = 0;
        foreach (IRegion region in regions)
        {
            GameObject regionButton = Instantiate(button, new Vector3(button.GetComponent<RectTransform>().rect.width*2, 400 - 2*button.GetComponent<RectTransform>().rect.height * i, 0), Quaternion.identity, planetUI.transform);
            regionButton.GetComponentInChildren<Text>().text = region.name;
            regionButton.GetComponent<Button>().onClick.AddListener(delegate {selectRegionButton(region);}); 
            i++;
        }
    }
    public void selectRegionButton(IRegion region)
    {
        Debug.Log(region.name);
    }
    public GameObject textBox;
    public GameObject regionUI;
    public void displayRegionalData(List<float> displayableStatistics, List<string> statisticsNames, string regionName)
    {
        GameObject regiUI = Instantiate(regionUI, new Vector3(500,100,100), transform.rotation, this.transform);

        for (int i = 0; i < 3; i++)
        {
            GameObject textUIObject = Instantiate(textBox, new Vector3(500,20*(i-1),100), transform.rotation, regiUI.transform);
            Text textUI = textUIObject.GetComponent<Text>();
            textUI.text = statisticsNames[i] +": " + displayableStatistics[i].ToString();
        }
        Text regiUIMainText = regiUI.GetComponentInChildren<Text>();
        regiUIMainText.text = regionName;
    }



    //Temporary for testing displayPlanetaryData
    /*private void Start() {
        AstronomicalObject ast = new AstronomicalObject();
        ast.regions.Add(new Region("Asia", new Country(Country.controlledBy.NOONE)));
        List<float> statistics = new List<float>{
            ast.regions[0].fuel,
            ast.regions[0].refineries,
            ast.regions[0].hydrocarbons,

        };

        List<string> statisticsNames = new List<string>{
            "fuel",
            "refineries",
            "hydrocarbons",
        };
        displayRegionalData(statistics, statisticsNames, ast.regions[0].name);
    }*/

    public Text timeUI;
    public DateTime date = new DateTime(2030, 1, 1);
    public void displayTime(int ticks)
    {
        timeUI.text = date.ToString("yyyy-MM-dd") ; //ticks.ToString();
    }

}