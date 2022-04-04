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
}
