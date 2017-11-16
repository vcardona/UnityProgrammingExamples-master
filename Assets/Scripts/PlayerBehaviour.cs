using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour 
{
    public int valorVeneno = 50;
    public int valorvenenoDos = 30;
    public int valorSalud = 40;
    public int saludJugador = 25;
    public int cantidadVecesVeneno = 10;
    public string nombreSonido;

    public Slider mainSlider;

    public AudioManager activarAudio;

    private void Start()
    {
        SendMessage("saludoGrupo");
        nombreSonido = "Carrito";
        
        activarAudio.activandoAudio(nombreSonido);
    }

    void OnTriggerEnter(Collider other)
    {
        if (saludJugador < 1000)
        {

            if (other.CompareTag("Salud"))
            {

                saludJugador += valorSalud;

                mainSlider.value = saludJugador;


                Debug.Log("Cantidad de Salud: " + saludJugador);

            }
        }
        
            if(other.CompareTag("Veneno"))
            {
                saludJugador -= valorVeneno;
                mainSlider.value = saludJugador;
                Debug.Log("Cantidad de Salud: " + saludJugador);
                cantidadVecesVeneno += 1;
                Debug.Log("Veces veneno: "+ cantidadVecesVeneno);
            }
            

    }
}
