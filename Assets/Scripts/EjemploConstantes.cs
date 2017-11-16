using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploConstantes : MonoBehaviour 
{
    /****************************************************************************************/
    /*  La palabra clave Const es usada para decirle a cualquiera que este leyendo el       */
    /*  código, que el valor asignado no puede cambiar durante la ejecución del juego.       */
    /*                                                                                      */
    /****************************************************************************************/
    
    const int MaxHitPoints = 10;

    private const int velocidadMaxima = 180;

    public static int VelocidadMaxima
    {
        get
        {
            return velocidadMaxima;
        }
    }
    // Cuando definimos un valor de este tipo siempre nos pide que encapsulemos.
    // y que usemos una propiedad.
}
