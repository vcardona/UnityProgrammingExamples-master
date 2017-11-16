using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploTimersTarde : MonoBehaviour 
{
    float NexTime = 0;
    int Counter = 10;
    public int Timer;

    public float HorizontalSpacing = 2f;
    public float VerticalSpacing = 1f;

	void Update () 
	{
        if(Counter > 0 && Time.fixedTime > NexTime)
        {
            NexTime = Time.fixedTime + Timer;

            for (int j = 10; j > 0; j--)
            {

                int randomNumber = Random.Range(1, 10);
                for (int i = 0; i < randomNumber; i++)
                {
                    GameObject box =
                        GameObject.CreatePrimitive(PrimitiveType.Cube);
                    box.transform.position = new Vector3(Counter * HorizontalSpacing,
                        i * VerticalSpacing, j * HorizontalSpacing);
                }
            }
            Counter--;
        }
        
	}
}
