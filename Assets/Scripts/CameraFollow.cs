using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform player;
	Vector3 offset;

	void Start () {
		offset = transform.position - player.transform.position;
	}

	void Update () {
		Vector3 tempPos = player.transform.position + offset;
		transform.position = tempPos;
	}
}
