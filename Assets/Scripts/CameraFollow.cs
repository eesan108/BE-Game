using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;  // The player
    [SerializeField] private float smoothSpeed = 0.125f;
    [SerializeField] private Vector3 offset;    // (0, 0, -10) for 2D

    private void LateUpdate()
    {
        if (target == null) return;

        // Target position with offset
        Vector3 desiredPosition = target.position + offset;

        // Smooth movement
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Apply position, keeping Z fixed
        transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, desiredPosition.z);
    }
}
