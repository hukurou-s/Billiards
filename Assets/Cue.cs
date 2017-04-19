using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cue : MonoBehaviour {

	private float speed = -400.0f;
	private float accel = 1000.0f;
	private Vector3 StartPosition;
	private Quaternion StartRotation;


	void Start () {
		StartPosition = this.transform.position;
		StartRotation = this.transform.rotation;
		//GetComponent<Transform> ().rotation = Quaternion.Euler(target.transform.localEulerAngles.x+15+90 , target.transform.localEulerAngles.y, target.transform.localEulerAngles.z);
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.R)) {
			this.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			this.transform.position = StartPosition;
			this.transform.rotation = StartRotation;
		}

		if (Input.GetKeyUp (KeyCode.Return)) {
			this.GetComponent<Rigidbody> ().AddForce (
				transform.up * speed,
				ForceMode.VelocityChange);
		}

		if ((Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.LeftAlt)) ||
		    (Input.GetKey (KeyCode.RightShift) && Input.GetKey (KeyCode.RightAlt))) {
			this.GetComponent<Rigidbody> ().AddForce (
				transform.up * Input.GetAxisRaw ("Vertical") * (accel * -1),
				ForceMode.Impulse);
		} else if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift)) {
			
			this.gameObject.transform.Rotate (
				0,
				Input.GetAxis ("Horizontal"),
				Input.GetAxis ("Vertical")* -1,
				Space.World
			);
		} else {

			this.GetComponent<Rigidbody> ().AddForce (
				transform.right * Input.GetAxisRaw ("Horizontal") * accel,
				ForceMode.Impulse);

			this.GetComponent<Rigidbody> ().AddForce (
				transform.forward * Input.GetAxisRaw ("Vertical") * accel,
				ForceMode.Impulse);
		}

	}

	void OnCollisionEnter(Collision collision) {
		if ( collision.gameObject.tag == "Ball" ) {
			this.gameObject.SetActive (false);

		}
	}
}
