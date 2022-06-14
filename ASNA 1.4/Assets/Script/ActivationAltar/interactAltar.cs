using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactAltar : Interactable
{
    public Item item;
    public int neededAmount;

    public Transform spawnPoint;
    public GameObject Prefab;

    public ParticleSystem collectParticle;
    public int effectSpawn;

    public Transform Spawn;
    public Transform ApsaraRelic;
    public GameObject spawnvfx;
    public GameObject Apsara;

    public GameObject LvManager;
    //public Animator anim;
    public GameObject colCutscene;

    private void Start()
    {
        //anim = GetComponent<Animator>();
        //anim.SetBool("OpenBedawang", false);
    }

    public override void Interact()
    {
        int a = 0;
        int b = Inventory.instance.items.Count;

        for (int i = 0; i < b; i++)
        {
            if (Inventory.instance.items[i] == item)
            {
                a++;
            }
        }

        if (a >= neededAmount)
        {
            for (int i = 0; i <= b; i++)
            {
                if (Inventory.instance.have(item))
                {
                    Inventory.instance.Remove(item);
                }
            }

            Instan();
            //anim.SetBool("OpenBedawang", true);
            LvManager.SetActive(true);

            Debug.Log("go");
        }
        else
        {
            collectParticle.Stop();
            Debug.Log("nah");
        }
    }

    public void Instan()
    {
        Instantiate(Prefab, spawnPoint.position, spawnPoint.rotation);
        collectParticle.Play();
        colCutscene.SetActive(true);
        Instantiate(spawnvfx, Spawn.position, Spawn.rotation);
        Instantiate(Apsara, ApsaraRelic.position, ApsaraRelic.rotation);
    }
}