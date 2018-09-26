using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public float bulletSpeed = 0.5f;
	void Start () {
		
	}
	
	void Update () {
        transform.Translate(0,0, bulletSpeed * Time.deltaTime);
	}

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "levelObject") Destroy(this.gameObject);
    }
}
