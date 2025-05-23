using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 moveDirection;
    private float moveSpeed = 2.5f;


    void Awake()
    {
        characterController = GetComponent<CharacterController>();  
    }

    void Update()
    {
        moveDirection = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection.z = 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection.x = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection.z = -1;
        }

        characterController.Move(moveDirection * Time.deltaTime * moveSpeed);

    }
}
