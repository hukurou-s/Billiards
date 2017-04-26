using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueBall : MonoBehaviour {


	private Vector3 StartPosition;
	private Quaternion StartRotation;
	private float speed = -400.0f;
	private float accel = 1000.0f;

	// Use this for initialization
	void Start () {
		StartPosition = this.transform.position;
		StartRotation = this.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 movedPosition = this.transform.position;

		if (Input.GetKey (KeyCode.W)) {
			movedPosition.z += 2f;
		} else if (Input.GetKey (KeyCode.S)) {
			movedPosition.z -= 2f;
		}
		if (Input.GetKey (KeyCode.A)) {
			movedPosition.x -= 2f;
		} else if (Input.GetKey (KeyCode.D)) {
			movedPosition.x += 2f;
		}

		this.transform.position = movedPosition;

		/*if ((Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.LeftAlt)) ||
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
		}*/

	}

	void OnCollisionEnter(Collision collision) {
		if ( collision.gameObject.tag == "Pocket" ) {
			this.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			this.transform.position = StartPosition;
			this.transform.rotation = StartRotation;
			this.gameObject.SetActive (false);
		}
	}
}
