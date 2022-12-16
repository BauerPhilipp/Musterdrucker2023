using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WindowButtons : MonoBehaviour
{
    Button closeButton;
    UIDocument uiDocument;

    private void Start()
    {
        uiDocument = GetComponent<UIDocument>();
        closeButton = uiDocument.rootVisualElement.Q<Button>("buttonClose");
        closeButton.clicked += CloseApp;
    }

    public void CloseApp()
    {
        Application.Quit();
    }

}
