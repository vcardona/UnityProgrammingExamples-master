using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploEnums : MonoBehaviour 
{
    public enum TipoDePrimitiva
    {
        Sphere,
        Capsule,
        Cylinder,
        Cube,
        Plane
    }
    public TipoDePrimitiva tipoDePrimitiva;

    public enum tipoDeColor
    {
        red,
        blue,
        green
    }
    public tipoDeColor miColor;
	
	void Update () 
	{
		switch(miColor)
        {
            case tipoDeColor.red:
                Debug.Log("Color seleccionado ROJO");
                break;
            case tipoDeColor.blue:
                Debug.Log("Colro seleccionado Azul");
                break;
            case tipoDeColor.green:
                Debug.Log("Color seleccionado VERDE");
                break;
            
        }
	}
}
