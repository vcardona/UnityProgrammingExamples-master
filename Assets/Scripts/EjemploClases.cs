using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploClases : MonoBehaviour 
{


    class primeraClase
    {
      public  int numero;
    }

    void Start()
    {
        primeraClase MyPrimeraClase = new primeraClase();
        MyPrimeraClase.numero = 20;

    }

    void Update()
    {
        
    }
}
