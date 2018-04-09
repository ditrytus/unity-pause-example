
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausableSpinner : MonoBehaviour {
	
	public float speed = 180.0f;

	void Update () {
		var delta = PausableTime.Instance.DeltaTime;
		transform.Rotate(delta * speed, delta * speed, delta * speed);	
	}
}