using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruit 
{
	public Apple()
    {
        Debug.Log("Primer llamado Constructor Apple");
    }

    public new void Chop()
    {
        Debug.Log("La manzana ha sido cortada");
    }

    public new void SayHello()
    {
        Debug.Log("Hola, soy una manzana");
    }

}
