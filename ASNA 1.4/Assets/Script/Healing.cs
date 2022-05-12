using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    public int Heal = 100;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        { 
            PlayerStats e = col.transform.GetComponent<PlayerStats>();

            if (e != null)
            {
                e.Healing(Heal);
                Destroy(gameObject);
            }

        }
    }

}
