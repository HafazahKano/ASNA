using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarudaRelicSpawn : MonoBehaviour
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
            xPos = Random.Range(517, 803);
            zPos = Random.Range(436, 734);

            Instantiate(Relic, new Vector3(xPos, -400, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);

            relicCount += 1;
        }
    }
}
