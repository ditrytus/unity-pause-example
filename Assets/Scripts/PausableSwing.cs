using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausableSwing : MonoBehaviour {

	private float startTime;
	private float startY;

	public float deviation = 1.0f;
	public float interval = 1.0f;
	
	void Start () {
		startTime = PausableTime.Instance.Time;
		startY = transform.position.y;
	}
	
	void Update ()
	{
		transform.position = new Vector3(
			transform.position.x,
			startY + Mathf.Sin(2 * Mathf.PI * (PausableTime.Instance.Time / interval)) * deviation,
			transform.position.z);
	}
}
