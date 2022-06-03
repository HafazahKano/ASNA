using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvBromodadali : MonoBehaviour
{
    public GameObject Item;


    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("OpenBedawang", true);
        Item.SetActive(true);
    }
}
