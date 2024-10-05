using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    public Transform playerTransform;  // Reference to the player's transform
    public Transform defaultPositionTransform;  // The transform of the default position

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerTransform.position = defaultPositionTransform.position;
        }
    }
}
