﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//this.GetComponent<Rigidbody> ().AddForce (
		//	transform.right * speed,
		//	ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision) {
		if ( collision.gameObject.tag == "Pocket" ) {
			this.gameObject.SetActive (false);
		}
	}
}
