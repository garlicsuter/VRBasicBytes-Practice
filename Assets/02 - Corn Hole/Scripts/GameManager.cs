using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI blueScoreText;
    public TextMeshProUGUI orangeScoreText;
    public GameObject SideLeft;
    public GameObject SideRight;
    public GameObject blueBag1;
    public GameObject blueBag2;
    public GameObject blueBag3;
    public GameObject orangeBag1;
    public GameObject orangeBag2;
    public GameObject orangeBag3;
    public GameObject XROrigin;
    private Vector3 XROriginPos;
    private Vector3 blueBag1StartPos;
    private Vector3 blueBag2StartPos;
    private Vector3 blueBag3StartPos;
    private Vector3 orangeBag1StartPos;
    private Vector3 orangeBag2StartPos;
    private Vector3 orangeBag3StartPos;

    public string side = "sideLeft";
    private int blueRoundScore = 0;
    private int orangeRoundScore = 0;
    private int blueTotalScore = 0;
    private int orangeTotalScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        //blueScoreText.text = "Hi Blue!";
        XROriginPos = XROrigin.transform.position;
        blueBag1StartPos = blueBag1.transform.position;
        blueBag2StartPos = blueBag2.transform.position;
        blueBag3StartPos = blueBag3.transform.position;
        orangeBag1StartPos = orangeBag1.transform.position;
        orangeBag2StartPos = orangeBag1.transform.position;
        orangeBag3StartPos = orangeBag1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetGame()
    {
        XROrigin.transform.position = XROriginPos;
        blueRoundScore = 0;
        orangeRoundScore = 0;
        orangeTotalScore = 0;
        blueTotalScore = 0;
        blueBag1.transform.position = blueBag1StartPos;
        blueBag2.transform.position = blueBag2StartPos;
        blueBag3.transform.position = blueBag3StartPos;
        orangeBag1.transform.position = orangeBag1StartPos;
        orangeBag2.transform.position = orangeBag2StartPos;
        orangeBag3.transform.position = orangeBag3StartPos;
        Debug.Log("Game Reset!");
    }
}
