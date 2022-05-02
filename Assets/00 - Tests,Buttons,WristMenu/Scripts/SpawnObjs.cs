using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjs : MonoBehaviour
{
    public GameObject golfBall;
    public GameObject spawner;
    public GameObject platform;
    private Vector3 spawnOffset = new Vector3(0,.15f,0);
    private Vector3 spawnLoc;
    public XRButton UpButton;
    public Vector3 platformLoc;
    public float platformSpeed = 0.1f;

    public void Start()
    {
        UpButton = this.GetComponent<XRButton>();
        Vector3 platformLoc = platform.transform.position;
    }

    public void Update()
    {
        //if (UpButton.isHovered)
        //{
        //    //platformLoc.y += 0.5f;
        //    platform.transform.Translate(Vector3.up * Time.deltaTime * platformSpeed, Space.World);
        //    Debug.Log("Going UP");
        //}
    }

    public void SpawnBall()
    {
        spawnLoc = spawner.transform.position;

        //Instantiate(golfBall, transform.position + spawnOffset, transform.rotation);
        Instantiate(golfBall, spawnLoc, transform.rotation);
    }

    //public void moveObjUp()
    //{
        
    //    if (UpButton.isSelected)
    //    {
    //         platformLoc.y += 0.5f;
    //    }
       
    //}
}
