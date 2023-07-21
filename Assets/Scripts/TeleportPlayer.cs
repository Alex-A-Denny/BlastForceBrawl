using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{

    public GameObject player;
    //public BoxCollider2D boundsUp;
    public BoxCollider2D boundsDown;
    /*public BoxCollider2D boundsLeft;
    public BoxCollider2D boundsRight;*/

    // Update is called once per frame
    void FixedUpdate()
    {
        //OnTriggerEnter2D(boundsUp);
        OnTriggerEnter2D(boundsDown);
        /*OnTriggerEnter2D(boundsLeft);
        OnTriggerEnter2D(boundsRight);*/

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bounds")) {
            Debug.Log("Teleport");
            player.transform.position = new Vector2(0f, 0f);    
        
        }
    }
}
