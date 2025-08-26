    using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

namespace UIToolkit.Editor
{
    public class UIDocumentBuilderWindow : EditorWindow
    {
        private UIDocument _uiDocument;

        [MenuItem("CustomUIToolkit/UIDocument Builder Window")]
        public static void ShowWindow()
        {
            var window = GetWindow<UIDocumentBuilderWindow>("UI Document Builder");
            window.Show();
        }

        public void CreateGUI()
        {
            var objectField = new ObjectField("UIDocument")
            {
                objectType = typeof(UIDocument),
                allowSceneObjects = true
            };
            objectField.RegisterValueChangedCallback(evt =>
            {
                _uiDocument = evt.newValue as UIDocument;
            });
            rootVisualElement.Add(objectField);

            var button = new Button(GenerateUIDocument) { text = "Generate UI Document" };
            rootVisualElement.Add(button);
        }
        private void OnValidate()
        {
            Debug.Log("OnValidate called");
            if (Application.isPlaying)
                return;
            Generate();
        }

        private void GenerateUIDocument()
        {
            if (_uiDocument == null)
            {
                Debug.LogError("No UIDocument assigned.");
                return;
            }
            var root = _uiDocument.rootVisualElement;
            var titleLabel = new Label("Hello");
            titleLabel.style.fontSize = 100;
            titleLabel.style.color = new StyleColor(Color.blue);
            root.Add(titleLabel);
            Debug.Log("UI Document generated.");
        }
        private void Generate()
        {
            var root = _uiDocument.rootVisualElement;
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
}
