using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SobreCarga : MonoBehaviour 
{
	public int Suma(int numeroUno, int numeroDos)
    {
        return numeroUno + numeroDos;
        
    }

    public string Suma(string letraUno, string letraDos)
    {
        return letraUno + letraDos;
    }

    public void saludos()
    {
        Debug.Log("Muestra cambios GitHub");
    }
}
