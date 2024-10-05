using UnityEngine;

[CreateAssetMenu(fileName = "NewResource", menuName = "Resources/New Resource")]
public class ResourceType : ScriptableObject
{
    public string resourceName;
    public int health;
    public int resourcesPerHit;
    public float regrowthTime;
}


