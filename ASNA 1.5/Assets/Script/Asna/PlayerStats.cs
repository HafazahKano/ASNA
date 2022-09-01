using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int MaxHealth = 1000;
    public int currentHealth;

    public HealthBar healthBar;
    //public GameObject damageText;

    private void Start()
    {
        currentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        Debug.Log(transform.name + "takes" + damage + "damage.");

        //DamageIndicator indicator = Instantiate(damageText, transform.position, Quaternion.identity).GetComponent<DamageIndicator>();
        //indicator.SetDamage(damage);

        if (currentHealth <= 0)
        {
            Die();
            Destroy(gameObject);
        }
    }

    public void Healing(int heal)
    {
        currentHealth += heal;
        healthBar.SetHealth(currentHealth);
        Debug.Log(transform.name + "takes healing");

    }

    public virtual void Die()
    {
        Debug.Log(transform.name + " died");
        Pmanage.instance.KillPlayer();
    }
}
