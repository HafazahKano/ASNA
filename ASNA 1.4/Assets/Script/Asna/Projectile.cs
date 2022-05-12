using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Vector3 hitPoint;
    public GameObject effect;
    public int speed;
    public int DamageAmount = 20;

    void Start()
    {
        this.GetComponent<Rigidbody>().AddForce((hitPoint - this.transform.position).normalized * speed);
    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "NPC")
        {
            GameObject neweffect = Instantiate(effect, this.transform.position, this.transform.rotation);
            neweffect.transform.parent = col.transform;
            Destroy(this.gameObject);

            Enemy e = col.transform.GetComponent<Enemy>();

            if(e != null)
            {
                e.TakeDamage(DamageAmount);
                return;
            }

        }
        else
        {
            Instantiate(effect, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
        Destroy(this.gameObject);
    }

}
