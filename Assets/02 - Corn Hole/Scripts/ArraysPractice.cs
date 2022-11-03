using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysPractice : MonoBehaviour
{

    public int[] lottoNumbers = { 1, 2, 3, 4, 5, 6 };
    public int myNumber;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myNumber = lottoNumbers[Random.Range(0,6)];
        Debug.Log("My number is: " + myNumber);
    }
}
