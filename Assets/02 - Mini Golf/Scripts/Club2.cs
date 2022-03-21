using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club2 : MonoBehaviour
{
    public float ForceAmount = 5.0f;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            rb.AddForce(0, 0, ForceAmount, ForceMode.Force);

        }
    }
}
