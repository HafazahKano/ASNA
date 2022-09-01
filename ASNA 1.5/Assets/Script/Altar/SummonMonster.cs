using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonMonster : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject Prefab;
    public GameObject trigger;

    void OnTriggerEnter()
    {
        Instantiate(Prefab, spawnPoint.position, spawnPoint.rotation);
    }
}