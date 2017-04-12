using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCueRazer : MonoBehaviour {

	public Transform target;    // ターゲットへの参照
	private Vector3 RelativeDistance;

	// Use this for initialization
	void Start () {
		RelativeDistance = GetComponent<Transform>().position - target.position;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Transform>().position = target.position + RelativeDistance;
		GetComponent<Transform>().rotation = Quaternion.Euler(0, -90, 0);

		if (Input.GetKeyDown (KeyCode.Return)) {
			this.gameObject.SetActive(false);
		}
	}
}
