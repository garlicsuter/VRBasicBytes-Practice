using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enumPlayer : MonoBehaviour
{
    public GameObject whatisthechosenShape;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gm = GameObject.FindGameObjectWithTag("GameManager");

       whatisthechosenShape = gm.GetComponent<enums_rules>().randoShape.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
