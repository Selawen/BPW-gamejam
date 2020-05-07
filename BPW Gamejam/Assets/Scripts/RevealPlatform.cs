using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealPlatform : MonoBehaviour
{
    GameObject platform;

    private void Start()
    {
        platform = GameObject.Find("revealingPlatform");
    }

    private void OnTriggerEnter(Collider other)
    {
        platform.transform.position = platform.transform.position + new Vector3(0, 2.0f, 0);
    }

    private void OnTriggerExit(Collider other)
    {
        platform.transform.position = platform.transform.position + new Vector3(0, -2.0f, 0);
    }
}
