using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float exForce = 10f;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Explode
    // Main movement mechanic in the game, player inputs 
    // a direction for explosion to launch them
    // 
    // 
    public void Explode() {
    
    
    
    }

}
