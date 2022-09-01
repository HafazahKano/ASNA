using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizBanggai : MonoBehaviour
{
    public GameObject quiz;
    public GameObject spawn;

    private void Awake()
    {
        quiz.SetActive(false);
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            spawn.SetActive(true);
            quiz.SetActive(false);
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
