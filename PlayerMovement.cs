using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f; //Player Speed
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();        //Attach controller to GameObject
    }

    void Update()
    {
        float moveVertical = 0f;

        if (Input.GetKey(KeyCode.W)) //Check for W
        {
            moveVertical = 1f;
        }
        else if (Input.GetKey(KeyCode.S)) //Check for S
        {
            moveVertical = -1f;
        }

        Vector3 move = transform.forward * moveVertical * speed * Time.deltaTime; //Calculate the movement direction and apply speed

        controller.Move(move); //Apply movement accrued
    }
}