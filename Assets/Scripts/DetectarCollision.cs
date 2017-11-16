using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarCollision : MonoBehaviour 
{
    static Vector3 puntoDeContacto;
    public Transform SpawnPoint;
    public float sumaEnZ;
    public static Vector3 velocidadVector;
    public EjemploGizmos instanciarOtroProjectile;
    

    void OnCollisionEnter(Collision other)
    {
        //print("Points colliding: " + other.contacts.Length);
       // print("First point that collided: " + other.contacts[0].point);
        puntoDeContacto = other.contacts[0].point;
        Debug.Log("Punto de contacto" + puntoDeContacto);
        //other.transform.position = SpawnPoint.transform.position;
        velocidadVector = other.rigidbody.velocity;
        Debug.Log("velocidad del RigidBody" + velocidadVector);
        SpawnPoint.transform.position = new Vector3(other.contacts[0].point.x + sumaEnZ, other.contacts[0].point.y, other.contacts[0].point.z);
        
    }
}
