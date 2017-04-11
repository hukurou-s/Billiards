using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CangeCamera : MonoBehaviour {

	public Camera MainCam;
	public Camera SubCam;

	// Use this for initialization
	void Start () {
		//MainCam = GameObject.Find ("Main Camera").GetComponent<Camera>();
		//MainCam = GameObject.Find("Main Camera");
		//SubCam = GameObject.Find ("Sub Camera").GetComponent<Camera>();
		//SubCam = GameObject.Find("SubCamera");

		SubCam.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space")){
			if(MainCam.enabled){
				MainCam.enabled = false;
				SubCam.enabled = true;
			}else{
				MainCam.enabled = true;
				SubCam.enabled = false;
			}
		}
	}
}
