using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject menuText;

    private GameObject activatonObj;
    private SwitchPlayer activationScript;

    private void Start()
    {
        activatonObj = GameObject.Find("SwitchPlayer");
        activationScript = activatonObj.GetComponent<SwitchPlayer>();
        gameOverScreen = GameObject.Find("GameMenu");
        menuText = GameObject.Find("GameMenuText");
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            int activePlayer = activationScript.activePlayer;

            switch (activePlayer)
            {
                case 1:
                    activationScript.p1Dead = true;
                    break;
                case 2:
                    activationScript.p2Dead = true;
                    break;
                case 3:
                    activationScript.p3Dead = true;
                    break;
            }

            if ((activationScript.p1Dead ? 1 : 0) + (activationScript.p2Dead ? 1 : 0) + (activationScript.p3Dead ? 1 : 0) == 3)
            { 
                GameOver();
            }
            activationScript.SwitchKitten();
        }
    }

    public void GameOver()
    {
        gameOverScreen.GetComponent<Canvas>().enabled = true;
        menuText.GetComponent<TextMeshProUGUI>().color = new Color(0.8f, 0.15f, 0.15f, 1.0f);
        menuText.GetComponent<TextMeshProUGUI>().text = "Game Over";
    }
}
