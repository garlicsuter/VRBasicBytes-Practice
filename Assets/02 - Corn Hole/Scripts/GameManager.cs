using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI blueScore;
    public TextMeshProUGUI orangeScore;
    public GameObject SideLeft;
    public GameObject SideRight;

    // Start is called before the first frame update
    void Start()
    {
        blueScore.text = "Hi Blue!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
