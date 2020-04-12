using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface UIMenuManager {
	void SetState(MenuState menuState);
	void ShowTopScore(int score);
	void SetMusicToggle(bool isOn);
}

public class CanvasUIMenuManager : MonoBehaviour, UIMenuManager {
	[SerializeField]
	private Text topScoreUI;
	[SerializeField]
	private Toggle musicToggleUI;
	[SerializeField]
	private GameObject[] uiStates;
	private MenuState menuState;

	public void ShowTopScore(int score) {
		topScoreUI.text = "" + score;
	}

	public void SetState(MenuState menuState) {
		uiStates[(int)this.menuState].SetActive(false);
		this.menuState = menuState;
		uiStates[(int)this.menuState].SetActive(true);
	}

	public void SetMusicToggle(bool isOn) {
		musicToggleUI.isOn = isOn;
	}
}
