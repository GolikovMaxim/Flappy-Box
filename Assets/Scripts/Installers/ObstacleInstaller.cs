using UnityEngine;
using Zenject;

public class ObstacleInstaller : MonoInstaller<ObstacleInstaller> {
	[SerializeField]
	private GameObject obstaclePrefab;
	[SerializeField]
	private GameObject boxPrefab;

	public override void InstallBindings() {
		Container.Bind<Controller>().To<TapController>().FromComponentInNewPrefab(boxPrefab).AsSingle();
		Container.BindMemoryPool<Obstacle, Obstacle.Pool>().WithInitialSize(3).FromComponentInNewPrefab(obstaclePrefab);
	}
}