using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using ejemploVictor;
using EjemploOtroNameSpace;


public class OrdenDeEjecucion : MonoBehaviour 
{
    //Ejemplo en el que se muestra el orden de ejecución de los metodos principales de Unity

    //Cuando une nueva instancia de MonoBehaviour es creada, llama las funciones Awake - OnEnabled - Start

    public int valorAleatorio;
    public int aleatorioDos;

    void Awake()
    {
        Debug.Log("Primer Awake");
        ejemploVictor.MyClass otraClase = new ejemploVictor.MyClass();
        aleatorioDos = UnityEngine.Random.Range(5,50);
    }

    void OnEnable()
    {
        Debug.Log("Primer OnEnable");
    }

    void Start () 
	{
        Debug.Log("Primer Start");
        valorAleatorio = UnityEngine.Random.Range(1,10);
    }

    void FixedUpdate()
    {
        Debug.Log("Primer FixedUpdate");
    }

    void Update () 
	{
        Debug.Log("Primer Update");
    }

    void LateUpdate()
    {
        Debug.Log("Primer LateUpdate");
        //Destroy(this);

        //Cuando la clase se elimina así misma primero se desabilita y luego se destruye 
    }

    void OnDisable()
    {
        Debug.Log("Primer OnDisable");
    }

    void OnDestroy()
    {
        Debug.Log("Primer OnDestroy");
    }
}
