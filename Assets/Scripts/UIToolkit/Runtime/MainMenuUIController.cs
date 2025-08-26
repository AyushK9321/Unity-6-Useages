using System;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuUIController : MonoBehaviour
{
    [SerializeField] private UIDocument UIDocument;
    //[SerializeField] private StyleSheet UIStyleSheet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Generate();
    }
    private void OnValidate()
    {
        Debug.Log("OnValidate called");
        if (Application.isPlaying)
            return;
        Generate();
    }

    private void Generate()
    {
        var root = UIDocument.rootVisualElement;
        root.Clear();
        var titleLabel = new Label("Hello");
        titleLabel.style.color = new StyleColor(Color.blue);
        titleLabel.style.fontSize = 100;
        var button = new Button();
        button.text = "Click Me";
        button.style.fontSize = 75;
        root.Add(titleLabel);
        root.Add(button);
    }
}
