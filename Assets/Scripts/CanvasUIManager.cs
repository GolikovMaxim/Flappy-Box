using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface UIManager {
	void ShowScore(int score);
	void SetState(GameState gameState);
	void ShowFinalScore(int score);
	void ShowTopScore(int score);
}

public class CanvasUIManager : MonoBehaviour, UIManager {
	[SerializeField]
	private Text scoreUI;
	[SerializeField]
	private Text finalScoreUI;
	[SerializeField]
	private Text topScoreUI;
	[SerializeField]
	private GameObject[] uiStates;
	private GameState gameState;

	public void ShowScore(int score) {
		scoreUI.text = "" + score;
	}

	public void ShowFinalScore(int score) {
		finalScoreUI.text = "" + score;
	}

	public void ShowTopScore(int score) {
		topScoreUI.text = "" + score;
	}

	public void SetState(GameState gameState) {
		uiStates[(int)this.gameState].SetActive(false);
		this.gameState = gameState;
		uiStates[(int)this.gameState].SetActive(true);
	}
}
