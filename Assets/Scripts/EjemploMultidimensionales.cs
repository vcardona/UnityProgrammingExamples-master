using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploMultidimensionales : MonoBehaviour 
{

    public string[,] seleccionInventario;

    void Start () 
	{
        seleccionInventario = new string[3, 4] {    {"Carro", "Escudo", "Arma", "Cañon" },
                                                    {"Posión", "salud", "Armadura", "Veneno" },
                                                    {"Vida", "Muerte", "Fuego", "Aire" }
                                                };
    }

    public void ImpresionElemento(int f)
    {

        switch(f)
        {
            case 1:
                Debug.Log("Selecciono el elemento 1");
                Debug.Log(seleccionInventario[0,0]);
                break;
            case 2:
                Debug.Log("Selecciono el elemento 2");
                Debug.Log(seleccionInventario[0, 1]);
                break;
            case 3:
                Debug.Log("Selecciono el elemento 3");
                Debug.Log(seleccionInventario[0, 2]);
                break;
            case 4:
                Debug.Log("Selecciono el elemento 4");
                Debug.Log(seleccionInventario[0, 3]);
                break;
            case 5:
                Debug.Log("Selecciono el elemento 5");
                Debug.Log(seleccionInventario[1, 0]);
                break;
            case 6:
                Debug.Log("Selecciono el elemento 6");
                Debug.Log(seleccionInventario[1, 1]);
                break;

        }
    }
	
}
