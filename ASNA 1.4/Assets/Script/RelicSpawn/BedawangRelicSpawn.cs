﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedawangRelicSpawn : MonoBehaviour
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
        while (relicCount < 6)
        {
            xPos = Random.Range(107, -208);
            zPos = Random.Range(506, 136);

            Instantiate(Relic, new Vector3(xPos, -405, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);

            relicCount += 1;
        }
    }
}
