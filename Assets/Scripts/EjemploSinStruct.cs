using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploSinStruct : MonoBehaviour 
{
    public object[] PlayerDataArray;

    void Start()
    {
        PlayerDataArray[0] = new Vector3();//Position
        PlayerDataArray[1] = 10;// Hit Points
        PlayerDataArray[2] = 13;//Ammo
        PlayerDataArray[3] = 6.5f;//Run Speed
        PlayerDataArray[4] = 1.2f;//Walk Speed
    }
}
