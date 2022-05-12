using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NagaRelicSpawn : MonoBehaviour
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
            xPos = Random.Range(-274, 58);
            zPos = Random.Range(-362, -96);

            Instantiate(Relic, new Vector3(xPos, -399, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);

            relicCount += 1;
        }
    }
}
