using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.CompareTag ("Player")) {
			Destroy (gameObject);
		}
	}
}
