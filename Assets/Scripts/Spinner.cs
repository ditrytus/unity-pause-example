
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour {
	
	public float speed = 180.0f;
	
	void Update () {
		transform.Rotate(Time.deltaTime * speed, Time.deltaTime * speed, Time.deltaTime * speed);	
	}
}