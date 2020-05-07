using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : TriggerSystem
{
    public Item item;
    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    {
        Debug.Log("Pickup " + item.name);
        bool wasPickedUp = Inventory.instance.Add(item);

        if (wasPickedUp)
        {
            Destroy(gameObject);
        }
        
    }
}
