using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementForce = 10f;
    public float jumpForce = 1000f;

    // Update is called once per frame
    void FixedUpdate()
    {

        // Condition: When a player presses the D key...
        if (Input.GetKey(KeyCode.D) == true)
        {
            // Action: Apply a force (move the player)
            // Get the Rigidbody component off our player so we can use it
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

            // Add a force to the Rigidbody to move our player
            ourRigidbody.AddForce(Vector2.right * movementForce);

        }

        // Condition: When a player presses the A key...
        if (Input.GetKey(KeyCode.A) == true)
        {
            // Action: Apply a force (move the player)
            // Get the Rigidbody component off our player so we can use it
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

            // Add a force to the Rigidbody to move our player
            ourRigidbody.AddForce(Vector2.left * movementForce);
        }

        //Condition: When the player first presses space bar
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            //Action: Apply a force (push the player up)
            // Get the Rigidbody component off our player so we can use it
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

            // Add a force to the Rigidbody to move our player
            ourRigidbody.AddForce(Vector2.up * jumpForce);

        }
    }

}
