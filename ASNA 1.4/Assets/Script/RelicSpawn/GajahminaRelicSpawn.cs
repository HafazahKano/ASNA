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
            xPos = Random.Range(-719, -486);
            zPos = Random.Range(413, 746);

            Instantiate(Relic, new Vector3(xPos, -400, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);

            relicCount += 1;
        }
    }

}
