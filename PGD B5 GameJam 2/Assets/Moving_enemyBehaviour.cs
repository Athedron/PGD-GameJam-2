using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_enemyBehaviour : MonoBehaviour {

	private Transform target;
	public float maxDist = 10f;
	public float minDist = 1f;
	public float moveSpeed = 3f;


	void Start()
	{
		target = GameObject.Find("Player").transform;
	}

	void FixedUpdate()
	{
		if (Vector2.Distance(transform.position, target.position) >= minDist)
		{

			transform.position += transform.forward * moveSpeed * Time.deltaTime;
		}
	}
	
	void Update()
	{
		transform.LookAt(target);
	}
}

