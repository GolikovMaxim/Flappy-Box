using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BoxHealth : MonoBehaviour {
	private Controller controller;
	private GameManager gameManager;

	[Inject]
	public void Construct(Controller controller, GameManager gameManager) {
		this.controller = controller;
		this.gameManager = gameManager;
	}

	public void OnTriggerEnter2D(Collider2D coll) {
		if(coll.tag == Obstacle.obstacleTag) {
			gameManager.IncreaseScore();
		}
	}

	public void OnCollisionEnter2D() {
		controller.TurnOff();
		gameManager.SetState(GameState.GameOver);
	}
}
