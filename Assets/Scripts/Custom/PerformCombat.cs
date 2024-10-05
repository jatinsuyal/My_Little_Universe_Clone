using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Collider weaponCollider;     // Assign the weapon's collider in the Inspector
    private Animator animator;          // Reference to the Animator

    private void Start()
    {
        // Find the Animator component on the player
        animator = GetComponent<Animator>();

        // Ensure the weapon collider is initially disabled
        weaponCollider.enabled = false;

    }

    // These methods will be called from Animation Events
    public void EnableWeaponCollider()
    {
        // Enable the weapon collider
        weaponCollider.enabled = true;
        Debug.Log("Weapon Collider Enabled and Upper Body Layer Weight Set to 1");
    }

    public void DisableWeaponCollider()
    {
        // Disable the weapon collider
        weaponCollider.enabled = false;
        Debug.Log("Weapon Collider Disabled and Upper Body Layer Weight Set to 0");
    }
}
