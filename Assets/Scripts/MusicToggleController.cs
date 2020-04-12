using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MusicToggleController : MonoBehaviour {
	private AudioSource music;
	public bool isActive = true;
	private UIMenuManager uiMenuManager;

	[Inject]
	public void Construct(AudioSource music, UIMenuManager uiMenuManager) {
		this.music = music;
		this.uiMenuManager = uiMenuManager;
		uiMenuManager.SetMusicToggle(PlayerPrefs.GetInt(StringConstants.PREFS_MUSIC) == 0);
	}

	public void ChangeMusicActive() {
		isActive = !isActive;
		Debug.Log("" + isActive);
		music.enabled = isActive;
		PlayerPrefs.SetInt(StringConstants.PREFS_MUSIC, (isActive ? 0 : 1));
	}
}
