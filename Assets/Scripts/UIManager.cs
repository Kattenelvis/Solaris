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
    public void showPlanet(AstronomicalObject astronomicalObject)
    {  
        Destroy(currentPlanetUI);
        if (astronomicalObject != null)
        {
            GameObject planetui =  Instantiate(planetUI, new Vector3(100,100,100), Quaternion.identity, this.transform);
            currentPlanetUI = planetui;
            displayPlanetData(astronomicalObject.regions);
        }
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
        float[] regionalData = new float[4];
        regionalData[0] = region.fuel;
        regionalData[1] = region.hydrocarbons;
        regionalData[2] = region.refineries;
        regionalData[3] = (int) region.owner.controller;
        displayRegionalData(regionalData, region.name);
    }
    [SerializeField] GameObject textBox;
    [SerializeField] GameObject regionUI;
    GameObject currentlyActiveRegionUI;
    public void displayRegionalData(float[] regionalData, string regionName)
    {
        List<string> dataNames = new List<string>{"Fuel", "Hydrocarbons", "Refineries", "Controller"};
        
        GameObject regiUI = Instantiate(regionUI, new Vector3(500,100,100), transform.rotation, this.transform);
        //This might look like an uneccessary step but it prevents the UI from looking weird
        regiUI.transform.parent = currentPlanetUI.transform;

        Destroy(currentlyActiveRegionUI);
        currentlyActiveRegionUI = regiUI;

        for (int i = 0; i < regionalData.Length; i++)
        {
            GenerateStatisticsText(dataNames[i], regiUI, i, regionalData[i]);
        }

        Text regiUIMainText = regiUI.GetComponentInChildren<Text>();
        regiUIMainText.text = regionName;

    }

    void GenerateStatisticsText(string dataName, GameObject regiUI, int i, float data)
    {
        GameObject textUIObject = Instantiate(textBox, new Vector3(500, -10 * (i - 1), 100), transform.rotation, regiUI.transform);
        Text textUI = textUIObject.GetComponent<Text>();
        if(dataName == "Controller")
            textUI.text = dataName + ": " + ((Country.controlledBy) data).ToString();
        else
            textUI.text = dataName + ": " + data.ToString();
    }

    //Displays the clock in the top right corner
    public Text timeUI;
    public DateTime date = new DateTime(2030, 1, 1);
    public void displayTime(int ticks)
    {
        timeUI.text = date.ToString("yyyy-MM-dd") ; //ticks.ToString();
    }
    
}