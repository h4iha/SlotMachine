using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllRoll : MonoBehaviour
{

    public GameObject go1;
    public GameObject go2;
    public GameObject go3;

    void Start()
    {
        
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            go1.GetComponent<RollNumber>().Run0_9();
        }

    }
    void SlowStop()
    {
        go1.GetComponent<RollNumber>().speed = 1;
        go1.GetComponent<RollNumber>().timer = 0f;
    }
}
