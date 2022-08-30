using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club2 : MonoBehaviour
{
    public float ForceAmount = 5.0f;
    private float velocityMagnitude;

    private Vector3 posI;
    private Vector3 posF;
    private Vector3 vel;
    private float velMag;
    public float maxVel;

    public void Update()
    {
        //var fwd = transform.TransformDirection(Vector3.forward);
    }

    public void FixedUpdate()
    {
        velocityMagnitude = transform.GetComponent<Rigidbody>().velocity.magnitude;

        //Update initial and final positions
        posI = posF;
        posF = transform.position;
    }

    public Vector3 getVelocity()
    {
        //Calculate velocity
        vel = (posF - posI) / Time.deltaTime;
        velMag = vel.magnitude;
        //Limit velocity
        if (velMag > maxVel)
        {
            vel = vel * (maxVel / velMag);
        }
        return vel;
    }

    //public void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.tag == "Ball")
    //    {
    //        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
    //        rb.AddForce(Vector3.forward, ForceMode.Force);

    //    }
    //}
}
