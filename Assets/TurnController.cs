﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour {

	//public int ballMoveFlag = 0;    // 0ならボールは操作できない
	//public int cueMoveFlag = 1;    // 0ならCueは操作できない
	private GameObject cue;
	private GameObject cueBall;

	// Use this for initialization
	void Start () {
		cue = GameObject.Find ("Cue");
		cueBall = GameObject.Find ("cue ball");
	}
	
	// Update is called once per frame
	void Update () {



		if (Input.GetKey (KeyCode.N)) {

			if (!cueBall.gameObject.activeSelf) {
				cueBall.gameObject.SetActive (true);
			} else {

				cue.gameObject.SetActive (true);
			}
		}
	}
}
