﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameReset : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.CompareTag("Player")) {
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
