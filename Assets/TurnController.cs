using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour {

	private GameObject cue;

	// Use this for initialization
	void Start () {
		cue = GameObject.Find ("Cue");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			cue.gameObject.SetActive (true);
		}
	}
}
