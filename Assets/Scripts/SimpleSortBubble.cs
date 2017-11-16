using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSortBubble : MonoBehaviour 
{
    public GameObject[] GameObjectArray;

	void Start () 
	{
        ArrayList aList = new ArrayList();
        GameObject[] gameObjects = (GameObject[])GameObject.FindObjectsOfType(typeof(GameObject));

        
        foreach(GameObject go in gameObjects)
        {
            if(go.name == "Sphere")
            {
                aList.Add(go);
            }
        }

        GameObjectArray = aList.ToArray(typeof(GameObject)) as GameObject[];

        for (int i = 0; i < GameObjectArray.Length; i++)
        {
            Debug.Log(GameObjectArray[i].transform.position);
        }
    }

    void Update()
    {
        sortObjects(GameObjectArray, out GameObjectArray);
        for(int i = 0; i < GameObjectArray.Length; i++)
        {
            Vector3 PositionA = GameObjectArray[i].transform.position;
            Debug.DrawRay(PositionA, new Vector3(0, i*2f, 0), Color.red);
        }
   
    }

    void sortObjects(GameObject[] objects, out GameObject[] sortedObjects)
    {
        for(int i = 0; i < objects.Length - 1 ; i++)
        {
            Vector3 PositionA = objects[i].transform.position;
            Debug.Log("Posición A Vector3 "+PositionA);
            Vector3 PositionB = objects[i + 1].transform.position;
            Debug.Log("Posición B Vector 3 " + PositionB);
            Vector3 VectorToA = PositionA - transform.position;
            Vector3 VectorToB = PositionB - transform.position;
            float DistanceToA = VectorToA.magnitude;
            float DistanceToB = VectorToB.magnitude;
            Debug.Log("Distancia de A " + DistanceToA);
            Debug.Log("Distancia de B "+ DistanceToB);

            if(DistanceToA > DistanceToB)
            {
                GameObject temp = objects[i];
                objects[i] = objects[i + 1];
                objects[i + 1] = temp;
            }
        }

        sortedObjects = objects;
    }
}
