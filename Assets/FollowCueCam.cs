using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCueCam : MonoBehaviour {

	public Transform target;    // ターゲットへの参照
	private Vector3 RelativeDistance;
	//private float RotationX;

	// Use this for initialization
	void Start () {
		RelativeDistance = GetComponent<Transform>().position - target.position;
		//RotationX = GetComponent<Transform> ().rotation.x;
	}
	
	// Update is called once per frame
	void Update () {
		// 自分の座標にtargetの座標を代入する     
		GetComponent<Transform>().position = target.position + RelativeDistance;
		GetComponent<Transform>().rotation = Quaternion.Euler(15, -90, 0);
	}
}
