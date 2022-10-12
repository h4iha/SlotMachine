using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RollNumber : MonoBehaviour
{
    public Text textNumber;
    public int number;
    public float speed;
    private float timer;

    void Start()
    {
        number = 0;
        textNumber.text = number.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= speed)
        {
            Run0_9();
            timer = 0;
        }

        
    }

    void Run0_9() {
        if (number > 8)
        {
            number = 0;
        }
        number++;
        textNumber.text = number.ToString();
    }
}
