using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Rigidbody rb;
	public float speed;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
		float x, y;
		x = Input.GetAxis ("Horizontal");
		y = Input.GetAxis ("Vertical");

		rb.AddForce(new Vector3(x, 0, y) * speed);
	}
}
