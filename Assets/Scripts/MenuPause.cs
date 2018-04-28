	using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPause : MonoBehaviour {

    public GameObject menuPause;
    public Button boutonPause;
    public Button boutonResume;
    

    private void Start()
    {
        Button btnPause = boutonPause.GetComponent<Button>();
        btnPause.onClick.AddListener(delegate {TaskOnClick();  });


        Button btnResume = boutonResume.GetComponent<Button>();
        btnResume.onClick.AddListener(delegate { resumeOnClick(); });
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyUp(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                AudioListener.pause = true;
                menuPause.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                AudioListener.pause = false;
                menuPause.SetActive(false);
            }
        }
    }

	void TaskOnClick()
	{
		//Debug.Log ("clic");
		if (Time.timeScale == 1)
		{
			Time.timeScale = 0;
			AudioListener.pause = true;
			menuPause.SetActive(true);
        }
		else
		{
			Time.timeScale = 1;
			AudioListener.pause = false;
			menuPause.SetActive(false);
        }
	}

    void resumeOnClick()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        menuPause.SetActive(false);
    }
}
