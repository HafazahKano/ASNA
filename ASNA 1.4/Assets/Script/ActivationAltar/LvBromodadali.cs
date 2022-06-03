using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvBromodadali : MonoBehaviour
{
    public GameObject Item;

    public Animator anim;
     //Start is called before the first frame update
    void Start()
    {
        Item.SetActive(false);
        anim = GetComponent<Animator>();
        anim.SetBool("OpenBedawang", true);
    }

    // Update is called once per frame
    void Update()
    { 
        Item.SetActive(true);
        
    }
}
