using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clubber : MonoBehaviour
{

    public float mSpeed = 10.0f;
    Vector3 mPrevPos;
    RaycastHit hitBall;
    public bool rayHit = false;
    public float Reach = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        mPrevPos = transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        var fwd = transform.TransformDirection(Vector3.forward);

        

        mPrevPos = transform.position;

        //transform.Translate(-mSpeed * Time.deltaTime, 0.0f, 0.0f);

        //RaycastHit[] hits = Physics.RaycastAll(new Ray(mPrevPos, (transform.position - mPrevPos).normalized), (transform.position - mPrevPos).magnitude);

        //for(int i = 00; i < hits.Length; i++)
        //{
        //    Debug.Log(hits[i].collider.gameObject.name);
        //}

        
        if (Physics.Raycast(transform.position, fwd, out hitBall, Reach) && hitBall.transform.gameObject.tag == "Ball")
        {
            Debug.Log("Raycast hitBall: " + hitBall + " AND Reach is: " + Reach + " and name: " + hitBall.transform.gameObject.name);
        }

        Debug.DrawLine(transform.position, mPrevPos);
    }
}
