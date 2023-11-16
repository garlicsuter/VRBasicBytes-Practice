using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMaters : MonoBehaviour
{
    public GameObject Mater;
    public GameObject MaterSpawner;
    public Vector3 materSpawnLoc;

    // Start is called before the first frame update
    void Start()
    {
        materSpawnLoc = MaterSpawner.transform.position;
    }

    public void MaterSpawnerDeluxe()
    {
        Instantiate(Mater, materSpawnLoc, Quaternion.identity);
    }
}
