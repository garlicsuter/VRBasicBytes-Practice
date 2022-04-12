using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandNew : MonoBehaviour
{
    //Steam VR
    //private SteamVR_TrackedObject trackedObject;
    //private SteamVR_Controller.Device device;

    //Converted from SteamVR to Oculus
    private GameObject trackedObject;
    private GameObject device;

    //Game objects
    public GameObject golfClub;
    public GameObject golfClubHead;
    public GameObject golfClubShaft;
    public GameObject golfBall;
    public GameObject playerArea;
    public GameObject playerHead;
    public GameObject indicator;
    //Components
    public LineRenderer laser;
    //Variables
    private bool shift;
    private Vector3 shiftStart;
    private Vector3 shiftEnd;
    private float shiftStartTime;
    public float shiftDuration;
    private bool ballFollowLaser;
    private string mode;

    void Start()
    {
        //TO DO: Parent the golf club to the controller for the initial mode switch
        golfClub.SetActive(false);
        //SteamVR_TrackedObject needs replaced with Oculus Equivalent
        //trackedObject = GetComponent<SteamVR_TrackedObject>();
        //trackedObject =
        //laser = gameObject.GetComponent<LineRenderer>();
        //laser.material.color = Color.red;
        //laser.enabled = false;
        //indicator.SetActive(false);
        //shift = false;
        //ballFollowLaser = false;
        //mode = "teleport";
    }


    //Spawns and scales club based on distance of controller from the ground
    private void SpawnGolfClub()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out hit))
        {
            //Get ground position
            Vector3 ground = new Vector3();
            ground = ray.GetPoint(hit.distance);
            //Get wrist position
            Vector3 hand = new Vector3();
            hand = transform.position;
            //Calculate golf club length
            float golfClubLength = Vector3.Distance(hand, ground);
            //Calculate golf club midpoint position
            Vector3 golfClubMidpoint = new Vector3();
            golfClubMidpoint = (hand + ground) / 2;
            //Activate and position golf club
            golfClub.SetActive(true);
            golfClub.transform.position = golfClubMidpoint;
            golfClub.transform.localScale = new Vector3(golfClub.transform.localScale.x, golfClub.transform.localScale.y, golfClubLength - 0.1F);
            golfClub.transform.rotation = transform.rotation;
            golfClub.transform.SetParent(transform);
        }
    }

    private void DestroyGolfClub()
    {
        golfClub.SetActive(false);
    }


    private void ChangeMode()
    {
        if (mode == "putt")
        {
            mode = "teleport";
            golfClub.SetActive(false);
            return;
        }
        if (mode == "teleport")
        {
            mode = "putt";
            laser.enabled = false;
            indicator.SetActive(false);
            ballFollowLaser = false;
            golfClub.SetActive(true);
        }
    }

    private void BallFollowLaser(bool val)
    {
        if (val == true)
        {
            ballFollowLaser = true;
            golfBall.GetComponent<SphereCollider>().enabled = false;
            golfBall.GetComponent<Rigidbody>().useGravity = false;
            Debug.Log("Collider off");
            //TO DO: Add layer mask to ignore ball
        }
        else
        {
            ballFollowLaser = false;
            golfBall.GetComponent<SphereCollider>().enabled = true;
            golfBall.GetComponent<Rigidbody>().useGravity = true;
            Debug.Log("Collider on");
            //TO DO: Remove layer mask to ignore ball
        }
    }
}
