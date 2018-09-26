using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour {

    public string sceneName;
    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.name == "Player")
        {
        	SceneManager.LoadScene(sceneName);
            DontDestroyOnLoad(coll.gameObject);
        }
    }
}
