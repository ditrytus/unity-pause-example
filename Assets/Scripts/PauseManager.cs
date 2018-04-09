using UnityEngine;

public class PauseManager
{
	public bool IsPaused { get; private set;}

	public PauseManager()
	{
		Resume();
	}
	
	public void Pause()	
	{
		Time.timeScale = 0.0f;
		IsPaused = true;
	}

	public void Resume()
	{
		Time.timeScale = 1.0f;
		IsPaused = false;
	}
}
