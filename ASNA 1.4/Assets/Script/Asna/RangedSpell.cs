using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedSpell : MonoBehaviour
{
    public GameObject Projectile;
    public GameObject selectedUnit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Spell();
        }
    }

    void Spell()
    {
        Vector3 SpawnSpellLoc = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);

        GameObject clone;
        clone = Instantiate(Projectile, SpawnSpellLoc, Quaternion.identity);
        clone.transform.GetComponent<RangedAttack>().Target = selectedUnit;
    }
}
