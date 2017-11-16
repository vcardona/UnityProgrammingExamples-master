using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreandoConConstructores : MonoBehaviour 
{

    class crearCubo
    {

        public float valorEscala;
        public string colorDelCubo;
        public float rotacionDelCubo;
        public GameObject cuboCrear;

        public crearCubo()
        {
            Debug.Log("Cubo normal");
            cuboCrear = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject box = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        }

        public crearCubo(float valorEscalacubo)
        {
            Debug.Log("Cubo con escala igual a: " + valorEscala);
            cuboCrear = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cuboCrear.transform.localScale = new Vector3(valorEscalacubo, valorEscalacubo, valorEscalacubo);
        }

        public crearCubo(float rotacion, string color)
        {
            Debug.Log("El color es: "+ color);

            cuboCrear = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cuboCrear.transform.localScale = new Vector3(rotacion, rotacion, rotacion);
            cuboCrear.transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotacion));
            cuboCrear.gameObject.GetComponent<Renderer>().material.color = Color.magenta;

        }

        public crearCubo(string colorDelCubo)
        {
            valorEscala = 30;
            rotacionDelCubo = 45;
            cuboCrear = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cuboCrear.transform.localScale = new Vector3(valorEscala, valorEscala, valorEscala);
            cuboCrear.transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotacionDelCubo));
            switch (colorDelCubo)
            {
                case "Azul":
                    cuboCrear.gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    break;
                case "Verde":
                    cuboCrear.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    break;
                case "Rojo":
                    cuboCrear.gameObject.GetComponent<Renderer>().material.color = Color.red;
                    break;
                default:
                    cuboCrear.gameObject.GetComponent<Renderer>().material.color = Color.magenta;
                    break;

            }
        }
    }

    public bool cuboNormal = false;
    public bool cuboEscala = false;
    public bool cuboColor = false;
    public bool cuboRotacion = false;
    public int creado = 0;

	void Update () 
	{
        if (cuboNormal == true && creado == 0) { crearCubo cubo = new crearCubo(); creado = 1; }
        if (cuboEscala == true && creado == 0) { crearCubo cuboEscala = new crearCubo(20); creado = 1; }
        if (cuboColor == true && creado == 0) { crearCubo cuboDeColor = new crearCubo("Verde"); creado = 1; }
        if (cuboRotacion == true && creado == 0) { crearCubo cuboRatacion = new crearCubo(45, "Rojo"); creado = 1; }
	}
	
}
