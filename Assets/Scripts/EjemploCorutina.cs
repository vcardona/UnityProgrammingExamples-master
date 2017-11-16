using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EjemploCorutina : MonoBehaviour
{
    public Transform targetPisoUno;
    public Transform targetPisoDos;
    public Transform targetPisoTres;
    public Transform targetPisoCuatro;
    public Transform targetPisoCinco;
    public Transform targetPisoSeis;
    public Transform targetPisoSiete;
    public Transform targetPisoOcho;
    public Transform targetPisoNueve;
    public Transform targetPisoDiez;

    public Canvas canvas;


    public float speed;

    public void ActivarMovimiento(string seleccionPiso)
    {
      
        switch(seleccionPiso)
        {
            case "PisoUno":
                Debug.Log("Mover el piso 1");
                break;
            case "PisoDos":
                Debug.Log("Mover el piso 1");
                break;

            default:
                Debug.Log("Este piso no existe");
                break;

        }

        Fade();
    }

    void Start()
    {
        StartCoroutine("Fade");
        //ejemploDeUna();
        canvas.enabled = false;
    }

    IEnumerator Fade()
    {
        for (float f = 100f; f >= 0; f -= 0.1f)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, 
                targetPisoUno.position, step);
            yield return null;

            if(transform.position == targetPisoUno.position)
            {
                Debug.Log("Las dos posiciones son iguales");
                break;
            }
        }
    }

    void ejemploDeUna()
    {
        for (float f = 50f; f >= 0; f -= 0.1f)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPisoUno.position, step);
            
        }
    }

}
