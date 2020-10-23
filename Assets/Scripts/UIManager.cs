using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
public class UIManager : MonoBehaviour
{
    public void updateUI()
    {
        //Updates the UI every tick
    }
    [SerializeField] GameObject planetUI;
    GameObject currentPlanetUI;
    public void showPlanet(AstronomicalObject astronomicalObject, bool show)
    {
        /*if (astronomicalObject != null)
        {
            Transform UIelement = this.transform.Find("Astronomical Objects").Find(astronomicalObject.name);
            StartCoroutine(bugfixer(UIelement, show));
        }*/
        
        Destroy(currentPlanetUI);
        GameObject planetui =  Instantiate(planetUI, new Vector3(100,100,100), Quaternion.identity, this.transform);
        currentPlanetUI = planetui;
        print(astronomicalObject.Name);
        displayPlanetData(astronomicalObject.regions);
    }

    //A bug, likely caused by unity, is preventing the regions from showing up when you click a planet. 
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

    public void displayPlanetData(List<IRegion> regions)
    {
        int i = 0;
        foreach (IRegion region in regions)
        {
            GameObject regionButton = Instantiate(button,
                new Vector3(button.GetComponent<RectTransform>().rect.width*2, 
                400 - 2*button.GetComponent<RectTransform>().rect.height * i, 0), 
                Quaternion.identity, 
                currentPlanetUI.transform
            );
            regionButton.GetComponentInChildren<Text>().text = region.name;
            regionButton.GetComponent<Button>().onClick.AddListener(delegate {selectRegionButton(region);}); 
            i++;
        }
    }
    //When you click a planet and region buttons show up, this gets called
    public void selectRegionButton(IRegion region)
    {
        float[] statistics = new float[3];
        statistics[0] = region.fuel;
        statistics[1] = region.hydrocarbons;
        statistics[2] = region.refineries;
        displayRegionalData(statistics, region.name);
    }
    [SerializeField] GameObject textBox;
    [SerializeField] GameObject regionUI;
    GameObject currentlyActiveRegionUI;
    public void displayRegionalData(float[] displayableStatistics, string regionName)
    {
        //This is not good!!!!!
        List<string> statisticsNames = new List<string>{"Fuel", "Hydrocarbons", "Refineries"};
        
        GameObject regiUI = Instantiate(regionUI, new Vector3(500,100,100), transform.rotation, this.transform);
        Destroy(currentlyActiveRegionUI);
        currentlyActiveRegionUI = regiUI;

        for (int i = 0; i < displayableStatistics.Length; i++)
        {
            GameObject textUIObject = Instantiate(textBox, new Vector3(500,40*(i-1),100), transform.rotation, regiUI.transform);
            Text textUI = textUIObject.GetComponent<Text>();
            textUI.text = statisticsNames[i] +": " + displayableStatistics[i].ToString();
        }
        Text regiUIMainText = regiUI.GetComponentInChildren<Text>();

        regiUIMainText.text = regionName;
    }

    //Displays the clock in the top right corner
    public Text timeUI;
    public DateTime date = new DateTime(2030, 1, 1);
    public void displayTime(int ticks)
    {
        timeUI.text = date.ToString("yyyy-MM-dd") ; //ticks.ToString();
    }
    
}