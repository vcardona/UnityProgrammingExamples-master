using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColorScript : MonoBehaviour 
{
    Material material;

    private void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    private void OnEnable()
    {
        EventManager.Onclicked += TurnColor;
    }

    private void OnDisable()
    {
        EventManager.Onclicked -= TurnColor;
    }

    void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        material.color = col;
    }
}
