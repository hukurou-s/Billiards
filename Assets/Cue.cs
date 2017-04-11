using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cue : MonoBehaviour {

	private float speed = -300.0f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Return)) {
			this.GetComponent<Rigidbody> ().AddForce (
				transform.up * speed,
				ForceMode.VelocityChange);
		}
	}

	void OnCollisionEnter(Collision collision) {
		if ( collision.gameObject.tag == "Ball" ) {
			Destroy(this.gameObject);
		}
	}
}
