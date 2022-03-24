using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjs : MonoBehaviour
{
    public GameObject golfBall;
    private Vector3 spawnOffset = new Vector3(0,.15f,0);

    public void SpawnBall()
    {
        Instantiate(golfBall, transform.position + spawnOffset, transform.rotation);
    }
}
