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
    UnityEngine.UI.Text Score;
    public const float FramesCount = 500;
    public const float AnimationTimeSeconds = 2;
    public float _deltaTime = AnimationTimeSeconds / FramesCount;
    public float _dx = (InitScale - TargetScale) / FramesCount;
 
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
  //  GameObject scoreText;
    
    Text livesText;

	public Text objectifN;
	public Text objectifL;
	public Text objectifML;

	int livesNumber;
	public Text Scoretext;
    static int scoreNumber;
    int combo;


    public String lasthit;

    GameObject currentGameO;
	// Use this for initialization
	void Start () {
        float FramesCount = 100;
        _deltaTime = AnimationTimeSeconds / FramesCount;
        _dx = (InitScale - TargetScale) / FramesCount;
        //Lletter = GameObject.Find("Lletter");GameObject.FindGameObjectsWithTag("fred");
        Lletter = GameObject.FindGameObjectWithTag("Lletter");
			//GameObject.Find("Lletter").GetComponent<GameObject>();
		Nletter = GameObject.FindGameObjectWithTag("Nletter");
		MLletter = GameObject.FindGameObjectWithTag("MLletter");
        circle_timer = GameObject.Find("Circle_timer").GetComponent<UnityEngine.UI.Image>();
      //  scoreText = GameObject.Find("Score").GetComponent<UnityEngine.UI.Text>();
        //  scoreText = GameObject.Find("Score").GetComponent<Text>();
        livesText = GameObject.Find("Lives").GetComponent<Text>();


		//Initialize the values of walking speed
		float walkingSpeed = 0.0f;
		livesNumber = 1;
		scoreNumber = 0;
        combo = 1;

		//Initialize the GUI components
		//livesText.GetComponent(UnityEngine.UI.Text).guiText = "Lives Remaining: " + livesNumber;
		livesText.text  = "Level " + livesNumber;;
		//scoreText.GetComponent(UnityEngine.UI.Text).guiText = "Score: " + scoreNumber;
		//scoreText.text = "Score: ";
        N = 0;
        L = 0;
        ML = 0;
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
       
        InvokeRepeating("resetSize", 1f, 3f);
    }
    bool randomBoolean()
{
    if (UnityEngine.Random.value >= 0.5)
    {
        return true;
    }
    return false;
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
       ;
     
        //scoreNumber = Int32.Parse(Scoretext.text);
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
   
        foreach (GameObject go in allObjects)   
        {
            
            if (go.transform.childCount > 0 && go.layer == 0 )
            {
                if (go.transform.GetChild(0).transform.localScale.x < 0.25f)
                {
                    StartCoroutine(FadeTo(go, 0.0f, 0.5f));
                  
             
                }
                else if ((go.transform.GetChild(0).transform.localScale.x > 0.39f))
                {

                    StartCoroutine(Checklasthits());
                    StartCoroutine(FadeTo(go, 1f, 0.5f));
                    StartCoroutine(CollisionCheckWait(go));
                }

            }
        }
       
       
    }

    int resetSize()
    {
   
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

        foreach (GameObject gob in allObjects)
        {
            if (gob.transform.childCount > 0 && gob.layer == 0)
            {
                if ((gob.transform.GetChild(0).transform.localScale.x < 0.25f))
                {
                    if (randomBoolean())
                    {
                        if (gob.transform.GetComponent<Renderer>().enabled == true)
                        {
                          
                      
                            if ( (gob.name == "Fletter"))
                            {
                             scoreNumber += 100 * combo;
                            }
                            else if (gob.name == "Lletter" && L==0)
                                scoreNumber += 100 * combo;
                            else if (gob.name == "MLletter" && ML == 0)
                                scoreNumber += 100 * combo;
                            else if (gob.name == "Nletter" && N == 0)
                                scoreNumber += 100 * combo;
                          }
                        Scoretext.text = scoreNumber.ToString();
                        generatePos(gob);
                        gob.transform.GetChild(0).transform.localScale = Vector2.one * 0.40f;
                        break;
                    }
                }
            }
        }
        return 0;
    }

    void generatePos(GameObject obj)
    {
        float x = generateX();
        float y = generateY();
        Vector2 objPos2D = new Vector2(x, y);
        Vector2 originPos2D = new Vector2(obj.transform.position.x, obj.transform.position.y);
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
            obj.GetComponent<Rigidbody2D>().transform.position = new Vector3(x, y, obj.GetComponent<Rigidbody2D>().transform.position.z);
            obj.transform.GetChild(0).GetComponent<Renderer>().enabled = true;
            obj.transform.GetComponent<Renderer>().enabled = true;


        }
        else
        {
            obj.GetComponent<Rigidbody2D>().transform.position = new Vector3(x, y, obj.GetComponent<Rigidbody2D>().transform.position.z);
            obj.transform.GetComponent<Renderer>().enabled = true;
            obj.transform.GetChild(0).GetComponent<Renderer>().enabled = true;
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
                    //currentGameO.GetComponent<Rigidbody2D>().transform.position = new Vector3(x, y, currentGameO.GetComponent<Rigidbody2D>().transform.position.z);
                    currentGameO.transform.GetChild(0).GetComponent<Renderer>().enabled = false;
                    currentGameO.transform.GetComponent<Renderer>().enabled = false;

                    currentGameO.transform.GetChild(0).transform.localScale = Vector2.one * 0.40f;
                }
                else
                {
                    //currentGameO.GetComponent<Rigidbody2D>().transform.position = new Vector3(x, y, currentGameO.GetComponent<Rigidbody2D>().transform.position.z);
                    currentGameO.transform.GetChild(0).GetComponent<Renderer>().enabled = false;
                    currentGameO.transform.GetComponent<Renderer>().enabled = false;
                    currentGameO.transform.GetChild(0).transform.localScale = Vector2.one * 0.40f;
                }
             
               
            
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
      yield return new WaitForSeconds(seconds: 1f); ;  
    }
    IEnumerator CollisionCheckWait(GameObject obj)
    {
     
       
        StartCoroutine(Breath(obj));
     
        Debug.Log(obj.transform.GetChild(0).transform.localScale.x + "scale object");

        yield return new WaitForSeconds(seconds:0.0f);
        
 
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
    public IEnumerator generateObj(GameObject obj)
    {
       
          
     
        StartCoroutine(FadeToGen(obj, 1f, 0.5f));
        yield return new WaitForSeconds(seconds: 0.7f);



    }
public IEnumerator Breath(GameObject obj)
    {
        float _currentScale = obj.transform.GetChild(0).transform.localScale.x;
        Debug.Log(_currentScale +"curr scale");
        Debug.Log(_dx + "dx");
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / 2.0f)
        {
            _currentScale -= _dx;
            obj.transform.GetChild(0).transform.localScale = Vector2.one * _currentScale;           
            yield return null;
        }                     
    }
    IEnumerator FadeTo(GameObject obj, float aValue, float aTime)
    {
        float alpha2 = obj.transform.GetChild(0).GetComponent<Renderer>().material.color.a;
        float alpha = obj.transform.GetComponent<Renderer>().material.color.a;
     
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
        {

            Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha, aValue, t));
            Color newColor2 = new Color(1, 1, 1, Mathf.Lerp(alpha2, aValue, t));
            obj.transform.GetChild(0).transform.GetComponent<Renderer>().material.color = newColor2;    
            obj.transform.GetComponent<Renderer>().material.color = newColor;
        
            yield return null;
        }
    }
    IEnumerator FadeToGen(GameObject obj, float aValue, float aTime)
    {
        float alpha2 = obj.transform.GetChild(0).GetComponent<Renderer>().material.color.a;
        float alpha = obj.transform.GetComponent<Renderer>().material.color.a;

      
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
        {
            Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha, aValue, t));
            Color newColor2 = new Color(1, 1, 1, Mathf.Lerp(alpha2, aValue, t));
            obj.transform.GetChild(0).transform.GetComponent<Renderer>().material.color = newColor2;
            obj.transform.GetComponent<Renderer>().material.color = newColor;

            yield return null;
        }
    }
    void penalite(float penalite)
    {
            
        //Circle_timer circ = circle_timer.GetComponent<Circle_timer>();

        circle_timer.fillAmount -= penalite;
    
        
      //  Debug.Log("test penal" + circ.WaitTime);
    }

    void bonus(float bonus)
    {
   
        circle_timer.fillAmount += bonus;
    }

    void OnMouseDown()
    {
 
        Debug.Log(gameObject.name + "N " + N + " L " + L + " ML" + ML);
        if (gameObject.name == "Lletter")
        {
            if (L == 0 && (gameObject.transform.GetChild(0).transform.localScale.x > 0.25f))
            {
                scoreNumber -= 1000;
                penalite(0.05f);
                combo = 1;
            }
            //int i = Int32.Parse(objectifL.text);
            else if (gameObject.transform.GetChild(0).transform.localScale.x < 0.23f)
            {

                scoreNumber += 1000 * combo;

                L--;
                combo++;

            }
            else if (gameObject.transform.GetChild(0).transform.localScale.x < 0.25f)
            {

                scoreNumber += 1000 + 1000 * combo;
            //    scoreText.text = "Scorelol: " + scoreNumber    ;
                L--;
                combo++;

            }
            
            else
            penalite(0.05f);
            L = L < 0 ? 0 : L;
            //objectifL.text = " " + i;
        }
        else if (gameObject.name == "Nletter")
        {
            //int i = Int32.Parse(objectifN.text);
            if (N == 0 && (gameObject.transform.GetChild(0).transform.localScale.x > 0.25f))
            {

                scoreNumber -= 1000;
                penalite(0.05f);
                combo = 1;
            }
            else if (gameObject.transform.GetChild(0).transform.localScale.x < 0.23f)
            {
                scoreNumber += 1000 * combo;
             //   scoreText.text = "Scorelol: " + scoreNumber;

                combo++;
                N--;

            }
            else if (gameObject.transform.GetChild(0).transform.localScale.x < 0.25f)
            {
                scoreNumber += 1000 + 1000 * combo;
             //   scoreText.text = "Scorelol: " + scoreNumber;

                combo++;
                N--;

            }
         
            else
                penalite(0.05f);
            N = N < 0 ? 0 : N;
            //objectifN.text = " " + i;
        }
        else if (gameObject.name == "MLletter")
        {
            //int i = Int32.Parse(objectifML.text);
            if (ML == 0 && (gameObject.transform.GetChild(0).transform.localScale.x > 0.25f))
            {
                scoreNumber -= 1000;
                penalite(0.05f);
                combo = 1;
            }
            else if (gameObject.transform.GetChild(0).transform.localScale.x < 0.23f)
            {
                scoreNumber += 1000 * combo;
             //   scoreText.text = "Scorelol: " + scoreNumber;

                combo++;
                ML--;
            }
            else if (gameObject.transform.GetChild(0).transform.localScale.x < 0.25f)
            {
                scoreNumber += 1000 + 1000 * combo;
               // scoreText.text = "Scorelol: " + scoreNumber;

                combo++;
                ML--;
            }
          
            
            ML = ML < 0 ? 0 : ML;
            //objectifML.text = " " + i;
        }
        else if (gameObject.name == "Fletter")
        {
            if (gameObject.transform.GetChild(0).transform.localScale.x > 0.25f)
            {
                combo = 1;
                penalite(0.05f);
            }
           else if (gameObject.transform.GetChild(0).transform.localScale.x < 0.25f)
            {
                scoreNumber -= 1000;
                combo = 1;  
                penalite(0.05f);
            }
            
        }

        if (N == 0 && L == 0 && ML == 0)
        {
            objectifN.text = " " + N.ToString();
            objectifL.text = " " + L.ToString();
            objectifML.text = " " + ML.ToString();
            bonus(3f);
            //TODO Circle_timer.fillAmount = 1;
        }
        Scoretext.text = scoreNumber.ToString() ;
    }

}
