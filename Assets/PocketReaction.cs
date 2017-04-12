using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocketReaction : MonoBehaviour {


	private GameObject Child;

	// Use this for initialization
	void Start () {
		Child = transform.FindChild ("Sphere").gameObject;
		Child.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision) {
		if ( collision.gameObject.tag == "Ball" ) {
			Child.gameObject.SetActive (true);
		}
	}
}
