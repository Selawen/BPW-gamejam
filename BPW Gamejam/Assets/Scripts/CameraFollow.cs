using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    private GameObject activatonObj;
    private SwitchPlayer activationScript;

    private int followedPlayer;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player1");
        followedPlayer = 1;

        activatonObj = GameObject.Find("SwitchPlayer");
        activationScript = activatonObj.GetComponent<SwitchPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        int activePlayer = activationScript.activePlayer;
        if (followedPlayer == activePlayer)
        {
            if (Vector3.Distance(new Vector3(player.transform.position.x, 0, player.transform.position.z), new Vector3(transform.position.x, 0, transform.position.z - 15)) > 1)
            {
                transform.position += (new Vector3(player.transform.position.x, 0, player.transform.position.z) - new Vector3(transform.position.x, 0, transform.position.z + 15)) * Time.deltaTime;
            }
        }
        else
        {
            player = GameObject.Find("player" + activePlayer);
            followedPlayer = activePlayer;
        }
    }
}
