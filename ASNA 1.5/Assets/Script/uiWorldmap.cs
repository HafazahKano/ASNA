using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiWorldmap : MonoBehaviour
{
    public static bool OpenMap = false;

    public GameObject UIMap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (OpenMap)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        UIMap.SetActive(false);
        Time.timeScale = 1f;
        OpenMap = false;
        //player.SetActive(true);
    }

    void Pause()
    {
        UIMap.SetActive(true);
        Time.timeScale = 0f;
        OpenMap = true;
        //player.SetActive(false);
    }
}
