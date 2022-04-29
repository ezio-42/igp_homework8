using Leopotam.Ecs;
using UnityEngine;

public class FallTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        var player = other.gameObject.GetComponent<Player>();
        player.Entity.Get<MovementSpeed>().speed = 0;
        
        Debug.Log("Fail");
    }
}
