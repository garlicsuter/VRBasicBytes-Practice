using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer_OnBoard : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("OnBoard Started");
    }
    //private void OnCollisionEnter(Collision col)
    //{
    //    if (col.gameObject.CompareTag("Blue"))
    //    {
    //        Debug.Log("Blue Hit Board");
    //    }

    //    else if (col.gameObject.CompareTag("Orange"))
    //    {
    //        Debug.Log("Orange Hit Board");
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Entered Trigger");

        if (other.gameObject.CompareTag("Blue"))
        {
            Debug.Log("Blue Hit Board");
        }

        else if (other.gameObject.CompareTag("Orange"))
        {
            Debug.Log("Orange Hit Board");
        }
    }
}
