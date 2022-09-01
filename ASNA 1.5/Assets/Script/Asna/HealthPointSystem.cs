using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPointSystem : MonoBehaviour
{
    public int MaxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;


    void Start()
    {
        currentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
    }



    public void HurtPlayer(int Damage)
    {
        currentHealth -= Damage;

        healthBar.SetHealth(currentHealth);
    }

    public void HealPlayer(int heal)
    {
        heal = 10;
        currentHealth += heal;

        if(currentHealth > MaxHealth)
        {
            currentHealth = MaxHealth;
        }
    }
}
