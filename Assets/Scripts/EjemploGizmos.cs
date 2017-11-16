using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploGizmos : MonoBehaviour 
{
    public Rigidbody projectile;
    Vector3 posicionActual;
    public int CuadrarVelocidad;
    public Transform SphereOutSide;

    void Start()
    {
        posicionActual = transform.position;
    }

    void Update()
    {
        if (posicionActual != transform.position)
        {
            lanzarProjectile();
            posicionActual = transform.position;
        }

        transform.rotation = SphereOutSide.rotation;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5F);
        Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));
    }

    public void lanzarProjectile()
    {
        Rigidbody clone;
        clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
        //Physics.IgnoreCollision(clone.GetComponent<Collider>(), GetComponent<Collider>());
        clone.velocity = transform.TransformDirection(Vector3.forward * CuadrarVelocidad);

    }
    
}
