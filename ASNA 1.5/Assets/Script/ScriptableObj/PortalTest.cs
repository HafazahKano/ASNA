using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PortalTest : Interactable
{
    public GameObject Altar;
    public GameObject NPC;
    //public ParticleSystem darkParticle;
    public GameObject AltarActivated;
    public Transform spawn;
    public GameObject path;
    /*
    private void Start()
    {
        darkParticle.Play();
        Instantiate(darkParticle, spawn.position, spawn.rotation);
    }
    */

    public override void Interact()
    {
        base.Interact();
        
        Particle();
        Challenging();
    }

    void Particle()
    {
        //Destroy(darkParticle);
        //darkParticle.Stop();
        Debug.Log("matiin particle");
    }

    void Challenging()
    {
        FindObjectOfType<AudioManager>().Play("AsnaMonument");
        NPC.SetActive(true);
        Altar.SetActive(true);
        path.SetActive(true);
        Instantiate(AltarActivated, spawn.position, spawn.rotation);
        Destroy(this.gameObject);
        
    }


}
