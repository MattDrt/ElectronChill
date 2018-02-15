using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circle_timer : MonoBehaviour
{

    public UnityEngine.UI.Image circle_timer;

    float waitTime = 60.0f;

    public float WaitTime
    {
        get
        {
            return waitTime;
        }

        set
        {
            waitTime = value;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        circle_timer.fillAmount -= 1.0f / WaitTime * Time.deltaTime;

        if (circle_timer.fillAmount == 0)
        {
            Application.LoadLevel("GameOver");
            GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
            foreach (GameObject go in allObjects)
            {

                if (go.transform.childCount > 0 && go.layer == 0)
                {
                    go.transform.GetChild(0).GetComponent<Renderer>().enabled = false;
                    go.transform.GetComponent<Renderer>().enabled = false;
                }
            }
        }
    }

}