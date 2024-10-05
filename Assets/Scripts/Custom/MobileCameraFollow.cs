using UnityEngine;

public class SimpleMobileCameraFollow : MonoBehaviour
{
    public Transform player;            // The target to follow (the player)
    public Vector3 offset;              // Camera's offset relative to the player
    public float smoothSpeed = 0.125f;  // Smoothing factor for camera movement

    private void LateUpdate()
    {
        // Determine the desired position based on player's position and the offset
        Vector3 desiredPosition = player.position + offset;

        // Smoothly interpolate between the current position and the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Update the camera's position
        transform.position = smoothedPosition;
    }
}
