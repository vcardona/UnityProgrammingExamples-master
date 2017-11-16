using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploArrayList : MonoBehaviour 
{
     public ArrayList aList = new ArrayList();

	void Start () 
	{
        int i = 3;
        aList.Add(i);
        print(aList[0]);
	}
	
}
