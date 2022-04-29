using Leopotam.Ecs;
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField] private MovementSpeed movementSpeed;
    public EcsEntity Entity;

    public void CreateEntity(EcsWorld world) {
        Entity = world.NewEntity();

        ref var rigidbodyRef = ref Entity.Get<RigidbodyRef>();
        rigidbodyRef.Rigidbody = gameObject.GetComponent<Rigidbody>();

        ref var direction = ref Entity.Get<Direction>();
        direction.IsRight = true;

        ref var _movementSpeed = ref Entity.Get<MovementSpeed>();
        _movementSpeed.speed = movementSpeed.speed;
        
        Entity.Get<PlayerTag>();
    }
}
