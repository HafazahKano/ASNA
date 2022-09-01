using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomSonda : MonoBehaviour
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
        while (relicCount < 4)
        {
            xPos = Random.Range(-463, -698);
            zPos = Random.Range(660, 494);

            Instantiate(Relic, new Vector3(xPos, -423, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.01f);

            relicCount += 1;
        }
    }
}
