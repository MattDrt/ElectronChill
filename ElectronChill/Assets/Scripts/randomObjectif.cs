using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System;

public class randomObjectif : MonoBehaviour
{

    public Text objectifN;
    public Text objectifL;
    public Text objectifML;
    public Text score;

    public int N;
    public int L;
    public int ML;
    // Use this for initialization
    void Start()
    {
        int N = (int)UnityEngine.Random.Range(1, 6);
        int L = (int)UnityEngine.Random.Range(0, N - 1);
        int ML = (int)UnityEngine.Random.Range(0, L);

        objectifN.text = " " + N.ToString();
        objectifL.text = " " + L.ToString();
        objectifML.text = " " + ML.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        if (objectifN.text.Equals(" 0") && objectifL.text.Equals(" 0") && objectifML.text.Equals(" 0"))
        {
            Debug.Log("Tomorow");
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            string[] words = score.text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int i = Int32.Parse(words[1]);
            i++;
          /*  score.text = words[0] + " " + i;
            if (i >= 10)
                Application.LoadLevel("You Win");
            */this.Start();
        }


    }

}