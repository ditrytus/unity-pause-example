using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButtonHandler : MonoBehaviour {

	private PauseManager pauseManager;
	private Text uiText;
	private Button button;

	void Start()
	{
		pauseManager = new PauseManager();
		uiText = GetComponentInChildren<Text>();
		button = GetComponent<Button>();
		button.onClick.AddListener(OnClick);
	}

	void OnClick()
	{
		if(pauseManager.IsPaused)
		{
			pauseManager.Resume();
			uiText.text = "Pause";
		}
		else
		{
			pauseManager.Pause();
			uiText.text = "Resume";
		}
	}
}
