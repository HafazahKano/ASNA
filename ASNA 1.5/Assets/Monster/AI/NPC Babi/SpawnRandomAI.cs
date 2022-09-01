using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomAI : MonoBehaviour
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
            xPos = Random.Range(781, -348);
            zPos = Random.Range(463, 889);

            Instantiate(Relic, new Vector3(xPos, -410, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.01f);

            relicCount += 1;
        }
    }
}
