using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClubController_BostonLeek : MonoBehaviour
{
    public GameObject leftHand;
    public GameObject clubGray;
    public Rigidbody rb;
    public Vector3 clubVelocity;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = clubGray.GetComponent<Rigidbody>();

    
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().position = leftHand.transform.position;
        GetComponent<Rigidbody>().rotation = leftHand.transform.rotation;
        clubVelocity = clubGray.GetComponent<Rigidbody>().velocity;
    }
}
