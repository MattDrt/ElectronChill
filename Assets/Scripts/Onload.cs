using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Onload : MonoBehaviour {

    public GameObject Prefab;
    Sprite Nsp;
    Sprite Lsp;
    Sprite MLsp;
    Sprite Leurresp;
	public float x;
	public float y;
	public bool posIsOk;
    public float speed = 2f;
   
    List<Sprite> listLetters = new List<Sprite>();
    float timer;
    float timeLimit;
    // Use this for initialization
    void Start () {
        Nsp = Resources.Load<Sprite>("Sprite/N");
        Lsp = Resources.Load<Sprite>("Sprite/L Letter");
        MLsp = Resources.Load<Sprite>("Sprite/ML");
        Leurresp = Resources.Load<Sprite>("Sprite/reload");
		x = generateX ();
		y = generateY ();
        timer = 0;
        timeLimit = 0.5f;


       listLetters.Add(Nsp);
       listLetters.Add(Lsp);
       listLetters.Add(MLsp);
       listLetters.Add(Leurresp);

	   AudioProcessor processor = FindObjectOfType<AudioProcessor> ();
	   processor.onBeat.AddListener (onOnbeatDetected);
	   processor.onSpectrum.AddListener (onSpectrum);
    }

    // Update is called once per frame
    void Update () {
        /*int rdmgenLetter = Random.Range(0, 4);
        timer += Time.deltaTime;
        if (timer >= timeLimit)
        {
            timer = 0.0f;
            resetSize(listLetters[rdmgenLetter]);
        }*/
	
		if (objectFound (new Vector3 (x, y, 0), 0.3f) == 1) {
			x = generateX ();
			y = generateY ();
			posIsOk = false;
		} else
			posIsOk = true;
			

    }

	void onOnbeatDetected ()
	{
		int rdmgenLetter = Random.Range(0, 4);
	
		resetSize(listLetters[rdmgenLetter]);
	}

	int objectFound(Vector3 center, float radius)
	{
		
		Collider2D[] hitColliders = Physics2D.OverlapCircleAll(center, radius);
		int i = 0;
		while (i < hitColliders.Length)
		{

			i++;
		}
		if (i != 0)
			return 1;
		else
			return 0;
	}
	void onSpectrum (float[] spectrum)
	{
		//The spectrum is logarithmically averaged
		//to 12 bands

		for (int i = 0; i < spectrum.Length; ++i) {
			Vector3 start = new Vector3 (i, 0, 0);
			Vector3 end = new Vector3 (i, spectrum [i], 0);
			Debug.DrawLine (start, end);
		}
	}
    void resetSize(Sprite sp)
    {
        
        
		if (posIsOk== true) {
			GameObject clone = Instantiate (Prefab, new Vector3 (x, y, 0), Quaternion.identity) as GameObject;
			clone.transform.GetComponent<SpriteRenderer> ().sprite = sp;
			clone.transform.name = sp.name.ToString ();
			clone.transform.GetComponent<Onload> ().enabled = false;
			clone.transform.GetComponent<Renderer> ().enabled = true;
			clone.transform.GetComponent<Renderer> ().sortingOrder = 2;
			clone.transform.GetChild (0).GetComponent<Renderer> ().enabled = true;
			clone.transform.GetChild (0).transform.localScale = Vector2.one * 0.40f;
			StartCoroutine (Breath (clone, speed));
			StartCoroutine (FadeToGen (clone, 0f, speed * 2));
		}

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
    IEnumerator FadeToGen(GameObject obj, float aValue, float aTime)
    {
        float alpha2 = obj.transform.GetChild(0).GetComponent<Renderer>().material.color.a;
        float alpha = obj.transform.GetComponent<Renderer>().material.color.a;
   

        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
            {

    

            Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha, aValue, t));
            Color newColor2 = new Color(1, 1, 1, Mathf.Lerp(alpha2, aValue, t));

                if (obj != null)
            {
                float _currentScale = obj.transform.GetChild(0).transform.localScale.x;

                if (_currentScale < 0.29f )
                    newColor2 = new Color(0, 255, 0, Mathf.Lerp(alpha2, aValue, t));
                else
                    newColor2 = new Color(255, 0, 0, Mathf.Lerp(alpha2, aValue, t));

                obj.transform.GetChild(0).transform.GetComponent<Renderer>().material.color = newColor2;

                obj.transform.GetChild(0).transform.GetComponent<SpriteRenderer>().color = newColor2;
                obj.transform.GetComponent<Renderer>().material.color = newColor;
            }
                yield return null;
            }
       
    }
    public IEnumerator Breath(GameObject obj, float time)
    {
        Vector2 originalScale = obj.transform.GetChild(0).transform.localScale;
        Vector2 destinationScale = new Vector2(0.20f, 0.20f);
        float _currentScale = obj.transform.GetChild(0).transform.localScale.x;

        float currentTime = 0.0f;

        do
        {
            if(obj!=null)
            _currentScale = obj.transform.GetChild(0).transform.localScale.x;
            if (obj != null && _currentScale > 0.25f)
                obj.transform.GetChild(0).transform.localScale = Vector3.Lerp(originalScale, destinationScale, currentTime / time);
    

            currentTime += Time.deltaTime;
            yield return null;
        } while (currentTime <= time);
        if (obj != null)
        {
            Destroy(obj);

        }

    }
}
