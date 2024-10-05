using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    private Camera mainCamera;

    private void Start()
    {
        // Find the main camera in the scene
        mainCamera = Camera.main;
    }

    private void LateUpdate()
    {
        // Make the canvas face the camera by adjusting the rotation
        if (mainCamera != null)
        {
            // Rotate the canvas to look at the camera
            transform.LookAt(mainCamera.transform);
            // Optionally, reverse the canvas direction to avoid flipping
            transform.Rotate(0, 180, 0);
        }
    }
}
