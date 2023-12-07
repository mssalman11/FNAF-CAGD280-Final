using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PullUp : MonoBehaviour
{
    public GameObject camList;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;
    public GameObject cam6;
    public GameObject cam7;
    public GameObject cam8;
    public GameObject cam9;
    public GameObject cam10;
    public GameObject cam11;
    public GameObject pullup;
    public GameObject pulldown;

    
    
    private void Awake()
    {
        pullup.SetActive(true);
        pulldown.SetActive(false);
        
    }


    public void turnOn()
    {
        camList.SetActive(true);
        cam1.SetActive(true);
        cam2.SetActive(true);
        cam3.SetActive(true);
        cam4.SetActive(true);
        cam5.SetActive(true);
        cam6.SetActive(true);
        cam7.SetActive(true);
        cam8.SetActive(true);
        cam9.SetActive(true);
        cam10.SetActive(true);
        cam11.SetActive(true);
        pullup.SetActive(false);
        pulldown.SetActive(true);
        //CameraSwitch.CSInstance.SwitchCamera(ONEA);
    }

    public void turnOff()
    {
        camList.SetActive(false);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
        cam5.SetActive(false);
        cam6.SetActive(false);
        cam7.SetActive(false);
        cam8.SetActive(false);
        cam9.SetActive(false);
        cam10.SetActive(false);
        cam11.SetActive(false);
        pullup.SetActive(true);
        pulldown.SetActive(false);
        

    }
}
