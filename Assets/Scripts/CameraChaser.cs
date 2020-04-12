using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class CameraChaser : MonoBehaviour {
	[SerializeField]
	private Vector3 bias;
	private Controller controller;

	[Inject]
	public void Construct(Controller controller) {
		this.controller = controller;
	}

	private void Update() {
		transform.position = Vector3.right * controller.GetPositionX() + bias;
	}
}
