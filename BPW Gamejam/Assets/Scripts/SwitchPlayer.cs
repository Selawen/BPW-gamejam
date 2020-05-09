using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayer : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public int activePlayer;

    public bool p1Dead;
    public bool p2Dead;
    public bool p3Dead;

    private GameObject Hazard;
    private Die deathScript;

    // Start is called before the first frame update
    void Start()
    {
        activePlayer = 1;
        p1Dead = false;
        p2Dead = false;
        p3Dead = false;

        Hazard = GameObject.Find("Spikes");
        deathScript = Hazard.GetComponent<Die>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("e"))
        {
            SwitchKitten();
        }
    }

    public void SwitchKitten()
    {
        if ((p1Dead ? 1 : 0) + (p2Dead ? 1 : 0) + (p3Dead ? 1 : 0) == 3)
        {
            p1.GetComponent<Movement>().enabled = false;
            p2.GetComponent<Movement>().enabled = false;
            p3.GetComponent<Movement>().enabled = false;
        }
        else
        {
            if (activePlayer == 1 && p2Dead)
            {
                p1.GetComponent<Movement>().enabled = false;
                p3.GetComponent<Movement>().enabled = true;
                activePlayer = 3;
            }
            else
            {
                if (activePlayer == 2 && p3Dead)
                {
                    p2.GetComponent<Movement>().enabled = false;
                    p1.GetComponent<Movement>().enabled = true;
                    activePlayer = 1;
                }
                else
                {

                    if (activePlayer == 3 && p1Dead)
                    {
                        p3.GetComponent<Movement>().enabled = false;
                        p2.GetComponent<Movement>().enabled = true;
                        activePlayer = 2;
                    }
                    else

                    {
                        switch (activePlayer)
                        {
                            case 1:
                                p1.GetComponent<Movement>().enabled = false;
                                p2.GetComponent<Movement>().enabled = true;
                                activePlayer = 2;
                                break;
                            case 2:
                                p2.GetComponent<Movement>().enabled = false;
                                p3.GetComponent<Movement>().enabled = true;
                                activePlayer = 3;
                                break;
                            case 3:
                                p3.GetComponent<Movement>().enabled = false;
                                p1.GetComponent<Movement>().enabled = true;
                                activePlayer = 1;
                                break;
                        }
                    }
                }
            }
        }
    }
}
