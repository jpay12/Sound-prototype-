using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     public float speed = 5f;

  public float moveSpeed; 

  float horizontalInput;

  float verticalInput;  
    
  Vector3 moveDirection;

  public Transform orientation;

  Rigidbody rb; 

   private void Start()
    {
      rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MyInput(); 
    }
     
    private void  FixedUpdate()
    {
        MovePlayer(); 
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal"); 
        verticalInput = Input.GetAxisRaw("Vertical"); 
    }

    private void MovePlayer()
    {
        // calculate movement direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force); 
    }
}
