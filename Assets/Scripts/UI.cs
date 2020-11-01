using UnityEngine;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{
    Label counterLabel;
    Button counterButton;
    VisualElement planetScreen;
    int count;
    VisualElement rootVS;
    Label planetName;
    Button defaultPlanetButton;
    VisualElement planetButtons;
    void OnEnable()
    {
        rootVS = GetComponent<UIDocument>().rootVisualElement;

        planetName = rootVS.Q<Label>("planet-name");
        defaultPlanetButton = rootVS.Q<Button>("planet-button");
        planetButtons = rootVS.Q<VisualElement>("regions");
        planetScreen = rootVS.Q<VisualElement>("planet-screen");
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
            planetButtons.Add(regionButton);
            regionButton.RegisterCallback<ClickEvent>(ev => displayRegionUI(region.name));
        }
    }
    public void hidePlanetUI()
    {
        planetScreen.visible = false;
        currentlyOnDisplay = null;
        planetButtons.Clear();
    }
    void displayRegionUI(string region)
    {
        print($"this is the region {region}");
    }
}