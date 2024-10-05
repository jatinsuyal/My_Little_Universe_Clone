using UnityEngine;

public class WeaponInteraction : MonoBehaviour
{
    public WeaponStats weaponStats;  // Reference to the weapon ScriptableObject

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object we collided with is tagged as "Resource"
        if (other.CompareTag("Resource"))
        {
            // Try to get the ResourceBase component from the object
            ResourceBase resource = other.GetComponent<ResourceBase>();

            if (resource != null && resource.isAvailable)
            {
                Debug.Log($"{weaponStats.weaponName} interacting with resource");

                // Call CollectResource() on the resource with the weapon's base damage
                resource.CollectResource(weaponStats.baseDamage);
            }
        }
    }
}
