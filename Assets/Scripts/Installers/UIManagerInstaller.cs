using UnityEngine;
using Zenject;

public class UIManagerInstaller : MonoInstaller {
	[SerializeField]
	private GameObject uiManager;

    public override void InstallBindings() {
    	Container.Bind<UIManager>().To<CanvasUIManager>().FromComponentInNewPrefab(uiManager).AsSingle();
    }
}