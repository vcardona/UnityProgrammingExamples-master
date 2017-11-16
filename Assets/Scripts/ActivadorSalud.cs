using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorSalud : MonoBehaviour 
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Prueba Salud");
        }
    }
}
