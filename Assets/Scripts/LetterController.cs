using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterController : MonoBehaviour {
    public GameObject Prefab;
    // public GameObject PrefabN;
    //public GameObject PrefabML;
    //public GameObject PrefabLeurre;
    List<GameObject> listLetters = new List<GameObject>();
    float timer;
    float timeLimit;
    // Use this for initialization
    void Start()
    {



        timer = 0;
        timeLimit = 1f;


        listLetters.Add(Prefab);
        // listLetters.Add(PrefabN);
        //  listLetters.Add(PrefabML);
        // listLetters.Add(PrefabLeurre);
    }

    // Update is called once per frame
    void Update()
    {
        int rdmgenLetter = Random.Range(0, 1);
        timer += Time.deltaTime;
        if (timer >= timeLimit)
        {
            timer = 0.0f;
            resetSize(listLetters[rdmgenLetter]);
        }

    }
    void resetSize(GameObject test)
    {

        float x = generateX();
        float y = generateY();
        GameObject clone = Instantiate(test, new Vector3(x, y, 0), Quaternion.identity) as GameObject;
        clone.transform.GetComponent<Onload>().enabled = false;
        clone.transform.GetComponent<Renderer>().enabled = true;
        clone.transform.GetComponent<Renderer>().sortingOrder = 2;
        clone.transform.GetChild(0).GetComponent<Renderer>().enabled = true;
        clone.transform.GetChild(0).transform.localScale = Vector2.one * 0.40f;
        StartCoroutine(Breath(clone, 2f));

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
    public IEnumerator Breath(GameObject obj, float time)
    {
        Vector2 originalScale = obj.transform.GetChild(0).transform.localScale;
        Vector2 destinationScale = new Vector2(0.15f, 0.15f);
        float _currentScale = obj.transform.GetChild(0).transform.localScale.x;

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
}