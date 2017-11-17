using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulticastScript : MonoBehaviour 
{

    delegate void MultiDelegate();
    MultiDelegate myMultiDelegate;

    void PowerUp()
    {
        Debug.Log("Orb is powering up!");
    }

    void TurnRed()
    {
        Debug.Log("Cambiar el color a ROJO");
    }

	void Start () 
	{
        myMultiDelegate += PowerUp;
        myMultiDelegate += TurnRed;

        if (myMultiDelegate != null)
        {
            myMultiDelegate();
        }
                
	}
	
	
}
