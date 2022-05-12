using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideo : MonoBehaviour
{
    public GameObject cutscene;
    public GameObject UI;
    public int timeToStop;

    private void Awake()
    {
        cutscene.SetActive(false);
        UI.SetActive(true);
    }

    private void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            //Time.timeScale = 0f;
            cutscene.SetActive(true);
            UI.SetActive(false);
            Destroy(cutscene, timeToStop);
        }
    }

    
    private void OnTriggerExit(Collider other)
    {
        UI.SetActive(true);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
