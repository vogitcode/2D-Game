using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth = 10;
    
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void Start()
    {
        slider.maxValue = maxHealth;
        slider.value = maxHealth;
        currentHealth = maxHealth;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        if (health >= 0)
        {
            currentHealth = health;
        }
        else
        {
            currentHealth = 0;
        }

        slider.value = currentHealth;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    public int GetHealth()
    {
        return this.currentHealth;
    }

    public void Damaged(int damage)
    {
        int health = this.GetHealth() - damage;
        this.SetHealth(health);
    }
}
