using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploMovimiento : MonoBehaviour 
{
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    public float thrust;
    public Rigidbody rb;

    void Start()
    {
         rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump") && estaEnElPiso == true)
        {
            rb.AddForce(0, thrust, 0, ForceMode.Impulse);
        }
    }

    public bool estaEnElPiso = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Piso"))
        {
            
            estaEnElPiso = true;
            Debug.Log("Tocando el piso " + estaEnElPiso);
        }    
    }

    void OnCollisionExit(Collision cosito)
    {
        
        estaEnElPiso = false;
        print("No longer in contact with " + estaEnElPiso);
    }

    void saludoGrupo()
    {
        Debug.Log("Saludo Grupo");
    }
}
