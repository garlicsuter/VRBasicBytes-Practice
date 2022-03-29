using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfBall : MonoBehaviour
{
   


    private void OnTriggerEnter(Collider other)
    {
        //This runs twice for some reason (holeScore++ at least)
        if (other.tag == "GolfClubHead")
        {
            //Increment hole score
            //holeScore++;
            //Transfer velocity

            //GetComponent<Rigidbody>().velocity = other.transform.GetComponent<Rigidbody>().velocity;

            GetComponent<Rigidbody>().velocity = other.GetComponent<Club2>().getVelocity() * 1.25F;
            Debug.Log("Hit by club");
            //Despawn flag
            //flag.SetActive(false);
            //Vibrate controller
            //if (rCont != null) rCont.GetComponent<Hand>().Vibrate();
            //if (lCont != null) lCont.GetComponent<Hand>().Vibrate();
            //GameObject.Find("Controller (right)").GetComponent<Hand>().Vibrate();
            //GameObject.Find("Controller (left)").GetComponent<Hand>().Vibrate();
        }
    }
}
