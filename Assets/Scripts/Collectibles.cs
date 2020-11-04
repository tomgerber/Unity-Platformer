using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    public float moveSpeed;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (gameObject.tag == "Coin")
            {
                // Whatever happens once the player collects the coin
                Player playerScript = collision.gameObject.GetComponent<Player>();
                playerScript.addCoins();
            }
            if(gameObject.tag == "Gun")
            {

            }
            Destroy(gameObject);
        }
    }
}
