using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Unity.VisualScripting;

public class CameraSwitch : MonoBehaviour {

    //Holder for all cams
    public CinemachineVirtualCamera ONEA;
    public CinemachineVirtualCamera ONEB;
    public CinemachineVirtualCamera ONEC;
    public CinemachineVirtualCamera TWOA;
    public CinemachineVirtualCamera TWOB;
    public CinemachineVirtualCamera THREE;
    public CinemachineVirtualCamera FOURA;
    public CinemachineVirtualCamera FOURB;
    public CinemachineVirtualCamera FIVE;
    public CinemachineVirtualCamera SEVEN;
    public CinemachineVirtualCamera SIX;
    public CinemachineVirtualCamera OFFICE;

    [SerializeField]
    List<CinemachineVirtualCamera> cameras;

    public static CinemachineVirtualCamera activeCam = null;

    private void Awake()
    {
        cameras = new List<CinemachineVirtualCamera>();
        cameras.Add(ONEA);
        cameras.Add(ONEB);
        cameras.Add(ONEC);
        cameras.Add(TWOA);
        cameras.Add(TWOB);
        cameras.Add(THREE);
        cameras.Add(FOURA);
        cameras.Add(FOURB);
        cameras.Add(FIVE);
        cameras.Add(SEVEN);
        cameras.Add(SIX);

    }

    
    public void SwitchCamera(CinemachineVirtualCamera camera)
    {
        camera.Priority = 20;
        activeCam = camera;

        foreach (CinemachineVirtualCamera cam in cameras) {
            if (cam != activeCam)
            {
                cam.Priority = 10;
            }
        }                            

    }

    public void goBack()
    {
        OFFICE.Priority = 20;
        ONEA.Priority = 19;
        ONEB.Priority = 18;
        ONEC.Priority = 17;
        TWOA.Priority = 16;
        TWOB.Priority = 15;
        THREE.Priority = 14;
        FOURA.Priority = 13;
        FOURB.Priority = 12;
        FIVE.Priority = 11;
        SIX.Priority = 9;
        SEVEN.Priority = 10;
        
    }

    public void defaultForCams()
    {
        OFFICE.Priority = 19;
        ONEA.Priority = 20;
    }
}

