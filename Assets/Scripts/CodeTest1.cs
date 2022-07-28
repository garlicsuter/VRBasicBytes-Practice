using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeTest1 : MonoBehaviour
{
    public int score = 0;
    private int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My Score is: " + score);
        Debug.Log("I have" + lives + "lives left.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
