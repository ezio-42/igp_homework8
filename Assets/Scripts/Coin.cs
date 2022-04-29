using UnityEngine;

public class Coin : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        var playerMovement = other.GetComponent<Player>();
        if (playerMovement == null) return;
        
        var coinCounter = other.GetComponent<Counter>();
        if (coinCounter == null) return;

        coinCounter.Increment();

        Debug.LogFormat("Coin was collected, total count = {0}", coinCounter.GetCount());
        Destroy(gameObject);
    }
}