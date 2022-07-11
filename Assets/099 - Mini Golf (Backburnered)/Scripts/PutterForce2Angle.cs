using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutterForce2Angle : MonoBehaviour
{
    public float radius = 5.0F;
    public float power = 10.0F;
    public AudioSource src;
    public float angle = 45;
    public GameObject scoreText;


    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collide");
        if (col.gameObject.tag == "Ball")
        {
            Debug.Log("Ball");
            Vector3 explosionPos = transform.position;
            Rigidbody rb = col.gameObject.GetComponent<Rigidbody>();
            scoreText.GetComponent<ScoreKeeper>().UpdateScore();

            //Get angle of club head
            Vector3 dir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;

            if (rb != null)
            {
                Debug.Log("Boom");
                src.Play();
                //rb.AddExplosionForce(power, explosionPos, radius, 1.0F);
                rb.AddForce(dir * power, ForceMode.Impulse);
            }
        }
    }
}
