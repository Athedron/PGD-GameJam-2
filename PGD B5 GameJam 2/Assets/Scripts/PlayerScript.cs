using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 10;
	public float jumpSpeed = 0.5f;
    public GameObject bulletPrefab, bulletSpawn;
	Rigidbody rb;

    bool isJumping;

    Vector3 jumpPos;
    
    void Start() {
        rb = GetComponent<Rigidbody>();
        jumpPos = transform.position;

    }

	void Update()
    {
        Move();
        if (Input.GetMouseButtonDown(0))  Shoot();
		
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            isJumping = true;
            rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
        }
        transform.Translate(x, 0, z);
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, bulletSpawn.transform.position, this.transform.rotation);
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "Ground")
        {
            isJumping = false;
        }
    }
}
