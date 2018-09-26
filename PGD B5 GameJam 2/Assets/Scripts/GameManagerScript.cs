using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

    // Use this for initialization
    public GameObject playerPrefab;
	void Start () {
        if (GameObject.Find("Player") == null)
        {
            GameObject player = Instantiate(playerPrefab);
            player.name = "Player";
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
