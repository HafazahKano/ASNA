using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ProjectileShooting : MonoBehaviour
{
    public float cooldownSpeed;
    public float fireRate;
    private float accuracy;
    public float maxSpreadAngle;
    public float timeTillMaxSpread;
    //public float FOV;
    public float lookRadius;

    public GameObject bullet;
    public GameObject shootPoint;

    //Transform target;
    Transform target;

    GameObject closestEnemy;
    GameObject[] allEnemies;
    public float cooldown = 0.5f;
    public float nextShoot = 0;

    void Start()
    {
        //closestEnemy = null;
        

    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindWithTag("NPC").transform;


        float distance = Vector3.Distance(target.transform.position, transform.position);
        cooldownSpeed += Time.deltaTime * 60f;
        if (Input.GetMouseButtonDown(0))
        {

            accuracy += Time.deltaTime * 1f;

            if (cooldownSpeed >= fireRate)
            {
                findClosestEnemy();

                Vector3 dir = closestEnemy.transform.position - transform.position;
                Quaternion rot = Quaternion.LookRotation(dir);
                transform.rotation = rot;

                if(nextShoot < Time.time)
                {
                    Shoot();
                    nextShoot = cooldown + Time.time;
                }
                
            }
            

        }
    }

    void findClosestEnemy()
    {
        float disToClosestEnemy = Mathf.Infinity;
        closestEnemy = null;
        allEnemies = GameObject.FindGameObjectsWithTag("NPC");

        foreach (GameObject currentEnemy in allEnemies)
        {
            float disToEnemy = (currentEnemy.transform.position - this.transform.position).sqrMagnitude;

            if (disToEnemy < disToClosestEnemy)
            {
                disToClosestEnemy = disToEnemy;
                closestEnemy = currentEnemy;
            }
        }
        Debug.DrawLine(this.transform.position, closestEnemy.transform.position);
    }


    void Shoot()
    {
        FindObjectOfType<AudioManager>().Play("AsnaAttack");
        RaycastHit hit;
        Quaternion fireRotation = Quaternion.LookRotation(transform.forward);

        float currentSpeed = Mathf.Lerp(0.01f, maxSpreadAngle, accuracy / timeTillMaxSpread);

        fireRotation = Quaternion.RotateTowards(fireRotation, Random.rotation, Random.Range(0.0f, currentSpeed));

        if (Physics.Raycast(transform.position, fireRotation * Vector3.forward, out hit, Mathf.Infinity))
        {
            GameObject tempBullet = Instantiate(bullet, shootPoint.transform.position, fireRotation);
            tempBullet.GetComponent<Projectile>().hitPoint = hit.point;

        }

    }

}
