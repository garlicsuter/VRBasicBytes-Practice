using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMaters : MonoBehaviour
{
    public GameObject Mater;
    public GameObject MaterSpawner;
    public Vector3 materSpawnLoc;

    private void Start()
    {
        materSpawnLoc = MaterSpawner.transform.position;
    }

    public void SpawnMater()
    {
        Instantiate(Mater, materSpawnLoc, Quaternion.identity);
    }
}
