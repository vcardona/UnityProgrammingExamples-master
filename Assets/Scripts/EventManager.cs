using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour 
{
    public delegate void ClickAction();
    public static event ClickAction Onclicked;

    void OnGUI()
    {
        if(GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100,30), "Click"))
        {
            if (Onclicked != null)
                Onclicked();
        }
    }
}
