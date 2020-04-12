using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public enum GameState {
	Game,
	Pause,
	GameOver
}

public interface GameManager {
	void IncreaseScore();
	void SetState(GameState gameState);
	GameState GetState();
}

public class BoxGameManager : GameManager {
	private UIManager uiManager;
	private int score = 0;
	private GameState gameState = GameState.Game;

	[Inject]
	public void Construct(UIManager uiManager) {
		this.uiManager = uiManager;
		SetState(gameState);
	}

	public void IncreaseScore() {
		score++;
		uiManager.ShowScore(score);
	}

	public void SetState(GameState gameState) {
		this.gameState = gameState;
		switch(gameState) {
			case GameState.Game: 
				Time.timeScale = 1;
				break;
			case GameState.Pause:
				Time.timeScale = 0;
				break;
			case GameState.GameOver: {
				Time.timeScale = 1;
				int topScore = PlayerPrefs.GetInt(StringConstants.PREFS_TOPSCORE);
				if(topScore < score) {
					PlayerPrefs.SetInt(StringConstants.PREFS_TOPSCORE, score);
					topScore = score;
				}
				uiManager.ShowFinalScore(score);
				uiManager.ShowTopScore(topScore);
				break;
			}
		}
		uiManager.SetState(gameState);
	}

	public GameState GetState() {
		return gameState;
	}
}
