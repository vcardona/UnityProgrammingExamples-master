using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanState : Zombie  
{

	override public void LookAround()
	{
		GameObject[] Zombies = (GameObject[])GameObject.FindObjectsOfType (typeof(GameObject));

		foreach(GameObject go in Zombies)
		{
			Zombie z = go.GetComponent<Zombie> ();
			if(z == null || z == this)
			{
				continue;
			}

			Vector3 v = go.transform.position - transform.position;
			float distanceToGo = v.magnitude;
			if(distanceToGo < closesDistance)
			{
				if(z is Zombie)
				{
					closesDistance = distanceToGo;
					closestGameObject = go;
				}
			}

			if(distanceToGo > furtherDistance)
			{
				if(z is HumanState)
				{
					furtherDistance = distanceToGo;
					furtherGameObject = go;
				}
			}
		}
	}
}
