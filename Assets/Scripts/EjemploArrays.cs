using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploArrays : MonoBehaviour 
{

    public int variable1;
    public int variable2;
    public int variable3;

    public int medidaArray;

    public int[] variables = new int [20];

    public float variableDos;

    public float[] SegundaPrueba;

    public GameObject[] ejemploDos;

    void Start () 
	{
        Debug.Log("Yo estoy en el Start");
        SegundaPrueba = new float[medidaArray];
        Debug.Log(variables.Length);
        for (int i = 0; i < ejemploDos.Length; i ++)
        {
            ejemploDos[i].name = i.ToString();
            ejemploDos[i].gameObject.transform.position = new Vector3(i,i,i);
        }
        foreach(GameObject MyAbuelo in ejemploDos)
        {
            Debug.Log(MyAbuelo.name);
        }
		
	}
    int[] scores = new int[10];
    int i = 0;
    
}
