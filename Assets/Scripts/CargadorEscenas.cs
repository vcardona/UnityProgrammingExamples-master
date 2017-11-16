using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargadorEscenas : MonoBehaviour 
{
	void Start () 
	{
		
	}
	
	void Update () 
	{
		

	}

    public void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
