using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public enum MenuState {
	Main,
	Score,
	Settings
}

public interface MenuManager {
	void SetState(MenuState menuState);
}

public class BoxMenuManager : MenuManager {
	private UIMenuManager uiMenuManager;
	private MenuState menuState = MenuState.Main;

	[Inject]
	public void Construct(UIMenuManager uiMenuManager) {
		this.uiMenuManager = uiMenuManager;
		SetState(menuState);
	}

	public void SetState(MenuState menuState) {
		this.menuState = menuState;
		switch(menuState) {
			case MenuState.Main:
				break;
			case MenuState.Score:
				uiMenuManager.ShowTopScore(PlayerPrefs.GetInt(StringConstants.PREFS_TOPSCORE));
				break;
			case MenuState.Settings:
				break;
		}
		uiMenuManager.SetState(menuState);
	}
}
