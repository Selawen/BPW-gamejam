using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayer : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public int activePlayer;

    // Start is called before the first frame update
    void Start()
    {
        activePlayer = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("end"))
        {
            if (activePlayer == 1)
            {
                p1.GetComponent<Movement>().enabled = false;
                p2.GetComponent<Movement>().enabled = true;
                activePlayer = 2;
            }
            else if (activePlayer == 2)
            {
                p2.GetComponent<Movement>().enabled = false;
                p3.GetComponent<Movement>().enabled = true;
                activePlayer = 3;
            }
            else if (activePlayer == 3)
            {
                p3.GetComponent<Movement>().enabled = false;
                p1.GetComponent<Movement>().enabled = true;
                activePlayer = 1;

            }
        }
    }
}
