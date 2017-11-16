using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatevsFixedUpdate : MonoBehaviour 
{

    void Start()
    {
        if(StaticExample.funcionamiento == false)
        {
            Debug.Log("Esta verificando el Static");
        }
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }


    void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}
