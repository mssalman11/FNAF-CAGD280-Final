using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class DoorAndLights : MonoBehaviour
{
    public bool openTheDoor = false;
    public bool closeTheDoor;
    public bool doorOpen;
    protected bool lightsOn;

    public GameObject Door;
    public Vector3 doorPos;
    private float doorMax;
    private float doorMin;

    private void Awake()
    {
        doorPos = GetComponent<Transform>().position;
        doorMax = doorPos.y + 4.0f;
        //doorMin = doorPos.y;
    }


    void openDoor()
    {
        Door.transform.Translate(Vector3.up * (Time.deltaTime * 10));
        doorOpen = true;
    }

    void closeDoor()
    {
        Door.transform.Translate(Vector3.down * (Time.deltaTime * 10));
        doorOpen = false;

    }

    private void Update()
    {
        if (openTheDoor)
        {
            openDoor();
            if (Door.GetComponent<Transform>().position.y >= doorMax)
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
