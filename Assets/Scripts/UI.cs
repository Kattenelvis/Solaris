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
    VisualElement regionScreen;
    AstronomicalObject selectedPlanet;
    public void updateUI()
    {
        displayPlanetUI(selectedPlanet);
    }
    void OnEnable()
    {
        rootVS = GetComponent<UIDocument>().rootVisualElement;

        planetName = rootVS.Q<Label>("planet-name");
        defaultPlanetButton = rootVS.Q<Button>("planet-button");
        planetButtons = rootVS.Q<IMGUIContainer>("regions");
        planetScreen = rootVS.Q<VisualElement>("planet-screen");
        dateUI = rootVS.Q<Label>("the-date");
        regionScreen = rootVS.Q<VisualElement>("region-screen");
    }

    public void displayPlanetUI(AstronomicalObject planet)
    {
        //Clears previous UI
        hidePlanetUI();

        selectedPlanet = planet;
        planetScreen.visible = true;
        planetName.text = planet.Name;

        foreach (Region region in planet.regions)
        {
            Button regionButton = new Button();
            regionButton.text = region.name;
            regionButton.focusable = true;
            planetButtons.hierarchy.Add(regionButton);
            regionButton.RegisterCallback<ClickEvent>(ev => displayRegionUI(region));
        }
    }
    public void hidePlanetUI()
    {
        planetScreen.visible = false;
        planetButtons.hierarchy.Clear();
        regionScreen.visible = false;
    }
    void displayRegionUI(Region region)
    {
        regionScreen.visible = true;

        //TODO: Figure out a way to simplify this
        regionScreen.Q<Label>("region-name").text = region.name;
        regionScreen.Q<Label>("hydrocarbons").text = $"Hydrocarbons: {region.hydrocarbons}";
        regionScreen.Q<Label>("refineries").text = $"Refineries: {region.refineries}";
        regionScreen.Q<Label>("fuel").text = $"Fuel: {region.fuel}";
        regionScreen.Q<Label>("owner").text = $"Owner: {region.owner.name}";
    }

    public DateTime date = new DateTime(2030, 1, 1);
    public void displayDate()
    {
        dateUI.text = date.ToString("yyyy-MM-dd");
    }
}