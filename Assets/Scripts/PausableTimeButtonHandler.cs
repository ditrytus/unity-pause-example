using UnityEngine;
using UnityEngine.UI;

public class PausableTimeButtonHandler : MonoBehaviour {

	private Text uiText;

	void Start()
	{
		uiText = GetComponentInChildren<Text>();
		GetComponent<Button>().onClick.AddListener(OnClick);
	}

	void OnClick()
	{
		if(PausableTime.Instance.IsPaused)
		{
			PausableTime.Instance.Resume();
			uiText.text = "Pause";
		}
		else
		{
			PausableTime.Instance.Pause();
			uiText.text = "Resume";
		}
	}
}
