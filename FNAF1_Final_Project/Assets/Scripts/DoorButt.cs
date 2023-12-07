using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButt : MonoBehaviour
{
    public GameObject Doorr;

    private void OnMouseEnter()
    {
        Debug.Log("AHHHHHH");
        
    }

    private void OnMouseDown()
    {
        
        if (Doorr.GetComponent<DoorAndLights>().openTheDoor  == false && Doorr.GetComponent<DoorAndLights>().doorOpen != true)
        {
            Doorr.GetComponent<DoorAndLights>().openTheDoor = true;
            
        }
        else
        {
            Doorr.GetComponent<DoorAndLights>().closeTheDoor = true;
            

        }
    }
}
