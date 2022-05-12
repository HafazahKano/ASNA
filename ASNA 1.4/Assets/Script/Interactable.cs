using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    GameObject player;
    
    
    

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(player.transform.position, transform.position) < radius)
        {
            //notif.SetActive(true);

            if (Input.GetKeyDown(KeyCode.F))
            {
                Interact();
            }


            if (Input.GetMouseButtonDown(0))
            {
                Attack();
                Debug.Log("Nyerang");
            }

            Debug.Log("true");
        }
    }


    public virtual void Interact()
    {
        Debug.Log("Interacting with " + this.name);
    }

    public virtual void Attack()
    {
        Debug.Log("attacking with " + this.name);
    }

}
