using UnityEngine;
using System.Collections;

public class CamShakeSimple : MonoBehaviour 
{

	Vector3 originalCameraPosition;



	public GameObject mainCamera;
	/*
	void OnCollisionEnter2D(Collision2D coll) 
	{

		shakeAmt = coll.relativeVelocity.magnitude * .0025f;
		InvokeRepeating("CameraShake", 0, .01f);
		Invoke("StopShaking", 0.3f);

	}
	*/
	void start()
	{
		mainCamera = GameObject.FindGameObjectsWithTag ("MainCamera")[0];
		originalCameraPosition = mainCamera.transform.position;

	}

	void FixedUpdate()
	{

		RaycastHit2D hit;
		if (Input.GetMouseButtonDown(0)) {
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
			
			hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
			if (hit.collider != null) {

				if (hit.collider.gameObject.tag == "prefabs") {

					Debug.Log ("testclicshake");
					Invoke("CameraShake", 0.01f);
					Invoke("StopShaking", 0.3f);
					
				}
			}


		}

	}
	void OnMouseDown()
	{
		
		if (gameObject.name != null ) {
			Debug.Log ("testshake");

			//;


			//Invoke("StopShaking", 0.3f);
		}
	}
	void CameraShake()
	{
		
			float quakeAmt = Random.value*0.02f;
	//	Vector3 originale =  GameObject.FindGameObjectsWithTag ("MainCamera")[0].transform.position;
			Vector3 pp = mainCamera.transform.position;
			pp.y+= quakeAmt;
		pp.x+= quakeAmt;// can also add to x and/or z

		mainCamera.transform.position = pp;
		Debug.Log ("testshakefinal");
	//	mainCamera.transform.position = originale;
	}

	void StopShaking()
	{
		CancelInvoke("CameraShake");
		float x = 0f;
		float y = 0f;
		Vector3 pp = new Vector3 (0f, 0f, -10f);
	
		mainCamera.transform.position = pp;
	}

}