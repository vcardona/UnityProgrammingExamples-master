using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploMath : MonoBehaviour 
{
    public int numBoxes;
    public GameObject[] boxes;
    public int spacing;

	void Start () 
	{
        boxes = new GameObject[numBoxes];
        for(int i = 0; i < numBoxes; i++)
        {
            GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
            box.AddComponent<Monster>();
            Monster m = box.GetComponent("Monster") as Monster;
            m.ID = i;
            m.spacing = spacing;
            boxes[i] = box;
        }
	}
}
