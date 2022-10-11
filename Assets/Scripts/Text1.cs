using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Text1 : MonoBehaviour
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
        Run0_9WithSpeed();
        textNumber.text = number.ToString();
    }

    void Run0_9WithSpeed()
    {
        if (timer < 1 * speed && timer >= 0 * speed) number = 0;
        if (timer < 2 * speed && timer >= 1 * speed) number = 1;
        if (timer < 3 * speed && timer >= 2 * speed) number = 2;
        if (timer < 4 * speed && timer >= 3 * speed) number = 3;
        if (timer < 5 * speed && timer >= 4 * speed) number = 4;
        if (timer < 6 * speed && timer >= 5 * speed) number = 5;
        if (timer < 7 * speed && timer >= 6 * speed) number = 6;
        if (timer < 8 * speed && timer >= 7 * speed) number = 7;
        if (timer < 9 * speed && timer >= 8 * speed) number = 8;
        if (timer < 10 * speed && timer >= 9 * speed) number = 9;
        if (timer >= 10 * speed)
        {
            number = 0;
            timer = 0f;
        }

    }
}
