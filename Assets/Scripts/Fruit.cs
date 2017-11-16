using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour 
{
    public Fruit()
    {
        Debug.Log("1st Llamado constructor Fruta");
    }

    public void Chop()
    {
        Debug.Log("La fruta fue cortada");
    }

    public void SayHello()
    {
        Debug.Log("Hello, Soy una fruta");
    }

}
