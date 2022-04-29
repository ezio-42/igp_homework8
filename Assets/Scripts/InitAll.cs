using Leopotam.Ecs;
using UnityEngine;

public class InitAll : IEcsInitSystem
{
    private Player _player;
    private EcsWorld _world;

    public void Init() {
        _player.CreateEntity(_world);
        Debug.Log("Init called");
    }
}