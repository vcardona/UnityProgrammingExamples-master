using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploConstructores : MonoBehaviour 
{
    public EjemploConstructores()
    {

    }

	class Zombie
    {
        public string Nombre;
        public int comeCerebros;
        public int hitPoints;
        public float escudo;

        public Zombie()
        {
            Nombre = "Zombie";
            comeCerebros = 0;
            hitPoints = 10;
        }

        public Zombie(string n, int hp)
        {
            Nombre = n;
            comeCerebros = 0;
            hitPoints = hp;
        }

        public Zombie(float sangre, int hello)
        {
            Nombre = "Sergio";
            comeCerebros = hello;
            escudo = sangre;
            hitPoints = 100;

        }
    }

    void Start()
    {
        Zombie rob = new Zombie();
        rob.Nombre = "Zombie";
        rob.comeCerebros = 0;
        rob.hitPoints = 10;


        Zombie roberto = new Zombie("Roberto", 10);
        Zombie sergio = new Zombie(10.0f, 50);
    }
}
