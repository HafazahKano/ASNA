using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public int MaxHealth = 40;
    public int currentHealth;
    public int PlayerHeal = 100;
    public GameObject prefab;
    public string audio;
    public HealthBar healthBar;


    private void Start()
    {
        currentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
    }

    private void Update()
    {
       
            PlayerStats e = this.transform.GetComponent<PlayerStats>();

            if (currentHealth <= 0)
            {
                e.Healing(PlayerHeal);
            Debug.Log("Heal Activated");
            }
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        Debug.Log(transform.name + "takes" + damage + "damage.");

        if (currentHealth <= 0)
        { 
            Instantiate(prefab, transform.position, transform.rotation);
           
            Destroy(gameObject);
            Die();
        }
    }

    public virtual void Die()
    {
        Debug.Log(transform.name + "died");
        FindObjectOfType<AudioManager>().Play(audio);
    }
}
