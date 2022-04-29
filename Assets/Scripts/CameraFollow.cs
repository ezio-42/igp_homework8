using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform follow;

    private Vector3 _offsetFromFollowToCamera;
    private float _initialY;

    private void Awake() {
        _offsetFromFollowToCamera = transform.position - follow.position;
        _initialY = transform.position.y;
    }

    private void LateUpdate() {
        var position = follow.position + _offsetFromFollowToCamera;
        position.y = _initialY;
        transform.position = position;
    }
}