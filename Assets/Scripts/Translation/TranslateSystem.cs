using System;
using Controller;
using Microsoft.MixedReality.Toolkit.UX;
using UnityEditor;
using UnityEngine;

namespace Translation
{
    public class TranslateSystem : MonoBehaviour
    {
        [SerializeField] private DialogController dialogController;

        private void OnEnable()
        {
            if (!dialogController) return;
            dialogController.OpenOkayDialog("Translation",
                "Translation has been turned on", DialogController.DialogSize.Medium, (property =>
                {
                    if (property.ResultContext.ButtonType == DialogButtonType.OK)
                    {
                        Debug.Log("Dismissed dialog");
                    }
                    // TODO: callback
                }));
        }

        private void OnDisable()
        {
            if (!dialogController) return;
            dialogController.OpenOkayDialog("Translation",
                "Translation has been turned off", DialogController.DialogSize.Medium, (property =>
                {
                    if (property.ResultContext.ButtonType == DialogButtonType.OK)
                    {
                        Debug.Log("Dismissed dialog");
                    }
                    // TODO: callback
                }));
        }
    }
}