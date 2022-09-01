using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomNabiru : MonoBehaviour
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
            xPos = Random.Range(507, 1054);
            zPos = Random.Range(-519, -110);

            Instantiate(Relic, new Vector3(xPos, -383, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.01f);

            relicCount += 1;
        }
    }
}
