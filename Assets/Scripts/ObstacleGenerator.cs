using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ObstacleGenerator : MonoBehaviour {
	[SerializeField]
	private float obstacleDelta;
	[SerializeField]
	private float minY;
	[SerializeField]
	private float maxY;
	private float lastObstacle = 0;
	private Obstacle.Pool obstaclePool;
	private Controller controller;
	private LinkedList<Obstacle> obstacles = new LinkedList<Obstacle>();

	[Inject]
	public void Construct(Obstacle.Pool obstaclePool, Controller controller) {
		this.obstaclePool = obstaclePool;
		this.controller = controller;
	}

	private void Update() {
		if(controller.GetPositionX() > lastObstacle) {
			lastObstacle += obstacleDelta;
			AddObstacle(new Vector3(lastObstacle, Random.value * (maxY - minY) + minY, 0));
		}
	}

	private void AddObstacle(Vector3 position) {
		obstacles.AddLast(obstaclePool.Spawn(position));
	}

	private void RemoveObstacle() {
		Obstacle obstacle = obstacles.First.Value;
		obstaclePool.Despawn(obstacle);
		obstacles.RemoveFirst();
	}
}
