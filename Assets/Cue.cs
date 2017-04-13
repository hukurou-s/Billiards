using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cue : MonoBehaviour {

	private float speed = -400.0f;
	private float accel = 1000.0f;
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

		if ( (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.LeftAlt) ) ||
			(Input.GetKey (KeyCode.RightShift) && Input.GetKey (KeyCode.RightAlt)) ) {
			this.GetComponent<Rigidbody> ().AddForce (
				transform.up * Input.GetAxisRaw ("Vertical") * accel,
				ForceMode.Impulse);
		} else if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift)) {
			
			this.gameObject.transform.Rotate(
				0,
				Input.GetAxis("Horizontal"),
				Input.GetAxis("Vertical"),
				Space.World
			);
		}

		this.GetComponent<Rigidbody> ().AddForce (
			transform.right * Input.GetAxisRaw ("Horizontal") * accel,
			ForceMode.Impulse);

		this.GetComponent<Rigidbody> ().AddForce (
			transform.forward * Input.GetAxisRaw ("Vertical") * accel,
			ForceMode.Impulse);
	}

	void OnCollisionEnter(Collision collision) {
		if ( collision.gameObject.tag == "Ball" ) {
			//Destroy(this.gameObject);
			//this.gameObject.SetActive(false);
		}
	}
}
