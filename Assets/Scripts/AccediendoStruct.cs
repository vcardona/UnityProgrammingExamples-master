using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct BoxParameters
{
    public float width;
    public float height;
    public float depth;
    public Color color;
}

public class AccediendoStruct : MonoBehaviour 
{
    public BoxParameters myParameters;
    public int dato = 1;
    public float datoDos;
    public string datoTres = "1";

	void Start () 
	{

        myParameters.width = 2;
        myParameters.height = 3;
        myParameters.depth = 4;
        myParameters.color = new Color(1, 0, 0, 1);
    }
}
