using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LetterScript : MonoBehaviour {

    public const float InitScale = 0.4f;
   // public float _currentScale = InitScale;
    public const float TargetScale = 0.25f;

    UnityEngine.UI.Image circle_timer;
    public const int FramesCount = 100;
    public const float AnimationTimeSeconds = 2;
    public float _deltaTime = AnimationTimeSeconds / FramesCount;
    public float _dx = (TargetScale - InitScale) / FramesCount;
    public bool _stopScale = true;
    public GameObject circleLetterN;
    public GameObject circleLetterL;
    public GameObject circleLetterML;


    static int N;
    static int L;
    static int ML;

    private IEnumerator coroutine;



    GameObject Lletter ;
	GameObject Nletter;
	GameObject MLletter;

	Text scoreText;
	Text livesText;

	public Text objectifN;
	public Text objectifL;
	public Text objectifML;

	int livesNumber;
	int scoreNumber;




    public String lasthit;

    GameObject currentGameO;
	// Use this for initialization
	void Start () {

		//Lletter = GameObject.Find("Lletter");GameObject.FindGameObjectsWithTag("fred");
		Lletter = GameObject.FindGameObjectWithTag("Lletter");
			//GameObject.Find("Lletter").GetComponent<GameObject>();
		Nletter = GameObject.FindGameObjectWithTag("Nletter");
		MLletter = GameObject.FindGameObjectWithTag("MLletter");
        circle_timer = GameObject.Find("Circle_timer").GetComponent<UnityEngine.UI.Image>();

        scoreText = GameObject.Find("Score").GetComponent<Text>();
		livesText = GameObject.Find("Lives").GetComponent<Text>();


		//Initialize the values of walking speed
		float walkingSpeed = 0.0f;
		livesNumber = 3;
		scoreNumber = 0;


		//Initialize the GUI components
		//livesText.GetComponent(UnityEngine.UI.Text).guiText = "Lives Remaining: " + livesNumber;
		livesText.text  = "Lives Remaining: " + livesNumber;;
		//scoreText.GetComponent(UnityEngine.UI.Text).guiText = "Score: " + scoreNumber;
		scoreText.text = "Score: " + scoreNumber;
        N = 0;
        L = 0;
        ML = 0;
    }



	// Update is called once per frame
	void Update () {
        /*
		timer+=Time.deltaTime;
		if (timer >= timeLimit) {
			timer = 0.0f;
		}
        */
        if (N == 0 && L == 0 && ML == 0)
        {
            N = Int32.Parse(objectifN.text);
            L = Int32.Parse(objectifL.text);
            ML = Int32.Parse(objectifML.text);
        }

    }
    
    void FixedUpdate()
    {
        

        RaycastHit2D hit;
            if (Input.GetMouseButtonUp(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {            
                currentGameO = hit.collider.gameObject;
                lasthit = hit.collider.gameObject.name;

                float x = generateX();
                float y = generateY();
                Vector2 objPos2D = new Vector2(x, y);
                Vector2 originPos2D = new Vector2(currentGameO.transform.position.x, currentGameO.transform.position.y);
                Vector2 dir = (objPos2D - originPos2D).normalized;
                RaycastHit2D hitobj = Physics2D.Raycast(objPos2D, dir);
                if (hitobj.collider != null)
                {
                    while (hitobj.collider != null)
                    {
                        x = generateX();
                        y = generateY();
                        objPos2D = new Vector2(x, y);

                        dir = (objPos2D - originPos2D).normalized;
                        hitobj = Physics2D.Raycast(objPos2D, dir);

                    }
                    
                    currentGameO.GetComponent<Rigidbody2D>().transform.position = new Vector3(x, y, currentGameO.GetComponent<Rigidbody2D>().transform.position.z);
                    
                }
          else
                    currentGameO.GetComponent<Rigidbody2D>().transform.position = new Vector3(x, y, currentGameO.GetComponent<Rigidbody2D>().transform.position.z);

                StartCoroutine(Breath(currentGameO));
                StartCoroutine(CollisionCheckWait(currentGameO));
            }      
        }
       
    }
   void LateUpdate()
    {
      
    }

    void gameOver(){	
		Application.LoadLevel("GameOver");
	}

	float generateX(){
		float x = UnityEngine.Random.Range(-2.30f,2.30f);
		return x;
	}

	float generateY(){
		float y = UnityEngine.Random.Range(-4.0f,2.24f);
		return y;
	}
   
	void generateCoordinates(GameObject obj){
    
        float x = generateX();
        float y = generateY();
        //You clicked it!
        scoreNumber += 1;
        StartCoroutine(moveObject(obj, x, y));
        Debug.Log(obj.name+" is generated" + obj.GetComponent<Rigidbody2D>().bodyType + obj.tag);
           
    }
    IEnumerator moveObject(GameObject obj, float x, float y)
    {
        //yield return new WaitForFixedUpdate();
        yield return new WaitForSeconds(seconds: 0.1f);
        obj.GetComponent<Rigidbody2D>().transform.position = new Vector3(x, y, obj.GetComponent<Rigidbody2D>().transform.position.z);
       
    }


    IEnumerator Checklasthits()
    {
        yield return new WaitForFixedUpdate();  
    }
    IEnumerator CollisionCheckWait(GameObject obj)
    {
        yield return new WaitForSeconds(seconds:0.5f);
        obj.GetComponent<Renderer>().enabled = true;
        //update_score(obj);
        
    }

    void update_score(GameObject obj)
    {
        if (obj.name == "Lletter")
        {
            int i = Int32.Parse(objectifL.text);
            i--;
            //i = i < 0 ? 0 : i;
            objectifL.text = " " + i;
        }
        else if (obj.name == "Nletter")
        {
            int i = Int32.Parse(objectifN.text);
            i--;
            //i = i < 0 ? 0 : i;
            objectifN.text = " " + i;
        }
        else if (obj.name == "MLletter")
        {
            int i = Int32.Parse(objectifML.text);
            i--;
            //i = i < 0 ? 0 : i;
            objectifML.text = " " + i;
        }
    }

    public IEnumerator Breath(GameObject obj)
    {

     // float  _currentScale = obj.transform.GetChild(0).localScale.x;

        float _currentScale = obj.transform.GetChild(0).transform.localScale.x;
        Debug.Log(_currentScale +"curr scale");

        while (_currentScale >= TargetScale)
        {
            _currentScale += _dx;
      
            obj.transform.GetChild(0).transform.localScale= Vector3.one * _currentScale;
                yield return new WaitForSeconds(_deltaTime);
        }
    
        /*
        while (!_upScale)
        {
            _currentScale -= _dx;
            if (_currentScale < InitScale)
            {
                _upScale = true;
                _currentScale = InitScale;
            }
            obj.transform.GetChild(0).localScale = Vector3.one * _currentScale;
            yield return new WaitForSeconds(_deltaTime);

        }
        */
    }
    void penalite()
    {
        circle_timer.fillAmount -= 0.25f;
    }

    void bonus()
    {
        circle_timer.fillAmount += 0.5f;
    }
    void OnMouseDown()
    {
        Debug.Log(gameObject.name + "N " + N + " L " + L + " ML" + ML);
        if (gameObject.name == "Lletter")
        {
            if (L == 0)
                penalite();
            //int i = Int32.Parse(objectifL.text);
            L--;
            L = L < 0 ? 0 : L;
            //objectifL.text = " " + i;
        }
        else if (gameObject.name == "Nletter")
        {
            //int i = Int32.Parse(objectifN.text);
            if (N == 0)
                penalite();
            N--;
            N = N < 0 ? 0 : N;
            //objectifN.text = " " + i;
        }
        else if (gameObject.name == "MLletter")
        {
            //int i = Int32.Parse(objectifML.text);
            if (ML == 0)
                penalite();
            ML--;
            ML = ML < 0 ? 0 : ML;
            //objectifML.text = " " + i;
        }
        else if (gameObject.name == "Fletter")
        {
            penalite();
        }

        if (N == 0 && L == 0 && ML == 0)
        {
            objectifN.text = " " + N.ToString();
            objectifL.text = " " + L.ToString();
            objectifML.text = " " + ML.ToString();
            bonus();
            //TODO Circle_timer.fillAmount = 1;
        }

    }

}
