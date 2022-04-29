using UnityEngine;
using Leopotam.Ecs;

public class Startup : MonoBehaviour
{
    [SerializeField] private Player player;
    private EcsSystems _systems;
    private EcsWorld _world;

    private void Start() {
        _world = new EcsWorld();
        _systems = new EcsSystems(_world)
            .Add(new InitAll())
            .Add(new PlayerMovement())
            .Inject(player);

        _systems.Init();
    }

    private void Update() {
        _systems.Run(); 
    }

    private void OnDestroy() {
        _systems.Destroy();
        _world.Destroy();
    }
}