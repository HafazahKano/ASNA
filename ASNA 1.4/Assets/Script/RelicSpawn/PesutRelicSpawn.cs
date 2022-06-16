using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PesutRelicSpawn : MonoBehaviour
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
            xPos = Random.Range(483, 1000);
            zPos = Random.Range(-507, -145);

            Instantiate(Relic, new Vector3(xPos, -360, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);

            relicCount += 1;
        }
    }
}
