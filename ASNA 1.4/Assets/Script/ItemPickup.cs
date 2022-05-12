using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;
    public ParticleSystem efek;

    public override void Interact()
    {
        base.Interact();

        Pickup();
    }

    void Pickup()
    {
        //animation
       

        // Add to inventory
        Debug.Log("Picking Up " + item.name);
        bool wasPicked = Inventory.instance.Add(item);
        // Destroy Game Object
        if (wasPicked)
        {
            Destroy(gameObject);
            Smoke();
        }
    }

    public void Smoke()
    {
        efek.Play();
    }
}
