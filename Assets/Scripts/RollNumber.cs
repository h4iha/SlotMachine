using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollNumber : MonoBehaviour
{
    public int index;
    public Text textNumber;
    public int number;
    public int choosenumber;
    public float fixspeed = 1;
    public float timer;
    public float speed;

    void Start()
    {
        number = 0;
        speed = 0.05f * (float) index;
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= speed && speed > 0) 
        {
            Run0_9();
            timer = 0;
        }
        textNumber.text = number.ToString();
    }

    public void Run0_9() {
        if (number > 8)
        {
            number = 0;
        }
        number++;
        textNumber.text = number.ToString();
    }

}
