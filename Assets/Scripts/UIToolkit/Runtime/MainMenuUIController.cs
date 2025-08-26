using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuUIController : MonoBehaviour
{
    [SerializeField] private UIDocument UIDocument;
    [SerializeField] private StyleSheet UIStyleSheet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Generate();
        var btn = UIDocument.rootVisualElement.Q<Button>("btn");
    }

    private void Generate()
    {
        var root = UIDocument.rootVisualElement;
        
        var titleLabel = new Label("Hello");
        titleLabel.style.color = new StyleColor(Color.blue);
        titleLabel.style.fontSize = 100;
        root.Add(titleLabel);
    }
}
