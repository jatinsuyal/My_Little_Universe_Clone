using UnityEngine;

[CreateAssetMenu(fileName = "NewWeaponStats", menuName = "Weapons/WeaponStats")]
public class WeaponStats : ScriptableObject
{
    [Header("Weapon Properties")]
    public string weaponName;      // Name of the weapon
    public int baseDamage = 1;     // Initial damage of the weapon
    public int currentLevel = 1;   // Current level of the weapon
    public int maxLevel = 5;       // Maximum upgrade level for the weapon
    public int upgradeIncrement = 1; // Amount of damage increased with each upgrade

    [Header("Weapon Effects")]
    public AudioClip attackSound;  // Sound played when attacking with the weapon

    // Method to upgrade the weapon
    public void UpgradeWeapon()
    {
        if (currentLevel < maxLevel)
        {
            currentLevel++;
            baseDamage += upgradeIncrement; // Increase damage by a whole number
            Debug.Log($"{weaponName} upgraded to level {currentLevel}. New damage: {baseDamage}");
        }
        else
        {
            Debug.Log($"{weaponName} has reached the maximum level!");
        }
    }
}
