using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegundoArrayList : MonoBehaviour 
{
    public GameObject[] AllGameObjects;

	void Start () 
	{
        ArrayList aList = new ArrayList();
        Object[] AllObjects = 
            GameObject.FindObjectsOfType(typeof(Object)) as Object[];

        foreach(Object o in AllObjects)
        {
            GameObject go = o as GameObject;
            if(go != null)
            {
                aList.Add(go);
            }
        }

        AllGameObjects = new GameObject[aList.Count];
        aList.CopyTo(AllGameObjects);
    }
	
}
