using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{

    public GameObject player;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bounds")) {

            //teleports player when they make contact with bounds
            player.transform.position = new Vector2(0f, 0f);

            //reset the player's velocity
            Rigidbody2D playerRb = player.GetComponent<Rigidbody2D>();
            playerRb.velocity = Vector2.zero;

        }
    }
}
