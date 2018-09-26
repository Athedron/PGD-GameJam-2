using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

	public GameObject bullet;
	private Transform target;

	// Use this for initialization
	void Start()
	{
		InvokeRepeating("Shoot", 1f, 1f);
		target = GameObject.Find("Player").transform;
	
		
	}
	// Update is called once per frame
	void Update () {

	transform.LookAt(target);
	}

	void Shoot()
	{
		GameObject bulletPrefab = Instantiate(bullet, transform.position, bullet.transform.rotation);
		Destroy(bulletPrefab, 5f);
		
	}
}
