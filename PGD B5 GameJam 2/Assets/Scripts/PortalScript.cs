using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour {
    
	void Start () {
		
	}
	
	void Update () {
		
	}

    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.name == "Player")
        {
        	SceneManager.LoadScene(1);
            DontDestroyOnLoad(coll.gameObject);
        }
    }
}
