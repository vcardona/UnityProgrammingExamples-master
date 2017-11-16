using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour 
{
    public AudioClip saludActiva;
    public AudioClip venenoActivo;
    AudioSource reproductorAudio;
    public Slider controlVolumen;

    private void Update()
    {
        reproductorAudio.volume = controlVolumen.value;
    }

    void Start () 
	{
        reproductorAudio = GetComponent<AudioSource>();

        for(int i = 0; i < 20; i++)
        {
            Debug.Log("Hola grupo de la tarde");
            if(i == 5)
            {
                Debug.Log("Encontre el numero 5");
                continue;
            }

            else
            {
                Debug.Log("Este es el si no directo");
            }
        }
	}
	
    public void activandoAudio(string nombreAudio)
    {
        string nombreCancion = nombreAudio;

        switch(nombreCancion)
        {
            case "saludActiva":
                reproductorAudio.PlayOneShot(saludActiva);
                break;
            case "venenoActivo":
                reproductorAudio.PlayOneShot(venenoActivo);
                break;
            default:
                Debug.Log("El nombre es incorrecto");
                break;
        }
        
        
        

        Debug.Log("Activando el Audio");
    }


}
