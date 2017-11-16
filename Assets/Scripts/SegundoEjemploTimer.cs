using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegundoEjemploTimer : MonoBehaviour
{
    //Variable que almacena el valor para comparar.
    float NexTime = 0;

    //Variable que contiene los segundos para volver activar algo
    public int Timer;

    void Update()
    {
        if (Time.fixedTime > NexTime)
        {
            NexTime = Time.fixedTime + Timer;
            //Se almacena la variable para controlar el tiempo de ejecución.

            //Debug para verificar el funcionamiento.
            Debug.Log("Hola, tiempo: "+ NexTime);
        }
    }
}
