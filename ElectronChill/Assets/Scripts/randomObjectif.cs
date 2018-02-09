using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomObjectif : MonoBehaviour
{

    public Text objectifN;
    public Text objectifL;
    public Text objectifML;

    int N;
    int L;
    int ML;

    // Use this for initialization
    void Start()
    {
        int N = (int)Random.Range(1, 6);
        int L = (int)Random.Range(0, N - 1);
        int ML = (int)Random.Range(0, L);

        objectifN.text = N.ToString();
        objectifL.text = L.ToString();
        objectifML.text = ML.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        objectifN.text = N.ToString();
        objectifL.text = N.ToString();
        objectifML.text = N.ToString();
        */
    }
}
