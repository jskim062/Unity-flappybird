using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.SetResolution (480, 800, false);
	}
	
	// Update is called once per frame


	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
			gameObject.GetComponent<Rigidbody> ().AddForce (0, 300, 0);
		}


	
	}
	void OnCollisionEnter(Collision coll)
	{
		Application.LoadLevel ("Die");
		Time.timeScale = 0;
	}


}

