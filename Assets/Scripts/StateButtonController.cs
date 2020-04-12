using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class StateButtonController : MonoBehaviour {
	private GameManager gameManager;
	[SerializeField]
	private GameState gameState;

	[Inject]
	public void Construct(GameManager gameManager) {
		this.gameManager = gameManager;
	}

	public void SetGameManagerState() {
		gameManager.SetState(gameState);
	}
}
