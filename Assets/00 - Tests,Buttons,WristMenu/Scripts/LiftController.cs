using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftController : MonoBehaviour
{
    public GameObject platform;
    public float platformSpeed;
    public XRButton UpButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UpButton.isHovered)
        {
            //platformLoc.y += 0.5f;
            platform.transform.Translate(Vector3.up * Time.deltaTime * platformSpeed, Space.World);
            Debug.Log("Going UP");
        }
    }

    public void GoingUp()
    {
        platform.transform.Translate(Vector3.up * Time.deltaTime * platformSpeed, Space.World);
        Debug.Log("Going UP");
    }
}
