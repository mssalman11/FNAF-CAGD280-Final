using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButt : MonoBehaviour
{
    public GameObject Light;

    private void OnMouseEnter()
    {
        //Debug.Log("AHHHHHH");

    }

    private void OnMouseDown()
    {
        if (Light.GetComponent<DoorAndLights>().lightsOn == false)
        {
            Light.GetComponent<DoorAndLights>().turnOn = true;

        }
        else
        {
            Light.GetComponent<DoorAndLights>().turnOn = false;


        }
    }
}
