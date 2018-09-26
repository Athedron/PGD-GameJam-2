using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
	private Transform target;
	// Use this for initialization
	void Start()
	{
		target = GameObject.Find("Player").transform;
	}

	void FixedUpdate()
	{
		Vector3 toTarget = (target.transform.position - transform.position).normalized;
		transform.Translate(toTarget * 2f * Time.deltaTime);
	}

	// Update is called once per frame
	void Update()
	{
		//transform.LookAt(target);
	}
	void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.name == "Player")
		{
			Destroy(this.gameObject);
			Debug.Log("destroyed");
		}
	}
}

