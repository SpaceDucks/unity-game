﻿using UnityEngine;
//https://www.youtube.com/watch?v=HQNl3Ff2Lpo&list=PLPV2KyIb3jR4KLGCCAciWQ5qHudKtYeP7&index=5

public class ItemPickup : Interactable
{
    public Item item;
    
    public override void Interact()
    {
        base.Interact();
        PickUp();
    }

    void PickUp()
    {
        Debug.Log("Picking up " + item.name + ".");

        //Fix these lines or the Inventory object.
        //The objects are now destoyed but do not add to the inventory.

        //bool wasPickedUp = Inventory.instance.Add(item);
        // if (wasPickedUp)
        // {
        //     Destroy(gameObject);
        // }

        // Inventory.instance.Add(item);
        Destroy(gameObject);
    }
}
