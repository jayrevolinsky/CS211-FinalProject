using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSystem : MonoBehaviour
{
    public float radius = 3f;
    public Transform triggerTransform;

    bool isTrigger = false;
    Transform player;

    bool hasInteracted = false;

    public virtual void Interact()
    {
        //Interact code
        Debug.Log("Triggered on" + transform.name);
    }
    public void Update()
    {
        if (isTrigger && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, triggerTransform.position);

            if (distance <= radius)
            {
                Interact();
                hasInteracted = true;
            }
        }
    }
    public void OnFocused(Transform playerTransform)
    {
        isTrigger = true;
        player = playerTransform;
        hasInteracted = false;
    }

    public void OnDefocused()
    {
        isTrigger = false;
        player = null;
        hasInteracted = false;
    }
    void OnDrawGizmosSelected()
    {
        if (triggerTransform == null)
        {
            triggerTransform = transform;
        }
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(triggerTransform.position, radius);
    }
}
