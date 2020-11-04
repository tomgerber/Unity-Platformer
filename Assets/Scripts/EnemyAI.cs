using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float minDistance;
    public float moveSpeed;
    Rigidbody2D rb;
    GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // checks if our player is within specified distance of our enemy
        if (player != null) {
            if (Vector2.Distance(player.transform.position, gameObject.transform.position) < minDistance)
            {
                rb.velocity = new Vector2(moveSpeed * -1, 0);
            }
        }
    }
}
