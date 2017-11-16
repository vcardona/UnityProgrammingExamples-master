using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour 
{
	float stateTimer;
	public float closesDistance;
	public float furtherDistance;
	public GameObject closestGameObject;
	public GameObject furtherGameObject;

	enum ZState
	{
		idleing,
		wandering
	}

	ZState MyState;

	void Start () 
	{
		stateTimer = 0.1f;
		MyState = ZState.idleing;
		closesDistance = Mathf.Infinity;
	}
	
	void Update () 
	{
		switch (MyState) 
		{
		case ZState.idleing:
			goto Ideling;
		case ZState.wandering:
			goto Wandering;
		default:
			break;
		}

		Ideling:
			stateTimer -= Time.deltaTime;
			if(stateTimer < 0.0f)
			{
				MyState = ZState.wandering;
				stateTimer = 3.0f;
				closesDistance = Mathf.Infinity;
				furtherDistance = 0f;
				LookAround ();
			}
			return;
		Wandering:
			stateTimer -= Time.deltaTime;
			MoveAround ();
			if(stateTimer < 0.0f)
			{
				MyState = ZState.idleing;
				stateTimer = 3.0f;
			}
			return;
	}

	virtual public void LookAround()
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
				closesDistance = distanceToGo;
				closestGameObject = go;
			}

			if(distanceToGo > furtherDistance)
			{
				furtherDistance = distanceToGo;
				furtherGameObject = go;
			}
		}
	}

	void MoveAround()
	{
		Vector3 MoveAway = (transform.position - closestGameObject.transform.position).normalized;
		Vector3 MoveTo = (transform.position - furtherGameObject.transform.position).normalized;
		Vector3 directionToMove = MoveAway - MoveTo;
		transform.forward = directionToMove;
		gameObject.GetComponent<Rigidbody> ().velocity = directionToMove * Random.Range (10, 30) * 0.1f;
		Debug.DrawRay (transform.position, directionToMove, Color.red);
		Debug.DrawLine (transform.position, closestGameObject.transform.position, Color.red);
		Debug.DrawLine (transform.position, furtherGameObject.transform.position, Color.green);

	}
}
