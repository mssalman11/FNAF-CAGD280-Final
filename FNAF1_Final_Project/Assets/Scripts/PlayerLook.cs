using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    public float xSens = 5f;
    public static PlayerLook Instance;
    private PlayerMovement playerInput;

    
    public void looking(Vector2 mouseInput)
    {
        float mouseX = mouseInput.x;
        

        //transform.Rotate(Vector3.up * (Mathf.Clamp(mouseX, -20, 20) * Time.deltaTime));
        transform.Rotate(Vector3.up * mouseX * Time.deltaTime);

    }

    private void Awake()
    {
        playerInput = new PlayerMovement();

        playerInput.Enable();
    }

    private void Update()
    {
        //Mathf.Clamp(playerInput.Movement.Looking.ReadValue<Vector2>().x, -5, 5);
        looking(playerInput.Movement.Looking.ReadValue<Vector2>() * xSens);
        
       
        

    }

}
