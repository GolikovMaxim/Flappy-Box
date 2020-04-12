using UnityEngine;
using Zenject;

public class MusicInstaller : MonoInstaller {
	[SerializeField]
	private GameObject musicPrefab;

    public override void InstallBindings() {
    	Container.Bind<AudioSource>().FromComponentInNewPrefab(musicPrefab).AsSingle().NonLazy();
    }
}