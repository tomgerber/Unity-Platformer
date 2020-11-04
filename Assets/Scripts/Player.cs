using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int numberOfCoins;
    public float jumpForce;
    public float moveSpeed;
    Rigidbody2D rb;

    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        // we equate rb and tell the script that this rb is the rigidbody attached to the game object
        // this script sits on
        rb = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal"); //returns a value between -1 to 0 if the left button is hit
                                     //returns a value between 0 to 1 if the right button is hit
        rb.velocity = new Vector2(Horizontal * moveSpeed, rb.velocity.y);

        if (rb.velocity.y == 0)
        {
            isGrounded = true;
        } else
        {
            isGrounded = false;
        }
        isGrounded = true;
        if(isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector2 jump = new Vector2(0, jumpForce);
                rb.AddForce(jump);
            }
        }
        
    }
    
    // Called whenever player object collides with any other object
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            if (rb.velocity.y < 0)
            {
                // destroy the enemy
                Destroy(other.gameObject);
            } else
            {
                // destroy ourselves 
                Destroy(gameObject);
            }
        }
    }

    public void addCoins()
    {
        numberOfCoins = numberOfCoins + 1;
    }

    public int returnCoins()
    {
        return numberOfCoins;
    }
}
