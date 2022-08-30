using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GolfBall_New : MonoBehaviour
{
    //Hole independent vars
    private int holeCount;
    private int totalScore;
    private int totalPars;
    private GameObject[] holes;
    public GameObject flag;
    public GameObject rCont;
    public GameObject lCont;
    public Text finalScoreBoardTotals;
    //Hole specific vars
    private Vector3 ballPos;
    private Vector3 holePos;
    private float holeRadius;
    private int holePar;
    private int holeScore;
    //Do this another way
    private bool inHole;
    public Vector3 lastFrameVelocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //This runs twice for some reason (holeScore++ at least)
        if (other.tag == "GolfClubHead")
        {
            //Increment hole score
            holeScore++;
            //Transfer velocity
            GetComponent<Rigidbody>().velocity = other.GetComponent<GolfClubHeadNew>().getVelocity() * 1.25F;
            //Despawn flag
            flag.SetActive(false);
            //Vibrate controller
            //if (rCont != null) rCont.GetComponent<Hand>().Vibrate();
            //if (lCont != null) lCont.GetComponent<Hand>().Vibrate();
            
            //GameObject.Find("Controller (right)").GetComponent<Hand>().Vibrate();
            //GameObject.Find("Controller (left)").GetComponent<Hand>().Vibrate();
        }
    }


    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Border")
        {
            GetComponent<Rigidbody>().velocity = Vector3.Reflect(GetComponent<Rigidbody>().velocity, col.contacts[0].normal) * 0.75F;
        }
    }

        
    
}
