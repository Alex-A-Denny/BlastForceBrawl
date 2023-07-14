using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float exForce = 10f;
    public float moveSpeed = 10f;

    Vector2 moveDir;
    float horizontalInput;
    float verticalInput;
    Transform orientation;
    
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        orientation = transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movePlayer();
    }

    private void movePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Debug.Log(horizontalInput + "  " + verticalInput);

        //caculate movement
        moveDir = (orientation.forward * verticalInput + orientation.right * horizontalInput) * Time.deltaTime;

        rb.AddForce(moveDir * moveSpeed, ForceMode2D.Force);

        if (Input.GetKeyDown(KeyCode.Space)) {

            Explode(moveDir);
        
        }
    }

    // Explode
    // Main movement mechanic in the game, player inputs 
    // a direction for explosion to launch them
    // 
    // Vector2 dir : direction of explosion force
    public void Explode(Vector2 direction)
    {
        rb.AddForce(direction * exForce * moveSpeed, ForceMode2D.Impulse);
    }

}
