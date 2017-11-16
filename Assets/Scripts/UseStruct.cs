using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseStruct : MonoBehaviour 
{
    BoxParameters ThatBox;

	void Update () 
	{

        ThatBox = GameObject.Find("Cube").GetComponent<AccediendoStruct>().myParameters;
        gameObject.transform.position = new Vector3(0,ThatBox.height * 0.5f, -10);
    }
}
