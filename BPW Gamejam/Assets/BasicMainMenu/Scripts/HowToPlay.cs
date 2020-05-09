using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlay : MonoBehaviour
{
    public GameObject HowToPlayPanel;

    public void ActivatePanel()
    {
        HowToPlayPanel.SetActive(true);
    }

    public void ClosePanel()
    {
        HowToPlayPanel.SetActive(false);
    }

}
