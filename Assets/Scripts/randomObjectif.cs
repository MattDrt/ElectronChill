using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class randomObjectif : MonoBehaviour
{

    public Text objectifN;
    public Text objectifL;
    public Text objectifML;
	public Text timing;
    int numberObjFill= 0;

    public int N;
    public int L;
    public int ML;

	public static float timer;
	float timeLimit;

    public Image myOrbital;
    Sprite orbSprite;

    // Use this for initialization
    void Start()
    {
		timer = 0;
		timeLimit = 2f;

		timing.text = "New objectif !!!";

        int N = (int)UnityEngine.Random.Range(1, 6);
        int L = (int)UnityEngine.Random.Range(0, N - 1);
        int ML = (int)UnityEngine.Random.Range(0, L);

        myOrbital.enabled = false;

        if (myOrbital != null)
        {
            myOrbital.enabled = true;
			//Choix de l'image de l'orbitale atomique à afficher en fond en fonction de la valeur de l'objectif
            orbSprite = Resources.Load<Sprite>("orbitales/" + N.ToString() + L.ToString() + ML.ToString());
            myOrbital.sprite = orbSprite;
			if (orbSprite == null)
				myOrbital.enabled = false;
            else if (orbSprite != null )
                myOrbital.enabled = true;
        }

        objectifN.text = " " + N.ToString();
        objectifL.text = " " + L.ToString();
        objectifML.text = " " + ML.ToString();
        numberObjFill++;

		if (numberObjFill > 5)
			SceneManager.LoadScene ("you win");
            //Application.LoadLevel("you win");

    }

    // Update is called once per frame
    void Update()
    {
		timer += Time.deltaTime;
		if (timer >= timeLimit)
		{
			timer = 0.0f;
			timing.text = "      ";
		}
        if (objectifN.text.Equals(" 0") && objectifL.text.Equals(" 0") && objectifML.text.Equals(" 0"))
        {
            timer = 0.0f;
        //    Circle_timer.FindObjectOfType<Image>().fillAmount += 60f ;
            this.Start();
        }
    }
}