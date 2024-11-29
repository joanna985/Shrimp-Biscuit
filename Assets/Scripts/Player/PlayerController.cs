using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
//using Unity.Burst.CompilerServices;
using UnityEngine;

public class PlayerController: MonoBehaviour {
    public GameObject player;
    public float speed = 40;
    private Rigidbody rb;
    public void Start() {
        rb = GetComponent<Rigidbody>();
    }
    public void Update() {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, -verticalInput,0);
        movement = transform.TransformDirection(movement);
        movement = movement * speed;
        rb.MovePosition(rb.position + movement * Time.deltaTime);
    }
}