using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour 
{
    private void OnEnable()
    {
        EventManager.Onclicked += Teleport;
    }

    private void OnDisable()
    {
        EventManager.Onclicked -= Teleport;
    }

    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(1.0f, 3.0f);
        transform.position = pos;
    }
}
