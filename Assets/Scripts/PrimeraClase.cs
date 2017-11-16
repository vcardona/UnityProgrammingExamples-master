using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeraClase : MonoBehaviour 
{
    public int intCantidadBalas;
    private float floatValorEscudo = 10.0f;
    public bool boolCarroLugar = true;
    public string strNombrePersonaje = "";

    public string comoSaluda = "";

    void Start () 
	{
        Debug.Log("Estoy en el Start");
        SaludoGrupo(comoSaluda);
	}

    public void ImprimirSaludo()
    {
        Debug.Log("Hola grupo");
        if (boolCarroLugar) 
        {
            Debug.Log("Si esta");
            
        }
    }
	
	void Update () 
	{
        //Debug.Log("Hola Updates");
	}

    public bool boolSaludogrupo = true;

    void SaludoGrupo(string salud)
    {
        bool carro = true;
        if(carro)
        {
            Debug.Log(salud);
        }
        
    }

    void SaludoGrupo()
    {
        Debug.Log("Saludo para todos");
    }

    int comprarAlgo(string que, int dinero)
    {
        int gaseosa = 10;

        return gaseosa;
    }

    void Awake()
    {
        Debug.Log("Estoy en el Awake");
        SaludoGrupo(comoSaluda);
    }
}
