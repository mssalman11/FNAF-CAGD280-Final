using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    public float xSens = 10f;
    public static PlayerLook Instance;
    private PlayerMovement playerInput;

    
    public void looking(Vector2 mouseInput)
    {
        float mouseX = mouseInput.x;

        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime));
    }

    private void Awake()
    {
        playerInput = new PlayerMovement();

        playerInput.Enable();
    }

    private void Update()
    {


        looking(playerInput.Movement.Looking.ReadValue<Vector2>() * xSens);
        
    }

}
