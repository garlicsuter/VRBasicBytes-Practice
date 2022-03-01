using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanScript : MonoBehaviour
{
    public GameObject scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Can"))
        {
            Destroy(other.gameObject);
            scoreText.GetComponent<ScoreKeeperCans>().scoreValue += 5;
            scoreText.GetComponent<ScoreKeeperCans>().UpdateScore();
        }
    }
}
