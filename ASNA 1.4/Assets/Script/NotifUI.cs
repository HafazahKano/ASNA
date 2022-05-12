using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NotifUI : MonoBehaviour
{
    public GameObject notif;

    private void Awake()
    {
        notif.SetActive(false);
    }

    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.F))
        {
            notif.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            notif.SetActive(true);
            
        }
        
    }

    private void OnTriggerExit()
    {
        notif.SetActive(false);
    }
}
