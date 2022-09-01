using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prolog : MonoBehaviour
{
    public GameObject colCutscene;
    public int TimeToStop = 84;
    public GameObject UI;
    public GameObject bgm;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(UIactivation());
        Destroy(colCutscene, TimeToStop);
    }

    IEnumerator UIactivation()
    {

        yield return new WaitForSeconds(84);

        UI.SetActive(true);
        bgm.SetActive(true);
    }
}
