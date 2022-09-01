using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightAnim : MonoBehaviour
{
    private Animator anim;
    public float cooldownTime = 0.3f;
    private float nextFireTime = 0.5f;
    public static int noOfClick = 0;
    float lastClickedTime = 0;
    public float maxComboDelay = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.5f && anim.GetCurrentAnimatorStateInfo(0).IsName("hit1"))
        {
            anim.SetBool("hit1", false);
        }
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.5f && anim.GetCurrentAnimatorStateInfo(0).IsName("hit2"))
        {
            anim.SetBool("hit2", false);
        }
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.5f && anim.GetCurrentAnimatorStateInfo(0).IsName("hit3"))
        {
            anim.SetBool("hit3", false);
            noOfClick = 0;
        }
        

        if(Time.time - lastClickedTime > maxComboDelay)
        {
            noOfClick = 0;
        }
        
        if (Time.time > nextFireTime)
        {
            if (Input.GetMouseButtonDown(0))
            {
                OnClick();
            }
        }
        
    }

    void OnClick()
    {
        lastClickedTime = Time.time;
        noOfClick++;
        
        if(noOfClick == 1)
        {
            anim.SetBool("hit1", true);
        }
        noOfClick = Mathf.Clamp(noOfClick, 0, 3);

        if (noOfClick >= 2 && anim.GetNextAnimatorStateInfo(0).normalizedTime > 0.5f && anim.GetCurrentAnimatorStateInfo(0).IsName("hit1"))
        {

            anim.SetBool("hit2", true);
        }

        if (noOfClick >= 3 && anim.GetNextAnimatorStateInfo(0).normalizedTime > 0.5f && anim.GetCurrentAnimatorStateInfo(0).IsName("hit2"))
        {

            anim.SetBool("hit3", true);
            noOfClick = 0;
        }
    }
    
}
