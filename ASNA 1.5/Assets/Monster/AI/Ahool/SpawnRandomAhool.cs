using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomAhool : MonoBehaviour
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
            xPos = Random.Range(-390, 50);
            zPos = Random.Range(26, -285);

            Instantiate(Relic, new Vector3(xPos, -411, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.01f);

            relicCount += 1;
        }
    }
}
