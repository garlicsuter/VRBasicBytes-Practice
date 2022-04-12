using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger : MonoBehaviour
{
    public void Hovered()
    {
        Debug.Log("Hovered!");
    }

    public void Action()
    {
        Debug.Log("Action!");
    }

    public void Exited()
    {
        Debug.Log("Exited!");
    }

    public void HandExited()
    {
        Debug.Log("Hand Exited!");
    }

    public void HandHovered()
    {
        Debug.Log("Hand Hovered!");
    }

    public void HandAction()
    {
        Debug.Log("HandAction!");
    }
}
