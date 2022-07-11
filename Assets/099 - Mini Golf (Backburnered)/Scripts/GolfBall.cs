using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfBall : MonoBehaviour
{
    public Vector3 direction;
    public GameObject ClubController;
    public Vector3 lastFrameVelocity;
    public float speed = 80.0f;


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

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "GolfClubHead")
        {
            //public ContactPoint GetContact(0);

            lastFrameVelocity = this.GetComponent<Rigidbody>().velocity;
            direction = Vector3.Reflect(lastFrameVelocity.normalized, col.contacts[0].normal);
            this.GetComponent<Rigidbody>().velocity = direction * speed;

            float addForce = ClubController.GetComponent<ClubController_BostonLeek>().clubVelocity.magnitude;
            speed += addForce;

        }
    }
}
