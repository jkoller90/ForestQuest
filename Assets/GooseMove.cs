﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooseMove : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * 9);
		transform.Rotate (Vector3.up * Time.deltaTime * 60);
	}
}
