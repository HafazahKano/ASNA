using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BromodadaliRandom : MonoBehaviour
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
            xPos = Random.Range(-320, 161);
            zPos = Random.Range(1028, 878);

            Instantiate(Relic, new Vector3(xPos, -401, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);

            relicCount += 1;
        }
    }
}
