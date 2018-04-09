﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour {
	
	public float speed = 180.0f;
	
	void Update () {
		var delta = Time.deltaTime;
		transform.Rotate(delta * speed, delta * speed, delta * speed);	
	}
}