using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enums_rules : MonoBehaviour
{
    public GameObject[] Shapes;
    public int randoChoiceNum;
    public GameObject randoShape;

    void Start()
    {
        Shapes = GameObject.FindGameObjectsWithTag("Shapey");

        //for (int i = 0; i < Shapes.Length; i++)
        //{
        //    Debug.Log(Shapes[i]);
        //}
        RandoShape();
    }
    

    public void RandoShape()
    {
        randoChoiceNum = Random.Range(0, Shapes.Length);
        randoShape = Shapes[randoChoiceNum];

        Debug.Log("randoChoice= " + randoChoiceNum);
        Debug.Log("The chosen shape: " + randoShape);
    }

}
