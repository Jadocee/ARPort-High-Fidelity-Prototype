using JetBrains.Annotations;
using Microsoft.MixedReality.Toolkit.UX;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TranslationAlert : MonoBehaviour
{
    public TextMeshPro DescriptionText;
    public bool TranslationStatus = false;
    public PressableButton Translate;
    private Dialog DialogPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Translate.OnClicked.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        Dialog.InstantiateFromPrefab(DialogPrefab, new DialogProperty("Translation", 
            TranslationStatus ? "Translation has been turned on" : "Translation has been turned off", DialogButtonHelpers.OK), true, false);
        TranslationStatus = !TranslationStatus;
    }
}