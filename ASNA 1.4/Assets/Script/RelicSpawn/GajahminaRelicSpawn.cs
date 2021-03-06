using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GajahminaRelicSpawn : MonoBehaviour
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
        while(relicCount < 5)
        {
            xPos = Random.Range(-874, -535);
            zPos = Random.Range(183, 630);

            Instantiate(Relic, new Vector3(xPos, -390, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);

            relicCount += 1;
        }
    }

}
