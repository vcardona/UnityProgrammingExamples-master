using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciandoObjetos : MonoBehaviour 
{
    public Transform prefab;

    public Rigidbody projectile;
    public Transform Arma;
    public Transform IgnorarUno;
    public Transform IgnorarDos;
    public int velocidadProjectile;

    void Update()
    {
        if(Input.GetButtonDown("Fire1") && Time.timeScale == 1.0F)
        {
            Debug.Log("prueba input");
            //instanciandoEsferas();


            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            Physics.IgnoreCollision(clone.GetComponent<Collider>(), GetComponent<Collider>());
            clone.velocity = transform.TransformDirection(Vector3.forward * velocidadProjectile);
            
        }
    }

    void instanciandoEsferas()
    {
        int ubicacionEnX = Random.Range(1,15);
        int ubicacionEnY = Random.Range(1,20);
            Instantiate(prefab, new Vector3(ubicacionEnX, ubicacionEnY, 24), Quaternion.identity);
        
    }


}
