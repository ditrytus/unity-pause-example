using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausableTime
{
    public static PausableTime Instance { get; private set; }

	static PausableTime()
	{
		Instance = new PausableTime();
	}

	public bool IsPaused { get; private set; }

	private float pauseTime = 0.0f;

	public float gapTime;

	public float Time
	{
		get
		{
			float result;
			if (IsPaused)
			{
				result = pauseTime;
			}
			else
			{
				result =  UnityEngine.Time.time - gapTime;
			}
			
			return result;
		}
	}

	public float DeltaTime
	{
		get
		{
			float result;
			if (IsPaused)
			{
				result = 0.0f;
			}
			else
			{
				result = UnityEngine.Time.deltaTime;
			}
			return result;
		}
	}

    public PausableTime()
	{
		IsPaused = false;
		gapTime = 0.0f;
	}

    public void Pause()
    {
        if (IsPaused)
		{
			return;
		}

		pauseTime = Time;

		IsPaused = true;
    }

    public void Resume()
    {
        if (!IsPaused)
		{
			return;
		}

		gapTime = UnityEngine.Time.time - pauseTime;

		IsPaused = false;
    }
}