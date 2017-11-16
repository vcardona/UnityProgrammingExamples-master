using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Enemy 
{
	new public void Yell()
    {
        Debug.Log("Versión Orc del metodo Yell()");
    }
}
