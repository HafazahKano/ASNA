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
        while (relicCount < 4)
        {
            xPos = Random.Range(582, 1028);
            zPos = Random.Range(-459, -79);

            Instantiate(Relic, new Vector3(xPos, -382, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);

            relicCount += 1;
        }
    }
}
