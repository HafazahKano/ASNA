using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomBanggai : MonoBehaviour
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
        while (relicCount < 10)
        {
            xPos = Random.Range(774, 559);
            zPos = Random.Range(784, 653);

            Instantiate(Relic, new Vector3(xPos, -411, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.01f);

            relicCount += 1;
        }
    }
}
