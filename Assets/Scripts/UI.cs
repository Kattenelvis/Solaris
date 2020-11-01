using UnityEngine;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{
    Label counterLabel;
    Button counterButton;
    VisualElement planetScreen;
    int count;
    VisualElement rootVS;
    void OnEnable()
    {
        rootVS = GetComponent<UIDocument>().rootVisualElement;

        //counterLabel = rootVS.Q<Label>("Tee");
        //counterButton = rootVS.Q<Button>("Cool-Button");
        planetScreen = rootVS.Q<VisualElement>("planet-screen");

        //counterButton.RegisterCallback<ClickEvent>(ev => Increment());
    }

    void Increment()
    {
        count++;
        counterLabel.text = $"{count}";
    }

    public void displayPlanetUI(AstronomicalObject planet)
    {
        planetScreen.visible = true;

        foreach (Region region in planet.regions)
        {
            Button regionButton = new Button();
            regionButton.text = region.name;
            planetScreen.Add(regionButton);

        }
        //counterLabel.visible = false;
        //counterButton.visible = false;
    }

    public void hidePlanetUI()
    {
        planetScreen.visible = false;
    }
}