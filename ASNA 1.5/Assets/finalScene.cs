using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalScene : MonoBehaviour
{
    public GameObject UI;
    public GameObject colCutscene;
    public int TimeToStop = 120;
    public GameObject bgm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            StartCoroutine(UIactivation());
            Debug.Log("masuk trigger");
        }

    }

    IEnumerator UIactivation()
    {
        yield return new WaitForSeconds(0);

        UI.SetActive(false);
        colCutscene.SetActive(true);
        Destroy(colCutscene, TimeToStop);
        bgm.SetActive(false);

        yield return new WaitForSeconds(120);

        
        SceneManager.LoadScene(0);
    }
}
