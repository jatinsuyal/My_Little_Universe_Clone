using System.Collections;
using UnityEngine;

public abstract class ResourceBase : MonoBehaviour
{
    public string resourceName;
    public int health;               // Number of hits required to collect the resource
    public int resourcesPerHit;      // Resources earned per hit
    public float regrowthTime;       // Time it takes for the resource to regrow after being collected
    public bool isAvailable = true;

    public AudioClip collectAudioClip; // Audio clip to play when the resource is collected
    public AudioSource audioSource; // Audio source for playing sound

    private Collider resourceCollider; // Reference to the collider
    private MeshRenderer meshRenderer; // Reference to the mesh renderer
    private int initialHealth;


    private void Awake()
    {
        // Get references to the collider and mesh renderer
        resourceCollider = GetComponent<Collider>();
        meshRenderer = GetComponent<MeshRenderer>();
        initialHealth = health;
    }

    // Call this method when the player interacts with the resource (e.g., on hit)
    public virtual void CollectResource(int val)
    {
        Debug.Log("Collect resource");
        if (isAvailable)
        {
            // Add resources to player's resource count before reducing health
            AddResource();

            PlayCollectAudio();

           // health--;
            health = health - val;

            // If health reaches zero, trigger regrowth
            if (health <= 0)
            {
                StartCoroutine(Regrow());
                isAvailable = false;
            }
        }
    }

    // Method to handle adding resources per hit
    private void AddResource()
    {
        // Use the ResourceUI or ResourceManager to update the player's resources
        ResourceUI.Instance.UpdateResourceCount(resourceName, resourcesPerHit);
        Debug.Log($"{resourcesPerHit} {resourceName} collected!"); // Feedback for debugging
    }

    // Method to play the collect audio clip
    private void PlayCollectAudio()
    {
        if (collectAudioClip != null && audioSource != null)
        {
            audioSource.PlayOneShot(collectAudioClip); // Play audio when resource is collected
        }
    }

    // Coroutine to handle resource regrowth after being collected
    private IEnumerator Regrow()
    {
        // Disable the collider and mesh renderer while regrowing
        resourceCollider.enabled = false;
        meshRenderer.enabled = false;

        yield return new WaitForSeconds(regrowthTime);

        // Reset health and re-enable the resource
        health = initialHealth;
        isAvailable = true;

        // Re-enable the collider and mesh renderer after regrowth
        resourceCollider.enabled = true;
        meshRenderer.enabled = true;

        Debug.Log($"{resourceName} has regrown!");
    }

    // Abstract method that can be implemented differently for each resource type (e.g., wood, stone)
    public abstract void OnResourceCollected();
}
