using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

     [SerializeField] float moveSpeed;
     [SerializeField] float jumpForce;
     [SerializeField] float gravityForce;

    private CharacterController controller;

    void Start() {
        controller = GetComponent<CharacterController>();
    }

    void Update() {

        float xMov = Input.GetAxis("Horizontal");
        float yMov = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3(xMov, 0, yMov);
        controller.Move(move * moveSpeed * Time.deltaTime);
        
    }
}
