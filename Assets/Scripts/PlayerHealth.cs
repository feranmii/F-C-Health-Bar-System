using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public HealthBarWidget healthBar;
    public HealthPointsWidget healthPoints;

    private int health;

    public int maxHealth = 100;

    
    public int Health
    {
        get => health;
        set
        {
            health = value;
            health = Mathf.Clamp(health, 0, maxHealth);

            if (health <= 0)
            {
                return;
            }

            if (healthBar != null)
            {
                healthBar.UpdateHealth(health, maxHealth);
            }
        }
    }

    private void Awake()
    {
        health = maxHealth;
        
        if(healthBar != null)
            healthBar.UpdateHealth(health, maxHealth);

        if (healthPoints != null)
        {
            healthPoints.Init(5);
            
        }
        
    }

    void Damage(int amount)
    {
        Health -= amount;
    }

    void Heal(int amount)
    {
        Health += amount;
    }

    [ContextMenu("Debug Damage")]
    void DebugDamage()
    {
        Damage(10);
    }

    [ContextMenu("Debug Heal")]
    void DebugHeal()
    {
        Heal(10);
    }
}