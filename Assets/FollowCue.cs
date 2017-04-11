using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCue : MonoBehaviour {

	public Transform target;    // ターゲットへの参照

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// 自分の座標にtargetの座標を代入する     
		GetComponent<Transform>().position = target.position;
		GetComponent<Transform>().rotation = Quaternion.Euler(0, -90, 0);
	}
}
