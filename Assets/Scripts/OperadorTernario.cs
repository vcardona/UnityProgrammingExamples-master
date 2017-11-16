using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperadorTernario : MonoBehaviour 
{
	void Start () 
	{
        int health = 10;
        string message;

        

        message = health > 0 ? "Player esta vivo" : health == 0 ? "Player es raro" :
           "Player esta Muerto";

        message = health > 0 ? "Player esta vivo" : "Player esta muerto";

        if (health > 0)
        {
            message = "Player esta vivo";
        }
        else
        {
            message = "Player esta muerto";
        }
	}
	
	
}
