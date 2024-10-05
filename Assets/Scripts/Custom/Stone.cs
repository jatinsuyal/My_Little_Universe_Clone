using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Stone : ResourceBase
{
    public override void OnResourceCollected()
    {
        ResourceUI.Instance.UpdateResourceCount("Stone", resourcesPerHit);
        Debug.Log("Stone resource collected!");
        // Add specific logic for stone collection here
    }
}
