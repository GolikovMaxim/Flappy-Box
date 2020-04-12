using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public interface Controller {
	void TurnOff();
	float GetPositionX();
}

public class TapController : MonoBehaviour, Controller {
	[SerializeField]
	private float tapImpulse;
	[SerializeField]
	private float horizontalSpeed;
	[SerializeField]
	private float topPadding;
	private Rigidbody2D rb2D;
	private GameManager gameManager;

	[Inject]
	public void Construct(GameManager gameManager) {
		this.gameManager = gameManager;
	} 

	private void Start() {
		rb2D = GetComponent<Rigidbody2D>();
		rb2D.AddForce(Vector2.right * horizontalSpeed, ForceMode2D.Impulse);
	}

	private void Update() {
		if(Input.GetMouseButtonDown(0) && Input.mousePosition.y < (1 - topPadding) * Screen.height && gameManager.GetState() == GameState.Game) {
			rb2D.AddForce(Vector2.up * tapImpulse, ForceMode2D.Impulse);
		}
	}

	public float GetPositionX() {
		return transform.position.x;
	}

	public void TurnOff() {
		enabled = false;
	}
}
