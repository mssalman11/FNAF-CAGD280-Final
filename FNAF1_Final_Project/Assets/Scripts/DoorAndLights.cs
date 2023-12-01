using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
    private float doorMax;

    private void Awake()
    {
        doorPos = GetComponent<Transform>().position;
        doorMax = doorPos.y + 4.0f;
    }


    void openDoor()
    {
        Door.transform.Translate(Vector3.up * (Time.deltaTime * 10));
    }

    void closeDoor()
    {
        Door.transform.Translate(Vector3.down * (Time.deltaTime * 10));

    }

    private void Update()
    {
        if (openTheDoor)
        {
            openDoor();
            if (Door.GetComponent<Transform>().position.y >= doorMax )
            {
                openTheDoor = false;
            }
            
        }

        if (closeTheDoor)
        {
            closeDoor();
            if (Door.GetComponent<Transform>().position.y <= doorPos.y)
            {
                closeTheDoor = false;
            }
            
        }


    }
}
