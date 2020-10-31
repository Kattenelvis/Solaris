using UnityEngine;
using UnityEngine.UIElements;

public class UI : MonoBehaviour {
    private Label counterLabel;
    private Button counterButton;
    int count;
    void OnEnable()
    {
        var rootVS = GetComponent<UIDocument>().rootVisualElement;

        counterLabel = rootVS.Q<Label>("Tee");
        counterButton = rootVS.Q<Button>("Cool-Button");

        counterButton.RegisterCallback<ClickEvent>(ev => Increment());
    }

    void Increment()
    {
        count++;
        counterLabel.text = $"{count}";
    }
}