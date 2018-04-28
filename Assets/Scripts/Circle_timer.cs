using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circle_timer : MonoBehaviour
{

    public UnityEngine.UI.Image circle_timer;
    float timer;
    float timeLimit;
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
        
        LetterScript.Combo = 1;
        timer = 0;
        timeLimit = 2f;

    }

    // Update is called once per frame
    void Update()
    {

        circle_timer.fillAmount -= 1.0f / WaitTime * Time.deltaTime;
        if (circle_timer.color == new Color(255, 0, 0) || circle_timer.color == new Color(0, 255, 0))
        {
            timer += Time.deltaTime;
            if (timer >= timeLimit)
            {
                timer = 0.0f;
                circle_timer.color = new Color(230, 255, 0);
            }                 
          
        }
      
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

