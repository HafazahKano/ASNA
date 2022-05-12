using UnityEngine;
using UnityEngine.UI;

public class CharacterStat : MonoBehaviour
{
    public int MaxHealth = 1000;
    public int currentHealth;

    public Stat damage;

    public HealthBar healthBar;

    private void Awake()
    {
        
    }

    private void Start()
    {
        currentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
    }

    private void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        Debug.Log(transform.name + "takes" + damage + "damage.");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        Debug.Log(transform.name + "died");
    }
}
