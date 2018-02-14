using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circle_timer : MonoBehaviour
{

    public UnityEngine.UI.Image circle_timer;

    float waitTime = 30.0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        circle_timer.fillAmount -= 1.0f / waitTime * Time.deltaTime;

        if (circle_timer.fillAmount == 0)
        {
            Application.LoadLevel("GameOver");
        }
    }

}