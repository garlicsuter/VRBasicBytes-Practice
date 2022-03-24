using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WristMenu : MonoBehaviour
{
    public GameObject wristUI;
    public bool activeWristUI = true;

    public GameObject golfBall;

    // Start is called before the first frame update
    void Start()
    {
        DisplayWristUI();
    }

    public void SpawnBall()
    {
        Instantiate(golfBall, transform.position, transform.rotation);
    }

    public void DisplayWristUI()
    {
        if (activeWristUI)
        {
            wristUI.SetActive(false);
            activeWristUI = false;
        }
        else if (!activeWristUI)
        {
            wristUI.SetActive(true);
            activeWristUI = true;
        }
    }
}
