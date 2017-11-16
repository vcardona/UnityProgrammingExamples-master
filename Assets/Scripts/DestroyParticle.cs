using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticle : MonoBehaviour 
{
    public int tiempoDestruccion;

	void Start () 
	{
        Destroy(gameObject, tiempoDestruccion);
    }
	
	
}
