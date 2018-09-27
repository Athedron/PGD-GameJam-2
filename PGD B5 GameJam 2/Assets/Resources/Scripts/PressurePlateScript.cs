using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateScript : MonoBehaviour {

    public bool activationNeeded; // activation needed is set in the inspector
    public bool activated = false;
    float timer = 0, timerStartTime = 360; // ms

    Material activatedMat, DisabledMat;


    void Start () {
        activatedMat = Resources.Load("Materials/ActivatedPlate", typeof(Material)) as Material;
        DisabledMat = Resources.Load("Materials/DisabledPlate", typeof(Material)) as Material;
    }
	
	void Update () {

        if (activated)
        {
            GetComponent<Renderer>().material = activatedMat;
            timer--;
            if (timer < 0)
                activated = false;
        }
        else
        {
            GetComponent<Renderer>().material = DisabledMat;
        }

	}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.name == "Moving_enemy")
        {
            timer = timerStartTime;
            activated = true;
        }
    }
}
