using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarAudioSource : MonoBehaviour 
{
    public AudioSource audio;
    
 
	void Start () 
	{
         audio = GetComponent<AudioSource>();
    }

    public int totalSalud = 100;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            audio.Play();
            totalSalud += 100;
            Debug.Log("Salud del Jugador: " + totalSalud);

        }
    }
}
