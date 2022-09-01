using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObj : Interactable
{
    public GameObject obj;

    public override void Interact()
    {
        base.Interact();


        Activate();
    }

    void Activate()
    {
        //Destroy(gameObject);
        obj.SetActive(true);
    }
}
