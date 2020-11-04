using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompleteLevel : MonoBehaviour
{
    public Text promptText;
    public Button restartButton;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        promptText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            promptText.text = "Level Complete! Restart?";

            promptText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            player.gameObject.SetActive(false);

        }
    }
}
