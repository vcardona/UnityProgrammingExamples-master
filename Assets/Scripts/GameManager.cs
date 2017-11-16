using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
	public void PausarJuego()
    {
        if (Time.timeScale == 1.0F)
        {
            Time.timeScale = 0.0F;
        }
        else 
        {
            Time.timeScale = 1.0F;
        }
    }
}
