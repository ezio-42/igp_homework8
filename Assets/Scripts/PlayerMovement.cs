using Leopotam.Ecs;
using UnityEngine;

public class PlayerMovement : IEcsRunSystem {
    private EcsFilter<RigidbodyRef, Direction, MovementSpeed, PlayerTag> _filter;


    public void Run() {
        foreach (var i in _filter) {
            ref var direction = ref _filter.Get2(i);

            if (Input.GetMouseButtonDown(0)) {
                direction.IsRight = !direction.IsRight;
            }

            ref var movementSpeed = ref _filter.Get3(i);
            ref var rigidbodyRef = ref _filter.Get1(i);

            var velocity = direction.IsRight ? Vector3.forward : Vector3.right;
            velocity *=  movementSpeed.speed;
            velocity.y = rigidbodyRef.Rigidbody.velocity.y;
            rigidbodyRef.Rigidbody.velocity = velocity;
        }
    }
}