using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class Finish : MonoBehaviour
{
    public string reset;

    public GameObject gameOverScreen;
    public GameObject menuText;

    public void Start()
    {
        gameOverScreen = GameObject.Find("GameMenu");
        menuText = GameObject.Find("GameMenuText");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameOverScreen.GetComponent<Canvas>().enabled = true;
            menuText.GetComponent<TextMeshProUGUI>().text = "You made it!";
            menuText.GetComponent<TextMeshProUGUI>().color = new Color(1.0f,0.58f,0.37f,1.0f);
        }
    }
}
