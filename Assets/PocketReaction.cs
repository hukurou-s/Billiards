using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocketReaction : MonoBehaviour {

	private GameObject Child;
	private float TimeOut = 1.0f;
	private float TimeElapsed = 0.0f;

	// Use this for initialization
	void Start () {
		Child = transform.FindChild ("Sphere").gameObject;
		Child.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		TimeElapsed += Time.deltaTime;

		if(TimeElapsed >= TimeOut) {
			// Do anything
			Child.gameObject.SetActive (false);
		}
	}

	void OnCollisionEnter(Collision collision) {
		if ( collision.gameObject.tag == "Ball" ) {
			Child.gameObject.SetActive (true);
			TimeElapsed = 0.0f;
		}
	}
}
