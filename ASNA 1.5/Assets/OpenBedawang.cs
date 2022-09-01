using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBedawang : MonoBehaviour
{
    private Animator anim;
    public GameObject altar;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(altar == true)
        {
            anim.SetBool("OpenBedawang", true);
        }
    }
}
