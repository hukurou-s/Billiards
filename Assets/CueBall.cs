using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueBall : MonoBehaviour {

	private float speed = -300.0f;
	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody> ().AddForce (
			transform.right * speed,
			ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
