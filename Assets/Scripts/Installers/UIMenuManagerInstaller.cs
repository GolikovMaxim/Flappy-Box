using UnityEngine;
using Zenject;

public class UIMenuManagerInstaller : MonoInstaller {
	[SerializeField]
	private GameObject uiMenuManager;

    public override void InstallBindings() {
    	Container.Bind<UIMenuManager>().To<CanvasUIMenuManager>().FromComponentInNewPrefab(uiMenuManager).AsSingle();
    }
}