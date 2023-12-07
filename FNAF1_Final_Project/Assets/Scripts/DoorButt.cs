using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButt : MonoBehaviour
{
    public GameObject Door;

    private void OnMouseEnter()
    {
        Debug.Log("AHHHHHH");
        
    }

    private void OnMouseDown()
    {
        
        if (Door.GetComponent<DoorAndLights>().openTheDoor  == false && Door.GetComponent<DoorAndLights>().doorOpen != true)
        {
            Door.GetComponent<DoorAndLights>().openTheDoor = true;
            
        }
        else
        {
            Door.GetComponent<DoorAndLights>().closeTheDoor = true;
            

        }
    }
}
