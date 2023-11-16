using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeperCans : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int scoreValue;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void UpdateScore()
    {
        scoreText.text = "Score: " + scoreValue.ToString();
    }
}
