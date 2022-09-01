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
        while (relicCount < 5)
        {
            xPos = Random.Range(757, 406);
            zPos = Random.Range(410, 688);

            Instantiate(Relic, new Vector3(xPos, -320, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);

            relicCount += 1;
        }
    }
}
