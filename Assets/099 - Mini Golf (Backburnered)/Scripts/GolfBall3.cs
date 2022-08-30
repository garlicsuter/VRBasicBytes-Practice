using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfBall3 : MonoBehaviour
{
    public Rigidbody rb;
    public float forceAmount;
    public Vector3 v3Velocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "GolfClubHead")
        {
            //GetComponent<Rigidbody>().velocity = Vector3.Reflect(GetComponent<Rigidbody>().velocity, col.contacts[0].normal) * 0.75F;

            //Get velocity of club, stored as "forceamount" float
            v3Velocity = col.gameObject.GetComponent<Rigidbody>().velocity;
            forceAmount = v3Velocity.magnitude;
            //forceAmount = col.gameObject.getVelocity() * 1.25F;
            rb.AddForce(Vector3.forward * forceAmount, ForceMode.Force);
        }
    }
}
