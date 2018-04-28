using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LetterScript : MonoBehaviour
{

    public GameObject Prefab;
    public const float InitScale = 0.4f;
    // public float _currentScale = InitScale;
    public const float TargetScale = 0.25f;

    public UnityEngine.UI.Image circle_timer;
    UnityEngine.UI.Text Score;
    public const float FramesCount = 300;
    public const float AnimationTimeSeconds = 2;
    public float _deltaTime = AnimationTimeSeconds / FramesCount;
    public float _dx = (InitScale - TargetScale) / FramesCount;
    public static int Combo;
    public bool _stopScale = true;
    public GameObject circleLetterN;
    public GameObject circleLetterL;
    public GameObject circleLetterML;


    static int N;
    static int L;
    static int ML;

    private IEnumerator coroutine;

    public Text timing;

    public GameObject Lletter;
    public GameObject Nletter;
    public GameObject MLletter;

    //  GameObject scoreText;

    Text livesText;

    public Text objectifN;
    public Text objectifL;
    public Text objectifML;


    int livesNumber;
    public Text Scoretext;
    static int scoreNumber;


    float timer;
    float timeLimit;

    public String lasthit;

    GameObject currentGameO;
    // Use this for initialization
    void Start()
    {
        //  Prefab = Resources.Load("prefab/Prefab") as Transform;

        this.Lletter.transform.Translate(0, 0, 0.2f);
        this.Nletter.transform.Translate(0, 0, 0.2f);
        this.MLletter.transform.Translate(0, 0, 0.2f);

        float FramesCount = 100;
        _deltaTime = AnimationTimeSeconds / FramesCount;
        _dx = (InitScale - TargetScale) / FramesCount;
        // Lletter = GameObject.Find("Lletter");GameObject.FindGameObjectsWithTag("fred");
        //Lletter = GameObject.FindGameObjectWithTag("Lletter");
        //GameObject.Find("Lletter").GetComponent<GameObject>();
        //		Nletter = GameObject.FindGameObjectWithTag("Nletter");

        //		MLletter = GameObject.FindGameObjectWithTag("MLletter");
        // circle_timer = GameObject.Find("Circle_timer").GetComponent<UnityEngine.UI.Image>();
        //  scoreText = GameObject.Find("Score").GetComponent<UnityEngine.UI.Text>();
        //  scoreText = GameObject.Find("Score").GetComponent<Text>();
        livesText = GameObject.Find("Lives").GetComponent<Text>();



        livesNumber = 1;
        //scoreNumber = 0;

        //Initialize the GUI components
        //livesText.GetComponent(UnityEngine.UI.Text).guiText = "Lives Remaining: " + livesNumber;
        livesText.text = "Level " + livesNumber; ;
        //scoreText.GetComponent(UnityEngine.UI.Text).guiText = "Score: " + scoreNumber;
        //scoreText.text = "Score: ";

        //N = 0;
        //L = 0;
        // ML = 0;
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

        timer = 0;
        timeLimit = 1;


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
    void Update()
    {




        //  StartCoroutine(resetSize());
        if (N == 0 && L == 0 && ML == 0)
        {
            N = Int32.Parse(objectifN.text);
            L = Int32.Parse(objectifL.text);
            ML = Int32.Parse(objectifML.text);
        }


        //scoreNumber = Int32.Parse(Scoretext.text);
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

        foreach (GameObject go in allObjects)
        {
            if (go.tag == "prefabs")
            {
                go.transform.Translate(0, 0, 0.4f);
                Debug.Log("go transfoooooooooooorm");
            }

            if (go.transform.childCount > 0 && go.layer == 0 && (go.tag != "prefabs"))
            {
                //     Debug.Log(go.transform.GetChild(0).transform.localScale.x+"test scale");

                if (go.transform.GetChild(0).transform.localScale.x < 0.25f)
                {
                    //  StartCoroutine(FadeTo(go, 0.0f, 0.5f));


                }
                else if ((go.transform.GetChild(0).transform.localScale.x > 0.39f))
                {

                    // StartCoroutine(Breath(go));
                    // StartCoroutine(FadeTo(go, 1f, 0.5f));


                }

            }
        }


    }

    //   void resetSize()
    //  {
    /*  GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();


          float x = generateX();
          float y = generateY();

          GameObject clone = Instantiate(Prefab, new Vector3(x, y, 0), Quaternion.identity) as GameObject;

        //  clone.tag = "prefabL1";
          clone.name = "Lclone2" + Time.deltaTime;
          //  generatePos(gobe);
          clone.transform.GetComponent<Renderer>().enabled = true;
          clone.transform.GetComponent<Renderer>().sortingOrder = 2;
          clone.transform.GetChild(0).GetComponent<Renderer>().enabled = true;
          clone.transform.GetChild(0).transform.localScale = Vector2.one * 0.40f;
          //clone.GetComponent<LetterScript>().Prefab = Prefab;

          Debug.Log("testprefab");
          StartCoroutine(Breath(clone, 2f));

      */


    /*
    yield return new WaitForSeconds(seconds: 1f);
    if (GameObject.FindGameObjectsWithTag("prefabL2").Length == 0)
    {
        float x = generateX();
        float y = generateY();
        GameObject clone2 = Instantiate(Resources.Load("prefab/Prefab"), new Vector3(x, y, 0), Quaternion.identity) as GameObject;

        clone2.tag = "prefabL2";
        clone2.name = "Lclone2" + Time.deltaTime;
        //  generatePos(gobe);
        clone2.transform.GetComponent<Renderer>().enabled = true;
        clone2.transform.GetComponent<Renderer>().sortingOrder = 2;
        clone2.transform.GetChild(0).GetComponent<Renderer>().enabled = true;
        clone2.transform.GetChild(0).transform.localScale = Vector2.one * 0.40f;
        Debug.Log("testprefab");
        StartCoroutine(Breath(clone2, 2f));
    }
   */
    //  }

    /*  
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
    */

    //}

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
                    // currentGameO.transform.GetChild(0).GetComponent<Renderer>().enabled = false;
                    // currentGameO.transform.GetComponent<Renderer>().enabled = false;
                    //StartCoroutine(DestroyObj(currentGameO));
                    // currentGameO.transform.GetChild(0).transform.localScale = Vector2.one * 0.40f;

                }
                else
                {
                    //currentGameO.GetComponent<Rigidbody2D>().transform.position = new Vector3(x, y, currentGameO.GetComponent<Rigidbody2D>().transform.position.z);
                    //currentGameO.transform.GetChild(0).GetComponent<Renderer>().enabled = false;
                    //currentGameO.transform.GetComponent<Renderer>().enabled = false;
                    //StartCoroutine(DestroyObj(currentGameO));
                    //currentGameO.transform.GetChild(0).transform.localScale = Vector2.one * 0.40f;

                }



            }
        }

    }
    void LateUpdate()
    {

    }

    void gameOver()
    {
        Application.LoadLevel("GameOver");
    }

    float generateX()
    {
        float x = UnityEngine.Random.Range(-2.30f, 2.30f);
        return x;
    }

    float generateY()
    {
        float y = UnityEngine.Random.Range(-4.0f, 2.24f);
        return y;
    }

    void generateCoordinates(GameObject obj)
    {

        float x = generateX();
        float y = generateY();
        //You clicked it!
        StartCoroutine(moveObject(obj, x, y));

        //  Debug.Log(obj.name+" is generated" + obj.GetComponent<Rigidbody2D>().bodyType + obj.tag);

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


        StartCoroutine(Breath(obj, 2f));

        Debug.Log(obj.transform.GetChild(0).transform.localScale.x + "scale object");

        yield return new WaitForSeconds(seconds: 0.0f);




    }

    void update_score(GameObject obj)
    {
        if (obj.name == "L Letter")
        {
           
            int i = Int32.Parse(objectifL.text);
            i--;
            //i = i < 0 ? 0 : i;
            if (i >= 0)
                objectifL.text = " " + i;
        }
        else if (obj.name == "N")
        {
           
            int i = Int32.Parse(objectifN.text);
            i--;
            Debug.Log("test" + i);
            //i = i < 0 ? 0 : i;
            if (i >= 0)
                objectifN.text = " " + i;
        }
        else if (obj.name == "ML")
        {
            int i = Int32.Parse(objectifML.text);
            i--;
            //i = i < 0 ? 0 : i;
            if (i >= 0)
                objectifML.text = " " + i;
        }
        if (objectifN.text.Equals(" 0") && objectifL.text.Equals(" 0") && objectifML.text.Equals(" 0"))
            bonus(0.5f);
    }
    public IEnumerator generateObj(GameObject obj)
    {



        StartCoroutine(FadeToGen(obj, 1f, 0.5f));
        yield return new WaitForSeconds(seconds: 0.7f);



    }
    public IEnumerator DestroyObj(GameObject obj)
    {

        yield return new WaitForSeconds(seconds: 0.0f);
        Destroy(obj);




    }

    public IEnumerator Breath(GameObject obj, float time)
    {
        Vector2 originalScale = obj.transform.GetChild(0).transform.localScale;
        Vector2 destinationScale = new Vector2(0.15f, 0.15f);
        float _currentScale = obj.transform.GetChild(0).transform.localScale.x;
        Debug.Log(_currentScale + "curr scale");
        Debug.Log(_dx + "dx");
        float currentTime = 0.0f;

        do
        {
            if (obj != null)
                obj.transform.GetChild(0).transform.localScale = Vector3.Lerp(originalScale, destinationScale, currentTime / time);
            currentTime += Time.deltaTime;
            yield return null;
        } while (currentTime <= time);
        if (obj != null)
        {
            Destroy(obj);

        }

    }

    IEnumerator FadeTo(GameObject obj, float aValue, float aTime)
    {
        float alpha2 = obj.transform.GetChild(0).GetComponent<SpriteRenderer>().material.color.a;
        float alpha = obj.transform.GetComponent<SpriteRenderer>().material.color.a;

        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
        {
            Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha, aValue, t));
            Color newColor2 = new Color(1, 1, 1, Mathf.Lerp(alpha2, aValue, t));

            if (obj != null)
            {
                obj.transform.GetComponent<SpriteRenderer>().material.color = newColor;
                obj.transform.GetChild(0).transform.GetComponent<SpriteRenderer>().material.color = newColor2;

            }
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
    IEnumerator penalite(float penalite)
    {
        circle_timer.color = new Color(255, 0, 0);
        circle_timer.fillAmount -= penalite;

        yield return new WaitForSeconds(0.01f);

        circle_timer.color = new Color(230, 255, 0);

        //  Debug.Log("test penal" + circ.WaitTime);
    }

    void bonus(float bonus)
    {
        circle_timer.color = new Color(0, 255, 0);
        circle_timer.fillAmount += bonus;
    }

    void OnMouseDown()
    {

        Debug.Log(Combo + "beat");
    

        if (gameObject.name == "L Letter")
        {
            randomObjectif.timer = 0;
            if (L == 0 && (gameObject.transform.GetChild(0).transform.localScale.x > 0.29f))
            {
                int score = 1000;
                scoreNumber -= score;
              
                penalite(0.05f);
                Combo = 1;
                timing.text = "-" + score.ToString();
            }
            else if (L == 0 && (gameObject.transform.GetChild(0).transform.localScale.x < 0.29f))
            {
                int score = 1000;
                scoreNumber -= score;

                penalite(0.05f);
                Combo = 1;
                timing.text = "-" + score.ToString();
            }
            else if (gameObject.transform.GetChild(0).transform.localScale.x < 0.25f)
            {
                int score = 1000 + 1000 * Combo;
                scoreNumber += score;
                timing.text = "+" + score.ToString() + "  Precision:Max";
                //    scoreText.text = "Scorelol: " + scoreNumber    ;
                L--;
                Combo++;

            }
            //int i = Int32.Parse(objectifL.text);
            else if (gameObject.transform.GetChild(0).transform.localScale.x < 0.29f)
            {
                int score = 1000 * Combo;
                scoreNumber += score;
                timing.text = "+" + score.ToString() +  "  Precision:Moy";
                L--;
                Combo++;

            }

            else
                StartCoroutine(penalite(0.05f));
            L = L < 0 ? 0 : L;
            //objectifL.text = " " + i;
        }
        else if (gameObject.name == "N")
        {
            randomObjectif.timer = 0;
            Debug.Log("test" + gameObject.name + gameObject.transform.GetChild(0).transform.localScale.x);
            //int i = Int32.Parse(objectifN.text);
            if (N == 0 && (gameObject.transform.GetChild(0).transform.localScale.x > 0.29f))
            {
                int score = 1000;
                scoreNumber -= score;
            
                StartCoroutine(penalite(0.05f));
                Combo = 1;
                timing.text = "-" + score.ToString();
            }
            else if (N == 0 && (gameObject.transform.GetChild(0).transform.localScale.x < 0.29f))
            {
                int score = 1000;
                scoreNumber -= score;

                StartCoroutine(penalite(0.05f));
                Combo = 1;
                timing.text = "-" + score.ToString();
            }
            else if (gameObject.transform.GetChild(0).transform.localScale.x < 0.25f)
            {
                int score = 1000 + 1000 * Combo;
                scoreNumber += score;
                timing.text = "+" + score.ToString()+ "  Precision:Max";
                //   scoreText.text = "Scorelol: " + scoreNumber;
                Debug.Log("testNsore");
                Combo++;
                N--;
                Debug.Log("testNsore1");

            }
            else if (gameObject.transform.GetChild(0).transform.localScale.x < 0.29f)
            {
                int score = 1000 * Combo;
                scoreNumber += score;
                timing.text = "+" + score.ToString()  +  "  Precision:Moy"; ;
                //   scoreText.text = "Scorelol: " + scoreNumber;

                Combo++;
                N--;

            }

            else
                StartCoroutine(penalite(0.05f));
            N = N < 0 ? 0 : N;
            //objectifN.text = " " + i;
        }
        else if (gameObject.name == "ML")
        {
            randomObjectif.timer = 0;
            //int i = Int32.Parse(objectifML.text);
            if (ML == 0 && (gameObject.transform.GetChild(0).transform.localScale.x > 0.29f)) // quand clic au mauvais moment
            {
                int score = 1000;
                scoreNumber -= score;
                timing.text = "-" + score.ToString();
                StartCoroutine(penalite(0.05f));
                Combo = 1;
            }
            else if (ML == 0 && (gameObject.transform.GetChild(0).transform.localScale.x < 0.29f)) // quand clic au mauvais moment
            {
                int score = 1000;
                scoreNumber -= score;
                timing.text = "-" + score.ToString();
                StartCoroutine(penalite(0.05f));
                Combo = 1;
            }
            else if (gameObject.transform.GetChild(0).transform.localScale.x < 0.25f ) // Quand clic au meilleur moment
            {
                int score = 1000 + 1000 * Combo;
                scoreNumber += score;
                timing.text = "+" + score.ToString() +  "  Precision:Max"; ;
                // scoreText.text = "Scorelol: " + scoreNumber;
                Combo++;
                ML--;
            }
            else if (gameObject.transform.GetChild(0).transform.localScale.x < 0.29f) // Quand clic au "bon" moment
            {
                {
                    int score = 1000 * Combo;
                    scoreNumber += score;
                    timing.text = "+" + score.ToString() + "  Precision:Moy"; ;
                    //   scoreText.text = "Scorelol: " + scoreNumber;
                    Combo++;
                    ML--;
                }

                ML = ML < 0 ? 0 : ML;
                //objectifML.text = " " + i;
            }
        }
        else if (gameObject.name == "reload")
        {
            randomObjectif.timer = 0;
            if (gameObject.transform.GetChild(0).transform.localScale.x > 0.25f)
            {
                Combo = 1;
                StartCoroutine(penalite(0.05f));
            }
            else if (gameObject.transform.GetChild(0).transform.localScale.x < 0.25f)
            {
                int score = 1000;
                scoreNumber -= score;
                timing.text = "-" + score.ToString() ;
                Combo = 1;
                StartCoroutine(penalite(0.05f));
            }
        }
            Debug.Log("testdz");
            Scoretext.text = scoreNumber.ToString();
            update_score(gameObject);
            Destroy(gameObject);
        


    }
}   
