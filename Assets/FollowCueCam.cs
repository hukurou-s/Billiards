using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCueCam : MonoBehaviour {

	public Transform target;    // ターゲットへの参照
	private Vector3 RelativeDistance;

	// Use this for initialization
	void Start () {
		RelativeDistance = GetComponent<Transform>().position - target.position;
		RelativeDistance.x = 0; RelativeDistance.z = 0;
	}
	
	// Update is called once per frame
	void Update () {
		// 自分の座標にtargetの座標を代入する
		GetComponent<Transform>().position = target.position + RelativeDistance;
		GetComponent<Transform> ().rotation = Quaternion.Euler(target.transform.localEulerAngles.x+15+90 , target.transform.localEulerAngles.y, target.transform.localEulerAngles.z);//target.rotation + RelativeRotation;
		//Quaternion.Euler(15+target.rotation.x , -90+target.rotation.y, 0+target.rotation.z);

	}
}
