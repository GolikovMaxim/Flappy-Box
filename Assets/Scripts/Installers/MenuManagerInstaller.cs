using UnityEngine;
using Zenject;

public class MenuManagerInstaller : MonoInstaller {
    public override void InstallBindings() {
    	Container.Bind<MenuManager>().To<BoxMenuManager>().AsSingle().NonLazy();
    }
}