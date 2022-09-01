using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomAI3 : MonoBehaviour
{
    public GameObject Relic;
    public int xPos, zPos;
    public int relicCount;

    void Start()
    {
        StartCoroutine(RelicDrop());
    }

    IEnumerator RelicDrop()
    {
        while (relicCount < 50)
        {
            xPos = Random.Range(243, -460);
            zPos = Random.Range(-269, -28);

            Instantiate(Relic, new Vector3(xPos, -407, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.01f);

            relicCount += 1;
        }
    }
}
