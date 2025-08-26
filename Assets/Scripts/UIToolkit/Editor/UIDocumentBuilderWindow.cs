using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class UIDocumentBuilderWindow : EditorWindow
{
    [SerializeField] private UIDocument uiDocument;

    [MenuItem("Tools/UIDocument Builder Window")]
    public static void ShowWindow()
    {
        var window = GetWindow<UIDocumentBuilderWindow>("UI Document Builder");
        window.Show();
    }

    private void OnGUI()
    {
        EditorGUILayout.LabelField("Assign UIDocument:");
        uiDocument = (UIDocument)EditorGUILayout.ObjectField(uiDocument, typeof(UIDocument), true);

        if (GUILayout.Button("Generate UI Document"))
        {
            GenerateUIDocument();
        }
    }

    private void GenerateUIDocument()
    {
        if (uiDocument == null)
        {
            Debug.LogError("No UIDocument assigned.");
            return;
        }
        var root = uiDocument.rootVisualElement;
        var titleLabel = new Label("Hello");
        titleLabel.style.color = new StyleColor(Color.blue);
        root.Add(titleLabel);
        Debug.Log("UI Document generated.");
    }
}
