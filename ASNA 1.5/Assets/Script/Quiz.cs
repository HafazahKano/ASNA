using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    public GameObject quiz;
    public GameObject efek;
    public GameObject nextCol;


    private void Awake()
    {
        quiz.SetActive(false);
    }

    
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            efek.SetActive(true);
            quiz.SetActive(false);
            nextCol.SetActive(true);
            Destroy(this.gameObject);
            Debug.Log("interact");
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            quiz.SetActive(true);
            Debug.Log("masuk trigger");
        }

    }

    private void OnTriggerExit()
    {
        quiz.SetActive(false);
    }
}
