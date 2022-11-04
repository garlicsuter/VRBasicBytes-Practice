using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer_InHole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started InHole Scoring");
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Entered Trigger");

        if (other.gameObject.CompareTag("Blue"))
        {
            Debug.Log("Blue In Hole!");
        }

        else if (other.gameObject.CompareTag("Orange"))
        {
            Debug.Log("Orange In Hole!");
        }
    }
}
