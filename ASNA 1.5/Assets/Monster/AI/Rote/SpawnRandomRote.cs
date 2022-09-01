using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomRote : MonoBehaviour
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
            xPos = Random.Range(622, 417);
            zPos = Random.Range(719, 267);

            Instantiate(Relic, new Vector3(xPos, -410, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.01f);

            relicCount += 1;
        }
    }
}
