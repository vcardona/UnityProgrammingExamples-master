using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploPlayerPrefs : MonoBehaviour 
{
    public int SaludJugador;
    public int nuevaSalud;

    public void guardarSaludJugador()
    {
        PlayerPrefs.SetInt("Sangre Jugador", SaludJugador);
        Debug.Log("Se guardo la salud");
    }

    public void cargarSaludJugador()
    {
        nuevaSalud = PlayerPrefs.GetInt("Sangre Jugador");
        Debug.Log("La salud del jugador es: "+nuevaSalud);
    }

}
