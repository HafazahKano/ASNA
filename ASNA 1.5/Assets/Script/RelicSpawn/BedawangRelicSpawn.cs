using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedawangRelicSpawn : MonoBehaviour
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
            xPos = Random.Range(-171, 152);
            zPos = Random.Range(482, 90);

            Instantiate(Relic, new Vector3(xPos, -390, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);

            relicCount += 1;
        }
    }
}
