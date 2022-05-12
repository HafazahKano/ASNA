using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent agent;
    public int DamageAmount = 5;
    public float cooldown = 0.5f;
    public float nextShoot = 0;

    Animator anim;

    private void Start()
    {
        target = Pmanage.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        //combat = GetComponent<CharacterCombat>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if(distance <= lookRadius)
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
            anim.SetBool("isAttack", false);
            agent.SetDestination(target.position);
            
        }
        if (distance <= agent.stoppingDistance)
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isIdle", false);
            anim.SetBool("isAttack", true);

            PlayerStats e = transform.GetComponent<PlayerStats>();

            if (e != null)
            {
                e.TakeDamage(DamageAmount);
            }

            //StartAttack();
        }
        if (distance >= lookRadius)
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isIdle", true);
            anim.SetBool("isAttack", false);
        }

    }

    /*
    private void StartAttack()
    {
        if(nextFireTime < Time.time)
        {
            Instantiate(enemyBullet, shootPoint.transform.position, transform.rotation);
            nextFireTime = cooldown + Time.time;
        }
    }
    */

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerStats e = col.transform.GetComponent<PlayerStats>();

            if (nextShoot < Time.time)
            {
                if (e != null)
                {
                    e.TakeDamage(DamageAmount);
                }
                nextShoot = cooldown + Time.time;
            }
            

        }
    }


void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
        anim.SetBool("isAttack", true);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
