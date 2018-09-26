using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy_Behaviour : MonoBehaviour {


	private Transform target;
	public float maxDist = 10f;
	public float minDist = 0.5f;
	public float moveSpeed = 3f;
	// Use this for initialization
	void Start () {

		target = GameObject.Find("Player").transform;
		
	}

	void FixedUpdate()
	{
		

		if (Vector3.Distance(transform.position, target.position) >= minDist)
		{

			transform.position += transform.forward * moveSpeed * Time.deltaTime;
		}

	}
	// Update is called once per frame
	void Update () {

		transform.LookAt(target);
	}
}
