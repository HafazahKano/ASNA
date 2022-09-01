using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerSpawn : MonoBehaviour
{
    public GameObject Relic;
    public float xPos, zPos;
    public int relicCount;

    void Start()
    {
        StartCoroutine(RelicDrop());
    }

    IEnumerator RelicDrop()
    {
        while (relicCount < 1000)
        {
            xPos = Random.Range(301, 524);
            zPos = Random.Range(818, 582);

            Instantiate(Relic, new Vector3(xPos, 1.501f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);

            relicCount += 1;
        }
    }
}
