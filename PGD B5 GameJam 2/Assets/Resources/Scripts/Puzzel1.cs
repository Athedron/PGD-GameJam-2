using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzel1 : MonoBehaviour
{

    bool puzzelFinished = false;

    void Start()
    {

    }

    void Update()
    {
        for (int iComponent = 0; iComponent < transform.childCount; iComponent++)
        {
            Transform component = transform.GetChild(iComponent);

            //checks if plates that need to be activated are active
            if (component.name.Contains("Plate"))
            {
                puzzelFinished = true; //if one trap is not activated correctly it will deactivate
                for (int iPlate = 0; iPlate < component.childCount; iPlate++)
                {
                    Transform plate = component.GetChild(iPlate);
                    PressurePlateScript script = plate.GetComponent<PressurePlateScript>();
                    if (script.activationNeeded != script.activated)
                    {
                        puzzelFinished = false;
                    }
                }
            }
            else if (component.name.Contains("Door"))
            {
                if (puzzelFinished)
                {
                    for (int iDoor = 0; iDoor < component.childCount; iDoor++)
                    {
                        Transform door = component.GetChild(iDoor);
						door.GetComponent<Rigidbody>().isKinematic = false;
						door.GetComponent<Collider>().enabled = false;
						
					}
                }
            }

            if (puzzelFinished)
				
                Debug.Log("YAY!!!");
        }
    }
}
