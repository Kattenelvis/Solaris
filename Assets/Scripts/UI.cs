using UnityEngine;
using UnityEngine.UIElements;
using System;
public class UI : MonoBehaviour
{
    Label counterLabel;
    Button counterButton;
    VisualElement planetScreen;
    int count;
    VisualElement rootVS;
    Label planetName;
    Button defaultPlanetButton;
    IMGUIContainer planetButtons;
    Label dateUI;
    void OnEnable()
    {
        rootVS = GetComponent<UIDocument>().rootVisualElement;

        planetName = rootVS.Q<Label>("planet-name");
        defaultPlanetButton = rootVS.Q<Button>("planet-button");
        planetButtons = rootVS.Q<IMGUIContainer>("regions");
        planetScreen = rootVS.Q<VisualElement>("planet-screen");
        dateUI = rootVS.Q<Label>("the-date");
    }
    AstronomicalObject currentlyOnDisplay;
    public void displayPlanetUI(AstronomicalObject planet)
    {
        if (currentlyOnDisplay == planet)
            return;

        currentlyOnDisplay = planet;
        planetScreen.visible = true;
        planetName.text = planet.Name;

        foreach (Region region in planet.regions)
        {
            Button regionButton = new Button();
            regionButton.text = region.name;
            regionButton.focusable = true;
            planetButtons.hierarchy.Add(regionButton);
            regionButton.RegisterCallback<ClickEvent>(ev => displayRegionUI(region.name));
        }
    }
    public void hidePlanetUI()
    {
        planetScreen.visible = false;
        currentlyOnDisplay = null;
        planetButtons.hierarchy.Clear();
    }
    void displayRegionUI(string region)
    {
        print($"this is the region {region}");
    }

    public DateTime date = new DateTime(2030, 1, 1);
    public void displayDate()
    {
        dateUI.text = date.ToString("yyyy-MM-dd");
    }

}