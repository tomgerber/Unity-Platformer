using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 updatedPosition = new Vector3(player.transform.position.x, player.transform.position.y, gameObject.transform.position.z);
            gameObject.transform.position = updatedPosition;
        }
    }
}
