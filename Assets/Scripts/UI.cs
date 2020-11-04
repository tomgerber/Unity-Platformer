using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    GameObject player;
    public Text scoreText;
    public Text promptText;
    public Button restartButton;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        promptText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Player playerScript = player.GetComponent<Player>();
            int numberOfCoins = playerScript.returnCoins();
            scoreText.text = "Coins : " + numberOfCoins;
        } else
        {
            promptText.text = "You died! Restart?";
            promptText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
