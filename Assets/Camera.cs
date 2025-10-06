using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target;     // your player
    public float smoothTime = 0.1f;
    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (!target) return;
        // Camera always stays at z = -10 so it sees the scene
        Vector3 goal = new Vector3(target.position.x, target.position.y, -10f);
        transform.position = Vector3.SmoothDamp(transform.position, goal, ref velocity, smoothTime);
    }
}

