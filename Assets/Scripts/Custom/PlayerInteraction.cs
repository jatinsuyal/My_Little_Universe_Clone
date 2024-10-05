using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        if (other.GetComponent<AreaUnlocker>() != null) 
        {
            AreaUnlocker areaUnlocker = other.GetComponent<AreaUnlocker>();
            areaUnlocker.TryUnlockArea(); // Try unlocking the area
            return; // Exit since we handled area unlocking
        }
    }
}
