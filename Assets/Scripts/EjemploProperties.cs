using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploProperties : MonoBehaviour 
{
    void Start()
    {
        int x = EjemploStatic.enemyCount;
        Debug.Log("Cuanto vale X " + x);

        int Suma = EjemploStatic.Add(50, 30);
        Debug.Log("El resultado de la suma es: "+ Suma);

        SobreCarga mySuma = new SobreCarga();
        int resultadoInt = mySuma.Suma(50,80);
        string resultadoSuma = mySuma.Suma("Hola "," Grupo");
        Debug.Log(resultadoInt);
        Debug.Log(resultadoSuma);
    }

    private int experience;

    public int Experience
    {
        get
        {
            return experience;
        }

        set
        {
            experience = value;
        }

    }

    public int Level
    {
        get
        {
            return experience / 1000;
            
        }

        set
        {
            experience = value * 1000;
            prueba();
        }
    }

    void prueba()
    {
        Debug.Log("Prueba");
    }
}
