using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 150f;
	public float jumpSpeed = 0.5f;
    public GameObject bulletPrefab, bulletSpawn;
	Rigidbody player;

	void Start() {
		player = GetComponent<Rigidbody>();
	}

	void Update()
    {
        Move();
        if (Input.GetMouseButtonDown(0))  Shoot();
		
    }

    void Move()
    {
		var y = Input.GetAxis("Vertical");
		if (Input.GetKey(KeyCode.Space)) {
			y *= Time.deltaTime * jumpSpeed;
		}
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
		
		
        transform.Translate(x, 0, z);
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, bulletSpawn.transform.position, this.transform.rotation);
    }

	void Jump() {

	}

}
