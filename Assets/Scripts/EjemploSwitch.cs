using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploSwitch : MonoBehaviour 
{
    void Start()
    {
        int activar = Random.Range(1,4);
        FuncionamientoSwitch(activar);
    }


    void FuncionamientoSwitch(int activador)
    {
        int caseSwitch = activador;

        switch (caseSwitch)
        {
            case 1:
                Debug.Log("Hola caso 1");
                break;
            default:
                Debug.Log("Hola caso 3");
                break;
            case 2:
                Debug.Log("Hola caso 2");
                break;
            
        }
    }

    void FuncionamientoSwitch(string activador)
    {
        string caseSwitch = activador;

        switch (caseSwitch)
        {
            case "Hola 1":
                Debug.Log("Hola caso 1");
                break;
          
            case "Hola 2":
                Debug.Log("Hola caso 2");
                break;

            case "Hola 3":
                Debug.Log("Hola caso 2");
                break;

            default:
                Debug.Log("Hola caso 3");
                break;

        }
    }

}
