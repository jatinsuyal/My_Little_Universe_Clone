using UnityEngine;

public class Tree : ResourceBase
{
    public override void OnResourceCollected()
    {
        ResourceUI.Instance.UpdateResourceCount("Wood", resourcesPerHit);
        Debug.Log("Tree resource collected!");
        // Add specific logic for tree collection here
    }
}