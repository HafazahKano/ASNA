using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomCeleng : MonoBehaviour
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
        while (relicCount < 5)
        {
            xPos = Random.Range(-547, -507);
            zPos = Random.Range(-290, -389);

            Instantiate(Relic, new Vector3(xPos, -433, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.01f);

            relicCount += 1;
        }
    }
}
