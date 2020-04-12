using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MenuStateButtonController : MonoBehaviour {
	private MenuManager menuManager;
	[SerializeField]
	private MenuState menuState;

	[Inject]
	public void Construct(MenuManager menuManager) {
		this.menuManager = menuManager;
	}

	public void SetMenuManagerState() {
		menuManager.SetState(menuState);
	}
}
