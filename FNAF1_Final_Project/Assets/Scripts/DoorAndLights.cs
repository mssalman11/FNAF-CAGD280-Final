using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorAndLights : MonoBehaviour
{
    public bool openTheDoor;
    public bool closeTheDoor;
    protected bool lightsOn;

    public GameObject Door;
    //public GameObject rightDoor;

    //Vector3 of DoorPos
    public Vector3 doorPos;
    

    void openDoor()
    {
        transform.Translate(new Vector3(0.0f, 4.0f, 0.0f));
        //GetComponent<Transform>().position = new Vector3(doorPos.x, doorPos.y + 4, doorPos.z);
        //doorOpen = true;
    }

    void closeDoor()
    {
        transform.Translate(new Vector3(0.0f, -4.0f, 0.0f));
        //GetComponent<Transform>().position = new Vector3(doorPos.x, doorPos.y + 4, doorPos.z);
       // doorOpen=false;
    }

    private void FixedUpdate()
    {
        if (openTheDoor)
        {
            openDoor();
            openTheDoor = false;
        }

        if (closeTheDoor)
        {
            closeDoor();
            closeTheDoor = false;
        }


    }
}
