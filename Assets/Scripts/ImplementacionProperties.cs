using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImplementacionProperties : MonoBehaviour 
{
	void Start () 
	{
        EjemploProperties myProperties = new EjemploProperties();

        myProperties.Experience = 5;
        int x = myProperties.Experience;
        myProperties.Level = 10;
	}
	
	void Update () 
	{
		
	}
}
