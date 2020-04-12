using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Obstacle : MonoBehaviour {
	public static readonly string obstacleTag = "Obstacle";

	private void Start() {
		gameObject.tag = obstacleTag;
	}

	private void Reset(Vector3 position) {
		transform.position = position;
	}

	public class Pool : MonoMemoryPool<Vector3, Obstacle> {
		protected override void Reinitialize(Vector3 position, Obstacle obstacle) {
			obstacle.Reset(position);
		}
	}
}