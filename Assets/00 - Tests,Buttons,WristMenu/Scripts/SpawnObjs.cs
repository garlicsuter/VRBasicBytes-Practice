using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjs : MonoBehaviour
{
    public GameObject golfBall;
    public GameObject spawner;
    private Vector3 spawnOffset = new Vector3(0,.15f,0);
    private Vector3 spawnLoc;

    public void SpawnBall()
    {
        spawnLoc = spawner.transform.position;

        //Instantiate(golfBall, transform.position + spawnOffset, transform.rotation);
        Instantiate(golfBall, spawnLoc, transform.rotation);
    }
}
