using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomNeso : MonoBehaviour
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
        while (relicCount < 3)
        {
            xPos = Random.Range(169, -202);
            zPos = Random.Range(969, 671);

            Instantiate(Relic, new Vector3(xPos, -411, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.01f);

            relicCount += 1;
        }
    }
}
