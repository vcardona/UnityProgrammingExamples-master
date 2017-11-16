using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ejercicios : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i < 9)
            {
                continue;
            }
            Debug.Log(i);
        }

        // Keep the console open in debug mode.
        Debug.Log("Press any key to exit.");
        
    }

   
}
